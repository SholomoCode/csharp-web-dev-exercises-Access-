using IceCreamShop;

Case menu = new Case();
List<Flavor> availableFlavors = menu.Flavors;
List<Cone> availableCones = menu.Cones;

// TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
//  field.
FlavorComparer comparer = new FlavorComparer();
foreach (Flavor flavors in availableFlavors)
{
    Console.WriteLine(flavors.Name);
    foreach(string allergen in flavors.Allergens)
    {
        Console.WriteLine(allergen);
    }
    

}
availableFlavors.Sort(comparer);
Console.WriteLine();
foreach (Flavor flavors in availableFlavors)
{
    Console.WriteLine(flavors.Name + "\n");
    foreach (string allergen in flavors.Allergens)
    {
        Console.WriteLine(allergen);
    }
}

// TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
//  field.

ConeComparer coneComparer = new ConeComparer();
Console.WriteLine();
Console.WriteLine("Before:\n");
foreach (Cone cone in availableCones)
{
    Console.WriteLine(cone.Cost);
}
availableCones.Sort(coneComparer);
Console.WriteLine();
Console.WriteLine("After:\n");

foreach (Cone cone in availableCones)
{
    Console.WriteLine(cone.Cost);
}

// TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.