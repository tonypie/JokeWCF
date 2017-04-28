using Data;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

namespace WebServices.REST
{
    [ServiceContract(Namespace = "")]
    public interface IJokeServiceREST
    {
        [OperationContract]
        [WebGet(UriTemplate = "/Jokes")]
        List<Joke> GetAllJokes();

        [OperationContract]
        [WebGet(UriTemplate = "/Joke/{jokeId}")]
        Joke GetJoke(string jokeID);


        [OperationContract]
        [WebInvoke(Method ="POST", UriTemplate ="/Jokes")]
        Joke AddJoke(Joke joke);


        [OperationContract]
        [WebInvoke(Method ="PUT", UriTemplate ="/Joke")]
        void UpdateJoke(Joke joke);


        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/Joke/{jokeId}")]
        void DeleteJoke(string jokeID);
    }
}