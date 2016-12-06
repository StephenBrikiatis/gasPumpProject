/*Author: John Houk Stephen Brikiatis
Class:  CSI-340-01
Assignment: Semester project
Date Assigned: 09/16/16
Due Date: 12/05/16

Description: This is the abstract class for the various pump states.

Certification of Authenticity:
We certify that this assignment is entirely our own work.
*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasPumpProject
{
    abstract class PumpState
    {

        public abstract void usePump();
        public abstract float usePump(int a, int b, float c);
    }
}
