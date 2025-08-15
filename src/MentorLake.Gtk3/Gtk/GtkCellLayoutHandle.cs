namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkCellLayout is an interface to be implemented by all objects which
/// want to provide a #GtkTreeViewColumn like API for packing cells,
/// setting attributes and data funcs.
/// </para>
/// <para>
/// One of the notable features provided by implementations of
/// GtkCellLayout are attributes. Attributes let you set the properties
/// in flexible ways. They can just be set to constant values like regular
/// properties. But they can also be mapped to a column of the underlying
/// tree model with gtk_cell_layout_set_attributes(), which means that the value
/// of the attribute can change from cell to cell as they are rendered by
/// the cell renderer. Finally, it is possible to specify a function with
/// gtk_cell_layout_set_cell_data_func() that is called to determine the
/// value of the attribute for each cell that is rendered.
/// </para>
/// <para>
/// # GtkCellLayouts as GtkBuildable
/// </para>
/// <para>
/// Implementations of GtkCellLayout which also implement the GtkBuildable
/// interface (#GtkCellView, #GtkIconView, #GtkComboBox,
/// #GtkEntryCompletion, #GtkTreeViewColumn) accept GtkCellRenderer objects
/// as `&amp;lt;child&amp;gt;` elements in UI definitions. They support a custom `&amp;lt;attributes&amp;gt;`
/// element for their children, which can contain multiple `&amp;lt;attribute&amp;gt;`
/// elements. Each `&amp;lt;attribute&amp;gt;` element has a name attribute which specifies
/// a property of the cell renderer; the content of the element is the
/// attribute value.
/// </para>
/// <para>
/// This is an example of a UI definition fragment specifying attributes:
/// </para>
/// <code>
/// &amp;lt;object class=&quot;GtkCellView&quot;&amp;gt;
/// &amp;lt;object class=&quot;GtkCellView&quot;&amp;gt;
///   &amp;lt;child&amp;gt;
///     &amp;lt;object class=&quot;GtkCellRendererText&quot;/&amp;gt;
///     &amp;lt;attributes&amp;gt;
///       &amp;lt;attribute name=&quot;text&quot;&amp;gt;0&amp;lt;/attribute&amp;gt;
///     &amp;lt;/attributes&amp;gt;
///   &amp;lt;/child&amp;gt;
/// &amp;lt;/object&amp;gt;
/// </code>
/// <para>
/// Furthermore for implementations of GtkCellLayout that use a #GtkCellArea
/// to lay out cells (all GtkCellLayouts in GTK+ use a GtkCellArea)
/// [cell properties][cell-properties] can also be defined in the format by
/// specifying the custom `&amp;lt;cell-packing&amp;gt;` attribute which can contain multiple
/// `&amp;lt;property&amp;gt;` elements defined in the normal way.
/// </para>
/// <para>
/// Here is a UI definition fragment specifying cell properties:
/// </para>
/// <code>
/// &amp;lt;object class=&quot;GtkTreeViewColumn&quot;&amp;gt;
/// &amp;lt;object class=&quot;GtkTreeViewColumn&quot;&amp;gt;
///   &amp;lt;child&amp;gt;
///     &amp;lt;object class=&quot;GtkCellRendererText&quot;/&amp;gt;
///     &amp;lt;cell-packing&amp;gt;
///       &amp;lt;property name=&quot;align&quot;&amp;gt;True&amp;lt;/property&amp;gt;
///       &amp;lt;property name=&quot;expand&quot;&amp;gt;False&amp;lt;/property&amp;gt;
///     &amp;lt;/cell-packing&amp;gt;
///   &amp;lt;/child&amp;gt;
/// &amp;lt;/object&amp;gt;
/// </code>
/// <para>
/// # Subclassing GtkCellLayout implementations
/// </para>
/// <para>
/// When subclassing a widget that implements #GtkCellLayout like
/// #GtkIconView or #GtkComboBox, there are some considerations related
/// to the fact that these widgets internally use a #GtkCellArea.
/// The cell area is exposed as a construct-only property by these
/// widgets. This means that it is possible to e.g. do
/// </para>
/// <code>
/// combo = g_object_new (GTK_TYPE_COMBO_BOX, &quot;cell-area&quot;, my_cell_area, NULL);
/// combo = g_object_new (GTK_TYPE_COMBO_BOX, &quot;cell-area&quot;, my_cell_area, NULL);
/// </code>
/// <para>
/// to use a custom cell area with a combo box. But construct properties
/// are only initialized after instance init()
/// functions have run, which means that using functions which rely on
/// the existence of the cell area in your subclass’ init() function will
/// cause the default cell area to be instantiated. In this case, a provided
/// construct property value will be ignored (with a warning, to alert
/// you to the problem).
/// </para>
/// <code>
/// static void
/// static void
/// my_combo_box_init (MyComboBox *b)
/// {
///   GtkCellRenderer *cell;
/// 
///   cell = gtk_cell_renderer_pixbuf_new ();
///   // The following call causes the default cell area for combo boxes,
///   // a GtkCellAreaBox, to be instantiated
///   gtk_cell_layout_pack_start (GTK_CELL_LAYOUT (b), cell, FALSE);
///   ...
/// }
/// 
/// GtkWidget *
/// my_combo_box_new (GtkCellArea *area)
/// {
///   // This call is going to cause a warning about area being ignored
///   return g_object_new (MY_TYPE_COMBO_BOX, &quot;cell-area&quot;, area, NULL);
/// }
/// </code>
/// <para>
/// If supporting alternative cell areas with your derived widget is
/// not important, then this does not have to concern you. If you want
/// to support alternative cell areas, you can do so by moving the
/// problematic calls out of init() and into a constructor()
/// for your class.
/// </para>
/// </summary>

public interface GtkCellLayoutHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkCellLayoutHandleImpl : BaseSafeHandle, GtkCellLayoutHandle
{
}

public static class GtkCellLayoutHandleExtensions
{
/// <summary>
/// <para>
/// Adds an attribute mapping to the list in @cell_layout.
/// </para>
/// <para>
/// The @column is the column of the model to get a value from, and the
/// @attribute is the parameter on @cell to be set from the value. So for
/// example if column 2 of the model contains strings, you could have the
/// “text” attribute of a #GtkCellRendererText get its values from column 2.
/// </para>
/// </summary>

/// <param name="cell_layout">
/// a #GtkCellLayout
/// </param>
/// <param name="cell">
/// a #GtkCellRenderer
/// </param>
/// <param name="attribute">
/// an attribute on the renderer
/// </param>
/// <param name="column">
/// the column position on the model to get the attribute from
/// </param>

	public static T AddAttribute<T>(this T cell_layout, MentorLake.Gtk.GtkCellRendererHandle cell, string attribute, int column) where T : GtkCellLayoutHandle
	{
		if (cell_layout.IsInvalid) throw new Exception("Invalid handle (GtkCellLayoutHandle)");
		GtkCellLayoutHandleExterns.gtk_cell_layout_add_attribute(cell_layout, cell, attribute, column);
		return cell_layout;
	}

/// <summary>
/// <para>
/// Unsets all the mappings on all renderers on @cell_layout and
/// removes all renderers from @cell_layout.
/// </para>
/// </summary>

/// <param name="cell_layout">
/// a #GtkCellLayout
/// </param>

	public static T Clear<T>(this T cell_layout) where T : GtkCellLayoutHandle
	{
		if (cell_layout.IsInvalid) throw new Exception("Invalid handle (GtkCellLayoutHandle)");
		GtkCellLayoutHandleExterns.gtk_cell_layout_clear(cell_layout);
		return cell_layout;
	}

/// <summary>
/// <para>
/// Clears all existing attributes previously set with
/// gtk_cell_layout_set_attributes().
/// </para>
/// </summary>

/// <param name="cell_layout">
/// a #GtkCellLayout
/// </param>
/// <param name="cell">
/// a #GtkCellRenderer to clear the attribute mapping on
/// </param>

	public static T ClearAttributes<T>(this T cell_layout, MentorLake.Gtk.GtkCellRendererHandle cell) where T : GtkCellLayoutHandle
	{
		if (cell_layout.IsInvalid) throw new Exception("Invalid handle (GtkCellLayoutHandle)");
		GtkCellLayoutHandleExterns.gtk_cell_layout_clear_attributes(cell_layout, cell);
		return cell_layout;
	}

/// <summary>
/// <para>
/// Returns the underlying #GtkCellArea which might be @cell_layout
/// if called on a #GtkCellArea or might be %NULL if no #GtkCellArea
/// is used by @cell_layout.
/// </para>
/// </summary>

/// <param name="cell_layout">
/// a #GtkCellLayout
/// </param>
/// <return>
/// the cell area used by @cell_layout,
/// or %NULL in case no cell area is used.
/// </return>

	public static MentorLake.Gtk.GtkCellAreaHandle GetArea(this MentorLake.Gtk.GtkCellLayoutHandle cell_layout)
	{
		if (cell_layout.IsInvalid) throw new Exception("Invalid handle (GtkCellLayoutHandle)");
		return GtkCellLayoutHandleExterns.gtk_cell_layout_get_area(cell_layout);
	}

/// <summary>
/// <para>
/// Returns the cell renderers which have been added to @cell_layout.
/// </para>
/// </summary>

/// <param name="cell_layout">
/// a #GtkCellLayout
/// </param>
/// <return>
/// 
///     a list of cell renderers. The list, but not the renderers has
///     been newly allocated and should be freed with g_list_free()
///     when no longer needed.
/// </return>

	public static MentorLake.GLib.GListHandle GetCells(this MentorLake.Gtk.GtkCellLayoutHandle cell_layout)
	{
		if (cell_layout.IsInvalid) throw new Exception("Invalid handle (GtkCellLayoutHandle)");
		return GtkCellLayoutHandleExterns.gtk_cell_layout_get_cells(cell_layout);
	}

/// <summary>
/// <para>
/// Adds the @cell to the end of @cell_layout. If @expand is %FALSE, then the
/// @cell is allocated no more space than it needs. Any unused space is
/// divided evenly between cells for which @expand is %TRUE.
/// </para>
/// <para>
/// Note that reusing the same cell renderer is not supported.
/// </para>
/// </summary>

/// <param name="cell_layout">
/// a #GtkCellLayout
/// </param>
/// <param name="cell">
/// a #GtkCellRenderer
/// </param>
/// <param name="expand">
/// %TRUE if @cell is to be given extra space allocated to @cell_layout
/// </param>

	public static T PackEnd<T>(this T cell_layout, MentorLake.Gtk.GtkCellRendererHandle cell, bool expand) where T : GtkCellLayoutHandle
	{
		if (cell_layout.IsInvalid) throw new Exception("Invalid handle (GtkCellLayoutHandle)");
		GtkCellLayoutHandleExterns.gtk_cell_layout_pack_end(cell_layout, cell, expand);
		return cell_layout;
	}

/// <summary>
/// <para>
/// Packs the @cell into the beginning of @cell_layout. If @expand is %FALSE,
/// then the @cell is allocated no more space than it needs. Any unused space
/// is divided evenly between cells for which @expand is %TRUE.
/// </para>
/// <para>
/// Note that reusing the same cell renderer is not supported.
/// </para>
/// </summary>

/// <param name="cell_layout">
/// a #GtkCellLayout
/// </param>
/// <param name="cell">
/// a #GtkCellRenderer
/// </param>
/// <param name="expand">
/// %TRUE if @cell is to be given extra space allocated to @cell_layout
/// </param>

	public static T PackStart<T>(this T cell_layout, MentorLake.Gtk.GtkCellRendererHandle cell, bool expand) where T : GtkCellLayoutHandle
	{
		if (cell_layout.IsInvalid) throw new Exception("Invalid handle (GtkCellLayoutHandle)");
		GtkCellLayoutHandleExterns.gtk_cell_layout_pack_start(cell_layout, cell, expand);
		return cell_layout;
	}

/// <summary>
/// <para>
/// Re-inserts @cell at @position.
/// </para>
/// <para>
/// Note that @cell has already to be packed into @cell_layout
/// for this to function properly.
/// </para>
/// </summary>

/// <param name="cell_layout">
/// a #GtkCellLayout
/// </param>
/// <param name="cell">
/// a #GtkCellRenderer to reorder
/// </param>
/// <param name="position">
/// new position to insert @cell at
/// </param>

	public static T Reorder<T>(this T cell_layout, MentorLake.Gtk.GtkCellRendererHandle cell, int position) where T : GtkCellLayoutHandle
	{
		if (cell_layout.IsInvalid) throw new Exception("Invalid handle (GtkCellLayoutHandle)");
		GtkCellLayoutHandleExterns.gtk_cell_layout_reorder(cell_layout, cell, position);
		return cell_layout;
	}

/// <summary>
/// <para>
/// Sets the attributes in list as the attributes of @cell_layout.
/// </para>
/// <para>
/// The attributes should be in attribute/column order, as in
/// gtk_cell_layout_add_attribute(). All existing attributes are
/// removed, and replaced with the new attributes.
/// </para>
/// </summary>

/// <param name="cell_layout">
/// a #GtkCellLayout
/// </param>
/// <param name="cell">
/// a #GtkCellRenderer
/// </param>
/// <param name="@__arglist">
/// a %NULL-terminated list of attributes
/// </param>

	public static T SetAttributes<T>(this T cell_layout, MentorLake.Gtk.GtkCellRendererHandle cell, IntPtr @__arglist) where T : GtkCellLayoutHandle
	{
		if (cell_layout.IsInvalid) throw new Exception("Invalid handle (GtkCellLayoutHandle)");
		GtkCellLayoutHandleExterns.gtk_cell_layout_set_attributes(cell_layout, cell, @__arglist);
		return cell_layout;
	}

/// <summary>
/// <para>
/// Sets the #GtkCellLayoutDataFunc to use for @cell_layout.
/// </para>
/// <para>
/// This function is used instead of the standard attributes mapping
/// for setting the column value, and should set the value of @cell_layout’s
/// cell renderer(s) as appropriate.
/// </para>
/// <para>
/// @func may be %NULL to remove a previously set function.
/// </para>
/// </summary>

/// <param name="cell_layout">
/// a #GtkCellLayout
/// </param>
/// <param name="cell">
/// a #GtkCellRenderer
/// </param>
/// <param name="func">
/// the #GtkCellLayoutDataFunc to use, or %NULL
/// </param>
/// <param name="func_data">
/// user data for @func
/// </param>
/// <param name="destroy">
/// destroy notify for @func_data
/// </param>

	public static T SetCellDataFunc<T>(this T cell_layout, MentorLake.Gtk.GtkCellRendererHandle cell, MentorLake.Gtk.GtkCellLayoutDataFunc func, IntPtr func_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkCellLayoutHandle
	{
		if (cell_layout.IsInvalid) throw new Exception("Invalid handle (GtkCellLayoutHandle)");
		GtkCellLayoutHandleExterns.gtk_cell_layout_set_cell_data_func(cell_layout, cell, func, func_data, destroy);
		return cell_layout;
	}

}

internal class GtkCellLayoutHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_layout_add_attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellLayoutHandleImpl>))] MentorLake.Gtk.GtkCellLayoutHandle cell_layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, string attribute, int column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_layout_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellLayoutHandleImpl>))] MentorLake.Gtk.GtkCellLayoutHandle cell_layout);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_layout_clear_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellLayoutHandleImpl>))] MentorLake.Gtk.GtkCellLayoutHandle cell_layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))]
	internal static extern MentorLake.Gtk.GtkCellAreaHandle gtk_cell_layout_get_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellLayoutHandleImpl>))] MentorLake.Gtk.GtkCellLayoutHandle cell_layout);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_cell_layout_get_cells([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellLayoutHandleImpl>))] MentorLake.Gtk.GtkCellLayoutHandle cell_layout);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_layout_pack_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellLayoutHandleImpl>))] MentorLake.Gtk.GtkCellLayoutHandle cell_layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, bool expand);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_layout_pack_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellLayoutHandleImpl>))] MentorLake.Gtk.GtkCellLayoutHandle cell_layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, bool expand);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_layout_reorder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellLayoutHandleImpl>))] MentorLake.Gtk.GtkCellLayoutHandle cell_layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_layout_set_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellLayoutHandleImpl>))] MentorLake.Gtk.GtkCellLayoutHandle cell_layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_layout_set_cell_data_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellLayoutHandleImpl>))] MentorLake.Gtk.GtkCellLayoutHandle cell_layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, MentorLake.Gtk.GtkCellLayoutDataFunc func, IntPtr func_data, MentorLake.GLib.GDestroyNotify destroy);

}
