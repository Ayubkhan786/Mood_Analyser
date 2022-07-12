 using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyser;


namespace MoodAnalyseTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        //The data in the row is null
        // Created using DataRow object.
        [DataRow(null)]
        
        public void checkMood(string info)
        {
            //To check the test case 
            //If null it return happy
            MoodAnalyse test = new MoodAnalyse(info);
            var res = test.AnalyseMood();
            Assert.AreEqual("happy", res);
        }
        [TestMethod]
        public void CheckMoodhappy()
        {
            MoodAnalyser m = new MoodAnalyser("msg");
            var res = m.AnalyseMood("I am happy");
            Assert.AreEqual("happy", res);


        }


        [TestMethod]
        public void CheckMoodAny()
        {
            var m1 = new MoodAnalyser("msg");
            var res1 = m1.AnalyseAnyMood("I am in any mood");


            Assert.AreEqual("happy", res1);
        }

       

      
    }
}