using SoapServiceFootballPlayers.Business_Message;
using System;
using System.Collections.Generic;

namespace SoapServiceFootballPlayers.Business_Action
{
    public static class FootballManager
    {

        public static WorkersResponse GetAllPlayers()
        {
            Random Random = new Random();
            var players = new List<Person>() { new Person()
            {
                FullName = "Cristiano Ronaldo",
                Team = "Real Madrid",
                Goals = Random.Next(1, 1000)
            },
            new Person()
            {
                FullName = "Lionel Messi",
                Team = "Barcelona de España",
                Goals = Random.Next(1, 1000)
            },
            new Person()
            {
                FullName = "Robert Levandowski",
                Team = "Fc Bayern de Munich",
                Goals = Random.Next(1, 1000)
            },
            new Person()
            {
                FullName = "Neymar Jr.",
                Team = "Paris Saint-Germain",
                Goals = Random.Next(1, 1000)
            }
            };
            return new WorkersResponse()
            {
                Players = players,
                ActionResult = true
            };
        }
    }
}