namespace Balta.NotificationContext
{
    //Sealed quer dizer que a classe não pode ser extendida
    public sealed class Notification
    {
        public Notification()
        {
            
        }

        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }

        public string Property { get; set; }
        public string Message { get; set; }
    }
}