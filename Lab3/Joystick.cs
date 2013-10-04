using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SlimDX;
using SlimDX.DirectInput;

namespace Lab3
{
    class Joystick
    {
        private SlimDX.DirectInput.Joystick joystick;
        private JoystickState               joyState = new JoystickState();

        public bool JoystickIsConnected
        {
            get;
            protected set;
        }

        public Joystick()
        {
            var di = new DirectInput();

            // Get the first joystick.
            try
            {
                var device = di.GetDevices(DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly)[0];
                joystick = new SlimDX.DirectInput.Joystick(di, device.InstanceGuid);
            }
            catch 
            {
                JoystickIsConnected = false;
                return;
            }

        

            /*foreach (DeviceObjectInstance deviceObject in joystick.GetObjects())
            {
                if ((deviceObject.ObjectType & ObjectDeviceType.Axis) != 0)
                {
                    joystick.GetObjectPropertiesById((int)deviceObject.ObjectType).SetRange(-1000, 1000);
                }
            }*/

            joystick.Acquire();
        }

        public void Poll(Action<JoystickState> f)
        {
            if (!JoystickIsConnected)
                return;

            if (joystick.Acquire().IsFailure)
                return;

            if (joystick.Poll().IsFailure)
                return;

            joyState = joystick.GetCurrentState();
            if (Result.Last.IsFailure)
                return;

            
            // Joystick is all good, call the function.
            f(joyState);
        }
    }
}
