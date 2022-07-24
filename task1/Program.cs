//числа фибоначчи
int[] arr = new int[15];
arr[0] = arr[1] = 1;
int i = 2;
while (i < arr.Length)
{
    arr[i] = arr[i-1] + arr[i-2];
    Console.Write(arr[i++]);
}

