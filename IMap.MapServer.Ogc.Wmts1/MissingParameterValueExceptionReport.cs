using IMap.MapServer.Ogc.Ows1_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMap.MapServer.Ogc.Wmts1
{
    public class MissingParameterValueExceptionReport: ExceptionReport
    {
        public MissingParameterValueExceptionReport()
        {
            Exception =new ExceptionType[] 
            {
                new ExceptionType()
                {
                    exceptionCode =ExceptionCodes.MissingParameterValue.ToString(),
                    ExceptionText = new string[] { "Bad request" }
                }
            };
        }
    }
}
