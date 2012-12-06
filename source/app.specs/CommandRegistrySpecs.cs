using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;
using app.web;
using developwithpassion.specifications.rhinomocks;
using developwithpassion.specifications.extensions;

namespace app.specs
{
  [Subject(typeof(CommandRegistry))]
  public class CommandRegistrySpecs
  {
    public abstract class concern : Observes<IFindCommands,
                                      CommandRegistry>
    {
    }

    public class when_finding_a_command_that_can_run_a_request : concern
    {
      Establish c = () =>
      {
        the_request = fake.an<IContainRequestDetails>();
        all_the_possible_commands = Enumerable.Range(1, 100).Select(x => fake.an<IRunOneRequest>()).ToList();
        depends.on<IEnumerable<IRunOneRequest>>(all_the_possible_commands);

      };
      Because b = () =>
        result = sut.get_the_command_that_can_run(the_request);

      public class and_it_has_the_command
      {
        Establish c = () =>
        {
          the_command_that_can_run = fake.an<IRunOneRequest>();
          all_the_possible_commands.Add(the_command_that_can_run);

          the_command_that_can_run.setup(x => x.can_run(the_request)).Return(true);
        };

        It should_return_the_command_that_can_run_the_request = () =>
          result.ShouldEqual(the_command_that_can_run);

        static IRunOneRequest the_command_that_can_run;
      }

      static IContainRequestDetails the_request;
      static IRunOneRequest result;
      static List<IRunOneRequest> all_the_possible_commands;
    }
  }
}