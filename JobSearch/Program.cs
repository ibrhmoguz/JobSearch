using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var urlList = new List<string>
            {
                "https://www.reed.co.uk/jobs/jobs-in-united-kingdom?keywords=.NET&contract=True&datecreatedoffset=Today",
                "https://www.reed.co.uk/jobs/jobs-in-united-kingdom?keywords=C%23&contract=True&datecreatedoffset=Today",
                "https://www.reed.co.uk/jobs/jobs-in-united-kingdom?keywords=ASP.NET+Core&contract=True&datecreatedoffset=Today",
                "https://www.reed.co.uk/jobs/jobs-in-united-kingdom?keywords=biztalk&contract=True&datecreatedoffset=Today",
                "https://www.reed.co.uk/jobs/jobs-in-united-kingdom?keywords=angular&contract=True&datecreatedoffset=Today",
                "https://www.cwjobs.co.uk/jobs/contract/net/in-uk?q=.NET&postedwithin=1",
                "https://www.cwjobs.co.uk/jobs/contract/net/in-uk?q=C%23&postedwithin=1",
                "https://www.cwjobs.co.uk/jobs/contract/net/in-uk?q=Angular&postedwithin=1",
                "https://www.cwjobs.co.uk/jobs/contract/net/in-uk?q=biztalk&postedwithin=1",
                "https://www.cwjobs.co.uk/jobs/contract/net/in-uk?q=ASP.NET+Core&postedwithin=1",
                "https://www.cv-library.co.uk/search-jobs?q=C%23&geo=UK&distance=15&salarymin=&salarymax=&salarytype=annum&posted=1&industry=&tempperm=Contract&order=",
                "https://www.cv-library.co.uk/search-jobs?q=.Net&geo=UK&distance=15&salarymin=&salarymax=&salarytype=annum&posted=1&industry=&tempperm=Contract&order=",
                "https://www.cv-library.co.uk/search-jobs?q=Angular&geo=UK&distance=15&salarymin=&salarymax=&salarytype=annum&posted=1&industry=&tempperm=Contract&order=",
                "https://www.cv-library.co.uk/search-jobs?q=ASP.NET+Core&geo=UK&distance=15&salarymin=&salarymax=&salarytype=annum&posted=1&industry=&tempperm=Contract&order=",
                "https://www.cv-library.co.uk/search-jobs?q=Biztalk&geo=UK&distance=15&salarymin=&salarymax=&salarytype=annum&posted=1&industry=&tempperm=Contract&order=",
                "https://www.linkedin.com/jobs/search/?f_E=3%2C4&f_JT=C&f_TP=1&keywords=c%23&location=United%20Kingdom&locationId=gb%3A0",
                "https://www.linkedin.com/jobs/search/?f_E=3%2C4&f_JT=C&f_TP=1&keywords=.NET&location=United%20Kingdom&locationId=gb%3A0",
                "https://www.linkedin.com/jobs/search/?f_E=3%2C4&f_JT=C&f_TP=1&keywords=Angular&location=United%20Kingdom&locationId=gb%3A0",
                "https://www.linkedin.com/jobs/search/?f_E=3%2C4&f_JT=C&f_TP=1&keywords=ASP.NET+Core&location=United%20Kingdom&locationId=gb%3A0",
                "https://www.linkedin.com/jobs/search/?f_E=3%2C4&f_JT=C&f_TP=1&keywords=Biztalk&location=United%20Kingdom&locationId=gb%3A0"
            };
            Process.Start("chrome.exe", " /new-window " + string.Join(" ", urlList));
        }
    }
}
