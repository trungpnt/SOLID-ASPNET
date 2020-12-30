package WithoutShippingLogic;

import Customer.Customer;
import Product.Product;
import ShopOperationLogic.ShopOperation;

import java.util.List;

public class ShopOperationWithoutShipping extends ShopOperation implements IServiceOperationWithoutShipping {

    public ShopOperationWithoutShipping(List<Product> productsPurchased, Customer a) {
        super(productsPurchased, a);
    }

    @Override
    public void getUsersDetails() {
        System.out.println("Verifying user details");
    }

    @Override
    public void processRequest() {
        System.out.println("Processing request without shipping operation");
        getUsersDetails();
        System.out.println(completed());
    }

    @Override
    public boolean completed() {
        return true;
    }
}
