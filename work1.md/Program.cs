// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// [1, 2, 3, 4] -> [2, 4]
// [1, 3, 4, 5, 7, 1, 3] -> [4]
// [2, -4, 6] -> [2, -4, 6]
// [1, 3, 5] -> []

void printArr(int[] array)
{
    for(int i = 0; i < array.Length; i++ )
     {
     Console.Write(array[i] + " ");    
     }
     Console.WriteLine();
 }

void SelectChet(int[] array)
{
    for(int i = 0; i < array.Length; i++ )
    {
        if (array[i] % 2 == 0)
        {
            Console.Write(array[i] +" ");
        }
    }
}   

// 1 вводи массива руками
int[] array = { 2, 7, 9, 12, 13, 15, 16, 21, 84, 91, 75, 17, 28, 31 };

printArr(array);
SelectChet(array);

Console.WriteLine();


// 2 вывод массива с случайными цифрами

void PrintRandArr(int[] array)
{
        for (int i = 0; i < array.Length; i++)
        {
           array[i] = new Random().Next(1, 50);
           Console.Write(array[i] +" ");
        }
}

int[] arr = new int[20];
PrintRandArr(arr);
Console.WriteLine();
SelectChet(arr);