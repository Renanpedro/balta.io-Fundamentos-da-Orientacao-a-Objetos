using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.ContentContext
{
    public class CareerItem : Base
    {
        public CareerItem(int order, string title, string description, Course course)
        {
            if(course == null)
                AddNotification(new Notification("Course", "Curso Invalido"));
            
            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Course Course { get; set; }
    }
}