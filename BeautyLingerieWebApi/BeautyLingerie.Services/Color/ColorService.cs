using BeautyLingerie.Data;
using BeautyLingerie.Services.Media.Contracts;
using BeautyLingerie.Services.Color.Contracts;
using Microsoft.EntityFrameworkCore;
using BeautyLingerie.ViewModels.Color;

namespace BeautyLingerie.Services.Color
{
    public class ColorService: IColorService
    {
        public BeautyLingerieDbContext dbContext { get; set; }
        public ColorService(BeautyLingerieDbContext dbContext)
        {
            this.dbContext = dbContext;
           
        }
        public async Task<IEnumerable<ColorViewModel>> GetAllAsync()
        {

            List<ColorViewModel> colors = await dbContext.Colors.Select(c => new ColorViewModel
            {
                Name = c.Name,
            }
            ).OrderBy(c=>c.Name)
            .AsNoTracking()
            .ToListAsync();
           
            return colors;
        }
    }
}
