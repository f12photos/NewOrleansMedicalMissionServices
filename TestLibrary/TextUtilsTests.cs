using Xunit;
using System.Diagnostics;
using NOMMS.Domain;

namespace TestLibrary
{
    public class TextUtils_GetWordCountShould
    {
        [Fact]
        public void IgnoreCasing()
        {
            var wordCount = WordCount.GetWordCount("Jack", "Jack jack");

            Assert.NotEqual(2, wordCount);
        }
    }
}