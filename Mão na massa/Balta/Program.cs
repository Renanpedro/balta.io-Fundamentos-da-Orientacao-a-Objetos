using System.Security.Cryptography.X509Certificates;
using Balta.ContentContext;
using Microsoft.VisualBasic;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            // var articles = new List<Article>();
            // articles.Add(new Article("Artigo sobre OOP", "Orientacao-Objetos"));
            // articles.Add(new Article("Artigo sobre C#", "CSharp"));
            // articles.Add(new Article("Artigo sobre .Net", ".net"));

            // foreach (var article in articles)
            // {
            //     System.Console.WriteLine(article.Id);
            //     System.Console.WriteLine(article.Title);
            //     System.Console.WriteLine(article.Url);
            // }

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
            var careeritem1 = new CareerItem(1, "Comece por aqui", "", null);
            var careeritem3 = new CareerItem(3, "Aprenda .NET", "", null);
            careerDotnet.Items.Add(careeritem2);
            careerDotnet.Items.Add(careeritem1);
            careerDotnet.Items.Add(careeritem3);
            careers.Add(careerDotnet);

            foreach(var carrer in careers)
            {
                System.Console.WriteLine(carrer.Title);
                foreach(var carrerDotnet in carrer.Items.OrderBy(x => x.Order))
                {
                    System.Console.WriteLine($"{carrerDotnet.Order} - {carrerDotnet.Title}");
                }
            }
        }
    }   
}
