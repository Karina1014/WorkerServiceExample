using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundTheCode.WorkerServiceExample
{
    public interface IFileData
    {
        public Task Create(String Path);
    }
}
