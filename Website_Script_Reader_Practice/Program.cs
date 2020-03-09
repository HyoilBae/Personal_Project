using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http;

namespace Website_Script_Reader_Practice
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //System.Net.WebClient wc = new System.Net.WebClient();
        //    ////byte[] raw = wc.DownloadData("https://www.glassdoor.com/Job/jobs.htm?suggestCount=0&suggestChosen=true&clickSource=searchBtn&typedKeyword=Software+Engineer+%2B+Software+Developer&sc.keyword=Software+Engineer+%2B+Software+Developer&locT=S&locId=3020&jobType=");
        //    ////string webData = System.Text.Encoding.UTF8.GetString(raw);
        //    //string webData = wc.DownloadString("https://www.glassdoor.com/Job/jobs.htm?suggestCount=0&suggestChosen=true&clickSource=searchBtn&typedKeyword=Software+Engineer+%2B+Software+Developer&sc.keyword=Software+Engineer+%2B+Software+Developer&locT=S&locId=3020&jobType=");
        //    //Console.WriteLine(webData);



        //}

        static async Task Main(string[] args)
        {
            using var client = new HttpClient();
            
        }



    }
}
