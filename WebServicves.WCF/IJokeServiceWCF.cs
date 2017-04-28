using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServicves.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IJokeServiceWCF
    {
        [OperationContract]
        Joke GetJoke(int jokeID);

        [OperationContract]
        List<Joke> GetAllJokes();

        [OperationContract]
        Joke AddJoke(Joke joke);

        [OperationContract]
        Joke UpdateJoke(Joke joke);

        [OperationContract]
        void DeleteJoke(int jokeID);
    }
}
