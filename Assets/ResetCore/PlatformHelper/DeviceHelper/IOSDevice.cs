﻿using UnityEngine;
using System.Collections;
using System;

namespace ResetCore.PlatformHelper
{
    public class IOSDevice : Device
    {

        public override void SendMessage(string eventName, string json)
        {
            throw new NotImplementedException();
        }

    }

}
