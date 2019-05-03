using StatePattern.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Phone
    {
        public string Number { get; set; }
        public double Account { get; set; }
        public double CallProbability { get; set; }
        public IState State { get; set; }

        public double CALL_PRICE = 0.25;

        Random rnd;

        public Phone(string number, double account, double probability)
        {
            Number = number;
            Account = account;
            CallProbability = probability;

            rnd = new Random();
        }
        public void TopUpAccount(double money)
        {
            State.TopUpAccount(this, money);
        }

        public void PickUp()
        {
            if(rnd.NextDouble() >= CallProbability)
            {
                State.PickUp(this);
            }
        }

        public void Call()
        {
            State.Call(this);

            Account -= CALL_PRICE;

            if (Account < 0)
            {
                State = new BlockState();
                throw new Exception(string.Format("Phone {0} is blocked!", Number));
            }
        }

        public void EndCall()
        {
            State.EndCall(this);
        }
    }
}
