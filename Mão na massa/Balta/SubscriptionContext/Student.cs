using System.Security.Cryptography.X509Certificates;
using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            subscriptions = new List<Subscription>();
        }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public User User { get; set; }
        public IList<Subscription> subscriptions { get; set; }

        public void CreateSubscription(Subscription subscription)
        {
            if(IsPremium)
            {
                AddNotification(new NotificationContext.Notification("Premium", "O aluno já tem uma assinatura ativa"));
                return;
            }

            subscriptions.Add(subscription);
        }

        public bool IsPremium => subscriptions.Any(x=> !x.IsInactive);
    }
}