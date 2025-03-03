// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

using System.Xml.Serialization;
using BankApp01;
using System.Diagnostics;

LinkedList customer_list=new LinkedList();
Console.WriteLine("\t\t\t\t\t\t======================================");
Console.WriteLine("\t\t\t\t\t\t\tBANK MANAGEMENT SYSTEM");
Console.WriteLine("\t\t\t\t\t\t======================================");

while(true)
{

    Console.WriteLine("\n=====================");
    Console.WriteLine("      MAIN MENU      ");
    Console.WriteLine("=====================\n");
    Console.WriteLine("1. Create an account");
    Console.WriteLine("2. Display the accounts");
    Console.WriteLine("3. Deposit");
    Console.WriteLine("4. Withdrawl");
    Console.WriteLine("5. Delete an account");
    Console.WriteLine("6. Tranfer Money To Another Account");
    Console.WriteLine("7. Exit");
    Console.WriteLine("Enter Your choice here:");
    string? choice=Console.ReadLine();

    switch(choice)
    {


        case "1":
                while(true)
                {


                Console.WriteLine("==================================");
                Console.WriteLine("   WELCOME TO CREATE AN ACCOUNT   ");
                Console.WriteLine("==================================");
                

                
                        Console.WriteLine("Enter the customer Name:");
                        string? name=Console.ReadLine();
                        long acc_num;
                        while(true)
                        {
                        Console.WriteLine("Enter the 6 digts Account Number:");

                        string? accNmr=Console.ReadLine();
                    

                        if(!long.TryParse(accNmr,out acc_num)||accNmr.Length!=6)
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
                    
                    
                string? id_num;
                while(true)
                {
                    Console.WriteLine("Enter the ID Number:");
                    id_num=Console.ReadLine();
                    
                    if(customer_list.Id_Exists(id_num))
                    {
                    Console.WriteLine($"The {id_num} already exists.Try agin");
                    
                    
                    continue;
                    }
                    break;
                }
                    
                
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
                
                while(true)
                {
                    Console.WriteLine("\nWhat would you like to do next?");
                    Console.WriteLine("1. Create another Account");
                    Console.WriteLine("2. Return to Main Menu");
                    Console.WriteLine("3. Exit the system");
                    Console.Write("Select an option: ");

                    String? choice_1=Console.ReadLine();
                    switch (choice_1)
                    {
                        case "1":
                        Console.Clear();
                        break;


                        case"2":
                        Console.WriteLine("Returning to Main Menu...");
                        goto MainMenu;

                        case "3":
                        Console.WriteLine("Successfully exit the system");
                        return;

                        default:
                        Console.WriteLine("Inavalid choice return to previous menu");
                        break;
                    }
                    break;
                }

                
        

                }
                MainMenu:
                break;
            
    


                


        case "2":
            customer_list.Display();
            break;




        case "3":
            while (true) // Deposit Menu
            {
                Console.WriteLine("===============================");
                Console.WriteLine("    WELCOME TO DEPOSIT PAGE    ");
                Console.WriteLine("===============================");

                long depositAccount;
                while (true)
                {
                    Console.WriteLine("Enter the account number to deposit:");
                    if (!long.TryParse(Console.ReadLine(), out depositAccount))
                    {
                        Console.WriteLine("Invalid account number.");
                        continue;
                    }
                    if (!customer_list.AccountExists(depositAccount))
                    {
                        Console.WriteLine($"Account {depositAccount} does not exist. Please check and try again.");
                        continue;
                    }
                    break;
                }

                Console.WriteLine("Enter the Amount to Deposit:");
                if (!long.TryParse(Console.ReadLine(), out long depositAmount) || depositAmount <= 0)
                {
                    Console.WriteLine("Invalid deposit amount.");
                    continue;
                }

                customer_list.Deposit(depositAccount, depositAmount);
                Console.WriteLine("Deposit Successful!");

                while (true) 
                {
                    Console.WriteLine("\nWhat would you like to do next?");
                    Console.WriteLine("1. Deposit to Another Account");
                    Console.WriteLine("2. Return to Main Menu");
                    Console.WriteLine("3. Exit");
                    Console.Write("Select an option: ");

                    string? choice_a = Console.ReadLine() ?? "";

                    switch (choice_a)
                    {
                        case "1":
                            Console.Clear();
                            break; 
                        case "2":
                            Console.WriteLine("Returning to Main Menu...");
                            goto MainMenu; 
                        case "3":
                            Console.WriteLine("Exiting...");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            continue; 
                    }
                    break; 
                }
            }
            
             

                
        

        case "4":
            while(true)
            {

                Console.WriteLine("=================================");
                Console.WriteLine("   WELCOME TO WITHDRAWAL PAGE   ");
                Console.WriteLine("=================================");
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
                        Console.WriteLine($"Your account {withdrawAccount} number is wrong. Please check and try again.");
                        continue;
                    }
                    break;
                }

                Console.WriteLine("Enter the Amount to withdraw");
                if(!long.TryParse(Console.ReadLine(),out long withdrawAmount) || withdrawAmount <= 0)
                {
                    Console.WriteLine("Invalid withdraw Amount");
                    break;
                }

                customer_list.Withdrawl(withdrawAccount, withdrawAmount);
               

                while (true) 
                {
                    Console.WriteLine("\nWhat would you like to do next?");
                    Console.WriteLine("1. Withdraw from Another Account");
                    Console.WriteLine("2. Return to Main Menu");
                    Console.WriteLine("3. Exit");
                    Console.Write("Select an option: ");

                    string? choice4 = Console.ReadLine() ?? "";

                    switch (choice4)
                    {
                        case "1":
                            Console.Clear();
                            break; 

                        case "2":
                            Console.WriteLine("Returning to Main Menu...");
                            goto MainMenu; 

                        case "3":
                            Console.WriteLine("Exiting...");
                            Environment.Exit(0);
                            break; 

                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            continue; 
                    }

                    break;
                }
                
            }
             break;
                
            


        case "5":
           while(true)
           {
             Console.WriteLine("=============================");
             Console.WriteLine("   WELCOME TO DELETE PAGE    ");
             Console.WriteLine("=============================");
            

            
                Console.WriteLine("Enter the account number to delete:");

                if (!long.TryParse(Console.ReadLine(), out long AccDelete))
                {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                break;
                }

            
                 customer_list.Delete(AccDelete);
                

                 while (true)
                {
                    Console.WriteLine("\nWhat would you like to do next?");
                    Console.WriteLine("1. Delete another account");
                    Console.WriteLine("2. Return to Main Menu");
                    Console.WriteLine("3. Exit");
                    Console.Write("Select an option: ");

                    string? choice2 = Console.ReadLine();

                    switch (choice2)
                    {
                        case "1":
                            Console.Clear();
                            break; 

                        case "2":
                            Console.WriteLine("Returning to Main Menu...");
                            goto MainMenu; 

                        case "3":
                            Console.WriteLine("Exiting program... Goodbye!");
                            Environment.Exit(0); 
                            break;

                        default:
                            Console.WriteLine("Invalid choice! Please select 1, 2, or 3.");
                            break; 
                    }
                    break;
                }

                

            }
            

            break; 

       
        case "6":

            while(true)
            {
                Console.WriteLine("=============================");
                Console.WriteLine("   WELCOME TO TRANSFER PAGE   ");
                Console.WriteLine("=============================");

                Console.Write("Enter sender account number: ");
                long fromAcc = long.Parse(Console.ReadLine()!);

                Console.Write("Enter receiver account number: ");
                long toAcc = long.Parse(Console.ReadLine()!);

                Console.Write("Enter amount to transfer: ");
                decimal amount = decimal.Parse(Console.ReadLine()!);


                customer_list.TransferMoney(fromAcc,toAcc,amount);

                while(true)
                {   
                    Console.WriteLine("\nWhat would you like to do next?");
                    Console.WriteLine("1. Transfer to another account");
                    Console.WriteLine("2. Return to Main Menu");
                    Console.WriteLine("3. Exit");
                    Console.Write("Select an option: ");

                     string? choice6 = Console.ReadLine();

                     switch (choice6)
                    {
                        case "1":
                            Console.Clear();
                            break; 

                        case "2":
                            Console.WriteLine("Returning to Main Menu...");
                            goto MainMenu; 

                        case "3":
                            Console.WriteLine("Exiting program... Goodbye!");
                            Environment.Exit(0); 
                            break;

                        default:
                            Console.WriteLine("Invalid choice! Please select 1, 2, or 3.");
                            break; 
                    }
                    break;



                }
                
            }
            
            
            



        case "7":
            Console.WriteLine("Exit the system.Have a good day");
            return;

        default:
            Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
            break;


    }
}
