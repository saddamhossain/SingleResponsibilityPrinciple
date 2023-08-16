namespace SingleResponsibilityPrinciple;

// In an online store application, we can separate the responsibilities of managing products, shopping cart, and order processing.
// The responsibilities related to shopping cart management and product updates are separated into different classes.
// This ensures that each class has a single, well-defined responsibility.

#region Not following SRP
public class OnLineStore
{
    public void AddToCart(Product product)
    {
        // Add product to shopping cart logic
    }

    public void Checkout()
    {
        // Process order logic
    }

    public void UpdateProduct(Product product)
    {
        // Update product details logic
    }
}
#endregion


#region Following SRP
public class ShoppingCart
{
    public void AddToCart(Product product)
    {
        // Add product to shopping cart logic
    }

    public void Checkout()
    {
        // Process order logic
    }
}

public class ProductManager
{
    public void UpdateProduct(Product product)
    {
        // Update product details logic
    }
}
#endregion