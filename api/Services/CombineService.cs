using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public interface ICombineService
    {
        public string getScoped();
        public string getTransient();
    }
    public class CombineService: ICombineService
    {
        private readonly ITransientService _transientService;
        private readonly IScopedService _scopedService;
        public CombineService(ITransientService transientService, IScopedService scopedService)
        {
            _transientService = transientService;
            _scopedService = scopedService;   
        }
        public string getScoped() {
            return _scopedService.getGuid();
        }
        public string getTransient() {
            return _transientService.getGuid();
        }
    }
}