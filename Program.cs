namespace ListCollection
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            List<string> groceryList = ["Apples", "Bananas", "Bread", "Cheese", "Peanut-Butter"];
            string tempItem = "Chocolate Cake"; // creating a string variable
            groceryList.Add(tempItem); // adding a value stored in a variable
            groceryList.Insert(0, "Coffee"); // adding to the beginning
            Console.WriteLine();
            Console.WriteLine($"The original list had {groceryList.Count()} items");
            string[] itemArray = new string[] { "Chips", "Salsa", "Milk", "Oatmeal" };
            groceryList.AddRange(itemArray);
            Console.WriteLine($"The new list now has {groceryList.Count()} items");
            Console.WriteLine();
            Console.WriteLine("-------Original List--------");
            for (int i = 0; i < groceryList.Count(); i++)
            {
                Console.WriteLine(groceryList[i]);
            }

            _ = groceryList.Remove("Chocolate Cake");
            _ = groceryList.Remove(groceryList[4]); // the item at index 4 is removed
            groceryList.RemoveRange(3, 2); // beginning at index 3, 2 items are removed
            Console.WriteLine();
            Console.WriteLine($"The revised list now has {groceryList.Count()} Items");
            Console.WriteLine();
            Console.WriteLine("-------Revised List--------");
            for (int i = 0; i < groceryList.Count(); i++)
            {
                Console.WriteLine(groceryList[i]);
            }

            groceryList.Sort();
            Console.WriteLine();
            Console.WriteLine("-------Sorted List--------");
            foreach (string i in groceryList)
            {
                Console.WriteLine(i);
            }

            groceryList.Reverse();
            Console.WriteLine();
            Console.WriteLine("-------Reverse Sorted List--------");
            foreach (string i in groceryList)
            {
                Console.WriteLine(i);
            }
        }
    }
}