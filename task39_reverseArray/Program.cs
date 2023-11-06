// Task39 Разверните массив и выведите на экран исхлодный и развёрнутый массив.
int[] reverseArr(int[] array)
{
    int[] revArr = new int[array.Length];
    for(int i = 0;i < array.Length;i++)
    {
        revArr[revArr.Length-1-i] = array[i];
    }
    return revArr;
}

void printArr(int[] array)
{
    for(int i = 0;i < array.Length;i++)
    {
        Console.Write(array[i]+"\t");
    }
    Console.WriteLine();
}
int[] numbers = {5,4,3,2,1,0,-2};
int[] reversedNumbers = reverseArr(numbers);
printArr(numbers);
printArr(reversedNumbers);

