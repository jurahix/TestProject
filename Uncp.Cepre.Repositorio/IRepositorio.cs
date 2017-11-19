using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Uncp.Cepre.Repositorio
{
    interface IRepositorio<TEntity> where TEntity : class
    {
        TEntity BuscarPorId(string id);
        IEnumerable<TEntity> ListarTodos();
        IEnumerable<TEntity> BuscarPorExpresion(Expression<Func<TEntity, bool>> predicate);
        void Guardar(TEntity entity);
        void GuardarLista(IEnumerable<TEntity> entities);

        void Eliminar(TEntity entity);
        void EliminarLista(IEnumerable<TEntity> entities);
    }
}
