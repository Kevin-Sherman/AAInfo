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

        /// <summary>
        /// Default constructor of InfoDisplayer
        /// Fills fields with pretty generic information that is assumed based off of the projects this has been associated with thusfar.
        /// </summary>
        public InfoDisplayer()
        {
            toolName = "This software";
            companyName = "Acrelec";
            toolLicence = "MIT Licence";
            toolDesc = "help fascilitate our operations in a streamlined manner";
            aboutForm = new frmAbout();
        }

        /// <summary>
        /// InfoDisplayer constructor that allows for custom variables.
        /// Catches an improperly configured attempt at construction, throwing a special error message but continuing function.
        /// NOTE: THESE ARE POPULATED MANUALLY
        /// ORDER IS IMPORTANT AND MUST BE RESEPCTED
        /// </summary>
        /// <param name="descriptors">String[4] {"Software name", "Company Name", "Software Licence Type", "Software Description"}</param>
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

        /// <summary>
        /// Formats the text and displays the dialog box
        /// Used to interface with a constructed InfoDisplayer
        /// </summary>
        public void showForm()
        {
            formatText();
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Gets default text (string[]) and keys(string[]) from aboutForm, references what was input during construction (string[4]), and formats
        /// the text by itterating through all string[]'s and calling replaceFields() to actually replace
        /// </summary>
        private void formatText()
        {
            string[] transformText = aboutForm.getText();
            string[] replaceKeys = aboutForm.getTextKeys();
            string[] descriptors = new string[] { toolName, companyName, toolDesc, toolLicence  };

            for (int j = 0; j < transformText.Length; j++)
            {
                for (int i=0; i<descriptors.Length; i++)
                {
                    transformText[j] = replaceFields(transformText[j], replaceKeys[i], descriptors[i]);
                }
            }

            aboutForm.setText(transformText);
        }

        /// <summary>
        /// Checkes a string for the existance of a key, if found it is replaced with differeing formatting depending on key that was sent
        /// 
        /// NOTE: The text sent in is encapsulated in "<<"&">>". This is setup by default from where the strings originated.
        /// The final step of processing this text will add special formatting depending on the encapsulating characters
        /// BOLD = "|"
        /// </summary>
        /// <param name="original">Original string</param>
        /// <param name="key">Key that will be searched for and replaced, if found</param>
        /// <param name="replacer">Text that the key will be replaced with, if found</param>
        /// <returns>Original string with the key replaced with the replacer text, if found</returns>
        private static string replaceFields(string original, string key, string replacer)
        {
            if (original.IndexOf(key)>=0)
            {
                if (key == "<<DESC>>")
                {
                    return original.Replace(key, replacer);
                }
                else
                {
                    return original.Replace(key, "|" + replacer + "|");
                }
            }
            else
            {
                return original;
            }
        }
    }
}
