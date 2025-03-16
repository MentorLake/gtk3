namespace MentorLake.Gdk;

public class GdkFrameClockClassHandle : BaseSafeHandle
{
}


public static class GdkFrameClockClassExtensions
{

	public static GdkFrameClockClass Dereference(this GdkFrameClockClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkFrameClockClass>(x.DangerousGetHandle());
}
internal class GdkFrameClockClassExterns
{
}

public struct GdkFrameClockClass
{
}
