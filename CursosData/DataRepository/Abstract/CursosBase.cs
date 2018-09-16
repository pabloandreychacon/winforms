using CursosData.DataRepository.Context;
using CursosData.DataRepository.Interfaces;
using CursosEntities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace CursosData.DataRepository.Abstract
{
    public abstract class CursosBase : ICursos
    {
        // fields
        private DbContextTransaction dbCtxTran;

        // props
        public CursosEntity dbCtx { get; set; }
        private string myPropertyExample = "";
        public string MyPropertyExample
        {
            get { return myPropertyExample; } // read only
            //set { myPropertyExample = value; }
        }
        public string MyAutoPropertyExample { get; set; }

        // ctors
        public CursosBase()
        {
            if (dbCtx == null)
                dbCtx = new CursosEntity();// multiusuario: ya no es readonly, se necesita que se cree cada vez para que recoja de nuevo los datos de la base de datos
            //dbCtx = CursosContext.DbCtx; 
        }

        public CursosBase(CursosEntity db)
        {
            dbCtx = db; // por si quiero usar otro contextDb que no sea el static ControlContext.DbCtx 
        }

        // general methods non virtual
        public void BeginTran()
        {
            dbCtxTran = dbCtx.Database.BeginTransaction();
        }

        public void Commit()
        {
            dbCtxTran.Commit();
        }

        public void Rollback()
        {
            dbCtxTran.Rollback();
        }

        public void Refresh<Q>(Q query) where Q : class
        {
            (((IObjectContextAdapter)dbCtxTran).ObjectContext).Refresh(
                System.Data.Entity.Core.Objects.RefreshMode.StoreWins, query) ;
        }
        public int ExecuteSql(string sql) 
        {
            try
            {
                BeginTran();
                var count = dbCtx.Database.ExecuteSqlCommand(sql);
                Commit();
                return count;
            }
            catch (Exception)
            {
                throw;
            }            
        }
        public string GetConnection()
        {
            // el conecction string debe tener Persist Security Info=True;
            return dbCtx.Database.Connection.ConnectionString;
        }
        public void AddEntity<E>(E entity) where E : class
        {
            dbCtx.Set<E>().Add(entity);
        }

        public void CreateEntity<E>(E entity) where E : class
        {
            dbCtx.Set<E>().Add(entity);
            dbCtx.SaveChanges();
        }

        public void UpdateEntity<E>(E entity) where E : class
        {
            try
            {
                if (dbCtx.Entry(entity).State == EntityState.Unchanged) return;
                dbCtx.SaveChanges();
            }
            catch (Exception)
            {
                if (dbCtx.Entry(entity).State != EntityState.Added) ReloadEntity(entity);
                throw;
            }
        }

        public void DeleteEntity<E>(E entity) where E : class
        {
            try
            {
                dbCtx.Set<E>().Remove(entity);
                dbCtx.SaveChanges();
            }
            catch (Exception) 
            { 
                ReloadEntity(entity);
                throw; 
            }
        }

        public void ReloadEntity<T>(T entity) where T : class
        {
            try
            {
                dbCtx.Entry(entity).Reload();
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        public E SetEntity<E>(object obj) where E : class
        {
            return (E)obj;
        }

        public E GetEntity<E>() where E : class
        {
            return dbCtx.Set<E>().FirstOrDefault();
        }

        public IEnumerable<E> GetList<E>() where E : class
        {
            IEnumerable<E> result = dbCtx.Set<E>();
            return result.ToList();
        }

        public BindingList<E> GetBindList<E>() where E : class
        {
            dbCtx.Set<E>().Load();
            var bindList = dbCtx.Set<E>().Local.ToBindingList();
            return bindList;
        }

        // virtual methods for overriding
        public virtual string SayName()
        {
            return MyAutoPropertyExample + MyPropertyExample + " Inside ControlR.SayName()";
        }
    }
}
