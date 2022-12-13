/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

Console.WriteLine("ВВедите числа через запятую: ");         //здесь просим ввести число элементов
string? s = Console.ReadLine();
string [] numbs = s.Split(',');
 
int count = 0;
int [] array = new int [numbs.Length];

for (int i = 0; i < numbs.Length; i++)
{
    array [i] = Convert.ToInt32(numbs[i]);
    if  (array[i] > 0 )count++;
}

Console.WriteLine ($" Пользователь ввел {count} чисел больще нуля");
//конец первой задачи


/* 

int sum = 0;          //сумма элементов на нечетных позициях
for (int i=0; i<N; i++)             
{
    if (i%2 == 1 ) sum = sum + array[i];
}

Console.WriteLine("Заданный массив: ");
Print_array(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях {sum}");


 */ 

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

/* Console.WriteLine("ВВедите число b1: ");         
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите число k1: ");          
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите число b2: ");          
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите число k2: ");          
int k2 = Convert.ToInt32(Console.ReadLine());

double [] array = new double [2];

array [0]= (double) (b2-b1) / (k1-k2);
array [1] = array[0] * k1 + b1;

Console.WriteLine($"Координаты точки пересечения прямых: {array[0]}, {array[1]}");  */