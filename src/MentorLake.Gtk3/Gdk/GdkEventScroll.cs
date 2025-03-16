namespace MentorLake.Gdk;

public class GdkEventScrollHandle : BaseSafeHandle
{
}


public static class GdkEventScrollExtensions
{

	public static GdkEventScroll Dereference(this GdkEventScrollHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventScroll>(x.DangerousGetHandle());
}
internal class GdkEventScrollExterns
{
}

public struct GdkEventScroll
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public uint time;
	public double x;
	public double y;
	public GdkModifierType state;
	public GdkScrollDirection direction;
	public IntPtr device;
	public double x_root;
	public double y_root;
	public double delta_x;
	public double delta_y;
	public uint is_stop;
}
