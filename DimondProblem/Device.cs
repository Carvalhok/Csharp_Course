namespace DimondProblem
{
    abstract class Device
    {
        public string Message { get; set; }

        protected Device(string message)
        {
            Message = message;
        }

        abstract public void ProcessDoc();
    }
}
