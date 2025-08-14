namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkStyle object encapsulates the information that provides the look and
/// feel for a widget.
/// </para>
/// <para>
/// > In GTK+ 3.0, GtkStyle has been deprecated and replaced by
/// > #GtkStyleContext.
/// </para>
/// <para>
/// Each #GtkWidget has an associated #GtkStyle object that is used when
/// rendering that widget. Also, a #GtkStyle holds information for the five
/// possible widget states though not every widget supports all five
/// states; see #GtkStateType.
/// </para>
/// <para>
/// Usually the #GtkStyle for a widget is the same as the default style that
/// is set by GTK+ and modified the theme engine.
/// </para>
/// <para>
/// Usually applications should not need to use or modify the #GtkStyle of
/// their widgets.
/// </para>
/// </summary>

public class GtkStyleHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkStyle.
/// </para>
/// </summary>

/// <return>
/// a new #GtkStyle.
/// </return>

	public static MentorLake.Gtk.GtkStyleHandle New()
	{
		return GtkStyleHandleExterns.gtk_style_new();
	}

}
public static class GtkStyleHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when the style has been initialized for a particular
/// visual. Connecting to this signal is probably seldom
/// useful since most of the time applications and widgets only
/// deal with styles that have been already realized.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when the aspects of the style specific to a particular visual
/// is being cleaned up. A connection to this signal can be useful
/// if a widget wants to cache objects as object data on #GtkStyle.
/// This signal provides a convenient place to free such cached objects.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// Emitted when the style has been initialized for a particular
/// visual. Connecting to this signal is probably seldom
/// useful since most of the time applications and widgets only
/// deal with styles that have been already realized.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void realize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the aspects of the style specific to a particular visual
/// is being cleaned up. A connection to this signal can be useful
/// if a widget wants to cache objects as object data on #GtkStyle.
/// This signal provides a convenient place to free such cached objects.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unrealize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle self, IntPtr user_data);

}


public static class GtkStyleHandleExtensions
{

/// <param name="style">
/// </param>
/// <param name="cr">
/// </param>
/// <param name="window">
/// </param>
/// <param name="state_type">
/// </param>
/// <param name="x">
/// </param>
/// <param name="y">
/// </param>
/// <param name="width">
/// </param>
/// <param name="height">
/// </param>

	public static T ApplyDefaultBackground<T>(this T style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gtk.GtkStateType state_type, int x, int y, int width, int height) where T : GtkStyleHandle
	{
		if (style.IsInvalid) throw new Exception("Invalid handle (GtkStyleHandle)");
		GtkStyleHandleExterns.gtk_style_apply_default_background(style, cr, window, state_type, x, y, width, height);
		return style;
	}

/// <summary>
/// <para>
/// Attaches a style to a window; this process allocates the
/// colors and creates the GC’s for the style - it specializes
/// it to a particular visual. The process may involve the creation
/// of a new style if the style has already been attached to a
/// window with a different style and visual.
/// </para>
/// <para>
/// Since this function may return a new object, you have to use it
/// in the following way:
/// `style = gtk_style_attach (style, window)`
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle.
/// </param>
/// <param name="window">
/// a #GdkWindow.
/// </param>
/// <return>
/// Either @style, or a newly-created #GtkStyle.
///   If the style is newly created, the style parameter
///   will be unref'ed, and the new style will have
///   a reference count belonging to the caller.
/// </return>

	public static MentorLake.Gtk.GtkStyleHandle Attach(this MentorLake.Gtk.GtkStyleHandle style, MentorLake.Gdk.GdkWindowHandle window)
	{
		if (style.IsInvalid) throw new Exception("Invalid handle (GtkStyleHandle)");
		return GtkStyleHandleExterns.gtk_style_attach(style, window);
	}

/// <summary>
/// <para>
/// Creates a copy of the passed in #GtkStyle object.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <return>
/// a copy of @style
/// </return>

	public static MentorLake.Gtk.GtkStyleHandle Copy(this MentorLake.Gtk.GtkStyleHandle style)
	{
		if (style.IsInvalid) throw new Exception("Invalid handle (GtkStyleHandle)");
		return GtkStyleHandleExterns.gtk_style_copy(style);
	}

/// <summary>
/// <para>
/// Detaches a style from a window. If the style is not attached
/// to any windows anymore, it is unrealized. See gtk_style_attach().
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>

	public static T Detach<T>(this T style) where T : GtkStyleHandle
	{
		if (style.IsInvalid) throw new Exception("Invalid handle (GtkStyleHandle)");
		GtkStyleHandleExterns.gtk_style_detach(style);
		return style;
	}

/// <summary>
/// <para>
/// Gets the values of a multiple style properties for @widget_type
/// from @style.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="widget_type">
/// the #GType of a descendant of #GtkWidget
/// </param>
/// <param name="first_property_name">
/// the name of the first style property to get
/// </param>
/// <param name="@__arglist">
/// pairs of property names and locations to
///   return the property values, starting with the location for
///   @first_property_name, terminated by %NULL.
/// </param>

	public static T Get<T>(this T style, MentorLake.GObject.GType widget_type, string first_property_name, IntPtr @__arglist) where T : GtkStyleHandle
	{
		if (style.IsInvalid) throw new Exception("Invalid handle (GtkStyleHandle)");
		GtkStyleHandleExterns.gtk_style_get(style, widget_type, first_property_name, @__arglist);
		return style;
	}

/// <summary>
/// <para>
/// Queries the value of a style property corresponding to a
/// widget class is in the given style.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="widget_type">
/// the #GType of a descendant of #GtkWidget
/// </param>
/// <param name="property_name">
/// the name of the style property to get
/// </param>
/// <param name="value">
/// a #GValue where the value of the property being
///     queried will be stored
/// </param>

	public static T GetStyleProperty<T>(this T style, MentorLake.GObject.GType widget_type, string property_name, out MentorLake.GObject.GValue value) where T : GtkStyleHandle
	{
		if (style.IsInvalid) throw new Exception("Invalid handle (GtkStyleHandle)");
		GtkStyleHandleExterns.gtk_style_get_style_property(style, widget_type, property_name, out value);
		return style;
	}

/// <summary>
/// <para>
/// Non-vararg variant of gtk_style_get().
/// Used primarily by language bindings.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="widget_type">
/// the #GType of a descendant of #GtkWidget
/// </param>
/// <param name="first_property_name">
/// the name of the first style property to get
/// </param>
/// <param name="var_args">
/// a va_list of pairs of property names and
///     locations to return the property values, starting with the
///     location for @first_property_name.
/// </param>

	public static T GetValist<T>(this T style, MentorLake.GObject.GType widget_type, string first_property_name, IntPtr var_args) where T : GtkStyleHandle
	{
		if (style.IsInvalid) throw new Exception("Invalid handle (GtkStyleHandle)");
		GtkStyleHandleExterns.gtk_style_get_valist(style, widget_type, first_property_name, var_args);
		return style;
	}

/// <summary>
/// <para>
/// Returns whether @style has an associated #GtkStyleContext.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <return>
/// %TRUE if @style has a #GtkStyleContext
/// </return>

	public static bool HasContext(this MentorLake.Gtk.GtkStyleHandle style)
	{
		if (style.IsInvalid) throw new Exception("Invalid handle (GtkStyleHandle)");
		return GtkStyleHandleExterns.gtk_style_has_context(style);
	}

/// <summary>
/// <para>
/// Looks up @color_name in the style’s logical color mappings,
/// filling in @color and returning %TRUE if found, otherwise
/// returning %FALSE. Do not cache the found mapping, because
/// it depends on the #GtkStyle and might change when a theme
/// switch occurs.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="color_name">
/// the name of the logical color to look up
/// </param>
/// <param name="color">
/// the #GdkColor to fill in
/// </param>
/// <return>
/// %TRUE if the mapping was found.
/// </return>

	public static bool LookupColor(this MentorLake.Gtk.GtkStyleHandle style, string color_name, out MentorLake.Gdk.GdkColor color)
	{
		if (style.IsInvalid) throw new Exception("Invalid handle (GtkStyleHandle)");
		return GtkStyleHandleExterns.gtk_style_lookup_color(style, color_name, out color);
	}

/// <summary>
/// <para>
/// Looks up @stock_id in the icon factories associated with @style
/// and the default icon factory, returning an icon set if found,
/// otherwise %NULL.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="stock_id">
/// an icon name
/// </param>
/// <return>
/// icon set of @stock_id
/// </return>

	public static MentorLake.Gtk.GtkIconSetHandle LookupIconSet(this MentorLake.Gtk.GtkStyleHandle style, string stock_id)
	{
		if (style.IsInvalid) throw new Exception("Invalid handle (GtkStyleHandle)");
		return GtkStyleHandleExterns.gtk_style_lookup_icon_set(style, stock_id);
	}

/// <summary>
/// <para>
/// Renders the icon specified by @source at the given @size
/// according to the given parameters and returns the result in a
/// pixbuf.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="source">
/// the #GtkIconSource specifying the icon to render
/// </param>
/// <param name="direction">
/// a text direction
/// </param>
/// <param name="state">
/// a state
/// </param>
/// <param name="size">
/// the size to render the icon at (#GtkIconSize). A size of
///     `(GtkIconSize)-1` means render at the size of the source and
///     don’t scale.
/// </param>
/// <param name="widget">
/// the widget
/// </param>
/// <param name="detail">
/// a style detail
/// </param>
/// <return>
/// a newly-created #GdkPixbuf
///     containing the rendered icon
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle RenderIcon(this MentorLake.Gtk.GtkStyleHandle style, MentorLake.Gtk.GtkIconSourceHandle source, MentorLake.Gtk.GtkTextDirection direction, MentorLake.Gtk.GtkStateType state, MentorLake.Gtk.GtkIconSize size, MentorLake.Gtk.GtkWidgetHandle widget, string detail)
	{
		if (style.IsInvalid) throw new Exception("Invalid handle (GtkStyleHandle)");
		return GtkStyleHandleExterns.gtk_style_render_icon(style, source, direction, state, size, widget, detail);
	}

/// <summary>
/// <para>
/// Sets the background of @window to the background color or pixmap
/// specified by @style for the given state.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="state_type">
/// a state
/// </param>

	public static T SetBackground<T>(this T style, MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gtk.GtkStateType state_type) where T : GtkStyleHandle
	{
		if (style.IsInvalid) throw new Exception("Invalid handle (GtkStyleHandle)");
		GtkStyleHandleExterns.gtk_style_set_background(style, window, state_type);
		return style;
	}

}

internal class GtkStyleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))]
	internal static extern MentorLake.Gtk.GtkStyleHandle gtk_style_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_apply_default_background([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gtk.GtkStateType state_type, int x, int y, int width, int height);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))]
	internal static extern MentorLake.Gtk.GtkStyleHandle gtk_style_attach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))]
	internal static extern MentorLake.Gtk.GtkIconSetHandle gtk_style_lookup_icon_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, string stock_id);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_style_render_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source, MentorLake.Gtk.GtkTextDirection direction, MentorLake.Gtk.GtkStateType state, MentorLake.Gtk.GtkIconSize size, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_set_background([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gtk.GtkStateType state_type);

}
