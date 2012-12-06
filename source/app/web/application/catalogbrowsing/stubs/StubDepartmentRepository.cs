using System.Collections.Generic;
using System.Linq;

namespace app.web.application.catalogbrowsing.stubs
{
  public class StubStoreCatalog : IFindInformationInTheStore
  {
    public IEnumerable<DepartmentItem> get_the_main_departments_in_the_store()
    {
      return Enumerable.Range(1, 1000).Select(x => new DepartmentItem {name = x.ToString("Department 0")});
    }

    public IEnumerable<DepartmentItem> get_the_departments_using(ViewDepartmentInDepartmentRequest request)
    {
      return Enumerable.Range(1, 1000).Select(x => new DepartmentItem {name = x.ToString("Sub Department 0")});
    }

    public IEnumerable<Product> get_the_products_using(ViewTheProductsInDepartmentRequest request)
    {
      return Enumerable.Range(1, 1000).Select(x => new Product {name = x.ToString("Product 0")});
    }
  }
}