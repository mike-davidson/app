 using System.Collections.Generic;
 using Machine.Specifications;
 using app.web.application.catalogbrowsing;
 using app.web.core;
 using developwithpassion.specifications.rhinomocks;
 using developwithpassion.specifications.extensions;

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
        product_finder = depends.on<IFindProducts>();
        display_engine = depends.on<IDisplayInformation>();
        the_products_in_a_department = new List<Product>();
        product_finder.setup(x => x.get_the_products_in_a_department()).Return(the_products_in_a_department);
      };

      Because b = () =>
        sut.process(request);


      It should_display_the_products_in_the_department = () =>
        display_engine.received(x => x.display(the_products_in_a_department));

      static IDisplayInformation display_engine;
      static IContainRequestDetails request;
      static IEnumerable<Product> the_products_in_a_department;
      static IFindProducts product_finder;
    }
  }
}
