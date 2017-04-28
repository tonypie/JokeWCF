using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using Data;

namespace WebServices.AJAX
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class JokeServiceAJAX : IJokeServiceAJAX
    {
        private JokesDatabase jd;

        public JokeServiceAJAX()
        {
            jd = new JokesDatabase();
        }

        public void DoWork()
        { return; }

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

        public Joke GetJoke(int jokeID)
        {
            return jd.GetJoke(jokeID);
        }

        public Joke AddJoke(Joke joke)
        {
            return jd.AddJoke(joke);
        }

        public Joke UpdateJoke(Joke joke)
        {
            return jd.UpdateJoke(joke);
        }

        public void DeleteJoke(int jokeID)
        {
            jd.DeleteJoke(jokeID);
        }
        // Add more operations here and mark them with [OperationContract]
    }
}
