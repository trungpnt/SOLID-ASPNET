using System.Collections.Generic;

namespace D_Principle_CONFORMED.Models
{

    public class NotifyCustomers {
        private static IEnumerable<Pizza> pizzas;
        OrderPizza orderPizza = new OrderPizza(1,"12h36'",pizzas);
        //This class should only talk to an interface, without knowing the internal logic
        INotifitcationWay iNotifitcationWay;

        public void registerNotificationChannel(INotifitcationWay way){
            iNotifitcationWay = way;
        }
        public void sendMsg(){
            iNotifitcationWay.notifyCustomer();
        }
    }
}
