namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A union holding one collected value.
/// </para>
/// </summary>

public class GTypeCValueHandle : BaseSafeHandle
{
}


public static class GTypeCValueExtensions
{

	public static GTypeCValue Dereference(this GTypeCValueHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTypeCValue>(x.DangerousGetHandle());
}
internal class GTypeCValueExterns
{
}

/// <summary>
/// <para>
/// A union holding one collected value.
/// </para>
/// </summary>

public struct GTypeCValue
{
	/// <summary>
/// <para>
/// the field for holding integer values
/// </para>
/// </summary>

public int v_int;
	/// <summary>
/// <para>
/// the field for holding long integer values
/// </para>
/// </summary>

public long v_long;
	/// <summary>
/// <para>
/// the field for holding 64 bit integer values
/// </para>
/// </summary>

public long v_int64;
	/// <summary>
/// <para>
/// the field for holding floating point values
/// </para>
/// </summary>

public double v_double;
	/// <summary>
/// <para>
/// the field for holding pointers
/// </para>
/// </summary>

public IntPtr v_pointer;
}
