namespace MentorLake.Gio;


public class GVolumeMonitorClassHandle : BaseSafeHandle
{
}


public static class GVolumeMonitorClassExtensions
{

	public static GVolumeMonitorClass Dereference(this GVolumeMonitorClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GVolumeMonitorClass>(x.DangerousGetHandle());
}
internal class GVolumeMonitorClassExterns
{
}


public struct GVolumeMonitorClass
{
	
public GObjectClass parent_class;
	
public IntPtr volume_added;
	
public IntPtr volume_removed;
	
public IntPtr volume_changed;
	
public IntPtr mount_added;
	
public IntPtr mount_removed;
	
public IntPtr mount_pre_unmount;
	
public IntPtr mount_changed;
	
public IntPtr drive_connected;
	
public IntPtr drive_disconnected;
	
public IntPtr drive_changed;
	
public IntPtr is_supported;
	
public IntPtr get_connected_drives;
	
public IntPtr get_volumes;
	
public IntPtr get_mounts;
	
public IntPtr get_volume_for_uuid;
	
public IntPtr get_mount_for_uuid;
	
public IntPtr adopt_orphan_mount;
	
public IntPtr drive_eject_button;
	
public IntPtr drive_stop_button;
	
public IntPtr _g_reserved1;
	
public IntPtr _g_reserved2;
	
public IntPtr _g_reserved3;
	
public IntPtr _g_reserved4;
	
public IntPtr _g_reserved5;
	
public IntPtr _g_reserved6;
}
