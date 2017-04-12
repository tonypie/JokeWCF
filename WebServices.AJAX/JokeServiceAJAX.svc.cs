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
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class JokeServiceAJAX : IJokeServiceAJAX
    {
        private JokeServiceAJAX _client;

        public JokeServiceAJAX()
        {
            _client = new JokeServiceAJAX();
        }

        public int AddJoke(Joke joke)
        {
            return ((IJokeServiceAJAX)_client).AddJoke(joke);
        }

        public void DeleteJoke(int jokeID)
        {
            ((IJokeServiceAJAX)_client).DeleteJoke(jokeID);
        }

        // To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
        // To create an operation that returns XML,
        //     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
        //     and include the following line in the operation body:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
        [OperationContract]
        [WebGet]
        public List<Joke> GetAllJokes()
        {
            
            // Add your operation implementation here
            return _client.GetAllJokes();
        }

        public Joke GetJoke(int jokeID)
        {
            return ((IJokeServiceAJAX)_client).GetJoke(jokeID);
        }

        public void UpdateJoke(Joke joke)
        {
            ((IJokeServiceAJAX)_client).UpdateJoke(joke);
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
