using NUnit.Framework;
using SmartHomework;
using System;

namespace SmartHomeworkTests
{
    
    public class PrimeNTests
    {
        [Test]
        public void TestIsPrime()
        {
            
            int num1 = 17;

           
            bool result = PrimeN.IsPrime(num1);

           
            Assert.IsTrue(result);
        }
        [Test]
        public void IsPrime_Negative()
        {
           
            int number = -3;

            
            bool result = PrimeN.IsPrime(number);


            Assert.Throws<ArgumentException>(() => PrimeN.IsPrime(number));
        }
        [Test]
        public void IsPrime_large_number()
        {

            int number = 1234567;


            bool result = PrimeN.IsPrime(number);


            Assert.IsFalse(result);
        }
        [Test]
        public void IsPrime_0()
        {

            int number = 0;


            bool result = PrimeN.IsPrime(number);


            Assert.IsFalse(result);

        }
        [Test]
        public void IsPrime_2()
        {

            int number = 2;


            bool result = PrimeN.IsPrime(number);


            Assert.IsTrue(result);
        }
    }
}
