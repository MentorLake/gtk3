namespace MentorLake.Gtk3.Gtk3;

public class GtkCellAreaHandle : GInitiallyUnownedHandle, GtkBuildableHandle, GtkCellLayoutHandle
{
}

public static class GtkCellAreaSignalExtensions
{

	public static IObservable<GtkCellAreaSignalStructs.AddEditableSignal> Signal_AddEditable(this GtkCellAreaHandle instance)
	{
		return Observable.Create((IObserver<GtkCellAreaSignalStructs.AddEditableSignal> obs) =>
		{
			GtkCellAreaSignalDelegates.add_editable handler = (GtkCellAreaHandle self, GtkCellRendererHandle renderer, GtkCellEditableHandle editable, GdkRectangle cell_area, string path, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellAreaSignalStructs.AddEditableSignal()
				{
					Self = self, Renderer = renderer, Editable = editable, CellArea = cell_area, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "add_editable", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkCellAreaSignalStructs.ApplyAttributesSignal> Signal_ApplyAttributes(this GtkCellAreaHandle instance)
	{
		return Observable.Create((IObserver<GtkCellAreaSignalStructs.ApplyAttributesSignal> obs) =>
		{
			GtkCellAreaSignalDelegates.apply_attributes handler = (GtkCellAreaHandle self, GtkTreeModelHandle model, GtkTreeIterHandle iter, bool is_expander, bool is_expanded, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellAreaSignalStructs.ApplyAttributesSignal()
				{
					Self = self, Model = model, Iter = iter, IsExpander = is_expander, IsExpanded = is_expanded, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "apply_attributes", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkCellAreaSignalStructs.FocusChangedSignal> Signal_FocusChanged(this GtkCellAreaHandle instance)
	{
		return Observable.Create((IObserver<GtkCellAreaSignalStructs.FocusChangedSignal> obs) =>
		{
			GtkCellAreaSignalDelegates.focus_changed handler = (GtkCellAreaHandle self, GtkCellRendererHandle renderer, string path, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellAreaSignalStructs.FocusChangedSignal()
				{
					Self = self, Renderer = renderer, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "focus_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkCellAreaSignalStructs.RemoveEditableSignal> Signal_RemoveEditable(this GtkCellAreaHandle instance)
	{
		return Observable.Create((IObserver<GtkCellAreaSignalStructs.RemoveEditableSignal> obs) =>
		{
			GtkCellAreaSignalDelegates.remove_editable handler = (GtkCellAreaHandle self, GtkCellRendererHandle renderer, GtkCellEditableHandle editable, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellAreaSignalStructs.RemoveEditableSignal()
				{
					Self = self, Renderer = renderer, Editable = editable, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "remove_editable", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkCellAreaSignalStructs
{

public struct AddEditableSignal
{
	public GtkCellAreaHandle Self;
	public GtkCellRendererHandle Renderer;
	public GtkCellEditableHandle Editable;
	public GdkRectangle CellArea;
	public string Path;
	public IntPtr UserData;
}

public struct ApplyAttributesSignal
{
	public GtkCellAreaHandle Self;
	public GtkTreeModelHandle Model;
	public GtkTreeIterHandle Iter;
	public bool IsExpander;
	public bool IsExpanded;
	public IntPtr UserData;
}

public struct FocusChangedSignal
{
	public GtkCellAreaHandle Self;
	public GtkCellRendererHandle Renderer;
	public string Path;
	public IntPtr UserData;
}

public struct RemoveEditableSignal
{
	public GtkCellAreaHandle Self;
	public GtkCellRendererHandle Renderer;
	public GtkCellEditableHandle Editable;
	public IntPtr UserData;
}
}

public static class GtkCellAreaSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void add_editable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellAreaHandle>))] GtkCellAreaHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellRendererHandle>))] GtkCellRendererHandle renderer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellEditableHandleImpl>))] GtkCellEditableHandle editable, GdkRectangle cell_area, string path, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void apply_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellAreaHandle>))] GtkCellAreaHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeModelHandleImpl>))] GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeIterHandle>))] GtkTreeIterHandle iter, bool is_expander, bool is_expanded, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void focus_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellAreaHandle>))] GtkCellAreaHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellRendererHandle>))] GtkCellRendererHandle renderer, string path, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void remove_editable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellAreaHandle>))] GtkCellAreaHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellRendererHandle>))] GtkCellRendererHandle renderer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellEditableHandleImpl>))] GtkCellEditableHandle editable, IntPtr user_data);

}


public static class GtkCellAreaHandleExtensions
{
	public static bool Activate(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkRectangleHandle cell_area, GtkCellRendererState flags, bool edit_only)
	{
		return GtkCellAreaExterns.gtk_cell_area_activate(area, context, widget, cell_area, flags, edit_only);
	}

	public static bool ActivateCell(this GtkCellAreaHandle area, GtkWidgetHandle widget, GtkCellRendererHandle renderer, GdkEventHandle @event, GdkRectangleHandle cell_area, GtkCellRendererState flags)
	{
		return GtkCellAreaExterns.gtk_cell_area_activate_cell(area, widget, renderer, @event, cell_area, flags);
	}

	public static T Add<T>(this T area, GtkCellRendererHandle renderer) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_add(area, renderer);
		return area;
	}

	public static T AddFocusSibling<T>(this T area, GtkCellRendererHandle renderer, GtkCellRendererHandle sibling) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_add_focus_sibling(area, renderer, sibling);
		return area;
	}

	public static T AddWithProperties<T>(this T area, GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__arglist) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_add_with_properties(area, renderer, first_prop_name, @__arglist);
		return area;
	}

	public static T ApplyAttributes<T>(this T area, GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, bool is_expander, bool is_expanded) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_apply_attributes(area, tree_model, iter, is_expander, is_expanded);
		return area;
	}

	public static T AttributeConnect<T>(this T area, GtkCellRendererHandle renderer, string attribute, int column) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_attribute_connect(area, renderer, attribute, column);
		return area;
	}

	public static T AttributeDisconnect<T>(this T area, GtkCellRendererHandle renderer, string attribute) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_attribute_disconnect(area, renderer, attribute);
		return area;
	}

	public static int AttributeGetColumn(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, string attribute)
	{
		return GtkCellAreaExterns.gtk_cell_area_attribute_get_column(area, renderer, attribute);
	}

	public static T CellGet<T>(this T area, GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__arglist) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_cell_get(area, renderer, first_prop_name, @__arglist);
		return area;
	}

	public static T CellGetProperty<T>(this T area, GtkCellRendererHandle renderer, string property_name, GValueHandle value) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_cell_get_property(area, renderer, property_name, value);
		return area;
	}

	public static T CellGetValist<T>(this T area, GtkCellRendererHandle renderer, string first_property_name, out IntPtr var_args) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_cell_get_valist(area, renderer, first_property_name, out var_args);
		return area;
	}

	public static T CellSet<T>(this T area, GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__arglist) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_cell_set(area, renderer, first_prop_name, @__arglist);
		return area;
	}

	public static T CellSetProperty<T>(this T area, GtkCellRendererHandle renderer, string property_name, GValueHandle value) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_cell_set_property(area, renderer, property_name, value);
		return area;
	}

	public static T CellSetValist<T>(this T area, GtkCellRendererHandle renderer, string first_property_name, IntPtr var_args) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_cell_set_valist(area, renderer, first_property_name, var_args);
		return area;
	}

	public static GtkCellAreaContextHandle CopyContext(this GtkCellAreaHandle area, GtkCellAreaContextHandle context)
	{
		return GtkCellAreaExterns.gtk_cell_area_copy_context(area, context);
	}

	public static GtkCellAreaContextHandle CreateContext(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_cell_area_create_context(area);
	}

	public static int Event(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkEventHandle @event, GdkRectangleHandle cell_area, GtkCellRendererState flags)
	{
		return GtkCellAreaExterns.gtk_cell_area_event(area, context, widget, @event, cell_area, flags);
	}

	public static bool Focus(this GtkCellAreaHandle area, GtkDirectionType direction)
	{
		return GtkCellAreaExterns.gtk_cell_area_focus(area, direction);
	}

	public static T Foreach<T>(this T area, GtkCellCallback callback, IntPtr callback_data) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_foreach(area, callback, callback_data);
		return area;
	}

	public static T ForeachAlloc<T>(this T area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkRectangleHandle cell_area, GdkRectangleHandle background_area, GtkCellAllocCallback callback, IntPtr callback_data) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_foreach_alloc(area, context, widget, cell_area, background_area, callback, callback_data);
		return area;
	}

	public static T GetCellAllocation<T>(this T area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GtkCellRendererHandle renderer, GdkRectangleHandle cell_area, out GdkRectangle allocation) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_get_cell_allocation(area, context, widget, renderer, cell_area, out allocation);
		return area;
	}

	public static GtkCellRendererHandle GetCellAtPosition(this GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkRectangleHandle cell_area, int x, int y, out GdkRectangle alloc_area)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_cell_at_position(area, context, widget, cell_area, x, y, out alloc_area);
	}

	public static string GetCurrentPathString(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_current_path_string(area);
	}

	public static GtkCellEditableHandle GetEditWidget(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_edit_widget(area);
	}

	public static GtkCellRendererHandle GetEditedCell(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_edited_cell(area);
	}

	public static GtkCellRendererHandle GetFocusCell(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_focus_cell(area);
	}

	public static GtkCellRendererHandle GetFocusFromSibling(this GtkCellAreaHandle area, GtkCellRendererHandle renderer)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_focus_from_sibling(area, renderer);
	}

	public static GListHandle GetFocusSiblings(this GtkCellAreaHandle area, GtkCellRendererHandle renderer)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_focus_siblings(area, renderer);
	}

	public static T GetPreferredHeight<T>(this T area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, out int minimum_height, out int natural_height) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_get_preferred_height(area, context, widget, out minimum_height, out natural_height);
		return area;
	}

	public static T GetPreferredHeightForWidth<T>(this T area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_get_preferred_height_for_width(area, context, widget, width, out minimum_height, out natural_height);
		return area;
	}

	public static T GetPreferredWidth<T>(this T area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, out int minimum_width, out int natural_width) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_get_preferred_width(area, context, widget, out minimum_width, out natural_width);
		return area;
	}

	public static T GetPreferredWidthForHeight<T>(this T area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, int height, out int minimum_width, out int natural_width) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_get_preferred_width_for_height(area, context, widget, height, out minimum_width, out natural_width);
		return area;
	}

	public static GtkSizeRequestMode GetRequestMode(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_cell_area_get_request_mode(area);
	}

	public static bool HasRenderer(this GtkCellAreaHandle area, GtkCellRendererHandle renderer)
	{
		return GtkCellAreaExterns.gtk_cell_area_has_renderer(area, renderer);
	}

	public static T InnerCellArea<T>(this T area, GtkWidgetHandle widget, GdkRectangleHandle cell_area, out GdkRectangle inner_area) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_inner_cell_area(area, widget, cell_area, out inner_area);
		return area;
	}

	public static bool IsActivatable(this GtkCellAreaHandle area)
	{
		return GtkCellAreaExterns.gtk_cell_area_is_activatable(area);
	}

	public static bool IsFocusSibling(this GtkCellAreaHandle area, GtkCellRendererHandle renderer, GtkCellRendererHandle sibling)
	{
		return GtkCellAreaExterns.gtk_cell_area_is_focus_sibling(area, renderer, sibling);
	}

	public static T Remove<T>(this T area, GtkCellRendererHandle renderer) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_remove(area, renderer);
		return area;
	}

	public static T RemoveFocusSibling<T>(this T area, GtkCellRendererHandle renderer, GtkCellRendererHandle sibling) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_remove_focus_sibling(area, renderer, sibling);
		return area;
	}

	public static T Render<T>(this T area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, cairo_tHandle cr, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags, bool paint_focus) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_render(area, context, widget, cr, background_area, cell_area, flags, paint_focus);
		return area;
	}

	public static T RequestRenderer<T>(this T area, GtkCellRendererHandle renderer, GtkOrientation orientation, GtkWidgetHandle widget, int for_size, out int minimum_size, out int natural_size) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_request_renderer(area, renderer, orientation, widget, for_size, out minimum_size, out natural_size);
		return area;
	}

	public static T SetFocusCell<T>(this T area, GtkCellRendererHandle renderer) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_set_focus_cell(area, renderer);
		return area;
	}

	public static T StopEditing<T>(this T area, bool canceled) where T : GtkCellAreaHandle
	{
		GtkCellAreaExterns.gtk_cell_area_stop_editing(area, canceled);
		return area;
	}

}

internal class GtkCellAreaExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_cell_area_activate(GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkRectangleHandle cell_area, GtkCellRendererState flags, bool edit_only);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_cell_area_activate_cell(GtkCellAreaHandle area, GtkWidgetHandle widget, GtkCellRendererHandle renderer, GdkEventHandle @event, GdkRectangleHandle cell_area, GtkCellRendererState flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_add(GtkCellAreaHandle area, GtkCellRendererHandle renderer);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_add_focus_sibling(GtkCellAreaHandle area, GtkCellRendererHandle renderer, GtkCellRendererHandle sibling);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_add_with_properties(GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_apply_attributes(GtkCellAreaHandle area, GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, bool is_expander, bool is_expanded);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_attribute_connect(GtkCellAreaHandle area, GtkCellRendererHandle renderer, string attribute, int column);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_attribute_disconnect(GtkCellAreaHandle area, GtkCellRendererHandle renderer, string attribute);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_cell_area_attribute_get_column(GtkCellAreaHandle area, GtkCellRendererHandle renderer, string attribute);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_cell_get(GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_cell_get_property(GtkCellAreaHandle area, GtkCellRendererHandle renderer, string property_name, GValueHandle value);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_cell_get_valist(GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_property_name, out IntPtr var_args);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_cell_set(GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_cell_set_property(GtkCellAreaHandle area, GtkCellRendererHandle renderer, string property_name, GValueHandle value);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_cell_set_valist(GtkCellAreaHandle area, GtkCellRendererHandle renderer, string first_property_name, IntPtr var_args);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCellAreaContextHandle gtk_cell_area_copy_context(GtkCellAreaHandle area, GtkCellAreaContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCellAreaContextHandle gtk_cell_area_create_context(GtkCellAreaHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_cell_area_event(GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkEventHandle @event, GdkRectangleHandle cell_area, GtkCellRendererState flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_cell_area_focus(GtkCellAreaHandle area, GtkDirectionType direction);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_foreach(GtkCellAreaHandle area, GtkCellCallback callback, IntPtr callback_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_foreach_alloc(GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkRectangleHandle cell_area, GdkRectangleHandle background_area, GtkCellAllocCallback callback, IntPtr callback_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_get_cell_allocation(GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GtkCellRendererHandle renderer, GdkRectangleHandle cell_area, out GdkRectangle allocation);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCellRendererHandle gtk_cell_area_get_cell_at_position(GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, GdkRectangleHandle cell_area, int x, int y, out GdkRectangle alloc_area);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_cell_area_get_current_path_string(GtkCellAreaHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCellEditableHandle gtk_cell_area_get_edit_widget(GtkCellAreaHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCellRendererHandle gtk_cell_area_get_edited_cell(GtkCellAreaHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCellRendererHandle gtk_cell_area_get_focus_cell(GtkCellAreaHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCellRendererHandle gtk_cell_area_get_focus_from_sibling(GtkCellAreaHandle area, GtkCellRendererHandle renderer);

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_cell_area_get_focus_siblings(GtkCellAreaHandle area, GtkCellRendererHandle renderer);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_get_preferred_height(GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, out int minimum_height, out int natural_height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_get_preferred_height_for_width(GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_get_preferred_width(GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, out int minimum_width, out int natural_width);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_get_preferred_width_for_height(GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, int height, out int minimum_width, out int natural_width);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSizeRequestMode gtk_cell_area_get_request_mode(GtkCellAreaHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_cell_area_has_renderer(GtkCellAreaHandle area, GtkCellRendererHandle renderer);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_inner_cell_area(GtkCellAreaHandle area, GtkWidgetHandle widget, GdkRectangleHandle cell_area, out GdkRectangle inner_area);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_cell_area_is_activatable(GtkCellAreaHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_cell_area_is_focus_sibling(GtkCellAreaHandle area, GtkCellRendererHandle renderer, GtkCellRendererHandle sibling);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_remove(GtkCellAreaHandle area, GtkCellRendererHandle renderer);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_remove_focus_sibling(GtkCellAreaHandle area, GtkCellRendererHandle renderer, GtkCellRendererHandle sibling);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_render(GtkCellAreaHandle area, GtkCellAreaContextHandle context, GtkWidgetHandle widget, cairo_tHandle cr, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags, bool paint_focus);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_request_renderer(GtkCellAreaHandle area, GtkCellRendererHandle renderer, GtkOrientation orientation, GtkWidgetHandle widget, int for_size, out int minimum_size, out int natural_size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_set_focus_cell(GtkCellAreaHandle area, GtkCellRendererHandle renderer);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_area_stop_editing(GtkCellAreaHandle area, bool canceled);

}
