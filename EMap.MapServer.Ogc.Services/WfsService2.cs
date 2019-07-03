using System;
using System.Collections.Generic;
using System.Text;
using EMap.MapServer.Ogc.Wfs2;

namespace EMap.MapServer.Ogc.Services
{
    public abstract class WfsService2 : OgcService, IWfsService2
    {
        public abstract string CreateStoredQuery(string path, CreateStoredQueryType createStoredQueryType);
        public abstract string DescribeFeatureType(string path, DescribeFeatureTypeType describeFeatureTypeType);
        public abstract string DescribeStoredQueries(string path, DescribeStoredQueriesType describeStoredQueriesType);
        public abstract string DropStoredQuery(string path, DropStoredQuery dropStoredQuery);
        public abstract string GetCapabilities(string path, GetCapabilitiesType getCapabilitiesType);
        public abstract string GetFeature(string path, GetFeatureType getFeatureType);
        public abstract string GetFeatureWithLock(string path, GetFeatureWithLockType getFeatureWithLockType);
        public abstract string GetPropertyValue(string path, GetPropertyValueType getPropertyValueType);
        public abstract string ListStoredQueries(string path, ListStoredQueriesType listStoredQueriesType);
        public abstract string LockFeature(string path, LockFeatureType lockFeatureType);
        public abstract string Transaction(string path, TransactionType transactionType);
    }
}
