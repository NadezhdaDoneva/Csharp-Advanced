using System;

class Program {
  public static void Main (string[] args) {
    //zad1
    /*
    string[] arr = new string[5];
    for (int i=0; i<5; i++){
      arr[i] = Console.ReadLine();
    }
    Array.Sort(arr);
    foreach(string element in arr){
      Console.WriteLine(element);
    }*/

    //zad2
    /*
    string[] arr = new string[5];
    for (int i=0; i<5; i++){
      arr[i] = Console.ReadLine();
    }
    for (int i =0; i<5; i++){
      Console.WriteLine(arr[i].Replace("a","@"));
    }*/

    //zad3

    string[] arr = new string[5];
    string[] arr2 = new string[5];
    for (int i=0; i<5; i++){
      arr[i] = Console.ReadLine();
    }
    for (int i=0; i<5; i++){
    
       
       Console.WriteLine(arr[i][2]);
      
 
    }
  }
}