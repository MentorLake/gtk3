namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Class structure for #GDBusObjectManagerServer.
/// </para>
/// </summary>

public class GDBusObjectManagerServerClassHandle : BaseSafeHandle
{
}


public static class GDBusObjectManagerServerClassExtensions
{

	public static GDBusObjectManagerServerClass Dereference(this GDBusObjectManagerServerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusObjectManagerServerClass>(x.DangerousGetHandle());
}
internal class GDBusObjectManagerServerClassExterns
{
}

/// <summary>
/// <para>
/// Class structure for #GDBusObjectManagerServer.
/// </para>
/// </summary>

public struct GDBusObjectManagerServerClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GObjectClass parent_class;
}
