using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Repository;

namespace Library.Test
{

  [TestClass]
  public class BaseRepositrotyTest
  {
    private readonly UnitOfWork _unitOfWork;
    private string _errorMessage = "";

    public BaseRepositrotyTest() {
      _unitOfWork = new UnitOfWork();
    }

    [TestMethod]
    public void Base_Insert() {

    }

    [TestMethod]
    public void Base_GetByID() {

    }

    [TestMethod]
    public void Base_Update() {

    }

    [TestMethod]
    public void Base_Delete() {

    }
  }
}
