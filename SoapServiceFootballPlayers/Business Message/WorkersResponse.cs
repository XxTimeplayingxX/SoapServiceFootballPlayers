using System.Collections.Generic;

namespace SoapServiceFootballPlayers.Business_Message
{
    public class WorkersResponse
    {
        public List<Person> Players { get; set; }
        public bool ActionResult { get; set; }
        public string Error { get; set; }
    }
}