namespace MentorLake.Gdk;

public class GdkEventTouchpadPinchHandle : BaseSafeHandle
{
}


public static class GdkEventTouchpadPinchExtensions
{

	public static GdkEventTouchpadPinch Dereference(this GdkEventTouchpadPinchHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventTouchpadPinch>(x.DangerousGetHandle());
}
internal class GdkEventTouchpadPinchExterns
{
}

public struct GdkEventTouchpadPinch
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public byte phase;
	public byte n_fingers;
	public uint time;
	public double x;
	public double y;
	public double dx;
	public double dy;
	public double angle_delta;
	public double scale;
	public double x_root;
	public double y_root;
	public GdkModifierType state;
}
