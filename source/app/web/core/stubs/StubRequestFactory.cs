using System.Web;
using app.web.application.catalogbrowsing;

namespace app.web.core.stubs
{
  public class StubRequestFactory : ICreateAControllerRequest
  {
    public IContainRequestDetails create_request_from(HttpContext a_raw_asp_net_request)
    {
      return new StubRequest();
    }

    class StubRequest : IContainRequestDetails
    {
        public int get_the_department()
        {
           return 1;
        }
    }
  }
}