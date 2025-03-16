namespace MentorLake.Gdk;

public class GdkEventPadAxisHandle : BaseSafeHandle
{
}


public static class GdkEventPadAxisExtensions
{

	public static GdkEventPadAxis Dereference(this GdkEventPadAxisHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventPadAxis>(x.DangerousGetHandle());
}
internal class GdkEventPadAxisExterns
{
}

public struct GdkEventPadAxis
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public uint time;
	public uint group;
	public uint index;
	public uint mode;
	public double value;
}
