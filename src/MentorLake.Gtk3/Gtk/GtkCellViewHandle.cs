namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkCellView displays a single row of a #GtkTreeModel using a #GtkCellArea
/// and #GtkCellAreaContext. A #GtkCellAreaContext can be provided to the
/// #GtkCellView at construction time in order to keep the cellview in context
/// of a group of cell views, this ensures that the renderers displayed will
/// be properly aligned with eachother (like the aligned cells in the menus
/// of #GtkComboBox).
/// </para>
/// <para>
/// #GtkCellView is #GtkOrientable in order to decide in which orientation
/// the underlying #GtkCellAreaContext should be allocated. Taking the #GtkComboBox
/// menu as an example, cellviews should be oriented horizontally if the menus are
/// listed top-to-bottom and thus all share the same width but may have separate
/// individual heights (left-to-right menus should be allocated vertically since
/// they all share the same height but may have variable widths).
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkCellView has a single CSS node with name cellview.
/// </para>
/// </summary>

public class GtkCellViewHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkCellLayoutHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkCellView widget.
/// </para>
/// </summary>

/// <return>
/// A newly created #GtkCellView widget.
/// </return>

	public static MentorLake.Gtk.GtkCellViewHandle New()
	{
		return GtkCellViewHandleExterns.gtk_cell_view_new();
	}

/// <summary>
/// <para>
/// Creates a new #GtkCellView widget with a specific #GtkCellArea
/// to layout cells and a specific #GtkCellAreaContext.
/// </para>
/// <para>
/// Specifying the same context for a handfull of cells lets
/// the underlying area synchronize the geometry for those cells,
/// in this way alignments with cellviews for other rows are
/// possible.
/// </para>
/// </summary>

/// <param name="area">
/// the #GtkCellArea to layout cells
/// </param>
/// <param name="context">
/// the #GtkCellAreaContext in which to calculate cell geometry
/// </param>
/// <return>
/// A newly created #GtkCellView widget.
/// </return>

	public static MentorLake.Gtk.GtkCellViewHandle NewWithContext(MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkCellAreaContextHandle context)
	{
		return GtkCellViewHandleExterns.gtk_cell_view_new_with_context(area, context);
	}

/// <summary>
/// <para>
/// Creates a new #GtkCellView widget, adds a #GtkCellRendererText
/// to it, and makes it show @markup. The text can be
/// marked up with the [Pango text markup language][PangoMarkupFormat].
/// </para>
/// </summary>

/// <param name="markup">
/// the text to display in the cell view
/// </param>
/// <return>
/// A newly created #GtkCellView widget.
/// </return>

	public static MentorLake.Gtk.GtkCellViewHandle NewWithMarkup(string markup)
	{
		return GtkCellViewHandleExterns.gtk_cell_view_new_with_markup(markup);
	}

/// <summary>
/// <para>
/// Creates a new #GtkCellView widget, adds a #GtkCellRendererPixbuf
/// to it, and makes it show @pixbuf.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// the image to display in the cell view
/// </param>
/// <return>
/// A newly created #GtkCellView widget.
/// </return>

	public static MentorLake.Gtk.GtkCellViewHandle NewWithPixbuf(MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GtkCellViewHandleExterns.gtk_cell_view_new_with_pixbuf(pixbuf);
	}

/// <summary>
/// <para>
/// Creates a new #GtkCellView widget, adds a #GtkCellRendererText
/// to it, and makes it show @text.
/// </para>
/// </summary>

/// <param name="text">
/// the text to display in the cell view
/// </param>
/// <return>
/// A newly created #GtkCellView widget.
/// </return>

	public static MentorLake.Gtk.GtkCellViewHandle NewWithText(string text)
	{
		return GtkCellViewHandleExterns.gtk_cell_view_new_with_text(text);
	}

}

public static class GtkCellViewHandleExtensions
{
/// <summary>
/// <para>
/// Returns a #GtkTreePath referring to the currently
/// displayed row. If no row is currently displayed,
/// %NULL is returned.
/// </para>
/// </summary>

/// <param name="cell_view">
/// a #GtkCellView
/// </param>
/// <return>
/// the currently displayed row or %NULL
/// </return>

	public static MentorLake.Gtk.GtkTreePathHandle GetDisplayedRow(this MentorLake.Gtk.GtkCellViewHandle cell_view)
	{
		if (cell_view.IsInvalid) throw new Exception("Invalid handle (GtkCellViewHandle)");
		return GtkCellViewHandleExterns.gtk_cell_view_get_displayed_row(cell_view);
	}

/// <summary>
/// <para>
/// Gets whether @cell_view is configured to draw all of its
/// cells in a sensitive state.
/// </para>
/// </summary>

/// <param name="cell_view">
/// a #GtkCellView
/// </param>
/// <return>
/// whether @cell_view draws all of its
/// cells in a sensitive state
/// </return>

	public static bool GetDrawSensitive(this MentorLake.Gtk.GtkCellViewHandle cell_view)
	{
		if (cell_view.IsInvalid) throw new Exception("Invalid handle (GtkCellViewHandle)");
		return GtkCellViewHandleExterns.gtk_cell_view_get_draw_sensitive(cell_view);
	}

/// <summary>
/// <para>
/// Gets whether @cell_view is configured to request space
/// to fit the entire #GtkTreeModel.
/// </para>
/// </summary>

/// <param name="cell_view">
/// a #GtkCellView
/// </param>
/// <return>
/// whether @cell_view requests space to fit
/// the entire #GtkTreeModel.
/// </return>

	public static bool GetFitModel(this MentorLake.Gtk.GtkCellViewHandle cell_view)
	{
		if (cell_view.IsInvalid) throw new Exception("Invalid handle (GtkCellViewHandle)");
		return GtkCellViewHandleExterns.gtk_cell_view_get_fit_model(cell_view);
	}

/// <summary>
/// <para>
/// Returns the model for @cell_view. If no model is used %NULL is
/// returned.
/// </para>
/// </summary>

/// <param name="cell_view">
/// a #GtkCellView
/// </param>
/// <return>
/// a #GtkTreeModel used or %NULL
/// </return>

	public static MentorLake.Gtk.GtkTreeModelHandle GetModel(this MentorLake.Gtk.GtkCellViewHandle cell_view)
	{
		if (cell_view.IsInvalid) throw new Exception("Invalid handle (GtkCellViewHandle)");
		return GtkCellViewHandleExterns.gtk_cell_view_get_model(cell_view);
	}

/// <summary>
/// <para>
/// Sets @requisition to the size needed by @cell_view to display
/// the model row pointed to by @path.
/// </para>
/// </summary>

/// <param name="cell_view">
/// a #GtkCellView
/// </param>
/// <param name="path">
/// a #GtkTreePath
/// </param>
/// <param name="requisition">
/// return location for the size
/// </param>
/// <return>
/// %TRUE
/// </return>

	public static bool GetSizeOfRow(this MentorLake.Gtk.GtkCellViewHandle cell_view, MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkRequisition requisition)
	{
		if (cell_view.IsInvalid) throw new Exception("Invalid handle (GtkCellViewHandle)");
		return GtkCellViewHandleExterns.gtk_cell_view_get_size_of_row(cell_view, path, out requisition);
	}

/// <summary>
/// <para>
/// Sets the background color of @view.
/// </para>
/// </summary>

/// <param name="cell_view">
/// a #GtkCellView
/// </param>
/// <param name="color">
/// the new background color
/// </param>

	public static T SetBackgroundColor<T>(this T cell_view, MentorLake.Gdk.GdkColorHandle color) where T : GtkCellViewHandle
	{
		if (cell_view.IsInvalid) throw new Exception("Invalid handle (GtkCellViewHandle)");
		GtkCellViewHandleExterns.gtk_cell_view_set_background_color(cell_view, color);
		return cell_view;
	}

/// <summary>
/// <para>
/// Sets the background color of @cell_view.
/// </para>
/// </summary>

/// <param name="cell_view">
/// a #GtkCellView
/// </param>
/// <param name="rgba">
/// the new background color
/// </param>

	public static T SetBackgroundRgba<T>(this T cell_view, MentorLake.Gdk.GdkRGBAHandle rgba) where T : GtkCellViewHandle
	{
		if (cell_view.IsInvalid) throw new Exception("Invalid handle (GtkCellViewHandle)");
		GtkCellViewHandleExterns.gtk_cell_view_set_background_rgba(cell_view, rgba);
		return cell_view;
	}

/// <summary>
/// <para>
/// Sets the row of the model that is currently displayed
/// by the #GtkCellView. If the path is unset, then the
/// contents of the cellview “stick” at their last value;
/// this is not normally a desired result, but may be
/// a needed intermediate state if say, the model for
/// the #GtkCellView becomes temporarily empty.
/// </para>
/// </summary>

/// <param name="cell_view">
/// a #GtkCellView
/// </param>
/// <param name="path">
/// a #GtkTreePath or %NULL to unset.
/// </param>

	public static T SetDisplayedRow<T>(this T cell_view, MentorLake.Gtk.GtkTreePathHandle path) where T : GtkCellViewHandle
	{
		if (cell_view.IsInvalid) throw new Exception("Invalid handle (GtkCellViewHandle)");
		GtkCellViewHandleExterns.gtk_cell_view_set_displayed_row(cell_view, path);
		return cell_view;
	}

/// <summary>
/// <para>
/// Sets whether @cell_view should draw all of its
/// cells in a sensitive state, this is used by #GtkComboBox menus
/// to ensure that rows with insensitive cells that contain
/// children appear sensitive in the parent menu item.
/// </para>
/// </summary>

/// <param name="cell_view">
/// a #GtkCellView
/// </param>
/// <param name="draw_sensitive">
/// whether to draw all cells in a sensitive state.
/// </param>

	public static T SetDrawSensitive<T>(this T cell_view, bool draw_sensitive) where T : GtkCellViewHandle
	{
		if (cell_view.IsInvalid) throw new Exception("Invalid handle (GtkCellViewHandle)");
		GtkCellViewHandleExterns.gtk_cell_view_set_draw_sensitive(cell_view, draw_sensitive);
		return cell_view;
	}

/// <summary>
/// <para>
/// Sets whether @cell_view should request space to fit the entire #GtkTreeModel.
/// </para>
/// <para>
/// This is used by #GtkComboBox to ensure that the cell view displayed on
/// the combo box’s button always gets enough space and does not resize
/// when selection changes.
/// </para>
/// </summary>

/// <param name="cell_view">
/// a #GtkCellView
/// </param>
/// <param name="fit_model">
/// whether @cell_view should request space for the whole model.
/// </param>

	public static T SetFitModel<T>(this T cell_view, bool fit_model) where T : GtkCellViewHandle
	{
		if (cell_view.IsInvalid) throw new Exception("Invalid handle (GtkCellViewHandle)");
		GtkCellViewHandleExterns.gtk_cell_view_set_fit_model(cell_view, fit_model);
		return cell_view;
	}

/// <summary>
/// <para>
/// Sets the model for @cell_view.  If @cell_view already has a model
/// set, it will remove it before setting the new model.  If @model is
/// %NULL, then it will unset the old model.
/// </para>
/// </summary>

/// <param name="cell_view">
/// a #GtkCellView
/// </param>
/// <param name="model">
/// a #GtkTreeModel
/// </param>

	public static T SetModel<T>(this T cell_view, MentorLake.Gtk.GtkTreeModelHandle model) where T : GtkCellViewHandle
	{
		if (cell_view.IsInvalid) throw new Exception("Invalid handle (GtkCellViewHandle)");
		GtkCellViewHandleExterns.gtk_cell_view_set_model(cell_view, model);
		return cell_view;
	}

}

internal class GtkCellViewHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))]
	internal static extern MentorLake.Gtk.GtkCellViewHandle gtk_cell_view_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))]
	internal static extern MentorLake.Gtk.GtkCellViewHandle gtk_cell_view_new_with_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))]
	internal static extern MentorLake.Gtk.GtkCellViewHandle gtk_cell_view_new_with_markup(string markup);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))]
	internal static extern MentorLake.Gtk.GtkCellViewHandle gtk_cell_view_new_with_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))]
	internal static extern MentorLake.Gtk.GtkCellViewHandle gtk_cell_view_new_with_text(string text);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_cell_view_get_displayed_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))] MentorLake.Gtk.GtkCellViewHandle cell_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_view_get_draw_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))] MentorLake.Gtk.GtkCellViewHandle cell_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_view_get_fit_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))] MentorLake.Gtk.GtkCellViewHandle cell_view);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))]
	internal static extern MentorLake.Gtk.GtkTreeModelHandle gtk_cell_view_get_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))] MentorLake.Gtk.GtkCellViewHandle cell_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_view_get_size_of_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))] MentorLake.Gtk.GtkCellViewHandle cell_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkRequisition requisition);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_view_set_background_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))] MentorLake.Gtk.GtkCellViewHandle cell_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_view_set_background_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))] MentorLake.Gtk.GtkCellViewHandle cell_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle rgba);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_view_set_displayed_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))] MentorLake.Gtk.GtkCellViewHandle cell_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_view_set_draw_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))] MentorLake.Gtk.GtkCellViewHandle cell_view, bool draw_sensitive);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_view_set_fit_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))] MentorLake.Gtk.GtkCellViewHandle cell_view, bool fit_model);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_view_set_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))] MentorLake.Gtk.GtkCellViewHandle cell_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model);

}
