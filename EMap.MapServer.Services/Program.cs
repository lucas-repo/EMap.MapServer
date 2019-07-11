using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OSGeo.GDAL;
using OSGeo.OGR;
using OSGeo.OSR;

namespace EMap.MapServer.Services
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);//todo 注册编码，注册gdal使用的GBK编码
            Gdal.AllRegister();
            Ogr.RegisterAll();
            // 为了支持中文路径，请添加下面这句代码  
            if (Encoding.Default.EncodingName== Encoding.UTF8.EncodingName&& Encoding.Default.CodePage == Encoding.UTF8.CodePage)
            {
                Gdal.SetConfigOption("GDAL_FILENAME_IS_UTF8", "YES");
            }
            else
            {
                Gdal.SetConfigOption("GDAL_FILENAME_IS_UTF8", "NO");
            }
            // 为了使属性表字段支持中文，请添加下面这句  
            Gdal.SetConfigOption("SHAPE_ENCODING", "");
            CreateWebHostBuilder(args).Build().Run(); 
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
