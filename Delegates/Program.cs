// See https://aka.ms/new-console-template for more information
void voidMethod()
{
    Console.WriteLine("Void method for delegate");
}


(int, char) TupleMethod(Test a, (string, int) tuple)
{
    Console.WriteLine("TupleMethod for delegate");
    return (2, 'a');
}



XHandler xHandler = voidMethod;
YHandler yHandler = TupleMethod;

XHandler x2Handler = () => { };

YHandler y2Handler = (a, p) =>
{
    return (2, 'a');
};

xHandler();
var value = yHandler(new Test(), ("a", 2));

ZHandler zHandler = () => Console.WriteLine("Method1");
zHandler += () => Console.WriteLine("Method2");
zHandler += () => Console.WriteLine("Method3");
zHandler += () => Console.WriteLine("Method4");
zHandler += () => Console.WriteLine("Method5");
zHandler();

var delegates = zHandler.GetInvocationList(); //method list


GenericHandler<string, int, Test> genericHandler = (a, b) => GenericMethod(a, b);
var test = genericHandler("sa", 32);

Test GenericMethod(string name,int age)
{
    return new Test() { Name = name,Age = age};
}



public delegate void XHandler();
public delegate (int, char) YHandler(Test a, (string, int) p);
public delegate void ZHandler();
public delegate T3 GenericHandler<T1, T2, T3>(T1 t1, T2 t2);
