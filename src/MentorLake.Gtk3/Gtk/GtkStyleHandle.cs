namespace MentorLake.Gtk;

public class GtkStyleHandle : GObjectHandle
{
	public static MentorLake.Gtk.GtkStyleHandle New()
	{
		return GtkStyleHandleExterns.gtk_style_new();
	}

}
public static class GtkStyleHandleSignalExtensions
{

	public static IObservable<GtkStyleHandleSignalStructs.RealizeSignal> Signal_Realize(this GtkStyleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkStyleHandleSignalStructs.RealizeSignal> obs) =>
		{
			GtkStyleHandleSignalDelegates.realize handler = ( MentorLake.Gtk.GtkStyleHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStyleHandleSignalStructs.RealizeSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "realize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkStyleHandleSignalStructs.UnrealizeSignal> Signal_Unrealize(this GtkStyleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkStyleHandleSignalStructs.UnrealizeSignal> obs) =>
		{
			GtkStyleHandleSignalDelegates.unrealize handler = ( MentorLake.Gtk.GtkStyleHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStyleHandleSignalStructs.UnrealizeSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "unrealize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkStyleHandleSignalStructs
{

public class RealizeSignal
{
	public MentorLake.Gtk.GtkStyleHandle Self;
	public IntPtr UserData;
}

public class UnrealizeSignal
{
	public MentorLake.Gtk.GtkStyleHandle Self;
	public IntPtr UserData;
}
}

public static class GtkStyleHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void realize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unrealize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle self, IntPtr user_data);

}


public static class GtkStyleHandleExtensions
{
	public static T ApplyDefaultBackground<T>(this T style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gtk.GtkStateType state_type, int x, int y, int width, int height) where T : GtkStyleHandle
	{
		if (style.IsInvalid || style.IsClosed) throw new Exception("Invalid or closed handle (GtkStyleHandle)");
		GtkStyleHandleExterns.gtk_style_apply_default_background(style, cr, window, state_type, x, y, width, height);
		return style;
	}

	public static MentorLake.Gtk.GtkStyleHandle Attach(this MentorLake.Gtk.GtkStyleHandle style, MentorLake.Gdk.GdkWindowHandle window)
	{
		if (style.IsInvalid || style.IsClosed) throw new Exception("Invalid or closed handle (GtkStyleHandle)");
		return GtkStyleHandleExterns.gtk_style_attach(style, window);
	}

	public static MentorLake.Gtk.GtkStyleHandle Copy(this MentorLake.Gtk.GtkStyleHandle style)
	{
		if (style.IsInvalid || style.IsClosed) throw new Exception("Invalid or closed handle (GtkStyleHandle)");
		return GtkStyleHandleExterns.gtk_style_copy(style);
	}

	public static T Detach<T>(this T style) where T : GtkStyleHandle
	{
		if (style.IsInvalid || style.IsClosed) throw new Exception("Invalid or closed handle (GtkStyleHandle)");
		GtkStyleHandleExterns.gtk_style_detach(style);
		return style;
	}

	public static T Get<T>(this T style, MentorLake.GObject.GType widget_type, string first_property_name, IntPtr @__arglist) where T : GtkStyleHandle
	{
		if (style.IsInvalid || style.IsClosed) throw new Exception("Invalid or closed handle (GtkStyleHandle)");
		GtkStyleHandleExterns.gtk_style_get(style, widget_type, first_property_name, @__arglist);
		return style;
	}

	public static T GetStyleProperty<T>(this T style, MentorLake.GObject.GType widget_type, string property_name, out MentorLake.GObject.GValue value) where T : GtkStyleHandle
	{
		if (style.IsInvalid || style.IsClosed) throw new Exception("Invalid or closed handle (GtkStyleHandle)");
		GtkStyleHandleExterns.gtk_style_get_style_property(style, widget_type, property_name, out value);
		return style;
	}

	public static T GetValist<T>(this T style, MentorLake.GObject.GType widget_type, string first_property_name, IntPtr var_args) where T : GtkStyleHandle
	{
		if (style.IsInvalid || style.IsClosed) throw new Exception("Invalid or closed handle (GtkStyleHandle)");
		GtkStyleHandleExterns.gtk_style_get_valist(style, widget_type, first_property_name, var_args);
		return style;
	}

	public static bool HasContext(this MentorLake.Gtk.GtkStyleHandle style)
	{
		if (style.IsInvalid || style.IsClosed) throw new Exception("Invalid or closed handle (GtkStyleHandle)");
		return GtkStyleHandleExterns.gtk_style_has_context(style);
	}

	public static bool LookupColor(this MentorLake.Gtk.GtkStyleHandle style, string color_name, out MentorLake.Gdk.GdkColor color)
	{
		if (style.IsInvalid || style.IsClosed) throw new Exception("Invalid or closed handle (GtkStyleHandle)");
		return GtkStyleHandleExterns.gtk_style_lookup_color(style, color_name, out color);
	}

	public static MentorLake.Gtk.GtkIconSetHandle LookupIconSet(this MentorLake.Gtk.GtkStyleHandle style, string stock_id)
	{
		if (style.IsInvalid || style.IsClosed) throw new Exception("Invalid or closed handle (GtkStyleHandle)");
		return GtkStyleHandleExterns.gtk_style_lookup_icon_set(style, stock_id);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle RenderIcon(this MentorLake.Gtk.GtkStyleHandle style, MentorLake.Gtk.GtkIconSourceHandle source, MentorLake.Gtk.GtkTextDirection direction, MentorLake.Gtk.GtkStateType state, MentorLake.Gtk.GtkIconSize size, MentorLake.Gtk.GtkWidgetHandle widget, string detail)
	{
		if (style.IsInvalid || style.IsClosed) throw new Exception("Invalid or closed handle (GtkStyleHandle)");
		return GtkStyleHandleExterns.gtk_style_render_icon(style, source, direction, state, size, widget, detail);
	}

	public static T SetBackground<T>(this T style, MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gtk.GtkStateType state_type) where T : GtkStyleHandle
	{
		if (style.IsInvalid || style.IsClosed) throw new Exception("Invalid or closed handle (GtkStyleHandle)");
		GtkStyleHandleExterns.gtk_style_set_background(style, window, state_type);
		return style;
	}

}

internal class GtkStyleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStyleHandle gtk_style_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_apply_default_background([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gtk.GtkStateType state_type, int x, int y, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStyleHandle gtk_style_attach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStyleHandle gtk_style_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_detach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, MentorLake.GObject.GType widget_type, string first_property_name, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_get_style_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, MentorLake.GObject.GType widget_type, string property_name, out MentorLake.GObject.GValue value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_get_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, MentorLake.GObject.GType widget_type, string first_property_name, IntPtr var_args);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_style_has_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_style_lookup_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, string color_name, out MentorLake.Gdk.GdkColor color);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkIconSetHandle gtk_style_lookup_icon_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_style_render_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source, MentorLake.Gtk.GtkTextDirection direction, MentorLake.Gtk.GtkStateType state, MentorLake.Gtk.GtkIconSize size, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_set_background([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gtk.GtkStateType state_type);

}
