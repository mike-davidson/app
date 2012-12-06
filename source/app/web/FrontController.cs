namespace app.web
{
  public class FrontController : IProcessRequests
  {
    IFindCommands findCommands;

    public FrontController(IFindCommands findCommands)
    {
       this.findCommands = findCommands;
    }

    public void process(object the_request)
    {
      var command = findCommands.get_the_command_that_can_run(the_request);
      command.process(the_request);
    }
  }
}