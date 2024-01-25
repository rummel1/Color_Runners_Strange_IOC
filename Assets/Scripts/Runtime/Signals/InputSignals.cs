using strange.extensions.signal.impl;

namespace Runtime.Signals
{
    public class InputSignals : Signal
    {
        public Signal onEnableTouch = new Signal();
        public Signal onDisableTouch = new Signal();
    }
}