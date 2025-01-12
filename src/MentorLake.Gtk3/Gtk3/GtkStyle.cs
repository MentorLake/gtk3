namespace MentorLake.Gtk3.Gtk3;

public class GtkStyleHandle : GObjectHandle
{
	public static GtkStyleHandle New()
	{
		return GtkStyleExterns.gtk_style_new();
	}

}

public static class GtkStyleSignalExtensions
{

	public static IObservable<GtkStyleSignalStructs.RealizeSignal> Signal_Realize(this GtkStyleHandle instance)
	{
		return Observable.Create((IObserver<GtkStyleSignalStructs.RealizeSignal> obs) =>
		{
			GtkStyleSignalDelegates.realize handler = (GtkStyleHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStyleSignalStructs.RealizeSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "realize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkStyleSignalStructs.UnrealizeSignal> Signal_Unrealize(this GtkStyleHandle instance)
	{
		return Observable.Create((IObserver<GtkStyleSignalStructs.UnrealizeSignal> obs) =>
		{
			GtkStyleSignalDelegates.unrealize handler = (GtkStyleHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStyleSignalStructs.UnrealizeSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "unrealize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkStyleSignalStructs
{

public struct RealizeSignal
{
	public GtkStyleHandle Self;
	public IntPtr UserData;
}

public struct UnrealizeSignal
{
	public GtkStyleHandle Self;
	public IntPtr UserData;
}
}

public static class GtkStyleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void realize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkStyleHandle>))] GtkStyleHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unrealize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkStyleHandle>))] GtkStyleHandle self, IntPtr user_data);

}


public static class GtkStyleHandleExtensions
{
	public static T ApplyDefaultBackground<T>(this T style, cairo_tHandle cr, GdkWindowHandle window, GtkStateType state_type, int x, int y, int width, int height) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_style_apply_default_background(style, cr, window, state_type, x, y, width, height);
		return style;
	}

	public static GtkStyleHandle Attach(this GtkStyleHandle style, GdkWindowHandle window)
	{
		return GtkStyleExterns.gtk_style_attach(style, window);
	}

	public static GtkStyleHandle Copy(this GtkStyleHandle style)
	{
		return GtkStyleExterns.gtk_style_copy(style);
	}

	public static T Detach<T>(this T style) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_style_detach(style);
		return style;
	}

	public static T Get<T>(this T style, GType widget_type, string first_property_name, IntPtr @__arglist) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_style_get(style, widget_type, first_property_name, @__arglist);
		return style;
	}

	public static T GetStyleProperty<T>(this T style, GType widget_type, string property_name, out GValue value) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_style_get_style_property(style, widget_type, property_name, out value);
		return style;
	}

	public static T GetValist<T>(this T style, GType widget_type, string first_property_name, IntPtr var_args) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_style_get_valist(style, widget_type, first_property_name, var_args);
		return style;
	}

	public static bool HasContext(this GtkStyleHandle style)
	{
		return GtkStyleExterns.gtk_style_has_context(style);
	}

	public static bool LookupColor(this GtkStyleHandle style, string color_name, out GdkColor color)
	{
		return GtkStyleExterns.gtk_style_lookup_color(style, color_name, out color);
	}

	public static GtkIconSetHandle LookupIconSet(this GtkStyleHandle style, string stock_id)
	{
		return GtkStyleExterns.gtk_style_lookup_icon_set(style, stock_id);
	}

	public static GdkPixbufHandle RenderIcon(this GtkStyleHandle style, GtkIconSourceHandle source, GtkTextDirection direction, GtkStateType state, GtkIconSize size, GtkWidgetHandle widget, string detail)
	{
		return GtkStyleExterns.gtk_style_render_icon(style, source, direction, state, size, widget, detail);
	}

	public static T SetBackground<T>(this T style, GdkWindowHandle window, GtkStateType state_type) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_style_set_background(style, window, state_type);
		return style;
	}

	public static T GtkPaintShadow<T>(this T style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_paint_shadow(style, cr, state_type, shadow_type, widget, detail, x, y, width, height);
		return style;
	}

	public static T GtkPaintDiamond<T>(this T style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_paint_diamond(style, cr, state_type, shadow_type, widget, detail, x, y, width, height);
		return style;
	}

	public static T GtkPaintFlatBox<T>(this T style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_paint_flat_box(style, cr, state_type, shadow_type, widget, detail, x, y, width, height);
		return style;
	}

	public static T GtkPaintCheck<T>(this T style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_paint_check(style, cr, state_type, shadow_type, widget, detail, x, y, width, height);
		return style;
	}

	public static T GtkPaintLayout<T>(this T style, cairo_tHandle cr, GtkStateType state_type, bool use_text, GtkWidgetHandle widget, string detail, int x, int y, PangoLayoutHandle layout) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_paint_layout(style, cr, state_type, use_text, widget, detail, x, y, layout);
		return style;
	}

	public static T GtkPaintExpander<T>(this T style, cairo_tHandle cr, GtkStateType state_type, GtkWidgetHandle widget, string detail, int x, int y, GtkExpanderStyle expander_style) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_paint_expander(style, cr, state_type, widget, detail, x, y, expander_style);
		return style;
	}

	public static T GtkPaintTab<T>(this T style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_paint_tab(style, cr, state_type, shadow_type, widget, detail, x, y, width, height);
		return style;
	}

	public static T GtkPaintBoxGap<T>(this T style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height, GtkPositionType gap_side, int gap_x, int gap_width) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_paint_box_gap(style, cr, state_type, shadow_type, widget, detail, x, y, width, height, gap_side, gap_x, gap_width);
		return style;
	}

	public static T GtkPaintExtension<T>(this T style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height, GtkPositionType gap_side) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_paint_extension(style, cr, state_type, shadow_type, widget, detail, x, y, width, height, gap_side);
		return style;
	}

	public static T GtkPaintFocus<T>(this T style, cairo_tHandle cr, GtkStateType state_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_paint_focus(style, cr, state_type, widget, detail, x, y, width, height);
		return style;
	}

	public static T GtkPaintResizeGrip<T>(this T style, cairo_tHandle cr, GtkStateType state_type, GtkWidgetHandle widget, string detail, GdkWindowEdge edge, int x, int y, int width, int height) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_paint_resize_grip(style, cr, state_type, widget, detail, edge, x, y, width, height);
		return style;
	}

	public static T GtkPaintShadowGap<T>(this T style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height, GtkPositionType gap_side, int gap_x, int gap_width) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_paint_shadow_gap(style, cr, state_type, shadow_type, widget, detail, x, y, width, height, gap_side, gap_x, gap_width);
		return style;
	}

	public static T GtkPaintSlider<T>(this T style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height, GtkOrientation orientation) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_paint_slider(style, cr, state_type, shadow_type, widget, detail, x, y, width, height, orientation);
		return style;
	}

	public static T GtkPaintHandle<T>(this T style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height, GtkOrientation orientation) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_paint_handle(style, cr, state_type, shadow_type, widget, detail, x, y, width, height, orientation);
		return style;
	}

	public static T GtkPaintArrow<T>(this T style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, GtkArrowType arrow_type, bool fill, int x, int y, int width, int height) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_paint_arrow(style, cr, state_type, shadow_type, widget, detail, arrow_type, fill, x, y, width, height);
		return style;
	}

	public static T GtkPaintOption<T>(this T style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_paint_option(style, cr, state_type, shadow_type, widget, detail, x, y, width, height);
		return style;
	}

	public static T GtkPaintBox<T>(this T style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_paint_box(style, cr, state_type, shadow_type, widget, detail, x, y, width, height);
		return style;
	}

	public static T GtkPaintHline<T>(this T style, cairo_tHandle cr, GtkStateType state_type, GtkWidgetHandle widget, string detail, int x1, int x2, int y) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_paint_hline(style, cr, state_type, widget, detail, x1, x2, y);
		return style;
	}

	public static T GtkPaintVline<T>(this T style, cairo_tHandle cr, GtkStateType state_type, GtkWidgetHandle widget, string detail, int y1_, int y2_, int x) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_paint_vline(style, cr, state_type, widget, detail, y1_, y2_, x);
		return style;
	}

	public static T GtkPaintSpinner<T>(this T style, cairo_tHandle cr, GtkStateType state_type, GtkWidgetHandle widget, string detail, uint step, int x, int y, int width, int height) where T : GtkStyleHandle
	{
		GtkStyleExterns.gtk_paint_spinner(style, cr, state_type, widget, detail, step, x, y, width, height);
		return style;
	}

}

internal class GtkStyleExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStyleHandle gtk_style_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_apply_default_background(GtkStyleHandle style, cairo_tHandle cr, GdkWindowHandle window, GtkStateType state_type, int x, int y, int width, int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStyleHandle gtk_style_attach(GtkStyleHandle style, GdkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStyleHandle gtk_style_copy(GtkStyleHandle style);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_detach(GtkStyleHandle style);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_get(GtkStyleHandle style, GType widget_type, string first_property_name, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_get_style_property(GtkStyleHandle style, GType widget_type, string property_name, out GValue value);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_get_valist(GtkStyleHandle style, GType widget_type, string first_property_name, IntPtr var_args);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_style_has_context(GtkStyleHandle style);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_style_lookup_color(GtkStyleHandle style, string color_name, out GdkColor color);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconSetHandle gtk_style_lookup_icon_set(GtkStyleHandle style, string stock_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_style_render_icon(GtkStyleHandle style, GtkIconSourceHandle source, GtkTextDirection direction, GtkStateType state, GtkIconSize size, GtkWidgetHandle widget, string detail);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_set_background(GtkStyleHandle style, GdkWindowHandle window, GtkStateType state_type);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paint_shadow(GtkStyleHandle style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paint_diamond(GtkStyleHandle style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paint_flat_box(GtkStyleHandle style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paint_check(GtkStyleHandle style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paint_layout(GtkStyleHandle style, cairo_tHandle cr, GtkStateType state_type, bool use_text, GtkWidgetHandle widget, string detail, int x, int y, PangoLayoutHandle layout);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paint_expander(GtkStyleHandle style, cairo_tHandle cr, GtkStateType state_type, GtkWidgetHandle widget, string detail, int x, int y, GtkExpanderStyle expander_style);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paint_tab(GtkStyleHandle style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paint_box_gap(GtkStyleHandle style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height, GtkPositionType gap_side, int gap_x, int gap_width);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paint_extension(GtkStyleHandle style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height, GtkPositionType gap_side);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paint_focus(GtkStyleHandle style, cairo_tHandle cr, GtkStateType state_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paint_resize_grip(GtkStyleHandle style, cairo_tHandle cr, GtkStateType state_type, GtkWidgetHandle widget, string detail, GdkWindowEdge edge, int x, int y, int width, int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paint_shadow_gap(GtkStyleHandle style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height, GtkPositionType gap_side, int gap_x, int gap_width);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paint_slider(GtkStyleHandle style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height, GtkOrientation orientation);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paint_handle(GtkStyleHandle style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height, GtkOrientation orientation);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paint_arrow(GtkStyleHandle style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, GtkArrowType arrow_type, bool fill, int x, int y, int width, int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paint_option(GtkStyleHandle style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paint_box(GtkStyleHandle style, cairo_tHandle cr, GtkStateType state_type, GtkShadowType shadow_type, GtkWidgetHandle widget, string detail, int x, int y, int width, int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paint_hline(GtkStyleHandle style, cairo_tHandle cr, GtkStateType state_type, GtkWidgetHandle widget, string detail, int x1, int x2, int y);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paint_vline(GtkStyleHandle style, cairo_tHandle cr, GtkStateType state_type, GtkWidgetHandle widget, string detail, int y1_, int y2_, int x);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paint_spinner(GtkStyleHandle style, cairo_tHandle cr, GtkStateType state_type, GtkWidgetHandle widget, string detail, uint step, int x, int y, int width, int height);

}
