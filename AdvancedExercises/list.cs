using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    //zad1
    /*
    List<int> list = new List<int>();
    List<int> list1 = new List<int>();
    int a;
    int temp;
    for (int i=0; i<10; i++){
      a = Convert.ToInt32(Console.ReadLine());
      list.Add(a);
    }
    Console.WriteLine("vuvedi razdelqshto chislo: ");
    int b = Convert.ToInt32(Console.ReadLine());
    for (int i=0; i<list.Count; i++){
      if (b==list[i]){
        temp =i;
        list.Remove(list[i]);
        for (int j=0; j<temp; j++){
          Console.Write(list[j] + " ");
        }
        Console.WriteLine("");
        for (int m=temp; m<list.Count; m++){
          Console.Write(list[m] + " ");
        }
      }
      }
*/
    //zad2
    /*
    List<double> list = new List<double>();
    double a = Convert.ToInt32(Console.ReadLine());
    double result;
    for (int i=0; i<=a; i++){
      result = -i*i+3*i-2;
      list.Add(result);
    }
    for (int i=0; i<list.Count; i++){
      Console.WriteLine(list[i]);
    }*/

    //zad3
    /*
    List<double> list = new List<double>();
    double a = Convert.ToInt32(Console.ReadLine());
    double result;
    for (int i=0; i<=a; i++){
      result = Math.Pow(2,i);
      list.Add(result);
    }
    for (int i=0; i<list.Count; i++){
      Console.WriteLine(list[i]);
    }*/

    //zad4
    List<double> list = new List<double>();
    int a;
    for (int i=0; i<10; i++){
      a = Convert.ToInt32(Console.ReadLine());
      list.Add(a);
    }
    Console.WriteLine("vuvedi chislo: ");
    int b = Convert.ToInt32(Console.ReadLine());
    for (int i=0; i<list.Count; i++){
      Console.Write(b + " , " + list[i] + " , ");
    }
  }
}