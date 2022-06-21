using DatabaseHelper;
using Library.DTO;

namespace Library.Repository {
  public class MembersRepository : BaseRepository<Member> {
    internal MembersRepository(Database database) : base(database) {

    }
  }
}