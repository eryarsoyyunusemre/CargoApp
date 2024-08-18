using CargoApp.Dal.Abstract;
using CargoApp.Dal.Context;
using CargoApp.Dal.Repository;
using CargoApp.Entities.Models;

namespace CargoApp.Dal.EntityFramework;

public class EfShippingDal : GenericRepository<Shipping>,IShippingDal
{
    public EfShippingDal(CargoAppContext context) : base(context)
    {
        
    }
}