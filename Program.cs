var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

using (var context = new TodoContext())
{
    /*Console.WriteLine("--- Inserting 3 Todos ---");
    context.Add(new Todo { Task = "Réunion transpromo", Completed = false, Deadline = DateTime.Today });
    context.Add(new Todo { Task = "Faire la vaisselle", Completed = true });
    context.Add(new Todo { Task = "WEI", Completed = false, Deadline = DateTime.Parse("01-03-22") });

    context.SaveChanges();*/

}
