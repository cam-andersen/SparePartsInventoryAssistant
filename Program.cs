// Activity 11: building the code for Spare Parts Inventory Assistant

//Start by creating the inventory:
string part1 = "hydraulic pump";
string part2 = "PLC module";
string part3 = "servo motor";

//Prints the beginning of the conversation that the assistant is doing:
Console.WriteLine("Hej. Welcome to the spare parts inventory!");

// Defines the boolean variable that controls the loop (false = keep asking, true = stop)
bool done = false;

//Creates a 'while' loop as the assistant should keep asking until the right condition is met - something is in stock
//from the inventory.
while (!done)
{
    //The assistant asks what part we need and the user can write the part
    Console.Write("Which part do you need? ");
    string input = Console.ReadLine();
    
//Codes the special queries
    //Creates an 'if-else' to check if the user has written any parts that are defined in the inventory. Uses == to
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
    
    //Creates an 'else if' to check if the entered text matches the first part.
    else if (input == part1)
    {
        //Prints confirmation message with the part name or prints a goodbye message to signal the program is ending
        Console.WriteLine($"I've got {part1} here for you 😊");
        Console.WriteLine("Bye!");
        //Sets the boolean variable 'done' to true so the while loop will stop
        done = true; // exit the loop
    }
    //Creates another 'else if' to check if the entered text matches the second part
    else if (input == part2)
    {
        //Prints confirmation message with the part name or prints a goodbye message to signal the program is ending
        Console.WriteLine($"I've got {part2} here for you 😊");
        Console.WriteLine("Bye!");
        //Sets the boolean variable 'done' to true so the while loop will stop
        done = true;
    }
    //Creates another 'else if' to check if the entered text matches the third part
    else if (input == part3)
    {
        //Prints confirmation message with the part name or prints a goodbye message to signal the program is ending
        Console.WriteLine($"I've got {part3} here for you 😊");
        Console.WriteLine("Bye!");
        //Sets the boolean variable 'done' to true so the while loop will stop
        done = true;
    }
    //Creates an 'else' to when the entered text does not match any part
    else
    {
        //Prints a message saying the part is not in the inventory
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