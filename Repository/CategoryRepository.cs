using API_foreigner_teacher.Data;
using API_foreigner_teacher.Interfaces;
using API_foreigner_teacher.Models;

namespace API_foreigner_teacher.Repository
{
    public class CategoryRepository : ICategoryRepository

    {
        private readonly DataContext context;

        public CategoryRepository(DataContext context)
        {
            this.context = context;
        }
        public bool CategoryExists(int id)
        {
            return  context.Categories.Any(p => p.Id == id);
        }

        public ICollection<Category> GetCategories()
        {
            return context.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return context.Categories.Where(c => c.Id == id).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
        {
            return context.PokemonCategories.Where(e => e.CategoryId == categoryId).Select(c => c.Pokemon).ToList();
        }
    }
}
