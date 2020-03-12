using System;
using System.Collections.Generic;
using System.Text;

namespace TalOrder.Domain.Entities {
    public class Position {
        public Square[, ] Squares { get; set; }

        public Position () {
            Squares = InitializeStartPosition ();
        }

        private static Square[, ] InitializeStartPosition () {
            var squares = new Square[8, 8];
            squares[0, 0] = new Square (new Piece (Color.Black, PieceType.Rook));
            squares[0, 1] = new Square (new Piece (Color.Black, PieceType.Knight));
            squares[0, 2] = new Square (new Piece (Color.Black, PieceType.Bishop));
            squares[0, 3] = new Square (new Piece (Color.Black, PieceType.Queen));
            squares[0, 4] = new Square (new Piece (Color.Black, PieceType.King));
            squares[0, 5] = new Square (new Piece (Color.Black, PieceType.Bishop));
            squares[0, 6] = new Square (new Piece (Color.Black, PieceType.Knight));
            squares[0, 7] = new Square (new Piece (Color.Black, PieceType.Rook));

            squares[1, 0] = new Square (new Piece (Color.Black, PieceType.Pawn));
            squares[1, 1] = new Square (new Piece (Color.Black, PieceType.Pawn));
            squares[1, 2] = new Square (new Piece (Color.Black, PieceType.Pawn));
            squares[1, 3] = new Square (new Piece (Color.Black, PieceType.Pawn));
            squares[1, 4] = new Square (new Piece (Color.Black, PieceType.Pawn));
            squares[1, 5] = new Square (new Piece (Color.Black, PieceType.Pawn));
            squares[1, 6] = new Square (new Piece (Color.Black, PieceType.Pawn));
            squares[1, 7] = new Square (new Piece (Color.Black, PieceType.Pawn));

            squares[7, 0] = new Square (new Piece (Color.White, PieceType.Rook));
            squares[7, 1] = new Square (new Piece (Color.White, PieceType.Knight));
            squares[7, 2] = new Square (new Piece (Color.White, PieceType.Bishop));
            squares[7, 3] = new Square (new Piece (Color.White, PieceType.Queen));
            squares[7, 4] = new Square (new Piece (Color.White, PieceType.King));
            squares[7, 5] = new Square (new Piece (Color.White, PieceType.Bishop));
            squares[7, 6] = new Square (new Piece (Color.White, PieceType.Knight));
            squares[7, 7] = new Square (new Piece (Color.White, PieceType.Rook));

            squares[6, 0] = new Square (new Piece (Color.White, PieceType.Pawn));
            squares[6, 1] = new Square (new Piece (Color.White, PieceType.Pawn));
            squares[6, 2] = new Square (new Piece (Color.White, PieceType.Pawn));
            squares[6, 3] = new Square (new Piece (Color.White, PieceType.Pawn));
            squares[6, 4] = new Square (new Piece (Color.White, PieceType.Pawn));
            squares[6, 5] = new Square (new Piece (Color.White, PieceType.Pawn));
            squares[6, 6] = new Square (new Piece (Color.White, PieceType.Pawn));
            squares[6, 7] = new Square (new Piece (Color.White, PieceType.Pawn));

            return squares;
        }

        public IEnumerable<Move> GetLegalMoves () {
            for (var i = 0; i <= Squares.Length; i++) {
                for (var j = 0; j <= Squares.Length; j++) {
                    return new List<Move> ();
                }
            }

            return null;
        }
    }
}