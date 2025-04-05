using Microsoft.AspNetCore.Identity;
using System.Reflection;

namespace BeautyLingerie.WebApi.Extention
{
    public static class WebExtention
    {
        public static void AddApplicationServices(this IServiceCollection services, Type serviceType)
        {
            Assembly? serviceAssembly = Assembly.GetAssembly(serviceType);
            if (serviceAssembly == null)
            {
                throw new InvalidOperationException("Invalid service type provided!");
            }

            Type[] implementationTypes = serviceAssembly
                .GetTypes()
                .Where(t => t.Name.EndsWith("Service") && !t.IsInterface)
                .ToArray();
            foreach (Type implementationType in implementationTypes)
            {
                Type? interfaceType = implementationType
                    .GetInterface($"I{implementationType.Name}");
                if (interfaceType == null)
                {
                    throw new InvalidOperationException(
                        $"No interface is provided for the service with name: {implementationType.Name}");
                }

                services.AddScoped(interfaceType, implementationType);
            }
        }
        public static IApplicationBuilder SeedAdministrator(this IApplicationBuilder app, string email)
        {
            using (IServiceScope scopedServices = app.ApplicationServices.CreateScope())
            {
                IServiceProvider serviceProvider = scopedServices.ServiceProvider;

                UserManager<IdentityUser> userManager =
                    serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
                RoleManager<IdentityRole> roleManager =
                    serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var configuration = serviceProvider.GetRequiredService<IConfiguration>();


                var task = Task.Run(async () =>
                {

                    if (!await roleManager.RoleExistsAsync("Administrator"))
                    {

                        IdentityRole role = new IdentityRole("Administrator");
                        await roleManager.CreateAsync(role);
                    }


                    IdentityUser adminUser = await userManager.FindByEmailAsync(email);
                    if (adminUser == null)
                    {
                        adminUser = new IdentityUser
                        {
                            UserName = email,
                            Email = email
                        };

                        var createResult = await userManager.CreateAsync(adminUser, configuration["Admin:Password"]);
                        if (!createResult.Succeeded)
                        {
                            throw new InvalidOperationException("Failed to create admin user.");
                        }


                        adminUser = await userManager.FindByEmailAsync(email);
                    }


                    if (!await userManager.IsInRoleAsync(adminUser, "Administrator"))
                    {
                        await userManager.AddToRoleAsync(adminUser, "Administrator");
                    }
                });
                task.GetAwaiter().GetResult();
            }

            return app;
        }

    }
}

