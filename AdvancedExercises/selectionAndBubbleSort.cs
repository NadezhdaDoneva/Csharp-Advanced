using System;

class Program {
  public static void Main (string[] args) {
    //zad1
    /*int[] array = new int[] {55, 15, 32, 6, 48};
    for (int i=0; i<array.Length-1; i++){
      for (int j=i+1; j<array.Length; j++){
        if (array[i]>array[j]){
          int cup = array[i];
          array[i] = array[j];
          array[j]=cup;
        }
      }
    }
    for (int i=0; i<array.Length; i++){
      Console.WriteLine(array[i]);
    }*/

    //zad2
    int[] array = new int[] {5, 15, 32, 6, 48};
    for (int i=0; i<array.Length-1; i++){
      for (int j=0; j<array.Length-1; j++){
        if (array[j]>array[j+1]){
          int cup = array[j];
          array[j] = array[j+1];                                                                        
          array[j+1]=cup;
        }
      }
    }
    for (int i=0; i<array.Length; i++){
      Console.WriteLine(array[i]);
    }
  }
}