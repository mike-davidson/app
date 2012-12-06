namespace app.web.core
{
  public class RequestCommand : IRunOneRequest
  {
    IMatchARequest request_specification;
    ISupportAUserFeature feature;

    public RequestCommand(IMatchARequest request_specification, ISupportAUserFeature feature)
    {
      this.request_specification = request_specification;
      this.feature = feature;
    }

    public void process(IContainRequestDetails the_request)
    {
      feature.process(the_request);
    }

    public bool can_run(IContainRequestDetails the_request)
    {
      return request_specification(the_request);
    }
  }
}