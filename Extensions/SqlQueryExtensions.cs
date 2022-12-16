using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
 
using System.Linq;
using System.IO;

 
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using System.Data.Common;


public static class SqlQueryExtensions
{
    

    public static async Task<T> GenerateEntity<T>(this DbContext db, string sql, object newObject = null) where T : class, new()
    {
        using (var cnn = new Microsoft.Data.SqlClient.SqlConnection(db.Database.GetConnectionString()))
        {
            using (var cmd = cnn.CreateCommand())
            {
                cmd.CommandText = sql;

                if (newObject == null)
                    newObject = new T();

                var oldCnnState = cnn.State;

                if (oldCnnState != System.Data.ConnectionState.Open)
                    cnn.Open();

                using (var rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                        rd.MapDataToObject(newObject);

                    rd.Close();

                    cnn.Close();

                    return (T)Convert.ChangeType(newObject, typeof(T));
                }
            }
        }
    }
    public static void MapDataToObject<T>(this DbDataReader dataReader, T newObject)
    {
        if (newObject == null) throw new ArgumentNullException(nameof(newObject));

        var type = newObject.GetType();

        var members = type.GetProperties();

        for (int i = 0; i < dataReader.FieldCount; i++)
        {
            if (!dataReader.IsDBNull(i))
            {
                string fieldName = dataReader.GetName(i);

                if (members.Any(m => string.Equals(m.Name, fieldName, StringComparison.OrdinalIgnoreCase)))
                {
                    type.GetProperty(fieldName).SetValue(newObject, dataReader.GetValue(i));
                    
                }
            }
        }
    }
}