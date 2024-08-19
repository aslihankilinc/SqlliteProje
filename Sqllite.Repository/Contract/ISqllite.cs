using Sqllite.Data.Table;
namespace Sqllite.Repository.Contract
{
    public interface ISqllite
    {
        public  Task<List<Category>> GetCategory();
        public  Task<bool> AddCategory(List<Category> category);


    }
}
