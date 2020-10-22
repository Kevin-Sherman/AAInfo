using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAInfo
{
    /*AAInfo  -InfoDisplayer- Version 1.0
    * Created: 10/22/2020
    * Updated: 10/22/2020
    * Designed by: Kevin Sherman at Acrelec America
    * Contact at: Kevin@Metadevdigital.com
    * 
    * Copyright Copyright MIT Liscenece  - Enjoy boys, keep updating without me. Fork to your hearts content
    */

    public class InfoDisplayer
    {
        private string toolName, companyName, toolLicence, toolDesc;
        private frmAbout aboutForm;

        public InfoDisplayer()
        {
            toolName = "This software";
            companyName = "Acrelec";
            toolLicence = "MIT Licence";
            toolDesc = "help fascilitate our operations in a streamlined manner";
            aboutForm = new frmAbout();
        }

        public InfoDisplayer(string[] descriptors)
        {
            try
            {
                toolName = descriptors[0];
                companyName = descriptors[1];
                toolLicence = descriptors[2];
                toolDesc = descriptors[3];
                aboutForm = new frmAbout();
            }
            catch (IndexOutOfRangeException)
            {
                toolName = "This software";
                companyName = "Acrelec";
                toolLicence = "MIT Licence";
                toolDesc = "help fascilitate our operations in a streamlined manner";
                aboutForm = new frmAbout();
                MessageBox.Show("There was an issue handling your request. An error occured - AAINFO-ID1. Please log this error and send a report.", "Error: AAInfo-ID1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void showForm()
        {
            formatText();
            aboutForm.ShowDialog();
        }

        private void formatText()
        {
            
        }


        ///// <summary>
        ///// The main entry point for the application.
        ///// </summary>
        //[STAThread]
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new frmAbout());
        //}
    }
}
