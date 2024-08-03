using Microsoft.EntityFrameworkCore;
using Amazon.S3;
using BeautyLingerie.Data;
using BeautyLingerie.WebApi.Extention;
using BeautyLingerie.Services.Product.Contacts;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Configure Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure Entity Framework and Identity
builder.Services.AddDbContext<BeautyLingerieDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddAuthorization();
builder.Services.AddIdentityApiEndpoints<IdentityUser>()
        .AddEntityFrameworkStores<BeautyLingerieDbContext>();

// Configure AWS Services
builder.Services.AddDefaultAWSOptions(builder.Configuration.GetAWSOptions("AWS"));
builder.Services.AddAWSService<IAmazonS3>();

// Configure Application Services
builder.Services.AddApplicationServices(typeof(IProductService));

// Configure CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost5175",
        policy =>
        {
            policy.WithOrigins("http://localhost:5176")
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowLocalhost5175");

app.UseAuthorization();

app.MapControllers();
app.MapIdentityApi<IdentityUser>();

app.Run();
