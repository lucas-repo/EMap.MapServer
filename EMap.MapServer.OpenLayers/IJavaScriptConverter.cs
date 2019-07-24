namespace EMap.MapServer.OpenLayers
{
    public interface IJavaScriptConverter
    {
        string JavaScriptName { get; set; }
        /// <summary>
        /// 创建脚本实例
        /// </summary>
        /// <returns></returns>
        string ToJavaScriptInstance();
    }
}