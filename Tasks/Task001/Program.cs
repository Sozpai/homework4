//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();
int numbers(int i, int n){
  int result = 1;
  for(int x=1; x <= n; x++){
    result = result * i;
  }
    return result;
}

  Console.Write("Введите первое число: ");
  int i = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите второе число: ");
  int n= Convert.ToInt32(Console.ReadLine());

  int exponentiation = numbers(i, n);
  Console.WriteLine("Ответ: " + exponentiation);