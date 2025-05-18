namespace MentorLake.Gtk;

public class GtkStyleContextHandle : GObjectHandle
{
	public static MentorLake.Gtk.GtkStyleContextHandle New()
	{
		return GtkStyleContextHandleExterns.gtk_style_context_new();
	}

	public static void AddProviderForScreen(MentorLake.Gdk.GdkScreenHandle screen, MentorLake.Gtk.GtkStyleProviderHandle provider, uint priority)
	{
		GtkStyleContextHandleExterns.gtk_style_context_add_provider_for_screen(screen, provider, priority);
	}

	public static void RemoveProviderForScreen(MentorLake.Gdk.GdkScreenHandle screen, MentorLake.Gtk.GtkStyleProviderHandle provider)
	{
		GtkStyleContextHandleExterns.gtk_style_context_remove_provider_for_screen(screen, provider);
	}

	public static void ResetWidgets(MentorLake.Gdk.GdkScreenHandle screen)
	{
		GtkStyleContextHandleExterns.gtk_style_context_reset_widgets(screen);
	}

}
public static class GtkStyleContextHandleSignalExtensions
{

	public static IObservable<GtkStyleContextHandleSignalStructs.ChangedSignal> Signal_Changed(this GtkStyleContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkStyleContextHandleSignalStructs.ChangedSignal> obs) =>
		{
			GtkStyleContextHandleSignalDelegates.changed handler = ( MentorLake.Gtk.GtkStyleContextHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStyleContextHandleSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkStyleContextHandleSignalStructs
{

public class ChangedSignal
{
	public MentorLake.Gtk.GtkStyleContextHandle Self;
	public IntPtr UserData;
}
}

public static class GtkStyleContextHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle self, IntPtr user_data);

}


public static class GtkStyleContextHandleExtensions
{
	public static T AddClass<T>(this T context, string class_name) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_add_class(context, class_name);
		return context;
	}

	public static T AddProvider<T>(this T context, MentorLake.Gtk.GtkStyleProviderHandle provider, uint priority) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_add_provider(context, provider, priority);
		return context;
	}

	public static T AddRegion<T>(this T context, string region_name, MentorLake.Gtk.GtkRegionFlags flags) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_add_region(context, region_name, flags);
		return context;
	}

	public static T CancelAnimations<T>(this T context, IntPtr region_id) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_cancel_animations(context, region_id);
		return context;
	}

	public static T Get<T>(this T context, MentorLake.Gtk.GtkStateFlags state, IntPtr @__arglist) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get(context, state, @__arglist);
		return context;
	}

	public static T GetBackgroundColor<T>(this T context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gdk.GdkRGBA color) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get_background_color(context, state, out color);
		return context;
	}

	public static T GetBorder<T>(this T context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder border) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get_border(context, state, out border);
		return context;
	}

	public static T GetBorderColor<T>(this T context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gdk.GdkRGBA color) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get_border_color(context, state, out color);
		return context;
	}

	public static T GetColor<T>(this T context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gdk.GdkRGBA color) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get_color(context, state, out color);
		return context;
	}

	public static MentorLake.Gtk.GtkTextDirection GetDirection(this MentorLake.Gtk.GtkStyleContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_get_direction(context);
	}

	public static MentorLake.Pango.PangoFontDescriptionHandle GetFont(this MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateFlags state)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_get_font(context, state);
	}

	public static MentorLake.Gdk.GdkFrameClockHandle GetFrameClock(this MentorLake.Gtk.GtkStyleContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_get_frame_clock(context);
	}

	public static MentorLake.Gtk.GtkJunctionSides GetJunctionSides(this MentorLake.Gtk.GtkStyleContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_get_junction_sides(context);
	}

	public static T GetMargin<T>(this T context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder margin) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get_margin(context, state, out margin);
		return context;
	}

	public static T GetPadding<T>(this T context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder padding) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get_padding(context, state, out padding);
		return context;
	}

	public static MentorLake.Gtk.GtkStyleContextHandle GetParent(this MentorLake.Gtk.GtkStyleContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_get_parent(context);
	}

	public static MentorLake.Gtk.GtkWidgetPathHandle GetPath(this MentorLake.Gtk.GtkStyleContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_get_path(context);
	}

	public static T GetProperty<T>(this T context, string property, MentorLake.Gtk.GtkStateFlags state, out MentorLake.GObject.GValue value) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get_property(context, property, state, out value);
		return context;
	}

	public static int GetScale(this MentorLake.Gtk.GtkStyleContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_get_scale(context);
	}

	public static MentorLake.Gdk.GdkScreenHandle GetScreen(this MentorLake.Gtk.GtkStyleContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_get_screen(context);
	}

	public static MentorLake.Gtk.GtkCssSectionHandle GetSection(this MentorLake.Gtk.GtkStyleContextHandle context, string property)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_get_section(context, property);
	}

	public static MentorLake.Gtk.GtkStateFlags GetState(this MentorLake.Gtk.GtkStyleContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_get_state(context);
	}

	public static T GetStyle<T>(this T context, IntPtr @__arglist) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get_style(context, @__arglist);
		return context;
	}

	public static T GetStyleProperty<T>(this T context, string property_name, out MentorLake.GObject.GValue value) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get_style_property(context, property_name, out value);
		return context;
	}

	public static T GetStyleValist<T>(this T context, IntPtr args) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get_style_valist(context, args);
		return context;
	}

	public static T GetValist<T>(this T context, MentorLake.Gtk.GtkStateFlags state, IntPtr args) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get_valist(context, state, args);
		return context;
	}

	public static bool HasClass(this MentorLake.Gtk.GtkStyleContextHandle context, string class_name)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_has_class(context, class_name);
	}

	public static bool HasRegion(this MentorLake.Gtk.GtkStyleContextHandle context, string region_name, out MentorLake.Gtk.GtkRegionFlags flags_return)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_has_region(context, region_name, out flags_return);
	}

	public static T Invalidate<T>(this T context) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_invalidate(context);
		return context;
	}

	public static MentorLake.GLib.GListHandle ListClasses(this MentorLake.Gtk.GtkStyleContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_list_classes(context);
	}

	public static MentorLake.GLib.GListHandle ListRegions(this MentorLake.Gtk.GtkStyleContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_list_regions(context);
	}

	public static bool LookupColor(this MentorLake.Gtk.GtkStyleContextHandle context, string color_name, out MentorLake.Gdk.GdkRGBA color)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_lookup_color(context, color_name, out color);
	}

	public static MentorLake.Gtk.GtkIconSetHandle LookupIconSet(this MentorLake.Gtk.GtkStyleContextHandle context, string stock_id)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_lookup_icon_set(context, stock_id);
	}

	public static T NotifyStateChange<T>(this T context, MentorLake.Gdk.GdkWindowHandle window, IntPtr region_id, MentorLake.Gtk.GtkStateType state, bool state_value) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_notify_state_change(context, window, region_id, state, state_value);
		return context;
	}

	public static T PopAnimatableRegion<T>(this T context) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_pop_animatable_region(context);
		return context;
	}

	public static T PushAnimatableRegion<T>(this T context, IntPtr region_id) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_push_animatable_region(context, region_id);
		return context;
	}

	public static T RemoveClass<T>(this T context, string class_name) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_remove_class(context, class_name);
		return context;
	}

	public static T RemoveProvider<T>(this T context, MentorLake.Gtk.GtkStyleProviderHandle provider) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_remove_provider(context, provider);
		return context;
	}

	public static T RemoveRegion<T>(this T context, string region_name) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_remove_region(context, region_name);
		return context;
	}

	public static T Restore<T>(this T context) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_restore(context);
		return context;
	}

	public static T Save<T>(this T context) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_save(context);
		return context;
	}

	public static T ScrollAnimations<T>(this T context, MentorLake.Gdk.GdkWindowHandle window, int dx, int dy) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_scroll_animations(context, window, dx, dy);
		return context;
	}

	public static T SetBackground<T>(this T context, MentorLake.Gdk.GdkWindowHandle window) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_set_background(context, window);
		return context;
	}

	public static T SetDirection<T>(this T context, MentorLake.Gtk.GtkTextDirection direction) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_set_direction(context, direction);
		return context;
	}

	public static T SetFrameClock<T>(this T context, MentorLake.Gdk.GdkFrameClockHandle frame_clock) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_set_frame_clock(context, frame_clock);
		return context;
	}

	public static T SetJunctionSides<T>(this T context, MentorLake.Gtk.GtkJunctionSides sides) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_set_junction_sides(context, sides);
		return context;
	}

	public static T SetParent<T>(this T context, MentorLake.Gtk.GtkStyleContextHandle parent) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_set_parent(context, parent);
		return context;
	}

	public static T SetPath<T>(this T context, MentorLake.Gtk.GtkWidgetPathHandle path) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_set_path(context, path);
		return context;
	}

	public static T SetScale<T>(this T context, int scale) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_set_scale(context, scale);
		return context;
	}

	public static T SetScreen<T>(this T context, MentorLake.Gdk.GdkScreenHandle screen) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_set_screen(context, screen);
		return context;
	}

	public static T SetState<T>(this T context, MentorLake.Gtk.GtkStateFlags flags) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_set_state(context, flags);
		return context;
	}

	public static bool StateIsRunning(this MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateType state, out double progress)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_state_is_running(context, state, out progress);
	}

	public static string ToString(this MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStyleContextPrintFlags flags)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_to_string(context, flags);
	}

}

internal class GtkStyleContextHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))]
	internal static extern MentorLake.Gtk.GtkStyleContextHandle gtk_style_context_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_add_class([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, string class_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_add_provider([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleProviderHandleImpl>))] MentorLake.Gtk.GtkStyleProviderHandle provider, uint priority);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_add_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, string region_name, MentorLake.Gtk.GtkRegionFlags flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_cancel_animations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, IntPtr region_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateFlags state, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get_background_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gdk.GdkRGBA color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get_border([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder border);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get_border_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gdk.GdkRGBA color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gdk.GdkRGBA color);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTextDirection gtk_style_context_get_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle gtk_style_context_get_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateFlags state);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))]
	internal static extern MentorLake.Gdk.GdkFrameClockHandle gtk_style_context_get_frame_clock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkJunctionSides gtk_style_context_get_junction_sides([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder margin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get_padding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder padding);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))]
	internal static extern MentorLake.Gtk.GtkStyleContextHandle gtk_style_context_get_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetPathHandle gtk_style_context_get_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, string property, MentorLake.Gtk.GtkStateFlags state, out MentorLake.GObject.GValue value);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_style_context_get_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))]
	internal static extern MentorLake.Gdk.GdkScreenHandle gtk_style_context_get_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssSectionHandle>))]
	internal static extern MentorLake.Gtk.GtkCssSectionHandle gtk_style_context_get_section([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, string property);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStateFlags gtk_style_context_get_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get_style_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, string property_name, out MentorLake.GObject.GValue value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get_style_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, IntPtr args);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateFlags state, IntPtr args);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_style_context_has_class([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, string class_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_style_context_has_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, string region_name, out MentorLake.Gtk.GtkRegionFlags flags_return);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_invalidate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_style_context_list_classes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_style_context_list_regions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_style_context_lookup_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, string color_name, out MentorLake.Gdk.GdkRGBA color);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))]
	internal static extern MentorLake.Gtk.GtkIconSetHandle gtk_style_context_lookup_icon_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_notify_state_change([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, IntPtr region_id, MentorLake.Gtk.GtkStateType state, bool state_value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_pop_animatable_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_push_animatable_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, IntPtr region_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_remove_class([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, string class_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_remove_provider([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleProviderHandleImpl>))] MentorLake.Gtk.GtkStyleProviderHandle provider);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_remove_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, string region_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_restore([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_save([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_scroll_animations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, int dx, int dy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_set_background([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_set_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkTextDirection direction);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_set_frame_clock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle frame_clock);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_set_junction_sides([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkJunctionSides sides);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_set_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle parent);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_set_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_set_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, int scale);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_set_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_set_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateFlags flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_style_context_state_is_running([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateType state, out double progress);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_style_context_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStyleContextPrintFlags flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_add_provider_for_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleProviderHandleImpl>))] MentorLake.Gtk.GtkStyleProviderHandle provider, uint priority);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_remove_provider_for_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleProviderHandleImpl>))] MentorLake.Gtk.GtkStyleProviderHandle provider);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_reset_widgets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

}
