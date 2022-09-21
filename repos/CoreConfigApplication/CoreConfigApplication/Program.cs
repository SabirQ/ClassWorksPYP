using CoreConfigApplication;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var mail=app.Configuration[SettingCodeAcademy.ConfigName+":Email"];

var fullname = app.Configuration[SettingCodeAcademy.ConfigName + ":"];

app.MapGet("/", () => "Hello World!");

app.Run();
