namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkAllocation-struct of a widget represents region
/// which has been allocated to the widget by its parent. It is a subregion
/// of its parents allocation. See
/// [GtkWidget’s geometry management section][geometry-management] for
/// more information.
/// </para>
/// </summary>

public struct GtkAllocation
{
	public MentorLake.Gdk.GdkRectangle Value;
}

/// <summary>
/// <para>
/// A #GtkAllocation-struct of a widget represents region
/// which has been allocated to the widget by its parent. It is a subregion
/// of its parents allocation. See
/// [GtkWidget’s geometry management section][geometry-management] for
/// more information.
/// </para>
/// </summary>

public class GtkAllocationHandle : BaseSafeHandle
{
}

public static class GtkAllocationHandleExtensions
{
	public static GtkAllocation Dereference(this GtkAllocationHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAllocation>(x.DangerousGetHandle());
	public static MentorLake.Gdk.GdkRectangle DereferenceValue(this GtkAllocationHandle x) => x.Dereference().Value;
}
