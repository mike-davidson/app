 using System;
 using System.IO;
 using System.Web;
 using Machine.Specifications;
 using app.specs.utility;
 using app.web.core;
 using app.web.core.aspnet;
 using developwithpassion.specifications.rhinomocks;
 using developwithpassion.specifications.extensions;

namespace app.specs
{  
  [Subject(typeof(ASPNetHandler))]  
  public class ASPNetHandlerSpecs
  {
    public abstract class concern : Observes<IHttpHandler,
                                      ASPNetHandler>
    {
        
    }

   
    public class when_processing_a_new_aspnet_request : concern
    {

      Establish c = () =>
      {
        front_controller = depends.on<IProcessRequests>();
        request_factory = depends.on<ICreateAControllerRequest>();
        a_raw_asp_net_request = ObjectFactory.web.create_http_context();
        a_new_request = fake.an<IContainRequestDetails>();

        request_factory.setup(x => x.create_request_from(a_raw_asp_net_request)).Return(a_new_request);
      };

      Because b = () =>
        sut.ProcessRequest(a_raw_asp_net_request);

      It should_delegate_the_processing_of_a_new_controller_request_to_our_front_controller = () =>
        front_controller.received(x => x.process(a_new_request));

      static IProcessRequests front_controller;
      static IContainRequestDetails a_new_request;
      static HttpContext a_raw_asp_net_request;
      static ICreateAControllerRequest request_factory;
    }
  }
}
