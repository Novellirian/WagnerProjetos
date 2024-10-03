using System; 
using System.Collections.Generic;

public class Branch{
  public string Name {get;set;}
  public int Code {get;set;}
  public string City {get;set;}

  public List<Account> accounts = new List<Account> {};

  public Branch(int code,string name,string city){
    Code = code;
    Name = name;
    City = city;
  }

  public void addAccount(Account a){
    accounts.Add(a);
  }
  public void removeAccount(Account a){
    accounts.Remove(a);
  }

  public Account getAccount(int acc_number){
    foreach(Account a in accounts){
      if(a.Acc_number == acc_number){
        return a;
      }
    }
    return null;   
  }

}