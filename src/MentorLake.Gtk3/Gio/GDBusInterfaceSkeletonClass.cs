namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Class structure for #GDBusInterfaceSkeleton.
/// </para>
/// </summary>

public class GDBusInterfaceSkeletonClassHandle : BaseSafeHandle
{
}


public static class GDBusInterfaceSkeletonClassExtensions
{

	public static GDBusInterfaceSkeletonClass Dereference(this GDBusInterfaceSkeletonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusInterfaceSkeletonClass>(x.DangerousGetHandle());
}
internal class GDBusInterfaceSkeletonClassExterns
{
}

/// <summary>
/// <para>
/// Class structure for #GDBusInterfaceSkeleton.
/// </para>
/// </summary>

public struct GDBusInterfaceSkeletonClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GObjectClass parent_class;
	/// <summary>
/// <para>
/// Returns a #GDBusInterfaceInfo. See g_dbus_interface_skeleton_get_info() for details.
/// </para>
/// </summary>

public IntPtr get_info;
	/// <summary>
/// <para>
/// Returns a #GDBusInterfaceVTable. See g_dbus_interface_skeleton_get_vtable() for details.
/// </para>
/// </summary>

public IntPtr get_vtable;
	/// <summary>
/// <para>
/// Returns a #GVariant with all properties. See g_dbus_interface_skeleton_get_properties().
/// </para>
/// </summary>

public IntPtr get_properties;
	/// <summary>
/// <para>
/// Emits outstanding changes, if any. See g_dbus_interface_skeleton_flush().
/// </para>
/// </summary>

public IntPtr flush;
	/// <summary>
/// <para>
/// Signal class handler for the #GDBusInterfaceSkeleton::g-authorize-method signal.
/// </para>
/// </summary>

public IntPtr g_authorize_method;
}
