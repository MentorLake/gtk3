namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Provides an interface for converting data from one type
/// to another type. The conversion can be stateful
/// and may fail at any place.
/// </para>
/// </summary>

public class GConverterIfaceHandle : BaseSafeHandle
{
}


public static class GConverterIfaceExtensions
{

	public static GConverterIface Dereference(this GConverterIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GConverterIface>(x.DangerousGetHandle());
}
internal class GConverterIfaceExterns
{
}

/// <summary>
/// <para>
/// Provides an interface for converting data from one type
/// to another type. The conversion can be stateful
/// and may fail at any place.
/// </para>
/// </summary>

public struct GConverterIface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// Converts data.
/// </para>
/// </summary>

public IntPtr convert;
	/// <summary>
/// <para>
/// Reverts the internal state of the converter to its initial state.
/// </para>
/// </summary>

public IntPtr reset;
}
