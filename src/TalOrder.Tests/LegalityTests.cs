using System;
using System.Linq;
using TalOrder.Domain.Entities;
using TalOrder.Domain.Entities.Board;
using Xunit;

namespace TalOrder.Tests
{
    public class LegalityTests
    {
        [Fact]
        public void TestMove()
        {
            var board = new Board(new Position());

            var moves = board.GetLegalMoves().ToList();

        }
    }
}
