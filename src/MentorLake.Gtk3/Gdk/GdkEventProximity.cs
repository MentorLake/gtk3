namespace MentorLake.Gdk;

public class GdkEventProximityHandle : BaseSafeHandle
{
}


public static class GdkEventProximityExtensions
{

	public static GdkEventProximity Dereference(this GdkEventProximityHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventProximity>(x.DangerousGetHandle());
}
internal class GdkEventProximityExterns
{
}

public struct GdkEventProximity
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public uint time;
	public IntPtr device;
}
