namespace L_Principle_CONFORMED.Models
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

        public void makePurchases(){}
        public int getRewardPoints(){
            return rewardPoints;
        }
    }
}
