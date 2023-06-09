// See https://aka.ms/new-console-template for more information
int[] InputCoeff()
{
    int[] massive = new int[4];
    Console.WriteLine("Введите b1: ");
    massive[0]=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите k1: ");
    massive[1]=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите b2: ");
    massive[2]=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите k2: ");
    massive[3]=Convert.ToInt32(Console.ReadLine());
    return massive;
}

void CountXY(int[] massive)
{
    //k1x+b1=k2x+b2
    //b1-b2=x(k2-k1)
    double x=(double)(massive[0]-massive[2])/(massive[3]-massive[1]);
    double y=massive[1]*x+massive[0];
    Console.WriteLine("Координата Х: "+x + " , координата Y: " +y);
}

CountXY(InputCoeff());
