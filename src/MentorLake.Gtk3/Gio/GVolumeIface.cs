namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Interface for implementing operations for mountable volumes.
/// </para>
/// </summary>

public class GVolumeIfaceHandle : BaseSafeHandle
{
}


public static class GVolumeIfaceExtensions
{

	public static GVolumeIface Dereference(this GVolumeIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GVolumeIface>(x.DangerousGetHandle());
}
internal class GVolumeIfaceExterns
{
}

/// <summary>
/// <para>
/// Interface for implementing operations for mountable volumes.
/// </para>
/// </summary>

public struct GVolumeIface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// Changed signal that is emitted when the volume&apos;s state has changed.
/// </para>
/// </summary>

public IntPtr changed;
	/// <summary>
/// <para>
/// The removed signal that is emitted when the #GVolume have been removed. If the recipient is holding references to the object they should release them so the object can be finalized.
/// </para>
/// </summary>

public IntPtr removed;
	/// <summary>
/// <para>
/// Gets a string containing the name of the #GVolume.
/// </para>
/// </summary>

public IntPtr get_name;
	/// <summary>
/// <para>
/// Gets a #GIcon for the #GVolume.
/// </para>
/// </summary>

public IntPtr get_icon;
	/// <summary>
/// <para>
/// Gets the UUID for the #GVolume. The reference is typically based on the file system UUID for the mount in question and should be considered an opaque string. Returns %NULL if there is no UUID available.
/// </para>
/// </summary>

public IntPtr get_uuid;
	/// <summary>
/// <para>
/// Gets a #GDrive the volume is located on. Returns %NULL if the #GVolume is not associated with a #GDrive.
/// </para>
/// </summary>

public IntPtr get_drive;
	/// <summary>
/// <para>
/// Gets a #GMount representing the mounted volume. Returns %NULL if the #GVolume is not mounted.
/// </para>
/// </summary>

public IntPtr get_mount;
	/// <summary>
/// <para>
/// Returns %TRUE if the #GVolume can be mounted.
/// </para>
/// </summary>

public IntPtr can_mount;
	/// <summary>
/// <para>
/// Checks if a #GVolume can be ejected.
/// </para>
/// </summary>

public IntPtr can_eject;
	/// <summary>
/// <para>
/// Mounts a given #GVolume.
///     #GVolume implementations must emit the #GMountOperation::aborted
///     signal before completing a mount operation that is aborted while
///     awaiting input from the user through a #GMountOperation instance.
/// </para>
/// </summary>

public IntPtr mount_fn;
	/// <summary>
/// <para>
/// Finishes a mount operation.
/// </para>
/// </summary>

public IntPtr mount_finish;
	/// <summary>
/// <para>
/// Ejects a given #GVolume.
/// </para>
/// </summary>

public IntPtr eject;
	/// <summary>
/// <para>
/// Finishes an eject operation.
/// </para>
/// </summary>

public IntPtr eject_finish;
	/// <summary>
/// <para>
/// Returns the [identifier](#volume-identifiers) of the given kind, or %NULL if
///    the #GVolume doesn&apos;t have one.
/// </para>
/// </summary>

public IntPtr get_identifier;
	/// <summary>
/// <para>
/// Returns an array strings listing the kinds
///    of [identifiers](#volume-identifiers) which the #GVolume has.
/// </para>
/// </summary>

public IntPtr enumerate_identifiers;
	/// <summary>
/// <para>
/// Returns %TRUE if the #GVolume should be automatically mounted.
/// </para>
/// </summary>

public IntPtr should_automount;
	/// <summary>
/// <para>
/// Returns the activation root for the #GVolume if it is known in advance or %NULL if
///   it is not known.
/// </para>
/// </summary>

public IntPtr get_activation_root;
	/// <summary>
/// <para>
/// Starts ejecting a #GVolume using a #GMountOperation. Since 2.22.
/// </para>
/// </summary>

public IntPtr eject_with_operation;
	/// <summary>
/// <para>
/// Finishes an eject operation using a #GMountOperation. Since 2.22.
/// </para>
/// </summary>

public IntPtr eject_with_operation_finish;
	/// <summary>
/// <para>
/// Gets a key used for sorting #GVolume instance or %NULL if no such key exists. Since 2.32.
/// </para>
/// </summary>

public IntPtr get_sort_key;
	/// <summary>
/// <para>
/// Gets a symbolic #GIcon for the #GVolume. Since 2.34.
/// </para>
/// </summary>

public IntPtr get_symbolic_icon;
}
