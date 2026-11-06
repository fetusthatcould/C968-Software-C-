using System.ComponentModel;

public abstract class Part
{
    public int PartID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int InStock { get; set; }
    public int Min { get; set; }
    public int Max { get; set; }
}

public class Inhouse : Part
{
    public int MachineID { get; set; }
}

public class Outsourced : Part
{
    public string CompanyName { get; set; }
}

public class Product
{
    public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();
    public int ProductID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int InStock { get; set; }
    public int Min { get; set; }
    public int Max { get; set; }

    public void addAssociatedPart(Part part)
    {
        AssociatedParts.Add(part);
    }

    public bool removeAssociatedPart(int partID)
    {
        Part partToRemove = lookupAssociatedPart(partID);
        if (partToRemove != null)
        {
            return AssociatedParts.Remove(partToRemove);
        }
        return false;
    }

    public Part lookupAssociatedPart(int partID)
    {
        foreach (Part part in AssociatedParts)
        {
            if (part.PartID == partID)
            {
                return part;
            }
        }
        return null;
    }
}