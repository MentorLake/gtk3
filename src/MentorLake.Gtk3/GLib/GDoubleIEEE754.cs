namespace MentorLake.GLib;

public class GDoubleIEEE754_mpnHandle : BaseSafeHandle
{
}


public static class GDoubleIEEE754_mpnExtensions
{

	public static GDoubleIEEE754_mpn Dereference(this GDoubleIEEE754_mpnHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDoubleIEEE754_mpn>(x.DangerousGetHandle());
}
internal class GDoubleIEEE754_mpnExterns
{
}

public struct GDoubleIEEE754_mpn
{
	public uint mantissa_low;
	public uint mantissa_high;
	public uint biased_exponent;
	public uint sign;
}

public class GDoubleIEEE754Handle : BaseSafeHandle
{
}


public static class GDoubleIEEE754Extensions
{

	public static GDoubleIEEE754 Dereference(this GDoubleIEEE754Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDoubleIEEE754>(x.DangerousGetHandle());
}
internal class GDoubleIEEE754Externs
{
}

public struct GDoubleIEEE754
{
	public GDoubleIEEE754_mpn mpn;
	public double v_double;
}
