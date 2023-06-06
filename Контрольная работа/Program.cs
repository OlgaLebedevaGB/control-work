//Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 
// 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
// задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

void ShowIntMas (string [] array)
{
    for (int count=0; count <array.Length; count++) Console.Write(array[count]+ " ");
    Console.WriteLine();
}

string [] WordsFromTheFirstThreeLetters (string[] array)
{
    string[] mas = new string [array.Length];
    for (int i=0; i<array.Length; i++)
        mas [i] = array [i].Substring(0, 3); 
    return mas;
}

string[] words = { "зубр", "волк", "носорог", "макака" };
ShowIntMas(words);
string [] whichWord = WordsFromTheFirstThreeLetters(words);
ShowIntMas (whichWord);



