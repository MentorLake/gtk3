namespace MentorLake.Gdk;

public class GdkKeymapKeyHandle : BaseSafeHandle
{
}


public static class GdkKeymapKeyExtensions
{

	public static GdkKeymapKey Dereference(this GdkKeymapKeyHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkKeymapKey>(x.DangerousGetHandle());
}
internal class GdkKeymapKeyExterns
{
}

public struct GdkKeymapKey
{
	public uint keycode;
	public int group;
	public int level;
}
