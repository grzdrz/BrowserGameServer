﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;

namespace BrowserGameServer.GameSession
{
    public enum PlayerStates
    {
        WaitBegining,
        ActiveLeading,
        ActiveWaiting,
        EndMove,
        Winner,
        Loser,
        Disconnected
    }

    public enum Side
    {
        Black,
        White
    }

    public class Player
    {
        public string PlayerLogin;
        public string PlayerAddress;
        public LinkedList<WebSocketHandler> PlayerHandlers = new LinkedList<WebSocketHandler>();

        public PlayerStates PlayerStates = PlayerStates.WaitBegining;
        public Side Side;

        public string ChessPositions;
    }
}