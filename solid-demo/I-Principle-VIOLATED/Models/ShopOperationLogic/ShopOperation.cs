using System.Collections.Generic;

namespace I_Principle_VIOLATED.Models
{
    public class ShopOperation : IServiceOperation 
    {
        private IEnumerable<Product> productsPurchased;
        private bool deliveryChoice;
        private Customer a;
        //We have to add deliveryChoice here to see if the customer requests shipping or not
        public ShopOperation(IEnumerable<Product> productsPurchased, bool deliveryChoice,Customer a ) {
            this.productsPurchased = productsPurchased;
            this.deliveryChoice = deliveryChoice;
            this.a = a;
        }


        public void calculateShippingCost() {
            //("Products prices + shipping cost = total ");
        }


        public void getUsersDetails() {
            //("Successfully verified for " + a.getName());
        }


        public bool completed() {
            return true;
        }

        public void processRequest() {
            //System.out.println("Processing request... but does he come to the shop or not ?");
            if(a.getDeliveryChoice() == false){
                processWithoutShipping();
            }
            else{
                processWithShipping();
            }
        }

        //We need two methods to use in different cases
        //What if in the future we have far more logic to add new benefits for shipping / non-shipping choices?
        private void processWithoutShipping(){
            getUsersDetails();
            bool isShipped = completed();
            //("ok it is shipped" );
        }

        private void processWithShipping(){
            getUsersDetails();
            calculateShippingCost();
            bool isShipped = completed();
            //("Well the shipper has successfully delivered!");
        }
    }
}
