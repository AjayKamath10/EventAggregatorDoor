﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Sent from SmartDoor -> Timer
namespace EventAggregatorDoor
{
    public class DoorEventArgs : EventArgs
    {
        public SmartDoor door { get; }

        public DoorEventArgs(SmartDoor door)
        {
            this.door = door;
        }
    }

}
