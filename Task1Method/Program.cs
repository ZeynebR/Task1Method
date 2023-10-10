




int[] Numbers = { 2, 4, 7, 8, 10 };

int NewNumber = 7;

Console.WriteLine(FindNumber(Numbers, NewNumber));


bool FindNumber(int[] numbers, int NewNumber)
{
    for (int i = 0; i < Numbers.Length;i++)
    {
        if (Numbers[i] == NewNumber)
        {
            
            return true;
        }
    }
    return false;

}

