using EMap.MapServer.Ogc.Services;

namespace EMap.MapServer.DotSpatial
{
    public interface IDsWmts1ServiceFactory:IWmtsServiceFasctory
    {
        new IDsWmts1Service GetService();
    }
}