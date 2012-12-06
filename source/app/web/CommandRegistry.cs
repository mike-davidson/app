using System.Collections.Generic;
using System.Linq;

namespace app.web
{
  public class CommandRegistry : IFindCommands
  {
    IEnumerable<IRunOneRequest> all_commands;
    IHandleTheScenarioOfCreatingTheMissingCommand special_case_factory;

    public CommandRegistry(IEnumerable<IRunOneRequest> all_commands, IHandleTheScenarioOfCreatingTheMissingCommand special_case_factory)
    {
      this.all_commands = all_commands;
      this.special_case_factory = special_case_factory;
    }

    public IRunOneRequest get_the_command_that_can_run(IContainRequestDetails the_request)
    {
      return all_commands.FirstOrDefault(x => x.can_run(the_request)) ?? special_case_factory();
    }
  }
}