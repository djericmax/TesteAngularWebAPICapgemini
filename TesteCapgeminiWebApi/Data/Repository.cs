using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TesteCapgeminiWebApi.Models;

namespace TesteCapgeminiWebApi.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<Excel[]> GetAllExcelAsync()
        {
            IQueryable<Excel> query = _context.Excel;

            query = query.AsNoTracking()
                         .OrderBy(c => c.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Excel> GetExcelAsyncById(int Id)
        {
            IQueryable<Excel> query = _context.Excel;

            query = query.AsNoTracking()
                         .OrderBy(excel => excel.NomeProduto)
                         .Where(excel => excel.Id == Id);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }        
    }
}
