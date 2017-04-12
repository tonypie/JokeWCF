using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WebServices.AJAX
{
    [ServiceContract]
    public interface IJokeServiceAJAX
    {
        [OperationContract]
        Joke GetJoke(int jokeID);

        [OperationContract]
        List<Joke> GetAllJokes();

        [OperationContract]
        int AddJoke(Joke joke);

        [OperationContract]
        void UpdateJoke(Joke joke);

        [OperationContract]
        void DeleteJoke(int jokeID);
    }
}
