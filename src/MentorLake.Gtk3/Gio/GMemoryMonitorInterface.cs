namespace MentorLake.Gio;

public class GMemoryMonitorInterfaceHandle : BaseSafeHandle
{
}


public static class GMemoryMonitorInterfaceExtensions
{

	public static GMemoryMonitorInterface Dereference(this GMemoryMonitorInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMemoryMonitorInterface>(x.DangerousGetHandle());
}
internal class GMemoryMonitorInterfaceExterns
{
}

public struct GMemoryMonitorInterface
{
	public IntPtr low_memory_warning;
}
