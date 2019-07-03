using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.MapServer.Ogc.Wmts1
{
    public enum ExceptionCodes
    {
        MissingParameterValue = 400,
        InvalidParameterValue = 400,
        VersionNegotiationFailed = 400,
        InvalidUpdateSequence = 400,
        NoApplicableCode = 500
    }
}
