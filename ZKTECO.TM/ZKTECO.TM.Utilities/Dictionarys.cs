using System;
using System.Collections.Generic;

namespace ZKTECO.TM.Utilities
{
    public static class Dictionarys
    {
        public static readonly Dictionary<int, string> ATT_STATUS = new Dictionary<int, string>
        {
            {0, "Check-In" },// work attendance
            {1, "CheckOut"}, // sign-off from work
            {2, "BreakOut"}, // out
            {3, "Break-In"}, // out return
            {4, "OT-IN"}, // overtime attendance
            {5, "OT-OUT"}, // overtime sign-off
            {255, "255"},
        };
        public static readonly Dictionary<int, string> ATT_VERIFY = new Dictionary<int, string>
        {
            {0, "FP/PW/RF"},
            {1, "FP"},
            {2, "PIN"},
            {3, "PW"},
            {4, "RF"},
            {5, "FP/PW"},
            {6, "FP/RF"},
            {7, "PW/RF"},
            {8, "PIN&FP"},
            {9, "FP&PW"},
            {10, "FP&RF"},
            {11, "PW&RF"},
            {12, "FP&PW&RF"},
            {13, "PIN&FP&PW"},
            {14, "FP&RF/PIN"},
            {15, "FACE"},
            {101, "SLAVE DEVICE"},
        };
    }
}
