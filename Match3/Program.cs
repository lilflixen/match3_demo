var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();    // разрешаем index.html как стартовую страницу
app.UseStaticFiles();     // разрешаем отдавать файлы из wwwroot

app.Run();