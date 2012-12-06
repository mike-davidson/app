 using Machine.Specifications;
 using app.web;
 using app.web.core;
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

   
  }
}
