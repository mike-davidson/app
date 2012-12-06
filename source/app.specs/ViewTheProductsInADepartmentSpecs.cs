using System.Collections.Generic;
using Machine.Specifications;
using app.web.application.catalogbrowsing;
using app.web.core;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
  [Subject(typeof(ViewTheProductsInADepartment))]
  public class ViewTheProductsInADepartmentSpecs
  {
    public abstract class concern : Observes<ISupportAUserFeature,
                                      ViewTheProductsInADepartment>
    {
    }

    public class when_run : concern
    {
      Establish c = () =>
      {
        request = fake.an<IContainRequestDetails>();
        store_catalog = depends.on<IFindInformationInTheStore>();
        display_engine = depends.on<IDisplayInformation>();
        product_request = new ViewTheProductsInDepartmentRequest();
        the_products_in_a_department = new List<Product>();

        request.setup(x => x.map<ViewTheProductsInDepartmentRequest>()).Return(product_request);

        store_catalog.setup(x => x.get_the_products_using(product_request)).Return(the_products_in_a_department);
      };

      Because b = () =>
        sut.process(request);

      It should_display_the_products_in_the_department = () =>
        display_engine.received(x => x.display(the_products_in_a_department));

      static IDisplayInformation display_engine;
      static IContainRequestDetails request;
      static IEnumerable<Product> the_products_in_a_department;
      static IFindInformationInTheStore store_catalog;
      static ViewTheProductsInDepartmentRequest product_request;
    }
  }
}