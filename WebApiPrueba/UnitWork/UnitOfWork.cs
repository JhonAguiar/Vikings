using SharedModels;
using WebApiPrueba.Interfaces;
using WebApiPrueba.Repositories;

namespace WebApiPrueba.UnitWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VikingContext _context;
        public VikingRepositoryInterface<Viking> Vikingos { get; }

        public UnitOfWork(VikingContext context)
        {
            _context = context;
            Vikingos = new VikingRepository<Viking>(context);
        }

        public async Task<int> CompleteAsync() => await _context.SaveChangesAsync();


    }
}
