using Modules.ObjectPooler.Scripts.Runtime.Enums;
using Modules.ObjectPooler.Scripts.Runtime.Signals;
using Rich.Base.Runtime.Concrete.Injectable.Mediator;
using Runtime.Signals;
using Runtime.Views;
using UnityEngine;

namespace Runtime.Mediators
{
    public class PlayerMediator : MediatorLite
    {
        [Inject] public PlayerView view { get; set; }
        [Inject] public GameSignals GameSignals { get; set; }
        [Inject] public ObjectPoolingSignals ObjectPoolingSignals { get; set; }
        [Inject] public InputSignals InputSignals { get; set; }
        
        
    }
}