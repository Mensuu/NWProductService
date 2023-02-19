namespace NWProductService
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Scaffold - DbContext "Server=.\SQLExpress;Database=Nortwind;Trusted_Connection=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer - OutputDir Models
            //Scaffold - DbContext "Server=.\SQLExpress;Database=Nortwind;User Id=sa; Passwod=Fbu2016-;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer - OutputDir Models

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}