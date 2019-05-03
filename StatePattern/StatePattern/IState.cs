using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public interface IState
    {
        string Note { get; }
        void Call(Phone phone);
        void PickUp(Phone phone);
        void EndCall(Phone phone);
        void TopUpAccount(Phone phone, double money);

    }
}
