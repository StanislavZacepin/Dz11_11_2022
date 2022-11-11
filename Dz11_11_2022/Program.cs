// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int check = 5;
int[] mass = new int[] { };
check = dz1_1(mass);
Console.WriteLine(check);

static int dz1_1(int[] intMassiv)
{
    if (intMassiv.Length == 0) return -1; // пустой масив
    if (intMassiv.Length >= 10) return -2;// слишком большой
    if (intMassiv.Length <= 3) return -3; // слишком маленький
    return 0;
}