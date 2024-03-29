﻿
using strange.extensions.signal.impl;
using UnityEngine;

namespace Runtime.Signals
{
    public class GameSignals : Signal
    {
        //Game Behaviour
        public Signal onGameInitialize = new Signal();
        public Signal onLevelInitialize = new Signal();
        public Signal onLevelStart = new Signal();

        
        public Signal<GameObject> onSetCinemachineTarget = new Signal<GameObject>();

        public Signal<int> onBulletFired = new Signal<int>();
    }
}