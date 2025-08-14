namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Class structure for #GSocketListener.
/// </para>
/// </summary>

public class GSocketListenerClassHandle : BaseSafeHandle
{
}


public static class GSocketListenerClassExtensions
{

	public static GSocketListenerClass Dereference(this GSocketListenerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSocketListenerClass>(x.DangerousGetHandle());
}
internal class GSocketListenerClassExterns
{
}

/// <summary>
/// <para>
/// Class structure for #GSocketListener.
/// </para>
/// </summary>

public struct GSocketListenerClass
{
	
public GObjectClass parent_class;
	/// <summary>
/// <para>
/// virtual method called when the set of socket listened to changes
/// </para>
/// </summary>

public IntPtr changed;
	
public IntPtr @event;
	
public IntPtr _g_reserved2;
	
public IntPtr _g_reserved3;
	
public IntPtr _g_reserved4;
	
public IntPtr _g_reserved5;
	
public IntPtr _g_reserved6;
}
