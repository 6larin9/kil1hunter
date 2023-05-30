/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    double x = 30;
    double radian = x * Math.PI/180;
    double a = Math.Cos(2*radian);
    double b =  Math.Pow(Math.Cos(radian), 2)-Math.Pow(Math.Sin(radian), 2);
    if (a==b){
        Console.WriteLine("равно");
    }
  }
}
