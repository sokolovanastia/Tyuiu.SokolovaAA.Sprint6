using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SokolovaAA.Sprint6.Task5.V30.Lib;
using System.IO;
namespace Tyuiu.SokolovaAA.Sprint6.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\nassok\source\repos\Tyuiu.SokolovaAA.Sprint6\Tyuiu.SokolovaAA.Sprint6.Task5.V30\bin\Debug\InPutFileTask5V30.txt";
            double[] res = ds.LoadFromDataFile(path);
            double i = res[0];
            double wait = 5;
            Assert.AreEqual(wait, i);
        }
    }
}
