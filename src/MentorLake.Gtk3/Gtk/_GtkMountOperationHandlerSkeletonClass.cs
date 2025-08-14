namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Class structure for #_GtkMountOperationHandlerSkeleton.
/// </para>
/// </summary>

public class _GtkMountOperationHandlerSkeletonClassHandle : BaseSafeHandle
{
}


public static class _GtkMountOperationHandlerSkeletonClassExtensions
{

	public static _GtkMountOperationHandlerSkeletonClass Dereference(this _GtkMountOperationHandlerSkeletonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<_GtkMountOperationHandlerSkeletonClass>(x.DangerousGetHandle());
}
internal class _GtkMountOperationHandlerSkeletonClassExterns
{
}

/// <summary>
/// <para>
/// Class structure for #_GtkMountOperationHandlerSkeleton.
/// </para>
/// </summary>

public struct _GtkMountOperationHandlerSkeletonClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GDBusInterfaceSkeletonClass parent_class;
}
