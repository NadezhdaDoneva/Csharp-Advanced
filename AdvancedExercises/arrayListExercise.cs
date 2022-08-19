using System;
using System.Collections;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    //zad1
    /*
    ArrayList list0 = new ArrayList();
    ArrayList list1 = new ArrayList();
    int num0;
    int num1;
    int a;
    int b;
    bool yes = false;

    for (int i=0; i<10; i++){
      num0 = Convert.ToInt32(Console.ReadLine());
      list0.Add(num0);
    }
    for (int i=0; i<10; i++){
      num1 = Convert.ToInt32(Console.ReadLine());
      list1.Add(num1);
    }

    for (int i=0; i<10; i++){
      for (int j=0; j<10; j++){
        a = Convert.ToInt32(list0[i]);
        b = Convert.ToInt32(list1[j]);
        if (a==b){
          yes = true;
          break;
        }
      }
    }
    Console.WriteLine(yes);*/

    //zad2
    /*
    ArrayList list = new ArrayList();
    int num;
    for (int i=0; i<10; i++){
      num = Convert.ToInt32(Console.ReadLine());
      list.Add(num);
    }
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i=0; i<10; i++){
      if (n<Convert.ToInt32(list[i])){
        Console.WriteLine(list[i]);
      }
    }*/

    //zad3
    ArrayList list0 = new ArrayList();
    ArrayList list1 = new ArrayList();
    int num0;
    int num1;
    int a;
    int b;

    for (int i=0; i<10; i++){
      num0 = Convert.ToInt32(Console.ReadLine());
      list0.Add(num0);
    }
    for (int i=0; i<10; i++){
      num1 = Convert.ToInt32(Console.ReadLine());
      list1.Add(num1);
    }
    for (int i=0; i<10; i++){
      for (int j=0; j<10; j++){
        a = Convert.ToInt32(list0[i]);
        b = Convert.ToInt32(list1[j]);
        if (a==b){
          Console.WriteLine(list0[i]);
        }
      }
    }
  }
}