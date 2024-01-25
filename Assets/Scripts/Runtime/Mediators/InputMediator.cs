using Rich.Base.Runtime.Concrete.Injectable.Mediator;
using Runtime.Signals;
using Runtime.Views;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Runtime.Mediators
{
    public class InputMediator : MediatorLite
    {
        #region Injections

        [Inject] [ShowInInspector] public InputView view { get; set; }

        [Inject] public InputSignals InputSignals { get; set; }
        [Inject] public GameSignals GameSignals { get; set; }

        #endregion
        
    }
}