

namespace api.Services
{
    public interface IScopedService
    {
        public string getGuid();
    }
    public class ScopedService: IScopedService
    {
        private readonly Guid guid;
        public ScopedService()
        {
            guid = Guid.NewGuid();
        }
        public string getGuid() {
            return this.guid.ToString();
        }

    }
}