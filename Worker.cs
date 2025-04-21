using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;
using System.Threading;

namespace RoundTheCode.WorkerServiceExample
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        //lo que agregao
        private string _path = Directory.GetCurrentDirectory() + @"\Files\";
        private IFileData _fileData;
        //creo contador

        private int _count = 0;
        public Worker(ILogger<Worker> logger, IFileData fileData)
        {
            _logger = logger;
            _fileData = fileData;
        }

//        Tengo una clase llamada Worker que hereda de la clase BackgroundService,
//        lo que significa que está diseñada para trabajar en segundo plano, sin interfaz gráfica,
//        sin ventanas, y sin molestar al usuario mientras realiza sus tareas.

//        Dentro de esta clase, tengo una variable privada llamada _logger de tipo ILogger<Worker>,
//        que sirve como servicio de registro (log) para guardar o mostrar
//        mensajes sobre lo que está haciendo la clase (como cuándo empieza, errores,
//        o información útil para depurar).

//        Luego está el constructor, que también se llama Worker(porque siempre se llama
//        igual que la clase).
//        Este constructor recibe como parámetro un ILogger<Worker>, y lo que hace
//        es guardar ese logger recibido dentro de la variable privada _logger,
//        para poder usarlo en otros métodos de la clase.
       
            
            protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            //esto se ejecuta hasta que no reciba una cancelación para q se detenta esto
            //sino q sigue ejecutando una y otra vez
            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                    await _fileData.Create($"{_path}{_count++}.txt");
                }
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
