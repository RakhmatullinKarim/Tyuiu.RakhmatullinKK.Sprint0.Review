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

            int x = 3;
            int y = 2;
            int z = 4;

            int res = DataService.Calc(x, y, z);

            Assert.AreEqual(45, res);
        }
    }
}
