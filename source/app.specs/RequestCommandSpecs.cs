 using Machine.Specifications;
 using app.web;
 using developwithpassion.specifications.rhinomocks;
 using developwithpassion.specifications.extensions;

namespace app.specs
{  
  [Subject(typeof(RequestCommand))]  
  public class RequestCommandSpecs
  {
    public abstract class concern : Observes<IRunOneRequest,
                                      RequestCommand>
    {
        
    }

   
    public class when_determining_if_it_can_run_a_request : concern
    {
      Establish c = () =>
      {
        request = fake.an<IContainRequestDetails>();
      };

      Because b = () =>
        result = sut.can_run(request);

        private It should_return_true = () =>
          result.ShouldBeTrue();  
      
      static IContainRequestDetails request;
      static bool result;
    }
  }
}
