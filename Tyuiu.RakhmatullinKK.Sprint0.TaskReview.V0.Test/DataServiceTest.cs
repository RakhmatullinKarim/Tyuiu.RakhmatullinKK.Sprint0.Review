using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RakhmatullinKK.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.RakhmatullinKK.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {

            int FirstNum = 3;
            int SecondNum = 2;
            int ThirdNum = 4;

            int res = DataService.Calc(FirstNum, SecondNum, ThirdNum);

            Assert.AreEqual(45, res);
        }
    }
}
