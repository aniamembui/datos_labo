using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO ;
using System.Net;
using System.Net.Mail;

namespace metodos
{
    public class funciones
    {
        public static string add_alarm(string ruta_arch, string alarma)
        {
            try
            {
                File.AppendAllText(ruta_arch, alarma );
                return "OK";
            }
            catch ( Exception e)
            {
                return e.ToString();
            }
         }



        public static bool Send_email_from_gmail(string From, string To, string Subject, string ruta_arch)
        { 
            try
            {
                string texto = File.ReadAllText( ruta_arch );

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress( From );
                string[] emailList = File.ReadAllLines(To);
                foreach (string eml in emailList)
                    {
                      mail.To.Add(eml); 
                    }
                //mail.To.Add(To);
                mail.Subject = Subject ;
                mail.Body = texto ;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential( </*hardcoded GMAIL account */ >, </* hardcoded GMAIL account password*/> );
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                //MessageBox.Show("mail Send");
                return true;

            }
            catch (Exception ex)
            {
                //lineas para debugeo
                ///string error = (ex.ToString());
                ///File.AppendAllText( ruta_arch , error);
                return false;
            }
        }

    }
}
