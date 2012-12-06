using System.Collections.Generic;
using Machine.Specifications;
using app.web;
using app.web.application.catalogbrowsing;
using app.web.core;
using developwithpassion.specifications.rhinomocks;
using developwithpassion.specifications.extensions;

namespace app.specs
{
  [Subject(typeof(ViewTheMainDepartmentsInTheStore))]
  public class ViewTheMainDepartmentsInTheStoreSpecs
  {
    public abstract class concern : Observes<ISupportAUserFeature,
                                      ViewTheMainDepartmentsInTheStore>
    {
    }

    public class when_run : concern
    {
      Establish c = () =>
      {
        request = fake.an<IContainRequestDetails>();
        department_finder = depends.on<IFindDepartments>();
        the_main_departments = new List<DepartmentItem>();
        display_engine = depends.on<IDisplayInformation>();

        department_finder.setup(x => x.get_the_main_departments_in_the_store()).Return(the_main_departments);
      };

      Because b = () =>
        sut.process(request);

      It should_get_the_list_of_the_main_departments = () =>
      {

      };

      It should_display_the_main_departments = () =>
        display_engine.received(x => x.display(the_main_departments));


      static IFindDepartments department_finder;
      static IContainRequestDetails request;
      static IEnumerable<DepartmentItem> the_main_departments;
      static IDisplayInformation display_engine;
    }
  }
}
