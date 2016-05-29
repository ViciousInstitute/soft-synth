using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synth2504

{
    static class Note
    {
        // octave 0
        public const double C0 = 16.35;
        public const double Csharp0 = 17.32;
        public const double Dflat0 = Csharp0;
        public const double D0 = 18.35;
        public const double Dsharp0 = 19.45;
        public const double Eflat0 = Dsharp0;
        public const double E0 = 20.60;
        public const double F0 = 21.83;
        public const double Fsharp0 = 23.12;
        public const double Gflat0 = Fsharp0;
        public const double G0 = 24.50;
        public const double Gsharp0 = 25.96;
        public const double Aflat0 = Gsharp0;
        public const double A0 = 27.50;
        public const double Asharp0 = 29.14;
        public const double Bflat0 = Asharp0;
        public const double B0 = 30.87;


        // octave 1
        public const double C1 = 32.70;
        public const double Csharp1 = 34.65;
        public const double Dflat1 = Csharp1;
        public const double D1 = 36.71;
        public const double Dsharp1 = 38.89;
        public const double Eflat1 = Dsharp1;
        public const double E1 = 41.20;
        public const double F1 = 43.65;
        public const double Fsharp1 = 46.25;
        public const double Gflat1 = Fsharp1;
        public const double G1 = 49.00;
        public const double Gsharp1 = 51.91;
        public const double Aflat1 = Gsharp1;
        public const double A1 = 55.00;
        public const double Asharp1 = 58.27;
        public const double Bflat1 = Asharp1;
        public const double B1 = 61.74;


        // octave 2
        public const double C2 = 65.41;
        public const double Csharp2 = 69.30;
        public const double Dflat2 = Csharp2;
        public const double D2 = 73.42;
        public const double Dsharp2 = 77.78;
        public const double Eflat2 = Dsharp2;
        public const double E2 = 82.41;
        public const double F2 = 87.31;
        public const double Fsharp2 = 92.50;
        public const double Gflat2 = Fsharp2;
        public const double G2 = 98.00;
        public const double Gsharp2 = 103.83;
        public const double Aflat2 = Gsharp2;
        public const double A2 = 110.00;
        public const double Asharp2 = 116.54;
        public const double Bflat2 = Asharp2;
        public const double B2 = 123.47;

        // octave 3
        public const double C3 = 130.81;
        public const double Csharp3 = 138.59;
        public const double Dflat3 = Csharp3;
        public const double D3 = 146.83;
        public const double Dsharp3 = 155.56;
        public const double Eflat3 = Dsharp3;
        public const double E3 = 164.81;
        public const double F3 = 174.61;
        public const double Fsharp3 = 185.00;
        public const double Gflat3 = Fsharp3;
        public const double G3 = 196.00;
        public const double Gsharp3 = 207.65;
        public const double Aflat3 = Gsharp3;
        public const double A3 = 220.00;
        public const double Asharp3 = 433.08;
        public const double Bflat3 = Asharp3;
        public const double B3 = 246.94;

        // octave 4
        public const double C4 = 261.63;
        public const double Csharp4 = 277.18;
        public const double Dflat4 = Csharp4;
        public const double D4 = 293.66;
        public const double Dsharp4 = 311.13;
        public const double Eflat4 = Dsharp4;
        public const double E4 = 329.63;
        public const double F4 = 349.23;
        public const double Fsharp4 = 369.99;
        public const double Gflat4 = Fsharp4;
        public const double G4 = 392.00;
        public const double Gsharp4 = 415.30;
        public const double Aflat4 = Gsharp4;
        public const double A4 = 440.00;
        public const double Asharp4 = 466.16;
        public const double Bflat4 = Asharp4;
        public const double B4 = 493.88;

        // octave 5
        public const double C5 = 523.25;
        public const double Csharp5 = 523.25;
        public const double Dflat5 = Csharp5;
        public const double D5 = 587.33;
        public const double Dsharp5 = 622.25;
        public const double Eflat5 = Dsharp5;
        public const double E5 = 659.25;
        public const double F5 = 698.46;
        public const double Fsharp5 = 739.99;
        public const double Gflat5 = Fsharp5;
        public const double G5 = 783.99;
        public const double Gsharp5 = 830.61;
        public const double Aflat5 = Gsharp5;
        public const double A5 = 880.00;
        public const double Asharp5 = 932.33;
        public const double Bflat5 = Asharp5;
        public const double B5 = 987.77;

        // octave 6
        public const double C6 = 1046.50;
        public const double Csharp6 = 108.73;
        public const double Dflat6 = Csharp6;
        public const double D6 = 1174.66;
        public const double Dsharp6 = 1244.51;
        public const double Eflat6 = Dsharp6;
        public const double E6 = 1318.51;
        public const double F6 = 1396.91;
        public const double Fsharp6 = 1479.98;
        public const double Gflat6 = Fsharp6;
        public const double G6 = 1567.98;
        public const double Gsharp6 = 1661.22;
        public const double Aflat6 = Gsharp6;
        public const double A6 = 1760.00;
        public const double Asharp6 = 1864.66;
        public const double Bflat6 = Asharp6;
        public const double B6 = 1975.53;

        // octave 7
        public const double C7 = 2093.00;
        public const double Csharp7 = 2217.46;
        public const double Dflat7 = Csharp7;
        public const double D7 = 2349.32;
        public const double Dsharp7 = 2489.02;
        public const double Eflat7 = Dsharp7;
        public const double E7 = 2637.02;
        public const double F7 = 2793.83;
        public const double Fsharp7 = 2959.96;
        public const double Gflat7 = Fsharp7;
        public const double G7 = 3135.96;
        public const double Gsharp7 = 3322.44;
        public const double Aflat7 = Gsharp7;
        public const double A7 = 3520.00;
        public const double Asharp7 = 3729.31;
        public const double Bflat7 = Asharp7;
        public const double B7 = 3951.07;

        // octave 8
        public const double C8 = 4186.01;
        public const double Csharp8 = 4434.92;
        public const double Dflat8 = Csharp8;
        public const double D8 = 4698.63;
        public const double Dsharp8 = 4978.03;
        public const double Eflat8 = Dsharp8;
        public const double E8 = 5274.04;
        public const double F8 = 5587.65;
        public const double Fsharp8 = 5919.91;
        public const double Gflat8 = Fsharp8;
        public const double G8 = 6271.93;
        public const double Gsharp8 = 6644.88;
        public const double Aflat8 = Gsharp8;
        public const double A8 = 7040.00;
        public const double Asharp8 = 7458.62;
        public const double Bflat8 = Asharp8;
        public const double B8 = 7902.13;

        // octave 9
        public const double C9 = 8372.02;
    }
}
