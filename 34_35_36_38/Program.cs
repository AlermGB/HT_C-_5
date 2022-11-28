// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [ 10, 11, 12, 13, 14 ] -> 5

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


Console.WriteLine("");
Console.WriteLine("Приветствую вас, Алексей! Введите номер задачи из домашнего задания для проверки(34, 35, 36 или 38)");

int taskNumber = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("");

int[] RandomFillArray(int arrayLength,int minBorder,int maxBorder){

    int[] array = new int[arrayLength];     
    maxBorder+=1;

    for (int i=0; i<arrayLength;i++ ){
      array[i]= new Random().Next(minBorder,maxBorder);                
    }
    Console.Write('[' + string.Join(", ", array) + ']');
    return array;
}

int LengthInput(){
    Console.WriteLine("Введите длину массива: ");
    int len = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    return len;
}


//Первая задача (34)
if (taskNumber == 34){

    int counter =0;
    int min = 100;
    int max = 999;
    int length = LengthInput();
    int[] RandomArray=RandomFillArray(length,min,max);
    for (int i=0; i<length; i++){
        if (RandomArray[i]%2==0){
            counter+=1;
        }
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Количество чётных элементов в созданном массиве равно {counter}");

}

//Вторая задача (35)
else if (taskNumber == 35){

    int counter =0;
    int min = 0;
    int max = 200;
    int A =10;
    int B =99;
    int length = 123;
    int[] RandomArray=RandomFillArray(length,min,max);
    for (int i=0; i<length; i++){
        if (RandomArray[i]>=A && RandomArray[i]<=B){
            counter+=1;
        }
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] равно {counter}");
  

}

//Третья задача (36)
else if (taskNumber == 36){

    int sum =0;
    int min = 0;
    int max = 10;
    int length = LengthInput();
    int[] RandomArray=RandomFillArray(length,min,max);
    for (int i=1; i<length; i+=2){
        sum+=RandomArray[i];
        }
    
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях(индексах), равна {sum}");
    
}

//Четвёртая задача (38)
else if (taskNumber == 38){

    double MinMax(string id, double[] arr){

        double maxElement = arr[0];
        double minElement = arr[0];
        for(int i=0; i<arr.Length;i++){
            if (arr[i]>maxElement){
                maxElement=arr[i];
            }
            if (arr[i]<minElement){
                minElement=arr[i];
            }
        }
        if (id == "max"){
            return maxElement;
        }
        if (id == "min"){
            return minElement;
        }
        else{
            Console.WriteLine("Неверный идентификатор");
            return 0;
        }
    }
    
    double differ =0;
    double min = -3;
    double max = 3;
    int length = LengthInput();
    double[] array = new double[length];     
    max+=1;

    for (int i=0; i<length;i++ ){
        array[i]= Math.Round(min + new Random().NextDouble()*(max-min),2);                
    }
    Console.WriteLine('[' + string.Join(", ", array) + ']');

    differ = MinMax("max",array) - MinMax("min",array);
    
    Console.WriteLine();
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {differ}");
}

else{
    Console.WriteLine("Увы, в этом блоке представлено только четыре задачи: 34, 35, 36 или 38");
}

Console.WriteLine();
Console.WriteLine("Всего доброго.");
Console.WriteLine();