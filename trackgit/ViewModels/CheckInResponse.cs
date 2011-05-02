namespace trackgit.ViewModels
{
    public class CheckInResponse
    {
        public CheckInResponse(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }
    }
}