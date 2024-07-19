using MultiShop.Discount.Api.Dtos;

namespace MultiShop.Discount.Api.Services
{
    public interface IDiscountService
    {
        Task<List<ResultCupponDto>> GetAllCupponAsync();
        Task CreateCupponAsync(CreateCupponDto createCupponDto);
        Task UpdateCupponAsync(UpdateCupponDto updateCupponDto);
        Task DeleteCupponAsync(int id);
        Task<GetByIdCupponDto> GetByIdCupponAsync(int id);
    }
}
