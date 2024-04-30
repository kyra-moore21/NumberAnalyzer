bool runProgram = true;
//name 
Console.WriteLine("What is your name?");
string name = Console.ReadLine();

//programloop
while (runProgram)
{
    
        Console.WriteLine($"{name}, please enter a number between 1 and 100 inculsive");
        int usernum = int.Parse(Console.ReadLine());
    //validation
        if (usernum <= 0 || usernum > 100)
        {
            Console.WriteLine($"{name}, number must be between 1 and 100");
            continue;
        }
    

        //ifelse statements
        if (usernum % 2 != 0)
        {
            if (usernum < 60)
            {
                Console.WriteLine($"{name}, your number is odd and less than 60");
            }
            else
            {
                Console.WriteLine($"{name}, your number is odd and greater than 60");
            }
        }
        else if (usernum % 2 == 0)
        {
            if (usernum < 25)
            {
                Console.WriteLine($"{name}, your number is even and less than 25");
            }
            else if (usernum > 25 && usernum <= 60)
            {
                Console.WriteLine($"{name}, your number is even and between 26 and 60 inclusive.");
            }
            else
            {
                Console.WriteLine($"{name}, your number is even and greater than 60");
            }

        }

        //getoutofprogram
        while (true)
        {
            Console.WriteLine($"Would you like to enter another number, {name}? y/n");
            string choice = Console.ReadLine().ToLower().Trim();
            if (choice == "y")
            {
                break;
            }
            else if (choice == "n")
            {
                runProgram = false;
                break;
            }
            else
            {
                Console.WriteLine($"Invalid Input, {name}");

            }
        }

    }
   
