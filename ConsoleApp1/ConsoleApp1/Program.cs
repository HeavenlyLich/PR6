using System;

interface IParent
{
    string Info();
    double Metod1();
    double Metod2();
}

class Child1 : IParent
{
    private double pole1;

    public Child1(double pole1)
    {
        this.pole1 = pole1;
    }

    public string Info()
    {
        return $"Тетраедр: а={pole1}";
    }

    public double Metod1()
    {
        return Math.Sqrt(3) * pole1 * pole1;
    }

    public double Metod2()
    {
        return (pole1 * pole1 * pole1 * Math.Sqrt(2)) / 12;
    }
}

class Child2 : IParent
{
    private double pole1;

    public Child2(double pole1)
    {
        this.pole1 = pole1;
    }

    public string Info()
    {
        return $"Куб: а={pole1}";
    }

    public double Metod1()
    {
        return 6 * pole1 * pole1;
    }

    public double Metod2()
    {
        return pole1 * pole1 * pole1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Random rnd = new Random();

        for (int i = 0; i < 5; i++)
        {
            double pole1 = rnd.Next(1, 11);

            IParent obj;

            if (rnd.Next(2) == 0)
            {
                obj = new Child1(pole1);
            }
            else
            {
                obj = new Child2(pole1);
            }

            Console.WriteLine(obj.Info());
            Console.WriteLine($"S={obj.Metod1():F2} V={obj.Metod2():F2}");
           
        }
    }
}
