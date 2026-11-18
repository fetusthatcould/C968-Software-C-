using System.ComponentModel;

namespace BFM2Task1
{
    public static class Inventory
    {
        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

        private static int _nextPartId = 0;
        private static int _nextProductId = 0;

        public static int GeneratePartID() => _nextPartId++;
        public static int GenerateProductID() => _nextProductId++;

        // --- Part Methods ---
        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public static bool deletePart(Part part)
        {
            return AllParts.Remove(part);
        }

        public static Part? lookupPart(int partID)
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
            // Bug 1 Fix: Preserve the original ID
            updatedPart.PartID = partID;

            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == partID)
                {
                    AllParts[i] = updatedPart;
                    break;
                }
            }

            // Bug 2 Fix: Sync the updated part inside every product's AssociatedParts
            foreach (Product product in Products)
            {
                for (int j = 0; j < product.AssociatedParts.Count; j++)
                {
                    if (product.AssociatedParts[j].PartID == partID)
                    {
                        product.AssociatedParts[j] = updatedPart;
                    }
                }
            }
        }

        public static bool isPartAssociated(int partID)
        {
            foreach (Product product in Products)
            {
                if (product.lookupAssociatedPart(partID) != null)
                {
                    return true;
                }
            }
            return false;
        }

        // --- Product Methods ---
        public static void addProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool removeProduct(int productID)
        {
            Product? productToRemove = lookupProduct(productID);
            if (productToRemove != null)
            {
                return Products.Remove(productToRemove);
            }
            return false;
        }

        public static Product? lookupProduct(int productID)
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
            // Bug 1 Fix: Preserve the original ID
            updatedProduct.ProductID = productID;

            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productID) 
                {
                    Products[i] = updatedProduct;
                    return;
                }
            }
        }

        // --- Sample Data ---
        public static void PopulateSampleData()
        {
            if (AllParts.Count > 0 || Products.Count > 0) return;

            var wheel = new Inhouse { PartID = GeneratePartID(), Name = "Wheel", InStock = 15, Price = 12.11m, Min = 5, Max = 25, MachineID = 101 };
            var pedal = new Inhouse { PartID = GeneratePartID(), Name = "Pedal", InStock = 11, Price = 8.22m, Min = 5, Max = 25, MachineID = 110 };
            var chain = new Outsourced { PartID = GeneratePartID(), Name = "Chain", InStock = 12, Price = 8.33m, Min = 5, Max = 25, CompanyName = "ChainCo" };
            var seat = new Outsourced { PartID = GeneratePartID(), Name = "Seat", InStock = 8, Price = 4.55m, Min = 2, Max = 15, CompanyName = "SeatWorks" };

            addPart(wheel);
            addPart(pedal);
            addPart(chain);
            addPart(seat);

            var redBike = new Product { ProductID = GenerateProductID(), Name = "Red Bicycle", InStock = 15, Price = 11.44m, Min = 1, Max = 25 };
            redBike.addAssociatedPart(wheel);
            redBike.addAssociatedPart(pedal);

            var yellowBike = new Product { ProductID = GenerateProductID(), Name = "Yellow Bicycle", InStock = 19, Price = 9.66m, Min = 1, Max = 20 };
            yellowBike.addAssociatedPart(chain);

            var blueBike = new Product { ProductID = GenerateProductID(), Name = "Blue Bicycle", InStock = 5, Price = 12.77m, Min = 1, Max = 25 };
            blueBike.addAssociatedPart(chain);
            blueBike.addAssociatedPart(wheel);
            blueBike.addAssociatedPart(seat);

            addProduct(redBike);
            addProduct(yellowBike);
            addProduct(blueBike);
        }
    }
}