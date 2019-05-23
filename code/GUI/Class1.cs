using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoard
{
    class Board
    {
        private int Order;
        private int Dimension;
        private Matrix_Graph() Gameboard;
        public Board(int order, int dimension)
        {
            Order = order;
            Dimension = dimension;
            Matrix_Graph(order ^ 2 * dimension ^ (order - 2));
        }

    }
}
