namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Base object type for D-Bus objects.
/// </para>
/// </summary>

public class GDBusObjectIfaceHandle : BaseSafeHandle
{
}


public static class GDBusObjectIfaceExtensions
{

	public static GDBusObjectIface Dereference(this GDBusObjectIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusObjectIface>(x.DangerousGetHandle());
}
internal class GDBusObjectIfaceExterns
{
}

/// <summary>
/// <para>
/// Base object type for D-Bus objects.
/// </para>
/// </summary>

public struct GDBusObjectIface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface parent_iface;
	/// <summary>
/// <para>
/// Returns the object path. See g_dbus_object_get_object_path().
/// </para>
/// </summary>

public IntPtr get_object_path;
	/// <summary>
/// <para>
/// Returns all interfaces. See g_dbus_object_get_interfaces().
/// </para>
/// </summary>

public IntPtr get_interfaces;
	/// <summary>
/// <para>
/// Returns an interface by name. See g_dbus_object_get_interface().
/// </para>
/// </summary>

public IntPtr get_interface;
	/// <summary>
/// <para>
/// Signal handler for the #GDBusObject::interface-added signal.
/// </para>
/// </summary>

public IntPtr interface_added;
	/// <summary>
/// <para>
/// Signal handler for the #GDBusObject::interface-removed signal.
/// </para>
/// </summary>

public IntPtr interface_removed;
}
