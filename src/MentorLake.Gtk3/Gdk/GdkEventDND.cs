namespace MentorLake.Gdk;

public class GdkEventDNDHandle : BaseSafeHandle
{
}


public static class GdkEventDNDExtensions
{

	public static GdkEventDND Dereference(this GdkEventDNDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventDND>(x.DangerousGetHandle());
}
internal class GdkEventDNDExterns
{
}

public struct GdkEventDND
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public IntPtr context;
	public uint time;
	public short x_root;
	public short y_root;
}
