

namespace api.Services
{
    public interface ISingletonService
    {
        public string getGuid();
    }
    public class SingletonService: ISingletonService
    {
        private readonly Guid guid;
        public SingletonService()
        {
            guid = Guid.NewGuid();
        }
        public string getGuid() {
            return this.guid.ToString();
        }

    }
}