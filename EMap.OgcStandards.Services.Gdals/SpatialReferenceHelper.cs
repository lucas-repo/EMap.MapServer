using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EMap.OgcStandards.Services.Gdals
{
    public static class SpatialReferenceHelper
    {
        private static string _spatialReferencePath;
        static SpatialReferenceHelper()
        {
            if (_spatialReferencePath == null)
            {
                _spatialReferencePath = ResourceHelper.GetFileName("spatialreference.db", typeof(SpatialReferenceHelper).Assembly);
            }
        }
        private static object ExcuteSql(string commandText)
        {
            object result = null;
            if (string.IsNullOrEmpty(commandText))
            {
                return result;
            }
            using (SqliteConnection conn = new SqliteConnection("Data Source = " + _spatialReferencePath))
            {
                conn.Open();
                using (SqliteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = commandText;
                    result = cmd.ExecuteScalar();
                }
                conn.Close();
            }
            return result;
        }

        public static int? GetWellKnownWkidFromProjecs(string projcs)
        {
            int? wkid = null;
            if (string.IsNullOrEmpty(projcs))
            {
                return wkid;
            }
            string commandText = $"SELECT wkid FROM spatialreference WHERE projcs = '{projcs}'";
            object result = ExcuteSql(commandText);
            if (result != null)
            {
                wkid = Convert.ToInt32(result);
            }
            return wkid;
        }
        public static int? GetWellKnownWkidFromGeogcs(string geogcs)
        {
            int? wkid = null;
            if (string.IsNullOrEmpty(geogcs))
            {
                return wkid;
            }
            string commandText = $"SELECT wkid FROM spatialreference WHERE projcs IS NULL AND geogcs = '{geogcs}'";
            object result = ExcuteSql(commandText);
            if (result != null)
            {
                wkid = Convert.ToInt32(result);
            }
            return wkid;
        }
        public static string GetWellKnownText(int wkid)
        {
            string wkt = null;
            string commandText = $"SELECT wkt FROM spatialreference WHERE wkid = {wkid}";
            object result = ExcuteSql(commandText);
            if (result != null)
            {
                wkt = result.ToString();
            }
            return wkt;
        }
        public static string GetProjcs(int wkid)
        {
            string projcs = null;
            string commandText = $"SELECT projcs FROM spatialreference WHERE wkid = {wkid}";
            object result = ExcuteSql(commandText);
            if (result != null)
            {
                projcs = result.ToString();
            }
            return projcs;
        }
        public static string GetGeogcs(int wkid)
        {
            string geogcs = null;
            string commandText = $"SELECT geogcs FROM spatialreference WHERE wkid = {wkid}";
            object result = ExcuteSql(commandText);
            if (result != null)
            {
                geogcs = result.ToString();
            }
            return geogcs;
        }
    }
}
