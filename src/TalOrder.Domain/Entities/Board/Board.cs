using System;
using System.Collections.Generic;

namespace TalOrder.Domain.Entities.Board
{
    public abstract class Board : IBoard
    {
        public void MakeMove(Move move)
        {
            throw new NotImplementedException();
        }

        protected IEnumerable<Move> GetLegalMoves()
        {
            throw new NotImplementedException();
        }

        protected 
    }
}
