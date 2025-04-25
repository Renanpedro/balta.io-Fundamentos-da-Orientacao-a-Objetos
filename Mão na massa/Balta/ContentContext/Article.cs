namespace Balta.ContentContext
{
    public class Article : Content
    {
        public Article(string title, string url) : base(title, url) //Neste caso esta sendo usado o base para passar as info para o contrutor da content
        {
            
        }
    }
}