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

//Dz2
// исключения ошибка индекса при переборе масива,
// неверный формат при попытки первести сифвол в число,
// пустой двухмерный масив масив,
// в двухмерном масиве буду встречаться тексты на не символы

int[] masiv1 = new int[] { 10, 15, 30, 70, 5 };
int[] masiv2 = new int[] { 5, 10, 15, 35, 2 };
int[] masiv3 = dz3(masiv1, masiv2);
printer(masiv3);

static int[] dz3(int[] masiv1, int[] masiv2)
{
    if (masiv1.Length != masiv2.Length) throw new Exception("Масивы не равны");

    int[] masiv3 = new int[masiv1.Length];
    for (int i = 0; i < masiv1.Length; i++)
    {
        masiv3[i] = masiv1[i] - masiv2[i];

    }
    return masiv3;
}

static void printer(int[] arry)
{
    foreach (var item in arry)
    {
        Console.WriteLine(item);
    }
}