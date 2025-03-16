namespace MentorLake.Gio;

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

public struct GPowerProfileMonitorInterface
{
}
