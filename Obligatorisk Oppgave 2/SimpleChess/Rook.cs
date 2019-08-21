﻿namespace SimpleChess
{
    public class Rook : Piece
    {
        public Rook(string symbol) : base(symbol)
        {
        }

        public override bool Move(string fromPosition, string toPosition)
        {
            return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
        }
    }
}