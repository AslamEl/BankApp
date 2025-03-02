namespace BankApp01
{

public class LinkedList
{
    private Node? head;
    

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
            Console.WriteLine("Insufficient Balance.");
            Console.WriteLine("Withdrawl unsucessfull");
            return;
        }
        if(current.Acc_Balance-amount<500)
        {
            Console.WriteLine("Insufficient Balance.Minimum  balance Rs.500.");
            return;
        }

        current!.Acc_Balance=current.Acc_Balance-amount;

        Console.WriteLine($" {amount} withdraw from Account Number {acc_num},New Balance:{current.Acc_Balance}");
        Console.WriteLine("Withdrawl successfull");

    }

    //Merge sort by Account number  Group Member 01

     public Node MergeSort(Node head)
    {
        if (head == null || head.Next == null)
            return head!;

      
        Node middle = MiddleNumber(head);
        Node nextOfMiddle = middle.Next!;
        middle.Next = null;

        
        Node left = MergeSort(head);
        Node right = MergeSort(nextOfMiddle);

       
        return Merge(left, right);
    }
     private Node Merge(Node left, Node right)
    {
        if (left == null) return right;
        if (right == null) return left;

        Node result;
        if (left.Acc_Number<= right.Acc_Number)
        {
            result = left;
            result.Next = Merge(left.Next!, right);
        }
        else
        {
            result = right;
            result.Next = Merge(left, right.Next!);
        }
        return result;
    }
    private Node MiddleNumber(Node head)
    {
        if (head == null) return head!;

        Node slow = head, fast = head.Next!;
        while (fast != null && fast.Next != null)
        {
            slow = slow.Next!;
            fast = fast.Next.Next!;
        }
        return slow;
    }
    // Bubble sort by Account Number Group Member 02
    public void BubbleSort()
    {
    if (head == null || head.Next == null)
        return;

    bool swapped;
    Node current;
    Node lastSorted= null!; 

    do
    {
        swapped = false;
        current = head;

        while (current.Next != lastSorted)
        {
            if (current.Acc_Number > current.Next!.Acc_Number)
            {
                
                long tempAcc = current.Acc_Number;
                current.Acc_Number = current.Next.Acc_Number;
                current.Next.Acc_Number = tempAcc;

                swapped = true;
            }
            current = current.Next!;
        }
        lastSorted = current; 
    } while (swapped);
    }
    //Insertion Sort by Account Number Group Member 03
    public void InsertionSort()
    {
    if (head == null || head.Next == null)
        return;

    Node sorted = null!; 
    Node current = head; 

    while (current != null)
    {
        Node next = current.Next!; 
        sorted = SortedInsert(sorted, current); 
        current = next; 
    }

    head = sorted; 
    }


    private Node SortedInsert(Node sorted, Node newNode)
    {
    if (sorted == null || sorted.Acc_Number >= newNode.Acc_Number)
    {
        newNode.Next = sorted;
        return newNode;
    }

    Node current = sorted;
    while (current.Next != null && current.Next.Acc_Number < newNode.Acc_Number)
    {
        current = current.Next;
    }

    newNode.Next = current.Next;
    current.Next = newNode;

    return sorted;
    }

   
    //Dispaly the accounts

    public void Display()
    {
        Console.WriteLine("=========================");
        Console.WriteLine(" WELCOME TO DISPLAY PAGE ");
        Console.WriteLine("=========================");
        if(head==null)
        {
            Console.WriteLine("There is nothing to display");
            return;
        }

        //BubbleSort();
        InsertionSort();

        //head=MergeSort(head);

        Node current= head;

        

        while(current!=null)
        {
            Console.WriteLine("Name: "+current.Name+"\tAccount Number: "+current.Acc_Number+"\tID Number: "+current.Id_Number+"\tBalance: "+current.Acc_Balance);
            current=current.Next!;
        }
       
    }


   

}

}