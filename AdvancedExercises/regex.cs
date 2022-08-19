using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    //zad1
    /*
    string password = Console.ReadLine();
    Regex re = new Regex(@"[0-9]");
    Regex reg = new Regex(@"[A-z]");
    Regex rege = new Regex(@"[-/+{}@!#$%^&*_]");
    if (password.Length>=8){
      if(re.IsMatch(password)&&reg.IsMatch(password)&&rege.IsMatch(password)){
        Console.WriteLine("True");
    }
    else{
      Console.WriteLine("False");
    }
    }
  */
    
    //zad2
    /*
    string password = Console.ReadLine();
    Regex re = new Regex(@"[0-9]");
    Regex rege = new Regex(@"[-/+{}@!#$%^&*_]");
      if(re.IsMatch(password)||rege.IsMatch(password)){
        Console.WriteLine("False");
    }
    else{
      Console.WriteLine("True");
    }
*/

    //zad3
    string katalog = "Ivan Lubo Pesho Mitko Misha Rado Stefaka Jeko Koce Marihuan";
    Regex re = new Regex();
    }
  }