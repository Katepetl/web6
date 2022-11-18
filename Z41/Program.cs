// See https://aka.ms/new-console-template for more information
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
Console.WriteLine("Vvedite massiv");
int[] array= Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int count=0;
void bolsheO(){
for (int i=0; i<array.Length; i++)
{
    if (array[i]>0)
    {
        count++;
    }
}
}
bolsheO();
Console.WriteLine($"Количество чисел больше 0: {count}");