namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Virtual table for handling subtrees registered with g_dbus_connection_register_subtree().
/// </para>
/// </summary>

public class GDBusSubtreeVTableHandle : BaseSafeHandle
{
}


public static class GDBusSubtreeVTableExtensions
{

	public static GDBusSubtreeVTable Dereference(this GDBusSubtreeVTableHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusSubtreeVTable>(x.DangerousGetHandle());
}
internal class GDBusSubtreeVTableExterns
{
}

/// <summary>
/// <para>
/// Virtual table for handling subtrees registered with g_dbus_connection_register_subtree().
/// </para>
/// </summary>

public struct GDBusSubtreeVTable
{
	/// <summary>
/// <para>
/// Function for enumerating child nodes.
/// </para>
/// </summary>

public GDBusSubtreeEnumerateFunc enumerate;
	/// <summary>
/// <para>
/// Function for introspecting a child node.
/// </para>
/// </summary>

public GDBusSubtreeIntrospectFunc introspect;
	/// <summary>
/// <para>
/// Function for dispatching a remote call on a child node.
/// </para>
/// </summary>

public GDBusSubtreeDispatchFunc dispatch;
}
