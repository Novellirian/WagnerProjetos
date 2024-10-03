using System; 

public class CurrentAccount : Account{

  public float ServiceFee {get;set;}
  public float Limit {get;set;}

  public CurrentAccount(int acc_number,Client c){
    Acc_number = acc_number;
    Opening_Date = DateTime.Now;
    client = c;
  }
}