using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserService
    {
        //void Add(User user);
        //void Delete(User user);
        //void Update(User user);
        //List<User> GetAll();
        //User GetById(int id);
        //List<OperationClaim> GetClaims(User user);
        //User GetByMail(string email);

        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int id);
        List<OperationClaim> GetClaims(User user);
        IDataResult<User> GetByMail(string email);
    }
}
