using System;
using RESTTestConsoleApp.Transports;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace RESTTestConsoleApp.DataServices
{
    public class JokeDataService
    {
        public JokeDataService()
        {
            //_client = new JokeServiceWCFClient();
        }

        public Joke GetJoke(int jokeID)
        {
            WebClient wc = new WebClient();
            string s = wc.DownloadString("http://localhost:52838/JokeServiceREST.svc/Joke/" + jokeID);
            XmlSerializer x = new XmlSerializer(typeof(Joke));

            Joke resultObject;

            using (var stream = new MemoryStream(Encoding.ASCII.GetBytes(s)))
            {
                resultObject = (Joke)x.Deserialize(stream);
            }

            return resultObject;
        }

        public List<Joke> GetAllJokes()
        {
            WebClient wc = new WebClient();
            string s = wc.DownloadString("http://localhost:52838/JokeServiceREST.svc/Jokes");
            XmlSerializer x = new XmlSerializer(typeof(List<Joke>));

            List<Joke> resultObject;

            using (var stream = new MemoryStream(Encoding.ASCII.GetBytes(s)))
            {
                resultObject = (List<Joke>)x.Deserialize(stream);
            }

            return resultObject;
        }

        public Joke AddJoke(Joke joke)
        {
            return SendPunToServer("http://localhost:52838/JokeServiceREST.svc/Jokes", "POST", joke);
        }

        private Joke SendPunToServer(string endpoint, string method, Joke joke)
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp(endpoint);
            request.Method = method;
            request.Accept = "application/json";
            request.ContentType = "application/json";

            var serializer = new DataContractJsonSerializer(typeof(Joke));

            using (var requestStream = request.GetRequestStream())
            {
                serializer.WriteObject(requestStream, new Joke() { Title = joke.Title, JokeText = joke.JokeText });
            }

            var response = request.GetResponse();

            Joke responseObject;

            using (var responseStream = response.GetResponseStream())
            {
                responseObject = (Joke)serializer.ReadObject(responseStream);
            }

            return responseObject;
        }

        public Joke UpdateJoke(Joke joke)
        {
            return SendPunToServer("http://localhost:52838/JokeServiceREST.svc/Jokes", "PUT", joke);
        }

        public void DeleteJoke(int jokeID)
        {
            throw new NotImplementedException();
        }


    }
}

