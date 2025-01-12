namespace MentorLake.Gtk3.Gtk3;

public class GtkStyleContextHandle : GObjectHandle
{
	public static GtkStyleContextHandle New()
	{
		return GtkStyleContextExterns.gtk_style_context_new();
	}

	public static void AddProviderForScreen(GdkScreenHandle screen, GtkStyleProviderHandle provider, uint priority)
	{
		GtkStyleContextExterns.gtk_style_context_add_provider_for_screen(screen, provider, priority);
	}

	public static void RemoveProviderForScreen(GdkScreenHandle screen, GtkStyleProviderHandle provider)
	{
		GtkStyleContextExterns.gtk_style_context_remove_provider_for_screen(screen, provider);
	}

	public static void ResetWidgets(GdkScreenHandle screen)
	{
		GtkStyleContextExterns.gtk_style_context_reset_widgets(screen);
	}

}

public static class GtkStyleContextSignalExtensions
{

	public static IObservable<GtkStyleContextSignalStructs.ChangedSignal> Signal_Changed(this GtkStyleContextHandle instance)
	{
		return Observable.Create((IObserver<GtkStyleContextSignalStructs.ChangedSignal> obs) =>
		{
			GtkStyleContextSignalDelegates.changed handler = (GtkStyleContextHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStyleContextSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkStyleContextSignalStructs
{

public struct ChangedSignal
{
	public GtkStyleContextHandle Self;
	public IntPtr UserData;
}
}

public static class GtkStyleContextSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkStyleContextHandle>))] GtkStyleContextHandle self, IntPtr user_data);

}


public static class GtkStyleContextHandleExtensions
{
	public static GtkStyleContextHandle AddClass(this GtkStyleContextHandle context, string class_name)
	{
		GtkStyleContextExterns.gtk_style_context_add_class(context, class_name);
		return context;
	}

	public static GtkStyleContextHandle AddProvider(this GtkStyleContextHandle context, GtkStyleProviderHandle provider, uint priority)
	{
		GtkStyleContextExterns.gtk_style_context_add_provider(context, provider, priority);
		return context;
	}

	public static GtkStyleContextHandle AddRegion(this GtkStyleContextHandle context, string region_name, GtkRegionFlags flags)
	{
		GtkStyleContextExterns.gtk_style_context_add_region(context, region_name, flags);
		return context;
	}

	public static GtkStyleContextHandle CancelAnimations(this GtkStyleContextHandle context, IntPtr region_id)
	{
		GtkStyleContextExterns.gtk_style_context_cancel_animations(context, region_id);
		return context;
	}

	public static GtkStyleContextHandle Get(this GtkStyleContextHandle context, GtkStateFlags state, IntPtr @__arglist)
	{
		GtkStyleContextExterns.gtk_style_context_get(context, state, @__arglist);
		return context;
	}

	public static GtkStyleContextHandle GetBackgroundColor(this GtkStyleContextHandle context, GtkStateFlags state, out GdkRGBA color)
	{
		GtkStyleContextExterns.gtk_style_context_get_background_color(context, state, out color);
		return context;
	}

	public static GtkStyleContextHandle GetBorder(this GtkStyleContextHandle context, GtkStateFlags state, out GtkBorder border)
	{
		GtkStyleContextExterns.gtk_style_context_get_border(context, state, out border);
		return context;
	}

	public static GtkStyleContextHandle GetBorderColor(this GtkStyleContextHandle context, GtkStateFlags state, out GdkRGBA color)
	{
		GtkStyleContextExterns.gtk_style_context_get_border_color(context, state, out color);
		return context;
	}

	public static GtkStyleContextHandle GetColor(this GtkStyleContextHandle context, GtkStateFlags state, out GdkRGBA color)
	{
		GtkStyleContextExterns.gtk_style_context_get_color(context, state, out color);
		return context;
	}

	public static GtkTextDirection GetDirection(this GtkStyleContextHandle context)
	{
		return GtkStyleContextExterns.gtk_style_context_get_direction(context);
	}

	public static PangoFontDescriptionHandle GetFont(this GtkStyleContextHandle context, GtkStateFlags state)
	{
		return GtkStyleContextExterns.gtk_style_context_get_font(context, state);
	}

	public static GdkFrameClockHandle GetFrameClock(this GtkStyleContextHandle context)
	{
		return GtkStyleContextExterns.gtk_style_context_get_frame_clock(context);
	}

	public static GtkJunctionSides GetJunctionSides(this GtkStyleContextHandle context)
	{
		return GtkStyleContextExterns.gtk_style_context_get_junction_sides(context);
	}

	public static GtkStyleContextHandle GetMargin(this GtkStyleContextHandle context, GtkStateFlags state, out GtkBorder margin)
	{
		GtkStyleContextExterns.gtk_style_context_get_margin(context, state, out margin);
		return context;
	}

	public static GtkStyleContextHandle GetPadding(this GtkStyleContextHandle context, GtkStateFlags state, out GtkBorder padding)
	{
		GtkStyleContextExterns.gtk_style_context_get_padding(context, state, out padding);
		return context;
	}

	public static GtkStyleContextHandle GetParent(this GtkStyleContextHandle context)
	{
		return GtkStyleContextExterns.gtk_style_context_get_parent(context);
	}

	public static GtkWidgetPathHandle GetPath(this GtkStyleContextHandle context)
	{
		return GtkStyleContextExterns.gtk_style_context_get_path(context);
	}

	public static GtkStyleContextHandle GetProperty(this GtkStyleContextHandle context, string property, GtkStateFlags state, out GValue value)
	{
		GtkStyleContextExterns.gtk_style_context_get_property(context, property, state, out value);
		return context;
	}

	public static int GetScale(this GtkStyleContextHandle context)
	{
		return GtkStyleContextExterns.gtk_style_context_get_scale(context);
	}

	public static GdkScreenHandle GetScreen(this GtkStyleContextHandle context)
	{
		return GtkStyleContextExterns.gtk_style_context_get_screen(context);
	}

	public static GtkCssSectionHandle GetSection(this GtkStyleContextHandle context, string property)
	{
		return GtkStyleContextExterns.gtk_style_context_get_section(context, property);
	}

	public static GtkStateFlags GetState(this GtkStyleContextHandle context)
	{
		return GtkStyleContextExterns.gtk_style_context_get_state(context);
	}

	public static GtkStyleContextHandle GetStyle(this GtkStyleContextHandle context, IntPtr @__arglist)
	{
		GtkStyleContextExterns.gtk_style_context_get_style(context, @__arglist);
		return context;
	}

	public static GtkStyleContextHandle GetStyleProperty(this GtkStyleContextHandle context, string property_name, out GValue value)
	{
		GtkStyleContextExterns.gtk_style_context_get_style_property(context, property_name, out value);
		return context;
	}

	public static GtkStyleContextHandle GetStyleValist(this GtkStyleContextHandle context, IntPtr args)
	{
		GtkStyleContextExterns.gtk_style_context_get_style_valist(context, args);
		return context;
	}

	public static GtkStyleContextHandle GetValist(this GtkStyleContextHandle context, GtkStateFlags state, IntPtr args)
	{
		GtkStyleContextExterns.gtk_style_context_get_valist(context, state, args);
		return context;
	}

	public static bool HasClass(this GtkStyleContextHandle context, string class_name)
	{
		return GtkStyleContextExterns.gtk_style_context_has_class(context, class_name);
	}

	public static bool HasRegion(this GtkStyleContextHandle context, string region_name, out GtkRegionFlags flags_return)
	{
		return GtkStyleContextExterns.gtk_style_context_has_region(context, region_name, out flags_return);
	}

	public static GtkStyleContextHandle Invalidate(this GtkStyleContextHandle context)
	{
		GtkStyleContextExterns.gtk_style_context_invalidate(context);
		return context;
	}

	public static GListHandle ListClasses(this GtkStyleContextHandle context)
	{
		return GtkStyleContextExterns.gtk_style_context_list_classes(context);
	}

	public static GListHandle ListRegions(this GtkStyleContextHandle context)
	{
		return GtkStyleContextExterns.gtk_style_context_list_regions(context);
	}

	public static bool LookupColor(this GtkStyleContextHandle context, string color_name, out GdkRGBA color)
	{
		return GtkStyleContextExterns.gtk_style_context_lookup_color(context, color_name, out color);
	}

	public static GtkIconSetHandle LookupIconSet(this GtkStyleContextHandle context, string stock_id)
	{
		return GtkStyleContextExterns.gtk_style_context_lookup_icon_set(context, stock_id);
	}

	public static GtkStyleContextHandle NotifyStateChange(this GtkStyleContextHandle context, GdkWindowHandle window, IntPtr region_id, GtkStateType state, bool state_value)
	{
		GtkStyleContextExterns.gtk_style_context_notify_state_change(context, window, region_id, state, state_value);
		return context;
	}

	public static GtkStyleContextHandle PopAnimatableRegion(this GtkStyleContextHandle context)
	{
		GtkStyleContextExterns.gtk_style_context_pop_animatable_region(context);
		return context;
	}

	public static GtkStyleContextHandle PushAnimatableRegion(this GtkStyleContextHandle context, IntPtr region_id)
	{
		GtkStyleContextExterns.gtk_style_context_push_animatable_region(context, region_id);
		return context;
	}

	public static GtkStyleContextHandle RemoveClass(this GtkStyleContextHandle context, string class_name)
	{
		GtkStyleContextExterns.gtk_style_context_remove_class(context, class_name);
		return context;
	}

	public static GtkStyleContextHandle RemoveProvider(this GtkStyleContextHandle context, GtkStyleProviderHandle provider)
	{
		GtkStyleContextExterns.gtk_style_context_remove_provider(context, provider);
		return context;
	}

	public static GtkStyleContextHandle RemoveRegion(this GtkStyleContextHandle context, string region_name)
	{
		GtkStyleContextExterns.gtk_style_context_remove_region(context, region_name);
		return context;
	}

	public static GtkStyleContextHandle Restore(this GtkStyleContextHandle context)
	{
		GtkStyleContextExterns.gtk_style_context_restore(context);
		return context;
	}

	public static GtkStyleContextHandle Save(this GtkStyleContextHandle context)
	{
		GtkStyleContextExterns.gtk_style_context_save(context);
		return context;
	}

	public static GtkStyleContextHandle ScrollAnimations(this GtkStyleContextHandle context, GdkWindowHandle window, int dx, int dy)
	{
		GtkStyleContextExterns.gtk_style_context_scroll_animations(context, window, dx, dy);
		return context;
	}

	public static GtkStyleContextHandle SetBackground(this GtkStyleContextHandle context, GdkWindowHandle window)
	{
		GtkStyleContextExterns.gtk_style_context_set_background(context, window);
		return context;
	}

	public static GtkStyleContextHandle SetDirection(this GtkStyleContextHandle context, GtkTextDirection direction)
	{
		GtkStyleContextExterns.gtk_style_context_set_direction(context, direction);
		return context;
	}

	public static GtkStyleContextHandle SetFrameClock(this GtkStyleContextHandle context, GdkFrameClockHandle frame_clock)
	{
		GtkStyleContextExterns.gtk_style_context_set_frame_clock(context, frame_clock);
		return context;
	}

	public static GtkStyleContextHandle SetJunctionSides(this GtkStyleContextHandle context, GtkJunctionSides sides)
	{
		GtkStyleContextExterns.gtk_style_context_set_junction_sides(context, sides);
		return context;
	}

	public static GtkStyleContextHandle SetParent(this GtkStyleContextHandle context, GtkStyleContextHandle parent)
	{
		GtkStyleContextExterns.gtk_style_context_set_parent(context, parent);
		return context;
	}

	public static GtkStyleContextHandle SetPath(this GtkStyleContextHandle context, GtkWidgetPathHandle path)
	{
		GtkStyleContextExterns.gtk_style_context_set_path(context, path);
		return context;
	}

	public static GtkStyleContextHandle SetScale(this GtkStyleContextHandle context, int scale)
	{
		GtkStyleContextExterns.gtk_style_context_set_scale(context, scale);
		return context;
	}

	public static GtkStyleContextHandle SetScreen(this GtkStyleContextHandle context, GdkScreenHandle screen)
	{
		GtkStyleContextExterns.gtk_style_context_set_screen(context, screen);
		return context;
	}

	public static GtkStyleContextHandle SetState(this GtkStyleContextHandle context, GtkStateFlags flags)
	{
		GtkStyleContextExterns.gtk_style_context_set_state(context, flags);
		return context;
	}

	public static bool StateIsRunning(this GtkStyleContextHandle context, GtkStateType state, out double progress)
	{
		return GtkStyleContextExterns.gtk_style_context_state_is_running(context, state, out progress);
	}

	public static string ToString(this GtkStyleContextHandle context, GtkStyleContextPrintFlags flags)
	{
		return GtkStyleContextExterns.gtk_style_context_to_string(context, flags);
	}

	public static GtkStyleContextHandle GtkRenderFrameGap(this GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height, GtkPositionType gap_side, double xy0_gap, double xy1_gap)
	{
		GtkStyleContextExterns.gtk_render_frame_gap(context, cr, x, y, width, height, gap_side, xy0_gap, xy1_gap);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderFrame(this GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkStyleContextExterns.gtk_render_frame(context, cr, x, y, width, height);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderIconSurface(this GtkStyleContextHandle context, cairo_tHandle cr, cairo_surface_tHandle surface, double x, double y)
	{
		GtkStyleContextExterns.gtk_render_icon_surface(context, cr, surface, x, y);
		return context;
	}

	public static GdkPixbufHandle GtkRenderIconPixbuf(this GtkStyleContextHandle context, GtkIconSourceHandle source, GtkIconSize size)
	{
		return GtkStyleContextExterns.gtk_render_icon_pixbuf(context, source, size);
	}

	public static GtkStyleContextHandle GtkRenderInsertionCursor(this GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, PangoLayoutHandle layout, int index, PangoDirection direction)
	{
		GtkStyleContextExterns.gtk_render_insertion_cursor(context, cr, x, y, layout, index, direction);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderExpander(this GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkStyleContextExterns.gtk_render_expander(context, cr, x, y, width, height);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderIcon(this GtkStyleContextHandle context, cairo_tHandle cr, GdkPixbufHandle pixbuf, double x, double y)
	{
		GtkStyleContextExterns.gtk_render_icon(context, cr, pixbuf, x, y);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderLine(this GtkStyleContextHandle context, cairo_tHandle cr, double x0, double y0, double x1, double y1)
	{
		GtkStyleContextExterns.gtk_render_line(context, cr, x0, y0, x1, y1);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderBackground(this GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkStyleContextExterns.gtk_render_background(context, cr, x, y, width, height);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderLayout(this GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, PangoLayoutHandle layout)
	{
		GtkStyleContextExterns.gtk_render_layout(context, cr, x, y, layout);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderArrow(this GtkStyleContextHandle context, cairo_tHandle cr, double angle, double x, double y, double size)
	{
		GtkStyleContextExterns.gtk_render_arrow(context, cr, angle, x, y, size);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderExtension(this GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height, GtkPositionType gap_side)
	{
		GtkStyleContextExterns.gtk_render_extension(context, cr, x, y, width, height, gap_side);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderActivity(this GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkStyleContextExterns.gtk_render_activity(context, cr, x, y, width, height);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderHandle(this GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkStyleContextExterns.gtk_render_handle(context, cr, x, y, width, height);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderFocus(this GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkStyleContextExterns.gtk_render_focus(context, cr, x, y, width, height);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderSlider(this GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height, GtkOrientation orientation)
	{
		GtkStyleContextExterns.gtk_render_slider(context, cr, x, y, width, height, orientation);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderBackgroundGetClip(this GtkStyleContextHandle context, double x, double y, double width, double height, out GdkRectangle out_clip)
	{
		GtkStyleContextExterns.gtk_render_background_get_clip(context, x, y, width, height, out out_clip);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderCheck(this GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkStyleContextExterns.gtk_render_check(context, cr, x, y, width, height);
		return context;
	}

	public static GtkStyleContextHandle GtkRenderOption(this GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkStyleContextExterns.gtk_render_option(context, cr, x, y, width, height);
		return context;
	}

}

internal class GtkStyleContextExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStyleContextHandle gtk_style_context_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_add_class(GtkStyleContextHandle context, string class_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_add_provider(GtkStyleContextHandle context, GtkStyleProviderHandle provider, uint priority);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_add_region(GtkStyleContextHandle context, string region_name, GtkRegionFlags flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_cancel_animations(GtkStyleContextHandle context, IntPtr region_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_get(GtkStyleContextHandle context, GtkStateFlags state, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_get_background_color(GtkStyleContextHandle context, GtkStateFlags state, out GdkRGBA color);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_get_border(GtkStyleContextHandle context, GtkStateFlags state, out GtkBorder border);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_get_border_color(GtkStyleContextHandle context, GtkStateFlags state, out GdkRGBA color);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_get_color(GtkStyleContextHandle context, GtkStateFlags state, out GdkRGBA color);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTextDirection gtk_style_context_get_direction(GtkStyleContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoFontDescriptionHandle gtk_style_context_get_font(GtkStyleContextHandle context, GtkStateFlags state);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkFrameClockHandle gtk_style_context_get_frame_clock(GtkStyleContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkJunctionSides gtk_style_context_get_junction_sides(GtkStyleContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_get_margin(GtkStyleContextHandle context, GtkStateFlags state, out GtkBorder margin);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_get_padding(GtkStyleContextHandle context, GtkStateFlags state, out GtkBorder padding);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStyleContextHandle gtk_style_context_get_parent(GtkStyleContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetPathHandle gtk_style_context_get_path(GtkStyleContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_get_property(GtkStyleContextHandle context, string property, GtkStateFlags state, out GValue value);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_style_context_get_scale(GtkStyleContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkScreenHandle gtk_style_context_get_screen(GtkStyleContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCssSectionHandle gtk_style_context_get_section(GtkStyleContextHandle context, string property);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStateFlags gtk_style_context_get_state(GtkStyleContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_get_style(GtkStyleContextHandle context, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_get_style_property(GtkStyleContextHandle context, string property_name, out GValue value);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_get_style_valist(GtkStyleContextHandle context, IntPtr args);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_get_valist(GtkStyleContextHandle context, GtkStateFlags state, IntPtr args);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_style_context_has_class(GtkStyleContextHandle context, string class_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_style_context_has_region(GtkStyleContextHandle context, string region_name, out GtkRegionFlags flags_return);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_invalidate(GtkStyleContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_style_context_list_classes(GtkStyleContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_style_context_list_regions(GtkStyleContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_style_context_lookup_color(GtkStyleContextHandle context, string color_name, out GdkRGBA color);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconSetHandle gtk_style_context_lookup_icon_set(GtkStyleContextHandle context, string stock_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_notify_state_change(GtkStyleContextHandle context, GdkWindowHandle window, IntPtr region_id, GtkStateType state, bool state_value);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_pop_animatable_region(GtkStyleContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_push_animatable_region(GtkStyleContextHandle context, IntPtr region_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_remove_class(GtkStyleContextHandle context, string class_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_remove_provider(GtkStyleContextHandle context, GtkStyleProviderHandle provider);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_remove_region(GtkStyleContextHandle context, string region_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_restore(GtkStyleContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_save(GtkStyleContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_scroll_animations(GtkStyleContextHandle context, GdkWindowHandle window, int dx, int dy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_set_background(GtkStyleContextHandle context, GdkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_set_direction(GtkStyleContextHandle context, GtkTextDirection direction);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_set_frame_clock(GtkStyleContextHandle context, GdkFrameClockHandle frame_clock);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_set_junction_sides(GtkStyleContextHandle context, GtkJunctionSides sides);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_set_parent(GtkStyleContextHandle context, GtkStyleContextHandle parent);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_set_path(GtkStyleContextHandle context, GtkWidgetPathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_set_scale(GtkStyleContextHandle context, int scale);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_set_screen(GtkStyleContextHandle context, GdkScreenHandle screen);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_set_state(GtkStyleContextHandle context, GtkStateFlags flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_style_context_state_is_running(GtkStyleContextHandle context, GtkStateType state, out double progress);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_style_context_to_string(GtkStyleContextHandle context, GtkStyleContextPrintFlags flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_render_frame_gap(GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height, GtkPositionType gap_side, double xy0_gap, double xy1_gap);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_render_frame(GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_render_icon_surface(GtkStyleContextHandle context, cairo_tHandle cr, cairo_surface_tHandle surface, double x, double y);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_render_icon_pixbuf(GtkStyleContextHandle context, GtkIconSourceHandle source, GtkIconSize size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_render_insertion_cursor(GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, PangoLayoutHandle layout, int index, PangoDirection direction);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_render_expander(GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_render_icon(GtkStyleContextHandle context, cairo_tHandle cr, GdkPixbufHandle pixbuf, double x, double y);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_render_line(GtkStyleContextHandle context, cairo_tHandle cr, double x0, double y0, double x1, double y1);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_render_background(GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_render_layout(GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, PangoLayoutHandle layout);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_render_arrow(GtkStyleContextHandle context, cairo_tHandle cr, double angle, double x, double y, double size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_render_extension(GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height, GtkPositionType gap_side);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_render_activity(GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_render_handle(GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_render_focus(GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_render_slider(GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height, GtkOrientation orientation);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_render_background_get_clip(GtkStyleContextHandle context, double x, double y, double width, double height, out GdkRectangle out_clip);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_render_check(GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_render_option(GtkStyleContextHandle context, cairo_tHandle cr, double x, double y, double width, double height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_add_provider_for_screen(GdkScreenHandle screen, GtkStyleProviderHandle provider, uint priority);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_remove_provider_for_screen(GdkScreenHandle screen, GtkStyleProviderHandle provider);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_context_reset_widgets(GdkScreenHandle screen);

}
