namespace MentorLake.Gdk;

public class GdkEventConfigureHandle : BaseSafeHandle
{
}


public static class GdkEventConfigureExtensions
{

	public static GdkEventConfigure Dereference(this GdkEventConfigureHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventConfigure>(x.DangerousGetHandle());
}
internal class GdkEventConfigureExterns
{
}

public struct GdkEventConfigure
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public int x;
	public int y;
	public int width;
	public int height;
}
