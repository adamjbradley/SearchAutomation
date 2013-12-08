using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Google.Apis.Services;

namespace SearchAutomation
{
    public class GoogleSearch
    {
        const string apiKey = "AIzaSyD9rrSqBWbwSn9HMPT9R_9oMIlro5eWVXs";
        const string cx = "000035349654863215211:z_zvh22vdei";        

        public GoogleSearch()
        {            
        }

        public CompanyDetails CompanySearch(string query)
        {
            var svc = new Google.Apis.Customsearch.v1.CustomsearchService(new BaseClientService.Initializer { ApiKey = apiKey });
            var listRequest = svc.Cse.List(query);

            listRequest.Cx = cx;
            var search = listRequest.Execute();

            CompanyDetails details = new CompanyDetails();
            foreach (var result in search.Items)
            {
                details.Domain = result.Link;                
                details.Confidence = 50;
                return details;
            }

            return details;
        }
    }
}
