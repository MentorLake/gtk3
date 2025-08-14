namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkFontButton is a button which displays the currently selected
/// font an allows to open a font chooser dialog to change the font.
/// It is suitable widget for selecting a font in a preference dialog.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkFontButton has a single CSS node with name button and style class .font.
/// </para>
/// </summary>

public class GtkFontButtonHandle : GtkButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle, GtkFontChooserHandle
{
/// <summary>
/// <para>
/// Creates a new font picker widget.
/// </para>
/// </summary>

/// <return>
/// a new font picker widget.
/// </return>

	public static MentorLake.Gtk.GtkFontButtonHandle New()
	{
		return GtkFontButtonHandleExterns.gtk_font_button_new();
	}

/// <summary>
/// <para>
/// Creates a new font picker widget.
/// </para>
/// </summary>

/// <param name="fontname">
/// Name of font to display in font chooser dialog
/// </param>
/// <return>
/// a new font picker widget.
/// </return>

	public static MentorLake.Gtk.GtkFontButtonHandle NewWithFont(string fontname)
	{
		return GtkFontButtonHandleExterns.gtk_font_button_new_with_font(fontname);
	}

}
public static class GtkFontButtonHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::font-set signal is emitted when the user selects a font.
/// When handling this signal, use gtk_font_chooser_get_font()
/// to find out which font was just selected.
/// </para>
/// <para>
/// Note that this signal is only emitted when the user
/// changes the font. If you need to react to programmatic font changes
/// as well, use the notify::font signal.
/// </para>
/// </summary>

	public static IObservable<GtkFontButtonHandleSignalStructs.FontSetSignal> Signal_FontSet(this GtkFontButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFontButtonHandleSignalStructs.FontSetSignal> obs) =>
		{
			GtkFontButtonHandleSignalDelegates.font_set handler = ( MentorLake.Gtk.GtkFontButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFontButtonHandleSignalStructs.FontSetSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "font-set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when a font is activated.
/// This usually happens when the user double clicks an item,
/// or an item is selected and the user presses one of the keys
/// Space, Shift+Space, Return or Enter.
/// </para>
/// </summary>

	public static IObservable<GtkFontButtonHandleSignalStructs.FontActivatedSignal> Signal_FontActivated(this GtkFontButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFontButtonHandleSignalStructs.FontActivatedSignal> obs) =>
		{
			GtkFontButtonHandleSignalDelegates.font_activated handler = ( MentorLake.Gtk.GtkFontChooserHandle self,  string fontname,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFontButtonHandleSignalStructs.FontActivatedSignal()
				{
					Self = self, Fontname = fontname, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "font-activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkFontButtonHandleSignalStructs
{

public class FontSetSignal
{

	public MentorLake.Gtk.GtkFontButtonHandle Self;

	public IntPtr UserData;
}

public class FontActivatedSignal
{

	public MentorLake.Gtk.GtkFontChooserHandle Self;
/// <summary>
/// <para>
/// the font name
/// </para>
/// </summary>

	public string Fontname;

	public IntPtr UserData;
}
}

public static class GtkFontButtonHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::font-set signal is emitted when the user selects a font.
/// When handling this signal, use gtk_font_chooser_get_font()
/// to find out which font was just selected.
/// </para>
/// <para>
/// Note that this signal is only emitted when the user
/// changes the font. If you need to react to programmatic font changes
/// as well, use the notify::font signal.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void font_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a font is activated.
/// This usually happens when the user double clicks an item,
/// or an item is selected and the user presses one of the keys
/// Space, Shift+Space, Return or Enter.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="fontname">
/// the font name
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void font_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle self, string fontname, IntPtr user_data);

}


public static class GtkFontButtonHandleExtensions
{
/// <summary>
/// <para>
/// Retrieves the name of the currently selected font. This name includes
/// style and size information as well. If you want to render something
/// with the font, use this string with pango_font_description_from_string() .
/// If you’re interested in peeking certain values (family name,
/// style, size, weight) just query these properties from the
/// #PangoFontDescription object.
/// </para>
/// </summary>

/// <param name="font_button">
/// a #GtkFontButton
/// </param>
/// <return>
/// an internal copy of the font name which must not be freed.
/// </return>

	public static string GetFontName(this MentorLake.Gtk.GtkFontButtonHandle font_button)
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		return GtkFontButtonHandleExterns.gtk_font_button_get_font_name(font_button);
	}

/// <summary>
/// <para>
/// Returns whether the font size will be shown in the label.
/// </para>
/// </summary>

/// <param name="font_button">
/// a #GtkFontButton
/// </param>
/// <return>
/// whether the font size will be shown in the label.
/// </return>

	public static bool GetShowSize(this MentorLake.Gtk.GtkFontButtonHandle font_button)
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		return GtkFontButtonHandleExterns.gtk_font_button_get_show_size(font_button);
	}

/// <summary>
/// <para>
/// Returns whether the name of the font style will be shown in the label.
/// </para>
/// </summary>

/// <param name="font_button">
/// a #GtkFontButton
/// </param>
/// <return>
/// whether the font style will be shown in the label.
/// </return>

	public static bool GetShowStyle(this MentorLake.Gtk.GtkFontButtonHandle font_button)
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		return GtkFontButtonHandleExterns.gtk_font_button_get_show_style(font_button);
	}

/// <summary>
/// <para>
/// Retrieves the title of the font chooser dialog.
/// </para>
/// </summary>

/// <param name="font_button">
/// a #GtkFontButton
/// </param>
/// <return>
/// an internal copy of the title string which must not be freed.
/// </return>

	public static string GetTitle(this MentorLake.Gtk.GtkFontButtonHandle font_button)
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		return GtkFontButtonHandleExterns.gtk_font_button_get_title(font_button);
	}

/// <summary>
/// <para>
/// Returns whether the selected font is used in the label.
/// </para>
/// </summary>

/// <param name="font_button">
/// a #GtkFontButton
/// </param>
/// <return>
/// whether the selected font is used in the label.
/// </return>

	public static bool GetUseFont(this MentorLake.Gtk.GtkFontButtonHandle font_button)
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		return GtkFontButtonHandleExterns.gtk_font_button_get_use_font(font_button);
	}

/// <summary>
/// <para>
/// Returns whether the selected size is used in the label.
/// </para>
/// </summary>

/// <param name="font_button">
/// a #GtkFontButton
/// </param>
/// <return>
/// whether the selected size is used in the label.
/// </return>

	public static bool GetUseSize(this MentorLake.Gtk.GtkFontButtonHandle font_button)
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		return GtkFontButtonHandleExterns.gtk_font_button_get_use_size(font_button);
	}

/// <summary>
/// <para>
/// Sets or updates the currently-displayed font in font picker dialog.
/// </para>
/// </summary>

/// <param name="font_button">
/// a #GtkFontButton
/// </param>
/// <param name="fontname">
/// Name of font to display in font chooser dialog
/// </param>
/// <return>
/// %TRUE
/// </return>

	public static bool SetFontName(this MentorLake.Gtk.GtkFontButtonHandle font_button, string fontname)
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		return GtkFontButtonHandleExterns.gtk_font_button_set_font_name(font_button, fontname);
	}

/// <summary>
/// <para>
/// If @show_size is %TRUE, the font size will be displayed along with the name of the selected font.
/// </para>
/// </summary>

/// <param name="font_button">
/// a #GtkFontButton
/// </param>
/// <param name="show_size">
/// %TRUE if font size should be displayed in dialog.
/// </param>

	public static T SetShowSize<T>(this T font_button, bool show_size) where T : GtkFontButtonHandle
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		GtkFontButtonHandleExterns.gtk_font_button_set_show_size(font_button, show_size);
		return font_button;
	}

/// <summary>
/// <para>
/// If @show_style is %TRUE, the font style will be displayed along with name of the selected font.
/// </para>
/// </summary>

/// <param name="font_button">
/// a #GtkFontButton
/// </param>
/// <param name="show_style">
/// %TRUE if font style should be displayed in label.
/// </param>

	public static T SetShowStyle<T>(this T font_button, bool show_style) where T : GtkFontButtonHandle
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		GtkFontButtonHandleExterns.gtk_font_button_set_show_style(font_button, show_style);
		return font_button;
	}

/// <summary>
/// <para>
/// Sets the title for the font chooser dialog.
/// </para>
/// </summary>

/// <param name="font_button">
/// a #GtkFontButton
/// </param>
/// <param name="title">
/// a string containing the font chooser dialog title
/// </param>

	public static T SetTitle<T>(this T font_button, string title) where T : GtkFontButtonHandle
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		GtkFontButtonHandleExterns.gtk_font_button_set_title(font_button, title);
		return font_button;
	}

/// <summary>
/// <para>
/// If @use_font is %TRUE, the font name will be written using the selected font.
/// </para>
/// </summary>

/// <param name="font_button">
/// a #GtkFontButton
/// </param>
/// <param name="use_font">
/// If %TRUE, font name will be written using font chosen.
/// </param>

	public static T SetUseFont<T>(this T font_button, bool use_font) where T : GtkFontButtonHandle
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		GtkFontButtonHandleExterns.gtk_font_button_set_use_font(font_button, use_font);
		return font_button;
	}

/// <summary>
/// <para>
/// If @use_size is %TRUE, the font name will be written using the selected size.
/// </para>
/// </summary>

/// <param name="font_button">
/// a #GtkFontButton
/// </param>
/// <param name="use_size">
/// If %TRUE, font name will be written using the selected size.
/// </param>

	public static T SetUseSize<T>(this T font_button, bool use_size) where T : GtkFontButtonHandle
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		GtkFontButtonHandleExterns.gtk_font_button_set_use_size(font_button, use_size);
		return font_button;
	}

}

internal class GtkFontButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkFontButtonHandle gtk_font_button_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkFontButtonHandle gtk_font_button_new_with_font(string fontname);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_button_get_font_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_font_button_get_show_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_font_button_get_show_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_button_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_font_button_get_use_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_font_button_get_use_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_font_button_set_font_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button, string fontname);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_font_button_set_show_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button, bool show_size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_font_button_set_show_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button, bool show_style);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_font_button_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button, string title);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_font_button_set_use_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button, bool use_font);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_font_button_set_use_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button, bool use_size);

}
