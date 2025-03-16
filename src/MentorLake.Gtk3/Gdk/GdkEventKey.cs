namespace MentorLake.Gdk;

public class GdkEventKeyHandle : BaseSafeHandle
{
}


public static class GdkEventKeyExtensions
{

	public static GdkEventKey Dereference(this GdkEventKeyHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventKey>(x.DangerousGetHandle());
}
internal class GdkEventKeyExterns
{
}

public struct GdkEventKey
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public uint time;
	public GdkModifierType state;
	public uint keyval;
	public int length;
	public string @string;
	public ushort hardware_keycode;
	public byte group;
	public uint is_modifier;
}
