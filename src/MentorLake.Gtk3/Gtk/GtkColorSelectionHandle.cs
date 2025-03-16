namespace MentorLake.Gtk;

public class GtkColorSelectionHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkColorSelectionHandle New()
	{
		return GtkColorSelectionHandleExterns.gtk_color_selection_new();
	}

	public static bool PaletteFromString(string str, out MentorLake.Gdk.GdkColor[] colors, out int n_colors)
	{
		return GtkColorSelectionHandleExterns.gtk_color_selection_palette_from_string(str, out colors, out n_colors);
	}

	public static string PaletteToString(MentorLake.Gdk.GdkColor[] colors, int n_colors)
	{
		return GtkColorSelectionHandleExterns.gtk_color_selection_palette_to_string(colors, n_colors);
	}

	public static MentorLake.Gtk.GtkColorSelectionChangePaletteWithScreenFunc SetChangePaletteWithScreenHook(MentorLake.Gtk.GtkColorSelectionChangePaletteWithScreenFunc func)
	{
		return GtkColorSelectionHandleExterns.gtk_color_selection_set_change_palette_with_screen_hook(func);
	}

}
public static class GtkColorSelectionHandleSignalExtensions
{

	public static IObservable<GtkColorSelectionHandleSignalStructs.ColorChangedSignal> Signal_ColorChanged(this GtkColorSelectionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkColorSelectionHandleSignalStructs.ColorChangedSignal> obs) =>
		{
			GtkColorSelectionHandleSignalDelegates.color_changed handler = ( MentorLake.Gtk.GtkColorSelectionHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkColorSelectionHandleSignalStructs.ColorChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "color-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkColorSelectionHandleSignalStructs
{

public struct ColorChangedSignal
{
	public MentorLake.Gtk.GtkColorSelectionHandle Self;
	public IntPtr UserData;
}
}

public static class GtkColorSelectionHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void color_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorSelectionHandle>))] MentorLake.Gtk.GtkColorSelectionHandle self, IntPtr user_data);

}


public static class GtkColorSelectionHandleExtensions
{
	public static ushort GetCurrentAlpha(this MentorLake.Gtk.GtkColorSelectionHandle colorsel)
	{
		return GtkColorSelectionHandleExterns.gtk_color_selection_get_current_alpha(colorsel);
	}

	public static T GetCurrentColor<T>(this T colorsel, out MentorLake.Gdk.GdkColor color) where T : GtkColorSelectionHandle
	{
		GtkColorSelectionHandleExterns.gtk_color_selection_get_current_color(colorsel, out color);
		return colorsel;
	}

	public static T GetCurrentRgba<T>(this T colorsel, out MentorLake.Gdk.GdkRGBA rgba) where T : GtkColorSelectionHandle
	{
		GtkColorSelectionHandleExterns.gtk_color_selection_get_current_rgba(colorsel, out rgba);
		return colorsel;
	}

	public static bool GetHasOpacityControl(this MentorLake.Gtk.GtkColorSelectionHandle colorsel)
	{
		return GtkColorSelectionHandleExterns.gtk_color_selection_get_has_opacity_control(colorsel);
	}

	public static bool GetHasPalette(this MentorLake.Gtk.GtkColorSelectionHandle colorsel)
	{
		return GtkColorSelectionHandleExterns.gtk_color_selection_get_has_palette(colorsel);
	}

	public static ushort GetPreviousAlpha(this MentorLake.Gtk.GtkColorSelectionHandle colorsel)
	{
		return GtkColorSelectionHandleExterns.gtk_color_selection_get_previous_alpha(colorsel);
	}

	public static T GetPreviousColor<T>(this T colorsel, out MentorLake.Gdk.GdkColor color) where T : GtkColorSelectionHandle
	{
		GtkColorSelectionHandleExterns.gtk_color_selection_get_previous_color(colorsel, out color);
		return colorsel;
	}

	public static T GetPreviousRgba<T>(this T colorsel, out MentorLake.Gdk.GdkRGBA rgba) where T : GtkColorSelectionHandle
	{
		GtkColorSelectionHandleExterns.gtk_color_selection_get_previous_rgba(colorsel, out rgba);
		return colorsel;
	}

	public static bool IsAdjusting(this MentorLake.Gtk.GtkColorSelectionHandle colorsel)
	{
		return GtkColorSelectionHandleExterns.gtk_color_selection_is_adjusting(colorsel);
	}

	public static T SetCurrentAlpha<T>(this T colorsel, ushort alpha) where T : GtkColorSelectionHandle
	{
		GtkColorSelectionHandleExterns.gtk_color_selection_set_current_alpha(colorsel, alpha);
		return colorsel;
	}

	public static T SetCurrentColor<T>(this T colorsel, MentorLake.Gdk.GdkColorHandle color) where T : GtkColorSelectionHandle
	{
		GtkColorSelectionHandleExterns.gtk_color_selection_set_current_color(colorsel, color);
		return colorsel;
	}

	public static T SetCurrentRgba<T>(this T colorsel, MentorLake.Gdk.GdkRGBAHandle rgba) where T : GtkColorSelectionHandle
	{
		GtkColorSelectionHandleExterns.gtk_color_selection_set_current_rgba(colorsel, rgba);
		return colorsel;
	}

	public static T SetHasOpacityControl<T>(this T colorsel, bool has_opacity) where T : GtkColorSelectionHandle
	{
		GtkColorSelectionHandleExterns.gtk_color_selection_set_has_opacity_control(colorsel, has_opacity);
		return colorsel;
	}

	public static T SetHasPalette<T>(this T colorsel, bool has_palette) where T : GtkColorSelectionHandle
	{
		GtkColorSelectionHandleExterns.gtk_color_selection_set_has_palette(colorsel, has_palette);
		return colorsel;
	}

	public static T SetPreviousAlpha<T>(this T colorsel, ushort alpha) where T : GtkColorSelectionHandle
	{
		GtkColorSelectionHandleExterns.gtk_color_selection_set_previous_alpha(colorsel, alpha);
		return colorsel;
	}

	public static T SetPreviousColor<T>(this T colorsel, MentorLake.Gdk.GdkColorHandle color) where T : GtkColorSelectionHandle
	{
		GtkColorSelectionHandleExterns.gtk_color_selection_set_previous_color(colorsel, color);
		return colorsel;
	}

	public static T SetPreviousRgba<T>(this T colorsel, MentorLake.Gdk.GdkRGBAHandle rgba) where T : GtkColorSelectionHandle
	{
		GtkColorSelectionHandleExterns.gtk_color_selection_set_previous_rgba(colorsel, rgba);
		return colorsel;
	}

}

internal class GtkColorSelectionHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkColorSelectionHandle gtk_color_selection_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern ushort gtk_color_selection_get_current_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorSelectionHandle>))] MentorLake.Gtk.GtkColorSelectionHandle colorsel);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_selection_get_current_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorSelectionHandle>))] MentorLake.Gtk.GtkColorSelectionHandle colorsel, out MentorLake.Gdk.GdkColor color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_selection_get_current_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorSelectionHandle>))] MentorLake.Gtk.GtkColorSelectionHandle colorsel, out MentorLake.Gdk.GdkRGBA rgba);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_color_selection_get_has_opacity_control([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorSelectionHandle>))] MentorLake.Gtk.GtkColorSelectionHandle colorsel);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_color_selection_get_has_palette([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorSelectionHandle>))] MentorLake.Gtk.GtkColorSelectionHandle colorsel);

	[DllImport(GtkLibrary.Name)]
	internal static extern ushort gtk_color_selection_get_previous_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorSelectionHandle>))] MentorLake.Gtk.GtkColorSelectionHandle colorsel);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_selection_get_previous_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorSelectionHandle>))] MentorLake.Gtk.GtkColorSelectionHandle colorsel, out MentorLake.Gdk.GdkColor color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_selection_get_previous_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorSelectionHandle>))] MentorLake.Gtk.GtkColorSelectionHandle colorsel, out MentorLake.Gdk.GdkRGBA rgba);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_color_selection_is_adjusting([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorSelectionHandle>))] MentorLake.Gtk.GtkColorSelectionHandle colorsel);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_selection_set_current_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorSelectionHandle>))] MentorLake.Gtk.GtkColorSelectionHandle colorsel, ushort alpha);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_selection_set_current_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorSelectionHandle>))] MentorLake.Gtk.GtkColorSelectionHandle colorsel, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_selection_set_current_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorSelectionHandle>))] MentorLake.Gtk.GtkColorSelectionHandle colorsel, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle rgba);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_selection_set_has_opacity_control([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorSelectionHandle>))] MentorLake.Gtk.GtkColorSelectionHandle colorsel, bool has_opacity);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_selection_set_has_palette([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorSelectionHandle>))] MentorLake.Gtk.GtkColorSelectionHandle colorsel, bool has_palette);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_selection_set_previous_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorSelectionHandle>))] MentorLake.Gtk.GtkColorSelectionHandle colorsel, ushort alpha);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_selection_set_previous_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorSelectionHandle>))] MentorLake.Gtk.GtkColorSelectionHandle colorsel, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_selection_set_previous_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorSelectionHandle>))] MentorLake.Gtk.GtkColorSelectionHandle colorsel, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle rgba);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_color_selection_palette_from_string(string str, out MentorLake.Gdk.GdkColor[] colors, out int n_colors);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_color_selection_palette_to_string(MentorLake.Gdk.GdkColor[] colors, int n_colors);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkColorSelectionChangePaletteWithScreenFunc gtk_color_selection_set_change_palette_with_screen_hook(MentorLake.Gtk.GtkColorSelectionChangePaletteWithScreenFunc func);

}
