using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
// !!!! aus einem alten VB6-Projekt übernommen !!!
// Nur das notwendigste angepasst!
// und ne Klasse drauss gemacht

public class clsCryptConnectionInfo
    {

    public enum eFileStatus : int
        {
        FileOk = 1,
        FileCorrupt = 2
        }

    

    private string pUsername;
    private string pPassword;
    private string pServer;
    private string pDatabase;
 
    /// <summary>
    /// Der Benutzername, mit dem die Verbindung zum DB-Server erfolgen soll.<para/>
    /// Das entspricht beim SqlConnectionStringBuilder dem Attribut: UserID
    /// </summary>
    public string Username
        {
        get
            {
            return pUsername;
            }
        set
            {
            pUsername = value;
            }
        }

    /// <summary>
    /// Das Kennwort, mit dem die Verbindung zum DB-Server erfolgen soll.<para/>
    /// Das entspricht beim SqlConnectionStringBuilder dem Attribut: Password
    /// </summary>
    public string Password
        {
        get
            {
            return pPassword;
            }
        set
            {
            pPassword = value;
            }
        }

    /// <summary>
    /// Der Datenbank-Server<para/>
    /// Das entspricht beim SqlConnectionStringBuilder dem Attribut: DataSource
    /// </summary>
    public string Server
        {
        get
            {
            return pServer;
            }
        set
            {
            pServer = value;
            }
        }

    /// <summary>
    /// Der Datenbankname<para/>
    /// Das entspricht beim SqlConnectionStringBuilder dem Attribut: InitialCatalog
    /// </summary>
    public string Database
        {
        get
            {
            return pDatabase;
            }
        set
            {
            pDatabase = value;
            }
        }

    // erzeugt eine Datei, in der die Properties versteckt abgelegt werden
    public void WriteToFile(string filename)
        {
        byte[] Bytearray = new byte[2000];
        int i = 0;
        int summe = 0;
        int start = 0;

        // Zufällig füllen
        Random rgen = new Random();
        for (i = 0; i < 2000; i++)
            {
            Bytearray[i] = (byte) rgen.Next(256);
            }

        // Servername verstecken 
        start = Bytearray[10] + 15;
        Bytearray[start] = (byte) pServer.Length;
        for (i = 1; i <= pServer.Length; i++)
            {
            Bytearray[start + i * 5] = (byte) Convert.ToChar(pServer.Substring(i - 1, 1));
            }
       
        // Datenbank verstecken 
        start = Bytearray[510] + 500 + 15;
        Bytearray[start] = (byte) pDatabase.Length;
        for (i = 1; i <=  pDatabase.Length; i++)
            {
            Bytearray[start + i * 5] = (byte) Convert.ToChar(pDatabase.Substring(i - 1, 1));
            }

        // Username verstecken 
        start = Bytearray[1010] + 1000 + 15;

        Bytearray[start] = (byte) pUsername.Length;
        for (i = 1; i <= pUsername.Length; i++)
            {
            Bytearray[start + i * 5] = (byte) Convert.ToChar(pUsername.Substring(i - 1, 1));
            }

        // Passwort verstecken 
        start = Bytearray[1510] + 1500 + 15;

        Bytearray[start] = (byte) pPassword.Length;
        for (i = 1; i <= pPassword.Length; i++)
            {
            Bytearray[start + i * 5] = (byte) Convert.ToChar(pPassword.Substring(i - 1, 1));
            }


        // Prüfsumme bilden
        summe = 0;
        for (i = 0; i < 2000; i++)
            {
            switch (i)
                {
                case 37:
                    break;
                case 537:
                    break;
                case 1037:
                    break;
                case 1537:
                    break;
                default:
                    summe = summe + Bytearray[i];
                    break;
                }
            }

        // Prüfsumme einspeichern
        Bytearray[1537] = (byte) (summe % 256);
        summe = summe / 256;
        Bytearray[1037] = (byte) (summe % 256);
        summe = summe / 256;
        Bytearray[537] = (byte) (summe % 256);
        summe = summe / 256;
        Bytearray[37] = (byte) summe;

        // File speichern
        File.WriteAllBytes(filename, Bytearray);

       
        }

    // liest aus einer Datei die versteckten Properties aus
    // wenn die Datei manipuliert wurde, wird eine eigene Exception
    // (FileIsCorruptExeption) geworfen
    public void ReadFromFile(string filename)
        {
        byte[] Bytearray = new byte[2000];
        int i = 0;
        int start = 0;

        // File öffnen
        Bytearray = File.ReadAllBytes(filename);

        // Test ob File korrupt
        if (CheckFile(filename) == eFileStatus.FileCorrupt)
            {
            throw new FileIsCorruptException(filename);
            }

        // Servername auslesen 
        pServer = "";
        start = Bytearray[10] + 15;

        for (i = 1; i <= Bytearray[start]; i++)
            {
            pServer += (char)(Bytearray[start + i * 5]);
            }

        // Datenbank auslesen 
        pDatabase = "";
        start = Bytearray[510] + 500 + 15;

        for (i = 1; i <= Bytearray[start]; i++)
            {
            pDatabase += (char)(Bytearray[start + i * 5]);
            }

        // Username auslesen 
        pUsername = "";
        start = Bytearray[1010] + 1000 + 15;

        for (i = 1; i <= Bytearray[start]; i++)
            {
            pUsername += (char)(Bytearray[start + i * 5]);
            }

        // Passwort auslesen 
        pPassword = "";
        start = Bytearray[1510] + 1500 + 15;

        for (i = 1; i <= Bytearray[start]; i++)
            {
            pPassword += (char)(Bytearray[start + i * 5]);
            }

        }

    // Testet, ob die Datei manipuliert wurde
    // liefert eFileStatus (FileOk/FileCorrupt) zurück
    public static eFileStatus CheckFile(string filename)
        {
        byte[] Bytearray = new byte[3072];
        int i = 0;
        int summe = 0;
        int pruefzahl = 0;

        // File öffnen
        Bytearray = File.ReadAllBytes(filename);

        // Prüfsumme bilden
        summe = 0;
        for (i = 0; i < 2000; i++)
            {
            switch (i)
                {
                case 37:
                    break;
                case 537:
                    break;
                case 1037:
                    break;
                case 1537:
                    break;
                default:
                    summe = summe + Bytearray[i];
                    break;
                }
            }

        pruefzahl = Bytearray[37];
        pruefzahl = pruefzahl * 256 + Bytearray[537];
        pruefzahl = pruefzahl * 256 + Bytearray[1037];
        pruefzahl = pruefzahl * 256 + Bytearray[1537];

        if (pruefzahl == summe)
            {
            return eFileStatus.FileOk;
            }
        else
            {
            return eFileStatus.FileCorrupt;
            }
        }


     }

class FileIsCorruptException : ApplicationException
    {
    // Erklärung: Der Konstruktor ruft den Konstruktor der übergeordneten Klasse auf (super() in Java) 
    public FileIsCorruptException(string Filename)
        : base("Die Datei " + Filename + " wurde manipuliert")
        {
        // falls noch was zu machen wäre
        }
  
    }
