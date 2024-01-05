using SoapServiceFootballPlayers.Business_Message;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public static WorkersResponse SavePlayers(PlayerServiceRequest playerServiceRequest)
        {
            var response = new WorkersResponse();

            if (playerServiceRequest == null)
            {
                response.ActionResult = false;
                response.Error = "Debe de Ingresra un nombre";
                return response;
            }
            if (string.IsNullOrEmpty(playerServiceRequest.Person.FullName))
            {
                response.ActionResult = false;
                response.Error = "Debe de ingresar un jugador";
                return response;
            }
            if (String.IsNullOrEmpty(playerServiceRequest.Person.Team))
            {
                response.ActionResult = false;
                response.Error = "Ingrese un equipo";
                return response;
            }
            var player = GetPlayers();

            player.Add(playerServiceRequest.Person);

            response.Players = player;
            response.ActionResult = true;
            return response;
        }
        public static List<Person> GetPlayers()
        {
            Random Random = new Random();
            return new List<Person>() { new Person()
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
        }
        public static WorkersResponse AddPlayer(PlayerServiceRequest playerServiceRequest)
        {
            var response = new WorkersResponse();
            var players = GetPlayers();
            players.Add(playerServiceRequest.Person);
            response.Players = players;
            response.ActionResult = true;
            return response;
        }
        public static WorkersResponse UpdatePlayer(PlayerServiceRequest playerServiceRequest)
        {
            var response = new WorkersResponse();
            var players = GetPlayers();

            Person existPlayer = players.FirstOrDefault(m => m.FullName == playerServiceRequest.Person.FullName);
            if (existPlayer != null)
            {
                existPlayer.FullName = playerServiceRequest.Person.FullName;
                return new WorkersResponse()
                {
                    Players = new List<Person> { existPlayer }
                };
            }
            else
            {
                return new WorkersResponse() { Error = "Jugador no encontrada" };
            }
        }
        public static WorkersResponse DeletePlayer(PlayerServiceRequest playerServiceRequest)
        {
            var response = new WorkersResponse();
            var players = GetPlayers();
            Person DeletePlayer = players.FirstOrDefault(m => m.FullName == playerServiceRequest.Person.FullName);
            if (DeletePlayer != null)
            {
                players.Remove(DeletePlayer);
                return new WorkersResponse() { ActionResult = true };
            }
            else
            {
                return new WorkersResponse() { Error = "Jugador no encontrado" };
            }
        }
    }
}

