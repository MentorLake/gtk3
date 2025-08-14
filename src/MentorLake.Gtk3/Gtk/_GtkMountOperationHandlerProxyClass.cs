namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Class structure for #_GtkMountOperationHandlerProxy.
/// </para>
/// </summary>

public class _GtkMountOperationHandlerProxyClassHandle : BaseSafeHandle
{
}


public static class _GtkMountOperationHandlerProxyClassExtensions
{

	public static _GtkMountOperationHandlerProxyClass Dereference(this _GtkMountOperationHandlerProxyClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<_GtkMountOperationHandlerProxyClass>(x.DangerousGetHandle());
}
internal class _GtkMountOperationHandlerProxyClassExterns
{
}

/// <summary>
/// <para>
/// Class structure for #_GtkMountOperationHandlerProxy.
/// </para>
/// </summary>

public struct _GtkMountOperationHandlerProxyClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GDBusProxyClass parent_class;
}
