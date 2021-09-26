namespace Mediator.Models
{
    public class Response
    {
        public Response(bool status)
        {
            Status = status;
        }

        public bool Status { get; set;}
    }
}
