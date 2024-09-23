using SharedModels;
using WebApiPrueba.Interfaces;

namespace WebApiPrueba.Business
{
    public class VikingoService
    {
        private readonly IUnitOfWork _unitOfWork;

        public VikingoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Viking>> GetAllAsync()
        {
            return await _unitOfWork.Vikingos.GetAllAsync();
        }

        public async Task<Viking> GetByIdAsync(int id)
        {
            return await _unitOfWork.Vikingos.GetByIdAsync(id);
        }

        public async Task AddAsync(Viking vikingo)
        {
            await _unitOfWork.Vikingos.AddAsync(vikingo);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateAsync(Viking vikingo)
        {
            await _unitOfWork.Vikingos.UpdateAsync(vikingo);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _unitOfWork.Vikingos.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
        }
    }
}
