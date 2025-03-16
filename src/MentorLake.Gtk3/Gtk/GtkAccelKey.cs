namespace MentorLake.Gtk;

public class GtkAccelKeyHandle : BaseSafeHandle
{
}


public static class GtkAccelKeyExtensions
{

	public static GtkAccelKey Dereference(this GtkAccelKeyHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAccelKey>(x.DangerousGetHandle());
}
internal class GtkAccelKeyExterns
{
}

public struct GtkAccelKey
{
	public uint accel_key;
	public GdkModifierType accel_mods;
	public uint accel_flags;
}
