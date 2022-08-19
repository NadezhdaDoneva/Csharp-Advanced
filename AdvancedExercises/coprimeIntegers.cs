using System;

class Program {
  public static void Main (string[] args) {
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    for (int i=2; i<a; i++){
      if (a%i==0){
        int delitel1 = i;
        Console.WriteLine(delitel1);

        for (int p=2; p<b; p++){
      if (b%p==0){
        int delitel2 = p;
        Console.WriteLine(delitel2);
      if (delitel1!=delitel2){
      Console.WriteLine("vzaimnoprosti sa");
      }
      else {
        Console.WriteLine("ne sa vzaimnoprosti");
      }
    }
    }
}
}
}
}