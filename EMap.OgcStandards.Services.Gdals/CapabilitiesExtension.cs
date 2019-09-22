using EMap.OgcStandards.Ows1_1;
using EMap.OgcStandards.Wmts1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EMap.OgcStandards.Services.Gdals
{
    /// <summary>
    /// Capabilities的扩展方法
    /// </summary>
    public static class CapabilitiesExtension
    {
        public static string GetHref(this Capabilities capabilities, WmtsOperationType operationType = WmtsOperationType.GetTile, WmtsRequestType requestMethod = WmtsRequestType.REST)
        {
            string href = null;
            Operation operation = capabilities.OperationsMetadata.Operation.FirstOrDefault(x => x.name == operationType.ToString());
            if (operation != null)
            {
                RequestMethodType[] requestMethodTypes = operation.DCP?.FirstOrDefault().Item.Items;
                if (requestMethodTypes != null)
                {
                    foreach (var requestMethodType in requestMethodTypes)
                    {
                        DomainType[] constraints = requestMethodType.Constraint;
                        if (constraints != null)
                        {
                            foreach (var constraint in constraints)
                            {
                                if (constraint.name == "GetEncoding")
                                {
                                    object[] allowedValues = constraint.AllowedValues;
                                    if (allowedValues != null)
                                    {
                                        bool ret = allowedValues.Any(item => item is Ows1_1.ValueType allowedValue && allowedValue.Value == requestMethod.ToString());
                                        if (ret)
                                        {
                                            href = requestMethodType.href;
                                            return href;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return href;
        }
    }
}
