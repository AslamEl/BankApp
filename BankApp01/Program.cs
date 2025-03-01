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
    Console.WriteLine("3. Deposit");
    Console.WriteLine("4. Withdrawl");
    Console.WriteLine("5. Delete an account");
    Console.WriteLine("6. Exit");
    Console.WriteLine("Enter Your choice here:");
    string? choice=Console.ReadLine();

    switch(choice)
    {


        case "1":
        Console.WriteLine("==============================");
        Console.WriteLine(" WELCOME TO CREATE AN ACCOUNT ");
        Console.WriteLine("==============================");
        while(true)

        {
                Console.WriteLine("Enter the customer Name:");
                string? name=Console.ReadLine();
                long acc_num;
                while(true)
                {
                Console.WriteLine("Enter the 6 digts Account Number:");

                string? accNmr=Console.ReadLine();
            

                if(!long.TryParse(accNmr,out acc_num)||accNmr.Length!=2)
            {
                Console.WriteLine("Invalid account Number.Account number must be 6 digits");
                continue;
            }
            
            
            if(customer_list.AccountExists(acc_num))
            {
            Console.WriteLine($"The {acc_num} already exists.Try agin");
            
            
            continue;
            }

            break;

            }
            
        
            Console.WriteLine("Enter the ID Number:");
            string? id_num=Console.ReadLine();
          
        long f_deposit;
        while(true)
        {
        Console.WriteLine("Enter the First Deposit Amount:");
        string? accba=Console.ReadLine();
        if(!long.TryParse(accba,out f_deposit)||f_deposit<500)
        {
            Console.WriteLine("Invalid amount.The first deposit Amount must larger then or equal to Rs.500");
            continue;
        }
        break;

        }


        customer_list.Add(name!,acc_num,id_num!,f_deposit);
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


         case "2":
        customer_list.Display();
        break;

        case "3":
        
        Console.WriteLine("=========================");
        Console.WriteLine(" WELCOME TO DEPOSIT PAGE ");
        Console.WriteLine("=========================");
        long depositAccount;
        while(true)
        {
        Console.WriteLine("Enter the account number to Deposit");
        if(!long.TryParse(Console.ReadLine(),out depositAccount))
        {
            Console.WriteLine("Invalid Account number");
            continue;
        }
        if(!customer_list.AccountExists(depositAccount))
        {
            Console.WriteLine($"Your account {depositAccount} number is wrong.Please check and Try Again");
            continue;
        }
        break;
        }
        
        Console.WriteLine("Enter the Amount to Deposit");
        if(!long.TryParse(Console.ReadLine(),out long depositAmount))
        {
            Console.WriteLine("Invalid deposit Amount");
            break;
        }

        customer_list.Deposit(depositAccount,depositAmount);
        break;

        case "4":
        Console.WriteLine("==========================");
        Console.WriteLine(" WELCOME TO WITHDRAWL PAGE ");
        Console.WriteLine("==========================");
        long withdrawAccount;
       

        while(true)
        {
        Console.WriteLine("Enter the account number to withdraw");

        if(!long.TryParse(Console.ReadLine(),out withdrawAccount))
        {
            Console.WriteLine("Invalid Account number");
            continue;
        }
        
        
         if(!customer_list.AccountExists(withdrawAccount))
        {
            Console.WriteLine($"Your account {withdrawAccount} number is wrong.Please check and Try Again");
            continue;
        }
        break;
        }
        
        Console.WriteLine("Enter the Amount to withdraw");
        if(!long.TryParse(Console.ReadLine(),out long  withdrawAmount))
        {
            Console.WriteLine("Invalid withdraw Amount");
            break;
        }
        
       

        customer_list.Withdrawl(withdrawAccount,withdrawAmount);
        break;



        case "5":
        long AccDelete;
        Console.WriteLine("=========================");
        Console.WriteLine(" WELCOME TO DELETE PAGE ");
        Console.WriteLine("=========================");
        while(true)
        {
        Console.WriteLine("enter the account number to delete");
        
       
        if(!long.TryParse(Console.ReadLine(),out AccDelete))
        {
            Console.WriteLine("Inavalid input please Enter valid number");
            continue;

        }
        break;
        }
        customer_list.Delete(AccDelete);

        break;


       
        

        case "6":
        Console.WriteLine("Exit the system.Have a good day");
        return;


    }
}
