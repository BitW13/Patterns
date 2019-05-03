using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    public class WaitingState : IState
    {
        public string Note { get; }

        public WaitingState()
        {
            Note = "Waiting";
        }
        public void Call(Phone phone)
        {
            phone.State = new CallingState();
        }

        public void EndCall(Phone phone)
        {
            throw new Exception(string.Format("Phone {0} is already waiting!", phone.Number));
        }

        public void PickUp(Phone phone)
        {
            phone.State = new TalkingState();
        }

        public void TopUpAccount(Phone phone, double money)
        {
            phone.Account += money;
        }
    }
}
