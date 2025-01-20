// See https://aka.ms/new-console-template for more information
using BankApp01;

LinkedList customer_list=new LinkedList();

Console.WriteLine("Bank Managment system");
Console.WriteLine("======================");

while(true)
{

    Console.WriteLine("Options");
    Console.WriteLine("1. Add an account");
    Console.WriteLine("2. Display the accounts");
    Console.WriteLine("3. Delete an account");
    Console.WriteLine("Enter Your choice here:");
    string? choice=Console.ReadLine();

    switch(choice)
    {


        case "1":
                Console.WriteLine("Enter the customer Name:");
                string? name=Console.ReadLine();
                Console.WriteLine("Enter the Account Number:");

                if(!int.TryParse(Console.ReadLine(),out int acc_num))
            {
                Console.WriteLine("Invalid account Number.Try again");
                continue;
            }

            Console.WriteLine("Enter the ID Number:");
            if(!int.TryParse(Console.ReadLine(),out int id_num))
        {
            Console.WriteLine("Invalid ID Number.Try again");
            continue;

        }

        customer_list.Add(name!,acc_num,id_num);
        Console.WriteLine("Customer added successfully to system");

        break;


    }
}
