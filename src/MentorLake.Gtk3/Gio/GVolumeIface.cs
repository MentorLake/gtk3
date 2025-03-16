namespace MentorLake.Gio;

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

public struct GVolumeIface
{
	public GTypeInterface g_iface;
	public IntPtr changed;
	public IntPtr removed;
	public IntPtr get_name;
	public IntPtr get_icon;
	public IntPtr get_uuid;
	public IntPtr get_drive;
	public IntPtr get_mount;
	public IntPtr can_mount;
	public IntPtr can_eject;
	public IntPtr mount_fn;
	public IntPtr mount_finish;
	public IntPtr eject;
	public IntPtr eject_finish;
	public IntPtr get_identifier;
	public IntPtr enumerate_identifiers;
	public IntPtr should_automount;
	public IntPtr get_activation_root;
	public IntPtr eject_with_operation;
	public IntPtr eject_with_operation_finish;
	public IntPtr get_sort_key;
	public IntPtr get_symbolic_icon;
}
