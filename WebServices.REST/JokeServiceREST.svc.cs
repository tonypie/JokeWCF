using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WebServices.REST
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class JokeServiceREST : IJokeServiceREST
    {
        private JokesDatabase jd;

        public JokeServiceREST()
        {
            jd = new JokesDatabase();
        }

        // To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
        // To create an operation that returns XML,
        //     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
        //     and include the following line in the operation body:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
        public List<Joke> GetAllJokes()
        {

            // Add your operation implementation here
            return jd.GetAllJokes();
        }

        public Joke GetJoke(string jokeID)
        {
            int parsedJokeId;
            parsedJokeId = Int32.Parse(jokeID);
            return jd.GetJoke(parsedJokeId);
        }

        public Joke AddJoke(Joke joke)
        {
            return jd.AddJoke(joke);
        }

        public void UpdateJoke(Joke joke)
        {
            jd.UpdateJoke(joke);
        }

        public void DeleteJoke(string jokeID)
        {
            int parsedJokeId;
            parsedJokeId = Int32.Parse(jokeID);
            jd.DeleteJoke(parsedJokeId);
        }
        // Add more operations here and mark them with [OperationContract]
    }
}

