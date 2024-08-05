using BeautyLingerie.ViewModels.Color;


namespace BeautyLingerie.Services.Color.Contracts
{
    public interface IColorService
    {
        Task<IEnumerable<ColorViewModel>> GetAllAsync();
    }
}
