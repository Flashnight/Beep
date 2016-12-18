using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Beep
{
    public static class Sound
    {
        private static Thread _beepThread;

        private static bool _lockStart = false;

        private class SoundParams
        {
            public int Frequency { get; set; }
            public int Duration { get; set; }
        }

        public static void StartSound(int frequency, int duration = int.MaxValue)
        {
            if (_lockStart == true)
                StopSound();

            _beepThread = new Thread(new ParameterizedThreadStart(Sounding));
            _beepThread.IsBackground = true;
            _beepThread.Start(new SoundParams { Frequency = frequency, Duration = duration });
            _lockStart = false;
        }

        private static void Sounding(object parameters)
        {
            var p = parameters as SoundParams;

            while (true)
            {
                Console.Beep(p.Frequency, p.Duration);
            }
        }

        public static void StopSound()
        {
            Console.Beep(32767, 1);
            _lockStart = true;
        }
    }
}
