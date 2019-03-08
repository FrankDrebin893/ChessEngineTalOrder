using System;
using System.Collections.Generic;

namespace TalOrder.Domain.Entities.Board
{
    public class Board : IBoard
    {
        private readonly Position _position;

        public Board(Position startPosition) {
            _position = startPosition;
        }

        public void MakeMove(Move move)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Move> GetLegalMoves()
        {
            throw new NotImplementedException();
        }
    }
}
