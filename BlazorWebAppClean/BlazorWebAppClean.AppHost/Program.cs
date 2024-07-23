var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.DeafultWebApp>("deafultwebapp");

builder.Build().Run();
