namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The virtual function table for #GMemoryMonitor.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// The virtual function table for #GMemoryMonitor.
/// </para>
/// </summary>

public struct GMemoryMonitorInterface
{
	/// <summary>
/// <para>
/// the virtual function pointer for the
///  #GMemoryMonitor::low-memory-warning signal.
/// </para>
/// </summary>

public IntPtr low_memory_warning;
}
