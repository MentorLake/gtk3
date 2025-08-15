namespace MentorLake.Gtk;


public class GtkCellAreaClassHandle : BaseSafeHandle
{
}


public static class GtkCellAreaClassExtensions
{
/// <summary>
/// <para>
/// Finds a cell property of a cell area class by name.
/// </para>
/// </summary>

/// <param name="aclass">
/// a #GtkCellAreaClass
/// </param>
/// <param name="property_name">
/// the name of the child property to find
/// </param>
/// <return>
/// the #GParamSpec of the child property
///   or %NULL if @aclass has no child property with that name.
/// </return>

	public static MentorLake.GObject.GParamSpecHandle FindCellProperty(this MentorLake.Gtk.GtkCellAreaClassHandle aclass, string property_name)
	{
		if (aclass.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaClass)");
		return GtkCellAreaClassExterns.gtk_cell_area_class_find_cell_property(aclass, property_name);
	}

/// <summary>
/// <para>
/// Installs a cell property on a cell area class.
/// </para>
/// </summary>

/// <param name="aclass">
/// a #GtkCellAreaClass
/// </param>
/// <param name="property_id">
/// the id for the property
/// </param>
/// <param name="pspec">
/// the #GParamSpec for the property
/// </param>

	public static void InstallCellProperty(this MentorLake.Gtk.GtkCellAreaClassHandle aclass, uint property_id, MentorLake.GObject.GParamSpecHandle pspec)
	{
		if (aclass.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaClass)");
		GtkCellAreaClassExterns.gtk_cell_area_class_install_cell_property(aclass, property_id, pspec);
	}

/// <summary>
/// <para>
/// Returns all cell properties of a cell area class.
/// </para>
/// </summary>

/// <param name="aclass">
/// a #GtkCellAreaClass
/// </param>
/// <param name="n_properties">
/// location to return the number of cell properties found
/// </param>
/// <return>
/// a newly
///     allocated %NULL-terminated array of #GParamSpec*.  The array
///     must be freed with g_free().
/// </return>

	public static MentorLake.GObject.GParamSpecHandle[] ListCellProperties(this MentorLake.Gtk.GtkCellAreaClassHandle aclass, out uint n_properties)
	{
		if (aclass.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaClass)");
		return GtkCellAreaClassExterns.gtk_cell_area_class_list_cell_properties(aclass, out n_properties);
	}


	public static GtkCellAreaClass Dereference(this GtkCellAreaClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellAreaClass>(x.DangerousGetHandle());
}
internal class GtkCellAreaClassExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle gtk_cell_area_class_find_cell_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaClassHandle>))] MentorLake.Gtk.GtkCellAreaClassHandle aclass, string property_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_class_install_cell_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaClassHandle>))] MentorLake.Gtk.GtkCellAreaClassHandle aclass, uint property_id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GObject.GParamSpecHandle[] gtk_cell_area_class_list_cell_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaClassHandle>))] MentorLake.Gtk.GtkCellAreaClassHandle aclass, out uint n_properties);

}


public struct GtkCellAreaClass
{
	/// <summary>
/// <para>
/// adds a #GtkCellRenderer to the area.
/// </para>
/// </summary>

public IntPtr add;
	/// <summary>
/// <para>
/// removes a #GtkCellRenderer from the area.
/// </para>
/// </summary>

public IntPtr remove;
	/// <summary>
/// <para>
/// calls the #GtkCellCallback function on every #GtkCellRenderer in
///     the area with the provided user data until the callback returns %TRUE.
/// </para>
/// </summary>

public IntPtr @foreach;
	/// <summary>
/// <para>
/// Calls the #GtkCellAllocCallback function on every
///     #GtkCellRenderer in the area with the allocated area for the cell
///     and the provided user data until the callback returns %TRUE.
/// </para>
/// </summary>

public IntPtr foreach_alloc;
	/// <summary>
/// <para>
/// Handle an event in the area, this is generally used to activate
///     a cell at the event location for button events but can also be used
///     to generically pass events to #GtkWidgets drawn onto the area.
/// </para>
/// </summary>

public IntPtr @event;
	/// <summary>
/// <para>
/// Actually render the area’s cells to the specified rectangle,
///     @background_area should be correctly distributed to the cells
///     corresponding background areas.
/// </para>
/// </summary>

public IntPtr render;
	/// <summary>
/// <para>
/// Apply the cell attributes to the cells. This is
///     implemented as a signal and generally #GtkCellArea subclasses don&apos;t
///     need to implement it since it is handled by the base class.
/// </para>
/// </summary>

public IntPtr apply_attributes;
	/// <summary>
/// <para>
/// Creates and returns a class specific #GtkCellAreaContext
///     to store cell alignment and allocation details for a said #GtkCellArea
///     class.
/// </para>
/// </summary>

public IntPtr create_context;
	/// <summary>
/// <para>
/// Creates a new #GtkCellAreaContext in the same state as
///     the passed @context with any cell alignment data and allocations intact.
/// </para>
/// </summary>

public IntPtr copy_context;
	/// <summary>
/// <para>
/// This allows an area to tell its layouting widget whether
///     it prefers to be allocated in %GTK_SIZE_REQUEST_HEIGHT_FOR_WIDTH or
///     %GTK_SIZE_REQUEST_WIDTH_FOR_HEIGHT mode.
/// </para>
/// </summary>

public IntPtr get_request_mode;
	/// <summary>
/// <para>
/// Calculates the minimum and natural width of the
///     areas cells with the current attributes applied while considering
///     the particular layouting details of the said #GtkCellArea. While
///     requests are performed over a series of rows, alignments and overall
///     minimum and natural sizes should be stored in the corresponding
///     #GtkCellAreaContext.
/// </para>
/// </summary>

public IntPtr get_preferred_width;
	/// <summary>
/// <para>
/// Calculates the minimum and natural height
///     for the area if the passed @context would be allocated the given width.
///     When implementing this virtual method it is safe to assume that @context
///     has already stored the aligned cell widths for every #GtkTreeModel row
///     that @context will be allocated for since this information was stored
///     at #GtkCellAreaClass.get_preferred_width() time. This virtual method
///     should also store any necessary alignments of cell heights for the
///     case that the context is allocated a height.
/// </para>
/// </summary>

public IntPtr get_preferred_height_for_width;
	/// <summary>
/// <para>
/// Calculates the minimum and natural height of the
///     areas cells with the current attributes applied. Essentially this is
///     the same as #GtkCellAreaClass.get_preferred_width() only for areas
///     that are being requested as %GTK_SIZE_REQUEST_WIDTH_FOR_HEIGHT.
/// </para>
/// </summary>

public IntPtr get_preferred_height;
	/// <summary>
/// <para>
/// Calculates the minimum and natural width
///     for the area if the passed @context would be allocated the given
///     height. The same as #GtkCellAreaClass.get_preferred_height_for_width()
///     only for handling requests in the %GTK_SIZE_REQUEST_WIDTH_FOR_HEIGHT
///     mode.
/// </para>
/// </summary>

public IntPtr get_preferred_width_for_height;
	/// <summary>
/// <para>
/// This should be implemented to handle changes in child
///     cell properties for a given #GtkCellRenderer that were previously
///     installed on the #GtkCellAreaClass with gtk_cell_area_class_install_cell_property().
/// </para>
/// </summary>

public IntPtr set_cell_property;
	/// <summary>
/// <para>
/// This should be implemented to report the values of
///     child cell properties for a given child #GtkCellRenderer.
/// </para>
/// </summary>

public IntPtr get_cell_property;
	/// <summary>
/// <para>
/// This virtual method should be implemented to navigate focus from
///     cell to cell inside the #GtkCellArea. The #GtkCellArea should move
///     focus from cell to cell inside the area and return %FALSE if focus
///     logically leaves the area with the following exceptions: When the
///     area contains no activatable cells, the entire area recieves focus.
///     Focus should not be given to cells that are actually “focus siblings”
///     of other sibling cells (see gtk_cell_area_get_focus_from_sibling()).
///     Focus is set by calling gtk_cell_area_set_focus_cell().
/// </para>
/// </summary>

public IntPtr focus;
	/// <summary>
/// <para>
/// Returns whether the #GtkCellArea can respond to
///     #GtkCellAreaClass.activate(), usually this does not need to be
///     implemented since the base class takes care of this however it can
///     be enhanced if the #GtkCellArea subclass can handle activation in
///     other ways than activating its #GtkCellRenderers.
/// </para>
/// </summary>

public IntPtr is_activatable;
	/// <summary>
/// <para>
/// This is called when the layouting widget rendering the
///     #GtkCellArea activates the focus cell (see gtk_cell_area_get_focus_cell()).
/// </para>
/// </summary>

public IntPtr activate;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
	
public IntPtr _gtk_reserved5;
	
public IntPtr _gtk_reserved6;
	
public IntPtr _gtk_reserved7;
	
public IntPtr _gtk_reserved8;
}
