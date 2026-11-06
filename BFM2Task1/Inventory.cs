using System.ComponentModel;

public static class Inventory
{
    public static BindingList<Product> Products { get; set; } = new BindingList<Product>();
    public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

    // --- Part Methods ---
    public static void addPart(Part part)
    {
        AllParts.Add(part);
    }

    public static bool deletePart(Part part)
    {
        return AllParts.Remove(part);
    }

    public static Part lookupPart(int partID)
    {
        foreach (Part part in AllParts)
        {
            if (part.PartID == partID)
            {
                return part;
            }
        }
        return null;
    }

    public static void updatePart(int partID, Part updatedPart)
    {
        for (int i = 0; i < AllParts.Count; i++)
        {
            if (AllParts[i].PartID == partID)
            {
                AllParts[i] = updatedPart;
                return;
            }
        }
    }

    // --- Product Methods ---
    public static void addProduct(Product product)
    {
        Products.Add(product);
    }

    public static bool removeProduct(int productID)
    {
        Product productToRemove = lookupProduct(productID);
        if (productToRemove != null)
        {
            return Products.Remove(productToRemove);
        }
        return false;
    }

    public static Product lookupProduct(int productID)
    {
        foreach (Product product in Products)
        {
            if (product.ProductID == productID)
            {
                return product;
            }
        }
        return null;
    }

    public static void updateProduct(int productID, Product updatedProduct)
    {
        for (int i = 0; i < Products.Count; i++)
        {
            if (Products[i].ProductID == productID)
            {
                Products[i] = updatedProduct;
                return;
            }
        }
    }
}