namespace MentorLake.Gio;

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

public struct GMountIface
{
	public GTypeInterface g_iface;
	public IntPtr changed;
	public IntPtr unmounted;
	public IntPtr get_root;
	public IntPtr get_name;
	public IntPtr get_icon;
	public IntPtr get_uuid;
	public IntPtr get_volume;
	public IntPtr get_drive;
	public IntPtr can_unmount;
	public IntPtr can_eject;
	public IntPtr unmount;
	public IntPtr unmount_finish;
	public IntPtr eject;
	public IntPtr eject_finish;
	public IntPtr remount;
	public IntPtr remount_finish;
	public IntPtr guess_content_type;
	public IntPtr guess_content_type_finish;
	public IntPtr guess_content_type_sync;
	public IntPtr pre_unmount;
	public IntPtr unmount_with_operation;
	public IntPtr unmount_with_operation_finish;
	public IntPtr eject_with_operation;
	public IntPtr eject_with_operation_finish;
	public IntPtr get_default_location;
	public IntPtr get_sort_key;
	public IntPtr get_symbolic_icon;
}
