using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using NoteList.Data;
using NoteList.Services;

namespace NoteList
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddDbContext<AppDbContext>(options =>
               options.UseSqlServer(@"Data Source=DESKTOP-G786A4S\SQLEXPRESS;
                                      Initial Catalog=bloc;
                                      Integrated Security=True;
                                      Encrypt=False;
                                      TrustServerCertificate=True"));

            builder.Services.AddScoped<NotesService>();
            //builder.Services.AddScoped<PhotosService>();




            return builder.Build();
        }
    }
}
