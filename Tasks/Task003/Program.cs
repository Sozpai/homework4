// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

Console.Clear();
Console.Write("Введите количество элементов массива:");
int n= Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
for(int i =0; i< array.Length; i++){
    Console.Write($"\nВведите элемент массива:");
 array[i]= Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Результат: [{string.Join(", ", array)}]");
