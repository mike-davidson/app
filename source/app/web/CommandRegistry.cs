using System.Collections.Generic;
using System.Linq;

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
      return all_commands.First(x => x.can_run(the_request));
    }
  }
}