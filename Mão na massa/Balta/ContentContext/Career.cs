namespace Balta.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url) : base(title, url)
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count; //Esse items.count é uma Expression Body neste caso tem somente a tag Get, sem o Set
    }    
}