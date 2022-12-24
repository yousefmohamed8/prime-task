int n1, n2, flag = 0;
Console.Write("Enter Frist number: ");
n1 = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Prime numbers  are: ");
Console.WriteLine("-----------------------------------------------------");
for (int i = n1; i < n2; i++)
{
    flag = 0;
    if (i > 1)
    {
        for (int j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                flag = 1;
                continue;
            }
        }
        if (flag == 0)
        {
            Console.WriteLine(i);
        }
    }
}

