using System; 
using System.Collections.Generic;

public class Client{
  public string Cpf {get;set;}
  public string Name {get;set;}
  public string Adress {get;set;}
  public string Phone {get;set;}
  public string Email {get;set;}

  public List<Account> accounts = new List<Account> {};

  public Client(string cpf,string name,string adress,string phone,string email){
    Cpf = cpf;
    Name = name;
    Adress = adress;
    Phone = phone;
    Email = email;
  }
}