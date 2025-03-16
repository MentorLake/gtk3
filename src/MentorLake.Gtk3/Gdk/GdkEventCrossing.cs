namespace MentorLake.Gdk;

public class GdkEventCrossingHandle : BaseSafeHandle
{
}


public static class GdkEventCrossingExtensions
{

	public static GdkEventCrossing Dereference(this GdkEventCrossingHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventCrossing>(x.DangerousGetHandle());
}
internal class GdkEventCrossingExterns
{
}

public struct GdkEventCrossing
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public IntPtr subwindow;
	public uint time;
	public double x;
	public double y;
	public double x_root;
	public double y_root;
	public GdkCrossingMode mode;
	public GdkNotifyType detail;
	public bool focus;
	public GdkModifierType state;
}
