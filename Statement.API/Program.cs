using Microsoft.EntityFrameworkCore;
using NLog;
using NLog.Web;
using Statements.Application.Statements.Create;
using Statements.Persistance.Context;

var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
logger.Debug("API started");

try
{
    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.AddDbContext<StatementContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
    builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<CreateStatementCommandHandler>());
    builder.Services.AddAutoMapper(typeof(CreateStatementCommandHandler).Assembly);

    builder.Logging.ClearProviders();
    builder.Host.UseNLog();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    using var scope = app.Services.CreateScope();
    var context = scope.ServiceProvider.GetRequiredService<StatementContext>();
    context.Database.Migrate();

    app.Run();
}
catch(Exception ex)
{
    logger.Error(ex);
}
finally
{
    LogManager.Shutdown();
}