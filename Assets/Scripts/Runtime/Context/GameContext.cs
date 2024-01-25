using Modules.Core.Abstract.Model;
using Modules.Core.Concrete.Model;
using Rich.Base.Runtime.Concrete.Context;
using Rich.Base.Runtime.Extensions;
using Runtime.Mediators;
using Runtime.Model;
using Runtime.Signals;
using Runtime.Views;
using UnityEngine;

namespace Runtime.Context
{
    public class GameContext : RichMVCContext
    {
        private GameSignals _gameSignals;
        private InputSignals _inputSignals;
        private CameraSignals _cameraSignals;
        private PlayerSignals _playerSignals;

        protected override void mapBindings()
        {
            base.mapBindings();

            
            _gameSignals = injectionBinder.BindCrossContextSingletonSafely<GameSignals>();
            _inputSignals = injectionBinder.BindCrossContextSingletonSafely<InputSignals>();
            _cameraSignals = injectionBinder.BindCrossContextSingletonSafely<CameraSignals>();
            _playerSignals = injectionBinder.BindCrossContextSingletonSafely<PlayerSignals>();


            //Injection Bindings
            injectionBinder.Bind<IGameModel>().To<GameModel>().CrossContext().ToSingleton();
            


            //Mediation Bindings
            mediationBinder.BindView<PlayerView>().ToMediator<PlayerMediator>();
            mediationBinder.BindView<InputView>().ToMediator<InputMediator>();
            mediationBinder.BindView<CameraView>().ToMediator<CameraMediator>();

            
  
        }

        public override void Launch()
        {
            base.Launch();
            Application.targetFrameRate = 60;
            _gameSignals.onGameInitialize.Dispatch();
        }
    }
}