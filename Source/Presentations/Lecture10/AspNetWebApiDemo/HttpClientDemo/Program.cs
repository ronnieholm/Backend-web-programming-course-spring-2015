using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

// Key points:
// - Install Newtonsoft.Json from NuGet
// - HttpClient part of Pluralsight course has outdated code (working code below)

namespace HttpClientDemo
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static Uri PostExample(HttpClient c)
        {
            Person person = new Person { Name = "Jesper", Age = 22 };

            // notice how we set the Content-Type header on the actual content object and not
            // in the general HttpClient settings. This makes sense, because the Content-Type
            // may very with each request (JSON, XML, binary, ...), if we so desire.
            StringContent content = new StringContent(JsonConvert.SerializeObject(person), Encoding.UTF8, "application/json");
            HttpResponseMessage result = c.PostAsync("/api/person", content).Result;
            
            if (result.IsSuccessStatusCode)
            { 
                Uri newPersonUrl = result.Headers.Location;
                Console.WriteLine("New person url: " + newPersonUrl);
                return newPersonUrl;
            }
            else
            {
                Console.WriteLine("Error: " + result.StatusCode);
                return null;
            }
        }

        static Person GetSpecificExample(HttpClient c, Uri personUrl)
        {
            HttpResponseMessage response = c.GetAsync(personUrl.LocalPath).Result;
            if (response.IsSuccessStatusCode)
            {
                string s = response.Content.ReadAsStringAsync().Result;
                Person p = JsonConvert.DeserializeObject<Person>(s);
                Console.WriteLine("Name: " + p.Name + ", Age: " + p.Age);
                return p;
            }
            else
            {
                Console.WriteLine("Error: " + response.StatusCode);
                return null;
            }
        }

        static void PutExample(HttpClient c, Uri personUrl, Person person)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(person), Encoding.UTF8, "application/json");
            HttpResponseMessage result = c.PutAsync(personUrl.LocalPath, content).Result;

            if (result.IsSuccessStatusCode)
            {
                Console.WriteLine("Updated succesfully: " + result.StatusCode);
            }
            else
            {
                Console.WriteLine("Error: " + result.StatusCode);
            }
        }

        static void DeleteExample(HttpClient c, Uri personUrl)
        {
            HttpResponseMessage result = c.DeleteAsync(personUrl.LocalPath).Result;
            if (result.IsSuccessStatusCode)
            {
                Uri updatedPersonUrl = result.Headers.Location;
                Console.WriteLine("Deleted succesfully: " + result.StatusCode);
            }
            else
            {
                Console.WriteLine("Error: " + result.StatusCode);
            }
        }

        static void GetAllExample(HttpClient c)
        {
            HttpResponseMessage response = c.GetAsync("/api/person").Result;
            if (response.IsSuccessStatusCode)
            {
                string s = response.Content.ReadAsStringAsync().Result;
                Person[] people = JsonConvert.DeserializeObject<Person[]>(s);

                foreach (Person p in people)
                {
                    Console.WriteLine("Name: " + p.Name + ", Age: " + p.Age);
                }
            }
            else
            {
                Console.WriteLine("Error: " + response.StatusCode);
            }
        }

        static void Main(string[] args)
        {
            HttpClient c = new HttpClient();

            // used for all requests with this HttpClient instance
            // for Fiddler to intercept traffic from console app running on localhost
            c.BaseAddress = new Uri("http://localhost.fiddler:50064/");

            // for use during normal operation without Fiddler running
            //c.BaseAddress = new Uri("http://localhost.fiddler:50064/");
            c.DefaultRequestHeaders.Accept.Clear();
            c.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Uri newPersonUrl = PostExample(c);
            Person p = GetSpecificExample(c, newPersonUrl);

            p.Name = "Tine";
            PutExample(c, newPersonUrl, p);

            GetAllExample(c);

            DeleteExample(c, newPersonUrl);
        }
    }
}
