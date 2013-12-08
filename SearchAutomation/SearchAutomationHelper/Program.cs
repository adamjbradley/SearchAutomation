using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SearchAutomation;

namespace SearchAutomationHelper
{
    class Program
    {                
        static void Main(string[] args)
        {
            List<string> unknown = new List<string>();
            unknown.Add("\"3M Singapore Pte Ltd\" Singapore");
            unknown.Add("\"3M Thailand Company Limited\" Thailand");
            unknown.Add("\"7 Eleven Stores Pty Ltd\" Australia");
            
            foreach (string query in unknown) {

                BingSearch bs = new BingSearch();
                List<CompanyDetails> cd = bs.CompanySearch(query);
                



                
            }
        }
    }
}
