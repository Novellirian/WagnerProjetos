using System; 
using System.Collections.Generic;

public class Bank{
  public string Name {get;set;}
  public int Code {get;set;}

  public List<Branch> branches = new List<Branch> {};
  public List<Client> clients = new List<Client> {};


  public Bank(string name,int code){
    Name = name;
    Code = code;
  }

  public void addBranch(Branch b){
    branches.Add(b);
  }

  public void removeBranch(Branch b){
    branches.Remove(b);
  }

  public List<Branch> getBranches(){
    return branches;
  }

  public Branch getBranch(int code){
    foreach(Branch b in branches){
      if(b.Code == code){
        return b;
      }
    }
    return null;   
  }

  public void addClient(Client c){
    clients.Add(c);
  }

  public Client getClient(string cpf){
    foreach(Client c in clients){
      if(c.Cpf == cpf){
        return c;
      }
    }
    return null;
  }

}