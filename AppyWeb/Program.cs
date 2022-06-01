var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();






//All the Dependencies are registered before this line.

var app = builder.Build();

//Request Pipeline Or Middleware configurations are done after this line

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();
