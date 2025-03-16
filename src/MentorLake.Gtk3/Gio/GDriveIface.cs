namespace MentorLake.Gio;

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

public struct GDriveIface
{
	public GTypeInterface g_iface;
	public IntPtr changed;
	public IntPtr disconnected;
	public IntPtr eject_button;
	public IntPtr get_name;
	public IntPtr get_icon;
	public IntPtr has_volumes;
	public IntPtr get_volumes;
	public IntPtr is_media_removable;
	public IntPtr has_media;
	public IntPtr is_media_check_automatic;
	public IntPtr can_eject;
	public IntPtr can_poll_for_media;
	public IntPtr eject;
	public IntPtr eject_finish;
	public IntPtr poll_for_media;
	public IntPtr poll_for_media_finish;
	public IntPtr get_identifier;
	public IntPtr enumerate_identifiers;
	public IntPtr get_start_stop_type;
	public IntPtr can_start;
	public IntPtr can_start_degraded;
	public IntPtr start;
	public IntPtr start_finish;
	public IntPtr can_stop;
	public IntPtr stop;
	public IntPtr stop_finish;
	public IntPtr stop_button;
	public IntPtr eject_with_operation;
	public IntPtr eject_with_operation_finish;
	public IntPtr get_sort_key;
	public IntPtr get_symbolic_icon;
	public IntPtr is_removable;
}
