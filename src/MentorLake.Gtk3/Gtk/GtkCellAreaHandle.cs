namespace MentorLake.Gtk;

public class GtkCellAreaHandle : GInitiallyUnownedHandle, GtkBuildableHandle, GtkCellLayoutHandle
{
}
public static class GtkCellAreaHandleSignalExtensions
{

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
	public MentorLake.Gtk.GtkCellRendererHandle Renderer;
	public MentorLake.Gtk.GtkCellEditableHandle Editable;
	public MentorLake.Gdk.GdkRectangleHandle CellArea;
	public string Path;
	public IntPtr UserData;
}

public class ApplyAttributesSignal
{
	public MentorLake.Gtk.GtkCellAreaHandle Self;
	public MentorLake.Gtk.GtkTreeModelHandle Model;
	public MentorLake.Gtk.GtkTreeIterHandle Iter;
	public bool IsExpander;
	public bool IsExpanded;
	public IntPtr UserData;
}

public class FocusChangedSignal
{
	public MentorLake.Gtk.GtkCellAreaHandle Self;
	public MentorLake.Gtk.GtkCellRendererHandle Renderer;
	public string Path;
	public IntPtr UserData;
}

public class RemoveEditableSignal
{
	public MentorLake.Gtk.GtkCellAreaHandle Self;
	public MentorLake.Gtk.GtkCellRendererHandle Renderer;
	public MentorLake.Gtk.GtkCellEditableHandle Editable;
	public IntPtr UserData;
}
}

public static class GtkCellAreaHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void add_editable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle editable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle cell_area, string path, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void apply_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, bool is_expander, bool is_expanded, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void focus_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, string path, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void remove_editable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle editable, IntPtr user_data);

}


public static class GtkCellAreaHandleExtensions
{
	public static bool Activate(this MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkCellAreaContextHandle context, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gtk.GtkCellRendererState flags, bool edit_only)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_activate(area, context, widget, cell_area, flags, edit_only);
	}

	public static bool ActivateCell(this MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkCellRendererHandle renderer, MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gtk.GtkCellRendererState flags)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_activate_cell(area, widget, renderer, @event, cell_area, flags);
	}

	public static T Add<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_add(area, renderer);
		return area;
	}

	public static T AddFocusSibling<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, MentorLake.Gtk.GtkCellRendererHandle sibling) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_add_focus_sibling(area, renderer, sibling);
		return area;
	}

	public static T AddWithProperties<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__arglist) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_add_with_properties(area, renderer, first_prop_name, @__arglist);
		return area;
	}

	public static T ApplyAttributes<T>(this T area, MentorLake.Gtk.GtkTreeModelHandle tree_model, MentorLake.Gtk.GtkTreeIterHandle iter, bool is_expander, bool is_expanded) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_apply_attributes(area, tree_model, iter, is_expander, is_expanded);
		return area;
	}

	public static T AttributeConnect<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, string attribute, int column) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_attribute_connect(area, renderer, attribute, column);
		return area;
	}

	public static T AttributeDisconnect<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, string attribute) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_attribute_disconnect(area, renderer, attribute);
		return area;
	}

	public static int AttributeGetColumn(this MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkCellRendererHandle renderer, string attribute)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_attribute_get_column(area, renderer, attribute);
	}

	public static T CellGet<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__arglist) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_cell_get(area, renderer, first_prop_name, @__arglist);
		return area;
	}

	public static T CellGetProperty<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, string property_name, out MentorLake.GObject.GValue value) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_cell_get_property(area, renderer, property_name, out value);
		return area;
	}

	public static T CellGetValist<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, string first_property_name, IntPtr var_args) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_cell_get_valist(area, renderer, first_property_name, var_args);
		return area;
	}

	public static T CellSet<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, string first_prop_name, IntPtr @__arglist) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_cell_set(area, renderer, first_prop_name, @__arglist);
		return area;
	}

	public static T CellSetProperty<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, string property_name, MentorLake.GObject.GValueHandle value) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_cell_set_property(area, renderer, property_name, value);
		return area;
	}

	public static T CellSetValist<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, string first_property_name, IntPtr var_args) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_cell_set_valist(area, renderer, first_property_name, var_args);
		return area;
	}

	public static MentorLake.Gtk.GtkCellAreaContextHandle CopyContext(this MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkCellAreaContextHandle context)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_copy_context(area, context);
	}

	public static MentorLake.Gtk.GtkCellAreaContextHandle CreateContext(this MentorLake.Gtk.GtkCellAreaHandle area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_create_context(area);
	}

	public static int Event(this MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkCellAreaContextHandle context, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gtk.GtkCellRendererState flags)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_event(area, context, widget, @event, cell_area, flags);
	}

	public static bool Focus(this MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkDirectionType direction)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_focus(area, direction);
	}

	public static T Foreach<T>(this T area, MentorLake.Gtk.GtkCellCallback callback, IntPtr callback_data) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_foreach(area, callback, callback_data);
		return area;
	}

	public static T ForeachAlloc<T>(this T area, MentorLake.Gtk.GtkCellAreaContextHandle context, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gdk.GdkRectangleHandle background_area, MentorLake.Gtk.GtkCellAllocCallback callback, IntPtr callback_data) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_foreach_alloc(area, context, widget, cell_area, background_area, callback, callback_data);
		return area;
	}

	public static T GetCellAllocation<T>(this T area, MentorLake.Gtk.GtkCellAreaContextHandle context, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkCellRendererHandle renderer, MentorLake.Gdk.GdkRectangleHandle cell_area, out MentorLake.Gdk.GdkRectangle allocation) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_get_cell_allocation(area, context, widget, renderer, cell_area, out allocation);
		return area;
	}

	public static MentorLake.Gtk.GtkCellRendererHandle GetCellAtPosition(this MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkCellAreaContextHandle context, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkRectangleHandle cell_area, int x, int y, out MentorLake.Gdk.GdkRectangle alloc_area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_get_cell_at_position(area, context, widget, cell_area, x, y, out alloc_area);
	}

	public static string GetCurrentPathString(this MentorLake.Gtk.GtkCellAreaHandle area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_get_current_path_string(area);
	}

	public static MentorLake.Gtk.GtkCellEditableHandle GetEditWidget(this MentorLake.Gtk.GtkCellAreaHandle area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_get_edit_widget(area);
	}

	public static MentorLake.Gtk.GtkCellRendererHandle GetEditedCell(this MentorLake.Gtk.GtkCellAreaHandle area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_get_edited_cell(area);
	}

	public static MentorLake.Gtk.GtkCellRendererHandle GetFocusCell(this MentorLake.Gtk.GtkCellAreaHandle area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_get_focus_cell(area);
	}

	public static MentorLake.Gtk.GtkCellRendererHandle GetFocusFromSibling(this MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkCellRendererHandle renderer)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_get_focus_from_sibling(area, renderer);
	}

	public static MentorLake.GLib.GListHandle GetFocusSiblings(this MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkCellRendererHandle renderer)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_get_focus_siblings(area, renderer);
	}

	public static T GetPreferredHeight<T>(this T area, MentorLake.Gtk.GtkCellAreaContextHandle context, MentorLake.Gtk.GtkWidgetHandle widget, out int minimum_height, out int natural_height) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_get_preferred_height(area, context, widget, out minimum_height, out natural_height);
		return area;
	}

	public static T GetPreferredHeightForWidth<T>(this T area, MentorLake.Gtk.GtkCellAreaContextHandle context, MentorLake.Gtk.GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_get_preferred_height_for_width(area, context, widget, width, out minimum_height, out natural_height);
		return area;
	}

	public static T GetPreferredWidth<T>(this T area, MentorLake.Gtk.GtkCellAreaContextHandle context, MentorLake.Gtk.GtkWidgetHandle widget, out int minimum_width, out int natural_width) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_get_preferred_width(area, context, widget, out minimum_width, out natural_width);
		return area;
	}

	public static T GetPreferredWidthForHeight<T>(this T area, MentorLake.Gtk.GtkCellAreaContextHandle context, MentorLake.Gtk.GtkWidgetHandle widget, int height, out int minimum_width, out int natural_width) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_get_preferred_width_for_height(area, context, widget, height, out minimum_width, out natural_width);
		return area;
	}

	public static MentorLake.Gtk.GtkSizeRequestMode GetRequestMode(this MentorLake.Gtk.GtkCellAreaHandle area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_get_request_mode(area);
	}

	public static bool HasRenderer(this MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkCellRendererHandle renderer)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_has_renderer(area, renderer);
	}

	public static T InnerCellArea<T>(this T area, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkRectangleHandle cell_area, out MentorLake.Gdk.GdkRectangle inner_area) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_inner_cell_area(area, widget, cell_area, out inner_area);
		return area;
	}

	public static bool IsActivatable(this MentorLake.Gtk.GtkCellAreaHandle area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_is_activatable(area);
	}

	public static bool IsFocusSibling(this MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkCellRendererHandle renderer, MentorLake.Gtk.GtkCellRendererHandle sibling)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		return GtkCellAreaHandleExterns.gtk_cell_area_is_focus_sibling(area, renderer, sibling);
	}

	public static T Remove<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_remove(area, renderer);
		return area;
	}

	public static T RemoveFocusSibling<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, MentorLake.Gtk.GtkCellRendererHandle sibling) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_remove_focus_sibling(area, renderer, sibling);
		return area;
	}

	public static T Render<T>(this T area, MentorLake.Gtk.GtkCellAreaContextHandle context, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gdk.GdkRectangleHandle background_area, MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gtk.GtkCellRendererState flags, bool paint_focus) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_render(area, context, widget, cr, background_area, cell_area, flags, paint_focus);
		return area;
	}

	public static T RequestRenderer<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer, MentorLake.Gtk.GtkOrientation orientation, MentorLake.Gtk.GtkWidgetHandle widget, int for_size, out int minimum_size, out int natural_size) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_request_renderer(area, renderer, orientation, widget, for_size, out minimum_size, out natural_size);
		return area;
	}

	public static T SetFocusCell<T>(this T area, MentorLake.Gtk.GtkCellRendererHandle renderer) where T : GtkCellAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaHandle)");
		GtkCellAreaHandleExterns.gtk_cell_area_set_focus_cell(area, renderer);
		return area;
	}

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
