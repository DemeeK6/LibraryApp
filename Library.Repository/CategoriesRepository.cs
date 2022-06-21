using DatabaseHelper;
using Library.DTO;

namespace Library.Repository
{
  public class CategoriesRepository : BaseRepository<Category> {
    internal CategoriesRepository(Database database) : base(database) {

    }
  }
}
