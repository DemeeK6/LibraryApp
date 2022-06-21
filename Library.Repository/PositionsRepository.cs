using DatabaseHelper;
using Library.DTO;

namespace Library.Repository {
  public class PositionsRepository : BaseRepository<Position> {
    internal PositionsRepository(Database database) : base(database) {

    }
  }
}