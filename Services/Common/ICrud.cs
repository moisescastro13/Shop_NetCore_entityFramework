using System.Collections.Generic;
using System.Security.Principal;

namespace Services.Common
{
    public interface ICrudTemplate<T,U>
        where T : class
        where U : class
    {
        public T Create(U body);
        public T FindOne(int id);
        public List<T> Find();
        public T Update(int id, U body);
        public void Delete(int id);
    }
}