using System;
using System.Collections;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    string temp = Console.ReadLine();
    Queue myQ = new Queue();
    bool proverka = true;
    while (proverka){
      if (temp=="q"){
        proverka=false;
        break;
      }
      myQ.Enqueue(temp);
      temp = Console.ReadLine();
    }
    int count = myQ.Count;
    for (int i=0; i<count; i++){
      Console.WriteLine(myQ.Dequeue());
    }
  }
}