namespace app.web
{
  public interface IRunOneRequest 
  {
    void process(IContainRequestDetails the_request);
    bool can_run(IContainRequestDetails the_request);
  }
}