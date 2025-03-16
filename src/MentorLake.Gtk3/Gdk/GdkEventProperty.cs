namespace MentorLake.Gdk;

public class GdkEventPropertyHandle : BaseSafeHandle
{
}


public static class GdkEventPropertyExtensions
{

	public static GdkEventProperty Dereference(this GdkEventPropertyHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventProperty>(x.DangerousGetHandle());
}
internal class GdkEventPropertyExterns
{
}

public struct GdkEventProperty
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public GdkAtom atom;
	public uint time;
	public GdkPropertyState state;
}
