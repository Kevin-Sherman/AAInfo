using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AAInfo
{

    /*AAInfo  -ErrorReporter- Version 1.0
    * Created: 10/22/2020
    * Updated: 10/22/2020
    * Designed by: Kevin Sherman at Acrelec America
    * Contact at: Kevin@Metadevdigital.com
    * 
    * Copyright Copyright MIT Liscenece  - Enjoy boys, keep updating without me. Fork to your hearts content
    */

    class ErrorReporter
    {
        private string software, from, to, fromHost;
        private int fromSMTP;
        private bool customEmail, fromSSL;
        private NetworkCredential networkCredential;
        private frmMail mailForm;
        public ErrorReporter()
        {
            to = "kevin@metadevdigital.com";
            software = "Acrelec America Software";
            customEmail = false;
            mailForm = new frmMail();
        }

        public ErrorReporter(string softwareName)
        {
            to = "kevin@metadevdigital.com";
            software = softwareName;
            customEmail = false;
            mailForm = new frmMail();
        }

        public ErrorReporter(string softwareName, string toAddr)
        {
            to = toAddr;
            software = softwareName;
            customEmail = false;
            mailForm = new frmMail();
        }

        public ErrorReporter(string softwareName, string toAddr, string fromAddr, string host, int SMTP, bool SSL, NetworkCredential deets)
        {
            to = toAddr;
            software = softwareName;
            customEmail = true;
            from = fromAddr;
            fromHost = host;
            fromSMTP = SMTP;
            fromSSL = SSL;
            networkCredential = deets;
            mailForm = new frmMail();
        }
    }
}
