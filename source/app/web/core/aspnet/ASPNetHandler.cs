using System.Web;
using app.web.core.stubs;

namespace app.web.core.aspnet
{
  public class ASPNetHandler : IHttpHandler
  {
    IProcessRequests front_controller;
    ICreateAControllerRequest request_factory;

    public ASPNetHandler():this(new FrontController(),
      new StubRequestFactory())
    {
    }

    public ASPNetHandler(IProcessRequests front_controller, ICreateAControllerRequest request_factory)
    {
      this.front_controller = front_controller;
      this.request_factory = request_factory;
    }

    public void ProcessRequest(HttpContext context)
    {
      front_controller.process(request_factory.create_request_from(context));
    }

    public bool IsReusable
    {
      get { return true; }
    }
  }
}