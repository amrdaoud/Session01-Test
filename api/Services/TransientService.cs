namespace api.Services
{
    public interface ITransientService
    {
        public string getGuid();
    }
    public class TransientService: ITransientService
    {
        private readonly Guid guid;
        public TransientService()
        {
            guid = Guid.NewGuid();
        }
        public string getGuid() {
            return this.guid.ToString();
        }

    }
}