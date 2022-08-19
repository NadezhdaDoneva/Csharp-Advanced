using System;
using System.Collections;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    //zad1
    /*ArrayList list = new ArrayList();
    string a;
    while (true){
      a = Console.ReadLine();
      if (a=="s"){
        break;
      }
      list.Add(Convert.ToDouble(a));
    }
    for (int i=0; i<list.Count; i++){
      Console.WriteLine(list[i]);
    }
    Console.WriteLine("lista ima duljina: "+list.Count);*/

    //zad2
    /*
    ArrayList list0 = new ArrayList();
    ArrayList list1 = new ArrayList();
    string a;
    double b;
    while (true){
      a = Console.ReadLine();
      if (a=="s"){
        break;
      }
      b = Convert.ToDouble(a);
      if (b%2==0){
        list0.Add(b);
      }
      else{
        list1.Add(b);
      }
    }
      for (int i=0; i<list0.Count; i++){
      Console.Write(list0[i] + " ");
    }
      Console.WriteLine(" ");
      for (int i=0; i<list1.Count; i++){
      Console.Write(list1[i] + " ");
    }*/
    

    //zad3
    /*
    ArrayList list = new ArrayList();
    string a;
    double sum=0;
    while (true){
      a = Console.ReadLine();
      if (a=="s"){
        break;
      }
      list.Add(Convert.ToDouble(a));
    }
    for (int i=0; i<list.Count; i++){
      sum +=Convert.ToDouble(list[i]);
    }
    Console.WriteLine(sum%list.Count);
*/

    //zad4
    /*ArrayList list = new ArrayList();
    ArrayList list2 = new ArrayList();
    string a;
    while (true){
      a = Console.ReadLine();
      if (a=="s"){
        break;
      }
      list.Add(Convert.ToDouble(a));
    }
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i=m; i<n; i++){
      list2.Add(Convert.ToDouble(list[i]));
    }
    for (int i=0; i<list2.Count; i++){
      Console.Write(list2[i]);
    }*/

    //zad5
    ArrayList list = new ArrayList();
    ArrayList list2 = new ArrayList();
    string a;
    int sum=0;
    while (true){
      a = Console.ReadLine();
      if (a=="s"){
        break;
      }
      list.Add(Convert.ToDouble(a));
    }
    int limit = Convert.ToInt32(Console.ReadLine());
    for (int i=0; i<list.Count-1; i++){
      sum = Convert.ToInt32(list[i]) + Convert.ToInt32(list[i+1]);
      if (sum<=limit){
       Console.Write(list[i]);
      }
    }
  }
}