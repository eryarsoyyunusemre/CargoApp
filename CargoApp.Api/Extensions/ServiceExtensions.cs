using CargoApp.Bll.Abstract;
using CargoApp.Bll.Concrete;
using CargoApp.Dal.Abstract;
using CargoApp.Dal.EntityFramework;
using CargoApp.Dal.Repository;

namespace CargoApp.Api.Extensions;

public static class ServiceExtensions
{
    
    // this olmazsa program.cs de gözükmez.
    public static void AddServiceExtension(this IServiceCollection services)
    {
            services.AddScoped<IMemberDal, EfMemberDal>();
            services.AddScoped<IMemberService, MemberManager>();
 

            services.AddScoped<IShippingDal, EfShippingDal>();
            services.AddScoped<IShippingService, ShippingManager>();


            services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
    }
    
}