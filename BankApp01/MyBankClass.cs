using System;

namespace BankApp01
{


    public class TreeNode
    
    {
        public Node? Account;

        public TreeNode? Left;
        public TreeNode? Right;



        public TreeNode(Node account)
        {
            Account=account;
            Left=null;
            Right=null;


        }

    }

public class BinarySearchTree
{

    private TreeNode? root;


    public void Insert(Node account)
    {
        TreeNode newNode= new TreeNode(account);

        if(root==null)
        {
            root=newNode;
        }

        else
        {
            InsertRecu(root,newNode);
        }
    }

    public void InsertRecu(TreeNode root,TreeNode newNode)
    {

        if(newNode?.Account?.Acc_Number<root?.Account?.Acc_Number)
        {
            if(root.Left==null)
            {
            root.Left=newNode;
            }
            else
            {
                InsertRecu(root.Left,newNode);
            }
        }

        else
        {
            if(root?.Right==null)
            {
            root!.Right=newNode;
            }
            else
            {
                InsertRecu(root.Right,newNode!);
            }

        }




    }


    public void InorderTravesel(TreeNode node)

    {
        if(node!=null)
        {
            InorderTravesel(node.Left!);
          
            Console.WriteLine($"Name: {node.Account!.Name}, Account Number: {node.Account.Acc_Number}, ID Number: {node.Account.Id_Number}, Account Balance: {node.Account.Acc_Balance}");
             InorderTravesel(node.Right!);
        }
    }

    public void DisplayAccounts()
    {
        InorderTravesel(root!);
    }



    public TreeNode? DeleteRec(TreeNode? root, long acc_num)
{
    if (root == null) return root;

    if (acc_num < root.Account!.Acc_Number)
        root.Left = DeleteRec(root.Left, acc_num);
    else if (acc_num > root.Account.Acc_Number)
        root.Right = DeleteRec(root.Right, acc_num);
    else
    {
        if (root.Left == null)
            return root.Right;
        else if (root.Right == null)
            return root.Left;

        root.Account = MinValue(root.Right);
        root.Right = DeleteRec(root.Right, root.Account.Acc_Number);
    }

    return root;
}

private Node MinValue(TreeNode node)
{
    Node minv = node.Account!;
    while (node.Left != null)
    {
        minv = node.Left.Account!;
        node = node.Left;
    }
    return minv;
}

public void Delete(long acc_num)
{
    root=DeleteRec(root,acc_num);
}



}
}