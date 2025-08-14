namespace MentorLake.Gtk;


public class GtkCellRendererClassHandle : BaseSafeHandle
{
}


public static class GtkCellRendererClassExtensions
{
/// <summary>
/// <para>
/// Sets the type to be used for creating accessibles for cells rendered by
/// cell renderers of @renderer_class. Note that multiple accessibles will
/// be created.
/// </para>
/// <para>
/// This function should only be called from class init functions of cell
/// renderers.
/// </para>
/// </summary>

/// <param name="renderer_class">
/// class to set the accessible type for
/// </param>
/// <param name="type">
/// The object type that implements the accessible for @widget_class.
///     The type must be a subtype of #GtkRendererCellAccessible
/// </param>

	public static void SetAccessibleType(this MentorLake.Gtk.GtkCellRendererClassHandle renderer_class, MentorLake.GObject.GType type)
	{
		if (renderer_class.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererClass)");
		GtkCellRendererClassExterns.gtk_cell_renderer_class_set_accessible_type(renderer_class, type);
	}


	public static GtkCellRendererClass Dereference(this GtkCellRendererClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellRendererClass>(x.DangerousGetHandle());
}
internal class GtkCellRendererClassExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_class_set_accessible_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererClassHandle>))] MentorLake.Gtk.GtkCellRendererClassHandle renderer_class, MentorLake.GObject.GType type);

}


public struct GtkCellRendererClass
{
	/// <summary>
/// <para>
/// Called to gets whether the cell renderer prefers
///    a height-for-width layout or a width-for-height layout.
/// </para>
/// </summary>

public IntPtr get_request_mode;
	/// <summary>
/// <para>
/// Called to get a renderer’s natural width.
/// </para>
/// </summary>

public IntPtr get_preferred_width;
	/// <summary>
/// <para>
/// Called to get a renderer’s natural height for width.
/// </para>
/// </summary>

public IntPtr get_preferred_height_for_width;
	/// <summary>
/// <para>
/// Called to get a renderer’s natural height.
/// </para>
/// </summary>

public IntPtr get_preferred_height;
	/// <summary>
/// <para>
/// Called to get a renderer’s natural width for height.
/// </para>
/// </summary>

public IntPtr get_preferred_width_for_height;
	/// <summary>
/// <para>
/// Called to get the aligned area used by @cell inside @cell_area.
/// </para>
/// </summary>

public IntPtr get_aligned_area;
	/// <summary>
/// <para>
/// Called to get the width and height needed to render the cell. Deprecated: 3.0.
/// </para>
/// </summary>

public IntPtr get_size;
	/// <summary>
/// <para>
/// Called to render the content of the #GtkCellRenderer.
/// </para>
/// </summary>

public IntPtr render;
	/// <summary>
/// <para>
/// Called to activate the content of the #GtkCellRenderer.
/// </para>
/// </summary>

public IntPtr activate;
	/// <summary>
/// <para>
/// Called to initiate editing the content of the #GtkCellRenderer.
/// </para>
/// </summary>

public IntPtr start_editing;
	/// <summary>
/// <para>
/// Signal gets emitted when the user cancels the process of editing a cell.
/// </para>
/// </summary>

public IntPtr editing_canceled;
	/// <summary>
/// <para>
/// Signal gets emitted when a cell starts to be edited.
/// </para>
/// </summary>

public IntPtr editing_started;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
