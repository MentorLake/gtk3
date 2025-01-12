namespace MentorLake.Gtk3.Gtk3;

public class GtkLabelHandle : GtkMiscHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkLabelHandle New(string str)
	{
		return GtkLabelExterns.gtk_label_new(str);
	}

	public static GtkLabelHandle NewWithMnemonic(string str)
	{
		return GtkLabelExterns.gtk_label_new_with_mnemonic(str);
	}

}

public static class GtkLabelSignalExtensions
{

	public static IObservable<GtkLabelSignalStructs.ActivateCurrentLinkSignal> Signal_ActivateCurrentLink(this GtkLabelHandle instance)
	{
		return Observable.Create((IObserver<GtkLabelSignalStructs.ActivateCurrentLinkSignal> obs) =>
		{
			GtkLabelSignalDelegates.activate_current_link handler = (GtkLabelHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelSignalStructs.ActivateCurrentLinkSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate_current_link", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkLabelSignalStructs.ActivateLinkSignal> Signal_ActivateLink(this GtkLabelHandle instance)
	{
		return Observable.Create((IObserver<GtkLabelSignalStructs.ActivateLinkSignal> obs) =>
		{
			GtkLabelSignalDelegates.activate_link handler = (GtkLabelHandle self, string uri, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelSignalStructs.ActivateLinkSignal()
				{
					Self = self, Uri = uri, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate_link", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkLabelSignalStructs.CopyClipboardSignal> Signal_CopyClipboard(this GtkLabelHandle instance)
	{
		return Observable.Create((IObserver<GtkLabelSignalStructs.CopyClipboardSignal> obs) =>
		{
			GtkLabelSignalDelegates.copy_clipboard handler = (GtkLabelHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelSignalStructs.CopyClipboardSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "copy_clipboard", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkLabelSignalStructs.MoveCursorSignal> Signal_MoveCursor(this GtkLabelHandle instance)
	{
		return Observable.Create((IObserver<GtkLabelSignalStructs.MoveCursorSignal> obs) =>
		{
			GtkLabelSignalDelegates.move_cursor handler = (GtkLabelHandle self, GtkMovementStep step, int count, bool extend_selection, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelSignalStructs.MoveCursorSignal()
				{
					Self = self, Step = step, Count = count, ExtendSelection = extend_selection, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "move_cursor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkLabelSignalStructs.PopulatePopupSignal> Signal_PopulatePopup(this GtkLabelHandle instance)
	{
		return Observable.Create((IObserver<GtkLabelSignalStructs.PopulatePopupSignal> obs) =>
		{
			GtkLabelSignalDelegates.populate_popup handler = (GtkLabelHandle self, GtkMenuHandle menu, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelSignalStructs.PopulatePopupSignal()
				{
					Self = self, Menu = menu, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "populate_popup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkLabelSignalStructs
{

public struct ActivateCurrentLinkSignal
{
	public GtkLabelHandle Self;
	public IntPtr UserData;
}

public struct ActivateLinkSignal
{
	public GtkLabelHandle Self;
	public string Uri;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct CopyClipboardSignal
{
	public GtkLabelHandle Self;
	public IntPtr UserData;
}

public struct MoveCursorSignal
{
	public GtkLabelHandle Self;
	public GtkMovementStep Step;
	public int Count;
	public bool ExtendSelection;
	public IntPtr UserData;
}

public struct PopulatePopupSignal
{
	public GtkLabelHandle Self;
	public GtkMenuHandle Menu;
	public IntPtr UserData;
}
}

public static class GtkLabelSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate_current_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkLabelHandle>))] GtkLabelHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool activate_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkLabelHandle>))] GtkLabelHandle self, string uri, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void copy_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkLabelHandle>))] GtkLabelHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkLabelHandle>))] GtkLabelHandle self, GtkMovementStep step, int count, bool extend_selection, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void populate_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkLabelHandle>))] GtkLabelHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkMenuHandle>))] GtkMenuHandle menu, IntPtr user_data);

}


public static class GtkLabelHandleExtensions
{
	public static double GetAngle(this GtkLabelHandle label)
	{
		return GtkLabelExterns.gtk_label_get_angle(label);
	}

	public static PangoAttrListHandle GetAttributes(this GtkLabelHandle label)
	{
		return GtkLabelExterns.gtk_label_get_attributes(label);
	}

	public static string GetCurrentUri(this GtkLabelHandle label)
	{
		return GtkLabelExterns.gtk_label_get_current_uri(label);
	}

	public static PangoEllipsizeMode GetEllipsize(this GtkLabelHandle label)
	{
		return GtkLabelExterns.gtk_label_get_ellipsize(label);
	}

	public static GtkJustification GetJustify(this GtkLabelHandle label)
	{
		return GtkLabelExterns.gtk_label_get_justify(label);
	}

	public static string GetLabel(this GtkLabelHandle label)
	{
		return GtkLabelExterns.gtk_label_get_label(label);
	}

	public static PangoLayoutHandle GetLayout(this GtkLabelHandle label)
	{
		return GtkLabelExterns.gtk_label_get_layout(label);
	}

	public static T GetLayoutOffsets<T>(this T label, out int x, out int y) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_get_layout_offsets(label, out x, out y);
		return label;
	}

	public static bool GetLineWrap(this GtkLabelHandle label)
	{
		return GtkLabelExterns.gtk_label_get_line_wrap(label);
	}

	public static PangoWrapMode GetLineWrapMode(this GtkLabelHandle label)
	{
		return GtkLabelExterns.gtk_label_get_line_wrap_mode(label);
	}

	public static int GetLines(this GtkLabelHandle label)
	{
		return GtkLabelExterns.gtk_label_get_lines(label);
	}

	public static int GetMaxWidthChars(this GtkLabelHandle label)
	{
		return GtkLabelExterns.gtk_label_get_max_width_chars(label);
	}

	public static uint GetMnemonicKeyval(this GtkLabelHandle label)
	{
		return GtkLabelExterns.gtk_label_get_mnemonic_keyval(label);
	}

	public static GtkWidgetHandle GetMnemonicWidget(this GtkLabelHandle label)
	{
		return GtkLabelExterns.gtk_label_get_mnemonic_widget(label);
	}

	public static bool GetSelectable(this GtkLabelHandle label)
	{
		return GtkLabelExterns.gtk_label_get_selectable(label);
	}

	public static bool GetSelectionBounds(this GtkLabelHandle label, out int start, out int end)
	{
		return GtkLabelExterns.gtk_label_get_selection_bounds(label, out start, out end);
	}

	public static bool GetSingleLineMode(this GtkLabelHandle label)
	{
		return GtkLabelExterns.gtk_label_get_single_line_mode(label);
	}

	public static string GetText(this GtkLabelHandle label)
	{
		return GtkLabelExterns.gtk_label_get_text(label);
	}

	public static bool GetTrackVisitedLinks(this GtkLabelHandle label)
	{
		return GtkLabelExterns.gtk_label_get_track_visited_links(label);
	}

	public static bool GetUseMarkup(this GtkLabelHandle label)
	{
		return GtkLabelExterns.gtk_label_get_use_markup(label);
	}

	public static bool GetUseUnderline(this GtkLabelHandle label)
	{
		return GtkLabelExterns.gtk_label_get_use_underline(label);
	}

	public static int GetWidthChars(this GtkLabelHandle label)
	{
		return GtkLabelExterns.gtk_label_get_width_chars(label);
	}

	public static float GetXalign(this GtkLabelHandle label)
	{
		return GtkLabelExterns.gtk_label_get_xalign(label);
	}

	public static float GetYalign(this GtkLabelHandle label)
	{
		return GtkLabelExterns.gtk_label_get_yalign(label);
	}

	public static T SelectRegion<T>(this T label, int start_offset, int end_offset) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_select_region(label, start_offset, end_offset);
		return label;
	}

	public static T SetAngle<T>(this T label, double angle) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_angle(label, angle);
		return label;
	}

	public static T SetAttributes<T>(this T label, PangoAttrListHandle attrs) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_attributes(label, attrs);
		return label;
	}

	public static T SetEllipsize<T>(this T label, PangoEllipsizeMode mode) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_ellipsize(label, mode);
		return label;
	}

	public static T SetJustify<T>(this T label, GtkJustification jtype) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_justify(label, jtype);
		return label;
	}

	public static T SetLabel<T>(this T label, string str) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_label(label, str);
		return label;
	}

	public static T SetLineWrap<T>(this T label, bool wrap) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_line_wrap(label, wrap);
		return label;
	}

	public static T SetLineWrapMode<T>(this T label, PangoWrapMode wrap_mode) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_line_wrap_mode(label, wrap_mode);
		return label;
	}

	public static T SetLines<T>(this T label, int lines) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_lines(label, lines);
		return label;
	}

	public static T SetMarkup<T>(this T label, string str) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_markup(label, str);
		return label;
	}

	public static T SetMarkupWithMnemonic<T>(this T label, string str) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_markup_with_mnemonic(label, str);
		return label;
	}

	public static T SetMaxWidthChars<T>(this T label, int n_chars) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_max_width_chars(label, n_chars);
		return label;
	}

	public static T SetMnemonicWidget<T>(this T label, GtkWidgetHandle widget) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_mnemonic_widget(label, widget);
		return label;
	}

	public static T SetPattern<T>(this T label, string pattern) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_pattern(label, pattern);
		return label;
	}

	public static T SetSelectable<T>(this T label, bool setting) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_selectable(label, setting);
		return label;
	}

	public static T SetSingleLineMode<T>(this T label, bool single_line_mode) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_single_line_mode(label, single_line_mode);
		return label;
	}

	public static T SetText<T>(this T label, string str) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_text(label, str);
		return label;
	}

	public static T SetTextWithMnemonic<T>(this T label, string str) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_text_with_mnemonic(label, str);
		return label;
	}

	public static T SetTrackVisitedLinks<T>(this T label, bool track_links) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_track_visited_links(label, track_links);
		return label;
	}

	public static T SetUseMarkup<T>(this T label, bool setting) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_use_markup(label, setting);
		return label;
	}

	public static T SetUseUnderline<T>(this T label, bool setting) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_use_underline(label, setting);
		return label;
	}

	public static T SetWidthChars<T>(this T label, int n_chars) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_width_chars(label, n_chars);
		return label;
	}

	public static T SetXalign<T>(this T label, float xalign) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_xalign(label, xalign);
		return label;
	}

	public static T SetYalign<T>(this T label, float yalign) where T : GtkLabelHandle
	{
		GtkLabelExterns.gtk_label_set_yalign(label, yalign);
		return label;
	}

}

internal class GtkLabelExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkLabelHandle gtk_label_new(string str);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkLabelHandle gtk_label_new_with_mnemonic(string str);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_label_get_angle(GtkLabelHandle label);

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoAttrListHandle gtk_label_get_attributes(GtkLabelHandle label);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_label_get_current_uri(GtkLabelHandle label);

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoEllipsizeMode gtk_label_get_ellipsize(GtkLabelHandle label);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkJustification gtk_label_get_justify(GtkLabelHandle label);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_label_get_label(GtkLabelHandle label);

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoLayoutHandle gtk_label_get_layout(GtkLabelHandle label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_get_layout_offsets(GtkLabelHandle label, out int x, out int y);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_label_get_line_wrap(GtkLabelHandle label);

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoWrapMode gtk_label_get_line_wrap_mode(GtkLabelHandle label);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_label_get_lines(GtkLabelHandle label);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_label_get_max_width_chars(GtkLabelHandle label);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_label_get_mnemonic_keyval(GtkLabelHandle label);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_label_get_mnemonic_widget(GtkLabelHandle label);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_label_get_selectable(GtkLabelHandle label);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_label_get_selection_bounds(GtkLabelHandle label, out int start, out int end);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_label_get_single_line_mode(GtkLabelHandle label);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_label_get_text(GtkLabelHandle label);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_label_get_track_visited_links(GtkLabelHandle label);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_label_get_use_markup(GtkLabelHandle label);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_label_get_use_underline(GtkLabelHandle label);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_label_get_width_chars(GtkLabelHandle label);

	[DllImport(Libraries.Gtk3)]
	internal static extern float gtk_label_get_xalign(GtkLabelHandle label);

	[DllImport(Libraries.Gtk3)]
	internal static extern float gtk_label_get_yalign(GtkLabelHandle label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_select_region(GtkLabelHandle label, int start_offset, int end_offset);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_angle(GtkLabelHandle label, double angle);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_attributes(GtkLabelHandle label, PangoAttrListHandle attrs);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_ellipsize(GtkLabelHandle label, PangoEllipsizeMode mode);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_justify(GtkLabelHandle label, GtkJustification jtype);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_label(GtkLabelHandle label, string str);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_line_wrap(GtkLabelHandle label, bool wrap);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_line_wrap_mode(GtkLabelHandle label, PangoWrapMode wrap_mode);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_lines(GtkLabelHandle label, int lines);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_markup(GtkLabelHandle label, string str);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_markup_with_mnemonic(GtkLabelHandle label, string str);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_max_width_chars(GtkLabelHandle label, int n_chars);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_mnemonic_widget(GtkLabelHandle label, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_pattern(GtkLabelHandle label, string pattern);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_selectable(GtkLabelHandle label, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_single_line_mode(GtkLabelHandle label, bool single_line_mode);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_text(GtkLabelHandle label, string str);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_text_with_mnemonic(GtkLabelHandle label, string str);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_track_visited_links(GtkLabelHandle label, bool track_links);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_use_markup(GtkLabelHandle label, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_use_underline(GtkLabelHandle label, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_width_chars(GtkLabelHandle label, int n_chars);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_xalign(GtkLabelHandle label, float xalign);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_label_set_yalign(GtkLabelHandle label, float yalign);

}
