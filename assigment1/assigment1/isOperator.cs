using System;


namespace assignment1
{

    internal class Ass1
    {
        static void Main()
        {
            object employee = new Dev();// input

            if (employee is Manager)
            {
                Console.WriteLine("type is manager");
            }
            else if(employee is Dev){
                Console.WriteLine("type is Dev");

            }
            else
            {
                Console.WriteLine("type is intern");

            }

        }
    }

    class Manager
    {

    }
    class Dev
    {

    }
    class intern
    {

    }
}

