using Runtime.Key;
using Runtime.Model;
using Runtime.Signals;
using strange.extensions.command.impl;

namespace Runtime.Controller
{
    public class OnGetPlayerDataCommand : Command
    {

        [Inject] public GameSignals GameSignals { get; set; }

        public LevelStartPlayerDataHolderParams LevelStartPlayerDataHolderParams { get; set; }


        public override void Execute()
        {
            Retain();
            GameSignals.onPlayerDataInitialize.Dispatch(LevelStartPlayerDataHolderParams);
            Release();
        }
        
    }
}