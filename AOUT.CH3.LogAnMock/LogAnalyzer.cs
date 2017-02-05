using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOUT.CH3.LogAnMock
{
    public interface IWebService
    {
        void LogError(string message);
    }

    public class FakeWebService : IWebService
    {
        public string LastError;

        public void LogError(string message)
        {
            LastError = message;
        }
    }

    public class LogAnalyzer
    {
        private IWebService service;

        public LogAnalyzer(IWebService service)
        {
            this.service = service;
        }

        public void Analyze(string fileName)
        {
            if (fileName.Length < 8)
            {
                service.LogError("Слишком короткое имя файла: " + fileName);
            }
        }
    }
}
