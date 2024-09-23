using SharedModels;

namespace WebApiPrueba.Interfaces
{
    public interface IUnitOfWork
    {
        VikingRepositoryInterface<Viking> Vikingos { get; }
        Task<int> CompleteAsync();
    }
}
