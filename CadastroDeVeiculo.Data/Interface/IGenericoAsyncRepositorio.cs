using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeVeiculo.Data.Interface
{
    public interface IGenericoAsyncRepositorio<T> where T : class
    {
        IQueryable<T> Entidade { get; }
        Task<T> PegaPorIdAsync(Guid id);
        Task<int> CountTotalAsync();
        Task<IReadOnlyList<T>> PegaTodosAsync();
        Task<T> AdicionaAsync(T entity);
        Task AtualizaAsync(T entity);
        Task DeletaAsync(T entity);
    }
}
