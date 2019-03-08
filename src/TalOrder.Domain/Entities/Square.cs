using System;
using System.Collections.Generic;
using System.Text;

namespace TalOrder.Domain.Entities
{
    public class Square
    {
        public Piece Piece { get; set; }

        public Square(Piece piece)
        {
            Piece = piece;
        }
    }
}
