 using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyser;

namespace MoodAnalyseTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckMoodhappy()
        {
            MoodAnalyser m = new MoodAnalyser("msg");
           var res = m.AnalyseMood("I am happy");
            Assert.AreEqual("happy" , res);

           
        }


        [TestMethod]
        public void CheckMoodAny()
        {
            var m1 = new MoodAnalyser("msg");
            m1.AnalyseAnyMood("I am in  happy mood");


            Assert.AreEqual("happy","happy");
        }
    }
}