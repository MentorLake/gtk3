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
	/// <summary>
/// <para>
/// The accelerator keyval
/// </para>
/// </summary>

public uint accel_key;
	/// <summary>
/// <para>
/// The accelerator modifiers
/// </para>
/// </summary>

public GdkModifierType accel_mods;
	/// <summary>
/// <para>
/// The accelerator flags
/// </para>
/// </summary>

public uint accel_flags;
}
