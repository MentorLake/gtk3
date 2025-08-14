namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The GtkTreeViewColumn object represents a visible column in a #GtkTreeView widget.
/// It allows to set properties of the column header, and functions as a holding pen for
/// the cell renderers which determine how the data in the column is displayed.
/// </para>
/// <para>
/// Please refer to the [tree widget conceptual overview](TreeWidget.html)
/// for an overview of all the objects and data types related to the tree widget and how
/// they work together.
/// </para>
/// </summary>

public class GtkTreeViewColumnHandle : GInitiallyUnownedHandle, GtkBuildableHandle, GtkCellLayoutHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkTreeViewColumn.
/// </para>
/// </summary>

/// <return>
/// A newly created #GtkTreeViewColumn.
/// </return>

	public static MentorLake.Gtk.GtkTreeViewColumnHandle New()
	{
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_new();
	}

/// <summary>
/// <para>
/// Creates a new #GtkTreeViewColumn using @area to render its cells.
/// </para>
/// </summary>

/// <param name="area">
/// the #GtkCellArea that the newly created column should use to layout cells.
/// </param>
/// <return>
/// A newly created #GtkTreeViewColumn.
/// </return>

	public static MentorLake.Gtk.GtkTreeViewColumnHandle NewWithArea(MentorLake.Gtk.GtkCellAreaHandle area)
	{
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_new_with_area(area);
	}

/// <summary>
/// <para>
/// Creates a new #GtkTreeViewColumn with a number of default values.
/// This is equivalent to calling gtk_tree_view_column_set_title(),
/// gtk_tree_view_column_pack_start(), and
/// gtk_tree_view_column_set_attributes() on the newly created #GtkTreeViewColumn.
/// </para>
/// <para>
/// Here’s a simple example:
/// |[<!-- language="C" -->
///  enum { TEXT_COLUMN, COLOR_COLUMN, N_COLUMNS };
///  // ...
///  {
///    GtkTreeViewColumn *column;
///    GtkCellRenderer   *renderer = gtk_cell_renderer_text_new ();
/// </para>
/// <para>
///    column = gtk_tree_view_column_new_with_attributes ("Title",
///                                                       renderer,
///                                                       "text", TEXT_COLUMN,
///                                                       "foreground", COLOR_COLUMN,
///                                                       NULL);
///  }
/// ]|
/// </para>
/// </summary>

/// <param name="title">
/// The title to set the header to
/// </param>
/// <param name="cell">
/// The #GtkCellRenderer
/// </param>
/// <param name="@__arglist">
/// A %NULL-terminated list of attributes
/// </param>
/// <return>
/// A newly created #GtkTreeViewColumn.
/// </return>

	public static MentorLake.Gtk.GtkTreeViewColumnHandle NewWithAttributes(string title, MentorLake.Gtk.GtkCellRendererHandle cell, IntPtr @__arglist)
	{
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_new_with_attributes(title, cell, @__arglist);
	}

}
public static class GtkTreeViewColumnHandleSignalExtensions
{

	public static IObservable<GtkTreeViewColumnHandleSignalStructs.ClickedSignal> Signal_Clicked(this GtkTreeViewColumnHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewColumnHandleSignalStructs.ClickedSignal> obs) =>
		{
			GtkTreeViewColumnHandleSignalDelegates.clicked handler = ( MentorLake.Gtk.GtkTreeViewColumnHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewColumnHandleSignalStructs.ClickedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "clicked", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkTreeViewColumnHandleSignalStructs
{

public class ClickedSignal
{

	public MentorLake.Gtk.GtkTreeViewColumnHandle Self;

	public IntPtr UserData;
}
}

public static class GtkTreeViewColumnHandleSignalDelegates
{


/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void clicked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle self, IntPtr user_data);

}


public static class GtkTreeViewColumnHandleExtensions
{
/// <summary>
/// <para>
/// Adds an attribute mapping to the list in @tree_column.  The @column is the
/// column of the model to get a value from, and the @attribute is the
/// parameter on @cell_renderer to be set from the value. So for example
/// if column 2 of the model contains strings, you could have the
/// “text” attribute of a #GtkCellRendererText get its values from
/// column 2.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <param name="cell_renderer">
/// the #GtkCellRenderer to set attributes on
/// </param>
/// <param name="attribute">
/// An attribute on the renderer
/// </param>
/// <param name="column">
/// The column position on the model to get the attribute from.
/// </param>

	public static T AddAttribute<T>(this T tree_column, MentorLake.Gtk.GtkCellRendererHandle cell_renderer, string attribute, int column) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_add_attribute(tree_column, cell_renderer, attribute, column);
		return tree_column;
	}

/// <summary>
/// <para>
/// Obtains the horizontal position and size of a cell in a column. If the
/// cell is not found in the column, @start_pos and @width are not changed and
/// %FALSE is returned.
/// </para>
/// </summary>

/// <param name="tree_column">
/// a #GtkTreeViewColumn
/// </param>
/// <param name="cell_renderer">
/// a #GtkCellRenderer
/// </param>
/// <param name="x_offset">
/// return location for the horizontal
///            position of @cell within @tree_column, may be %NULL
/// </param>
/// <param name="width">
/// return location for the width of @cell,
///         may be %NULL
/// </param>
/// <return>
/// %TRUE if @cell belongs to @tree_column.
/// </return>

	public static bool CellGetPosition(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, MentorLake.Gtk.GtkCellRendererHandle cell_renderer, out int x_offset, out int width)
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_cell_get_position(tree_column, cell_renderer, out x_offset, out width);
	}

/// <summary>
/// <para>
/// Obtains the width and height needed to render the column.  This is used
/// primarily by the #GtkTreeView.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <param name="cell_area">
/// The area a cell in the column will be allocated, or %NULL
/// </param>
/// <param name="x_offset">
/// location to return x offset of a cell relative to @cell_area, or %NULL
/// </param>
/// <param name="y_offset">
/// location to return y offset of a cell relative to @cell_area, or %NULL
/// </param>
/// <param name="width">
/// location to return width needed to render a cell, or %NULL
/// </param>
/// <param name="height">
/// location to return height needed to render a cell, or %NULL
/// </param>

	public static T CellGetSize<T>(this T tree_column, MentorLake.Gdk.GdkRectangleHandle cell_area, out int x_offset, out int y_offset, out int width, out int height) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_cell_get_size(tree_column, cell_area, out x_offset, out y_offset, out width, out height);
		return tree_column;
	}

/// <summary>
/// <para>
/// Returns %TRUE if any of the cells packed into the @tree_column are visible.
/// For this to be meaningful, you must first initialize the cells with
/// gtk_tree_view_column_cell_set_cell_data()
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn
/// </param>
/// <return>
/// %TRUE, if any of the cells packed into the @tree_column are currently visible
/// </return>

	public static bool CellIsVisible(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_cell_is_visible(tree_column);
	}

/// <summary>
/// <para>
/// Sets the cell renderer based on the @tree_model and @iter.  That is, for
/// every attribute mapping in @tree_column, it will get a value from the set
/// column on the @iter, and use that value to set the attribute on the cell
/// renderer.  This is used primarily by the #GtkTreeView.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <param name="tree_model">
/// The #GtkTreeModel to to get the cell renderers attributes from.
/// </param>
/// <param name="iter">
/// The #GtkTreeIter to to get the cell renderer’s attributes from.
/// </param>
/// <param name="is_expander">
/// %TRUE, if the row has children
/// </param>
/// <param name="is_expanded">
/// %TRUE, if the row has visible children
/// </param>

	public static T CellSetCellData<T>(this T tree_column, MentorLake.Gtk.GtkTreeModelHandle tree_model, MentorLake.Gtk.GtkTreeIterHandle iter, bool is_expander, bool is_expanded) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_cell_set_cell_data(tree_column, tree_model, iter, is_expander, is_expanded);
		return tree_column;
	}

/// <summary>
/// <para>
/// Unsets all the mappings on all renderers on the @tree_column.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn
/// </param>

	public static T Clear<T>(this T tree_column) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_clear(tree_column);
		return tree_column;
	}

/// <summary>
/// <para>
/// Clears all existing attributes previously set with
/// gtk_tree_view_column_set_attributes().
/// </para>
/// </summary>

/// <param name="tree_column">
/// a #GtkTreeViewColumn
/// </param>
/// <param name="cell_renderer">
/// a #GtkCellRenderer to clear the attribute mapping on.
/// </param>

	public static T ClearAttributes<T>(this T tree_column, MentorLake.Gtk.GtkCellRendererHandle cell_renderer) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_clear_attributes(tree_column, cell_renderer);
		return tree_column;
	}

/// <summary>
/// <para>
/// Emits the “clicked” signal on the column.  This function will only work if
/// @tree_column is clickable.
/// </para>
/// </summary>

/// <param name="tree_column">
/// a #GtkTreeViewColumn
/// </param>

	public static T Clicked<T>(this T tree_column) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_clicked(tree_column);
		return tree_column;
	}

/// <summary>
/// <para>
/// Sets the current keyboard focus to be at @cell, if the column contains
/// 2 or more editable and activatable cells.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn
/// </param>
/// <param name="cell">
/// A #GtkCellRenderer
/// </param>

	public static T FocusCell<T>(this T tree_column, MentorLake.Gtk.GtkCellRendererHandle cell) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_focus_cell(tree_column, cell);
		return tree_column;
	}

/// <summary>
/// <para>
/// Returns the current x alignment of @tree_column.  This value can range
/// between 0.0 and 1.0.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <return>
/// The current alignent of @tree_column.
/// </return>

	public static float GetAlignment(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_alignment(tree_column);
	}

/// <summary>
/// <para>
/// Returns the button used in the treeview column header
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn
/// </param>
/// <return>
/// The button for the column header.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetButton(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_button(tree_column);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the user can click on the header for the column.
/// </para>
/// </summary>

/// <param name="tree_column">
/// a #GtkTreeViewColumn
/// </param>
/// <return>
/// %TRUE if user can click the column header.
/// </return>

	public static bool GetClickable(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_clickable(tree_column);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the column expands to fill available space.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <return>
/// %TRUE if the column expands to fill available space.
/// </return>

	public static bool GetExpand(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_expand(tree_column);
	}

/// <summary>
/// <para>
/// Gets the fixed width of the column.  This may not be the actual displayed
/// width of the column; for that, use gtk_tree_view_column_get_width().
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <return>
/// The fixed width of the column.
/// </return>

	public static int GetFixedWidth(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_fixed_width(tree_column);
	}

/// <summary>
/// <para>
/// Returns the maximum width in pixels of the @tree_column, or -1 if no maximum
/// width is set.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <return>
/// The maximum width of the @tree_column.
/// </return>

	public static int GetMaxWidth(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_max_width(tree_column);
	}

/// <summary>
/// <para>
/// Returns the minimum width in pixels of the @tree_column, or -1 if no minimum
/// width is set.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <return>
/// The minimum width of the @tree_column.
/// </return>

	public static int GetMinWidth(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_min_width(tree_column);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the @tree_column can be reordered by the user.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn
/// </param>
/// <return>
/// %TRUE if the @tree_column can be reordered by the user.
/// </return>

	public static bool GetReorderable(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_reorderable(tree_column);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the @tree_column can be resized by the end user.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn
/// </param>
/// <return>
/// %TRUE, if the @tree_column can be resized.
/// </return>

	public static bool GetResizable(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_resizable(tree_column);
	}

/// <summary>
/// <para>
/// Returns the current type of @tree_column.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <return>
/// The type of @tree_column.
/// </return>

	public static MentorLake.Gtk.GtkTreeViewColumnSizing GetSizing(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_sizing(tree_column);
	}

/// <summary>
/// <para>
/// Gets the logical @sort_column_id that the model sorts on when this
/// column is selected for sorting.
/// See gtk_tree_view_column_set_sort_column_id().
/// </para>
/// </summary>

/// <param name="tree_column">
/// a #GtkTreeViewColumn
/// </param>
/// <return>
/// the current @sort_column_id for this column, or -1 if
///               this column can’t be used for sorting.
/// </return>

	public static int GetSortColumnId(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_sort_column_id(tree_column);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_tree_view_column_set_sort_indicator().
/// </para>
/// </summary>

/// <param name="tree_column">
/// a #GtkTreeViewColumn
/// </param>
/// <return>
/// whether the sort indicator arrow is displayed
/// </return>

	public static bool GetSortIndicator(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_sort_indicator(tree_column);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_tree_view_column_set_sort_order().
/// </para>
/// </summary>

/// <param name="tree_column">
/// a #GtkTreeViewColumn
/// </param>
/// <return>
/// the sort order the sort indicator is indicating
/// </return>

	public static MentorLake.Gtk.GtkSortType GetSortOrder(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_sort_order(tree_column);
	}

/// <summary>
/// <para>
/// Returns the spacing of @tree_column.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <return>
/// the spacing of @tree_column.
/// </return>

	public static int GetSpacing(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_spacing(tree_column);
	}

/// <summary>
/// <para>
/// Returns the title of the widget.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <return>
/// the title of the column. This string should not be
/// modified or freed.
/// </return>

	public static string GetTitle(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_title(tree_column);
	}

/// <summary>
/// <para>
/// Returns the #GtkTreeView wherein @tree_column has been inserted.
/// If @column is currently not inserted in any tree view, %NULL is
/// returned.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn
/// </param>
/// <return>
/// The tree view wherein @column has
///     been inserted if any, %NULL otherwise.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetTreeView(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_tree_view(tree_column);
	}

/// <summary>
/// <para>
/// Returns %TRUE if @tree_column is visible.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <return>
/// whether the column is visible or not.  If it is visible, then
/// the tree will show the column.
/// </return>

	public static bool GetVisible(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_visible(tree_column);
	}

/// <summary>
/// <para>
/// Returns the #GtkWidget in the button on the column header.
/// If a custom widget has not been set then %NULL is returned.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <return>
/// The #GtkWidget in the column
///     header, or %NULL
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetWidget(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_widget(tree_column);
	}

/// <summary>
/// <para>
/// Returns the current size of @tree_column in pixels.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <return>
/// The current width of @tree_column.
/// </return>

	public static int GetWidth(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_width(tree_column);
	}

/// <summary>
/// <para>
/// Returns the current X offset of @tree_column in pixels.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <return>
/// The current X offset of @tree_column.
/// </return>

	public static int GetXOffset(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_x_offset(tree_column);
	}

/// <summary>
/// <para>
/// Adds the @cell to end of the column. If @expand is %FALSE, then the @cell
/// is allocated no more space than it needs. Any unused space is divided
/// evenly between cells for which @expand is %TRUE.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <param name="cell">
/// The #GtkCellRenderer.
/// </param>
/// <param name="expand">
/// %TRUE if @cell is to be given extra space allocated to @tree_column.
/// </param>

	public static T PackEnd<T>(this T tree_column, MentorLake.Gtk.GtkCellRendererHandle cell, bool expand) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_pack_end(tree_column, cell, expand);
		return tree_column;
	}

/// <summary>
/// <para>
/// Packs the @cell into the beginning of the column. If @expand is %FALSE, then
/// the @cell is allocated no more space than it needs. Any unused space is divided
/// evenly between cells for which @expand is %TRUE.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <param name="cell">
/// The #GtkCellRenderer.
/// </param>
/// <param name="expand">
/// %TRUE if @cell is to be given extra space allocated to @tree_column.
/// </param>

	public static T PackStart<T>(this T tree_column, MentorLake.Gtk.GtkCellRendererHandle cell, bool expand) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_pack_start(tree_column, cell, expand);
		return tree_column;
	}

/// <summary>
/// <para>
/// Flags the column, and the cell renderers added to this column, to have
/// their sizes renegotiated.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn
/// </param>

	public static T QueueResize<T>(this T tree_column) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_queue_resize(tree_column);
		return tree_column;
	}

/// <summary>
/// <para>
/// Sets the alignment of the title or custom widget inside the column header.
/// The alignment determines its location inside the button -- 0.0 for left, 0.5
/// for center, 1.0 for right.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <param name="xalign">
/// The alignment, which is between [0.0 and 1.0] inclusive.
/// </param>

	public static T SetAlignment<T>(this T tree_column, float xalign) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_alignment(tree_column, xalign);
		return tree_column;
	}

/// <summary>
/// <para>
/// Sets the attributes in the list as the attributes of @tree_column.
/// The attributes should be in attribute/column order, as in
/// gtk_tree_view_column_add_attribute(). All existing attributes
/// are removed, and replaced with the new attributes.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn
/// </param>
/// <param name="cell_renderer">
/// the #GtkCellRenderer we’re setting the attributes of
/// </param>
/// <param name="@__arglist">
/// A %NULL-terminated list of attributes
/// </param>

	public static T SetAttributes<T>(this T tree_column, MentorLake.Gtk.GtkCellRendererHandle cell_renderer, IntPtr @__arglist) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_attributes(tree_column, cell_renderer, @__arglist);
		return tree_column;
	}

/// <summary>
/// <para>
/// Sets the #GtkTreeCellDataFunc to use for the column.  This
/// function is used instead of the standard attributes mapping for
/// setting the column value, and should set the value of @tree_column's
/// cell renderer as appropriate.  @func may be %NULL to remove an
/// older one.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn
/// </param>
/// <param name="cell_renderer">
/// A #GtkCellRenderer
/// </param>
/// <param name="func">
/// The #GtkTreeCellDataFunc to use.
/// </param>
/// <param name="func_data">
/// The user data for @func.
/// </param>
/// <param name="destroy">
/// The destroy notification for @func_data
/// </param>

	public static T SetCellDataFunc<T>(this T tree_column, MentorLake.Gtk.GtkCellRendererHandle cell_renderer, MentorLake.Gtk.GtkTreeCellDataFunc func, IntPtr func_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_cell_data_func(tree_column, cell_renderer, func, func_data, destroy);
		return tree_column;
	}

/// <summary>
/// <para>
/// Sets the header to be active if @clickable is %TRUE.  When the header is
/// active, then it can take keyboard focus, and can be clicked.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <param name="clickable">
/// %TRUE if the header is active.
/// </param>

	public static T SetClickable<T>(this T tree_column, bool clickable) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_clickable(tree_column, clickable);
		return tree_column;
	}

/// <summary>
/// <para>
/// Sets the column to take available extra space.  This space is shared equally
/// amongst all columns that have the expand set to %TRUE.  If no column has this
/// option set, then the last column gets all extra space.  By default, every
/// column is created with this %FALSE.
/// </para>
/// <para>
/// Along with “fixed-width”, the “expand” property changes when the column is
/// resized by the user.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <param name="expand">
/// %TRUE if the column should expand to fill available space.
/// </param>

	public static T SetExpand<T>(this T tree_column, bool expand) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_expand(tree_column, expand);
		return tree_column;
	}

/// <summary>
/// <para>
/// If @fixed_width is not -1, sets the fixed width of @tree_column; otherwise
/// unsets it.  The effective value of @fixed_width is clamped between the
/// minimum and maximum width of the column; however, the value stored in the
/// “fixed-width” property is not clamped.  If the column sizing is
/// #GTK_TREE_VIEW_COLUMN_GROW_ONLY or #GTK_TREE_VIEW_COLUMN_AUTOSIZE, setting
/// a fixed width overrides the automatically calculated width.  Note that
/// @fixed_width is only a hint to GTK+; the width actually allocated to the
/// column may be greater or less than requested.
/// </para>
/// <para>
/// Along with “expand”, the “fixed-width” property changes when the column is
/// resized by the user.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <param name="fixed_width">
/// The new fixed width, in pixels, or -1.
/// </param>

	public static T SetFixedWidth<T>(this T tree_column, int fixed_width) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_fixed_width(tree_column, fixed_width);
		return tree_column;
	}

/// <summary>
/// <para>
/// Sets the maximum width of the @tree_column.  If @max_width is -1, then the
/// maximum width is unset.  Note, the column can actually be wider than max
/// width if it’s the last column in a view.  In this case, the column expands to
/// fill any extra space.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <param name="max_width">
/// The maximum width of the column in pixels, or -1.
/// </param>

	public static T SetMaxWidth<T>(this T tree_column, int max_width) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_max_width(tree_column, max_width);
		return tree_column;
	}

/// <summary>
/// <para>
/// Sets the minimum width of the @tree_column.  If @min_width is -1, then the
/// minimum width is unset.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <param name="min_width">
/// The minimum width of the column in pixels, or -1.
/// </param>

	public static T SetMinWidth<T>(this T tree_column, int min_width) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_min_width(tree_column, min_width);
		return tree_column;
	}

/// <summary>
/// <para>
/// If @reorderable is %TRUE, then the column can be reordered by the end user
/// dragging the header.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn
/// </param>
/// <param name="reorderable">
/// %TRUE, if the column can be reordered.
/// </param>

	public static T SetReorderable<T>(this T tree_column, bool reorderable) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_reorderable(tree_column, reorderable);
		return tree_column;
	}

/// <summary>
/// <para>
/// If @resizable is %TRUE, then the user can explicitly resize the column by
/// grabbing the outer edge of the column button.  If resizable is %TRUE and
/// sizing mode of the column is #GTK_TREE_VIEW_COLUMN_AUTOSIZE, then the sizing
/// mode is changed to #GTK_TREE_VIEW_COLUMN_GROW_ONLY.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn
/// </param>
/// <param name="resizable">
/// %TRUE, if the column can be resized
/// </param>

	public static T SetResizable<T>(this T tree_column, bool resizable) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_resizable(tree_column, resizable);
		return tree_column;
	}

/// <summary>
/// <para>
/// Sets the growth behavior of @tree_column to @type.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <param name="type">
/// The #GtkTreeViewColumnSizing.
/// </param>

	public static T SetSizing<T>(this T tree_column, MentorLake.Gtk.GtkTreeViewColumnSizing type) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_sizing(tree_column, type);
		return tree_column;
	}

/// <summary>
/// <para>
/// Sets the logical @sort_column_id that this column sorts on when this column
/// is selected for sorting.  Doing so makes the column header clickable.
/// </para>
/// </summary>

/// <param name="tree_column">
/// a #GtkTreeViewColumn
/// </param>
/// <param name="sort_column_id">
/// The @sort_column_id of the model to sort on.
/// </param>

	public static T SetSortColumnId<T>(this T tree_column, int sort_column_id) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_sort_column_id(tree_column, sort_column_id);
		return tree_column;
	}

/// <summary>
/// <para>
/// Call this function with a @setting of %TRUE to display an arrow in
/// the header button indicating the column is sorted. Call
/// gtk_tree_view_column_set_sort_order() to change the direction of
/// the arrow.
/// </para>
/// </summary>

/// <param name="tree_column">
/// a #GtkTreeViewColumn
/// </param>
/// <param name="setting">
/// %TRUE to display an indicator that the column is sorted
/// </param>

	public static T SetSortIndicator<T>(this T tree_column, bool setting) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_sort_indicator(tree_column, setting);
		return tree_column;
	}

/// <summary>
/// <para>
/// Changes the appearance of the sort indicator.
/// </para>
/// <para>
/// This does not actually sort the model.  Use
/// gtk_tree_view_column_set_sort_column_id() if you want automatic sorting
/// support.  This function is primarily for custom sorting behavior, and should
/// be used in conjunction with gtk_tree_sortable_set_sort_column_id() to do
/// that. For custom models, the mechanism will vary.
/// </para>
/// <para>
/// The sort indicator changes direction to indicate normal sort or reverse sort.
/// Note that you must have the sort indicator enabled to see anything when
/// calling this function; see gtk_tree_view_column_set_sort_indicator().
/// </para>
/// </summary>

/// <param name="tree_column">
/// a #GtkTreeViewColumn
/// </param>
/// <param name="order">
/// sort order that the sort indicator should indicate
/// </param>

	public static T SetSortOrder<T>(this T tree_column, MentorLake.Gtk.GtkSortType order) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_sort_order(tree_column, order);
		return tree_column;
	}

/// <summary>
/// <para>
/// Sets the spacing field of @tree_column, which is the number of pixels to
/// place between cell renderers packed into it.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <param name="spacing">
/// distance between cell renderers in pixels.
/// </param>

	public static T SetSpacing<T>(this T tree_column, int spacing) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_spacing(tree_column, spacing);
		return tree_column;
	}

/// <summary>
/// <para>
/// Sets the title of the @tree_column.  If a custom widget has been set, then
/// this value is ignored.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <param name="title">
/// The title of the @tree_column.
/// </param>

	public static T SetTitle<T>(this T tree_column, string title) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_title(tree_column, title);
		return tree_column;
	}

/// <summary>
/// <para>
/// Sets the visibility of @tree_column.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <param name="visible">
/// %TRUE if the @tree_column is visible.
/// </param>

	public static T SetVisible<T>(this T tree_column, bool visible) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_visible(tree_column, visible);
		return tree_column;
	}

/// <summary>
/// <para>
/// Sets the widget in the header to be @widget.  If widget is %NULL, then the
/// header button is set with a #GtkLabel set to the title of @tree_column.
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn.
/// </param>
/// <param name="widget">
/// A child #GtkWidget, or %NULL.
/// </param>

	public static T SetWidget<T>(this T tree_column, MentorLake.Gtk.GtkWidgetHandle widget) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_widget(tree_column, widget);
		return tree_column;
	}

}

internal class GtkTreeViewColumnHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))]
	internal static extern MentorLake.Gtk.GtkTreeViewColumnHandle gtk_tree_view_column_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))]
	internal static extern MentorLake.Gtk.GtkTreeViewColumnHandle gtk_tree_view_column_new_with_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))]
	internal static extern MentorLake.Gtk.GtkTreeViewColumnHandle gtk_tree_view_column_new_with_attributes(string title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_add_attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell_renderer, string attribute, int column);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_column_cell_get_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell_renderer, out int x_offset, out int width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_cell_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle cell_area, out int x_offset, out int y_offset, out int width, out int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_column_cell_is_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_cell_set_cell_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, bool is_expander, bool is_expanded);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_clear_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell_renderer);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_clicked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_focus_cell([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell);

	[DllImport(GtkLibrary.Name)]
	internal static extern float gtk_tree_view_column_get_alignment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_tree_view_column_get_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_column_get_clickable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_column_get_expand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_view_column_get_fixed_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_view_column_get_max_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_view_column_get_min_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_column_get_reorderable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_column_get_resizable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeViewColumnSizing gtk_tree_view_column_get_sizing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_view_column_get_sort_column_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_column_get_sort_indicator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSortType gtk_tree_view_column_get_sort_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_view_column_get_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_tree_view_column_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_tree_view_column_get_tree_view([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_column_get_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_tree_view_column_get_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_view_column_get_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_view_column_get_x_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_pack_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, bool expand);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_pack_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, bool expand);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_queue_resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_alignment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, float xalign);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell_renderer, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_cell_data_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell_renderer, MentorLake.Gtk.GtkTreeCellDataFunc func, IntPtr func_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_clickable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, bool clickable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_expand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, bool expand);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_fixed_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, int fixed_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_max_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, int max_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_min_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, int min_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_reorderable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, bool reorderable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_resizable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, bool resizable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_sizing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, MentorLake.Gtk.GtkTreeViewColumnSizing type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_sort_column_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, int sort_column_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_sort_indicator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_sort_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, MentorLake.Gtk.GtkSortType order);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, int spacing);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, string title);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, bool visible);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

}
