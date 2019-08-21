using System;
using System.Runtime.InteropServices.ComTypes;

namespace SimpleChess
{
    public class Bishop : Piece
    {
        public Bishop(string symbol = "LPR") : base(symbol)
        {
        }
        public override bool Move(string fromPosition, string toPosition)
        {
            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];
            return Math.Abs(diffRow) == Math.Abs(diffCol);
        }
    }
}