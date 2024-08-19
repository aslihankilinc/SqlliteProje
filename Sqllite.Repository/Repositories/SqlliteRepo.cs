using Sqllite.Data;
using Sqllite.Data.Table;
using Sqllite.Repository.Contract;

namespace Sqllite.Repository.Repositories
{
    public class SqlliteRepo : ISqllite
    {
        public async Task<List<Category>> GetCategory()
        {
            List<Category> list = new();
            try
            {
                using (var context = new Context())
                {
                    list = context.Category.ToList();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return list;
        }

        public async Task<bool> AddCategory(List<Category> category)
        {
            try
            {
                using (var context = new Context())
                {
                    context.Category.AddRange(category);
                    context.SaveChanges();
                    
                }
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
