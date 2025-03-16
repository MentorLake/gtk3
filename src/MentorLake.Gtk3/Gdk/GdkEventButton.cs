namespace MentorLake.Gdk;

public class GdkEventButtonHandle : BaseSafeHandle
{
}


public static class GdkEventButtonExtensions
{

	public static GdkEventButton Dereference(this GdkEventButtonHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventButton>(x.DangerousGetHandle());
}
internal class GdkEventButtonExterns
{
}

public struct GdkEventButton
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public uint time;
	public double x;
	public double y;
	public IntPtr axes;
	public GdkModifierType state;
	public uint button;
	public IntPtr device;
	public double x_root;
	public double y_root;
}
