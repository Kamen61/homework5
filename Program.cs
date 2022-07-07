// Внимание, внимание! *Начиная с этого дз при оценке учитывается оформление и названия переменных. Будьте внимательны)
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

// int[] randomArray=new int[5];
// int sumEvenElements=0;
// for (int i=0;i<randomArray.Length;i++){
//     randomArray[i]=new Random().Next(1,100);
//     if (i%2==0)
//         sumEvenElements+=randomArray[i];
// }

// System.Console.WriteLine($"[{string.Join(";",randomArray)}]");
// System.Console.WriteLine("Сумма эелементов стоящих на нечетных позициях = {0}",sumEvenElements);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] array = new double[10];
for (int i = 0; i < array.Length; i++)
{

    array[i] = new Random().NextDouble();

}
System.Console.WriteLine($"[{string.Join(";", array)}]");
int indexMaxNumber = 0;
int indexMinNumber = 0;
double difference = 0;
for (int j = 1; j < array.Length; j++)
{
    if (array[j] > array[indexMaxNumber])
        indexMaxNumber = j;
    if (array[j] < array[indexMinNumber])
        indexMinNumber = j;
}
difference = array[indexMaxNumber] - array[indexMinNumber];
System.Console.WriteLine();
System.Console.WriteLine($"Максимальное значение из массива {Convert.ToString(array[indexMaxNumber])}");
System.Console.WriteLine($"Минимальное значение из массива {Convert.ToString(array[indexMinNumber])}");
System.Console.WriteLine($"Разница между минимальным значение и максимальным = {difference}");

