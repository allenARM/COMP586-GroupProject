using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class CameraToggleCommand : ICommand
    {
        private Camera camera;

        public CameraToggleCommand(Camera camera)
        {
            this.camera = camera;
        }

        public void Execute()
        {
            camera.Toggle();
        }
    }
}
