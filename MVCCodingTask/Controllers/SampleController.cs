using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCodingTask.Models;


namespace MVCCodingTask.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(NumberModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            TempData["numbers"] = "Natural Numbers: " + getNaturalNumber(model.intNumber);
            TempData["evenNumbers"] = "Even Numbers: " + getEvenOddNumber(model.intNumber, true);
            TempData["oddNumbers"] = "Odd Numbers: " + getEvenOddNumber(model.intNumber, false);
            TempData["alphaNumbers"] = "Alpha Numbers: " + getAlphaNumber(model.intNumber);
            TempData["fibonacciNumbers"] = "Fibonacci Numbers: " + getFibonacci(model.intNumber);

            return View();
        }

        public string getNaturalNumber(int number)
        {
            // Using array approach
            int[] intList = new int[number + 1];
            for (int i = 0; i <= number; i++)
                intList[i] = i;
            return string.Join(",", intList);
        }

        public string getEvenOddNumber(int number,bool isEven)
        {
            //String concatination approach
            string evenOddNumbers = string.Empty;
            if (isEven)
            {
                for (int i = 0; i <= number; i++)
                    if (((i % 2) == 0) && i != 0)
                        evenOddNumbers = evenOddNumbers + i + ",";
            }
            else
            {
                for (int i = 0; i <= number; i++)
                    if ((i % 2) != 0)
                        evenOddNumbers = evenOddNumbers + i + ",";
            }
            if (!string.IsNullOrEmpty(evenOddNumbers))
                evenOddNumbers = evenOddNumbers.Substring(0, evenOddNumbers.Length - 1);

            return evenOddNumbers;
        }

        public string getAlphaNumber(int number)
        {
            //String concatination approach
            string numberList = string.Empty;
            for (int i = 0; i <= number; i++)
            {
                if (i == 0)
                    numberList = numberList + i + ",";
                else if ((i % 3) == 0 && (i % 5) == 0 && i != 0)
                    numberList = numberList + "Z" + ",";
                else if ((i % 5) == 0)
                    numberList = numberList + "E" + ",";
                else if ((i % 3) == 0)
                    numberList = numberList + "C" + ",";
                else
                    numberList = numberList + i + ",";
            }

            if (!string.IsNullOrEmpty(numberList))
                numberList = numberList.Substring(0, numberList.Length - 1);

            return numberList;
        }

        public string getFibonacci(int number)
        {
            //String concatination approach
            string fibonacciList = string.Empty;
            for (int x = 0; x <= number; x++)
            {
                int a = 0;
                int b = 1;
                for (int i = 0; i < x; i++)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
                if (a > number)
                    break;
                fibonacciList = fibonacciList + a + ",";
            }
            if (!string.IsNullOrEmpty(fibonacciList))
                fibonacciList = fibonacciList.Substring(0, fibonacciList.Length - 1);

            return fibonacciList;
        }
    }
}