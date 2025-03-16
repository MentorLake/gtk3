namespace MentorLake.Gdk;

public class GdkEventPadButtonHandle : BaseSafeHandle
{
}


public static class GdkEventPadButtonExtensions
{

	public static GdkEventPadButton Dereference(this GdkEventPadButtonHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventPadButton>(x.DangerousGetHandle());
}
internal class GdkEventPadButtonExterns
{
}

public struct GdkEventPadButton
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public uint time;
	public uint group;
	public uint button;
	public uint mode;
}
