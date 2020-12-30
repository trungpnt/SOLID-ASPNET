namespace L_Principle_CONFORMED.Models
{
    public class LoyalCustomer : Customer,  ReturningCustomer {
        public LoyalCustomer(string name, int age) 
            :base(name, age){}
        
        //Benefits of returning customers
        public void receiveOfferedDiscount() {
            //("receiving discount..");
        }

      
        public void invitationToNewProductTrials() {
            //("Being invited");
        }


        public void makePurchase() {
            //("Processing order");
            rewardPoints++;
        }
    }
}