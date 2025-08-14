namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkCellArea is an abstract class for #GtkCellLayout widgets
/// (also referred to as "layouting widgets") to interface with an
/// arbitrary number of #GtkCellRenderers and interact with the user
/// for a given #GtkTreeModel row.
/// </para>
/// <para>
/// The cell area handles events, focus navigation, drawing and
/// size requests and allocations for a given row of data.
/// </para>
/// <para>
/// Usually users dont have to interact with the #GtkCellArea directly
/// unless they are implementing a cell-layouting widget themselves.
/// </para>
/// <para>
/// # Requesting area sizes
/// </para>
/// <para>
/// As outlined in
/// [GtkWidget’s geometry management section][geometry-management],
/// GTK+ uses a height-for-width
/// geometry management system to compute the sizes of widgets and user
/// interfaces. #GtkCellArea uses the same semantics to calculate the
/// size of an area for an arbitrary number of #GtkTreeModel rows.
/// </para>
/// <para>
/// When requesting the size of a cell area one needs to calculate
/// the size for a handful of rows, and this will be done differently by
/// different layouting widgets. For instance a #GtkTreeViewColumn
/// always lines up the areas from top to bottom while a #GtkIconView
/// on the other hand might enforce that all areas received the same
/// width and wrap the areas around, requesting height for more cell
/// areas when allocated less width.
/// </para>
/// <para>
/// It’s also important for areas to maintain some cell
/// alignments with areas rendered for adjacent rows (cells can
/// appear “columnized” inside an area even when the size of
/// cells are different in each row). For this reason the #GtkCellArea
/// uses a #GtkCellAreaContext object to store the alignments
/// and sizes along the way (as well as the overall largest minimum
/// and natural size for all the rows which have been calculated
/// with the said context).
/// </para>
/// <para>
/// The #GtkCellAreaContext is an opaque object specific to the
/// #GtkCellArea which created it (see gtk_cell_area_create_context()).
/// The owning cell-layouting widget can create as many contexts as
/// it wishes to calculate sizes of rows which should receive the
/// same size in at least one orientation (horizontally or vertically),
/// However, it’s important that the same #GtkCellAreaContext which
/// was used to request the sizes for a given #GtkTreeModel row be
/// used when rendering or processing events for that row.
/// </para>
/// <para>
/// In order to request the width of all the rows at the root level
/// of a #GtkTreeModel one would do the following:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// GtkTreeIter iter;
/// gint        minimum_width;
/// gint        natural_width;
/// </para>
/// <para>
/// valid = gtk_tree_model_get_iter_first (model, &iter);
/// while (valid)
///   {
///     gtk_cell_area_apply_attributes (area, model, &iter, FALSE, FALSE);
///     gtk_cell_area_get_preferred_width (area, context, widget, NULL, NULL);
/// </para>
/// <para>
///     valid = gtk_tree_model_iter_next (model, &iter);
///   }
/// gtk_cell_area_context_get_preferred_width (context, &minimum_width, &natural_width);
/// ]|
/// </para>
/// <para>
/// Note that in this example it’s not important to observe the
/// returned minimum and natural width of the area for each row
/// unless the cell-layouting object is actually interested in the
/// widths of individual rows. The overall width is however stored
/// in the accompanying #GtkCellAreaContext object and can be consulted
/// at any time.
/// </para>
/// <para>
/// This can be useful since #GtkCellLayout widgets usually have to
/// support requesting and rendering rows in treemodels with an
/// exceedingly large amount of rows. The #GtkCellLayout widget in
/// that case would calculate the required width of the rows in an
/// idle or timeout source (see g_timeout_add()) and when the widget
/// is requested its actual width in #GtkWidgetClass.get_preferred_width()
/// it can simply consult the width accumulated so far in the
/// #GtkCellAreaContext object.
/// </para>
/// <para>
/// A simple example where rows are rendered from top to bottom and
/// take up the full width of the layouting widget would look like:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// static void
/// foo_get_preferred_width (GtkWidget       *widget,
///                          gint            *minimum_size,
///                          gint            *natural_size)
/// {
///   Foo        *foo  = FOO (widget);
///   FooPrivate *priv = foo->priv;
/// </para>
/// <para>
///   foo_ensure_at_least_one_handfull_of_rows_have_been_requested (foo);
/// </para>
/// <para>
///   gtk_cell_area_context_get_preferred_width (priv->context, minimum_size, natural_size);
/// }
/// ]|
/// </para>
/// <para>
/// In the above example the Foo widget has to make sure that some
/// row sizes have been calculated (the amount of rows that Foo judged
/// was appropriate to request space for in a single timeout iteration)
/// before simply returning the amount of space required by the area via
/// the #GtkCellAreaContext.
/// </para>
/// <para>
/// Requesting the height for width (or width for height) of an area is
/// a similar task except in this case the #GtkCellAreaContext does not
/// store the data (actually, it does not know how much space the layouting
/// widget plans to allocate it for every row. It’s up to the layouting
/// widget to render each row of data with the appropriate height and
/// width which was requested by the #GtkCellArea).
/// </para>
/// <para>
/// In order to request the height for width of all the rows at the
/// root level of a #GtkTreeModel one would do the following:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// GtkTreeIter iter;
/// gint        minimum_height;
/// gint        natural_height;
/// gint        full_minimum_height = 0;
/// gint        full_natural_height = 0;
/// </para>
/// <para>
/// valid = gtk_tree_model_get_iter_first (model, &iter);
/// while (valid)
///   {
///     gtk_cell_area_apply_attributes (area, model, &iter, FALSE, FALSE);
///     gtk_cell_area_get_preferred_height_for_width (area, context, widget,
///                                                   width, &minimum_height, &natural_height);
/// </para>
/// <para>
///     if (width_is_for_allocation)
///        cache_row_height (&iter, minimum_height, natural_height);
/// </para>
/// <para>
///     full_minimum_height += minimum_height;
///     full_natural_height += natural_height;
/// </para>
/// <para>
///     valid = gtk_tree_model_iter_next (model, &iter);
///   }
/// ]|
/// </para>
/// <para>
/// Note that in the above example we would need to cache the heights
/// returned for each row so that we would know what sizes to render the
/// areas for each row. However we would only want to really cache the
/// heights if the request is intended for the layouting widgets real
/// allocation.
/// </para>
/// <para>
/// In some cases the layouting widget is requested the height for an
/// arbitrary for_width, this is a special case for layouting widgets
/// who need to request size for tens of thousands  of rows. For this
/// case it’s only important that the layouting widget calculate
/// one reasonably sized chunk of rows and return that height
/// synchronously. The reasoning here is that any layouting widget is
/// at least capable of synchronously calculating enough height to fill
/// the screen height (or scrolled window height) in response to a single
/// call to #GtkWidgetClass.get_preferred_height_for_width(). Returning
/// a perfect height for width that is larger than the screen area is
/// inconsequential since after the layouting receives an allocation
/// from a scrolled window it simply continues to drive the scrollbar
/// values while more and more height is required for the row heights
/// that are calculated in the background.
/// </para>
/// <para>
/// # Rendering Areas
/// </para>
/// <para>
/// Once area sizes have been aquired at least for the rows in the
/// visible area of the layouting widget they can be rendered at
/// #GtkWidgetClass.draw() time.
/// </para>
/// <para>
/// A crude example of how to render all the rows at the root level
/// runs as follows:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// GtkAllocation allocation;
/// GdkRectangle  cell_area = { 0, };
/// GtkTreeIter   iter;
/// gint          minimum_width;
/// gint          natural_width;
/// </para>
/// <para>
/// gtk_widget_get_allocation (widget, &allocation);
/// cell_area.width = allocation.width;
/// </para>
/// <para>
/// valid = gtk_tree_model_get_iter_first (model, &iter);
/// while (valid)
///   {
///     cell_area.height = get_cached_height_for_row (&iter);
/// </para>
/// <para>
///     gtk_cell_area_apply_attributes (area, model, &iter, FALSE, FALSE);
///     gtk_cell_area_render (area, context, widget, cr,
///                           &cell_area, &cell_area, state_flags, FALSE);
/// </para>
/// <para>
///     cell_area.y += cell_area.height;
/// </para>
/// <para>
///     valid = gtk_tree_model_iter_next (model, &iter);
///   }
/// ]|
/// </para>
/// <para>
/// Note that the cached height in this example really depends on how
/// the layouting widget works. The layouting widget might decide to
/// give every row its minimum or natural height or, if the model content
/// is expected to fit inside the layouting widget without scrolling, it
/// would make sense to calculate the allocation for each row at
/// #GtkWidget::size-allocate time using gtk_distribute_natural_allocation().
/// </para>
/// <para>
/// # Handling Events and Driving Keyboard Focus
/// </para>
/// <para>
/// Passing events to the area is as simple as handling events on any
/// normal widget and then passing them to the gtk_cell_area_event()
/// API as they come in. Usually #GtkCellArea is only interested in
/// button events, however some customized derived areas can be implemented
/// who are interested in handling other events. Handling an event can
/// trigger the #GtkCellArea::focus-changed signal to fire; as well as
/// #GtkCellArea::add-editable in the case that an editable cell was
/// clicked and needs to start editing. You can call
/// gtk_cell_area_stop_editing() at any time to cancel any cell editing
/// that is currently in progress.
/// </para>
/// <para>
/// The #GtkCellArea drives keyboard focus from cell to cell in a way
/// similar to #GtkWidget. For layouting widgets that support giving
/// focus to cells it’s important to remember to pass %GTK_CELL_RENDERER_FOCUSED
/// to the area functions for the row that has focus and to tell the
/// area to paint the focus at render time.
/// </para>
/// <para>
/// Layouting widgets that accept focus on cells should implement the
/// #GtkWidgetClass.focus() virtual method. The layouting widget is always
/// responsible for knowing where #GtkTreeModel rows are rendered inside
/// the widget, so at #GtkWidgetClass.focus() time the layouting widget
/// should use the #GtkCellArea methods to navigate focus inside the area
/// and then observe the GtkDirectionType to pass the focus to adjacent
/// rows and areas.
/// </para>
/// <para>
/// A basic example of how the #GtkWidgetClass.focus() virtual method
/// should be implemented:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// static gboolean
/// foo_focus (GtkWidget       *widget,
///            GtkDirectionType direction)
/// {
///   Foo        *foo  = FOO (widget);
///   FooPrivate *priv = foo->priv;
///   gint        focus_row;
///   gboolean    have_focus = FALSE;
/// </para>
/// <para>
///   focus_row = priv->focus_row;
/// </para>
/// <para>
///   if (!gtk_widget_has_focus (widget))
///     gtk_widget_grab_focus (widget);
/// </para>
/// <para>
///   valid = gtk_tree_model_iter_nth_child (priv->model, &iter, NULL, priv->focus_row);
///   while (valid)
///     {
///       gtk_cell_area_apply_attributes (priv->area, priv->model, &iter, FALSE, FALSE);
/// </para>
/// <para>
///       if (gtk_cell_area_focus (priv->area, direction))
///         {
///            priv->focus_row = focus_row;
///            have_focus = TRUE;
///            break;
///         }
///       else
///         {
///           if (direction == GTK_DIR_RIGHT ||
///               direction == GTK_DIR_LEFT)
///             break;
///           else if (direction == GTK_DIR_UP ||
///                    direction == GTK_DIR_TAB_BACKWARD)
///            {
///               if (focus_row == 0)
///                 break;
///               else
///                {
///                   focus_row--;
///                   valid = gtk_tree_model_iter_nth_child (priv->model, &iter, NULL, focus_row);
///                }
///             }
///           else
///             {
///               if (focus_row == last_row)
///                 break;
///               else
///                 {
///                   focus_row++;
///                   valid = gtk_tree_model_iter_next (priv->model, &iter);
///                 }
///             }
///         }
///     }
///     return have_focus;
/// }
/// ]|
/// </para>
/// <para>
/// Note that the layouting widget is responsible for matching the
/// GtkDirectionType values to the way it lays out its cells.
/// </para>
/// <para>
/// # Cell Properties
/// </para>
/// <para>
/// The #GtkCellArea introduces cell properties for #GtkCellRenderers
/// in very much the same way that #GtkContainer introduces
/// [child properties][child-properties]
/// for #GtkWidgets. This provides some general interfaces for defining
/// the relationship cell areas have with their cells. For instance in a
/// #GtkCellAreaBox a cell might “expand” and receive extra space when
/// the area is allocated more than its full natural request, or a cell
/// might be configured to “align” with adjacent rows which were requested
/// and rendered with the same #GtkCellAreaContext.
/// </para>
/// <para>
/// Use gtk_cell_area_class_install_cell_property() to install cell
/// properties for a cell area class and gtk_cell_area_class_find_cell_property()
/// or gtk_cell_area_class_list_cell_properties() to get information about
/// existing cell properties.
/// </para>
/// <para>
/// To set the value of a cell property, use gtk_cell_area_cell_set_property(),
/// gtk_cell_area_cell_set() or gtk_cell_area_cell_set_valist(). To obtain
/// the value of a cell property, use gtk_cell_area_cell_get_property(),
/// gtk_cell_area_cell_get() or gtk_cell_area_cell_get_valist().
/// </para>
/// </summary>

public class GtkCellAreaHandle : GInitiallyUnownedHandle, GtkBuildableHandle, GtkCellLayoutHandle
{
}
public static class GtkCellAreaHandleSignalExtensions
{
/// <summary>
/// <para>
/// Indicates that editing has started on @renderer and that @editable
/// should be added to the owning cell-layouting widget at @cell_area.
/// </para>
/// </summary>

	public static IObservable<GtkCellAreaHandleSignalStructs.AddEditableSignal> Signal_AddEditable(this GtkCellAreaHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCellAreaHandleSignalStructs.AddEditableSignal> obs) =>
		{
			GtkCellAreaHandleSignalDelegates.add_editable handler = ( MentorLake.Gtk.GtkCellAreaHandle self,  MentorLake.Gtk.GtkCellRendererHandle renderer,  MentorLake.Gtk.GtkCellEditableHandle editable,  MentorLake.Gdk.GdkRectangleHandle cell_area,  string path,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellAreaHandleSignalStructs.AddEditableSignal()
				{
					Self = self, Renderer = renderer, Editable = editable, CellArea = cell_area, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "add-editable", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted whenever applying attributes to @area from @model
/// </para>
/// </summary>

	public static IObservable<GtkCellAreaHandleSignalStructs.ApplyAttributesSignal> Signal_ApplyAttributes(this GtkCellAreaHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCellAreaHandleSignalStructs.ApplyAttributesSignal> obs) =>
		{
			GtkCellAreaHandleSignalDelegates.apply_attributes handler = ( MentorLake.Gtk.GtkCellAreaHandle self,  MentorLake.Gtk.GtkTreeModelHandle model,  MentorLake.Gtk.GtkTreeIterHandle iter,  bool is_expander,  bool is_expanded,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellAreaHandleSignalStructs.ApplyAttributesSignal()
				{
					Self = self, Model = model, Iter = iter, IsExpander = is_expander, IsExpanded = is_expanded, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "apply-attributes", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Indicates that focus changed on this @area. This signal
/// is emitted either as a result of focus handling or event
/// handling.
/// </para>
/// <para>
/// It's possible that the signal is emitted even if the
/// currently focused renderer did not change, this is
/// because focus may change to the same renderer in the
/// same cell area for a different row of data.
/// </para>
/// </summary>

	public static IObservable<GtkCellAreaHandleSignalStructs.FocusChangedSignal> Signal_FocusChanged(this GtkCellAreaHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCellAreaHandleSignalStructs.FocusChangedSignal> obs) =>
		{
			GtkCellAreaHandleSignalDelegates.focus_changed handler = ( MentorLake.Gtk.GtkCellAreaHandle self,  MentorLake.Gtk.GtkCellRendererHandle renderer,  string path,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellAreaHandleSignalStructs.FocusChangedSignal()
				{
					Self = self, Renderer = renderer, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "focus-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Indicates that editing finished on @renderer and that @editable
/// should be removed from the owning cell-layouting widget.
/// </para>
/// </summary>

	public static IObservable<GtkCellAreaHandleSignalStructs.RemoveEditableSignal> Signal_RemoveEditable(this GtkCellAreaHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCellAreaHandleSignalStructs.RemoveEditableSignal> obs) =>
		{
			GtkCellAreaHandleSignalDelegates.remove_editable handler = ( MentorLake.Gtk.GtkCellAreaHandle self,  MentorLake.Gtk.GtkCellRendererHandle renderer,  MentorLake.Gtk.GtkCellEditableHandle editable,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellAreaHandleSignalStructs.RemoveEditableSignal()
				{
					Self = self, Renderer = renderer, Editable = editable, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "remove-editable", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkCellAreaHandleSignalStructs
{

public class AddEditableSignal
{

	public MentorLake.Gtk.GtkCellAreaHandle Self;
/// <summary>
/// <para>
/// the #GtkCellRenderer that started the edited
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkCellRendererHandle Renderer;
/// <summary>
/// <para>
/// the #GtkCellEditable widget to add
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkCellEditableHandle Editable;
/// <summary>
/// <para>
/// the #GtkWidget relative #GdkRectangle coordinates
///             where @editable should be added
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkRectangleHandle CellArea;
/// <summary>
/// <para>
/// the #GtkTreePath string this edit was initiated for
/// </para>
/// </summary>

	public string Path;

	public IntPtr UserData;
}

public class ApplyAttributesSignal
{

	public MentorLake.Gtk.GtkCellAreaHandle Self;
/// <summary>
/// <para>
/// the #GtkTreeModel to apply the attributes from
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreeModelHandle Model;
/// <summary>
/// <para>
/// the #GtkTreeIter indicating which row to apply the attributes of
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreeIterHandle Iter;
/// <summary>
/// <para>
/// whether the view shows children for this row
/// </para>
/// </summary>

	public bool IsExpander;
/// <summary>
/// <para>
/// whether the view is currently showing the children of this row
/// </para>
/// </summary>

	public bool IsExpanded;

	public IntPtr UserData;
}

public class FocusChangedSignal
{

	public MentorLake.Gtk.GtkCellAreaHandle Self;
/// <summary>
/// <para>
/// the #GtkCellRenderer that has focus
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkCellRendererHandle Renderer;
/// <summary>
/// <para>
/// the current #GtkTreePath string set for @area
/// </para>
/// </summary>

	public string Path;

	public IntPtr UserData;
}

public class RemoveEditableSignal
{

	public MentorLake.Gtk.GtkCellAreaHandle Self;
/// <summary>
/// <para>
/// the #GtkCellRenderer that finished editeding
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkCellRendererHandle Renderer;
/// <summary>
/// <para>
/// the #GtkCellEditable widget to remove
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkCellEditableHandle Editable;

	public IntPtr UserData;
}
}

public static class GtkCellAreaHandleSignalDelegates
{

/// <summary>
/// <para>
/// Indicates that editing has started on @renderer and that @editable
/// should be added to the owning cell-layouting widget at @cell_area.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="renderer">
/// the #GtkCellRenderer that started the edited
/// </param>
/// <param name="editable">
/// the #GtkCellEditable widget to add
/// </param>
/// <param name="cell_area">
/// the #GtkWidget relative #GdkRectangle coordinates
///             where @editable should be added
/// </param>
/// <param name="path">
/// the #GtkTreePath string this edit was initiated for
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void add_editable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle editable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle cell_area, string path, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted whenever applying attributes to @area from @model
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="model">
/// the #GtkTreeModel to apply the attributes from
/// </param>
/// <param name="iter">
/// the #GtkTreeIter indicating which row to apply the attributes of
/// </param>
/// <param name="is_expander">
/// whether the view shows children for this row
/// </param>
/// <param name="is_expanded">
/// whether the view is currently showing the children of this row
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void apply_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, bool is_expander, bool is_expanded, IntPtr user_data);


/// <summary>
/// <para>
/// Indicates that focus changed on this @area. This signal
/// is emitted either as a result of focus handling or event
/// handling.
/// </para>
/// <para>
/// It's possible that the signal is emitted even if the
/// currently focused renderer did not change, this is
/// because focus may change to the same renderer in the
/// same cell area for a different row of data.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="renderer">
/// the #GtkCellRenderer that has focus
/// </param>
/// <param name="path">
/// the current #GtkTreePath string set for @area
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void focus_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, string path, IntPtr user_data);


/// <summary>
/// <para>
/// Indicates that editing finished on @renderer and that @editable
/// should be removed from the owning cell-layouting widget.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="renderer">
/// the #GtkCellRenderer that finished editeding
/// </param>
/// <param name="editable">
/// the #GtkCellEditable widget to remove
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void remove_editable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle editable, IntPtr user_data);

}


public static class GtkCellAreaHandleExtensions
{
/// <summary>
/// <para>
/// Activates @area, usually by activating the currently focused
/// cell, however some subclasses which embed widgets in the area
/// can also activate a widget if it currently has the focus.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="context">
/// the #GtkCellAreaContext in context with the current row data
/// </param>
/// <param name="widget">
/// the #GtkWidget that @area is rendering on
/// </param>
/// <param name="cell_area">
/// the size and location of @area relative to @widget’s allocation
/// </param>
/// <param name="flags">
/// the #GtkCellRendererState flags for @area for this row of data.
/// </param>
/// <param name="edit_only">
/// if %TRUE then only cell renderers that are %GTK_CELL_RENDERER_MODE_EDITABLE
///             will be activated.
/// </param>
/// <return>
/// Whether @area was successfully activated.
/// </return>

	public static bool Activate(this MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkCellAreaContextHandle context, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gtk.GtkCellRendererState flags, bool edit_only)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_activate(area, context, widget, cell_area, flags, edit_only);
	}

/// <summary>
/// <para>
/// This is used by #GtkCellArea subclasses when handling events
/// to activate cells, the base #GtkCellArea class activates cells
/// for keyboard events for free in its own GtkCellArea->activate()
/// implementation.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="widget">
/// the #GtkWidget that @area is rendering onto
/// </param>
/// <param name="renderer">
/// the #GtkCellRenderer in @area to activate
/// </param>
/// <param name="@event">
/// the #GdkEvent for which cell activation should occur
/// </param>
/// <param name="cell_area">
/// the #GdkRectangle in @widget relative coordinates
///             of @renderer for the current row.
/// </param>
/// <param name="flags">
/// the #GtkCellRendererState for @renderer
/// </param>
/// <return>
/// whether cell activation was successful
/// </return>

	public static bool ActivateCell(this MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkCellRendererHandle renderer, MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gtk.GtkCellRendererState flags)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_activate_cell(area, widget, renderer, @event, cell_area, flags);
	}

/// <summary>
/// <para>
/// Adds @renderer to @area with the default child cell properties.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="renderer">
/// the #GtkCellRenderer to add to @area
/// </param>

	public static T Add<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_add(area, renderer);
		return area;
	}

/// <summary>
/// <para>
/// Adds @sibling to @renderer’s focusable area, focus will be drawn
/// around @renderer and all of its siblings if @renderer can
/// focus for a given row.
/// </para>
/// <para>
/// Events handled by focus siblings can also activate the given
/// focusable @renderer.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="renderer">
/// the #GtkCellRenderer expected to have focus
/// </param>
/// <param name="sibling">
/// the #GtkCellRenderer to add to @renderer’s focus area
/// </param>

	public static T AddFocusSibling<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, MentorLake.Gtk.GtkCellRendererHandle sibling) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_add_focus_sibling(area, renderer, sibling);
		return area;
	}

/// <summary>
/// <para>
/// Adds @renderer to @area, setting cell properties at the same time.
/// See gtk_cell_area_add() and gtk_cell_area_cell_set() for more details.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="renderer">
/// a #GtkCellRenderer to be placed inside @area
/// </param>
/// <param name="first_prop_name">
/// the name of the first cell property to set
/// </param>
/// <param name="@__arglist">
/// a %NULL-terminated list of property names and values, starting
///     with @first_prop_name
/// </param>

	public static T AddWithProperties<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__arglist) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_add_with_properties(area, renderer, first_prop_name, @__arglist);
		return area;
	}

/// <summary>
/// <para>
/// Applies any connected attributes to the renderers in
/// @area by pulling the values from @tree_model.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="tree_model">
/// the #GtkTreeModel to pull values from
/// </param>
/// <param name="iter">
/// the #GtkTreeIter in @tree_model to apply values for
/// </param>
/// <param name="is_expander">
/// whether @iter has children
/// </param>
/// <param name="is_expanded">
/// whether @iter is expanded in the view and
///               children are visible
/// </param>

	public static T ApplyAttributes<T>(this T area, MentorLake.Gtk.GtkTreeModelHandle tree_model, MentorLake.Gtk.GtkTreeIterHandle iter, bool is_expander, bool is_expanded) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_apply_attributes(area, tree_model, iter, is_expander, is_expanded);
		return area;
	}

/// <summary>
/// <para>
/// Connects an @attribute to apply values from @column for the
/// #GtkTreeModel in use.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="renderer">
/// the #GtkCellRenderer to connect an attribute for
/// </param>
/// <param name="attribute">
/// the attribute name
/// </param>
/// <param name="column">
/// the #GtkTreeModel column to fetch attribute values from
/// </param>

	public static T AttributeConnect<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, string attribute, int column) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_attribute_connect(area, renderer, attribute, column);
		return area;
	}

/// <summary>
/// <para>
/// Disconnects @attribute for the @renderer in @area so that
/// attribute will no longer be updated with values from the
/// model.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="renderer">
/// the #GtkCellRenderer to disconnect an attribute for
/// </param>
/// <param name="attribute">
/// the attribute name
/// </param>

	public static T AttributeDisconnect<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, string attribute) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_attribute_disconnect(area, renderer, attribute);
		return area;
	}

/// <summary>
/// <para>
/// Returns the model column that an attribute has been mapped to,
/// or -1 if the attribute is not mapped.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="renderer">
/// a #GtkCellRenderer
/// </param>
/// <param name="attribute">
/// an attribute on the renderer
/// </param>
/// <return>
/// the model column, or -1
/// </return>

	public static int AttributeGetColumn(this MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkCellRendererHandle renderer, string attribute)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_attribute_get_column(area, renderer, attribute);
	}

/// <summary>
/// <para>
/// Gets the values of one or more cell properties for @renderer in @area.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="renderer">
/// a #GtkCellRenderer which is inside @area
/// </param>
/// <param name="first_prop_name">
/// the name of the first cell property to get
/// </param>
/// <param name="@__arglist">
/// return location for the first cell property, followed
///     optionally by more name/return location pairs, followed by %NULL
/// </param>

	public static T CellGet<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__arglist) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_cell_get(area, renderer, first_prop_name, @__arglist);
		return area;
	}

/// <summary>
/// <para>
/// Gets the value of a cell property for @renderer in @area.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="renderer">
/// a #GtkCellRenderer inside @area
/// </param>
/// <param name="property_name">
/// the name of the property to get
/// </param>
/// <param name="value">
/// a location to return the value
/// </param>

	public static T CellGetProperty<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, string property_name, out MentorLake.GObject.GValue value) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_cell_get_property(area, renderer, property_name, out value);
		return area;
	}

/// <summary>
/// <para>
/// Gets the values of one or more cell properties for @renderer in @area.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="renderer">
/// a #GtkCellRenderer inside @area
/// </param>
/// <param name="first_property_name">
/// the name of the first property to get
/// </param>
/// <param name="var_args">
/// return location for the first property, followed
///     optionally by more name/return location pairs, followed by %NULL
/// </param>

	public static T CellGetValist<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, string first_property_name, IntPtr var_args) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_cell_get_valist(area, renderer, first_property_name, var_args);
		return area;
	}

/// <summary>
/// <para>
/// Sets one or more cell properties for @cell in @area.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="renderer">
/// a #GtkCellRenderer which is a cell inside @area
/// </param>
/// <param name="first_prop_name">
/// the name of the first cell property to set
/// </param>
/// <param name="@__arglist">
/// a %NULL-terminated list of property names and values, starting
///           with @first_prop_name
/// </param>

	public static T CellSet<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__arglist) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_cell_set(area, renderer, first_prop_name, @__arglist);
		return area;
	}

/// <summary>
/// <para>
/// Sets a cell property for @renderer in @area.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="renderer">
/// a #GtkCellRenderer inside @area
/// </param>
/// <param name="property_name">
/// the name of the cell property to set
/// </param>
/// <param name="value">
/// the value to set the cell property to
/// </param>

	public static T CellSetProperty<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, string property_name, MentorLake.GObject.GValueHandle value) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_cell_set_property(area, renderer, property_name, value);
		return area;
	}

/// <summary>
/// <para>
/// Sets one or more cell properties for @renderer in @area.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="renderer">
/// a #GtkCellRenderer which inside @area
/// </param>
/// <param name="first_property_name">
/// the name of the first cell property to set
/// </param>
/// <param name="var_args">
/// a %NULL-terminated list of property names and values, starting
///           with @first_prop_name
/// </param>

	public static T CellSetValist<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, string first_property_name, IntPtr var_args) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_cell_set_valist(area, renderer, first_property_name, var_args);
		return area;
	}

/// <summary>
/// <para>
/// This is sometimes needed for cases where rows need to share
/// alignments in one orientation but may be separately grouped
/// in the opposing orientation.
/// </para>
/// <para>
/// For instance, #GtkIconView creates all icons (rows) to have
/// the same width and the cells theirin to have the same
/// horizontal alignments. However each row of icons may have
/// a separate collective height. #GtkIconView uses this to
/// request the heights of each row based on a context which
/// was already used to request all the row widths that are
/// to be displayed.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="context">
/// the #GtkCellAreaContext to copy
/// </param>
/// <return>
/// a newly created #GtkCellAreaContext copy of @context.
/// </return>

	public static MentorLake.Gtk.GtkCellAreaContextHandle CopyContext(this MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkCellAreaContextHandle context)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_copy_context(area, context);
	}

/// <summary>
/// <para>
/// Creates a #GtkCellAreaContext to be used with @area for
/// all purposes. #GtkCellAreaContext stores geometry information
/// for rows for which it was operated on, it is important to use
/// the same context for the same row of data at all times (i.e.
/// one should render and handle events with the same #GtkCellAreaContext
/// which was used to request the size of those rows of data).
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <return>
/// a newly created #GtkCellAreaContext which can be used with @area.
/// </return>

	public static MentorLake.Gtk.GtkCellAreaContextHandle CreateContext(this MentorLake.Gtk.GtkCellAreaHandle area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_create_context(area);
	}

/// <summary>
/// <para>
/// Delegates event handling to a #GtkCellArea.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="context">
/// the #GtkCellAreaContext for this row of data.
/// </param>
/// <param name="widget">
/// the #GtkWidget that @area is rendering to
/// </param>
/// <param name="@event">
/// the #GdkEvent to handle
/// </param>
/// <param name="cell_area">
/// the @widget relative coordinates for @area
/// </param>
/// <param name="flags">
/// the #GtkCellRendererState for @area in this row.
/// </param>
/// <return>
/// %TRUE if the event was handled by @area.
/// </return>

	public static int Event(this MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkCellAreaContextHandle context, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gtk.GtkCellRendererState flags)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_event(area, context, widget, @event, cell_area, flags);
	}

/// <summary>
/// <para>
/// This should be called by the @area’s owning layout widget
/// when focus is to be passed to @area, or moved within @area
/// for a given @direction and row data.
/// </para>
/// <para>
/// Implementing #GtkCellArea classes should implement this
/// method to receive and navigate focus in its own way particular
/// to how it lays out cells.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="direction">
/// the #GtkDirectionType
/// </param>
/// <return>
/// %TRUE if focus remains inside @area as a result of this call.
/// </return>

	public static bool Focus(this MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkDirectionType direction)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_focus(area, direction);
	}

/// <summary>
/// <para>
/// Calls @callback for every #GtkCellRenderer in @area.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="callback">
/// the #GtkCellCallback to call
/// </param>
/// <param name="callback_data">
/// user provided data pointer
/// </param>

	public static T Foreach<T>(this T area, MentorLake.Gtk.GtkCellCallback callback, IntPtr callback_data) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_foreach(area, callback, callback_data);
		return area;
	}

/// <summary>
/// <para>
/// Calls @callback for every #GtkCellRenderer in @area with the
/// allocated rectangle inside @cell_area.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="context">
/// the #GtkCellAreaContext for this row of data.
/// </param>
/// <param name="widget">
/// the #GtkWidget that @area is rendering to
/// </param>
/// <param name="cell_area">
/// the @widget relative coordinates and size for @area
/// </param>
/// <param name="background_area">
/// the @widget relative coordinates of the background area
/// </param>
/// <param name="callback">
/// the #GtkCellAllocCallback to call
/// </param>
/// <param name="callback_data">
/// user provided data pointer
/// </param>

	public static T ForeachAlloc<T>(this T area, MentorLake.Gtk.GtkCellAreaContextHandle context, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gdk.GdkRectangleHandle background_area, MentorLake.Gtk.GtkCellAllocCallback callback, IntPtr callback_data) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_foreach_alloc(area, context, widget, cell_area, background_area, callback, callback_data);
		return area;
	}

/// <summary>
/// <para>
/// Derives the allocation of @renderer inside @area if @area
/// were to be renderered in @cell_area.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="context">
/// the #GtkCellAreaContext used to hold sizes for @area.
/// </param>
/// <param name="widget">
/// the #GtkWidget that @area is rendering on
/// </param>
/// <param name="renderer">
/// the #GtkCellRenderer to get the allocation for
/// </param>
/// <param name="cell_area">
/// the whole allocated area for @area in @widget
///             for this row
/// </param>
/// <param name="allocation">
/// where to store the allocation for @renderer
/// </param>

	public static T GetCellAllocation<T>(this T area, MentorLake.Gtk.GtkCellAreaContextHandle context, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkCellRendererHandle renderer, MentorLake.Gdk.GdkRectangleHandle cell_area, out MentorLake.Gdk.GdkRectangle allocation) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_get_cell_allocation(area, context, widget, renderer, cell_area, out allocation);
		return area;
	}

/// <summary>
/// <para>
/// Gets the #GtkCellRenderer at @x and @y coordinates inside @area and optionally
/// returns the full cell allocation for it inside @cell_area.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="context">
/// the #GtkCellAreaContext used to hold sizes for @area.
/// </param>
/// <param name="widget">
/// the #GtkWidget that @area is rendering on
/// </param>
/// <param name="cell_area">
/// the whole allocated area for @area in @widget
///             for this row
/// </param>
/// <param name="x">
/// the x position
/// </param>
/// <param name="y">
/// the y position
/// </param>
/// <param name="alloc_area">
/// where to store the inner allocated area of the
///                                  returned cell renderer, or %NULL.
/// </param>
/// <return>
/// the #GtkCellRenderer at @x and @y.
/// </return>

	public static MentorLake.Gtk.GtkCellRendererHandle GetCellAtPosition(this MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkCellAreaContextHandle context, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkRectangleHandle cell_area, int x, int y, out MentorLake.Gdk.GdkRectangle alloc_area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_get_cell_at_position(area, context, widget, cell_area, x, y, out alloc_area);
	}

/// <summary>
/// <para>
/// Gets the current #GtkTreePath string for the currently
/// applied #GtkTreeIter, this is implicitly updated when
/// gtk_cell_area_apply_attributes() is called and can be
/// used to interact with renderers from #GtkCellArea
/// subclasses.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <return>
/// The current #GtkTreePath string for the current
/// attributes applied to @area. This string belongs to the area and
/// should not be freed.
/// </return>

	public static string GetCurrentPathString(this MentorLake.Gtk.GtkCellAreaHandle area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_get_current_path_string(area);
	}

/// <summary>
/// <para>
/// Gets the #GtkCellEditable widget currently used
/// to edit the currently edited cell.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <return>
/// The currently active #GtkCellEditable widget
/// </return>

	public static MentorLake.Gtk.GtkCellEditableHandle GetEditWidget(this MentorLake.Gtk.GtkCellAreaHandle area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_get_edit_widget(area);
	}

/// <summary>
/// <para>
/// Gets the #GtkCellRenderer in @area that is currently
/// being edited.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <return>
/// The currently edited #GtkCellRenderer
/// </return>

	public static MentorLake.Gtk.GtkCellRendererHandle GetEditedCell(this MentorLake.Gtk.GtkCellAreaHandle area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_get_edited_cell(area);
	}

/// <summary>
/// <para>
/// Retrieves the currently focused cell for @area
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <return>
/// the currently focused cell in @area.
/// </return>

	public static MentorLake.Gtk.GtkCellRendererHandle GetFocusCell(this MentorLake.Gtk.GtkCellAreaHandle area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_get_focus_cell(area);
	}

/// <summary>
/// <para>
/// Gets the #GtkCellRenderer which is expected to be focusable
/// for which @renderer is, or may be a sibling.
/// </para>
/// <para>
/// This is handy for #GtkCellArea subclasses when handling events,
/// after determining the renderer at the event location it can
/// then chose to activate the focus cell for which the event
/// cell may have been a sibling.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="renderer">
/// the #GtkCellRenderer
/// </param>
/// <return>
/// the #GtkCellRenderer for which @renderer
///    is a sibling, or %NULL.
/// </return>

	public static MentorLake.Gtk.GtkCellRendererHandle GetFocusFromSibling(this MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkCellRendererHandle renderer)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_get_focus_from_sibling(area, renderer);
	}

/// <summary>
/// <para>
/// Gets the focus sibling cell renderers for @renderer.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="renderer">
/// the #GtkCellRenderer expected to have focus
/// </param>
/// <return>
/// A #GList of #GtkCellRenderers.
///       The returned list is internal and should not be freed.
/// </return>

	public static MentorLake.GLib.GListHandle GetFocusSiblings(this MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkCellRendererHandle renderer)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_get_focus_siblings(area, renderer);
	}

/// <summary>
/// <para>
/// Retrieves a cell area’s initial minimum and natural height.
/// </para>
/// <para>
/// @area will store some geometrical information in @context along the way;
/// when requesting sizes over an arbitrary number of rows, it’s not important
/// to check the @minimum_height and @natural_height of this call but rather to
/// consult gtk_cell_area_context_get_preferred_height() after a series of
/// requests.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="context">
/// the #GtkCellAreaContext to perform this request with
/// </param>
/// <param name="widget">
/// the #GtkWidget where @area will be rendering
/// </param>
/// <param name="minimum_height">
/// location to store the minimum height, or %NULL
/// </param>
/// <param name="natural_height">
/// location to store the natural height, or %NULL
/// </param>

	public static T GetPreferredHeight<T>(this T area, MentorLake.Gtk.GtkCellAreaContextHandle context, MentorLake.Gtk.GtkWidgetHandle widget, out int minimum_height, out int natural_height) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_get_preferred_height(area, context, widget, out minimum_height, out natural_height);
		return area;
	}

/// <summary>
/// <para>
/// Retrieves a cell area’s minimum and natural height if it would be given
/// the specified @width.
/// </para>
/// <para>
/// @area stores some geometrical information in @context along the way
/// while calling gtk_cell_area_get_preferred_width(). It’s important to
/// perform a series of gtk_cell_area_get_preferred_width() requests with
/// @context first and then call gtk_cell_area_get_preferred_height_for_width()
/// on each cell area individually to get the height for width of each
/// fully requested row.
/// </para>
/// <para>
/// If at some point, the width of a single row changes, it should be
/// requested with gtk_cell_area_get_preferred_width() again and then
/// the full width of the requested rows checked again with
/// gtk_cell_area_context_get_preferred_width().
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="context">
/// the #GtkCellAreaContext which has already been requested for widths.
/// </param>
/// <param name="widget">
/// the #GtkWidget where @area will be rendering
/// </param>
/// <param name="width">
/// the width for which to check the height of this area
/// </param>
/// <param name="minimum_height">
/// location to store the minimum height, or %NULL
/// </param>
/// <param name="natural_height">
/// location to store the natural height, or %NULL
/// </param>

	public static T GetPreferredHeightForWidth<T>(this T area, MentorLake.Gtk.GtkCellAreaContextHandle context, MentorLake.Gtk.GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_get_preferred_height_for_width(area, context, widget, width, out minimum_height, out natural_height);
		return area;
	}

/// <summary>
/// <para>
/// Retrieves a cell area’s initial minimum and natural width.
/// </para>
/// <para>
/// @area will store some geometrical information in @context along the way;
/// when requesting sizes over an arbitrary number of rows, it’s not important
/// to check the @minimum_width and @natural_width of this call but rather to
/// consult gtk_cell_area_context_get_preferred_width() after a series of
/// requests.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="context">
/// the #GtkCellAreaContext to perform this request with
/// </param>
/// <param name="widget">
/// the #GtkWidget where @area will be rendering
/// </param>
/// <param name="minimum_width">
/// location to store the minimum width, or %NULL
/// </param>
/// <param name="natural_width">
/// location to store the natural width, or %NULL
/// </param>

	public static T GetPreferredWidth<T>(this T area, MentorLake.Gtk.GtkCellAreaContextHandle context, MentorLake.Gtk.GtkWidgetHandle widget, out int minimum_width, out int natural_width) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_get_preferred_width(area, context, widget, out minimum_width, out natural_width);
		return area;
	}

/// <summary>
/// <para>
/// Retrieves a cell area’s minimum and natural width if it would be given
/// the specified @height.
/// </para>
/// <para>
/// @area stores some geometrical information in @context along the way
/// while calling gtk_cell_area_get_preferred_height(). It’s important to
/// perform a series of gtk_cell_area_get_preferred_height() requests with
/// @context first and then call gtk_cell_area_get_preferred_width_for_height()
/// on each cell area individually to get the height for width of each
/// fully requested row.
/// </para>
/// <para>
/// If at some point, the height of a single row changes, it should be
/// requested with gtk_cell_area_get_preferred_height() again and then
/// the full height of the requested rows checked again with
/// gtk_cell_area_context_get_preferred_height().
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="context">
/// the #GtkCellAreaContext which has already been requested for widths.
/// </param>
/// <param name="widget">
/// the #GtkWidget where @area will be rendering
/// </param>
/// <param name="height">
/// the height for which to check the width of this area
/// </param>
/// <param name="minimum_width">
/// location to store the minimum width, or %NULL
/// </param>
/// <param name="natural_width">
/// location to store the natural width, or %NULL
/// </param>

	public static T GetPreferredWidthForHeight<T>(this T area, MentorLake.Gtk.GtkCellAreaContextHandle context, MentorLake.Gtk.GtkWidgetHandle widget, int height, out int minimum_width, out int natural_width) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_get_preferred_width_for_height(area, context, widget, height, out minimum_width, out natural_width);
		return area;
	}

/// <summary>
/// <para>
/// Gets whether the area prefers a height-for-width layout
/// or a width-for-height layout.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <return>
/// The #GtkSizeRequestMode preferred by @area.
/// </return>

	public static MentorLake.Gtk.GtkSizeRequestMode GetRequestMode(this MentorLake.Gtk.GtkCellAreaHandle area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_get_request_mode(area);
	}

/// <summary>
/// <para>
/// Checks if @area contains @renderer.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="renderer">
/// the #GtkCellRenderer to check
/// </param>
/// <return>
/// %TRUE if @renderer is in the @area.
/// </return>

	public static bool HasRenderer(this MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkCellRendererHandle renderer)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_has_renderer(area, renderer);
	}

/// <summary>
/// <para>
/// This is a convenience function for #GtkCellArea implementations
/// to get the inner area where a given #GtkCellRenderer will be
/// rendered. It removes any padding previously added by gtk_cell_area_request_renderer().
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="widget">
/// the #GtkWidget that @area is rendering onto
/// </param>
/// <param name="cell_area">
/// the @widget relative coordinates where one of @area’s cells
///             is to be placed
/// </param>
/// <param name="inner_area">
/// the return location for the inner cell area
/// </param>

	public static T InnerCellArea<T>(this T area, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkRectangleHandle cell_area, out MentorLake.Gdk.GdkRectangle inner_area) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_inner_cell_area(area, widget, cell_area, out inner_area);
		return area;
	}

/// <summary>
/// <para>
/// Returns whether the area can do anything when activated,
/// after applying new attributes to @area.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <return>
/// whether @area can do anything when activated.
/// </return>

	public static bool IsActivatable(this MentorLake.Gtk.GtkCellAreaHandle area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_is_activatable(area);
	}

/// <summary>
/// <para>
/// Returns whether @sibling is one of @renderer’s focus siblings
/// (see gtk_cell_area_add_focus_sibling()).
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="renderer">
/// the #GtkCellRenderer expected to have focus
/// </param>
/// <param name="sibling">
/// the #GtkCellRenderer to check against @renderer’s sibling list
/// </param>
/// <return>
/// %TRUE if @sibling is a focus sibling of @renderer
/// </return>

	public static bool IsFocusSibling(this MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkCellRendererHandle renderer, MentorLake.Gtk.GtkCellRendererHandle sibling)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_is_focus_sibling(area, renderer, sibling);
	}

/// <summary>
/// <para>
/// Removes @renderer from @area.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="renderer">
/// the #GtkCellRenderer to remove from @area
/// </param>

	public static T Remove<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_remove(area, renderer);
		return area;
	}

/// <summary>
/// <para>
/// Removes @sibling from @renderer’s focus sibling list
/// (see gtk_cell_area_add_focus_sibling()).
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="renderer">
/// the #GtkCellRenderer expected to have focus
/// </param>
/// <param name="sibling">
/// the #GtkCellRenderer to remove from @renderer’s focus area
/// </param>

	public static T RemoveFocusSibling<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, MentorLake.Gtk.GtkCellRendererHandle sibling) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_remove_focus_sibling(area, renderer, sibling);
		return area;
	}

/// <summary>
/// <para>
/// Renders @area’s cells according to @area’s layout onto @widget at
/// the given coordinates.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="context">
/// the #GtkCellAreaContext for this row of data.
/// </param>
/// <param name="widget">
/// the #GtkWidget that @area is rendering to
/// </param>
/// <param name="cr">
/// the #cairo_t to render with
/// </param>
/// <param name="background_area">
/// the @widget relative coordinates for @area’s background
/// </param>
/// <param name="cell_area">
/// the @widget relative coordinates for @area
/// </param>
/// <param name="flags">
/// the #GtkCellRendererState for @area in this row.
/// </param>
/// <param name="paint_focus">
/// whether @area should paint focus on focused cells for focused rows or not.
/// </param>

	public static T Render<T>(this T area, MentorLake.Gtk.GtkCellAreaContextHandle context, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gdk.GdkRectangleHandle background_area, MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gtk.GtkCellRendererState flags, bool paint_focus) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_render(area, context, widget, cr, background_area, cell_area, flags, paint_focus);
		return area;
	}

/// <summary>
/// <para>
/// This is a convenience function for #GtkCellArea implementations
/// to request size for cell renderers. It’s important to use this
/// function to request size and then use gtk_cell_area_inner_cell_area()
/// at render and event time since this function will add padding
/// around the cell for focus painting.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="renderer">
/// the #GtkCellRenderer to request size for
/// </param>
/// <param name="orientation">
/// the #GtkOrientation in which to request size
/// </param>
/// <param name="widget">
/// the #GtkWidget that @area is rendering onto
/// </param>
/// <param name="for_size">
/// the allocation contextual size to request for, or -1 if
/// the base request for the orientation is to be returned.
/// </param>
/// <param name="minimum_size">
/// location to store the minimum size, or %NULL
/// </param>
/// <param name="natural_size">
/// location to store the natural size, or %NULL
/// </param>

	public static T RequestRenderer<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, MentorLake.Gtk.GtkOrientation orientation, MentorLake.Gtk.GtkWidgetHandle widget, int for_size, out int minimum_size, out int natural_size) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_request_renderer(area, renderer, orientation, widget, for_size, out minimum_size, out natural_size);
		return area;
	}

/// <summary>
/// <para>
/// Explicitly sets the currently focused cell to @renderer.
/// </para>
/// <para>
/// This is generally called by implementations of
/// #GtkCellAreaClass.focus() or #GtkCellAreaClass.event(),
/// however it can also be used to implement functions such
/// as gtk_tree_view_set_cursor_on_cell().
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="renderer">
/// the #GtkCellRenderer to give focus to
/// </param>

	public static T SetFocusCell<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_set_focus_cell(area, renderer);
		return area;
	}

/// <summary>
/// <para>
/// Explicitly stops the editing of the currently edited cell.
/// </para>
/// <para>
/// If @canceled is %TRUE, the currently edited cell renderer
/// will emit the ::editing-canceled signal, otherwise the
/// the ::editing-done signal will be emitted on the current
/// edit widget.
/// </para>
/// <para>
/// See gtk_cell_area_get_edited_cell() and gtk_cell_area_get_edit_widget().
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkCellArea
/// </param>
/// <param name="canceled">
/// whether editing was canceled.
/// </param>

	public static T StopEditing<T>(this T area, bool canceled) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_stop_editing(area, canceled);
		return area;
	}

}

internal class GtkCellAreaHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_area_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gtk.GtkCellRendererState flags, bool edit_only);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_area_activate_cell([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gtk.GtkCellRendererState flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_add_focus_sibling([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle sibling);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_add_with_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_apply_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, bool is_expander, bool is_expanded);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_attribute_connect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, string attribute, int column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_attribute_disconnect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, string attribute);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_cell_area_attribute_get_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, string attribute);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_cell_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_cell_get_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, string property_name, out MentorLake.GObject.GValue value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_cell_get_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, string first_property_name, IntPtr var_args);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_cell_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_cell_set_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, string property_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_cell_set_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, string first_property_name, IntPtr var_args);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))]
	internal static extern MentorLake.Gtk.GtkCellAreaContextHandle gtk_cell_area_copy_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))]
	internal static extern MentorLake.Gtk.GtkCellAreaContextHandle gtk_cell_area_create_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_cell_area_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gtk.GtkCellRendererState flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_area_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkDirectionType direction);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkCellCallback callback, IntPtr callback_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_foreach_alloc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle cell_area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle background_area, MentorLake.Gtk.GtkCellAllocCallback callback, IntPtr callback_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_get_cell_allocation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle cell_area, out MentorLake.Gdk.GdkRectangle allocation);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))]
	internal static extern MentorLake.Gtk.GtkCellRendererHandle gtk_cell_area_get_cell_at_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle cell_area, int x, int y, out MentorLake.Gdk.GdkRectangle alloc_area);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_cell_area_get_current_path_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))]
	internal static extern MentorLake.Gtk.GtkCellEditableHandle gtk_cell_area_get_edit_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))]
	internal static extern MentorLake.Gtk.GtkCellRendererHandle gtk_cell_area_get_edited_cell([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))]
	internal static extern MentorLake.Gtk.GtkCellRendererHandle gtk_cell_area_get_focus_cell([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))]
	internal static extern MentorLake.Gtk.GtkCellRendererHandle gtk_cell_area_get_focus_from_sibling([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_cell_area_get_focus_siblings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_get_preferred_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out int minimum_height, out int natural_height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_get_preferred_height_for_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_get_preferred_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out int minimum_width, out int natural_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_get_preferred_width_for_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int height, out int minimum_width, out int natural_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSizeRequestMode gtk_cell_area_get_request_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_area_has_renderer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_inner_cell_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle cell_area, out MentorLake.Gdk.GdkRectangle inner_area);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_area_is_activatable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_area_is_focus_sibling([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle sibling);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_remove_focus_sibling([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle sibling);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_render([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle background_area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gtk.GtkCellRendererState flags, bool paint_focus);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_request_renderer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, MentorLake.Gtk.GtkOrientation orientation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int for_size, out int minimum_size, out int natural_size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_set_focus_cell([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_stop_editing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, bool canceled);

}
