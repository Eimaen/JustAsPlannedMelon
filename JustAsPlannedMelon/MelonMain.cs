using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustAsPlannedMelon
{
    public class MelonMain : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("Congratulations! You haven't paid for pixel Reimu.");
        }
    }
}
