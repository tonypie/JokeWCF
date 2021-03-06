﻿using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServicves.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class JokeServiceWCF : IJokeServiceWCF
    {
        private JokesDatabase jd;

        public JokeServiceWCF()
        {
            jd = new JokesDatabase();
        }

        public Joke GetJoke(int jokeID)
        {
            return jd.GetJoke(jokeID);
        }

        public List<Joke> GetAllJokes()
        {
            List<Joke> jokeList = jd.GetAllJokes();

            return jokeList;
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
    }
}
