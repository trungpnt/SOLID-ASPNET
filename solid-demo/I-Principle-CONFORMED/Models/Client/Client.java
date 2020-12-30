package Client;

import Customer.Customer;
import Product.Product;
import WithShippingLogic.IServiceOperationWithShipping;
import WithShippingLogic.ShopOperationWithShipping;
import WithoutShippingLogic.IServiceOperationWithoutShipping;
import WithoutShippingLogic.ShopOperationWithoutShipping;

import java.util.ArrayList;
import java.util.List;

public class Client {
    private static List<Product> productsToBuy = new ArrayList<Product>();
    private static IServiceOperationWithShipping withShipping;
    private static IServiceOperationWithoutShipping withoutShipping;

    public static void main(String[] args){

        Customer customer = new Customer("Bobby",1,productsToBuy,false);
        decideInterfaceAndProcess(customer);

    }

    public static void decideInterfaceAndProcess(Customer a){
        if(a.getDeliveryChoice() == false){
            withoutShipping = new ShopOperationWithoutShipping(productsToBuy,a);
            withoutShipping.processRequest();
        }
        else{
            withShipping = new ShopOperationWithShipping(productsToBuy,a);
            withShipping.processRequest();
        }
    }
}
