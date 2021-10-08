using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3_forms;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_forms.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void CompareTest1()
        {
            var word1 = "программа";
            var word2 = "информация";
            var Out = Logic.Compare(word1, word2);
            Assert.AreEqual("Нет Да Да Нет Да Да ", Out);
        }
        [TestMethod()]
        public void CompareTest2()
        {
            var word1 = "интернет";
            var word2 = "ноутбук";
            var Out = Logic.Compare(word1, word2);
            Assert.AreEqual("Нет Да Да Нет Нет ", Out);
        }
        [TestMethod()]
        public void CompareTest3()
        {
            var word1 = "school";
            var word2 = "book";
            var Out = Logic.Compare(word1, word2);
            Assert.AreEqual("Нет Нет Нет Да Нет ", Out);
        }
        [TestMethod()]
        public void CompareTest4()
        {
            var word1 = "ивоjydk";
            var word2 = "gfshвмтвы";
            var Out = Logic.Compare(word1, word2);
            Assert.AreEqual("Нет Да Нет Нет Нет Нет Нет ", Out);
        }
        [TestMethod()]
        public void CompareTest5()
        {
            var word1 = "jbdjkf";
            var word2 = "ifkhdngdg";
            var Out = Logic.Compare(word1, word2);
            Assert.AreEqual("Нет Нет Да Да Да ", Out);
        }
    }
}