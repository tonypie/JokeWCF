using Data;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

namespace WebServices.AJAX
{
    [ServiceContract(Namespace = "")]
    public interface IJokeServiceAJAX
    {
        [OperationContract]
        [WebGet]
        void DoWork();

        [OperationContract]
        [WebGet]
        List<Joke> GetAllJokes();

        [OperationContract]
        [WebGet]
        Joke GetJoke(int jokeID);


        [OperationContract]
        [WebInvoke]
        Joke AddJoke(Joke joke);


        [OperationContract]
        [WebInvoke]
        Joke UpdateJoke(Joke joke);


        [OperationContract]
        [WebInvoke]
        void DeleteJoke(int jokeID);
    }
}