using System;
using System.Collections.Generic;

//zad1
/*
class Student{
  public string name;
  public int age;
  public int grade;
  public string gender;

  public Student(string n, int a, int gr, string ge){
    this.name=n;
    this.age=a;
    this.grade=gr;
    this.gender=ge;
  }

  public void showStudent(){
    Console.WriteLine(this.name);
    Console.WriteLine(this.age);
    Console.WriteLine(this.grade);
    Console.WriteLine(this.gender);
  }
}
*/


class Book{
  public string author;
  public string title;
  public int year;

  public Book(string a, string t, int y){
    this.author=a;
    this.title=t;
    this.year=y;
  }

  public void print(){
    Console.WriteLine(this.author);
    Console.WriteLine(this.title);
    Console.WriteLine(this.year);
  }
}


class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    //zad1
    /*
    List<Student> list=new List<Student>();
    string name;
    int age;
    int grade;
    string gender;
    string vikam;

    for (int i=0; i<3; i++){
      name = Console.ReadLine();
      age = Convert.ToInt32(Console.ReadLine());
      grade = Convert.ToInt32(Console.ReadLine());
      gender = Console.ReadLine();

      list.Add(new Student(name, age, grade, gender));
    }

    Console.WriteLine("vuvedi ime:");
    vikam = Console.ReadLine();

    for (int i=0; i<3; i++){
      if (vikam.Equals(list[i].name)){
        list[i].showStudent();
      }
    }*/

    List<Book> list=new List<Book>();
    string author;
    string title;
    int year;

    for (int i=0; i<3; i++){
      author = Console.ReadLine();
      title = Console.ReadLine();
      year = Convert.ToInt32(Console.ReadLine());

      list.Add(new Book(author, title, year));
    }
    for (int i=0; i<3; i++){
      list[i].print();
  }
}
}