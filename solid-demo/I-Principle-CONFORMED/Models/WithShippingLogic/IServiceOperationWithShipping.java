package WithShippingLogic;

public interface IServiceOperationWithShipping {
    void calculateShippingCost();
    void getUsersDetails();
    void processRequest();
    boolean completed();
}
