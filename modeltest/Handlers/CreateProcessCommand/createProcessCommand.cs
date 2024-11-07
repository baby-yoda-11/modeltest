using MediatR;

namespace modeltest.Handlers.CreateProcessCommand
{
    public class createProcessCommand:IRequest
    {
        public dynamic json;

        public createProcessCommand(dynamic json)
        {
            this.json=json;
        }
    }
    
}
