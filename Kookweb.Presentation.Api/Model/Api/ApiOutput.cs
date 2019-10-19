namespace Kookweb.Presentation.Api.Model.Api
{
    public class ApiOutput<T> where T : class
    {
        public ApiOutput()
        {
            this.status = false;
            this.message = string.Empty;
            this.result = default(T);
        }

        public ApiOutput(bool status, string message)
        {
            this.status = status;
            this.message = message;
            this.result = default(T);
        }

        public bool status { get; set; }
        public string message { get; set; }
        public T result { get; set; }
    }
}