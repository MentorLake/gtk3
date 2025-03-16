namespace MentorLake.Gtk;

public class GtkCellRendererHandle : GInitiallyUnownedHandle
{
}
public static class GtkCellRendererHandleSignalExtensions
{

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

public struct EditingCanceledSignal
{
	public MentorLake.Gtk.GtkCellRendererHandle Self;
	public IntPtr UserData;
}

public struct EditingStartedSignal
{
	public MentorLake.Gtk.GtkCellRendererHandle Self;
	public MentorLake.Gtk.GtkCellEditableHandle Editable;
	public string Path;
	public IntPtr UserData;
}
}

public static class GtkCellRendererHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void editing_canceled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void editing_started([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle editable, string path, IntPtr user_data);

}


public static class GtkCellRendererHandleExtensions
{
	public static bool Activate(this MentorLake.Gtk.GtkCellRendererHandle cell, MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gtk.GtkWidgetHandle widget, string path, MentorLake.Gdk.GdkRectangleHandle background_area, MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gtk.GtkCellRendererState flags)
	{
		return GtkCellRendererHandleExterns.gtk_cell_renderer_activate(cell, @event, widget, path, background_area, cell_area, flags);
	}

	public static T GetAlignedArea<T>(this T cell, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkCellRendererState flags, MentorLake.Gdk.GdkRectangleHandle cell_area, out MentorLake.Gdk.GdkRectangle aligned_area) where T : GtkCellRendererHandle
	{
		GtkCellRendererHandleExterns.gtk_cell_renderer_get_aligned_area(cell, widget, flags, cell_area, out aligned_area);
		return cell;
	}

	public static T GetAlignment<T>(this T cell, out float xalign, out float yalign) where T : GtkCellRendererHandle
	{
		GtkCellRendererHandleExterns.gtk_cell_renderer_get_alignment(cell, out xalign, out yalign);
		return cell;
	}

	public static T GetFixedSize<T>(this T cell, out int width, out int height) where T : GtkCellRendererHandle
	{
		GtkCellRendererHandleExterns.gtk_cell_renderer_get_fixed_size(cell, out width, out height);
		return cell;
	}

	public static T GetPadding<T>(this T cell, out int xpad, out int ypad) where T : GtkCellRendererHandle
	{
		GtkCellRendererHandleExterns.gtk_cell_renderer_get_padding(cell, out xpad, out ypad);
		return cell;
	}

	public static T GetPreferredHeight<T>(this T cell, MentorLake.Gtk.GtkWidgetHandle widget, out int minimum_size, out int natural_size) where T : GtkCellRendererHandle
	{
		GtkCellRendererHandleExterns.gtk_cell_renderer_get_preferred_height(cell, widget, out minimum_size, out natural_size);
		return cell;
	}

	public static T GetPreferredHeightForWidth<T>(this T cell, MentorLake.Gtk.GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height) where T : GtkCellRendererHandle
	{
		GtkCellRendererHandleExterns.gtk_cell_renderer_get_preferred_height_for_width(cell, widget, width, out minimum_height, out natural_height);
		return cell;
	}

	public static T GetPreferredSize<T>(this T cell, MentorLake.Gtk.GtkWidgetHandle widget, out MentorLake.Gtk.GtkRequisition minimum_size, out MentorLake.Gtk.GtkRequisition natural_size) where T : GtkCellRendererHandle
	{
		GtkCellRendererHandleExterns.gtk_cell_renderer_get_preferred_size(cell, widget, out minimum_size, out natural_size);
		return cell;
	}

	public static T GetPreferredWidth<T>(this T cell, MentorLake.Gtk.GtkWidgetHandle widget, out int minimum_size, out int natural_size) where T : GtkCellRendererHandle
	{
		GtkCellRendererHandleExterns.gtk_cell_renderer_get_preferred_width(cell, widget, out minimum_size, out natural_size);
		return cell;
	}

	public static T GetPreferredWidthForHeight<T>(this T cell, MentorLake.Gtk.GtkWidgetHandle widget, int height, out int minimum_width, out int natural_width) where T : GtkCellRendererHandle
	{
		GtkCellRendererHandleExterns.gtk_cell_renderer_get_preferred_width_for_height(cell, widget, height, out minimum_width, out natural_width);
		return cell;
	}

	public static MentorLake.Gtk.GtkSizeRequestMode GetRequestMode(this MentorLake.Gtk.GtkCellRendererHandle cell)
	{
		return GtkCellRendererHandleExterns.gtk_cell_renderer_get_request_mode(cell);
	}

	public static bool GetSensitive(this MentorLake.Gtk.GtkCellRendererHandle cell)
	{
		return GtkCellRendererHandleExterns.gtk_cell_renderer_get_sensitive(cell);
	}

	public static T GetSize<T>(this T cell, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkRectangleHandle cell_area, out int x_offset, out int y_offset, out int width, out int height) where T : GtkCellRendererHandle
	{
		GtkCellRendererHandleExterns.gtk_cell_renderer_get_size(cell, widget, cell_area, out x_offset, out y_offset, out width, out height);
		return cell;
	}

	public static MentorLake.Gtk.GtkStateFlags GetState(this MentorLake.Gtk.GtkCellRendererHandle cell, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkCellRendererState cell_state)
	{
		return GtkCellRendererHandleExterns.gtk_cell_renderer_get_state(cell, widget, cell_state);
	}

	public static bool GetVisible(this MentorLake.Gtk.GtkCellRendererHandle cell)
	{
		return GtkCellRendererHandleExterns.gtk_cell_renderer_get_visible(cell);
	}

	public static bool IsActivatable(this MentorLake.Gtk.GtkCellRendererHandle cell)
	{
		return GtkCellRendererHandleExterns.gtk_cell_renderer_is_activatable(cell);
	}

	public static T Render<T>(this T cell, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkRectangleHandle background_area, MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gtk.GtkCellRendererState flags) where T : GtkCellRendererHandle
	{
		GtkCellRendererHandleExterns.gtk_cell_renderer_render(cell, cr, widget, background_area, cell_area, flags);
		return cell;
	}

	public static T SetAlignment<T>(this T cell, float xalign, float yalign) where T : GtkCellRendererHandle
	{
		GtkCellRendererHandleExterns.gtk_cell_renderer_set_alignment(cell, xalign, yalign);
		return cell;
	}

	public static T SetFixedSize<T>(this T cell, int width, int height) where T : GtkCellRendererHandle
	{
		GtkCellRendererHandleExterns.gtk_cell_renderer_set_fixed_size(cell, width, height);
		return cell;
	}

	public static T SetPadding<T>(this T cell, int xpad, int ypad) where T : GtkCellRendererHandle
	{
		GtkCellRendererHandleExterns.gtk_cell_renderer_set_padding(cell, xpad, ypad);
		return cell;
	}

	public static T SetSensitive<T>(this T cell, bool sensitive) where T : GtkCellRendererHandle
	{
		GtkCellRendererHandleExterns.gtk_cell_renderer_set_sensitive(cell, sensitive);
		return cell;
	}

	public static T SetVisible<T>(this T cell, bool visible) where T : GtkCellRendererHandle
	{
		GtkCellRendererHandleExterns.gtk_cell_renderer_set_visible(cell, visible);
		return cell;
	}

	public static MentorLake.Gtk.GtkCellEditableHandle StartEditing(this MentorLake.Gtk.GtkCellRendererHandle cell, MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gtk.GtkWidgetHandle widget, string path, MentorLake.Gdk.GdkRectangleHandle background_area, MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gtk.GtkCellRendererState flags)
	{
		return GtkCellRendererHandleExterns.gtk_cell_renderer_start_editing(cell, @event, widget, path, background_area, cell_area, flags);
	}

	public static T StopEditing<T>(this T cell, bool canceled) where T : GtkCellRendererHandle
	{
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
	internal static extern MentorLake.Gtk.GtkCellEditableHandle gtk_cell_renderer_start_editing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle background_area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle cell_area, MentorLake.Gtk.GtkCellRendererState flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_stop_editing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, bool canceled);

}
