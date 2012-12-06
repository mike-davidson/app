namespace app.web.core
{
  public class FrontController : IProcessRequests
  {
    IFindCommands command_registry;

    public FrontController(IFindCommands command_registry)
    {
      this.command_registry = command_registry;
    }

    public FrontController():this(new CommandRegistry())
    {
    }

    public void process(IContainRequestDetails the_request)
    {
      command_registry.get_the_command_that_can_run(the_request).process(the_request);
    }
  }
}