namespace L_Principle_VIOLATED.Models
{
    abstract public class Customer {
        protected string name;
        protected int age;
        protected int rewardPoints;
        protected bool registeredRewardsProgram;

        public Customer(string name, int age) {
            this.name = name;
            this.age = age;
            this.rewardPoints = 0;
        }

        //Each derived customer class must implement these methods, and this doesn't make
        //sense with infrequent and returning customers because the benefits are different
        public void makePurchases(){}
        public int getRewardPoints(){
            return rewardPoints;
        }
        public void receiveOfferedDiscount()
        {

        }
        public void invitationToNewProductTrials() 
        {

        }
        public void makePurchase(){} 
    }
}
