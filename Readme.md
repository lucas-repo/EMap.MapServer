# SharpMapServer

**基于OGC标准的c#地图发布器**

本项目旨在通过C#语言实现基于OGC标准的GIS地图服务，包括但不限于WMS、WFS、WCS及WTMS。


## 解决方案中的项目：
### OGC涉及的XML Schemas类：
SharpMapServer.Ogc.Gml：命名空间为<u>http://www.opengis.net/gml</u>的相关类  
SharpMapServer.Ogc.Gml3_2：命名空间为<u>http://www.opengis.net/gml/3.2</u>的相关类  
SharpMapServer.Ogc.Gmlcov1：命名空间为<u>http://www.opengis.net/gmlcov/1.0</u>的相关类  

SharpMapServer.Ogc.Ows1_1：命名空间为<u>http://www.opengis.net/ows/1.1</u>的相关类  
SharpMapServer.Ogc.Ows2：命名空间为<u>http://www.opengis.net/ows/2.0</u>的相关类  

SharpMapServer.Isotc211.Gco：命名空间为<u>http://www.isotc211.org/2005/gco</u>的相关类  
SharpMapServer.Isotc211.Gmd：命名空间为<u>http://www.isotc211.org/2005/gmd</u>的相关类  
SharpMapServer.Isotc211.Gsr：命名空间为<u>http://www.isotc211.org/2005/gsr</u>的相关类  
SharpMapServer.Isotc211.Gss：命名空间为<u>http://www.isotc211.org/2005/gss</u>的相关类  
SharpMapServer.Isotc211.Gts：命名空间为<u>http://www.isotc211.org/2005/gt</u>s的相关类  

SharpMapServer.Ogc.Wcs2：命名空间为<u>http://www.opengis.net/wcs/2.0</u>的相关类  
SharpMapServer.Ogc.Wfs2：命名空间为<u>http://www.opengis.net/wfs/2.0</u>的相关类  
SharpMapServer.Ogc.Wms：命名空间为<u>http://www.opengis.net/wms</u>的相关类  
SharpMapServer.Ogc.Wmts1：命名空间为<u>http://www.opengis.net/wmts/1.0</u>的相关类  

SharpMapServer.Ogc：命名空间为<u>http://www.opengis.net/ogc</u>的相关类  
SharpMapServer.Ogc.Fes2：命名空间为<u>http://www.opengis.net/fes/2.0</u>的相关类  
SharpMapServer.Ogc.Security1：命名空间为<u>http://www.opengis.net/security/1.0</u>的相关类  
SharpMapServer.Ogc.Swe2：命名空间为<u>http://www.opengis.net/swe/2.0</u>的相关类  

SharpMapServer.SMIL20：命名空间为<u>http://www.w3.org/2001/SMIL20</u>的相关类  
SharpMapServer.SMIL20.Language：命名空间为<u>http://www.w3.org/2001/SMIL20的</u>相关类  
SharpMapServer.Xlink：命名空间为<u>http://www.w3.org/1999/xlink</u>的相关类  

### 服务相关
SharpMapServer.Extensions：类扩展  
SharpMapServer.Ogc.Services：定义OGC标准服务相关接口  
SharpMapServer.Ogc.Services.Gdals：基于GDAL实现的OGC标准服务类  
SharpMapServer.Services：服务涉及的WebApi  
