using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAInfo
{
    /*AAInfo  -InfoDisplayer- Version 1.0
    * Created: 10/22/2020
    * Updated: 10/23/2020
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
        /// Creates an about form using the default constructor, which allows the form to create its own default ErrorReporter rather than handling it inside this class
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
        /// InfoDisplayer constructor for customizable about screens
        /// Creates an about form using the frmAbout(ErrorReporter) constructor allowing the insertion of the custom software name but default email settings
        /// </summary>
        /// <param name="software">String of software name</param>
        /// <param name="company">String of company name</param>
        /// <param name="licence">String of licence type</param>
        /// <param name="desc">String of software description</param>
        public InfoDisplayer(string software, string company, string licence, string desc)
        {
            toolName = software;
            companyName = company;
            toolLicence = licence;
            toolDesc = desc;
            aboutForm = new frmAbout(new ErrorReporter(software));
        }

        /// <summary>
        /// InfoDisplayer constructor for customizable about screens and a preconstructed ErrorReporter for custom email settings
        /// </summary>
        /// <param name="software">String of software name</param>
        /// <param name="company">String of company name</param>
        /// <param name="licence">String of licence type</param>
        /// <param name="desc">String of software description</param>
        /// <param name="error">Preconstructed ErrorReporter that was made with the non-default constructor</param>
        public InfoDisplayer(string software, string company, string licence, string desc, ErrorReporter error)
        {
            toolName = software;
            companyName = company;
            toolLicence = licence;
            toolDesc = desc;
            aboutForm = new frmAbout(error);
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
        /// the text by itterating through all string[]'s and calling replaceFields() to actually replace.
        /// 
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
