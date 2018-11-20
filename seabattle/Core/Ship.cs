using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Enums;

namespace Core
{
    class Ship
    {
        public int Size
        {
            get; protected set;
        }
        public ShipState State
        {
            get; protected set;
        }

        private int Injuries = 0;

        public Ship(int size)
        {
            this.Size = size;
            this.State = ShipState.Unbroken;
        }

        public void Injure()
        {
            if (State == ShipState.Broken) return;
            this.Injuries++;
            if (Injuries < Size) this.State = ShipState.Injured;
            else this.State = ShipState.Broken;
        }

    }
}
