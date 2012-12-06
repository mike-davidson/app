using app.web.core;

namespace app.web.application.catalogbrowsing
{
  public class ViewTheProductsInADepartment : ISupportAUserFeature
  {
      IFindProducts product_repository;
      IDisplayInformation display_engine;
      

    public ViewTheProductsInADepartment(IFindProducts product_repository,
                                            IDisplayInformation product_viewer)
    {
      this.product_repository = product_repository;
      this.display_engine = product_viewer;
    }

    public void process(IContainRequestDetails request)
    {
      display_engine.display(product_repository.get_the_products_in_a_department());
    }
  }
}