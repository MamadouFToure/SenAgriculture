using AppSenAgriculture.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security; // Ajout de cette directive using

namespace AppSenAgriculture.Helper
{
    public static class Utils
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TitreErreur"></param>
        /// <param name="erreur"></param>
        public static void WriteDataError(string TitreErreur, string erreur)
        {
            BdSenAgricultureContext db = new BdSenAgricultureContext();
            try
            {
                Td_Erreur log = new Td_Erreur();
                log.DateErreur = DateTime.Now;
                log.DescriptionErreur = erreur.Length > 2000 ? erreur.Substring(0, 2000) : erreur;
                log.TitreErreur = TitreErreur;
                db.td_Erreurs.Add(log);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                WriteLogSystem(ex.ToString(), "WriteDataError");
            }
        }

        /// <summary>
        /// logger les erreurs sur un fichier 
        /// </summary>
        /// <param name="message"></param>
        public static void WriteFileError(string message)
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, "Error", "erreur.txt");
                System.IO.TextWriter writeFile = new StreamWriter(path, true);
                writeFile.WriteLine("" + DateTime.Now);
                writeFile.WriteLine(message);
                writeFile.WriteLine("---------------------------------------------------------------------------------------");
                writeFile.Flush();
                writeFile.Close();
                writeFile = null;
            }
            catch (IOException e)
            {
                WriteLogSystem(e.ToString(), "WriteFileError");
            }
        }

        /// <summary>
        /// Permet de logger les erreurs au niveau du systeme d'exploitation
        /// </summary>
        /// <param name="erreur"></param>
        /// <param name="libelle"></param>
        public static void WriteLogSystem(string erreur, string libelle)
        {
            const string source = "SenAgriculture";
            const string logName = "Application";
            string message = $"date: {DateTime.Now}, libelle: {libelle}, description {erreur}";

            try
            {
                try
                {
                    // Tentative prudente de créer la source si elle n'existe pas.
                    if (!EventLog.SourceExists(source))
                    {
                        var data = new EventSourceCreationData(source, logName);
                        EventLog.CreateEventSource(data); // nécessite privilèges administrateur
                    }
                }
                catch (SecurityException) { /* permissions insuffisantes -> fallback */ }
                catch (UnauthorizedAccessException) { /* idem -> fallback */ }
                catch (Exception) { /* autre échec -> fallback */ }

                // Si la source existe, écrire dans l'EventLog
                if (EventLog.SourceExists(source))
                {
                    EventLog.WriteEntry(source, message, EventLogEntryType.Information, 101, 1);
                    return;
                }
            }
            catch (Exception)
            {
                // Si quelque chose de non prévu échoue, on passe au fallback
            }

            // Fallback : écrire dans un fichier local fiable
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Error", "event_fallback.txt");
                Directory.CreateDirectory(Path.GetDirectoryName(path));
                File.AppendAllText(path, message + Environment.NewLine + new string('-', 80) + Environment.NewLine);
            }
            catch
            {
                // Rien de plus à faire : éviter de lancer une exception depuis le logger
            }
        }

    }
}
