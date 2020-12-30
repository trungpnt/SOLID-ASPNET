package Customer;

import Product.Product;

import java.util.List;

public class Customer {
    private String name;
    private int id;
    private List<Product> productsBought;
    private boolean chooseDeliveryService;

    public Customer(String name, int id, List<Product> productsBought, boolean chooseDeliveryService) {
        this.name = name;
        this.id = id;
        this.productsBought = productsBought;
        this.chooseDeliveryService = chooseDeliveryService;
    }

    public String getName(){
        return name;
    }

    public boolean getDeliveryChoice(){
        return chooseDeliveryService;
    }
}
