/* 
  Collections: 
    - Dictionaries(Dictionary<Tkey, TValue>): Tamanho fixo, não ordenado, não indexado, não mutável e permite duplicatas. (Chave e valor))
*/
using System;
using System.Collections.Generic;

class Program{
  public static void Main(string[] args){
    Dictionary<string, int> idades = new Dictionary<string, int>{
      {"Carlos", 30},
      {"Joao", 22},
      {"Clara", 18},
      {"Wagner", 0}
    };

    idades.Add("Alice", 25);
    idades.Add("Jhon", 28);

    Console.WriteLine("Clara tem " + idades["Clara"] + " anos.");

    if (idades.ContainsKey("Bob")){
      Console.WriteLine("Eu sei a idade do Bob.");
    }else{
      Console.WriteLine("Eu não sei a idade do Bob.");
    }

    idades["Clara"] = 19;

    Console.WriteLine("Clara tem " + idades["Clara"] + " anos.");

    idades.Remove("Clara");

    if (idades.ContainsKey("Clara")){
      Console.WriteLine("Eu não sei a idade da Clara.");
    }else{
      Console.WriteLine("Eu não sei a idade da Clara.");
    }

    foreach (KeyValuePair<string, int> pair in idades){
      Console.WriteLine(pair.Key + " possui " + pair.Value + " anos.");
    }

    foreach (string nome in idades.Keys){
      Console.WriteLine(nome + " possui " + idades[nome]);
    }

    Console.WriteLine("Sabemos a idade de " + idades.Count + " pessoas.");

    idades.Clear();
    Console.WriteLine("Sabemos a idade de " + idades.Count + " pessoas.");
    
  }
}