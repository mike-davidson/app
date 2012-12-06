using System.Web;

namespace app.web.core
{
  public interface ICreateAControllerRequest
  {
    IContainRequestDetails create_request_from(HttpContext a_raw_asp_net_request);
  }
}