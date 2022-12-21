using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame
{
    public class Piece
    {
        string pieceName;
        string pieceColour;
        int piecePosition;
        string pieceColumn;
        int pieceRow;
        bool pieceInPlay;

        public Piece(string PieceName, string PieceColour, int PiecePosition, string PieceColumn, int PieceRow, bool PieceInPlay)
        {
            pieceName = PieceName;
            pieceColour = PieceColour;
            piecePosition = PiecePosition;
            pieceColumn = PieceColumn;
            pieceRow = PieceRow;
            pieceInPlay = PieceInPlay;
        }
    }
}
