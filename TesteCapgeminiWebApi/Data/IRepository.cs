using System.Threading.Tasks;
using TesteCapgeminiWebApi.Models;

namespace TesteCapgeminiWebApi.Data
{
    public interface IRepository
    {
        //GERAL
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;

        Task<bool> SaveChangesAsync();

        //EXCEL
        Task<Excel[]> GetAllExcelAsync();
        Task<Excel> GetExcelAsyncById(int Id);
    }
}