using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesOperatorsExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Sonja";
            //Console.WriteLine(name);

            //name = "Dave";
            //Console.WriteLine(name);

            //string birthMonth = "January";
            //Console.WriteLine(birthMonth);
            //integers
            //int birthMonthNumber = 1;
            //int age = 65;
            //int population = 10000;
            
            //Floating type variables.
            //float number = 2.164403304897294383961032f;
            //double someNumber = 2.164403304897294383961032d;
            //decimal partialNumber = 2.164403304897294383961032m;

            //Console.WriteLine(number);
            //Console.WriteLine(someNumber);
            //Console.WriteLine(partialNumber);

            //Boolean
            //bool isPresent = true;
            //bool seatTaken = false;
            
            //Character or Char
            //char lastLetter = 'S';

            int jessicaAge = 23;
            int samAge = 47;
            int total = samAge + jessicaAge;
            //Console.WriteLine(jessicaAge = samAge);

            //What is the amount of the bill if 3 friends divided it equally
            //Practic problems turning english into c#
            int mikeBill = 13;
            int sonjaBill = 13;
            int jamesBill = 13;
            int shawnBill = 13;

            Console.WriteLine(mikeBill + sonjaBill + jamesBill + shawnBill);

            int sugar = 7;
            int sugarUsed = 2;

            Console.WriteLine(sugar - sugarUsed);

            //int juliaMiles = 47;
            //console.WriteLine(juliaMiles - 30);

            int juliaMiles = 47;
            int previousMiles = 30;
            int anotherGirlsMiles = juliaMiles - previousMiles;
            //Console.WriteLine(anotherGirlsMiles);

            int totalMoney = 12;
            int envelopeCost = 3;
            int envelopes = totalMoney / envelopeCost;

            //Console.WriteLine(envelopes);

            int totalStudents = 331;
            int carStudents = 7;
            int busStudents = totalStudents - carStudents;
            int buses = 6;
            int studentsPerBus = busStudents / buses;

            Console.WriteLine(studentsPerBus);

            float maxMoney = 24.0f;
            int boughtPencils = 7;
            float leftOverMoney = 10.0f;

            //Console.WriteLine((maxMoney - leftOverMoney) / boughtPencils);

            int totalNumber = 72;
            int middleNumber = totalNumber / 3;
            int maxNumber = middleNumber + 1;
            int smallNumber = middleNumber - 1;

            //Console.WriteLine(smallNumber);

            int sum = 48;
            int numbers = 3;
            int average = sum / numbers;
            int smallestNumber = average - 2;
            Console.WriteLine("This smallest number is " + smallestNumber);

            int total1 = 48;
            int number1 = (total1 - 6) / 3;
            Console.WriteLine(number1);

            int sumOfEvenNumbers = 48;
            int evenOne = sumOfEvenNumbers / 3;
            int evenTwo = evenOne - 2;
            int evenThree = evenOne + 2;
            Console.WriteLine(evenTwo);


            int boughtBoxes = 7;
            int boxesLeft = 22;
            int boxesBeforeFire = boxesLeft * 2;
            Console.WriteLine(boxesBeforeFire);



        }
    }
}