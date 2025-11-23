// Activity 11: building the code for Spare Parts Inventory Assistant

//Start by creating the inventory:
string part1 = "hydraulic pump";
string part2 = "PLC module";
string part3 = "servo motor";

//Prints the conversation that the assistant is doing:
Console.WriteLine("Hej. Welcome to the spare parts inventory!");

//Defines the boolean variable (false = keep asking, true = stop)
bool done = false;

//Creates a while loop as the assistant should keep asking until the right condition is done meaning that something is in stock
//from the inventory. 
while (!done)
{
    //The assistant asks what part we need and the user can write the part
    Console.Write("Which part do you need? ");
    string input = Console.ReadLine();
    
    //Creates if-else to check if the user has written any parts that are defined in the inventory. Uses == to
    //check if the entered is equal to the parts in the inventory.
    if (input == "Do you actually have any parts?" ||
        input == "Is there anything in stock at all?")
    {
        //If the above is true, the assistant should print how many parts that are in stock. It will also print
        //what parts that have been stored in the part-variables. 
        Console.WriteLine("We have 3 part(s)!");
        Console.WriteLine(part1);
        Console.WriteLine(part2);
        Console.WriteLine(part3);
    }
    
    //Creates else if for each of the parts to check if the entered text matches the parts. If the part is in the inventory
    //the boolean variable defined earlier is inserted so the while loop stops
    else if (input == part1)
    {
        //Prints message with the part name or prints a goodbye message because the program is ending
        Console.WriteLine($"I've got {part1} here for you 😊");
        Console.WriteLine("Bye!");
        done = true;
    }
    //Part 2
    else if (input == part2)
    {
        Console.WriteLine($"I've got {part2} here for you 😊");
        Console.WriteLine("Bye!");
        done = true;
    }
    //Part 3
    else if (input == part3)
    {
        Console.WriteLine($"I've got {part3} here for you 😊");
        Console.WriteLine("Bye!");
        done = true;
    }
    //Create else when the entered text does not match any part in the system
    else
    {
        //Prints message
        Console.WriteLine($"I am afraid we don't have any {input} in the inventory 😔");
    }
}
}
}



//Activity 22: add improvements for activity 11
//Improvement: uses an array to store the parts
string[] inventory = { "hydraulic pump", "PLC module", "servo motor" 


// Improvement: inventory.Length comes from the array and it is easier to see
    Console.WriteLine($"We have {inventory.Length} part(s)!");
