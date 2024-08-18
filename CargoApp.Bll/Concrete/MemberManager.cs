using CargoApp.Bll.Abstract;
using CargoApp.Dal.Abstract;
using CargoApp.Entities.Models;
using MongoDB.Bson;

namespace CargoApp.Bll.Concrete;

public class MemberManager : GenericManager<Member>,IMemberService
{
    public MemberManager(IGenericDal<Member> genericDal) : base(genericDal)
    {
    }
}