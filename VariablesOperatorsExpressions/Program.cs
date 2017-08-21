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
            // float number = 2.164403304897294383961032f;
            // double someNumber = 2.164403304897294383961032d;
            // decimal partialNumber = 2.164403304897294383961032m;

            // Console.WriteLine(number);
            // Console.WriteLine(someNumber);
            // Console.WriteLine(partialNumber);

            //// Boolean
            // bool isPresent = true;
            // bool seatTaken = false;

            // //Character or Char
            // //char lastLetter = 'S';

            //int jessicaAge = 23;
            //int samAge = 47;
            //int total = samAge + jessicaAge;
            //Console.WriteLine(jessicaAge = samAge);

            //What is the amount of the bill if 3 friends divided it equally by adding
            //Practice problems turning english into c#
            int mikeBill = 13;
            int sonjaBill = 13;
            int jamesBill = 13;
            int shawnBill = 13;
            Console.WriteLine(mikeBill + sonjaBill + jamesBill + shawnBill);

            //What is the amount of the bill if 3 friends divided it equally multiplication
            //Practice problems turning english into c#
            int billAmount = 13;
            int totalFriends = 4;
            Console.WriteLine(billAmount * totalFriends);

            //Lisa is cooking muffins.The recipe calls for 7 cups of sugar.She has already put in 2 cups.
            //How many more cups does she need to put in?

            int sugar = 7;
            int sugarUsed = 2;
            Console.WriteLine(sugar - sugarUsed);

            //How many packages of diapers can you buy with $40 if one package costs $8 ?
            int packageOfDiapers = 8;
            int totalAmount = 40;
            Console.WriteLine(totalAmount / packageOfDiapers);


            /*Last Friday Trevon had $29. Over the weekend he received some money for cleaning the attic.
                He now has $41. How much money did he receive?*/
            int fridayMoney = 29;
            int TrevonTotalMoney = 41;
            Console.WriteLine(TrevonTotalMoney - fridayMoney);


           /*Last week Julia ran 30 miles more than Pranav. Julia ran 47 miles.
                How many miles did Pranav run?*/
            int juliaMiles = 47;
            Console.WriteLine(juliaMiles - 30);

            int julia_Miles = 47;
            int previousMiles = 30;
            int anotherGirlsMiles = juliaMiles - previousMiles;
            Console.WriteLine(anotherGirlsMiles);
        

            //How many boxes of envelopes can you buy with $12 if one box costs $3?
            int totalMoney = 12;
            int envelopeCost = 3;
            int envelopes = totalMoney / envelopeCost;
            Console.WriteLine(envelopes);

            /*After paying $5.12 for a salad, Norachai has $27.10.
                How much money did he have before buying the salad?*/
            float salad = 5.12f;
            float totalNow = 27.10f;
            Console.WriteLine(totalNow + salad);

            /*331 students went on a field trip. Six buses were filled and 7 students traveled in cars. 
                   How many students were in each bus?*/
            int totalStudents = 331;
            int carStudents = 7;
            int busStudents = totalStudents - carStudents;
            int buses = 6;
            int studentsPerBus = busStudents / buses;
            Console.WriteLine(studentsPerBus);

            /*Aliyah had $24 to spend on seven pencils. After buying them she had $10.
                How much did each pencil cost?*/
            //max $24, left over $10 on 7 pencils
            float maxMoney = 24.0f;
            int boughtPencils = 7;
            float leftOverMoney = 10.0f;
            Console.WriteLine((maxMoney - leftOverMoney) / boughtPencils);

            //The sum of three consecutive numbers is 72.What are the smallest of these numbers?
            int totalNumber = 72;
            int middleNumber = totalNumber / 3;
            int maxNumber = middleNumber + 1;
            int smallNumber = middleNumber - 1;
            Console.WriteLine(smallNumber);

            //The sum of three consecutive even numbers is 48. What are the smallest of these numbers?
            int sum = 48;
            int numbers = 3;
            int average = sum / numbers;
            int smallestNumber = average - 2;
            Console.WriteLine("The smallest number is" + smallestNumber);

            int total1 = 48;
            int number1 = (total1 - 6) / 3;
            Console.WriteLine(number1);

            int sumOfEvenNumbers = 48;
            int evenOne = sumOfEvenNumbers / 3;
            int evenTwo = evenOne - 2;
            int evenThree = evenOne + 2;
            Console.WriteLine(evenTwo);

            /*Maria bought seven boxes. A week later half of all her boxes were destroyed in a fire. 
                There are now only 22 boxes left. With how many did she start?*/
            int boughtBoxes = 7;
            int boxesLeft = 22;
            int boxesBeforeFire = boxesLeft * 2;
            Console.WriteLine(boxesBeforeFire);


            //Console.WriteLine("Please enter your age");
            //int userAge = int.Parse(Console.ReadLine());







        }
    }
}