using Library.DTO;
using Library.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Library.Test {
  [TestClass]
  public class RepositoryTest {
    private readonly UnitOfWork _unitOfWork;
    private string _errorMessage = "";
    private int _beginningID;
    private int _ID;

    public RepositoryTest() {
      _unitOfWork = new UnitOfWork();
    }

    [TestMethod]
    public void Author_Insert() {
      try {
        _beginningID = _unitOfWork.AuthorsRepository.Insert(new Author
        {
          FirstName = "ლუკა",
          MiddleName = "ვაჟა-ფშაველა",
          LastName = "რაზიკაშვილი"
        });
        _ID = _beginningID;
      }
      catch (Exception ex) {
        _ID = -1;
        _errorMessage = ex.Message;
      }

      Assert.AreEqual(_beginningID, _ID, $"Author Insert doesn't work. {_errorMessage}");
    }


    [TestMethod]
    public void Author_GetByID() {
      _beginningID = 1009;
      _ID = 1009;
      Author author = new Author();
      try {
        author = _unitOfWork.AuthorsRepository.GetByID(_ID, false);
        _ID = author.AuthorID;
      }
       catch (Exception ex) {
        _ID = -1;
        _errorMessage = ex.Message;
      }

      Assert.AreEqual(_beginningID, _ID, $"Author GetByID doesn't work. {_errorMessage}");
    }


    [TestMethod]
    public void Author_Update() {
      _beginningID = 1010;
      _ID = 1010;
      try {
        _unitOfWork.AuthorsRepository.Update(new Author
        {
          AuthorID = _beginningID,
          FirstName = "ლუკა2",
          MiddleName = "ვაჟა-ფშაველა2",
          LastName = "რაზიკაშვილი2"
        });
      }
      catch (Exception ex) {
        _ID = -1;
        _errorMessage = ex.Message;
      }

      Assert.AreEqual(_beginningID, _ID, $"Author Update doesn't work. {_errorMessage}");
    }

    [TestMethod]
    public void Author_Delete() {
      _beginningID = 1010;
      _ID = 1010;
      try {
        _ID = _unitOfWork.AuthorsRepository.Delete(Convert.ToInt32(_ID));
      }
      catch (Exception ex) {
        _ID = -1;
        _errorMessage = ex.Message;
      }

      Assert.AreNotEqual(_beginningID, _ID, $"Author Delete doesn't work. {_errorMessage}");
    }

    /*
		[TestMethod]
		public void LoginSuccessfulTest()
		{
		  bool result = _unitOfWork.EmployeesRepository.Login("admin", "1234");
		  Assert.IsTrue(result, "Valid username and password didn't login");
		}

		[TestMethod]
		public void LoginWrongPasswordTest()
		{
		  bool result = _unitOfWork.EmployeesRepository.Login("admin", "123");
		  Assert.IsFalse(result, "Wrong password logged");
		}

		[TestMethod]
		public void LoginWrongUsernameTest()
		{
		  bool result = _unitOfWork.EmployeesRepository.Login("admi", "1234");
		  Assert.IsFalse(result, "Wrong username logged");
		}

		[TestMethod]
		public void LoginWrongUsernameAndPasswordTest()
		{
		  bool result = _unitOfWork.EmployeesRepository.Login("admi", "123");
		  Assert.IsFalse(result, "Wrong username and password logged");
		}
		*/
  }
}