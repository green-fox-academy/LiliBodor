using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoWeb.Repositories
{
    public interface ITodoRepository<Type>
    {
        void Creat(Type element);
        List<Type> GetAllElements();
        void Update(Type element);
        void Delete(Type element);
    }
}
