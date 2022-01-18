using System;
using System.Collections.Generic;
using CurrencyLibrary;
using ShapesLibrary;

namespace InterfaceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Cannot create just a IShape because IShape is the idea of what a shape is
            IShape shape = new Square();

            shape.Draw();

            double area = shape.CalculateArea();
            Console.WriteLine(area);

            Square square = new Square();
            square.SideLength = 5;
            Console.WriteLine(square.CalculateArea());

            Triangle triangle = new Triangle();
            triangle.Height = 5;
            triangle.Width = 20;

            //Added
            Circle circle = new Circle();
            circle.Radius = 2;

            List<IShape> listOfShapes = new List<IShape>();
            listOfShapes.Add(square);
            listOfShapes.Add(triangle);
            listOfShapes.Add(shape);
            //Added
            listOfShapes.Add(circle);

            System.Console.WriteLine("______________________");

            foreach(IShape s in listOfShapes)
            {
                s.Draw();
            }
            */

            Penny penny = new Penny();
            Dime dime = new Dime();
            Dollar dollar = new Dollar();
            

            ElectronicPayment ePaymentOne = new ElectronicPayment(10.37m);
            ElectronicPayment ePaymentTwo = new ElectronicPayment(7.42m);

            List<ICurrency> money = new List<ICurrency>();
            money.Add(penny);
            money.Add(dime);
            money.Add(dollar);
            money.Add(ePaymentOne);
            money.Add(ePaymentTwo);
            money.Add(new Dollar());
            money.Add(new Penny());
            money.Add(new ElectronicPayment(2.22m));


            foreach (ICurrency currency in money)
            {
                System.Console.WriteLine($"The value of this {currency.Name} is {currency.Value}");
            }

            Console.WriteLine("_______________________");

            Transaction transaction = new Transaction(32.34m);

            transaction.MakePayment(new Dollar());
            transaction.MakePayment(new Dollar());
            transaction.MakePayment(new Dime());
            transaction.MakePayment(new Dime());


            transaction.MakePayment(new Penny(), new Penny(), new Dime(), new Dollar(), new Penny(), new ElectronicPayment(3.11m));

            System.Console.WriteLine(transaction.AmountPayed);
            
            Console.WriteLine($"Amount Owed: {transaction.AmountOwed}");

            transaction.MakePayment(new Euro(), new CanadianDollar(), new Euro(), new CanadianDollar(), new CanadianDollar());

            System.Console.WriteLine(transaction.AmountPayed);
            
            Console.WriteLine($"Amount Owed: {transaction.AmountOwed}");

            transaction.MakePayment(5, new Dollar());

            System.Console.WriteLine(transaction.AmountPayed);
            System.Console.WriteLine(transaction.AmountOwed);



            Console.ReadLine();
        }
    }
}
