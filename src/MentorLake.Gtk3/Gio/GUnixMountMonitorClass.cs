namespace MentorLake.Gio;


public class GUnixMountMonitorClassHandle : BaseSafeHandle
{
}


public static class GUnixMountMonitorClassExtensions
{

	public static GUnixMountMonitorClass Dereference(this GUnixMountMonitorClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUnixMountMonitorClass>(x.DangerousGetHandle());
}
internal class GUnixMountMonitorClassExterns
{
}


public struct GUnixMountMonitorClass
{
}
