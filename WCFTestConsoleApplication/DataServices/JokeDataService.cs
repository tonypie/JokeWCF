using System;
using WCFTestConsoleApplication.JokeServiceWCF;
using System.Collections.Generic;

namespace WCFTestConsoleApplication.DataServices
{
    public class JokeDataService
    {
        private JokeServiceWCFClient _client;

        public JokeDataService()
        {
            _client = new JokeServiceWCFClient();
        }

        public Joke GetJoke(int jokeID)
        {
            return _client.GetJoke(jokeID);
        }

        public List<Joke> GetAllJokes()
        {
            List<Joke> jokeList = _client.GetAllJokes();

            return jokeList;
        }

        public int AddJoke(Joke joke)
        {
            throw new NotImplementedException();
        }

        public void UpdateJoke(Joke joke)
        {
            throw new NotImplementedException();
        }

        public void DeleteJoke(int jokeID)
        {
            throw new NotImplementedException();
        }


    }
}

