string [] CreateArray(int size)
{
    string [] array = new string[size];
    for(int i=0; i<size; i++)
    {
        Console.Write("Пожалуйста введите элементы массива: ");
        array [i] = Console.ReadLine();
    }
    return array;
}

int IntermediateArray(string [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
            count++;
    }
    return count;
}

string [] NewArray(int count, string [] array)
{
    string [] arr = new string[count];
    for(int i = 0, j = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3){
            arr [j]= array[i];
            j++;
        }
    }
    return arr;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string [] array = CreateArray(size);
int number = IntermediateArray(array);
string[] newArr = NewArray(number, array);
for (int i = 0; i < newArr.Length; i++)
    Console.Write(newArr[i] + " ");

