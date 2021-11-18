using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartClientApp.Model
{
    public interface IItem
    {
        string ItemName();
        double ItemPrice();
    }
}
