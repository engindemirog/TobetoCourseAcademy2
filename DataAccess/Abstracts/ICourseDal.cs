using Core.DataAccess;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface ICourseDal : IEntityRepository<Course, int>
{

}
