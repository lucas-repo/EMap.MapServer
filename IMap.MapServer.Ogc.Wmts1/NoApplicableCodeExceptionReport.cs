using EMap.MapServer.Ogc.Ows1_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.MapServer.Ogc.Wmts1
{
    public class NoApplicableCodeExceptionReport : ExceptionReport
    {
        public NoApplicableCodeExceptionReport()
        {
            Exception =new ExceptionType[] 
            {
                new ExceptionType()
                {
                    exceptionCode =ExceptionCodes.NoApplicableCode.ToString(),
                    ExceptionText = new string[] { "Internal server error" }
                }
            };
        }
    }
}
