using AAInfo.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AAInfo
{

    /*AAInfo  -Email- Version 1.0
    * Created: 10/23/2020
    * Updated: 10/23/2020
    * Designed by: Kevin Sherman at Acrelec America
    * Contact at: Kevin@Metadevdigital.com
    * 
    * Copyright Copyright MIT Liscenece  - Enjoy boys, keep updating without me. Fork to your hearts content
    */
    
    public class Email
    {
        public string fromAddr { get; set; }
        public string fromName { get; set; }
        public string toAddr { get; set; }
        public string hostAddr { get; set; }
        public bool ssl { get; set; }
        public int smtp { get; set; }
        private NetworkCredential details { get; set; }

        /// <summary>
        /// Default constructer for Email. Includes default information that is assumed based off of current usage of AAInfo
        /// </summary>
        public Email()
        {
            fromAddr = "noreply.acrelec@gmail.com";
            toAddr = "kevin@metadevdigital.com";
            hostAddr = "smtp.gmail.com";
            fromName = "No Reply from Acrelec America";
            ssl = true;
            smtp = 587;
            details = new NetworkCredential(fromAddr, Settings.Default.DPass);
        }

        /// <summary>
        /// Constructor for email which allows for a custom address to be set for the destination address
        /// </summary>
        /// <param name="to">String of address to be delievered to</param>
        public Email(string to)
        {
            fromAddr = "noreply.acrelec@gmail.com";
            toAddr = to;
            hostAddr = "smtp.gmail.com";
            fromName = "No Reply from Acrelec America";
            ssl = true;
            smtp = 587;
            details = new NetworkCredential(fromAddr, Settings.Default.DPass);
        }

        /// <summary>
        /// Constructor for email which allows for a custom TO email address and a custom FROM email address
        /// </summary>
        /// <param name="to">String of address to be delivered to</param>
        /// <param name="from">String of address to be delivered from</param>
        /// <param name="fromHeader">String of name of the email to be delivered from (shows in email header as FROM: So&so at EmailAddr: )</param>
        /// <param name="host">String of host address for FROM email</param>
        /// <param name="enableSSL">Bool of whether SSL is enabled for FROM email</param>
        /// <param name="smtpPort">Int of SMTP port number</param>
        /// <param name="pass">String of password for FROM email</param>
        public Email(string to, string from, string fromHeader, string host, bool enableSSL, int smtpPort, string pass)
        {
            fromAddr = from;
            toAddr = to;
            hostAddr = host;
            fromName = fromHeader;
            ssl = enableSSL;
            smtp = smtpPort;
            details = new NetworkCredential(from, pass);
        }

        /// <summary>
        /// Sends plaintext emails to the details setup in the email class construction
        /// </summary>
        /// <param name="body">String of plaintext body of email</param>
        /// <param name="subject">String of email subject</param>
        public void send(string body, string subject)
        {
            SmtpClient mailClient = new SmtpClient(hostAddr, smtp);
            MailMessage toSend = new MailMessage();

            toSend.From = new MailAddress(fromAddr, fromName);
            toSend.To.Add(new MailAddress(toAddr));
            toSend.Subject = subject;
            toSend.Body = body;
            toSend.IsBodyHtml = false;

            // Add a carbon copy recipient.
            //MailAddress copy = new MailAddress("ccAddr");
            //toSend.CC.Add(copy);

            mailClient.Credentials = details;
            mailClient.EnableSsl = ssl;
            mailClient.Send(toSend);

            mailClient.Dispose();
            toSend.Dispose();
        }

        /// <summary>
        /// TODO: Configure for HTML emails or to allow sending a list of addresses that would be CC'd
        /// </summary>
        public void sendHTML()
        {
            //TODO: Configure for HTML emails or to allow sending a list of addresses that would be CC'd
            throw new NotImplementedException();
        }
    }
}
