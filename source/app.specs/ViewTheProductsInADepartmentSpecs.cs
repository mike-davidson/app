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
        display_engine = depends.on<IDisplayInformation>();
      };

      Because b = () =>
        sut.process(request);


      It should_display_the_products_in_the_department = () =>
        display_engine.received(x => x.display(the_products_in_a_department));

      static IDisplayInformation display_engine;
      static IContainRequestDetails request;
      static IEnumerable<....> the_products_in_a_department;
    }
  }
}
