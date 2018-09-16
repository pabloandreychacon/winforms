using CursosEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosData.DataRepository.Context
{
    public class CursosContext
    {
        // se hace global para que todos puedan accesar y read only para que usen el mismo
        //private static readonly CursosEntity dbCtx = new CursosEntity();
        //public static CursosEntity DbCtx
        //{
        //    get { return dbCtx; }
        //}
        // ya no es readonly, se necesita que se cree cada vez para que recoja de nuevo los datos de la base de datos
        // multiusuario
        private CursosEntity dbCtx = new CursosEntity();
        public CursosEntity DbCtx
        {
            get { return dbCtx; }
        }
    }
}
