using System;
using System.Collections.Generic;
using System.Text;

namespace TalOrder.Domain.Entities
{
    public class Move
    {
        public Square From { get; set; }
        public Square To { get; set; }
        public MoveType MoveType { get; set; }
    }

    public enum MoveType {
        Normal,
        EnPassent,
        Promotion
    }
}
