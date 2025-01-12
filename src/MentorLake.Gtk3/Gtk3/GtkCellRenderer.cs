namespace MentorLake.Gtk3.Gtk3;

public class GtkCellRendererHandle : GInitiallyUnownedHandle
{
}

public static class GtkCellRendererSignalExtensions
{

	public static IObservable<GtkCellRendererSignalStructs.EditingCanceledSignal> Signal_EditingCanceled(this GtkCellRendererHandle instance)
	{
		return Observable.Create((IObserver<GtkCellRendererSignalStructs.EditingCanceledSignal> obs) =>
		{
			GtkCellRendererSignalDelegates.editing_canceled handler = (GtkCellRendererHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellRendererSignalStructs.EditingCanceledSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "editing_canceled", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkCellRendererSignalStructs.EditingStartedSignal> Signal_EditingStarted(this GtkCellRendererHandle instance)
	{
		return Observable.Create((IObserver<GtkCellRendererSignalStructs.EditingStartedSignal> obs) =>
		{
			GtkCellRendererSignalDelegates.editing_started handler = (GtkCellRendererHandle self, GtkCellEditableHandle editable, string path, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellRendererSignalStructs.EditingStartedSignal()
				{
					Self = self, Editable = editable, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "editing_started", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkCellRendererSignalStructs
{

public struct EditingCanceledSignal
{
	public GtkCellRendererHandle Self;
	public IntPtr UserData;
}

public struct EditingStartedSignal
{
	public GtkCellRendererHandle Self;
	public GtkCellEditableHandle Editable;
	public string Path;
	public IntPtr UserData;
}
}

public static class GtkCellRendererSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void editing_canceled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellRendererHandle>))] GtkCellRendererHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void editing_started([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellRendererHandle>))] GtkCellRendererHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellEditableHandleImpl>))] GtkCellEditableHandle editable, string path, IntPtr user_data);

}


public static class GtkCellRendererHandleExtensions
{
	public static bool Activate(this GtkCellRendererHandle cell, GdkEventHandle @event, GtkWidgetHandle widget, string path, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_activate(cell, @event, widget, path, background_area, cell_area, flags);
	}

	public static T GetAlignedArea<T>(this T cell, GtkWidgetHandle widget, GtkCellRendererState flags, GdkRectangleHandle cell_area, out GdkRectangle aligned_area) where T : GtkCellRendererHandle
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_aligned_area(cell, widget, flags, cell_area, out aligned_area);
		return cell;
	}

	public static T GetAlignment<T>(this T cell, out float xalign, out float yalign) where T : GtkCellRendererHandle
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_alignment(cell, out xalign, out yalign);
		return cell;
	}

	public static T GetFixedSize<T>(this T cell, out int width, out int height) where T : GtkCellRendererHandle
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_fixed_size(cell, out width, out height);
		return cell;
	}

	public static T GetPadding<T>(this T cell, out int xpad, out int ypad) where T : GtkCellRendererHandle
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_padding(cell, out xpad, out ypad);
		return cell;
	}

	public static T GetPreferredHeight<T>(this T cell, GtkWidgetHandle widget, out int minimum_size, out int natural_size) where T : GtkCellRendererHandle
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_preferred_height(cell, widget, out minimum_size, out natural_size);
		return cell;
	}

	public static T GetPreferredHeightForWidth<T>(this T cell, GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height) where T : GtkCellRendererHandle
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_preferred_height_for_width(cell, widget, width, out minimum_height, out natural_height);
		return cell;
	}

	public static T GetPreferredSize<T>(this T cell, GtkWidgetHandle widget, out GtkRequisition minimum_size, out GtkRequisition natural_size) where T : GtkCellRendererHandle
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_preferred_size(cell, widget, out minimum_size, out natural_size);
		return cell;
	}

	public static T GetPreferredWidth<T>(this T cell, GtkWidgetHandle widget, out int minimum_size, out int natural_size) where T : GtkCellRendererHandle
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_preferred_width(cell, widget, out minimum_size, out natural_size);
		return cell;
	}

	public static T GetPreferredWidthForHeight<T>(this T cell, GtkWidgetHandle widget, int height, out int minimum_width, out int natural_width) where T : GtkCellRendererHandle
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_preferred_width_for_height(cell, widget, height, out minimum_width, out natural_width);
		return cell;
	}

	public static GtkSizeRequestMode GetRequestMode(this GtkCellRendererHandle cell)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_get_request_mode(cell);
	}

	public static bool GetSensitive(this GtkCellRendererHandle cell)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_get_sensitive(cell);
	}

	public static T GetSize<T>(this T cell, GtkWidgetHandle widget, GdkRectangleHandle cell_area, out int x_offset, out int y_offset, out int width, out int height) where T : GtkCellRendererHandle
	{
		GtkCellRendererExterns.gtk_cell_renderer_get_size(cell, widget, cell_area, out x_offset, out y_offset, out width, out height);
		return cell;
	}

	public static GtkStateFlags GetState(this GtkCellRendererHandle cell, GtkWidgetHandle widget, GtkCellRendererState cell_state)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_get_state(cell, widget, cell_state);
	}

	public static bool GetVisible(this GtkCellRendererHandle cell)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_get_visible(cell);
	}

	public static bool IsActivatable(this GtkCellRendererHandle cell)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_is_activatable(cell);
	}

	public static T Render<T>(this T cell, cairo_tHandle cr, GtkWidgetHandle widget, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags) where T : GtkCellRendererHandle
	{
		GtkCellRendererExterns.gtk_cell_renderer_render(cell, cr, widget, background_area, cell_area, flags);
		return cell;
	}

	public static T SetAlignment<T>(this T cell, float xalign, float yalign) where T : GtkCellRendererHandle
	{
		GtkCellRendererExterns.gtk_cell_renderer_set_alignment(cell, xalign, yalign);
		return cell;
	}

	public static T SetFixedSize<T>(this T cell, int width, int height) where T : GtkCellRendererHandle
	{
		GtkCellRendererExterns.gtk_cell_renderer_set_fixed_size(cell, width, height);
		return cell;
	}

	public static T SetPadding<T>(this T cell, int xpad, int ypad) where T : GtkCellRendererHandle
	{
		GtkCellRendererExterns.gtk_cell_renderer_set_padding(cell, xpad, ypad);
		return cell;
	}

	public static T SetSensitive<T>(this T cell, bool sensitive) where T : GtkCellRendererHandle
	{
		GtkCellRendererExterns.gtk_cell_renderer_set_sensitive(cell, sensitive);
		return cell;
	}

	public static T SetVisible<T>(this T cell, bool visible) where T : GtkCellRendererHandle
	{
		GtkCellRendererExterns.gtk_cell_renderer_set_visible(cell, visible);
		return cell;
	}

	public static GtkCellEditableHandle StartEditing(this GtkCellRendererHandle cell, GdkEventHandle @event, GtkWidgetHandle widget, string path, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags)
	{
		return GtkCellRendererExterns.gtk_cell_renderer_start_editing(cell, @event, widget, path, background_area, cell_area, flags);
	}

	public static T StopEditing<T>(this T cell, bool canceled) where T : GtkCellRendererHandle
	{
		GtkCellRendererExterns.gtk_cell_renderer_stop_editing(cell, canceled);
		return cell;
	}

}

internal class GtkCellRendererExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_cell_renderer_activate(GtkCellRendererHandle cell, GdkEventHandle @event, GtkWidgetHandle widget, string path, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_renderer_get_aligned_area(GtkCellRendererHandle cell, GtkWidgetHandle widget, GtkCellRendererState flags, GdkRectangleHandle cell_area, out GdkRectangle aligned_area);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_renderer_get_alignment(GtkCellRendererHandle cell, out float xalign, out float yalign);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_renderer_get_fixed_size(GtkCellRendererHandle cell, out int width, out int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_renderer_get_padding(GtkCellRendererHandle cell, out int xpad, out int ypad);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_renderer_get_preferred_height(GtkCellRendererHandle cell, GtkWidgetHandle widget, out int minimum_size, out int natural_size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_renderer_get_preferred_height_for_width(GtkCellRendererHandle cell, GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_renderer_get_preferred_size(GtkCellRendererHandle cell, GtkWidgetHandle widget, out GtkRequisition minimum_size, out GtkRequisition natural_size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_renderer_get_preferred_width(GtkCellRendererHandle cell, GtkWidgetHandle widget, out int minimum_size, out int natural_size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_renderer_get_preferred_width_for_height(GtkCellRendererHandle cell, GtkWidgetHandle widget, int height, out int minimum_width, out int natural_width);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSizeRequestMode gtk_cell_renderer_get_request_mode(GtkCellRendererHandle cell);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_cell_renderer_get_sensitive(GtkCellRendererHandle cell);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_renderer_get_size(GtkCellRendererHandle cell, GtkWidgetHandle widget, GdkRectangleHandle cell_area, out int x_offset, out int y_offset, out int width, out int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStateFlags gtk_cell_renderer_get_state(GtkCellRendererHandle cell, GtkWidgetHandle widget, GtkCellRendererState cell_state);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_cell_renderer_get_visible(GtkCellRendererHandle cell);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_cell_renderer_is_activatable(GtkCellRendererHandle cell);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_renderer_render(GtkCellRendererHandle cell, cairo_tHandle cr, GtkWidgetHandle widget, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_renderer_set_alignment(GtkCellRendererHandle cell, float xalign, float yalign);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_renderer_set_fixed_size(GtkCellRendererHandle cell, int width, int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_renderer_set_padding(GtkCellRendererHandle cell, int xpad, int ypad);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_renderer_set_sensitive(GtkCellRendererHandle cell, bool sensitive);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_renderer_set_visible(GtkCellRendererHandle cell, bool visible);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCellEditableHandle gtk_cell_renderer_start_editing(GtkCellRendererHandle cell, GdkEventHandle @event, GtkWidgetHandle widget, string path, GdkRectangleHandle background_area, GdkRectangleHandle cell_area, GtkCellRendererState flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_renderer_stop_editing(GtkCellRendererHandle cell, bool canceled);

}
