namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Base type for D-Bus object managers.
/// </para>
/// </summary>

public class GDBusObjectManagerIfaceHandle : BaseSafeHandle
{
}


public static class GDBusObjectManagerIfaceExtensions
{

	public static GDBusObjectManagerIface Dereference(this GDBusObjectManagerIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusObjectManagerIface>(x.DangerousGetHandle());
}
internal class GDBusObjectManagerIfaceExterns
{
}

/// <summary>
/// <para>
/// Base type for D-Bus object managers.
/// </para>
/// </summary>

public struct GDBusObjectManagerIface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface parent_iface;
	/// <summary>
/// <para>
/// Virtual function for g_dbus_object_manager_get_object_path().
/// </para>
/// </summary>

public IntPtr get_object_path;
	/// <summary>
/// <para>
/// Virtual function for g_dbus_object_manager_get_objects().
/// </para>
/// </summary>

public IntPtr get_objects;
	/// <summary>
/// <para>
/// Virtual function for g_dbus_object_manager_get_object().
/// </para>
/// </summary>

public IntPtr get_object;
	/// <summary>
/// <para>
/// Virtual function for g_dbus_object_manager_get_interface().
/// </para>
/// </summary>

public IntPtr get_interface;
	/// <summary>
/// <para>
/// Signal handler for the #GDBusObjectManager::object-added signal.
/// </para>
/// </summary>

public IntPtr object_added;
	/// <summary>
/// <para>
/// Signal handler for the #GDBusObjectManager::object-removed signal.
/// </para>
/// </summary>

public IntPtr object_removed;
	/// <summary>
/// <para>
/// Signal handler for the #GDBusObjectManager::interface-added signal.
/// </para>
/// </summary>

public IntPtr interface_added;
	/// <summary>
/// <para>
/// Signal handler for the #GDBusObjectManager::interface-removed signal.
/// </para>
/// </summary>

public IntPtr interface_removed;
}
