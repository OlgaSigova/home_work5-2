//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

int[] GetArray(int size)

{
    int[] array1 = new int[size];
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(-100, 100);
    }

    return array1;
}
int GetSumOddPosition(int[] array1)
{

    int sum = 0;
    for (int i = 0; i < array1.Length; i++)
    {

        if (i % 2 == 1)
        {
             sum=sum+ array1[i];
        }

    }
    return sum;

}
int[] array = GetArray(8);

Console.WriteLine(String.Join(",", array));
Console.WriteLine( GetSumOddPosition( array));
