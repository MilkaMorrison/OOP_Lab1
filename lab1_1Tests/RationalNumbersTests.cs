using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab1_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_1.Tests
{
    [TestClass()]
    public class RationalNumbersTests
    {
        
        [TestMethod()]
        public void ToStringTest0()
        {
            RationalNumbers res = new RationalNumbers(2, 3);
            Assert.AreEqual("2/3", res.ToString());
        }
        [TestMethod()]
        public void ToStringTest1()
        {
            RationalNumbers res = new RationalNumbers(-2, 3);
            Assert.AreEqual("-2/3", res.ToString());
        }
        [TestMethod()]
        public void ToStringTest2()
        {
            RationalNumbers res = new RationalNumbers(2, -3);
            Assert.AreEqual("-2/3", res.ToString());
        }
        [TestMethod()]
        public void ToStringTest3()
        {
            RationalNumbers res = new RationalNumbers(-2, -3);
            Assert.AreEqual("2/3", res.ToString());
        }
        [TestMethod()]
        public void ToStringTest4()
        {
            RationalNumbers res = new RationalNumbers(2, 0);
            Assert.AreEqual("0", res.ToString());
        }
        [TestMethod()]
        public void ToStringTest5()
        {
            RationalNumbers res = new RationalNumbers(0, 3);
            Assert.AreEqual("0", res.ToString());
        }
        [TestMethod()]
        public void ToStringTest6()
        {
            RationalNumbers res = new RationalNumbers(6, 3);
            Assert.AreEqual("2", res.ToString());
        }

        [TestMethod()]
        public void ReductionTest() 
        {
            RationalNumbers res = new RationalNumbers(2, 6);
            Assert.AreEqual("1/3", res.ToString());
        }

        [TestMethod()]
        public void operatorPlus0()  // a + b
        {
            RationalNumbers a = new RationalNumbers(1, 2);
            RationalNumbers b = new RationalNumbers(2, 5);
            RationalNumbers res = a + b;
            Assert.AreEqual("9/10", res.ToString()); 

        }
        [TestMethod()]
        public void operatorPlus1()
        {
            RationalNumbers a = new RationalNumbers(-3, 5);
            RationalNumbers b = new RationalNumbers(1, -3);
            RationalNumbers res = a + b;
            Assert.AreEqual("-14/15", res.ToString());

        }
        [TestMethod()]
        public void operatorPlus2()
        {
            RationalNumbers a = new RationalNumbers(1, -3);
            RationalNumbers b = new RationalNumbers(2, 5);
            RationalNumbers res = a + b;
            Assert.AreEqual("1/15", res.ToString());

        }
        [TestMethod()]
        public void operatorPlus3() 
        {
            RationalNumbers a = new RationalNumbers(1, 3);
            RationalNumbers b = new RationalNumbers(-2, 3);
            RationalNumbers res = a + b;
            Assert.AreEqual("-1/3", res.ToString());

        }
        [TestMethod()]
        public void operatorPlus4()
        {
            RationalNumbers a = new RationalNumbers(0, 5);
            RationalNumbers b = new RationalNumbers(1, 3);
            RationalNumbers res = a + b;
            Assert.AreEqual("1/3", res.ToString());

        }
        [TestMethod()]
        public void operatorPlus5()
        {
            RationalNumbers a = new RationalNumbers(2, 5);
            RationalNumbers b = new RationalNumbers(3, 0);
            RationalNumbers res = a + b;
            Assert.AreEqual("2/5", res.ToString());

        }

        [TestMethod()]
        public void operatorMinus0() // a - b
        {
            RationalNumbers a = new RationalNumbers(1, 2);
            RationalNumbers b = new RationalNumbers(2, 5);
            RationalNumbers res = a - b;
            Assert.AreEqual("1/10", res.ToString());
        }
        [TestMethod()]
        public void operatorMinus1()
        {
            RationalNumbers a = new RationalNumbers(1, 3);
            RationalNumbers b = new RationalNumbers(-2, 3);
            RationalNumbers res = a - b;
            Assert.AreEqual("1", res.ToString());
        }
        [TestMethod()]
        public void operatorMinus2()
        {
            RationalNumbers a = new RationalNumbers(1, -3);
            RationalNumbers b = new RationalNumbers(2, 5);
            RationalNumbers res = a - b;
            Assert.AreEqual("-11/15", res.ToString());
        }
        [TestMethod()]
        public void operatorMinus3()
        {
            RationalNumbers a = new RationalNumbers(-3, 5);
            RationalNumbers b = new RationalNumbers(1, -3);
            RationalNumbers res = a - b;
            Assert.AreEqual("-4/15", res.ToString());
        }
        [TestMethod()]
        public void operatorMinus4()
        {
            RationalNumbers a = new RationalNumbers(0, 5);
            RationalNumbers b = new RationalNumbers(1, 3);
            RationalNumbers res = a - b;
            Assert.AreEqual("-1/3", res.ToString());
        }
        [TestMethod()]
        public void operatorMinus5()
        {
            RationalNumbers a = new RationalNumbers(2, 5);
            RationalNumbers b = new RationalNumbers(3, 0);
            RationalNumbers res = a - b;
            Assert.AreEqual("2/5", res.ToString());
        }
        
        [TestMethod()]
        public void operatorMultiplication0()  // a * b
        {
            RationalNumbers a = new RationalNumbers(1, 2);
            RationalNumbers b = new RationalNumbers(2, 5);
            RationalNumbers res = a * b;
            Assert.AreEqual("1/5", res.ToString());
        }
        [TestMethod()]
        public void operatorMultiplication1()
        {
            RationalNumbers a = new RationalNumbers(1, 3);
            RationalNumbers b = new RationalNumbers(-2, 3);
            RationalNumbers res = a * b;
            Assert.AreEqual("-2/9", res.ToString());
        }
        [TestMethod()]
        public void operatorMultiplication2()
        {
            RationalNumbers a = new RationalNumbers(1, -3);
            RationalNumbers b = new RationalNumbers(2, 5);
            RationalNumbers res = a * b;
            Assert.AreEqual("-2/15", res.ToString());
        }
        [TestMethod()]
        public void operatorMultiplication3()
        {
            RationalNumbers a = new RationalNumbers(-3, 5);
            RationalNumbers b = new RationalNumbers(1, -3);
            RationalNumbers res = a * b;
            Assert.AreEqual("1/5", res.ToString());
        }
        [TestMethod()]
        public void operatorMultiplication4()
        {
            RationalNumbers a = new RationalNumbers(0, 5);
            RationalNumbers b = new RationalNumbers(1, 3);
            RationalNumbers res = a * b;
            Assert.AreEqual("0", res.ToString());
        }
        [TestMethod()]
        public void operatorMultiplication5()
        {
            RationalNumbers a = new RationalNumbers(2, 5);
            RationalNumbers b = new RationalNumbers(3, 0);
            RationalNumbers res = a * b;
            Assert.AreEqual("0", res.ToString());
        }
        
        [TestMethod()]
        public void operatorDivision0()  // a / b
        {
            RationalNumbers a = new RationalNumbers(1, 2);
            RationalNumbers b = new RationalNumbers(2, 5);
            RationalNumbers res = a / b;
            Assert.AreEqual("5/4", res.ToString());
        }
        [TestMethod()]
        public void operatorDivision1()
        {
            RationalNumbers a = new RationalNumbers(1, 3);
            RationalNumbers b = new RationalNumbers(-2, 3);
            RationalNumbers res = a / b;
            Assert.AreEqual("-1/2", res.ToString());
        }
        [TestMethod()]
        public void operatorDivision2()
        {
            RationalNumbers a = new RationalNumbers(1, -3);
            RationalNumbers b = new RationalNumbers(2, 5);
            RationalNumbers res = a / b;
            Assert.AreEqual("-5/6", res.ToString());
        }
        [TestMethod()]
        public void operatorDivision3()
        {
            RationalNumbers a = new RationalNumbers(-3, 5);
            RationalNumbers b = new RationalNumbers(1, -3);
            RationalNumbers res = a / b;
            Assert.AreEqual("9/5", res.ToString());
        }
        [TestMethod()]
        public void operatorDivision4()
        {
            RationalNumbers a = new RationalNumbers(0, 5);
            RationalNumbers b = new RationalNumbers(1, 3);
            RationalNumbers res = a / b;
            Assert.AreEqual("0", res.ToString());
        }
        [TestMethod()]
        public void operatorDivision5()
        {
            RationalNumbers a = new RationalNumbers(2, 5);
            RationalNumbers b = new RationalNumbers(3, 0);
            RationalNumbers res = a / b;
            Assert.AreEqual("0", res.ToString());
        }
        
        [TestMethod()]
        public void operatorUnarMinus0()  // -a
        {
            RationalNumbers a = new RationalNumbers(2, 5);
            Assert.AreEqual("-2/5", (-a).ToString());
        }
        [TestMethod()]
        public void operatorUnarMinus1()
        {
            RationalNumbers a = new RationalNumbers(-1, 3);
            Assert.AreEqual("1/3", (-a).ToString());
        }
        [TestMethod()]
        public void operatorUnarMinus2()
        {
            RationalNumbers a = new RationalNumbers(3, 0);
            Assert.AreEqual("0", (-a).ToString());
        }

        
        [TestMethod()]
        public void operatorEqual0()  // a == b
        {
            RationalNumbers a = new RationalNumbers(2, 3);
            RationalNumbers b = new RationalNumbers(1, 5);
            Assert.IsFalse(a == b);
        }
        [TestMethod()]
        public void operatorEqual1()
        {
            RationalNumbers a = new RationalNumbers(2, -3);
            RationalNumbers b = new RationalNumbers(2, -3);
            Assert.IsTrue(a == b);
        }
        [TestMethod()]
        public void operatorEqual2()
        {
            RationalNumbers a = new RationalNumbers(-2, 3);
            RationalNumbers b = new RationalNumbers(2, -3);
            Assert.IsTrue(a == b);
        }
        [TestMethod()]
        public void operatorEqual3()
        {
            RationalNumbers a = new RationalNumbers(2, -3);
            RationalNumbers b = new RationalNumbers(-2, 3);
            Assert.IsTrue(a == b);
        }
        [TestMethod()]
        public void operatorEqual4()
        {
            RationalNumbers a = new RationalNumbers(5, 2);
            RationalNumbers b = new RationalNumbers(1, 2);
            Assert.IsFalse(a == b);
        }

        
        [TestMethod()]
        public void operatorNotEqual0()  // a != b
        {
            RationalNumbers a = new RationalNumbers(2, 3);
            RationalNumbers b = new RationalNumbers(1, 5);
            Assert.IsTrue(a != b);
        }
        [TestMethod()]
        public void operatorNotEqual1()
        {
            RationalNumbers a = new RationalNumbers(2, -3);
            RationalNumbers b = new RationalNumbers(2, -3);
            Assert.IsFalse(a != b);
        }
        [TestMethod()]
        public void operatorNotEqual2()
        {
            RationalNumbers a = new RationalNumbers(-2, 3);
            RationalNumbers b = new RationalNumbers(2, -3);
            Assert.IsFalse(a != b);
        }
        [TestMethod()]
        public void operatorNotEqual3()
        {
            RationalNumbers a = new RationalNumbers(2, -3);
            RationalNumbers b = new RationalNumbers(-2, 3);
            Assert.IsFalse(a != b);
        }
        [TestMethod()]
        public void operatorNotEqual4()
        {
            RationalNumbers a = new RationalNumbers(5, 2);
            RationalNumbers b = new RationalNumbers(1, 2);
            Assert.IsTrue(a != b);
        }
        
        [TestMethod()]
        public void operatorLess0()  // a < b
        {
            RationalNumbers a = new RationalNumbers(5, 2);
            RationalNumbers b = new RationalNumbers(1, 2);
            Assert.IsFalse(a < b);
        }
        [TestMethod()]
        public void operatorLess1()
        {
            RationalNumbers a = new RationalNumbers(1, 2);
            RationalNumbers b = new RationalNumbers(5, 2);
            Assert.IsTrue(a < b);
        }
        [TestMethod()]
        public void operatorLess2()
        {
            RationalNumbers a = new RationalNumbers(1, 3);
            RationalNumbers b = new RationalNumbers(1, 3);
            Assert.IsFalse(a < b);
        }
        [TestMethod()]
        public void operatorLess3()
        {
            RationalNumbers a = new RationalNumbers(10, 0);
            RationalNumbers b = new RationalNumbers(1, 3);
            Assert.IsTrue(a < b);
        }

        
        [TestMethod()]
        public void operatorLessEqual0()  // a <= b
        {
            RationalNumbers a = new RationalNumbers(5, 2);
            RationalNumbers b = new RationalNumbers(1, 2);
            Assert.IsFalse(a <= b);
        }
        [TestMethod()]
        public void operatorLessEqual1()
        {
            RationalNumbers a = new RationalNumbers(1, 2);
            RationalNumbers b = new RationalNumbers(5, 2);
            Assert.IsTrue(a <= b);
        }
        [TestMethod()]
        public void operatorLessEqual2()
        {
            RationalNumbers a = new RationalNumbers(1, 3);
            RationalNumbers b = new RationalNumbers(1, 3);
            Assert.IsTrue(a <= b);
        }
        [TestMethod()]
        public void operatorLessEqual3()
        {
            RationalNumbers a = new RationalNumbers(10, 0);
            RationalNumbers b = new RationalNumbers(1, 3);
            Assert.IsTrue(a <= b);
        }
        [TestMethod()]
        public void operatorBigger0()  // a > b
        {

            RationalNumbers a = new RationalNumbers(5, 2);
            RationalNumbers b = new RationalNumbers(1, 2);
            Assert.IsTrue(a > b);
        }
        [TestMethod()]
        public void operatorBigger1()
        {
            RationalNumbers a = new RationalNumbers(1, 2);
            RationalNumbers b = new RationalNumbers(5, 2);
            Assert.IsFalse(a > b);
        }
        [TestMethod()]
        public void operatorBigger2()
        {
            RationalNumbers a = new RationalNumbers(1, 3);
            RationalNumbers b = new RationalNumbers(1, 3);
            Assert.IsFalse(a > b);
        }
        [TestMethod()]
        public void operatorBigger3()
        {
            RationalNumbers a = new RationalNumbers(10, 0);
            RationalNumbers b = new RationalNumbers(1, 3);
            Assert.IsFalse(a > b);
        }
        [TestMethod()]
        public void operatorBiggerEqual0()  // a >= b
        {

            RationalNumbers a = new RationalNumbers(5, 2);
            RationalNumbers b = new RationalNumbers(1, 2);
            Assert.IsTrue(a >= b);
        }
        [TestMethod()]
        public void operatorBiggerEqual1()
        {
            RationalNumbers a = new RationalNumbers(1, 2);
            RationalNumbers b = new RationalNumbers(5, 2);
            Assert.IsFalse(a >= b);
        }
        [TestMethod()]
        public void operatorBiggerEqual2()
        {
            RationalNumbers a = new RationalNumbers(1, 3);
            RationalNumbers b = new RationalNumbers(1, 3);
            Assert.IsTrue(a >= b);
        }
        [TestMethod()]
        public void operatorBiggerEqual3()
        {
            RationalNumbers a = new RationalNumbers(10, 0);
            RationalNumbers b = new RationalNumbers(1, 3);
            Assert.IsFalse(a >= b);
        }
    }
}