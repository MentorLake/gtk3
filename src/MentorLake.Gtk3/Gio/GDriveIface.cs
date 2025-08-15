namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Interface for creating #GDrive implementations.
/// </para>
/// </summary>

public class GDriveIfaceHandle : BaseSafeHandle
{
}


public static class GDriveIfaceExtensions
{

	public static GDriveIface Dereference(this GDriveIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDriveIface>(x.DangerousGetHandle());
}
internal class GDriveIfaceExterns
{
}

/// <summary>
/// <para>
/// Interface for creating #GDrive implementations.
/// </para>
/// </summary>

public struct GDriveIface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// Signal emitted when the drive is changed.
/// </para>
/// </summary>

public IntPtr changed;
	/// <summary>
/// <para>
/// The removed signal that is emitted when the #GDrive have been disconnected. If the recipient is holding references to the object they should release them so the object can be finalized.
/// </para>
/// </summary>

public IntPtr disconnected;
	/// <summary>
/// <para>
/// Signal emitted when the physical eject button (if any) of a drive have been pressed.
/// </para>
/// </summary>

public IntPtr eject_button;
	/// <summary>
/// <para>
/// Returns the name for the given #GDrive.
/// </para>
/// </summary>

public IntPtr get_name;
	/// <summary>
/// <para>
/// Returns a #GIcon for the given #GDrive.
/// </para>
/// </summary>

public IntPtr get_icon;
	/// <summary>
/// <para>
/// Returns %TRUE if the #GDrive has mountable volumes.
/// </para>
/// </summary>

public IntPtr has_volumes;
	/// <summary>
/// <para>
/// Returns a list #GList of #GVolume for the #GDrive.
/// </para>
/// </summary>

public IntPtr get_volumes;
	/// <summary>
/// <para>
/// Returns %TRUE if the #GDrive supports removal and insertion of media.
/// </para>
/// </summary>

public IntPtr is_media_removable;
	/// <summary>
/// <para>
/// Returns %TRUE if the #GDrive has media inserted.
/// </para>
/// </summary>

public IntPtr has_media;
	/// <summary>
/// <para>
/// Returns %TRUE if the #GDrive is capable of automatically detecting media changes.
/// </para>
/// </summary>

public IntPtr is_media_check_automatic;
	/// <summary>
/// <para>
/// Returns %TRUE if the #GDrive can eject media.
/// </para>
/// </summary>

public IntPtr can_eject;
	/// <summary>
/// <para>
/// Returns %TRUE if the #GDrive is capable of manually polling for media change.
/// </para>
/// </summary>

public IntPtr can_poll_for_media;
	/// <summary>
/// <para>
/// Ejects a #GDrive.
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
/// Poll for media insertion/removal on a #GDrive.
/// </para>
/// </summary>

public IntPtr poll_for_media;
	/// <summary>
/// <para>
/// Finishes a media poll operation.
/// </para>
/// </summary>

public IntPtr poll_for_media_finish;
	/// <summary>
/// <para>
/// Returns the identifier of the given kind, or %NULL if
///    the #GDrive doesn&apos;t have one.
/// </para>
/// </summary>

public IntPtr get_identifier;
	/// <summary>
/// <para>
/// Returns an array strings listing the kinds
///    of identifiers which the #GDrive has.
/// </para>
/// </summary>

public IntPtr enumerate_identifiers;
	/// <summary>
/// <para>
/// Gets a #GDriveStartStopType with details about starting/stopping the drive. Since 2.22.
/// </para>
/// </summary>

public IntPtr get_start_stop_type;
	/// <summary>
/// <para>
/// Returns %TRUE if a #GDrive can be started. Since 2.22.
/// </para>
/// </summary>

public IntPtr can_start;
	/// <summary>
/// <para>
/// Returns %TRUE if a #GDrive can be started degraded. Since 2.22.
/// </para>
/// </summary>

public IntPtr can_start_degraded;
	/// <summary>
/// <para>
/// Starts a #GDrive. Since 2.22.
/// </para>
/// </summary>

public IntPtr start;
	/// <summary>
/// <para>
/// Finishes a start operation. Since 2.22.
/// </para>
/// </summary>

public IntPtr start_finish;
	/// <summary>
/// <para>
/// Returns %TRUE if a #GDrive can be stopped. Since 2.22.
/// </para>
/// </summary>

public IntPtr can_stop;
	/// <summary>
/// <para>
/// Stops a #GDrive. Since 2.22.
/// </para>
/// </summary>

public IntPtr stop;
	/// <summary>
/// <para>
/// Finishes a stop operation. Since 2.22.
/// </para>
/// </summary>

public IntPtr stop_finish;
	/// <summary>
/// <para>
/// Signal emitted when the physical stop button (if any) of a drive have been pressed. Since 2.22.
/// </para>
/// </summary>

public IntPtr stop_button;
	/// <summary>
/// <para>
/// Starts ejecting a #GDrive using a #GMountOperation. Since 2.22.
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
/// Gets a key used for sorting #GDrive instances or %NULL if no such key exists. Since 2.32.
/// </para>
/// </summary>

public IntPtr get_sort_key;
	/// <summary>
/// <para>
/// Returns a symbolic #GIcon for the given #GDrive. Since 2.34.
/// </para>
/// </summary>

public IntPtr get_symbolic_icon;
	/// <summary>
/// <para>
/// Returns %TRUE if the #GDrive and/or its media is considered removable by the user. Since 2.50.
/// </para>
/// </summary>

public IntPtr is_removable;
}
