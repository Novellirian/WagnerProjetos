using System;

public class Program{
  public static void Main()
  {
    DBConnection c1 = DBConnection.Instance;
    c1.ExecuteCommand("SELECT * FROM xpto");
    //.....

    DBConnection c2 = DBConnection.Instance;
    c2.ExecuteCommand("UPDATE xpto SET name='Jose' WHERE id = 12");

    if(c1 == c2){
      Console.WriteLine("São a mesma instância de conexão!");
    }
  }
}