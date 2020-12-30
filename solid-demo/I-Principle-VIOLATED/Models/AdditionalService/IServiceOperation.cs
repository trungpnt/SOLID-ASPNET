namespace I_Principle_VIOLATED.Models
{
    public interface IServiceOperation 
    {
        void calculateShippingCost();
        //Not always necessary to calculate shipping cost!
        void getUsersDetails();
        void processRequest();
        bool completed();
    }
}
