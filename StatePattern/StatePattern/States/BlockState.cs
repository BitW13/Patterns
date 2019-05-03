using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    public class BlockState : IState
    {
        public string Note { get; }

        public BlockState()
        {
            Note = "Block";
        }

        public void Call(Phone phone)
        {
            throw new Exception(string.Format("Phone {0} is blocked!", phone.Number));
        }

        public void EndCall(Phone phone)
        {
            throw new NotImplementedException(string.Format("Phone {0} is blocked!", phone.Number));
        }

        public void PickUp(Phone phone)
        {
            phone.State = new TalkingState();
        }

        public void TopUpAccount(Phone phone, double money)
        {
            phone.Account += money;
            if(phone.Account >= 0)
            {
                phone.State = new WaitingState();
            }
        }
    }
}
