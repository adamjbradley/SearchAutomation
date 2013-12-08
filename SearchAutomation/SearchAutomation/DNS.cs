using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAutomation
{
    public class DNS
    {
        public enum Companies
        {
            Google,
            Microsoft,
            Unknown
        }

        public enum MaileXchangers
        {
            Postini,
            Exchange,
            ExchangeOnline,
            Sendmail,
            Postfix,
            Unknown
        }

        public bool hasGoogleService { get; set; }
        public bool hasMicrosoftService { get; set; }

        public MaileXchangers MailServer { get; set; }
        public Companies Company { get; set; }

        public string MX { get; set; }
        public string TXT { get; set; }        
    }
}
