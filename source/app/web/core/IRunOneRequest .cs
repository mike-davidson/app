namespace app.web.core
{
  public interface IRunOneRequest : ISupportAUserFeature
  {
    bool can_run(IContainRequestDetails the_request);
  }
}