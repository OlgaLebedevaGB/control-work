//Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 
// 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
// задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

//метод вывода двумерного массива на экран


// метод вывода на экран массива (элемент - значение)
void ShowIntMas (int [] array)
{
    for (int count=0; count <array.Length; count++) Console.WriteLine ($"Элемент массива {count} - {array[count]}");
}
// ShowIntMas (myArray);


int [] CopyArray (int[] array)
{
    int[] mas = new int [array.Length];
    for (int i=0; i<array.Length; i++) mas[i]=array[i];
    return mas;
}
// int [] newArray= CopyArray(myArray);
// ShowIntMas(newArray);


// char[] s = { 'a', 'и','с','в'};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j=0; j < count; j++)
//     {
//         Console.WriteLine($"{n++,-5}{s[i]}{s[j]}");
//     }
// }