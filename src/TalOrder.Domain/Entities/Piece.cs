namespace TalOrder.Domain.Entities
{
    public class Piece
    {
        public Color Color { get; set; }
        public PieceType PieceType { get; set; }

        public Piece(Color col, PieceType pType)
        {
            Color = col;
            PieceType = pType;
        }
    }
}
