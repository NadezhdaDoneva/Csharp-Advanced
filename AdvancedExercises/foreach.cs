using System;

class Program {
  public static void Main (string[] args) {
    //zad1
    /*Console.WriteLine ("Hello World");
    int[] arr = new int[10];
    int sum=0;
    for (int i=0; i<10; i++){
      arr[i]=Convert.ToInt32(Console.ReadLine());
    }
    Array.Sort(arr);
    foreach(int element in arr){
      Console.WriteLine(element);
    }
    for (int i=0; i<5; i++){
      sum+=arr[i];
    }
    Console.WriteLine("the sum is: " + sum);*/

    //zad2
    /*int counter = 0;
    bool next = true;
    int[] arr = new int[100];

    
    while (next){
      next = Convert.ToBoolean(Console.ReadLine());
      arr[counter]= Convert.ToInt32(Console.ReadLine());
      counter++;
    }

    Array.Sort(arr);
    Console.WriteLine(arr[counter-1]);
    Console.WriteLine(arr[counter-2]);
    Console.WriteLine(arr[counter-3]);*/

    //zad3
    /*int[] arr = new int[10];
    int temp;
    for (int i=0; i<10; i++){
      arr[i]=Convert.ToInt32(Console.ReadLine());
    }
    Array.Sort(arr);
    int min = arr[0];
    int max = arr[9];

    for(int i=0; i<10; i++){
      temp=(arr[i]-min)/(max-min);
      Console.WriteLine(temp);
    }*/

    //zad4
     int[] arr = new int[10];
     for (int i=0; i<10; i++){
      arr[i]=Convert.ToInt32(Console.ReadLine());
    }
    Array.Sort(arr);
    for (int i=0; i<5; i++){
      Console.Write(arr[i]);
    }
    for (int i=9; i>=5; i--){
      Console.Write(arr[i]);
    }
  }
}