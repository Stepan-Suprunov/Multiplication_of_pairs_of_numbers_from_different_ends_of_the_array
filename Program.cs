// Произведение пар чисел с разных концов массива

int [] array = new int [8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
}

int [] result = new int [(array.Length+1)/2];

void PrintArray(int [] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
}

void Multiplication()
{
for (int i = 0; i < array.Length/2; i++)
    { 
        result [i] = array[i] * array[array.Length - 1 - i];
    }
    PrintArray(result);
}

PrintArray(array);
Console.WriteLine();
Multiplication();