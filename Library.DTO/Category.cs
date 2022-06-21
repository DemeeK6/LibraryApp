using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DTO {
  public class Category {
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
    public string Description { get; set; }
    public int ParentID { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreateDate { get; set; }
  }
}

