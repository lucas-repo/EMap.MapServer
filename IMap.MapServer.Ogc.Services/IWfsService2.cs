using IMap.MapServer.Ogc.Wfs2;

namespace IMap.MapServer.Ogc.Services
{
    public interface IWfsService2 : IOgcService
    {
        string GetCapabilities(string path, GetCapabilitiesType getCapabilitiesType);
        string DescribeFeatureType(string path, DescribeFeatureTypeType describeFeatureTypeType);
        string GetPropertyValue(string path, GetPropertyValueType getPropertyValueType);
        string GetFeature(string path, GetFeatureType getFeatureType);
        string LockFeature(string path, LockFeatureType lockFeatureType);
        string GetFeatureWithLock(string path, GetFeatureWithLockType getFeatureWithLockType);
        string ListStoredQueries(string path, ListStoredQueriesType listStoredQueriesType);
        string DescribeStoredQueries(string path, DescribeStoredQueriesType describeStoredQueriesType);
        string CreateStoredQuery(string path, CreateStoredQueryType createStoredQueryType);
        string DropStoredQuery(string path, DropStoredQuery dropStoredQuery);
        string Transaction(string path, TransactionType transactionType);
        
    }
}
