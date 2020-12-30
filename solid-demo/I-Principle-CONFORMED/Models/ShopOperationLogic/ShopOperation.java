package ShopOperationLogic;

import Customer.Customer;
import Product.Product;

import java.util.List;

public abstract class ShopOperation {
    private List<Product> productsPurchased;
    private Customer customer;
    public ShopOperation(List<Product> productsPurchased, Customer customer) {
        this.productsPurchased = productsPurchased;
        this.customer = customer;
    }
    public void processRequest(){}
}
