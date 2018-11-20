using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Enums;

namespace Core
{


    public class Cell
    {
        public CellState State
        {
            get; protected set;
        }

        public Cell()
        {
            this.State = CellState.Closed;
        }
    }
}
