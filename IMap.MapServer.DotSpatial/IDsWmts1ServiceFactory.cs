using IMap.MapServer.Ogc.Services;

namespace IMap.MapServer.DotSpatial
{
    public interface IDsWmts1ServiceFactory:IWmtsServiceFasctory
    {
        new IDsWmts1Service GetService();
    }
}