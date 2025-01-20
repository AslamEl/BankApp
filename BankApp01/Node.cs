namespace BankApp01
{

public class Node
{
    public string? Name;
    public long Acc_Number;
    public long Id_Number;
    public Node? Next;
    public Node (string name,long acc_num,long id_num)
    {
        Name=name;
        Acc_Number=acc_num;
        Id_Number=id_num;
        Next=null;

    }


}

public class LinkedList
{
    private Node? head;

    //to add the name in linkedlistname
    public void Add(string name,long acc_num,long id_num)
    {
        Node newNode=new Node(name,acc_num,id_num);

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


    public bool Delete(int acc_num)
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
        while (current.Next!=null && current.Acc_Number!=acc_num)
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

    //to display the name

    public void Display_name()
    {
        if (head==null)
        {
            Console.WriteLine("Empty");
            return;
        }
        Node? current=head;

        while(current!=null)
        {
            Console.WriteLine($"Name:{current.Name},Account Number:{current.Acc_Number},ID Number:{current.Id_Number}");
            current=current.Next;
        }

    }


}




}