namespace MentorLake.Gtk;


public class GtkColorSelectionHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new GtkColorSelection.
/// </para>
/// </summary>

/// <return>
/// a new #GtkColorSelection
/// </return>

	public static MentorLake.Gtk.GtkColorSelectionHandle New()
	{
		return GtkColorSelectionHandleExterns.gtk_color_selection_new();
	}

/// <summary>
/// <para>
/// Parses a color palette string; the string is a colon-separated
/// list of color names readable by gdk_color_parse().
/// </para>
/// </summary>

/// <param name="str">
/// a string encoding a color palette
/// </param>
/// <param name="colors">
/// return location for
///     allocated array of #GdkColor
/// </param>
/// <param name="n_colors">
/// return location for length of array
/// </param>
/// <return>
/// %TRUE if a palette was successfully parsed
/// </return>

	public static bool PaletteFromString(string str, out MentorLake.Gdk.GdkColor[] colors, out int n_colors)
	{
		return GtkColorSelectionHandleExterns.gtk_color_selection_palette_from_string(str, out colors, out n_colors);
	}

/// <summary>
/// <para>
/// Encodes a palette as a string, useful for persistent storage.
/// </para>
/// </summary>

/// <param name="colors">
/// an array of colors
/// </param>
/// <param name="n_colors">
/// length of the array
/// </param>
/// <return>
/// allocated string encoding the palette
/// </return>

	public static string PaletteToString(MentorLake.Gdk.GdkColor[] colors, int n_colors)
	{
		return GtkColorSelectionHandleExterns.gtk_color_selection_palette_to_string(colors, n_colors);
	}

/// <summary>
/// <para>
/// Installs a global function to be called whenever the user
/// tries to modify the palette in a color selection.
/// </para>
/// <para>
/// This function should save the new palette contents, and update
/// the #GtkSettings:gtk-color-palette GtkSettings property so all
/// GtkColorSelection widgets will be modified.
/// </para>
/// </summary>

/// <param name="func">
/// a function to call when the custom palette needs saving
/// </param>
/// <return>
/// the previous change palette hook (that was replaced)
/// </return>

	public static MentorLake.Gtk.GtkColorSelectionChangePaletteWithScreenFunc SetChangePaletteWithScreenHook(MentorLake.Gtk.GtkColorSelectionChangePaletteWithScreenFunc func)
	{
		return GtkColorSelectionHandleExterns.gtk_color_selection_set_change_palette_with_screen_hook(func);
	}

}
public static class GtkColorSelectionHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when the color changes in the #GtkColorSelection
/// according to its update policy.
/// </para>
/// </summary>

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

public class ColorChangedSignal
{

	public MentorLake.Gtk.GtkColorSelectionHandle Self;

	public IntPtr UserData;
}
}

public static class GtkColorSelectionHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when the color changes in the #GtkColorSelection
/// according to its update policy.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void color_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorSelectionHandle>))] MentorLake.Gtk.GtkColorSelectionHandle self, IntPtr user_data);

}


public static class GtkColorSelectionHandleExtensions
{
/// <summary>
/// <para>
/// Returns the current alpha value.
/// </para>
/// </summary>

/// <param name="colorsel">
/// a #GtkColorSelection
/// </param>
/// <return>
/// an integer between 0 and 65535
/// </return>

	public static ushort GetCurrentAlpha(this MentorLake.Gtk.GtkColorSelectionHandle colorsel)
	{
		if (colorsel.IsInvalid) throw new Exception("Invalid handle (GtkColorSelectionHandle)");
		return GtkColorSelectionHandleExterns.gtk_color_selection_get_current_alpha(colorsel);
	}

/// <summary>
/// <para>
/// Sets @color to be the current color in the GtkColorSelection widget.
/// </para>
/// </summary>

/// <param name="colorsel">
/// a #GtkColorSelection
/// </param>
/// <param name="color">
/// a #GdkColor to fill in with the current color
/// </param>

	public static T GetCurrentColor<T>(this T colorsel, out MentorLake.Gdk.GdkColor color) where T : GtkColorSelectionHandle
	{
		if (colorsel.IsInvalid) throw new Exception("Invalid handle (GtkColorSelectionHandle)");
		GtkColorSelectionHandleExterns.gtk_color_selection_get_current_color(colorsel, out color);
		return colorsel;
	}

/// <summary>
/// <para>
/// Sets @rgba to be the current color in the GtkColorSelection widget.
/// </para>
/// </summary>

/// <param name="colorsel">
/// a #GtkColorSelection
/// </param>
/// <param name="rgba">
/// a #GdkRGBA to fill in with the current color
/// </param>

	public static T GetCurrentRgba<T>(this T colorsel, out MentorLake.Gdk.GdkRGBA rgba) where T : GtkColorSelectionHandle
	{
		if (colorsel.IsInvalid) throw new Exception("Invalid handle (GtkColorSelectionHandle)");
		GtkColorSelectionHandleExterns.gtk_color_selection_get_current_rgba(colorsel, out rgba);
		return colorsel;
	}

/// <summary>
/// <para>
/// Determines whether the colorsel has an opacity control.
/// </para>
/// </summary>

/// <param name="colorsel">
/// a #GtkColorSelection
/// </param>
/// <return>
/// %TRUE if the @colorsel has an opacity control,
///     %FALSE if it does&apos;t
/// </return>

	public static bool GetHasOpacityControl(this MentorLake.Gtk.GtkColorSelectionHandle colorsel)
	{
		if (colorsel.IsInvalid) throw new Exception("Invalid handle (GtkColorSelectionHandle)");
		return GtkColorSelectionHandleExterns.gtk_color_selection_get_has_opacity_control(colorsel);
	}

/// <summary>
/// <para>
/// Determines whether the color selector has a color palette.
/// </para>
/// </summary>

/// <param name="colorsel">
/// a #GtkColorSelection
/// </param>
/// <return>
/// %TRUE if the selector has a palette, %FALSE if it hasn&apos;t
/// </return>

	public static bool GetHasPalette(this MentorLake.Gtk.GtkColorSelectionHandle colorsel)
	{
		if (colorsel.IsInvalid) throw new Exception("Invalid handle (GtkColorSelectionHandle)");
		return GtkColorSelectionHandleExterns.gtk_color_selection_get_has_palette(colorsel);
	}

/// <summary>
/// <para>
/// Returns the previous alpha value.
/// </para>
/// </summary>

/// <param name="colorsel">
/// a #GtkColorSelection
/// </param>
/// <return>
/// an integer between 0 and 65535
/// </return>

	public static ushort GetPreviousAlpha(this MentorLake.Gtk.GtkColorSelectionHandle colorsel)
	{
		if (colorsel.IsInvalid) throw new Exception("Invalid handle (GtkColorSelectionHandle)");
		return GtkColorSelectionHandleExterns.gtk_color_selection_get_previous_alpha(colorsel);
	}

/// <summary>
/// <para>
/// Fills @color in with the original color value.
/// </para>
/// </summary>

/// <param name="colorsel">
/// a #GtkColorSelection
/// </param>
/// <param name="color">
/// a #GdkColor to fill in with the original color value
/// </param>

	public static T GetPreviousColor<T>(this T colorsel, out MentorLake.Gdk.GdkColor color) where T : GtkColorSelectionHandle
	{
		if (colorsel.IsInvalid) throw new Exception("Invalid handle (GtkColorSelectionHandle)");
		GtkColorSelectionHandleExterns.gtk_color_selection_get_previous_color(colorsel, out color);
		return colorsel;
	}

/// <summary>
/// <para>
/// Fills @rgba in with the original color value.
/// </para>
/// </summary>

/// <param name="colorsel">
/// a #GtkColorSelection
/// </param>
/// <param name="rgba">
/// a #GdkRGBA to fill in with the original color value
/// </param>

	public static T GetPreviousRgba<T>(this T colorsel, out MentorLake.Gdk.GdkRGBA rgba) where T : GtkColorSelectionHandle
	{
		if (colorsel.IsInvalid) throw new Exception("Invalid handle (GtkColorSelectionHandle)");
		GtkColorSelectionHandleExterns.gtk_color_selection_get_previous_rgba(colorsel, out rgba);
		return colorsel;
	}

/// <summary>
/// <para>
/// Gets the current state of the @colorsel.
/// </para>
/// </summary>

/// <param name="colorsel">
/// a #GtkColorSelection
/// </param>
/// <return>
/// %TRUE if the user is currently dragging
///     a color around, and %FALSE if the selection has stopped
/// </return>

	public static bool IsAdjusting(this MentorLake.Gtk.GtkColorSelectionHandle colorsel)
	{
		if (colorsel.IsInvalid) throw new Exception("Invalid handle (GtkColorSelectionHandle)");
		return GtkColorSelectionHandleExterns.gtk_color_selection_is_adjusting(colorsel);
	}

/// <summary>
/// <para>
/// Sets the current opacity to be @alpha.
/// </para>
/// <para>
/// The first time this is called, it will also set
/// the original opacity to be @alpha too.
/// </para>
/// </summary>

/// <param name="colorsel">
/// a #GtkColorSelection
/// </param>
/// <param name="alpha">
/// an integer between 0 and 65535
/// </param>

	public static T SetCurrentAlpha<T>(this T colorsel, ushort alpha) where T : GtkColorSelectionHandle
	{
		if (colorsel.IsInvalid) throw new Exception("Invalid handle (GtkColorSelectionHandle)");
		GtkColorSelectionHandleExterns.gtk_color_selection_set_current_alpha(colorsel, alpha);
		return colorsel;
	}

/// <summary>
/// <para>
/// Sets the current color to be @color.
/// </para>
/// <para>
/// The first time this is called, it will also set
/// the original color to be @color too.
/// </para>
/// </summary>

/// <param name="colorsel">
/// a #GtkColorSelection
/// </param>
/// <param name="color">
/// a #GdkColor to set the current color with
/// </param>

	public static T SetCurrentColor<T>(this T colorsel, MentorLake.Gdk.GdkColorHandle color) where T : GtkColorSelectionHandle
	{
		if (colorsel.IsInvalid) throw new Exception("Invalid handle (GtkColorSelectionHandle)");
		GtkColorSelectionHandleExterns.gtk_color_selection_set_current_color(colorsel, color);
		return colorsel;
	}

/// <summary>
/// <para>
/// Sets the current color to be @rgba.
/// </para>
/// <para>
/// The first time this is called, it will also set
/// the original color to be @rgba too.
/// </para>
/// </summary>

/// <param name="colorsel">
/// a #GtkColorSelection
/// </param>
/// <param name="rgba">
/// A #GdkRGBA to set the current color with
/// </param>

	public static T SetCurrentRgba<T>(this T colorsel, MentorLake.Gdk.GdkRGBAHandle rgba) where T : GtkColorSelectionHandle
	{
		if (colorsel.IsInvalid) throw new Exception("Invalid handle (GtkColorSelectionHandle)");
		GtkColorSelectionHandleExterns.gtk_color_selection_set_current_rgba(colorsel, rgba);
		return colorsel;
	}

/// <summary>
/// <para>
/// Sets the @colorsel to use or not use opacity.
/// </para>
/// </summary>

/// <param name="colorsel">
/// a #GtkColorSelection
/// </param>
/// <param name="has_opacity">
/// %TRUE if @colorsel can set the opacity, %FALSE otherwise
/// </param>

	public static T SetHasOpacityControl<T>(this T colorsel, bool has_opacity) where T : GtkColorSelectionHandle
	{
		if (colorsel.IsInvalid) throw new Exception("Invalid handle (GtkColorSelectionHandle)");
		GtkColorSelectionHandleExterns.gtk_color_selection_set_has_opacity_control(colorsel, has_opacity);
		return colorsel;
	}

/// <summary>
/// <para>
/// Shows and hides the palette based upon the value of @has_palette.
/// </para>
/// </summary>

/// <param name="colorsel">
/// a #GtkColorSelection
/// </param>
/// <param name="has_palette">
/// %TRUE if palette is to be visible, %FALSE otherwise
/// </param>

	public static T SetHasPalette<T>(this T colorsel, bool has_palette) where T : GtkColorSelectionHandle
	{
		if (colorsel.IsInvalid) throw new Exception("Invalid handle (GtkColorSelectionHandle)");
		GtkColorSelectionHandleExterns.gtk_color_selection_set_has_palette(colorsel, has_palette);
		return colorsel;
	}

/// <summary>
/// <para>
/// Sets the “previous” alpha to be @alpha.
/// </para>
/// <para>
/// This function should be called with some hesitations,
/// as it might seem confusing to have that alpha change.
/// </para>
/// </summary>

/// <param name="colorsel">
/// a #GtkColorSelection
/// </param>
/// <param name="alpha">
/// an integer between 0 and 65535
/// </param>

	public static T SetPreviousAlpha<T>(this T colorsel, ushort alpha) where T : GtkColorSelectionHandle
	{
		if (colorsel.IsInvalid) throw new Exception("Invalid handle (GtkColorSelectionHandle)");
		GtkColorSelectionHandleExterns.gtk_color_selection_set_previous_alpha(colorsel, alpha);
		return colorsel;
	}

/// <summary>
/// <para>
/// Sets the “previous” color to be @color.
/// </para>
/// <para>
/// This function should be called with some hesitations,
/// as it might seem confusing to have that color change.
/// Calling gtk_color_selection_set_current_color() will also
/// set this color the first time it is called.
/// </para>
/// </summary>

/// <param name="colorsel">
/// a #GtkColorSelection
/// </param>
/// <param name="color">
/// a #GdkColor to set the previous color with
/// </param>

	public static T SetPreviousColor<T>(this T colorsel, MentorLake.Gdk.GdkColorHandle color) where T : GtkColorSelectionHandle
	{
		if (colorsel.IsInvalid) throw new Exception("Invalid handle (GtkColorSelectionHandle)");
		GtkColorSelectionHandleExterns.gtk_color_selection_set_previous_color(colorsel, color);
		return colorsel;
	}

/// <summary>
/// <para>
/// Sets the “previous” color to be @rgba.
/// </para>
/// <para>
/// This function should be called with some hesitations,
/// as it might seem confusing to have that color change.
/// Calling gtk_color_selection_set_current_rgba() will also
/// set this color the first time it is called.
/// </para>
/// </summary>

/// <param name="colorsel">
/// a #GtkColorSelection
/// </param>
/// <param name="rgba">
/// a #GdkRGBA to set the previous color with
/// </param>

	public static T SetPreviousRgba<T>(this T colorsel, MentorLake.Gdk.GdkRGBAHandle rgba) where T : GtkColorSelectionHandle
	{
		if (colorsel.IsInvalid) throw new Exception("Invalid handle (GtkColorSelectionHandle)");
		GtkColorSelectionHandleExterns.gtk_color_selection_set_previous_rgba(colorsel, rgba);
		return colorsel;
	}

}

internal class GtkColorSelectionHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkColorSelectionHandle>))]
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
	internal static extern bool gtk_color_selection_palette_from_string(string str, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out MentorLake.Gdk.GdkColor[] colors, out int n_colors);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_color_selection_palette_to_string(MentorLake.Gdk.GdkColor[] colors, int n_colors);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkColorSelectionChangePaletteWithScreenFunc gtk_color_selection_set_change_palette_with_screen_hook(MentorLake.Gtk.GtkColorSelectionChangePaletteWithScreenFunc func);

}
