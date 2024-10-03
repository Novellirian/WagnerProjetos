using System; 

public abstract class Account{
  public int Acc_number {get;set;}
  private float Balance = 0;
  public DateTime Opening_Date {get;set;}
  public Client client;


  public virtual void debitAmount(float q){
    if(q > 0){
      Balance -= q;
    }else{
      throw new AccountException("Não pode debitar valores negativos!");
    }
  }
  public virtual void creditAmount(float q){
    if(q > 0){
      Balance += q;
    }
  }
  public virtual float getBalance(){
    return Balance;

  }
  public virtual void transfer(Account a,float q){
    if(Balance>=0){
      Balance -= q;
      a.Balance += q;
    }


  }
}