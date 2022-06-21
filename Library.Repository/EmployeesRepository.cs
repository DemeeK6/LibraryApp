using DatabaseHelper;
using Library.DTO;

namespace Library.Repository
{
	public class EmployeesRepository : BaseRepository<Employee>
	{
		internal EmployeesRepository(Database database) : base(database)
		{

		}
	}
}