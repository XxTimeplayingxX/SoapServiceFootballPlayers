﻿using SoapServiceFootballPlayers.Business_Action;
using SoapServiceFootballPlayers.Business_Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SoapServiceFootballPlayers
{
    /// <summary>
    /// Descripción breve de WebServiceFootballPlayers
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceFootballPlayers : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public WorkersResponse GetAllPlayers()
        {
            return FootballManager.GetAllPlayers();
        }
        [WebMethod]
        public WorkersResponse SaveStudent(PlayerServiceRequest playerServiceRequest)
        {
            return FootballManager.SavePlayers(playerServiceRequest);
        }
        [WebMethod]
        public WorkersResponse AddPlayer(PlayerServiceRequest playerServiceRequest)
        {
            return FootballManager.AddPlayer(playerServiceRequest);
        }
        [WebMethod]
        public WorkersResponse UpdatePlayer(PlayerServiceRequest playerServiceRequest)
        {
            return FootballManager.UpdatePlayer(playerServiceRequest);
        }
        [WebMethod]
        public WorkersResponse DeletePlayer(PlayerServiceRequest playerServiceRequest)
        {
            return FootballManager.DeletePlayer(playerServiceRequest);
        }
    }
}
