// See https://aka.ms/new-console-template for more information
int _a = 5;
int _b = 5;

RefMethod(ref _a);
Method(_b);

Console.WriteLine(_a); //output  10
Console.WriteLine(_b); //output  5

void RefMethod(ref int a)
{
    a = 10;
}

void Method(int b)
{
    b = 10;
}

//--------------------------

int _c = 5;

ref var __c = ref X(ref _c);

ref int X(ref int x)
{
    x = 10;
    return ref x;
}

//--------------------------

int[] numbers = {1,2,3,4,5};
ref int targetElement =ref FindElement(numbers,3);
targetElement = 12;
foreach (var item in numbers)
{
    Console.WriteLine(item);
}

ref int FindElement(int[] array,int target)
{
    for (var i = 0;  i < array.Length; i++)
    {
        if (array[i] == target)
            return ref array[i];
    }
    throw new InvalidOperationException("not_found");
}

//-------------------------- ref locals

char o = 'a';
ref char t = ref o;
t = 'c';
Console.WriteLine(o);