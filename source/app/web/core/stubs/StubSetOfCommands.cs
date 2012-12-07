using System.Collections;
using System.Collections.Generic;
using app.web.application.catalogbrowsing;

namespace app.web.core.stubs
{
  public class StubSetOfCommands : IEnumerable<IRunOneRequest>
  {

      private ISupportAUserFeature user_feature_requested;

      public StubSetOfCommands(ISupportAUserFeature user_feature_requested)
      {
          this.user_feature_requested = user_feature_requested;
      }
    
      
    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    public IEnumerator<IRunOneRequest> GetEnumerator()
    {
      yield return new RequestCommand(x => true, this.user_feature_requested);
    }
  }
}