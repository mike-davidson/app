using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app.web
{
    public class NotFoundRequest : IRunOneRequest
    {
        public void process(IContainRequestDetails the_request)
        {
            throw new NotImplementedException();
        }

        public bool can_run(IContainRequestDetails the_request)
        {
            return false;
        }
    }
}
