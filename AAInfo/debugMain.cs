using AAInfo.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*AAInfo  -debugMain- Version 1.0
* Created: 10/22/2020
* Updated: 10/22/2020
* Designed by: Kevin Sherman at Acrelec America
* Contact at: Kevin@Metadevdigital.com
* 
* Copyright Copyright MIT Liscenece  - Enjoy boys, keep updating without me. Fork to your hearts content
*/

/// <summary>
/// Main method for deubg
/// </summary>
namespace AAInfo
{
    class debugMain
    {
        // Main Method 
        static public void Main(String[] args)
        {
            //testDefaults();
            //testCustomErrorReporter();
            //testCustomInfoDisplayer();
            testBothCustom();
        }

        /// <summary>
        /// Test a custom InfoDisplayer with custom ErrorReporter class
        /// </summary>
        /// Info page says "AAInfo 1.0", "Metadev Digital", "for testing these dog-gone tests", "Not Apache 2.0"
        /// Email report has subject of AAInfo 2.0 Error Report, goes to Kevin1355@gmail.com, and is from noreply.acrelec@gmail.com
        /// </example>
        private static void testBothCustom()
        {
            ErrorReporter errorTest = new ErrorReporter("AAInfo 2.0", new Email("kevin1355@gmail.com"));
            InfoDisplayer test = new InfoDisplayer("AAInfo 1.0", "Metadev Digital", "Not Apache 2.0", "for testing these dog-gone test", errorTest);
            test.showForm();
        }

        /// <summary>
        /// Test a custom InfoDisplayer with default ErrorReporter class
        /// </summary>
        /// Info page says "AAInfo", "Metadev Digital", "for testing these dog-gone tests", "Not Apache 2.0"
        /// Email report has subject of AAInfo Error Report, goes to Kevin@Metadevdigital.com, and is from noreply.acrelec@gmail.com
        /// </example>
        private static void testCustomInfoDisplayer()
        {
            InfoDisplayer test = new InfoDisplayer("AAInfo", "Metadev Digital", "Not Apache 2.0", "for testing these dog-gone tests");
            test.showForm();
        }

        /// <summary>
        /// Test a custom ErrorReporter class independant of an InfoDisplayer
        /// </summary>
        /// <example>
        /// Email report has subject of AAInfo Test Error Report, goes to kevin1355@gmail.com, and is from noreplymetadevdigital@gmail.com
        /// </example>
        private static void testCustomErrorReporter()
        {
            ErrorReporter test = new ErrorReporter("AAInfo Test", new Email("kevin1355@gmail.com", "noreplymetadevdigital@gmail.com", "Metadev No Reply", "smtp.gmail.com", true, 587, Settings.Default.DebugPass));
            test.showForm();
        }

        /// <summary>
        /// Tests with default constructors
        /// </summary>
        /// <example>
        /// Info page says "This software", "Acrelec", "to fascillate our operations in a more streamlined manner", "MIT Licence"
        /// Email report has subject of Acrelec America Software Error Report, goes to Kevin@Metadevdigital.com, and is from noreply.acrelec@gmail.com
        /// </example>
        private static void testDefaults()
        {
            InfoDisplayer test = new InfoDisplayer();
            test.showForm();
        }
    }
}
