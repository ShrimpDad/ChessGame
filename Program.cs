﻿using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessGame.Greet();

            ChessGame.LoadResource();

            ChessGame.RunGame();
        }
    }
}