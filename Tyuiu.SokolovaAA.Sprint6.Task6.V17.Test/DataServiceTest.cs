using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SokolovaAA.Sprint6.Task6.V17.Lib;
using System.IO;

namespace Tyuiu.SokolovaAA.Sprint6.Task6.V17.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V17.txt";
            DataService ds = new DataService();
            string wait = " wFrlYaZtHI XuLENkL BV ltxrhBXm HbJcPW";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
