using System;
public class DBConnection
{
  private static DBConnection _instance;
  private DBConnection(){
    Console.WriteLine("Nova conexão criada.");
  }
  public static DBConnection Instance
  {
    get
    {
      if(_instance == null)
      {
        _instance = new DBConnection();
      }
      return _instance;
    }
  }
  public void ExecuteCommand(string sql)
  {
    Console.WriteLine($"Executando comando: {sql}");
  }
}

