﻿// Внимание, внимание! *Начиная с этого дз при оценке учитывается оформление и названия переменных. Будьте внимательны)
// *Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] arrayValues=new int[15];
// int evenNumbers=0;
// for (int i=0;i<arrayValues.Length;i++){

//     arrayValues[i]=new Random().Next(100,1000);
//     if (arrayValues[i]%2==0)
//         evenNumbers++;
// }
// System.Console.WriteLine($"[{string.Join(";",arrayValues)}]");

// System.Console.WriteLine("Кол-во четных чисел в массиве = {0}",evenNumbers);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] randomArray=new int[5];
int sumEvenElements=0;
for (int i=0;i<randomArray.Length;i++){
    randomArray[i]=new Random().Next(1,100);
    if (i%2==0)
        sumEvenElements+=randomArray[i];
}

System.Console.WriteLine($"[{string.Join(";",randomArray)}]");
System.Console.WriteLine("Сумма эелементов стоящих на нечетных позициях = {0}",sumEvenElements);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76