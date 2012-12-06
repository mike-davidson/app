using System.Collections.Generic;

namespace app.web
{
  public class CommandRegistry : IFindCommands
  {
    IEnumerable<IRunOneRequest> all_commands;

    public CommandRegistry(IEnumerable<IRunOneRequest> all_commands)
    {
      this.all_commands = all_commands;
    }

    public IRunOneRequest get_the_command_that_can_run(IContainRequestDetails the_request)
    {
      foreach (var runOneRequest in all_commands)
      {
        if (runOneRequest.can_run(the_request)) return  runOneRequest;
      }

      return null;
    }
  }
}