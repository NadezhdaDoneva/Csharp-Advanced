using System;

class Program {
  public static void Main (string[] args) {

  //zad1
    int [,] arr = new int [4,4];
    for (int i=0; i<4; i++){
      for (int j=0; j<4; j++){
        arr[i,j] = Convert.ToInt32(Console.ReadLine());
      }
    }

    for (int i=0; i<4; i++){
      for (int j=0; j<4; j++){
        Console.WriteLine(arr[i,j] + " ");
      }
    }
    
  }
}