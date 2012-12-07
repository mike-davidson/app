using System.Collections.Generic;

namespace app.web.application.catalogbrowsing
{
  public interface IFindInformationInTheStore 
  {
    IEnumerable<DepartmentItem> get_the_main_departments_in_the_store();

    IEnumerable<DepartmentItem> get_the_departments_using(IFindStoreCatalogRequests request);
    IEnumerable<Product> get_the_products_using(IFindStoreCatalogRequests request);
  }
}