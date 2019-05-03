using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    public class TalkingState : IState
    {
        public string Note { get; }

        public TalkingState()
        {
            Note = "Talking";
        }

        public void Call(Phone phone)
        {
            throw new Exception(string.Format("Phone {0} is used!", phone.Number));
        }

        public void EndCall(Phone phone)
        {
            phone.State = new WaitingState();
        }

        public void PickUp(Phone phone)
        {
            throw new Exception(string.Format("Phone {0} is used!", phone.Number));
        }

        public void TopUpAccount(Phone phone, double money)
        {
            throw new Exception(string.Format("Phone {0} is used!", phone.Number));
        }
    }
}
