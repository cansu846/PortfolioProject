using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using PortfolioProject.SignalRHub;

namespace PortfolioProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
          
            services.AddControllersWithViews();
            services.AddScoped<IFeatureService, FeatureManager>();
            services.AddScoped<IFeatureDal,EfFeatureDal>();

            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IAboutDal, EfAboutDal>();

            services.AddScoped<IServiceService, ServiceManager>();
            services.AddScoped<IServiceDal, EfServiceDal>();

            services.AddScoped<ISkillService, SkillManager>();
            services.AddScoped<ISkillDal, EfSkillDal>();

            services.AddScoped<IPortfolioService, PortfolioManager>();
            services.AddScoped<IPortfolioDal, EfPortfolioDal>();

            services.AddScoped<IExperienceService, ExperienceManager>();
            services.AddScoped<IExperienceDal, EfExperienceDal>();

            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactDal, EfContactDal>();

            services.AddScoped<IMessageService, MessageManager>();
            services.AddScoped<IMessageDal, EfMessageDal>();

            services.AddScoped<IUserMessageService, UserMessageManager>();
            services.AddScoped<IUserMessageDal, EfUserMessageDal>();

            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();

            services.AddScoped<IWriterMessageService, WriterMessageManager>();
            services.AddScoped<IWriterMessageDal, EfWriterMessageDal>();

            services.AddScoped<IWriterUserService, WriterUserManager>();
            services.AddScoped<IWriterUserDal, EfWriterUserDal>();

            services.AddDbContext<Context>();

            services.AddIdentity<WriterUser, WriterRole>()
                    .AddEntityFrameworkStores<Context>();

            services.AddScoped<IPasswordHasher<WriterUser>, PasswordHasher<WriterUser>>();

            services.AddSignalR();

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                {
                    //builder.WithOrigins("https://localhost:44444", "https://localhost:55555").  //?stedi?imiz kadar client ekleyebiliyoruz.
                    builder.AllowAnyOrigin().
                    AllowAnyHeader().
                     AllowAnyMethod();
                     //AllowCredentials();
                });
            });
                //// Authentication ve Authorization i�in gerekli servisler ekleniyor
                //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                //        .AddCookie(options =>
                //        {
                //            options.Cookie.HttpOnly = true;
                //            options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                //            options.LoginPath = "/Auth/Login/"; // Giri? sayfas?
                //            options.AccessDeniedPath = "/ErrorPage/Index/"; // Yetki eksikli?i sayfas?
                //        });

                // MVC ekleniyor ve global yetkilendirme politikas? tan?mlan?yor
                services.AddControllersWithViews(config =>
            {
                // Varsay?lan yetkilendirme politikas?: Kimlik do?rulamas? gereksinimi
                var policy = new AuthorizationPolicyBuilder()
                               .RequireAuthenticatedUser()
                               .Build();

                // T�m Controller ve Action'lara yetkilendirme filtresi ekleniyor
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            //services.AddMvc(config =>
            //{
            //    var policy = new AuthorizationPolicyBuilder()
            //                   .RequireAuthenticatedUser()
            //                   .Build();
            //    config.Filters.Add(new AuthorizeFilter(policy));
            //});

            //services.AddMvc();

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(100);
                options.AccessDeniedPath = "/ErrorPage/Index/";
                options.LoginPath = "/Auth/Login/";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCors("CorsPolicy");  //Tan?mlad???m?z Policy'i kullan?yoruz.
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();

        
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<DashboardStatisticHub>("/DashboardStatisticHub");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
