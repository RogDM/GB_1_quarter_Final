// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] startMass = {"hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science"};
string[] finalMass;

int count = 0;
int countMass = 0;

for (int i = 0; i < startMass.Length; i++)
{
    count = startMass[i].Length;
    if (count <= 3)
    {
        countMass++;
    }
}

finalMass = new string[countMass];
countMass = 0;

for (int i = 0; i < startMass.Length; i++)
{
    count = startMass[i].Length;
    if (count <= 3)
    {
        finalMass[countMass] = startMass[i];
        countMass++;
    }
}


for (int i = 0; i < finalMass.Length; i++)
{
    Console.Write($"{finalMass[i]} ");
}

