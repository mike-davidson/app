using app.web.application.catalogbrowsing.stubs;
using app.web.core;
using app.web.core.stubs;

namespace app.web.application.catalogbrowsing
{
  public class ViewTheMainDepartmentsInTheStore : ISupportAUserFeature
  {
    IFindDepartments department_repository;
    IDisplayInformation display_engine;

    public ViewTheMainDepartmentsInTheStore() : this(new StubDepartmentRepository(),
                                                     new StubDisplayEngine())
    {
    }

    public ViewTheMainDepartmentsInTheStore(IFindDepartments department_repository,
                                            IDisplayInformation department_viewer)
    {
      this.department_repository = department_repository;
      this.display_engine = department_viewer;
    }

    public void process(IContainRequestDetails request)
    {
      display_engine.display(department_repository.get_the_main_departments_in_the_store());
    }
  }
}