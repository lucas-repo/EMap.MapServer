using IMap.MapServer.Ogc.Ows1_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMap.MapServer.Ogc.Wmts1
{
    public class InvalidUpdateSequenceExceptionReport : ExceptionReport
    {
        public InvalidUpdateSequenceExceptionReport()
        {
            Exception =new ExceptionType[] 
            {
                new ExceptionType()
                {
                    exceptionCode =ExceptionCodes.InvalidUpdateSequence.ToString(),
                    ExceptionText = new string[] { "Bad request" }
                }
            };
        }
    }
}
