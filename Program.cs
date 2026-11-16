var builder = WebApplication.CreateBuilder(args);

// Serve wwwroot assets when running outside the published output (e.g. dotnet run, Production env).
builder.WebHost.UseStaticWebAssets();

// Windows EventLog blocked on this machine (access denied) — log to console only.
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<PortfolioV2._0.Services.IPortfolioData, PortfolioV2._0.Services.PortfolioData>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
