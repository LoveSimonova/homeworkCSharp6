// See https://aka.ms/new-console-template for more information
int[] GetMass(int length)
{
    int[] massive = new int[length];
    for(int i=0;i<length;i++)
    {
        Console.WriteLine("Введите число: ");
        massive[i]=Convert.ToInt32(Console.ReadLine());
    }
    return massive;
}

void CountPositive(int[] massive)
{
    int count=0;
    for(int i=0;i<massive.Length;i++)
        if(massive[i]>0)
            count++;
    Console.WriteLine("Чисел больше нуля: "+count);
}

Console.WriteLine("Введите количество элементов массива: ");
CountPositive(GetMass(Convert.ToInt32(Console.ReadLine())));
