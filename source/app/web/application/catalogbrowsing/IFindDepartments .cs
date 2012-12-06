using System.Collections.Generic;

namespace app.web.application.catalogbrowsing
{
  public interface IFindDepartments 
  {
    IEnumerable<DepartmentItem> get_the_main_departments_in_the_store();

    IEnumerable<DepartmentItem> get_the_departments_using(ViewDepartmentInDepartmentRequest request);
  }
}