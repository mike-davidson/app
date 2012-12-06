 using Machine.Specifications;
 using app.web;
 using developwithpassion.specifications.rhinomocks;
 using developwithpassion.specifications.extensions;

namespace app.specs
{  
  [Subject(typeof(FrontController))]  
  public class FrontControllerSpecs
  {
    public abstract class concern : Observes<IProcessRequests,
                                      FrontController>
    {
        
    }

   
    public class when_processing_a_new_request : concern
    {
      Establish c = () =>
      {
        command_that_can_run_the_request = fake.an<IRunOneRequest>();
        command_registry = depends.on<IFindCommands>();
        the_request = new object();

        command_registry.setup(x => x.get_the_command_that_can_run(the_request)).Return(command_that_can_run_the_request);

      };

      Because b = () =>
        sut.process(the_request);

      It should_tell_the_command_that_can_run_the_request_to_process_the_request = () =>
        command_that_can_run_the_request.received(x => x.process(the_request));

      static IRunOneRequest command_that_can_run_the_request;
      static object the_request;
      static IFindCommands command_registry;
    }
  }
}
