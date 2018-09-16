using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosData.DataRepository.Interfaces
{
    public interface ICursos
    {
        /// abstracto y obligatorio to implement
        /// SetEntity maybe not
        E SetEntity<E>(object entity) where E : class;
        /// GetIEnumerable or GetList
        IEnumerable<E> GetList<E>() where E : class;
        /// GetBindList
        BindingList<E> GetBindList<E>() where E : class;
        /// DeleteEntity
        void DeleteEntity<E>(E entity) where E : class;
        /// UpdateEntity
        void UpdateEntity<E>(E entity) where E : class;
        void AddEntity<E>(E entity) where E : class;
        void CreateEntity<E>(E entity) where E : class;
    }
}
