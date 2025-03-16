namespace MentorLake.Gdk;

public class GdkEventExposeHandle : BaseSafeHandle
{
}


public static class GdkEventExposeExtensions
{

	public static GdkEventExpose Dereference(this GdkEventExposeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventExpose>(x.DangerousGetHandle());
}
internal class GdkEventExposeExterns
{
}

public struct GdkEventExpose
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public GdkRectangle area;
	public IntPtr region;
	public int count;
}
