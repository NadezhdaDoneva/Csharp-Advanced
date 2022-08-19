using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

//zad1
class Fraction{
  public int enumerator;
  public int denominator;

  public void print(){
    Console.WriteLine(this.enumerator);
    Console.WriteLine(this.denominator);
  }
}

//zad2
class Delivery{
  public double packageWeight;
  public double packagePrice;
  public bool isUrgent;
  public void print(){
    Console.WriteLine(this.packageWeight);
    Console.WriteLine(this.packagePrice);
    Console.WriteLine(this.isUrgent);
  }
}

//zad3
class Ship{
  public string type;
  public double weight;
  public double length;
  public string cargoType;
  public string companyName;
  public void print(){
    Console.WriteLine(this.type);
    Console.WriteLine(this.weight);
    Console.WriteLine(this.length);
    Console.WriteLine(this.cargoType);
    Console.WriteLine(this.companyName);
  }
}

class Program {
    public static void Main(string[] args){
      //zad1
    /*Fraction num = new Fraction();
    num.enumerator = Convert.ToInt32(Console.ReadLine());
    num.denominator = Convert.ToInt32(Console.ReadLine());
    
    IFormatter formatter = new BinaryFormatter();
    Stream stream = new FileStream("stored.dat", FileMode.Create, FileAccess.Write);
    formatter.Serialize(stream, num);
    stream.Close();

    IFormatter formatter2 = new BinaryFormatter();
    Stream stream2 = new FileStream("stored.dat", FileMode.Open, FileAccess.Read);
    Fraction num2 = (Fraction)formatter.Deserialize(stream);
    num2.print();*/
    
    //zad2
    /*Delivery package = new Delivery();
    package.packageWeight = Convert.ToDouble(Console.ReadLine());
    package.packagePrice = Convert.ToDouble(Console.ReadLine());
    package.isUrgent = Convert.ToBoolean(Console.ReadLine());
    
    IFormatter formatter = new BinaryFormatter();
    Stream stream = new FileStream("stored.dat", FileMode.Create, FileAccess.Write);
    formatter.Serialize(stream, package);
    stream.Close();

    IFormatter formatter2 = new BinaryFormatter();
    Stream stream2 = new FileStream("stored.dat", FileMode.Open, FileAccess.Read);
    Delivery package2 = (Delivery)formatter.Deserialize(stream);
    package2.print();*/

    //zad3
    Ship s = new Ship();
    s.type = Console.ReadLine();
    s.weight = Convert.ToDouble(Console.ReadLine());
    s.length = Convert.ToDouble(Console.ReadLine());
    s.cargoType = Console.ReadLine();
    s.companyName = Console.ReadLine();
    
    IFormatter formatter = new BinaryFormatter();
    Stream stream = new FileStream("stored.dat", FileMode.Create, FileAccess.Write);
    formatter.Serialize(stream, package);
    stream.Close();

    IFormatter formatter2 = new BinaryFormatter();
    Stream stream2 = new FileStream("stored.dat", FileMode.Open, FileAccess.Read);
    Delivery package2 = (Delivery)formatter.Deserialize(stream);
    package2.print();
  }
}