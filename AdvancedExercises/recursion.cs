using System;

/*
//zad1
class Digit{
public void digitToWord(int digit){
  if (digit==1){
    Console.WriteLine("one");
  }
else if (digit==2){
  Console.WriteLine("two");
}
else if (digit==3){
  Console.WriteLine("three");
}

  else if (digit==4){
  Console.WriteLine("four");
}

  else if (digit==5){
  Console.WriteLine("five");
}

  else if (digit==6){
  Console.WriteLine("six");
}

  else if (digit==7){
  Console.WriteLine("seven");
}

  else if (digit==8){
  Console.WriteLine("eight");
}

  else if (digit==9){
  Console.WriteLine("nine");
}
}
}
*/



class Program {
  public static void Main (string[] args) {
  //zad1
    Digit m = new Digit();
    int n = Convert.ToInt32(Console.ReadLine());
    int reverse = 0;
    int rem;
    while (n!=0){
      rem = n%10;
      reverse = reverse*10+rem;
      n/=10;
    }
  Console.WriteLine(reverse);
    while (reverse!=0){
      m.digitToWord(reverse%10);
      reverse=reverse/10;
    }


    //zad2
double osnova = Convert.ToInt32(Console.ReadLine());
    double stepen =  Convert.ToInt32(Console.ReadLine());
    int counter = 1;
    double y=osnova;
    while (counter<stepen){
     y = Math.Pow(osnova, y);
      counter++;
    }
  Console.WriteLine(y);
    

    //zad3
    double n = Convert.ToDouble(Console.ReadLine());
    double x = 1;
    double avrg;
    double sq;
    while (n>x*x){
      x++;
    }
  if (n==x*x){
    Console.WriteLine(x);
  }
  else {
    avrg = (2*x-1)/2;
    sq = n/avrg;
    for (int i =1; i<20; i++){
      avrg=(sq+avrg)/2;
      sq = n/avrg;
    }
  Console.WriteLine(sq);
  }
  }
}