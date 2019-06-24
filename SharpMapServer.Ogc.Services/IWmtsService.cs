using SharpMapServer.Ogc.Wmts1;
using System.IO;

namespace SharpMapServer.Ogc.Services
{
    public interface IWmtsService:IOgcService
    {
        void XmlSerialize(TextWriter textWriter,Capabilities capabilities);
        Capabilities XmlDeSerialize(TextReader textReader);
        Capabilities CreateCapabilities(string href);
        LayerType AddContent(Capabilities capabilities, string dataPath);
        void RemoveContent(Capabilities capabilities, string contentIdentifier);
        Capabilities GetCapabilities(string capabilitiesPath, GetCapabilities getCapabilities);
        byte[] GetTile(Capabilities capabilities, string path, GetTile getTile);
        FeatureInfoResponse GetFeatureInfo(string capabilitiesPath, GetFeatureInfo getFeatureInfo);
    }
}
