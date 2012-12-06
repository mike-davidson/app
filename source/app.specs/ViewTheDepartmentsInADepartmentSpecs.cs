using System.Collections.Generic;
using Machine.Specifications;
using app.web;
using app.web.application.catalogbrowsing;
using app.web.core;
using developwithpassion.specifications.rhinomocks;
using developwithpassion.specifications.extensions;

namespace app.specs
{
  [Subject(typeof(ViewTheDepartmentsInADepartment))]
  public class ViewTheDepartmentsInADepartmentSpecs
  {
    public abstract class concern : Observes<ISupportAUserFeature,
                                      ViewTheDepartmentsInADepartment>
    {
    }

    public class when_run : concern
    {
        Establish c = () =>
        {
            request = fake.an<IContainRequestDetails>();
            department_finder = depends.on<IFindDepartments>();
            display_engine = depends.on<IDisplayInformation>();
            the_sub_departments = new List<DepartmentItem>();

            request.setup(x => x.map<ViewDepartmentInDepartmentRequest>()).Return(departments_request);
            department_finder.setup(x => x.get_the_departments_using(departments_request)).Return(the_sub_departments);
        };

        Because b = () =>
          sut.process(request);

        It should_get_the_list_of_the_departments_within_the_main_department = () =>
        {

        };

        It should_display_the_departments_within_the_main_department = () =>
          display_engine.received(x => x.display(the_sub_departments));


        static IFindDepartments department_finder;
        static IContainRequestDetails request;
        static IEnumerable<DepartmentItem> the_sub_departments;
        static IDisplayInformation display_engine;
        static int department_id;
        static ViewDepartmentInDepartmentRequest departments_request;
    }
  }
}