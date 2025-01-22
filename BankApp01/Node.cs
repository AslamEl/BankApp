namespace BankApp01
{

public class Node
{
    public string? Name;
    public long Acc_Number;
    public string? Id_Number;

    public decimal Acc_Balance;

    public decimal F_deposit;
    
    
    public Node? Next;
    public Node (string name,long acc_num,string id_num,decimal f_deposit)
    {
        Name=name;
        Acc_Number=acc_num;
        Id_Number=id_num;
        F_deposit=f_deposit;
        Acc_Balance=f_deposit;
        Next=null;

    }


}

public class LinkedList
{
    private Node? head;
    private BinarySearchTree bst= new BinarySearchTree();

    //to add the new customer to the system
    public void Add(string name,long acc_num,string id_num,decimal f_deposit)
    {
        Node newNode=new Node(name,acc_num,id_num,f_deposit);

        

        if (head==null)
        {
            head=newNode;
        }
        else
        {
            Node? current =head;
            while(current.Next!=null)
        
            {
                current=current.Next;

            }
            current.Next=newNode;

        }

        bst.Insert(newNode);
    }

    public bool AccountExists(long acc_num)
    {
        Node? current=head;

        while(current!=null)
        {
            if(current.Acc_Number==acc_num) return true;
            current=current.Next;
        }
        return false;
    }
    



    //delete an Account
    public bool Delete(long acc_num)
    {
        if (head==null)
        {
            Console.WriteLine("There is nothing to delete");
            return false;
        }
        if(head.Acc_Number==acc_num)
        {
            head=head.Next;
            bst.Delete(acc_num);
            Console.WriteLine($"Account {acc_num} deleted succesfully");
            return true;
        }

        Node? current=head;
        
        while (current.Next!=null && current.Next.Acc_Number!=acc_num)
        {
           
            current=current.Next;
        }

        if(current.Next==null)
        {
            Console.WriteLine("The account number is not found");
            return false;
        }

        current.Next=current.Next.Next;
        bst.Delete(acc_num);

        Console.WriteLine($"Account {acc_num} deleted successfully");
        return true;





    }
    
    //for deposit money

    public void Deposit(long acc_num,decimal amount)
    {
        Node? current=head;


        while(current!=null && current?.Acc_Number!=acc_num)
        {
            current=current?.Next;
        }

        if(current==null)
        {
            Console.WriteLine("Account not found");
            return;
        }

        current!.Acc_Balance=current.Acc_Balance+amount;

        Console.WriteLine($"Deposited {amount} to Account Number {acc_num},New Balance:{current.Acc_Balance}");


    }

    public void Withdrawl(long acc_num,decimal amount)
    {
        Node? current=head;
        while(head!=null && current?.Acc_Number!=acc_num)
        {
            current=current?.Next;
        }
        if(head==null)
        {
            Console.WriteLine("Account not found");
            return;
        }
        if(current!.Acc_Balance<amount)
        {
            Console.WriteLine("Account balance is too low");
            return;
        }
        if(current.Acc_Balance-amount<500)
        {
            Console.WriteLine("Account Balance is too law.Minimum  balance Rs.500 ");
            return;
        }

        current!.Acc_Balance=current.Acc_Balance-amount;

        Console.WriteLine($" {amount} withdraw from Account Number{acc_num},New Balance:{current.Acc_Balance}");

    }

   
    //dispaly the accounts

    public void Display()
    {
        if(head==null)
        {
            Console.WriteLine("There is nothing to display");
            return;
        }
        bst.DisplayAccounts();
    }


   

}

}