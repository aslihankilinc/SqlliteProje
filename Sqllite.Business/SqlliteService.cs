using Sqllite.Data.Table;
using Sqllite.Repository.Repositories;

namespace Sqllite.Business
{
    public class SqlliteService
    {
        private SqlliteRepo repo = null;
        public SqlliteService()
        {
            repo = new SqlliteRepo();
        }
        public async Task<List<Category>> GetCategory()
        {
            return await repo.GetCategory();
        }

        public async Task<bool> SetCategory()
        {
            List<Category> list = new();
            list.Add(new Category { Name = "İkinci El", Description = "Kullanılmış satılık ürünler", IsDeleted = 0 });
            list.Add(new Category { Name = "Teşhir", Description = "Teşhir amaçlı kullanılmış satılık ürünler", IsDeleted = 0 });
            list.Add(new Category { Name = "Sıfır", Description = "Kullanılmamış satılık ürünler", IsDeleted = 0 });
            return await repo.AddCategory(list);
        }
    }
}
