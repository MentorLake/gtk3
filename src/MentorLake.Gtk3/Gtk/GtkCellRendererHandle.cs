namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkCellRenderer is a base class of a set of objects used for
/// rendering a cell to a #cairo_t.  These objects are used primarily by
/// the #GtkTreeView widget, though they aren’t tied to them in any
/// specific way.  It is worth noting that #GtkCellRenderer is not a
/// #GtkWidget and cannot be treated as such.
/// </para>
/// <para>
/// The primary use of a #GtkCellRenderer is for drawing a certain graphical
/// elements on a #cairo_t. Typically, one cell renderer is used to
/// draw many cells on the screen.  To this extent, it isn’t expected that a
/// CellRenderer keep any permanent state around.  Instead, any state is set
/// just prior to use using #GObjects property system.  Then, the
/// cell is measured using gtk_cell_renderer_get_size(). Finally, the cell
/// is rendered in the correct location using gtk_cell_renderer_render().
/// </para>
/// <para>
/// There are a number of rules that must be followed when writing a new
/// #GtkCellRenderer.  First and foremost, it’s important that a certain set
/// of properties will always yield a cell renderer of the same size,
/// barring a #GtkStyle change.  The #GtkCellRenderer also has a number of
/// generic properties that are expected to be honored by all children.
/// </para>
/// <para>
/// Beyond merely rendering a cell, cell renderers can optionally
/// provide active user interface elements. A cell renderer can be
/// “activatable” like #GtkCellRendererToggle,
/// which toggles when it gets activated by a mouse click, or it can be
/// “editable” like #GtkCellRendererText, which
/// allows the user to edit the text using a widget implementing the
/// #GtkCellEditable interface, e.g. #GtkEntry.
/// To make a cell renderer activatable or editable, you have to
/// implement the #GtkCellRendererClass.activate or
/// #GtkCellRendererClass.start_editing virtual functions, respectively.
/// </para>
/// <para>
/// Many properties of #GtkCellRenderer and its subclasses have a
/// corresponding “set” property, e.g. “cell-background-set” corresponds
/// to “cell-background”. These “set” properties reflect whether a property
/// has been set or not. You should not set them independently.
/// </para>
/// </summary>

public class GtkCellRendererHandle : GInitiallyUnownedHandle
{
}
public static class GtkCellRendererHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal gets emitted when the user cancels the process of editing a
/// cell.  For example, an editable cell renderer could be written to cancel
/// editing when the user presses Escape.
/// </para>
/// <para>
/// See also: gtk_cell_renderer_stop_editing().
/// </para>
/// </summary>

	public static IObservable<GtkCellRendererHandleSignalStructs.EditingCanceledSignal> Signal_EditingCanceled(this GtkCellRendererHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCellRendererHandleSignalStructs.EditingCanceledSignal> obs) =>
		{
			GtkCellRendererHandleSignalDelegates.editing_canceled handler = ( MentorLake.Gtk.GtkCellRendererHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellRendererHandleSignalStructs.EditingCanceledSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "editing-canceled", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// This signal gets emitted when a cell starts to be edited.
/// The intended use of this signal is to do special setup
/// on @editable, e.g. adding a #GtkEntryCompletion or setting
/// up additional columns in a #GtkComboBox.
/// </para>
/// <para>
/// See gtk_cell_editable_start_editing() for information on the lifecycle of
/// the @editable and a way to do setup that doesn’t depend on the @renderer.
/// </para>
/// <para>
/// Note that GTK+ doesn't guarantee that cell renderers will
/// continue to use the same kind of widget for editing in future
/// releases, therefore you should check the type of @editable
/// before doing any specific setup, as in the following example:
/// |[<!-- language="C" -->
/// static void
/// text_editing_started (GtkCellRenderer *cell,
///                       GtkCellEditable *editable,
///                       const gchar     *path,
///                       gpointer         data)
/// {
///   if (GTK_IS_ENTRY (editable))
///     {
///       GtkEntry *entry = GTK_ENTRY (editable);
/// </para>
/// <para>
///       // ... create a GtkEntryCompletion
/// </para>
/// <para>
///       gtk_entry_set_completion (entry, completion);
///     }
/// }
/// ]|
/// </para>
/// </summary>

	public static IObservable<GtkCellRendererHandleSignalStructs.EditingStartedSignal> Signal_EditingStarted(this GtkCellRendererHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCellRendererHandleSignalStructs.EditingStartedSignal> obs) =>
		{
			GtkCellRendererHandleSignalDelegates.editing_started handler = ( MentorLake.Gtk.GtkCellRendererHandle self,  MentorLake.Gtk.GtkCellEditableHandle editable,  string path,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellRendererHandleSignalStructs.EditingStartedSignal()
				{
					Self = self, Editable = editable, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "editing-started", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkCellRendererHandleSignalStructs
{

public class EditingCanceledSignal
{

	public MentorLake.Gtk.GtkCellRendererHandle Self;

	public IntPtr UserData;
}

public class EditingStartedSignal
{

	public MentorLake.Gtk.GtkCellRendererHandle Self;
/// <summary>
/// <para>
/// the #GtkCellEditable
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkCellEditableHandle Editable;
/// <summary>
/// <para>
/// the path identifying the edited cell
/// </para>
/// </summary>

	public string Path;

	public IntPtr UserData;
}
}

public static class GtkCellRendererHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal gets emitted when the user cancels the process of editing a
/// cell.  For example, an editable cell renderer could be written to cancel
/// editing when the user presses Escape.
/// </para>
/// <para>
/// See also: gtk_cell_renderer_stop_editing().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void editing_canceled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal gets emitted when a cell starts to be edited.
/// The intended use of this signal is to do special setup
/// on @editable, e.g. adding a #GtkEntryCompletion or setting
/// up additional columns in a #GtkComboBox.
/// </para>
/// <para>
/// See gtk_cell_editable_start_editing() for information on the lifecycle of
/// the @editable and a way to do setup that doesn’t depend on the @renderer.
/// </para>
/// <para>
/// Note that GTK+ doesn't guarantee that cell renderers will
/// continue to use the same kind of widget for editing in future
/// releases, therefore you should check the type of @editable
/// before doing any specific setup, as in the following example:
/// |[<!-- language="C" -->
/// static void
/// text_editing_started (GtkCellRenderer *cell,
///                       GtkCellEditable *editable,
///                       const gchar     *path,
///                       gpointer         data)
/// {
///   if (GTK_IS_ENTRY (editable))
///     {
///       GtkEntry *entry = GTK_ENTRY (editable);
/// </para>
/// <para>
///       // ... create a GtkEntryCompletion
/// </para>
/// <para>
///       gtk_entry_set_completion (entry, completion);
///     }
/// }
/// ]|
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="editable">
/// the #GtkCellEditable
/// </param>
/// <param name="path">
/// the path identifying the edited cell
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void editing_started([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle editable, string path, IntPtr user_data);

}


public static class GtkCellRendererHandleExtensions
{
/// <summary>
/// <para>
/// Passes an activate event to the cell renderer for possible processing.
/// Some cell renderers may use events; for example, #GtkCellRendererToggle
/// toggles when it gets a mouse click.
/// </para>
/// </summary>

/// <param name="cell">
/// a #GtkCellRenderer
/// </param>
/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <param name="widget">
/// widget that received the event
/// </param>
/// <param name="path">
/// widget-dependent string representation of the event location;
///    e.g. for #GtkTreeView, a string representation of #GtkTreePath
/// </param>
/// <param name="background_area">
/// background area as passed to gtk_cell_renderer_render()
/// </param>
/// <param name="cell_area">
/// cell area as passed to gtk_cell_renderer_render()
/// </param>
/// <param name="flags">
/// render flags
/// </param>
/// <return>
/// %TRUE if the event was consumed/handled
/// </return>

	public static bool Activate(this MentorLake.Gtk.GtkCellRendererHandle cell, MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gtk.GtkWidgetHandle widget, string path, MentorLake.Gdk.GdkRectangleHandle background_area, MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gtk.GtkCellRendererState flags)
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		return GtkCellRendererHandleExterns.gtk_cell_renderer_activate(cell, @event, widget, path, background_area, cell_area, flags);
	}

/// <summary>
/// <para>
/// Gets the aligned area used by @cell inside @cell_area. Used for finding
/// the appropriate edit and focus rectangle.
/// </para>
/// </summary>

/// <param name="cell">
/// a #GtkCellRenderer instance
/// </param>
/// <param name="widget">
/// the #GtkWidget this cell will be rendering to
/// </param>
/// <param name="flags">
/// render flags
/// </param>
/// <param name="cell_area">
/// cell area which would be passed to gtk_cell_renderer_render()
/// </param>
/// <param name="aligned_area">
/// the return location for the space inside @cell_area
///                that would acually be used to render.
/// </param>

	public static T GetAlignedArea<T>(this T cell, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkCellRendererState flags, MentorLake.Gdk.GdkRectangleHandle cell_area, out MentorLake.Gdk.GdkRectangle aligned_area) where T : GtkCellRendererHandle
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		GtkCellRendererHandleExterns.gtk_cell_renderer_get_aligned_area(cell, widget, flags, cell_area, out aligned_area);
		return cell;
	}

/// <summary>
/// <para>
/// Fills in @xalign and @yalign with the appropriate values of @cell.
/// </para>
/// </summary>

/// <param name="cell">
/// A #GtkCellRenderer
/// </param>
/// <param name="xalign">
/// location to fill in with the x alignment of the cell, or %NULL
/// </param>
/// <param name="yalign">
/// location to fill in with the y alignment of the cell, or %NULL
/// </param>

	public static T GetAlignment<T>(this T cell, out float xalign, out float yalign) where T : GtkCellRendererHandle
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		GtkCellRendererHandleExterns.gtk_cell_renderer_get_alignment(cell, out xalign, out yalign);
		return cell;
	}

/// <summary>
/// <para>
/// Fills in @width and @height with the appropriate size of @cell.
/// </para>
/// </summary>

/// <param name="cell">
/// A #GtkCellRenderer
/// </param>
/// <param name="width">
/// location to fill in with the fixed width of the cell, or %NULL
/// </param>
/// <param name="height">
/// location to fill in with the fixed height of the cell, or %NULL
/// </param>

	public static T GetFixedSize<T>(this T cell, out int width, out int height) where T : GtkCellRendererHandle
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		GtkCellRendererHandleExterns.gtk_cell_renderer_get_fixed_size(cell, out width, out height);
		return cell;
	}

/// <summary>
/// <para>
/// Fills in @xpad and @ypad with the appropriate values of @cell.
/// </para>
/// </summary>

/// <param name="cell">
/// A #GtkCellRenderer
/// </param>
/// <param name="xpad">
/// location to fill in with the x padding of the cell, or %NULL
/// </param>
/// <param name="ypad">
/// location to fill in with the y padding of the cell, or %NULL
/// </param>

	public static T GetPadding<T>(this T cell, out int xpad, out int ypad) where T : GtkCellRendererHandle
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		GtkCellRendererHandleExterns.gtk_cell_renderer_get_padding(cell, out xpad, out ypad);
		return cell;
	}

/// <summary>
/// <para>
/// Retreives a renderer’s natural size when rendered to @widget.
/// </para>
/// </summary>

/// <param name="cell">
/// a #GtkCellRenderer instance
/// </param>
/// <param name="widget">
/// the #GtkWidget this cell will be rendering to
/// </param>
/// <param name="minimum_size">
/// location to store the minimum size, or %NULL
/// </param>
/// <param name="natural_size">
/// location to store the natural size, or %NULL
/// </param>

	public static T GetPreferredHeight<T>(this T cell, MentorLake.Gtk.GtkWidgetHandle widget, out int minimum_size, out int natural_size) where T : GtkCellRendererHandle
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		GtkCellRendererHandleExterns.gtk_cell_renderer_get_preferred_height(cell, widget, out minimum_size, out natural_size);
		return cell;
	}

/// <summary>
/// <para>
/// Retreives a cell renderers’s minimum and natural height if it were rendered to
/// @widget with the specified @width.
/// </para>
/// </summary>

/// <param name="cell">
/// a #GtkCellRenderer instance
/// </param>
/// <param name="widget">
/// the #GtkWidget this cell will be rendering to
/// </param>
/// <param name="width">
/// the size which is available for allocation
/// </param>
/// <param name="minimum_height">
/// location for storing the minimum size, or %NULL
/// </param>
/// <param name="natural_height">
/// location for storing the preferred size, or %NULL
/// </param>

	public static T GetPreferredHeightForWidth<T>(this T cell, MentorLake.Gtk.GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height) where T : GtkCellRendererHandle
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		GtkCellRendererHandleExterns.gtk_cell_renderer_get_preferred_height_for_width(cell, widget, width, out minimum_height, out natural_height);
		return cell;
	}

/// <summary>
/// <para>
/// Retrieves the minimum and natural size of a cell taking
/// into account the widget’s preference for height-for-width management.
/// </para>
/// </summary>

/// <param name="cell">
/// a #GtkCellRenderer instance
/// </param>
/// <param name="widget">
/// the #GtkWidget this cell will be rendering to
/// </param>
/// <param name="minimum_size">
/// location for storing the minimum size, or %NULL
/// </param>
/// <param name="natural_size">
/// location for storing the natural size, or %NULL
/// </param>

	public static T GetPreferredSize<T>(this T cell, MentorLake.Gtk.GtkWidgetHandle widget, out MentorLake.Gtk.GtkRequisition minimum_size, out MentorLake.Gtk.GtkRequisition natural_size) where T : GtkCellRendererHandle
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		GtkCellRendererHandleExterns.gtk_cell_renderer_get_preferred_size(cell, widget, out minimum_size, out natural_size);
		return cell;
	}

/// <summary>
/// <para>
/// Retreives a renderer’s natural size when rendered to @widget.
/// </para>
/// </summary>

/// <param name="cell">
/// a #GtkCellRenderer instance
/// </param>
/// <param name="widget">
/// the #GtkWidget this cell will be rendering to
/// </param>
/// <param name="minimum_size">
/// location to store the minimum size, or %NULL
/// </param>
/// <param name="natural_size">
/// location to store the natural size, or %NULL
/// </param>

	public static T GetPreferredWidth<T>(this T cell, MentorLake.Gtk.GtkWidgetHandle widget, out int minimum_size, out int natural_size) where T : GtkCellRendererHandle
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		GtkCellRendererHandleExterns.gtk_cell_renderer_get_preferred_width(cell, widget, out minimum_size, out natural_size);
		return cell;
	}

/// <summary>
/// <para>
/// Retreives a cell renderers’s minimum and natural width if it were rendered to
/// @widget with the specified @height.
/// </para>
/// </summary>

/// <param name="cell">
/// a #GtkCellRenderer instance
/// </param>
/// <param name="widget">
/// the #GtkWidget this cell will be rendering to
/// </param>
/// <param name="height">
/// the size which is available for allocation
/// </param>
/// <param name="minimum_width">
/// location for storing the minimum size, or %NULL
/// </param>
/// <param name="natural_width">
/// location for storing the preferred size, or %NULL
/// </param>

	public static T GetPreferredWidthForHeight<T>(this T cell, MentorLake.Gtk.GtkWidgetHandle widget, int height, out int minimum_width, out int natural_width) where T : GtkCellRendererHandle
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		GtkCellRendererHandleExterns.gtk_cell_renderer_get_preferred_width_for_height(cell, widget, height, out minimum_width, out natural_width);
		return cell;
	}

/// <summary>
/// <para>
/// Gets whether the cell renderer prefers a height-for-width layout
/// or a width-for-height layout.
/// </para>
/// </summary>

/// <param name="cell">
/// a #GtkCellRenderer    instance
/// </param>
/// <return>
/// The #GtkSizeRequestMode preferred by this renderer.
/// </return>

	public static MentorLake.Gtk.GtkSizeRequestMode GetRequestMode(this MentorLake.Gtk.GtkCellRendererHandle cell)
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		return GtkCellRendererHandleExterns.gtk_cell_renderer_get_request_mode(cell);
	}

/// <summary>
/// <para>
/// Returns the cell renderer’s sensitivity.
/// </para>
/// </summary>

/// <param name="cell">
/// A #GtkCellRenderer
/// </param>
/// <return>
/// %TRUE if the cell renderer is sensitive
/// </return>

	public static bool GetSensitive(this MentorLake.Gtk.GtkCellRendererHandle cell)
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		return GtkCellRendererHandleExterns.gtk_cell_renderer_get_sensitive(cell);
	}

/// <summary>
/// <para>
/// Obtains the width and height needed to render the cell. Used by view
/// widgets to determine the appropriate size for the cell_area passed to
/// gtk_cell_renderer_render().  If @cell_area is not %NULL, fills in the
/// x and y offsets (if set) of the cell relative to this location.
/// </para>
/// <para>
/// Please note that the values set in @width and @height, as well as those
/// in @x_offset and @y_offset are inclusive of the xpad and ypad properties.
/// </para>
/// </summary>

/// <param name="cell">
/// a #GtkCellRenderer
/// </param>
/// <param name="widget">
/// the widget the renderer is rendering to
/// </param>
/// <param name="cell_area">
/// The area a cell will be allocated, or %NULL
/// </param>
/// <param name="x_offset">
/// location to return x offset of cell relative to @cell_area, or %NULL
/// </param>
/// <param name="y_offset">
/// location to return y offset of cell relative to @cell_area, or %NULL
/// </param>
/// <param name="width">
/// location to return width needed to render a cell, or %NULL
/// </param>
/// <param name="height">
/// location to return height needed to render a cell, or %NULL
/// </param>

	public static T GetSize<T>(this T cell, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkRectangleHandle cell_area, out int x_offset, out int y_offset, out int width, out int height) where T : GtkCellRendererHandle
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		GtkCellRendererHandleExterns.gtk_cell_renderer_get_size(cell, widget, cell_area, out x_offset, out y_offset, out width, out height);
		return cell;
	}

/// <summary>
/// <para>
/// Translates the cell renderer state to #GtkStateFlags,
/// based on the cell renderer and widget sensitivity, and
/// the given #GtkCellRendererState.
/// </para>
/// </summary>

/// <param name="cell">
/// a #GtkCellRenderer, or %NULL
/// </param>
/// <param name="widget">
/// a #GtkWidget, or %NULL
/// </param>
/// <param name="cell_state">
/// cell renderer state
/// </param>
/// <return>
/// the widget state flags applying to @cell
/// </return>

	public static MentorLake.Gtk.GtkStateFlags GetState(this MentorLake.Gtk.GtkCellRendererHandle cell, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkCellRendererState cell_state)
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		return GtkCellRendererHandleExterns.gtk_cell_renderer_get_state(cell, widget, cell_state);
	}

/// <summary>
/// <para>
/// Returns the cell renderer’s visibility.
/// </para>
/// </summary>

/// <param name="cell">
/// A #GtkCellRenderer
/// </param>
/// <return>
/// %TRUE if the cell renderer is visible
/// </return>

	public static bool GetVisible(this MentorLake.Gtk.GtkCellRendererHandle cell)
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		return GtkCellRendererHandleExterns.gtk_cell_renderer_get_visible(cell);
	}

/// <summary>
/// <para>
/// Checks whether the cell renderer can do something when activated.
/// </para>
/// </summary>

/// <param name="cell">
/// A #GtkCellRenderer
/// </param>
/// <return>
/// %TRUE if the cell renderer can do anything when activated
/// </return>

	public static bool IsActivatable(this MentorLake.Gtk.GtkCellRendererHandle cell)
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		return GtkCellRendererHandleExterns.gtk_cell_renderer_is_activatable(cell);
	}

/// <summary>
/// <para>
/// Invokes the virtual render function of the #GtkCellRenderer. The three
/// passed-in rectangles are areas in @cr. Most renderers will draw within
/// @cell_area; the xalign, yalign, xpad, and ypad fields of the #GtkCellRenderer
/// should be honored with respect to @cell_area. @background_area includes the
/// blank space around the cell, and also the area containing the tree expander;
/// so the @background_area rectangles for all cells tile to cover the entire
/// @window.
/// </para>
/// </summary>

/// <param name="cell">
/// a #GtkCellRenderer
/// </param>
/// <param name="cr">
/// a cairo context to draw to
/// </param>
/// <param name="widget">
/// the widget owning @window
/// </param>
/// <param name="background_area">
/// entire cell area (including tree expanders and maybe
///    padding on the sides)
/// </param>
/// <param name="cell_area">
/// area normally rendered by a cell renderer
/// </param>
/// <param name="flags">
/// flags that affect rendering
/// </param>

	public static T Render<T>(this T cell, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkRectangleHandle background_area, MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gtk.GtkCellRendererState flags) where T : GtkCellRendererHandle
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		GtkCellRendererHandleExterns.gtk_cell_renderer_render(cell, cr, widget, background_area, cell_area, flags);
		return cell;
	}

/// <summary>
/// <para>
/// Sets the renderer’s alignment within its available space.
/// </para>
/// </summary>

/// <param name="cell">
/// A #GtkCellRenderer
/// </param>
/// <param name="xalign">
/// the x alignment of the cell renderer
/// </param>
/// <param name="yalign">
/// the y alignment of the cell renderer
/// </param>

	public static T SetAlignment<T>(this T cell, float xalign, float yalign) where T : GtkCellRendererHandle
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		GtkCellRendererHandleExterns.gtk_cell_renderer_set_alignment(cell, xalign, yalign);
		return cell;
	}

/// <summary>
/// <para>
/// Sets the renderer size to be explicit, independent of the properties set.
/// </para>
/// </summary>

/// <param name="cell">
/// A #GtkCellRenderer
/// </param>
/// <param name="width">
/// the width of the cell renderer, or -1
/// </param>
/// <param name="height">
/// the height of the cell renderer, or -1
/// </param>

	public static T SetFixedSize<T>(this T cell, int width, int height) where T : GtkCellRendererHandle
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		GtkCellRendererHandleExterns.gtk_cell_renderer_set_fixed_size(cell, width, height);
		return cell;
	}

/// <summary>
/// <para>
/// Sets the renderer’s padding.
/// </para>
/// </summary>

/// <param name="cell">
/// A #GtkCellRenderer
/// </param>
/// <param name="xpad">
/// the x padding of the cell renderer
/// </param>
/// <param name="ypad">
/// the y padding of the cell renderer
/// </param>

	public static T SetPadding<T>(this T cell, int xpad, int ypad) where T : GtkCellRendererHandle
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		GtkCellRendererHandleExterns.gtk_cell_renderer_set_padding(cell, xpad, ypad);
		return cell;
	}

/// <summary>
/// <para>
/// Sets the cell renderer’s sensitivity.
/// </para>
/// </summary>

/// <param name="cell">
/// A #GtkCellRenderer
/// </param>
/// <param name="sensitive">
/// the sensitivity of the cell
/// </param>

	public static T SetSensitive<T>(this T cell, bool sensitive) where T : GtkCellRendererHandle
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		GtkCellRendererHandleExterns.gtk_cell_renderer_set_sensitive(cell, sensitive);
		return cell;
	}

/// <summary>
/// <para>
/// Sets the cell renderer’s visibility.
/// </para>
/// </summary>

/// <param name="cell">
/// A #GtkCellRenderer
/// </param>
/// <param name="visible">
/// the visibility of the cell
/// </param>

	public static T SetVisible<T>(this T cell, bool visible) where T : GtkCellRendererHandle
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		GtkCellRendererHandleExterns.gtk_cell_renderer_set_visible(cell, visible);
		return cell;
	}

/// <summary>
/// <para>
/// Starts editing the contents of this @cell, through a new #GtkCellEditable
/// widget created by the #GtkCellRendererClass.start_editing virtual function.
/// </para>
/// </summary>

/// <param name="cell">
/// a #GtkCellRenderer
/// </param>
/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <param name="widget">
/// widget that received the event
/// </param>
/// <param name="path">
/// widget-dependent string representation of the event location;
///    e.g. for #GtkTreeView, a string representation of #GtkTreePath
/// </param>
/// <param name="background_area">
/// background area as passed to gtk_cell_renderer_render()
/// </param>
/// <param name="cell_area">
/// cell area as passed to gtk_cell_renderer_render()
/// </param>
/// <param name="flags">
/// render flags
/// </param>
/// <return>
/// A new #GtkCellEditable for editing this
///   @cell, or %NULL if editing is not possible
/// </return>

	public static MentorLake.Gtk.GtkCellEditableHandle StartEditing(this MentorLake.Gtk.GtkCellRendererHandle cell, MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gtk.GtkWidgetHandle widget, string path, MentorLake.Gdk.GdkRectangleHandle background_area, MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gtk.GtkCellRendererState flags)
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		return GtkCellRendererHandleExterns.gtk_cell_renderer_start_editing(cell, @event, widget, path, background_area, cell_area, flags);
	}

/// <summary>
/// <para>
/// Informs the cell renderer that the editing is stopped.
/// If @canceled is %TRUE, the cell renderer will emit the
/// #GtkCellRenderer::editing-canceled signal.
/// </para>
/// <para>
/// This function should be called by cell renderer implementations
/// in response to the #GtkCellEditable::editing-done signal of
/// #GtkCellEditable.
/// </para>
/// </summary>

/// <param name="cell">
/// A #GtkCellRenderer
/// </param>
/// <param name="canceled">
/// %TRUE if the editing has been canceled
/// </param>

	public static T StopEditing<T>(this T cell, bool canceled) where T : GtkCellRendererHandle
	{
		if (cell.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererHandle)");
		GtkCellRendererHandleExterns.gtk_cell_renderer_stop_editing(cell, canceled);
		return cell;
	}

}

internal class GtkCellRendererHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_renderer_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle background_area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gtk.GtkCellRendererState flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_get_aligned_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkCellRendererState flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle cell_area, out MentorLake.Gdk.GdkRectangle aligned_area);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_get_alignment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, out float xalign, out float yalign);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_get_fixed_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, out int width, out int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_get_padding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, out int xpad, out int ypad);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_get_preferred_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out int minimum_size, out int natural_size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_get_preferred_height_for_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_get_preferred_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out MentorLake.Gtk.GtkRequisition minimum_size, out MentorLake.Gtk.GtkRequisition natural_size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_get_preferred_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out int minimum_size, out int natural_size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_get_preferred_width_for_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int height, out int minimum_width, out int natural_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSizeRequestMode gtk_cell_renderer_get_request_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_renderer_get_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle cell_area, out int x_offset, out int y_offset, out int width, out int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStateFlags gtk_cell_renderer_get_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkCellRendererState cell_state);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_renderer_get_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_renderer_is_activatable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_render([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle background_area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gtk.GtkCellRendererState flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_set_alignment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, float xalign, float yalign);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_set_fixed_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_set_padding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, int xpad, int ypad);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_set_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, bool sensitive);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_set_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, bool visible);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))]
	internal static extern MentorLake.Gtk.GtkCellEditableHandle gtk_cell_renderer_start_editing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle background_area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gtk.GtkCellRendererState flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_stop_editing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, bool canceled);

}
