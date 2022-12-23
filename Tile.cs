using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame
{
    public class Tile
    {
        int tilePosition;
        string tileColumn;
        int tileRow;
        string tileColumnRow;

        public Tile(int TilePosition, string TileColumn, int TileRow, string TileColumnRow)
        {
            tilePosition = TilePosition;
            tileColumn = TileColumn;
            tileRow = TileRow;
            tileColumnRow = TileColumnRow;
        }
    }
}
