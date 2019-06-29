using IMap.MapServer.Ogc.Ows1_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMap.MapServer.Ogc.Services
{
    public static class ExceptionReportHelper
    {
        public static ExceptionReport GetExceptionReport(string exceptionCode = null, string locator = null, params string[] exceptionText)
        {
            ExceptionType exceptionType = GetExceptionType(exceptionCode, locator, exceptionText);
            ExceptionReport exception = new ExceptionReport()
            {
                Exception = new ExceptionType[]
                {
                    exceptionType
                }
            };
            return exception;
        }
        public static ExceptionType GetExceptionType(string exceptionCode = null, string locator = null, params string[] exceptionText)
        {
            ExceptionType exceptionType = new ExceptionType()
            {
                exceptionCode = exceptionCode,
                locator = locator,
                ExceptionText = exceptionText
            };
            return exceptionType;
        }
    }
}
