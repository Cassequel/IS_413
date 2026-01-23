using System.ComponentModel.Design;

class FoodItem
{
    public string food_item;
    public string category;
    public int quantity;
    public DateTime exp_date;

    public FoodItem(string food_item, string category, int quantity, DateTime exp_date)
    {
        this.food_item = food_item;
        this.category = category;
        this.quantity = quantity;
        this.exp_date = exp_date;
    }

    
}

class Program
{
    static void Main(string[] args)
    {
        int answer = 0;

        List<FoodItem> inventory = new List<FoodItem>();

        while (answer != 4) 
        {
            Console.WriteLine("Welcome to the Pantry");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add Food Items");
            Console.WriteLine("2. Delete Food Items");
            Console.WriteLine("3. Print List of Current Food Items");
            Console.WriteLine("4. Exit Program");
            Console.WriteLine("");
            Console.WriteLine("Enter your choice (1-4)");
            string input = Console.ReadLine();

            if (int.TryParse(input, out answer))
            {
                if (answer == 1)
                {
                    string food_item = "";
                    while (string.IsNullOrEmpty(food_item))
                    {
                        Console.WriteLine("What Food Would You Like To Add?");
                        food_item = Console.ReadLine();

                        if (string.IsNullOrEmpty(food_item))
                        {
                            Console.WriteLine("Please enter a food name.");
                            food_item = "";
                        }

                    }
                    string category = "";
                    while (string.IsNullOrEmpty(category))
                    {
                        Console.WriteLine("What Category does it belong to? (Canned Goods, Dairy, Produce, Meats, Vegetables, Fruits, Other)");
                        category = Console.ReadLine();

                        if (string.IsNullOrEmpty(category))
                        {
                            Console.WriteLine("Please enter a food name.");
                            category = "";
                        }
                    }
                    Console.WriteLine("How much");
                    int quantity = -1;
                    while (quantity < 0)
                    {
                        string quantity_input = Console.ReadLine();

                        if (int.TryParse(quantity_input, out quantity))
                        {
                            if (quantity < 0)
                            {
                                Console.WriteLine("Please Enter A Quantity Above 0");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please Enter A Valid Quantity");
                            quantity = -1;
                        }
                    }
                    DateTime exp_date = DateTime.Now;
                    bool validDate = false;
                    while (!validDate)
                    {
                        Console.WriteLine("What is the Expiration Date? (yyyy-mm-dd)");
                        string dateInput = Console.ReadLine();

                        if (DateTime.TryParse(dateInput, out exp_date))
                        {
                            validDate = true;
                        }
                        else
                        {
                            Console.WriteLine("Plase Enter a Valid Date");
                            validDate = false;
                        }
                    }
                    Console.WriteLine("Thank You!");
                    Console.WriteLine();

                    FoodItem newitem = new FoodItem(food_item, category, quantity, exp_date);
                    inventory.Add(newitem);
                }
                else if (answer == 2)
                {
                    Console.WriteLine("What Item Do You Want To Delete?");
                    for (int i = 0; i < inventory.Count; i++)
                    {
                        Console.Write("(" + (i + 1) + ")" + " ");
                        Console.WriteLine(inventory[i].food_item);
                        Console.WriteLine(inventory[i].category);
                        Console.WriteLine(inventory[i].quantity);
                        Console.WriteLine(inventory[i].exp_date);


                    }
                    Console.WriteLine(">");
                    int x = -1;
                    bool validChoice = false;

                    while (!validChoice)
                    {
                        string remove_input = Console.ReadLine();

                        if (int.TryParse(remove_input, out x))
                        {
                            if (x < 1 || x > inventory.Count)
                            {
                                Console.WriteLine("Please Select A Valid Item Number");
                            }
                            else
                            {
                                inventory.RemoveAt(x - 1);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please Input A Valid Number");
                        }
                    }


                    Console.WriteLine("Thank You!");
                    Console.WriteLine();
                }
                else if (answer == 3)
                {
                    Console.WriteLine("--Complete List of Items__");
                    Console.WriteLine();

                    for (int i = 0; i < inventory.Count; i++)
                    {
                        Console.WriteLine(inventory[i].food_item);
                        Console.WriteLine(inventory[i].category);
                        Console.WriteLine(inventory[i].quantity);
                        Console.WriteLine(inventory[i].exp_date);
                        Console.WriteLine("Thank You!");
                        Console.WriteLine();
                    }
                }
                else if (answer == 4)
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please Enter A Valid Number");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Please Enter A Valid Number");
                Console.WriteLine();
            }

        }
    }
}