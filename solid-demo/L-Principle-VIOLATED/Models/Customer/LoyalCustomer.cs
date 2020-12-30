namespace L_Principle_VIOLATED.Models
{
    public class LoyalCustomer : Customer  {
        public LoyalCustomer(string name, int age) :base(name,age){}
       
        //Benefits of returning customers

        public int getRewardPoints() {
            return base.getRewardPoints();
        }

       
        public void receiveOfferedDiscount() {
            //("receiving discount..");
        }

        public void invitationToNewProductTrials() {
            //("Being invited");
        }

      
        public void makePurchase() {
            //"Processing order");
            rewardPoints++;
        }
    }
}
