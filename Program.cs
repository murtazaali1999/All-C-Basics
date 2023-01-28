using System;
using static System.Math;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string result = "k";
                Console.WriteLine(Convert.ToInt32(result) + 10);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
              //  throw; by using this keyword the application stops
            }

        }
    }


    class Room
    {
        string size;
        string address;
        
        int phoneNumber;
        int price;

        Room(string size,string address,int phoneNumber,int price)
        {
            setRoom(size, address, phoneNumber, price);
        }

        public void setRoom(string size, string address, int phoneNumber, int price)
        {
            this.size = size;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.price = price;
        }

        public Room getRoom()
        {
            Room r1 = new Room(size, address, phoneNumber, price);
            return r1;
        }

        public void showRoomSpecifics()
        {
            Console.WriteLine("Size-->{0} \n,Address-->{1} \n,PhoneNumber-->{2} \n,Price-->{3}", 
                getRoom().size, getRoom().address, getRoom().phoneNumber, getRoom().price);
        }

        public char[] sizeCastingtoChar()
        {
            //Float/Double/String/Int/Char
            //string to char, Up - Low
            char[] converted;
            try
            {
                converted = size.ToCharArray(); //string can be converted to char array
                return converted;
            }
            catch (Exception e)
            {
                char[] emp= {};
                Console.WriteLine(e.Message);
                return emp;
                //returning empty array
            }
        }

        public double priceCastingtoDouble()
        {
            //int --> double, small cup to bigger cup
            try
            {
                double converted = price; //int -> double(no explicit casting)
                return converted;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }


    }

    class Mathematics
    {
        //Math Library Implementation
        public int Maximum(int n1,int n2)
        {
            return Math.Max(n1, n2);
        }

        public int Minimum(int n1, int n2)
        {
            return Math.Min(n1, n2);
        }

        public double Square(int n1, int n2)
        {
            return Math.Sqrt(n1);
        }

    }

    abstract class Abstraction
    {
        //only definitions are present
        //e.g if a function is abstract then only its definition
        //there can be non definition functions here
       
        //there should be no members/variables here
        //!!! Instance of this class cannot be made, only inherited and used

        public abstract void somethingOutOfTheBlue();
        public abstract void somethingOutOfTheRed();
        public abstract void NothingToSeeHere();

        public void IcanDoSomeThing()
        {
            Console.WriteLine("I am a non abstract function");
        }

    }

    interface Iinterface
    {
        //only definitions here
        //no members,no non-definition functions
        //strict abstract
        //same no object can be made

        public void DimSum();
        public void DesertRose();
    }

    class Inheritor: Abstraction, Iinterface
    {
        enum Level { ONE,TWO,THREE };

        //Abstract Functions
        public override void somethingOutOfTheBlue() { }
        public override void somethingOutOfTheRed() { }
        public override void NothingToSeeHere() { }

        //Interface Functions
        
        //no overriding here, in interface
        public void DimSum() { }
        public void DesertRose() { }

    }
}
