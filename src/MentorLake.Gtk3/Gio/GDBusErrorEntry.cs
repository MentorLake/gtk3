namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Struct used in g_dbus_error_register_error_domain().
/// </para>
/// </summary>

public class GDBusErrorEntryHandle : BaseSafeHandle
{
}


public static class GDBusErrorEntryExtensions
{

	public static GDBusErrorEntry Dereference(this GDBusErrorEntryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusErrorEntry>(x.DangerousGetHandle());
}
internal class GDBusErrorEntryExterns
{
}

/// <summary>
/// <para>
/// Struct used in g_dbus_error_register_error_domain().
/// </para>
/// </summary>

public struct GDBusErrorEntry
{
	/// <summary>
/// <para>
/// An error code.
/// </para>
/// </summary>

public int error_code;
	/// <summary>
/// <para>
/// The D-Bus error name to associate with @error_code.
/// </para>
/// </summary>

public string dbus_error_name;
}
