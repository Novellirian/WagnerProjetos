using System; 

public class SavingsAccount : Account{
  public float Rate {get;set;}

  public SavingsAccount(int acc_number,Client c){
    Acc_number = acc_number;
    Opening_Date = DateTime.Now;
    client = c;
  }
}