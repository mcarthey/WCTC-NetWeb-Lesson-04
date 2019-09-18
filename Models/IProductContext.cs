using System.Collections.Generic;

namespace MVCWebApplication.Models
{
    public interface IContext<T>
    {
        List<T> GetAll();
        T GetById(int id);
    }
}