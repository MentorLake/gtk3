namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Interface for implementing operations for mounts.
/// </para>
/// </summary>

public class GMountIfaceHandle : BaseSafeHandle
{
}


public static class GMountIfaceExtensions
{

	public static GMountIface Dereference(this GMountIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMountIface>(x.DangerousGetHandle());
}
internal class GMountIfaceExterns
{
}

/// <summary>
/// <para>
/// Interface for implementing operations for mounts.
/// </para>
/// </summary>

public struct GMountIface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// Changed signal that is emitted when the mount's state has changed.
/// </para>
/// </summary>

public IntPtr changed;
	/// <summary>
/// <para>
/// The unmounted signal that is emitted when the #GMount have been unmounted. If the recipient is holding references to the object they should release them so the object can be finalized.
/// </para>
/// </summary>

public IntPtr unmounted;
	/// <summary>
/// <para>
/// Gets a #GFile to the root directory of the #GMount.
/// </para>
/// </summary>

public IntPtr get_root;
	/// <summary>
/// <para>
/// Gets a string containing the name of the #GMount.
/// </para>
/// </summary>

public IntPtr get_name;
	/// <summary>
/// <para>
/// Gets a #GIcon for the #GMount.
/// </para>
/// </summary>

public IntPtr get_icon;
	/// <summary>
/// <para>
/// Gets the UUID for the #GMount. The reference is typically based on the file system UUID for the mount in question and should be considered an opaque string. Returns %NULL if there is no UUID available.
/// </para>
/// </summary>

public IntPtr get_uuid;
	/// <summary>
/// <para>
/// Gets a #GVolume the mount is located on. Returns %NULL if the #GMount is not associated with a #GVolume.
/// </para>
/// </summary>

public IntPtr get_volume;
	/// <summary>
/// <para>
/// Gets a #GDrive the volume of the mount is located on. Returns %NULL if the #GMount is not associated with a #GDrive or a #GVolume. This is convenience method for getting the #GVolume and using that to get the #GDrive.
/// </para>
/// </summary>

public IntPtr get_drive;
	/// <summary>
/// <para>
/// Checks if a #GMount can be unmounted.
/// </para>
/// </summary>

public IntPtr can_unmount;
	/// <summary>
/// <para>
/// Checks if a #GMount can be ejected.
/// </para>
/// </summary>

public IntPtr can_eject;
	/// <summary>
/// <para>
/// Starts unmounting a #GMount.
/// </para>
/// </summary>

public IntPtr unmount;
	/// <summary>
/// <para>
/// Finishes an unmounting operation.
/// </para>
/// </summary>

public IntPtr unmount_finish;
	/// <summary>
/// <para>
/// Starts ejecting a #GMount.
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
/// Starts remounting a #GMount.
/// </para>
/// </summary>

public IntPtr remount;
	/// <summary>
/// <para>
/// Finishes a remounting operation.
/// </para>
/// </summary>

public IntPtr remount_finish;
	/// <summary>
/// <para>
/// Starts guessing the type of the content of a #GMount.
///     See g_mount_guess_content_type() for more information on content
///     type guessing. This operation was added in 2.18.
/// </para>
/// </summary>

public IntPtr guess_content_type;
	/// <summary>
/// <para>
/// Finishes a content type guessing operation. Added in 2.18.
/// </para>
/// </summary>

public IntPtr guess_content_type_finish;
	/// <summary>
/// <para>
/// Synchronous variant of @guess_content_type. Added in 2.18
/// </para>
/// </summary>

public IntPtr guess_content_type_sync;
	/// <summary>
/// <para>
/// The ::pre-unmount signal that is emitted when the #GMount will soon be emitted. If the recipient is somehow holding the mount open by keeping an open file on it it should close the file.
/// </para>
/// </summary>

public IntPtr pre_unmount;
	/// <summary>
/// <para>
/// Starts unmounting a #GMount using a #GMountOperation. Since 2.22.
/// </para>
/// </summary>

public IntPtr unmount_with_operation;
	/// <summary>
/// <para>
/// Finishes an unmounting operation using a #GMountOperation. Since 2.22.
/// </para>
/// </summary>

public IntPtr unmount_with_operation_finish;
	/// <summary>
/// <para>
/// Starts ejecting a #GMount using a #GMountOperation. Since 2.22.
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
/// Gets a #GFile indication a start location that can be use as the entry point for this mount. Since 2.24.
/// </para>
/// </summary>

public IntPtr get_default_location;
	/// <summary>
/// <para>
/// Gets a key used for sorting #GMount instance or %NULL if no such key exists. Since 2.32.
/// </para>
/// </summary>

public IntPtr get_sort_key;
	/// <summary>
/// <para>
/// Gets a symbolic #GIcon for the #GMount. Since 2.34.
/// </para>
/// </summary>

public IntPtr get_symbolic_icon;
}
