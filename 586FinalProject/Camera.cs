using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class Camera : Device
    {
        private Boolean recording;

        public Camera()
        {
            recording = false;
        }

        public void Toggle() => recording = !recording;
        public Boolean IsRecording() => recording;
    }
}
