﻿// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
 
 int sum(int n){
    int counter = Convert.ToString(n).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = n - n % 10;
      result = result + (n - advance);
      n = n / 10;
    }
   return result;
  }

int sumNumber= sum(n);
Console.WriteLine($"Сумма цифр в числе: {sumNumber}");
