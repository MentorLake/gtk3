namespace MentorLake.Gio;

public class GFileMonitorPrivateHandle : BaseSafeHandle
{
}


public static class GFileMonitorPrivateExtensions
{

	public static GFileMonitorPrivate Dereference(this GFileMonitorPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFileMonitorPrivate>(x.DangerousGetHandle());
}
internal class GFileMonitorPrivateExterns
{
}

public struct GFileMonitorPrivate
{
}
