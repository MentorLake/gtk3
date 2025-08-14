namespace MentorLake.Gdk;


public class GdkMonitorClassHandle : BaseSafeHandle
{
}


public static class GdkMonitorClassExtensions
{

	public static GdkMonitorClass Dereference(this GdkMonitorClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkMonitorClass>(x.DangerousGetHandle());
}
internal class GdkMonitorClassExterns
{
}


public struct GdkMonitorClass
{
}
