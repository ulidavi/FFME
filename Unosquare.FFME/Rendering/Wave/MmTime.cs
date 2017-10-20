﻿namespace Unosquare.FFME.Rendering.Wave
{
#pragma warning disable SA1310 // Field names must not contain underscore

    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// http://msdn.microsoft.com/en-us/library/dd757347(v=VS.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    internal struct MmTime
    {
        public const int TIME_MS = 0x0001;
        public const int TIME_SAMPLES = 0x0002;
        public const int TIME_BYTES = 0x0004;

        [FieldOffset(0)]
        public uint Type;
        [FieldOffset(4)]
        public uint Ms;
        [FieldOffset(4)]
        public uint Sample;
        [FieldOffset(4)]
        public uint CB;
        [FieldOffset(4)]
        public uint Ticks;
        [FieldOffset(4)]
        public byte SmpteHour;
        [FieldOffset(5)]
        public byte SmpteMin;
        [FieldOffset(6)]
        public byte SmpteSec;
        [FieldOffset(7)]
        public byte SmpteFrame;
        [FieldOffset(8)]
        public byte SmpteFps;
        [FieldOffset(9)]
        public byte SmpteDummy;
        [FieldOffset(10)]
        public byte SmptePad0;
        [FieldOffset(11)]
        public byte SmptePad1;
        [FieldOffset(4)]
        public uint MidiSongPtrPos;
    }

#pragma warning restore SA1310 // Field names must not contain underscore
}
