﻿using System;

namespace Tennis.Implementation1
{
    public class Player
    {
        private readonly string _name;

        public Player(string player1Name)
        {
            this._name = player1Name;
        }

        public bool IsCalled(string playerName)
        {
            return _name == playerName;
        }
    }
}