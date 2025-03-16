namespace MentorLake.Gdk;

public class GdkEventOwnerChangeHandle : BaseSafeHandle
{
}


public static class GdkEventOwnerChangeExtensions
{

	public static GdkEventOwnerChange Dereference(this GdkEventOwnerChangeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventOwnerChange>(x.DangerousGetHandle());
}
internal class GdkEventOwnerChangeExterns
{
}

public struct GdkEventOwnerChange
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public IntPtr owner;
	public GdkOwnerChange reason;
	public GdkAtom selection;
	public uint time;
	public uint selection_time;
}
