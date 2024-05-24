using System.Globalization;
String [] Arr = {"Russia","2", "134567", "какой-то элемент массива"};
String [] ArrNew = new string [Arr.Length];
int i = 0;
int j = 0;
while (i < Arr.Length)
{
    if(Arr[i].Length < 4)
    {
        ArrNew[j] = Arr[i];
        Console.Write($"{ArrNew[j]} ");
        j++;
    }
}

