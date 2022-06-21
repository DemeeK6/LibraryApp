using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using Library.APP.Interfaces;
using Library.DTO;
using Library.Repository;

namespace Library.APP.Lists {
  public partial class BaseListForm : Form, IListForm {

    private Type _dtoType;
    private UnitOfWork _unitOfWork;

    public BaseListForm() {
      InitializeComponent();
    }

    public void BuildForm(Type type) {
      _dtoType = type;
      AddColumns();
      //LoadData();
    }

    public void DeleteData() {
      throw new NotImplementedException();
    }

    public void InsertData()  {
      throw new NotImplementedException();
    }

    public void LoadData() {
         
      throw new NotImplementedException();
    }

    public void UpdateData(){
      throw new NotImplementedException();
    }

    private void AddColumns(){
      var properties = _dtoType.GetProperties();

      foreach(var propInfo in properties) {
        grdRecords.Columns.Add(propInfo.Name, propInfo.Name);
      }
    }
  }
}
