using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAppInterfaceBackend.Services
{
    public interface IService<T>
    {
        List<T> GetAllItems();
        T GetItem(string id);
        bool AddItem(T item);
        bool EditItem(string id,T item);
        bool DeleteItem(string id);
    }
}
