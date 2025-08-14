namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkColorButton is a button which displays the currently selected
/// color and allows to open a color selection dialog to change the color.
/// It is suitable widget for selecting a color in a preference dialog.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkColorButton has a single CSS node with name button. To differentiate
/// it from a plain #GtkButton, it gets the .color style class.
/// </para>
/// </summary>

public class GtkColorButtonHandle : GtkButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle, GtkColorChooserHandle
{
/// <summary>
/// <para>
/// Creates a new color button.
/// </para>
/// <para>
/// This returns a widget in the form of a small button containing
/// a swatch representing the current selected color. When the button
/// is clicked, a color-selection dialog will open, allowing the user
/// to select a color. The swatch will be updated to reflect the new
/// color when the user finishes.
/// </para>
/// </summary>

/// <return>
/// a new color button
/// </return>

	public static MentorLake.Gtk.GtkColorButtonHandle New()
	{
		return GtkColorButtonHandleExterns.gtk_color_button_new();
	}

/// <summary>
/// <para>
/// Creates a new color button.
/// </para>
/// </summary>

/// <param name="color">
/// A #GdkColor to set the current color with
/// </param>
/// <return>
/// a new color button
/// </return>

	public static MentorLake.Gtk.GtkColorButtonHandle NewWithColor(MentorLake.Gdk.GdkColorHandle color)
	{
		return GtkColorButtonHandleExterns.gtk_color_button_new_with_color(color);
	}

/// <summary>
/// <para>
/// Creates a new color button.
/// </para>
/// </summary>

/// <param name="rgba">
/// A #GdkRGBA to set the current color with
/// </param>
/// <return>
/// a new color button
/// </return>

	public static MentorLake.Gtk.GtkColorButtonHandle NewWithRgba(MentorLake.Gdk.GdkRGBAHandle rgba)
	{
		return GtkColorButtonHandleExterns.gtk_color_button_new_with_rgba(rgba);
	}

}
public static class GtkColorButtonHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::color-set signal is emitted when the user selects a color.
/// When handling this signal, use gtk_color_button_get_rgba() to
/// find out which color was just selected.
/// </para>
/// <para>
/// Note that this signal is only emitted when the user
/// changes the color. If you need to react to programmatic color changes
/// as well, use the notify::color signal.
/// </para>
/// </summary>

	public static IObservable<GtkColorButtonHandleSignalStructs.ColorSetSignal> Signal_ColorSet(this GtkColorButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkColorButtonHandleSignalStructs.ColorSetSignal> obs) =>
		{
			GtkColorButtonHandleSignalDelegates.color_set handler = ( MentorLake.Gtk.GtkColorButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkColorButtonHandleSignalStructs.ColorSetSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "color-set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when a color is activated from the color chooser.
/// This usually happens when the user clicks a color swatch,
/// or a color is selected and the user presses one of the keys
/// Space, Shift+Space, Return or Enter.
/// </para>
/// </summary>

	public static IObservable<GtkColorButtonHandleSignalStructs.ColorActivatedSignal> Signal_ColorActivated(this GtkColorButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkColorButtonHandleSignalStructs.ColorActivatedSignal> obs) =>
		{
			GtkColorButtonHandleSignalDelegates.color_activated handler = ( MentorLake.Gtk.GtkColorChooserHandle self,  MentorLake.Gdk.GdkRGBAHandle color,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkColorButtonHandleSignalStructs.ColorActivatedSignal()
				{
					Self = self, Color = color, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "color-activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkColorButtonHandleSignalStructs
{

public class ColorSetSignal
{

	public MentorLake.Gtk.GtkColorButtonHandle Self;

	public IntPtr UserData;
}

public class ColorActivatedSignal
{

	public MentorLake.Gtk.GtkColorChooserHandle Self;
/// <summary>
/// <para>
/// the color
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkRGBAHandle Color;

	public IntPtr UserData;
}
}

public static class GtkColorButtonHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::color-set signal is emitted when the user selects a color.
/// When handling this signal, use gtk_color_button_get_rgba() to
/// find out which color was just selected.
/// </para>
/// <para>
/// Note that this signal is only emitted when the user
/// changes the color. If you need to react to programmatic color changes
/// as well, use the notify::color signal.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void color_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))] MentorLake.Gtk.GtkColorButtonHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a color is activated from the color chooser.
/// This usually happens when the user clicks a color swatch,
/// or a color is selected and the user presses one of the keys
/// Space, Shift+Space, Return or Enter.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="color">
/// the color
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void color_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorChooserHandleImpl>))] MentorLake.Gtk.GtkColorChooserHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle color, IntPtr user_data);

}


public static class GtkColorButtonHandleExtensions
{
/// <summary>
/// <para>
/// Returns the current alpha value.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkColorButton
/// </param>
/// <return>
/// an integer between 0 and 65535
/// </return>

	public static ushort GetAlpha(this MentorLake.Gtk.GtkColorButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkColorButtonHandle)");
		return GtkColorButtonHandleExterns.gtk_color_button_get_alpha(button);
	}

/// <summary>
/// <para>
/// Sets @color to be the current color in the #GtkColorButton widget.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkColorButton
/// </param>
/// <param name="color">
/// a #GdkColor to fill in with the current color
/// </param>

	public static T GetColor<T>(this T button, out MentorLake.Gdk.GdkColor color) where T : GtkColorButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkColorButtonHandle)");
		GtkColorButtonHandleExterns.gtk_color_button_get_color(button, out color);
		return button;
	}

/// <summary>
/// <para>
/// Sets @rgba to be the current color in the #GtkColorButton widget.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkColorButton
/// </param>
/// <param name="rgba">
/// a #GdkRGBA to fill in with the current color
/// </param>

	public static T GetRgba<T>(this T button, out MentorLake.Gdk.GdkRGBA rgba) where T : GtkColorButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkColorButtonHandle)");
		GtkColorButtonHandleExterns.gtk_color_button_get_rgba(button, out rgba);
		return button;
	}

/// <summary>
/// <para>
/// Gets the title of the color selection dialog.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkColorButton
/// </param>
/// <return>
/// An internal string, do not free the return value
/// </return>

	public static string GetTitle(this MentorLake.Gtk.GtkColorButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkColorButtonHandle)");
		return GtkColorButtonHandleExterns.gtk_color_button_get_title(button);
	}

/// <summary>
/// <para>
/// Does the color selection dialog use the alpha channel ?
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkColorButton
/// </param>
/// <return>
/// %TRUE if the color sample uses alpha channel, %FALSE if not
/// </return>

	public static bool GetUseAlpha(this MentorLake.Gtk.GtkColorButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkColorButtonHandle)");
		return GtkColorButtonHandleExterns.gtk_color_button_get_use_alpha(button);
	}

/// <summary>
/// <para>
/// Sets the current opacity to be @alpha.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkColorButton
/// </param>
/// <param name="alpha">
/// an integer between 0 and 65535
/// </param>

	public static T SetAlpha<T>(this T button, ushort alpha) where T : GtkColorButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkColorButtonHandle)");
		GtkColorButtonHandleExterns.gtk_color_button_set_alpha(button, alpha);
		return button;
	}

/// <summary>
/// <para>
/// Sets the current color to be @color.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkColorButton
/// </param>
/// <param name="color">
/// A #GdkColor to set the current color with
/// </param>

	public static T SetColor<T>(this T button, MentorLake.Gdk.GdkColorHandle color) where T : GtkColorButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkColorButtonHandle)");
		GtkColorButtonHandleExterns.gtk_color_button_set_color(button, color);
		return button;
	}

/// <summary>
/// <para>
/// Sets the current color to be @rgba.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkColorButton
/// </param>
/// <param name="rgba">
/// a #GdkRGBA to set the current color with
/// </param>

	public static T SetRgba<T>(this T button, MentorLake.Gdk.GdkRGBAHandle rgba) where T : GtkColorButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkColorButtonHandle)");
		GtkColorButtonHandleExterns.gtk_color_button_set_rgba(button, rgba);
		return button;
	}

/// <summary>
/// <para>
/// Sets the title for the color selection dialog.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkColorButton
/// </param>
/// <param name="title">
/// String containing new window title
/// </param>

	public static T SetTitle<T>(this T button, string title) where T : GtkColorButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkColorButtonHandle)");
		GtkColorButtonHandleExterns.gtk_color_button_set_title(button, title);
		return button;
	}

/// <summary>
/// <para>
/// Sets whether or not the color button should use the alpha channel.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkColorButton
/// </param>
/// <param name="use_alpha">
/// %TRUE if color button should use alpha channel, %FALSE if not
/// </param>

	public static T SetUseAlpha<T>(this T button, bool use_alpha) where T : GtkColorButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkColorButtonHandle)");
		GtkColorButtonHandleExterns.gtk_color_button_set_use_alpha(button, use_alpha);
		return button;
	}

}

internal class GtkColorButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkColorButtonHandle gtk_color_button_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkColorButtonHandle gtk_color_button_new_with_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkColorButtonHandle gtk_color_button_new_with_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle rgba);

	[DllImport(GtkLibrary.Name)]
	internal static extern ushort gtk_color_button_get_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))] MentorLake.Gtk.GtkColorButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_button_get_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))] MentorLake.Gtk.GtkColorButtonHandle button, out MentorLake.Gdk.GdkColor color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_button_get_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))] MentorLake.Gtk.GtkColorButtonHandle button, out MentorLake.Gdk.GdkRGBA rgba);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_color_button_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))] MentorLake.Gtk.GtkColorButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_color_button_get_use_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))] MentorLake.Gtk.GtkColorButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_button_set_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))] MentorLake.Gtk.GtkColorButtonHandle button, ushort alpha);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_button_set_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))] MentorLake.Gtk.GtkColorButtonHandle button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_button_set_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))] MentorLake.Gtk.GtkColorButtonHandle button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle rgba);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_button_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))] MentorLake.Gtk.GtkColorButtonHandle button, string title);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_button_set_use_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))] MentorLake.Gtk.GtkColorButtonHandle button, bool use_alpha);

}
