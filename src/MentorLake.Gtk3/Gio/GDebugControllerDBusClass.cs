namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The virtual function table for #GDebugControllerDBus.
/// </para>
/// </summary>

public class GDebugControllerDBusClassHandle : BaseSafeHandle
{
}


public static class GDebugControllerDBusClassExtensions
{

	public static GDebugControllerDBusClass Dereference(this GDebugControllerDBusClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDebugControllerDBusClass>(x.DangerousGetHandle());
}
internal class GDebugControllerDBusClassExterns
{
}

/// <summary>
/// <para>
/// The virtual function table for #GDebugControllerDBus.
/// </para>
/// </summary>

public struct GDebugControllerDBusClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GObjectClass parent_class;
	/// <summary>
/// <para>
/// Default handler for the #GDebugControllerDBus::authorize signal.
/// </para>
/// </summary>

public IntPtr authorize;
	
public IntPtr padding;
}
