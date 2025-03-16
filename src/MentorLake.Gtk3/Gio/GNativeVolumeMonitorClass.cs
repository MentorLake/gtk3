namespace MentorLake.Gio;

public class GNativeVolumeMonitorClassHandle : BaseSafeHandle
{
}


public static class GNativeVolumeMonitorClassExtensions
{

	public static GNativeVolumeMonitorClass Dereference(this GNativeVolumeMonitorClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GNativeVolumeMonitorClass>(x.DangerousGetHandle());
}
internal class GNativeVolumeMonitorClassExterns
{
}

public struct GNativeVolumeMonitorClass
{
	public GVolumeMonitorClass parent_class;
	public IntPtr get_mount_for_mount_path;
}
