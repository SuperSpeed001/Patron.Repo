namespace Patron.Repo.Repository
{
    using Microsoft.EntityFrameworkCore;
    using Patron.Modelos;
    using Patron.Repo.Model;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Se crea una clase llamada repository que requiere como tipo la clase  BaseModel
    /// y agrega los metodos basicos, CRUD para las clases que hay en ese BaseModel
    /// 
    /// </summary>
    /// <typeparam name="Entity">Aqui Entity es la entidad o tabla que estoy pasando, ejemplo Blog o Post</typeparam>
    public class GenericRepository<Entity> where Entity: BaseModel
    {
        private readonly BloggingContext _context;    //hace mension al contexto
        private DbSet<Entity> _dbSet;                 //aqui hace mension a cada entidad, por ejemplo cuando uso Blog

        public GenericRepository(BloggingContext context)
        {
            _context = context;
            _dbSet = _context.Set<Entity>();
        }

        public async Task<List<Entity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<Entity> GetAsync(Guid id)
        {
            return await _dbSet.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task CreateAsync(Entity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Update(Entity entity)
        {
            _dbSet.Update(entity);
        }

        public void Delete(Entity entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }



    }
}
