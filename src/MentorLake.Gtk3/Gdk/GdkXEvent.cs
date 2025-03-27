namespace MentorLake.Gdk;

public struct GdkXEvent
{
}

public class GdkXEventHandle : BaseSafeHandle
{
}

public static class GdkXEventHandleExtensions
{
	public static GdkXEvent Dereference(this GdkXEventHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkXEvent>(x.DangerousGetHandle());
}
