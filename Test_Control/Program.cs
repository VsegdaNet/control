
string[] arr1 = new string[6] {"YOU", "task", "home", "93939", "=", "+"};
string[] arr2 = new string[arr1.Length];

void ArrayNum(string[] arrOne, string[] arrTwo);
{
    int count = 0;
    for (int i = 0; i < arrOne.Length; i++)
    {
        if(arrOne[i].Length <= 3)
        {
            arrTwo[count] = arrOne[i];
            count ++;
        }

    }
}