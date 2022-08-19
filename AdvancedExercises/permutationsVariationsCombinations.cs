using System;
class Combinatorics{

  
    public int permuataions(int a){
      if (a==1){
        return 1;
      }
      else {
        return a*permuataions(a-1);
      }
    }

  public int combination(int n , int k){
    return permuataions(n)/(permuataions(k)*permuataions(n-k));
  }

  public int variation (int n, int k){
    return permuataions(n)/permuataions(k);
  }
}

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    Combinatorics combi = new Combinatorics();
    int n = Convert.ToInt32(Console.ReadLine());
    int k = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("permutaciq: " + combi.permuataions(n));
    Console.WriteLine("variaciq: " + combi.variation(n,k));
    Console.WriteLine("combinaciq: " + combi.combination(n,k));
  }
}