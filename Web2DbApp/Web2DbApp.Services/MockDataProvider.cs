using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Web2DbApp.Entities;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Web2DbApp.Services
{
    /// <summary>
    /// Mockdataprovider used for calling apis to get mock data
    /// </summary>
    public class MockDataProvider
    {
        /// <summary>
        /// Api url + key.
        /// </summary>
        private static string url = "https://randomapi.com/api/hcoej702?key=QU1X-NS9T-AICO-U8YJ";

        /// <summary>
        /// Calls api for a list of random people names and titles.
        /// </summary>
        /// <param name="amount">Number of people to call for.</param>
        /// <returns>Returns list of people.</returns>
        public List<Person> GetPeople(int amount)
        {
            Validtor validtor = new Validtor();
            Results results;
            List<Person> persons = new List<Person>();
            while (amount > 0)
            {
                using (var client = new WebClient())
                {
                    string response;
                    if (amount > 10)
                    {
                        response = client.DownloadString(url + $"&noinfo&results=10");
                    }
                    else
                    {
                        response = client.DownloadString(url + $"&noinfo&results={amount}");
                    }
                    results = JsonConvert.DeserializeObject<Results>(response);
                }
                foreach (Person p in results.results)
                {
                    if (validtor.ValidPerson(p.Firstname,p.Lastname,p.TitleOfCountesey))
                    {
                        persons.Add(p);
                    }

                }
                amount -= 10;
            }
            if (persons.Count != 0)
            {
                return persons;
            }
            else
            {
                return null;
            }
        }
    }
}
