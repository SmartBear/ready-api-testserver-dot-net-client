using System;
using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client
{
    public interface IExecutionListener
    {
        void RequestSent(ProjectResultReport projectResultReport);
        void ExecutionFinished(ProjectResultReport projectResultReport);
        void ErrorOccurred(Exception exception);
    }
}
