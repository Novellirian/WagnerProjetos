using System; 

public class Program {

  public static void Main(string[] args) {
    Bank b1 = new Bank("Banco do Brasil",1);
    Branch br1 = new Branch(1,"Itapuã","Vila Velha");
    Client c1 = new Client("123","João","Rua A","123321","Joao@email.com");
    Client c2 = new Client("124","Pedro","Rua B","123456","pEDRO@email.com");
    Account ca1 = new CurrentAccount(1,c1);
    Account sa1 = new SavingsAccount(2,c2);

    b1.addBranch(br1);
    b1.addClient(c1);
    br1.addAccount(ca1);
    br1.addAccount(sa1);


    foreach(Branch b in b1.branches){
      Console.WriteLine("Agência: " + " "+ b.Name+" "+b.City);
      foreach(Account a in b.accounts){
        Console.WriteLine(a.Acc_number+" "+a.client.Name+" "+a.getBalance());
      }
    }

    ca1.creditAmount(5);
    sa1.creditAmount(10);
    try{
      ca1.debitAmount(-100);
    }catch (AccountException ae){
      Console.WriteLine("Erro: " + ae.Message);
    }



    foreach(Branch b in b1.branches){
      Console.WriteLine("Agência: "+ b.Name+" "+b.City);
      foreach(Account a in b.accounts){
        Console.WriteLine(a.Acc_number+" "+a.client.Name+" "+a.getBalance());
      }
    }

    ca1.transfer(sa1,5);


    foreach(Branch b in b1.branches){
      Console.WriteLine("Agência: " + " "+ b.Name+" "+b.City);
      foreach(Account a in b.accounts){
        Console.WriteLine(a.Acc_number+" "+a.client.Name+" "+a.getBalance());
      }
    }
  }
}