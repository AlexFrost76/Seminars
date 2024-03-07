void Bar(ref int a)
{
    a =0;
}

int value =5;
 Bar( ref value);
Console.WriteLine(value);