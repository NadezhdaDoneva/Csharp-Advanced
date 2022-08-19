using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    //zad1
    /*
    int [,] arr1 = new int [3,3];
    int [,] arr2 = new int [3,3];
    int mult=1;

    for(int row=0; row<3; row++){
      for (int col=0; col<3; col++){
        arr1[row,col] = int.Parse(Console.ReadLine());
      }
    }
    for(int row=0; row<3; row++){
      for (int col=0; col<3; col++){
        arr2[row,col] = int.Parse(Console.ReadLine());
      }
    }

    for(int row=0; row<3; row++){
      for (int col=0; col<3; col++){
        mult = arr1[row,col]*arr2[row,col];
        Console.WriteLine(mult);
      }
    }*/
    
    //zad2
    /*
    int [,] arr1 = new int [3,3];
    int [,] arr2 = new int [3,3];
    for(int row=0; row<3; row++){
      for (int col=0; col<3; col++){
        arr1[row,col] = int.Parse(Console.ReadLine());
      }
    }
    for(int row=0; row<3; row++){
      for (int col=0; col<3; col++){
        Console.WriteLine(arr2[row,col] = arr1[row,col]*3);
      }
    }*/

    //zad3
    /*
    int [,] arr1 = new int [3,3];
    for(int row=0; row<3; row++){
      for (int col=0; col<3; col++){
        arr1[row,col] = int.Parse(Console.ReadLine());
      }
    }
    for(int row=0; row<3; row++){
      for (int col=0; col<3; col++){
        if (arr1[row,col]%3==0){
          arr1[row,col]=0;
        }
      }
    }
    for(int row=0; row<3; row++){
      for (int col=0; col<3; col++){
        Console.WriteLine(arr1[row,col]);
      }
    }*/

    //zad4
    int [,] arr1 = new int [4,4];
    int cup;
    for(int row=0; row<4; row++){
      for (int col=0; col<4; col++){
        arr1[row,col] = int.Parse(Console.ReadLine());
      }
    }
    for(int row=0; row<4; row++){
      for (int col=0; col<4; col+=2){
        cup = arr1[row,col];
        arr1[row,col]= arr1[row,col+1];
        arr1[row,col+1]=cup;
      }
    }
    for(int row=0; row<4; row++){
      for (int col=0; col<4; col++){
        Console.WriteLine(arr1[row,col]);
      }
    }
  }
}