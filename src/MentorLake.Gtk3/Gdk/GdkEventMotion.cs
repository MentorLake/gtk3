namespace MentorLake.Gdk;

public class GdkEventMotionHandle : BaseSafeHandle
{
}


public static class GdkEventMotionExtensions
{

	public static GdkEventMotion Dereference(this GdkEventMotionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventMotion>(x.DangerousGetHandle());
}
internal class GdkEventMotionExterns
{
}

public struct GdkEventMotion
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public uint time;
	public double x;
	public double y;
	public IntPtr axes;
	public GdkModifierType state;
	public short is_hint;
	public IntPtr device;
	public double x_root;
	public double y_root;
}
