using CargoApp.Dal.Abstract;
using CargoApp.Dal.Context;
using CargoApp.Dal.Repository;
using CargoApp.Entities.Models;

namespace CargoApp.Dal.EntityFramework;

public class EfMemberDal : GenericRepository<Member>,IMemberDal
{
    public EfMemberDal(CargoAppContext context) : base(context)
    {
    }
}