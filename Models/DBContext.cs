using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
 
using System.Linq;
using System.IO;

using Microsoft.Extensions.DependencyModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using System.Data.Common;

 

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class DBContext 
    {
        protected Guid _tenant;

        

        void SetQueryFilter<TEntity>(ModelBuilder modelBuilder)
            where TEntity : EntityBase
        {
            modelBuilder.Entity<TEntity>().HasQueryFilter(b => EF.Property<Guid>(b, "Corpid") == _tenant);
        }


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {

            var setQueryFilterMethod = new Action<ModelBuilder>(SetQueryFilter<EntityBase>)
                    .Method.GetGenericMethodDefinition();

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (entityType.BaseType == null && typeof(EntityBase).IsAssignableFrom(entityType.ClrType))
                {
                    if (entityType.FindProperty("Corpid") != null)
                        setQueryFilterMethod
                            .MakeGenericMethod(entityType.ClrType)
                            .Invoke(this, new object[] { modelBuilder });
                }
            }
        } 

        public T CreateEntity<T>(T? obj = null) where T : class, new()
        {
            if (obj == null)
                obj = new T();// { Id = Guid.NewGuid(), AdduserNavigation=new User(), Curcode= "TRY  " };

            var columnValues = new List<System.Collections.Generic.KeyValuePair<string, string>>();

            var et = this.Model.GetEntityTypes().FirstOrDefault(x => x.ClrType == obj.GetType());

            foreach (var prop in et.GetProperties())
            {
                object? defVal = null;// prop.GetDefaultValue();

                if (defVal != null)
                {
                    obj.GetType().GetProperty(prop.Name).SetValue(obj, defVal);
                }
                else
                {
                    defVal = prop.GetDefaultValueSql();

                    if (defVal != null)
                        columnValues.Add(new KeyValuePair<string, string>(prop.Name, "CAST(" + defVal.ToString() + " AS " + prop.GetColumnType() + ")"));
                    else if (prop.Name == "Adduser")
                    {
                        if (Guid.TryParse(_contextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "userId")?.Value, out var userId))
                            obj.GetType().GetProperty(prop.Name).SetValue(obj, userId);
                    }
                    else if (prop.Name == "Corpid")
                    {
                        if (_tenant != Guid.Empty)
                            obj.GetType().GetProperty(prop.Name).SetValue(obj, _tenant); 
                    }
                }
            }



            if (columnValues.Count > 0)
            {
                obj = this.GenerateEntity<T>(string.Format("SELECT {0} ", string.Join(",", columnValues.Select(x => x.Key + " = " + x.Value).ToArray())), obj).Result;
            }

            return obj;
        }

        
    }
}
