namespace MentorLake.Gdk;

public class GdkEventWindowStateHandle : BaseSafeHandle
{
}


public static class GdkEventWindowStateExtensions
{

	public static GdkEventWindowState Dereference(this GdkEventWindowStateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventWindowState>(x.DangerousGetHandle());
}
internal class GdkEventWindowStateExterns
{
}

public struct GdkEventWindowState
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public GdkWindowState changed_mask;
	public GdkWindowState new_window_state;
}
