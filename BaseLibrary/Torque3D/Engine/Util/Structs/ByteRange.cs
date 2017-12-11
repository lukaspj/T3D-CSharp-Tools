using System;
using System.Runtime.InteropServices;

namespace Torque3D.Util
{
   [StructLayout(LayoutKind.Sequential)]
   internal struct InternalByteRangeStruct
   {
      public byte low;
      public byte high;
   }

   public class ByteRange
   {
      public byte Low { get; set; }
      public byte High { get; set; }
      
      public ByteRange(byte low, byte high)
      {
         Low = low;
         High = high;
      }

      public ByteRange(string data)
      {
         string[] split = data.Split(' ');
         if (split.Length != 2) throw new ArgumentException("ByteRange always takes exactly 2 parameters");
         Low = byte.Parse(split[0]);
         High = byte.Parse(split[1]);
      }

      internal ByteRange(byte[] data)
      {
         if (data.Length != 2) throw new ArgumentException("ByteRange always takes exactly 2 parameters");
         Low = data[0];
         High = data[1];
      }

      internal ByteRange(InternalByteRangeStruct ByteRangeStruct)
      {
         Low = ByteRangeStruct.low;
         High = ByteRangeStruct.high;
      }

      public static ByteRange operator +(ByteRange p1, ByteRange p2)
      {
         return new ByteRange((byte)(p1.Low + p2.Low), (byte)(p1.High + p2.High));
      }

      public byte[] ToArray()
      {
         return new[] {Low, High};
      }

      internal InternalByteRangeStruct ToStruct()
      {
         return new InternalByteRangeStruct
         {
            low = Low,
            high = High
         };
      }

      public override string ToString()
      {
         return $"{Low} {High}";
      }

      public static ByteRange Zero = new ByteRange(0, 0);
   }
}
