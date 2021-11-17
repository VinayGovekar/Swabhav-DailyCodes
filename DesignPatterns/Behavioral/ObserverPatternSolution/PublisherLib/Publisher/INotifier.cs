using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherLib.Publisher
{
    public interface INotifier
    {
        void Notify(Account account);
    }
}
