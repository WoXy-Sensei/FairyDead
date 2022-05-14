using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Proje1.Inputs
{
    public class ComputerInputs
    {
        public bool JumpClickDown => Input.GetKeyDown(KeyCode.F);
        public bool FireClickDown => Input.GetKeyDown(KeyCode.J);
        public bool DashClickDown => Input.GetKeyDown(KeyCode.G);
        public bool BackDashClickDown => Input.GetKeyDown(KeyCode.H);


    }

}


