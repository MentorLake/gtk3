namespace MentorLake.Gdk;

public class GdkEventVisibilityHandle : BaseSafeHandle
{
}


public static class GdkEventVisibilityExtensions
{

	public static GdkEventVisibility Dereference(this GdkEventVisibilityHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventVisibility>(x.DangerousGetHandle());
}
internal class GdkEventVisibilityExterns
{
}

public struct GdkEventVisibility
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public GdkVisibilityState state;
}
