package WithShippingLogic;

import Customer.Customer;
import Product.Product;
import ShopOperationLogic.ShopOperation;

import java.util.List;

public class ShopOperationWithShipping extends ShopOperation implements IServiceOperationWithShipping {

    public ShopOperationWithShipping(List<Product> productsPurchased, Customer a) {
        super(productsPurchased, a);
    }

    @Override
    public void calculateShippingCost() {
        System.out.println("Prices + shipping cost = ...");
    }

    @Override
    public void getUsersDetails() {
        System.out.println("Verifying user details");
    }

    @Override
    public void processRequest() {
        System.out.println("Processing request with shipping operation");
        calculateShippingCost();
        getUsersDetails();
        System.out.println(completed());
    }

    @Override
    public boolean completed() {
        return true;
    }
}
