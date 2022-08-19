using System;
using System.IO;

class Program {
  public static void Main (string[] args) {
    /*string path = @"MyTest.txt";
    if(!File.Exists(path)){
      //create a file to write to 
      using (StreamWriter sw = File.CreateText(path)){
        sw.WriteLine("Hello");
        sw.WriteLine("And");
        sw.WriteLine("Welcome");
      }
    }
    // Open the file to read from
        using (StreamReader sr = File.OpenText(path))
        {
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    Console.WriteLine(String.Equals("yes","yes"));
    string ss = "Hello world";
    string newstring = ss.Replace("l", "f");
    Console.WriteLine(newstring);*/

    //zad1
    /*string s = Console.ReadLine();
    string path = @"c:\temp\1.txt";
    if(!File.Exists(path)){
      //create a file to write to 
      using (StreamWriter sw = File.CreateText(path)){
      sw.WriteLine(s);
        }
    }*/

    //zad2
    /*string username = Console.ReadLine();
    string password = Console.ReadLine();
    string path = usrname + ".txt";
     if(!File.Exists(path)){
      //create a file to write to 
      using (StreamWriter sw = File.CreateText(path)){
      sw.WriteLine(password);
        }
    }*/

    //zad3
    /*string username = Console.ReadLine();
    string password = Console.ReadLine();
    string path = usrname + ".txt";
    if(!File.Exists(path)){
      Console.WriteLine("invalid username");
    }
    else{
      using (StreamWriter sw = File.OpenText(path)){
        if (sr.ReadLine()==password){
          Console.WriteLine("successful login");
        }
        else {
          Console.WriteLine("invalid password");
        }
      }
    }*/

    //zad4
    
    

  }
}