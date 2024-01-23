﻿using Modules.ObjectPooler.Scripts.Runtime.Key;
using Modules.ObjectPooler.Scripts.Runtime.Signals;
using Rich.Base.Runtime.Concrete.Injectable.Mediator;
using Runtime.Key;
using Runtime.Signals;
using Runtime.Views;
using UnityEngine;

namespace Runtime.Mediators
{
    public class BulletMediator : MediatorLite
    {
        [Inject] public BulletView view { get; set; }
        [Inject] public GameSignals GameSignals { get; set; }
        [Inject] public ObjectPoolingSignals ObjectPoolingSignals { get; set; }

        public override void OnRegister()
        {
            base.OnRegister();
            view.onEnqueueBullet += OnEnqueueBullet;
        }

        public override void OnRemove()
        {
            base.OnRemove();
            view.onEnqueueBullet -= OnEnqueueBullet;
        }

        private void OnEnqueueBullet(OnEnqueuePooledObjectParams onEnqueuePooledObjectParams)
        {
            ObjectPoolingSignals.onEnqueuePooledObject.Dispatch(onEnqueuePooledObjectParams);
        }
    }
}