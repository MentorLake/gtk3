namespace MentorLake.Gdk;

public class GdkEventSelectionHandle : BaseSafeHandle
{
}


public static class GdkEventSelectionExtensions
{

	public static GdkEventSelection Dereference(this GdkEventSelectionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventSelection>(x.DangerousGetHandle());
}
internal class GdkEventSelectionExterns
{
}

public struct GdkEventSelection
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public GdkAtom selection;
	public GdkAtom target;
	public GdkAtom property;
	public uint time;
	public IntPtr requestor;
}
