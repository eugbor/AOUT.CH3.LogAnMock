using System;
using NUnit.Framework;

namespace AOUT.CH3.LogAnMock.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void Analyze_TooShortFileName_CallsWebService()
        {
            FakeWebService mockService = new FakeWebService();
            LogAnalyzer log = new LogAnalyzer(mockService);
            string tooShortFileName = "abc.ext";

            log.Analyze(tooShortFileName);

            StringAssert.Contains("Слишком короткое имя файла: abc.ext",
                mockService.LastError);
        }
    }
}
