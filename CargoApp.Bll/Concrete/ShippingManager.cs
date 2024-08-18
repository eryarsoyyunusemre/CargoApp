using CargoApp.Bll.Abstract;
using CargoApp.Dal.Abstract;
using CargoApp.Entities.Models;
using MongoDB.Bson;

namespace CargoApp.Bll.Concrete;

public class ShippingManager : GenericManager<Shipping>,IShippingService
{
    public ShippingManager(IGenericDal<Shipping> genericDal) : base(genericDal)
    {
    }
}