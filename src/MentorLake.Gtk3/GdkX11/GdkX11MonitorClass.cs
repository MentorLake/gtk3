namespace MentorLake.GdkX11;

public class GdkX11MonitorClassHandle : BaseSafeHandle
{
}


public static class GdkX11MonitorClassExtensions
{

	public static GdkX11MonitorClass Dereference(this GdkX11MonitorClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkX11MonitorClass>(x.DangerousGetHandle());
}
internal class GdkX11MonitorClassExterns
{
}

public struct GdkX11MonitorClass
{
}
