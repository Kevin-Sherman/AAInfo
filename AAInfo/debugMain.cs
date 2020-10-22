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
            InfoDisplayer test = new InfoDisplayer();

            test.showForm();
        }
    }
}
