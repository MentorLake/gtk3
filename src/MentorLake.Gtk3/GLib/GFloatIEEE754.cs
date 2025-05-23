namespace MentorLake.GLib;

public class GFloatIEEE754_mpnHandle : BaseSafeHandle
{
}


public static class GFloatIEEE754_mpnExtensions
{

	public static GFloatIEEE754_mpn Dereference(this GFloatIEEE754_mpnHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFloatIEEE754_mpn>(x.DangerousGetHandle());
}
internal class GFloatIEEE754_mpnExterns
{
}

public struct GFloatIEEE754_mpn
{
	public uint mantissa;
	public uint biased_exponent;
	public uint sign;
}

public class GFloatIEEE754Handle : BaseSafeHandle
{
}


public static class GFloatIEEE754Extensions
{

	public static GFloatIEEE754 Dereference(this GFloatIEEE754Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFloatIEEE754>(x.DangerousGetHandle());
}
internal class GFloatIEEE754Externs
{
}

public struct GFloatIEEE754
{
	public GFloatIEEE754_mpn mpn;
	public float v_float;
}
