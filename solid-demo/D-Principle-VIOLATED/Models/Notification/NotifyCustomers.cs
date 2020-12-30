using System.Collections.Generic;

namespace D_Principle_VIOLATED.Models
{
    public class NotifyCustomers {
        static IEnumerable<Pizza> pizzas;
        OrderPizza orderPizza = new OrderPizza(1,"12h36'",pizzas);
        
        //This design is not good
        EmailNotification email = new EmailNotification();
        SMSNotification sms = new SMSNotification();
        RealTimeNotification realTimeNotification = new RealTimeNotification();

        public void sendMsg(int choice){
            //1 for email, 2 for sms, 3 for realtime
            //Here's the problem : what if we want to expand this notification logic by another channel?
            switch (choice){
                case 1:
                    email.send();
                    break;
                case 2:
                    sms.send();
                    break;
                case 3:
                    realTimeNotification.send();
                    break;
                default:
                    break;
            }
        }

    }
}