namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Base type for D-Bus interfaces.
/// </para>
/// </summary>

public class GDBusInterfaceIfaceHandle : BaseSafeHandle
{
}


public static class GDBusInterfaceIfaceExtensions
{

	public static GDBusInterfaceIface Dereference(this GDBusInterfaceIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusInterfaceIface>(x.DangerousGetHandle());
}
internal class GDBusInterfaceIfaceExterns
{
}

/// <summary>
/// <para>
/// Base type for D-Bus interfaces.
/// </para>
/// </summary>

public struct GDBusInterfaceIface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface parent_iface;
	/// <summary>
/// <para>
/// Returns a #GDBusInterfaceInfo. See g_dbus_interface_get_info().
/// </para>
/// </summary>

public IntPtr get_info;
	/// <summary>
/// <para>
/// Gets the enclosing #GDBusObject. See g_dbus_interface_get_object().
/// </para>
/// </summary>

public IntPtr get_object;
	/// <summary>
/// <para>
/// Sets the enclosing #GDBusObject. See g_dbus_interface_set_object().
/// </para>
/// </summary>

public IntPtr set_object;
	/// <summary>
/// <para>
/// Gets a reference to the enclosing #GDBusObject. See g_dbus_interface_dup_object(). Added in 2.32.
/// </para>
/// </summary>

public IntPtr dup_object;
}
