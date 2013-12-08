using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAutomation
{
    public class CompanyDetails
    {
        private string domain = null;
        private int confidence = 0;
        private DNS dns = null;

        public string Domain {
            get { return domain; } 
            set {
                string tempdomain = value;
                if (tempdomain.Contains(@"https://"))
                    tempdomain = tempdomain.Replace(@"https://", "");
                else if (tempdomain.Contains(@"http://"))
                    tempdomain = tempdomain.Replace(@"http://", "");
                tempdomain = tempdomain.Substring(0, tempdomain.IndexOf("/"));
                domain = tempdomain;               
            }
        }

        public int Confidence { get; set; }

        public DNS DNS
        {
            get { return dns; } 
            set { dns = value; }
        }
    }
}
