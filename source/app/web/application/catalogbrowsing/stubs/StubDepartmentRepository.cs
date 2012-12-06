using System.Collections.Generic;
using System.Linq;

namespace app.web.application.catalogbrowsing.stubs
{
  public class StubDepartmentRepository : IFindDepartments
  {
    public IEnumerable<DepartmentItem> get_the_main_departments_in_the_store()
    {
      return Enumerable.Range(1, 1000).Select(x => new DepartmentItem{name = x.ToString("Department 0")});
    }

    public IEnumerable<DepartmentItem> get_the_departments_within_the_main_department(int department_id)
    {
      return Enumerable.Range(1, 1000).Select(x => new DepartmentItem { name = x.ToString("Main Department: "+ department_id + ": - Sub-Department 0") });
    }
  }
}