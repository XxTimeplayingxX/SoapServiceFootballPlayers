namespace SoapServiceFootballPlayers.Business_Message
{
    public class PlayerServiceRequest
    {
        public Person Person { get; set; }
        public PlayerServiceRequest()
        {
            Person = new Person();
        }
    }
}