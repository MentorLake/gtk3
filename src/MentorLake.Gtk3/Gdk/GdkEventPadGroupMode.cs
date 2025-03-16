namespace MentorLake.Gdk;

public class GdkEventPadGroupModeHandle : BaseSafeHandle
{
}


public static class GdkEventPadGroupModeExtensions
{

	public static GdkEventPadGroupMode Dereference(this GdkEventPadGroupModeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventPadGroupMode>(x.DangerousGetHandle());
}
internal class GdkEventPadGroupModeExterns
{
}

public struct GdkEventPadGroupMode
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public uint time;
	public uint group;
	public uint mode;
}
