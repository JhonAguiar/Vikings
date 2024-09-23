using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApiPrueba.Interfaces;

namespace WebApiPrueba.Repositories
{
    public class VikingRepository<T> : VikingRepositoryInterface<T> where T : class
    {
        private readonly VikingContext _context;
        private readonly DbSet<T> _dbSet;

        public VikingRepository(VikingContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<List<T>> GetAllAsync()
        {
            try
            {
                return await _dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                // Manejo de excepción (logging, etc.)
                throw new Exception("Error al obtener todos los elementos", ex);
            }
        }
        public async Task<T> GetByIdAsync(int id) => await _dbSet.FindAsync(id);
        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync(); // Guardar cambios después de agregar
        }
        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync(); // Guardar cambios después de actualizar
        }
        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync(); // Guardar cambios después de eliminar
            }
        }
    }
}
