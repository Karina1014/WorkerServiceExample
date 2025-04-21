using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundTheCode.WorkerServiceExample
{
    public class FileData : IFileData
    {
        public async Task Create(string path)
        {
            using (var sw = new StreamWriter(path))
            {
                await Task.Delay(1000);
                await sw.WriteAsync("Karina Simbaña Repasando");
            }
        }
    }
}
