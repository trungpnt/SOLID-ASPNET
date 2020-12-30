using System.Collections.Generic;

namespace I_Principle_VIOLATED.Models
{
    public class Customer 
    {
        private string name;
        private int id;
        private IEnumerable<Product> productsBought;
        private bool chooseDeliveryService;
        IServiceOperation pickService;
        public Customer(string name, int id, IEnumerable<Product> productsBought, bool chooseDeliveryService) {
            this.name = name;
            this.id = id;
            this.productsBought = productsBought;
            this.chooseDeliveryService = chooseDeliveryService;
        }

        public string getName(){
            return name;
        }
        public bool getDeliveryChoice(){
            return chooseDeliveryService;
        }
    }   

}
