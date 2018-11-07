using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzKata;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestContainsFizz()
        {
            string numbers = Traitement.getNumbers();
            Assert.IsTrue(numbers.Contains("Fizz"));
        }

        [TestMethod]
        public void TestContainsBuzz()
        {
            string numbers = Traitement.getNumbers();
            Assert.IsTrue(numbers.Contains("Buzz"));
        }

        [TestMethod]
        public void TestContainsFizzBuzz()
        {
            string numbers = Traitement.getNumbers();
            Assert.IsTrue(numbers.Contains("FizzBuzz"));
        }

        [TestMethod]
        public void TestFizzBuzzIsOK()
        {
            string numbers = Traitement.getNumbers();
            bool fail = false;
            string[] numbersArray = numbers.Split(new string[] { " " },StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < 100; i++) {
                if ((i + 1) % 3 == 0 && (i + 1) % 5 == 0) {
                    if (numbersArray[i] != "FizzBuzz") fail = true;
                }
            }
            Assert.IsFalse(fail);
        }

        [TestMethod]
        public void TestFizzIsOK()
        {
            string numbers = Traitement.getNumbers();
            bool fail = false;
            string[] numbersArray = numbers.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < 100; i++)
            {
                if ((i + 1) % 3 == 0 && (i + 1) % 5 != 0)
                {
                    if (numbersArray[i] != "Fizz") fail = true;
                }
            }
            Assert.IsFalse(fail);
        }

        [TestMethod]
        public void TestBuzzIsOK()
        {
            string numbers = Traitement.getNumbers();
            bool fail = false;
            string[] numbersArray = numbers.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < 100; i++)
            {
                if ((i + 1) % 3 != 0 && (i + 1) % 5 == 0)
                {
                    if (numbersArray[i] != "Buzz") fail = true;
                }
            }
            Assert.IsFalse(fail);
        }








    }
}
