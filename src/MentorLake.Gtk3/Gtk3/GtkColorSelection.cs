namespace MentorLake.Gtk3.Gtk3;

public class GtkColorSelectionHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkColorSelectionHandle New()
	{
		return GtkColorSelectionExterns.gtk_color_selection_new();
	}

	public static bool PaletteFromString(string str, out GdkColor[] colors, out int n_colors)
	{
		return GtkColorSelectionExterns.gtk_color_selection_palette_from_string(str, out colors, out n_colors);
	}

	public static string PaletteToString(GdkColor[] colors, int n_colors)
	{
		return GtkColorSelectionExterns.gtk_color_selection_palette_to_string(colors, n_colors);
	}

	public static GtkColorSelectionChangePaletteWithScreenFunc SetChangePaletteWithScreenHook(GtkColorSelectionChangePaletteWithScreenFunc func)
	{
		return GtkColorSelectionExterns.gtk_color_selection_set_change_palette_with_screen_hook(func);
	}

}

public static class GtkColorSelectionSignalExtensions
{

	public static IObservable<GtkColorSelectionSignalStructs.ColorChangedSignal> Signal_ColorChanged(this GtkColorSelectionHandle instance)
	{
		return Observable.Create((IObserver<GtkColorSelectionSignalStructs.ColorChangedSignal> obs) =>
		{
			GtkColorSelectionSignalDelegates.color_changed handler = (GtkColorSelectionHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkColorSelectionSignalStructs.ColorChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "color_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkColorSelectionSignalStructs
{

public struct ColorChangedSignal
{
	public GtkColorSelectionHandle Self;
	public IntPtr UserData;
}
}

public static class GtkColorSelectionSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void color_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkColorSelectionHandle>))] GtkColorSelectionHandle self, IntPtr user_data);

}


public static class GtkColorSelectionHandleExtensions
{
	public static ushort GetCurrentAlpha(this GtkColorSelectionHandle colorsel)
	{
		return GtkColorSelectionExterns.gtk_color_selection_get_current_alpha(colorsel);
	}

	public static GtkColorSelectionHandle GetCurrentColor(this GtkColorSelectionHandle colorsel, out GdkColor color)
	{
		GtkColorSelectionExterns.gtk_color_selection_get_current_color(colorsel, out color);
		return colorsel;
	}

	public static GtkColorSelectionHandle GetCurrentRgba(this GtkColorSelectionHandle colorsel, out GdkRGBA rgba)
	{
		GtkColorSelectionExterns.gtk_color_selection_get_current_rgba(colorsel, out rgba);
		return colorsel;
	}

	public static bool GetHasOpacityControl(this GtkColorSelectionHandle colorsel)
	{
		return GtkColorSelectionExterns.gtk_color_selection_get_has_opacity_control(colorsel);
	}

	public static bool GetHasPalette(this GtkColorSelectionHandle colorsel)
	{
		return GtkColorSelectionExterns.gtk_color_selection_get_has_palette(colorsel);
	}

	public static ushort GetPreviousAlpha(this GtkColorSelectionHandle colorsel)
	{
		return GtkColorSelectionExterns.gtk_color_selection_get_previous_alpha(colorsel);
	}

	public static GtkColorSelectionHandle GetPreviousColor(this GtkColorSelectionHandle colorsel, out GdkColor color)
	{
		GtkColorSelectionExterns.gtk_color_selection_get_previous_color(colorsel, out color);
		return colorsel;
	}

	public static GtkColorSelectionHandle GetPreviousRgba(this GtkColorSelectionHandle colorsel, out GdkRGBA rgba)
	{
		GtkColorSelectionExterns.gtk_color_selection_get_previous_rgba(colorsel, out rgba);
		return colorsel;
	}

	public static bool IsAdjusting(this GtkColorSelectionHandle colorsel)
	{
		return GtkColorSelectionExterns.gtk_color_selection_is_adjusting(colorsel);
	}

	public static GtkColorSelectionHandle SetCurrentAlpha(this GtkColorSelectionHandle colorsel, ushort alpha)
	{
		GtkColorSelectionExterns.gtk_color_selection_set_current_alpha(colorsel, alpha);
		return colorsel;
	}

	public static GtkColorSelectionHandle SetCurrentColor(this GtkColorSelectionHandle colorsel, GdkColorHandle color)
	{
		GtkColorSelectionExterns.gtk_color_selection_set_current_color(colorsel, color);
		return colorsel;
	}

	public static GtkColorSelectionHandle SetCurrentRgba(this GtkColorSelectionHandle colorsel, GdkRGBAHandle rgba)
	{
		GtkColorSelectionExterns.gtk_color_selection_set_current_rgba(colorsel, rgba);
		return colorsel;
	}

	public static GtkColorSelectionHandle SetHasOpacityControl(this GtkColorSelectionHandle colorsel, bool has_opacity)
	{
		GtkColorSelectionExterns.gtk_color_selection_set_has_opacity_control(colorsel, has_opacity);
		return colorsel;
	}

	public static GtkColorSelectionHandle SetHasPalette(this GtkColorSelectionHandle colorsel, bool has_palette)
	{
		GtkColorSelectionExterns.gtk_color_selection_set_has_palette(colorsel, has_palette);
		return colorsel;
	}

	public static GtkColorSelectionHandle SetPreviousAlpha(this GtkColorSelectionHandle colorsel, ushort alpha)
	{
		GtkColorSelectionExterns.gtk_color_selection_set_previous_alpha(colorsel, alpha);
		return colorsel;
	}

	public static GtkColorSelectionHandle SetPreviousColor(this GtkColorSelectionHandle colorsel, GdkColorHandle color)
	{
		GtkColorSelectionExterns.gtk_color_selection_set_previous_color(colorsel, color);
		return colorsel;
	}

	public static GtkColorSelectionHandle SetPreviousRgba(this GtkColorSelectionHandle colorsel, GdkRGBAHandle rgba)
	{
		GtkColorSelectionExterns.gtk_color_selection_set_previous_rgba(colorsel, rgba);
		return colorsel;
	}

}

internal class GtkColorSelectionExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkColorSelectionHandle gtk_color_selection_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern ushort gtk_color_selection_get_current_alpha(GtkColorSelectionHandle colorsel);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_selection_get_current_color(GtkColorSelectionHandle colorsel, out GdkColor color);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_selection_get_current_rgba(GtkColorSelectionHandle colorsel, out GdkRGBA rgba);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_color_selection_get_has_opacity_control(GtkColorSelectionHandle colorsel);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_color_selection_get_has_palette(GtkColorSelectionHandle colorsel);

	[DllImport(Libraries.Gtk3)]
	internal static extern ushort gtk_color_selection_get_previous_alpha(GtkColorSelectionHandle colorsel);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_selection_get_previous_color(GtkColorSelectionHandle colorsel, out GdkColor color);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_selection_get_previous_rgba(GtkColorSelectionHandle colorsel, out GdkRGBA rgba);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_color_selection_is_adjusting(GtkColorSelectionHandle colorsel);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_selection_set_current_alpha(GtkColorSelectionHandle colorsel, ushort alpha);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_selection_set_current_color(GtkColorSelectionHandle colorsel, GdkColorHandle color);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_selection_set_current_rgba(GtkColorSelectionHandle colorsel, GdkRGBAHandle rgba);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_selection_set_has_opacity_control(GtkColorSelectionHandle colorsel, bool has_opacity);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_selection_set_has_palette(GtkColorSelectionHandle colorsel, bool has_palette);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_selection_set_previous_alpha(GtkColorSelectionHandle colorsel, ushort alpha);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_selection_set_previous_color(GtkColorSelectionHandle colorsel, GdkColorHandle color);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_selection_set_previous_rgba(GtkColorSelectionHandle colorsel, GdkRGBAHandle rgba);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_color_selection_palette_from_string(string str, out GdkColor[] colors, out int n_colors);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_color_selection_palette_to_string(GdkColor[] colors, int n_colors);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkColorSelectionChangePaletteWithScreenFunc gtk_color_selection_set_change_palette_with_screen_hook(GtkColorSelectionChangePaletteWithScreenFunc func);

}
