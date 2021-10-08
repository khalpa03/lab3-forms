using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3_forms;

namespace Testlab3_forms
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CompareTest1()
        {
            var word1 = "процессор";
            var word2 = "информация";
            var Out = Logic.Compare(word1, word2);
            Assert.AreEqual("Нет Да Да Да Нет Нет ", Out);
        }
    }
}
