﻿using System;
using System.Runtime.InteropServices;

namespace Torque3D.Util
{
   [StructLayout(LayoutKind.Sequential)]
   internal struct InternalLinearColorFStruct
   {
      public float r;
      public float g;
      public float b;
      public float a;
   }

   public class LinearColorF
   {
      public float R { get; set; }
      public float G { get; set; }
      public float B { get; set; }
      public float A { get; set; }
      public static LinearColorF WHITE = new LinearColorF(1, 1, 1, 1);

      public LinearColorF(float r, float g, float b, float a)
      {
         R = r;
         G = g;
         B = b;
         A = a;
      }

      public LinearColorF(string s)
      {
         string[] split = s.Split(' ');
         if (split.Length != 4) throw new ArgumentException("LinearColorF always expect 4 parameters");
         R = float.Parse(split[0]);
         G = float.Parse(split[1]);
         B = float.Parse(split[2]);
         A = float.Parse(split[3]);
      }

      public LinearColorF(float[] vals)
      {
         if (vals.Length != 4) throw new ArgumentException("LinearColorF always expect 4 parameters");
         R = vals[0];
         G = vals[1];
         B = vals[2];
         A = vals[3];
      }

      internal LinearColorF(InternalLinearColorFStruct linearColorFStruct)
      {
         R = linearColorFStruct.r;
         G = linearColorFStruct.g;
         B = linearColorFStruct.b;
         A = linearColorFStruct.a;
      }

      public static LinearColorF operator +(LinearColorF p1, LinearColorF p2)
      {
         return new LinearColorF(p1.R + p2.R, p1.G + p2.G, p1.B + p2.B, p1.A + p2.A);
      }

      public float[] ToArray()
      {
         return new[] {R, G, B, A};
      }

      public override string ToString()
      {
         return $"{R} {G} {B} {A}";
      }

      internal InternalLinearColorFStruct ToStruct()
      {
         return new InternalLinearColorFStruct
         {
            r = R,
            g = G,
            b = B,
            a = A
         };
      }
   }
}
