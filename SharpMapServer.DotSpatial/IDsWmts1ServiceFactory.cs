using SharpMapServer.Ogc.Services;

namespace SharpMapServer.DotSpatial
{
    public interface IDsWmts1ServiceFactory:IWmtsServiceFasctory
    {
        new IDsWmts1Service GetService();
    }
}