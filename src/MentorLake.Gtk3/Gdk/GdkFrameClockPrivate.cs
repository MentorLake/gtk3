namespace MentorLake.Gdk;


public class GdkFrameClockPrivateHandle : BaseSafeHandle
{
}


public static class GdkFrameClockPrivateExtensions
{

	public static GdkFrameClockPrivate Dereference(this GdkFrameClockPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkFrameClockPrivate>(x.DangerousGetHandle());
}
internal class GdkFrameClockPrivateExterns
{
}


public struct GdkFrameClockPrivate
{
}
