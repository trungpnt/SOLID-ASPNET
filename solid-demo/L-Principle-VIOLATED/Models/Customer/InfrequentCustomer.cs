namespace L_Principle_VIOLATED.Models
{
    public class InfrequentCustomer : Customer  {

        public InfrequentCustomer(string name, int age) :base(name,age){}
        
        public void makePurchases() {
            base.makePurchases();
        }

        public int getRewardPoints() {
            return base.getRewardPoints();
        }

     
        public void receiveOfferedDiscount() {

        }

     
        public void invitationToNewProductTrials()  {

        }

       
        public void makePurchase() {

        }
    }
}
