using RoundTheCode.WorkerServiceExample;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>()
    .AddSingleton<IFileData,FileData>();

var host = builder.Build();
host.Run();
