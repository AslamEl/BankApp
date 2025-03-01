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
}