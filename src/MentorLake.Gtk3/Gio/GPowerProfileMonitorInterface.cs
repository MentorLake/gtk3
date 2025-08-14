namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The virtual function table for #GPowerProfileMonitor.
/// </para>
/// </summary>

public class GPowerProfileMonitorInterfaceHandle : BaseSafeHandle
{
}


public static class GPowerProfileMonitorInterfaceExtensions
{

	public static GPowerProfileMonitorInterface Dereference(this GPowerProfileMonitorInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GPowerProfileMonitorInterface>(x.DangerousGetHandle());
}
internal class GPowerProfileMonitorInterfaceExterns
{
}

/// <summary>
/// <para>
/// The virtual function table for #GPowerProfileMonitor.
/// </para>
/// </summary>

public struct GPowerProfileMonitorInterface
{
}
