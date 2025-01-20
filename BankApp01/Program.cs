// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
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
    Console.WriteLine("4. Exit");
    Console.WriteLine("Enter Your choice here:");
    string? choice=Console.ReadLine();

    switch(choice)
    {


        case "1":
        while(true)

        {
                Console.WriteLine("Enter the customer Name:");
                string? name=Console.ReadLine();
                Console.WriteLine("Enter the 10 digts Account Number:");

                string? accNmr=Console.ReadLine();
                if(accNmr?.Length!=10)
                {
                    Console.WriteLine("Invalid number Enter 10 digits");
                    continue;

                }

                if(!long.TryParse(accNmr,out long acc_num))
            {
                Console.WriteLine("Invalid account Number.Try again");
                continue;
            }

            Console.WriteLine("Enter the ID Number:");
            if(!long.TryParse(Console.ReadLine(),out long id_num))
        {
            Console.WriteLine("Invalid ID Number.Try again");
            continue;

        }

        customer_list.Add(name!,acc_num,id_num);
        Console.WriteLine("Customer added successfully to system");
            Console.WriteLine("1.Previous Menu");
            Console.WriteLine("2.Add another customer");
            Console.WriteLine("3.Exit the system");

            String? choice_1=Console.ReadLine();
            switch (choice_1)
            {
                case "1":
                    break;


                case"2":
                continue;

                case "3":
                Console.WriteLine("Successfully exit the system");
                return;

                default:
                Console.WriteLine("Inavalid choice return to previous menu");
                break;
            }

        
        break;
        }


        break;

        case "3":
        Console.WriteLine("enter the account number to delete");
        
       
        if(!long.TryParse(Console.ReadLine(),out long AccDelete))
        {
            Console.WriteLine("Inavalid input please Enter valid number");
            continue;

        }
        customer_list.Delete(AccDelete);

        break;


        case "2":
        customer_list.Display();
        break;
        

        case "4":
        Console.WriteLine("Exit the system....");
        return;


    }
}
