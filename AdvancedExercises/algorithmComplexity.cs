using System;
//zad1
class Makarty{
  public static int Ma(int n){
    if (n>100){
      return n-10;
    } 
    else {
      return Ma(Ma(n+11));
    }
  }
}

//zad2
class Binomi{
  public static int Pass(int l, int k, int sum=0){
    if (k==0 || l==k){
      return 1;
    } 
    else {
      return Pass(l-1,k)+Pass(l-1,k-1);
    }
  }
}

//zad3
class Solve{
  public static double Sss(double p){
    if (p==1){
      return 1;
    }
    else{
      return Math.Sqrt(p+Sss(p-1));
    }
  } 
}

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    //zad1
    int n  = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Makarty.Ma(n));

    //zad2
    int l  = Convert.ToInt32(Console.ReadLine());
    int k  = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Binomi.Pass(l,k));

    //zad3
    double p  = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(Solve.Sss(p));
  }
}