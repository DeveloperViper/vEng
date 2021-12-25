using CitizenFX.Core;
using static CitizenFX.Core.Native.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG
{
    public class client : BaseScript
    {
        [Command("eng")]
        public void EngCommand(int source, List<object> args, string raw)
        {
            TriggerEvent("chat:addMessage", new
            {
                color = new[] { 0, 255, 0 },
                multiline = true,
                args = new[] { "Your Engine Has Now Been Toggled On/Off" }
            });

            var ped = PlayerPedId();
            var vehicle = GetVehiclePedIsIn(ped, false);
            SetVehicleEngineOn(vehicle, false, true, true);
            var IsEngineRunning = GetIsVehicleEngineRunning(vehicle);
            if (IsEngineRunning)
            {
                SetVehicleEngineOn(vehicle, true, true, true);



            }
            else SetVehicleEngineOn(vehicle, false, true, false);
        }
    }
}
