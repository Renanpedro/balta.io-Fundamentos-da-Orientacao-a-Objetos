using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Balta.ContentContext;
using Balta.SubscriptionContext;
using Microsoft.VisualBasic;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "Orientacao-Objetos"));
            articles.Add(new Article("Artigo sobre C#", "CSharp"));
            articles.Add(new Article("Artigo sobre .Net", ".net"));

            foreach (var article in articles)
            {
                System.Console.WriteLine("=======================================================================================================");
                System.Console.WriteLine($"O Id do artigo é {article.Id}");
                System.Console.WriteLine($"O titulo do artigo é {article.Title}");
                System.Console.WriteLine($"A url do artigo é {article.Url}");
            }

            System.Console.WriteLine("=======================================================================================================");
            var courses = new List<Course>();
            var courseOOp = new Course("Fundamentos OOP", "Fundamentos-oop");
            var courseCSharp = new Course("Fundamentos CSharp", "CSharp");
            var courseAspNet = new Course("Fundamentos ASPNET", "ASPNET");
            courses.Add(courseOOp);
            courses.Add(courseCSharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "Especialista-dotnet");
            var careeritem2 = new CareerItem(2, "Aprenda OOP", "", null);
            var careeritem1 = new CareerItem(1, "Comece por aqui", "", courseCSharp);
            var careeritem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);
            careerDotnet.Items.Add(careeritem2);
            careerDotnet.Items.Add(careeritem1);
            careerDotnet.Items.Add(careeritem3);
            careers.Add(careerDotnet);

            foreach(var career in careers)
            {
                System.Console.WriteLine(career.Title);
                foreach(var careerItem in career.Items.OrderBy(x => x.Order))
                {
                    System.Console.WriteLine($"{careerItem.Order} - {careerItem.Title}");

                    foreach(var notification in careerItem.Notifications)
                    {
                        System.Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }

            var PaypalSubscription = new PaypalSubscription();
            var student = new Student();
            student.CreateSubscription(PaypalSubscription);
        }
    }   
}
