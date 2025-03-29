namespace MentorLake.Gtk;

public class GtkLabelHandle : GtkMiscHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkLabelHandle New(string str)
	{
		return GtkLabelHandleExterns.gtk_label_new(str);
	}

	public static MentorLake.Gtk.GtkLabelHandle NewWithMnemonic(string str)
	{
		return GtkLabelHandleExterns.gtk_label_new_with_mnemonic(str);
	}

}
public static class GtkLabelHandleSignalExtensions
{

	public static IObservable<GtkLabelHandleSignalStructs.ActivateCurrentLinkSignal> Signal_ActivateCurrentLink(this GtkLabelHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLabelHandleSignalStructs.ActivateCurrentLinkSignal> obs) =>
		{
			GtkLabelHandleSignalDelegates.activate_current_link handler = ( MentorLake.Gtk.GtkLabelHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelHandleSignalStructs.ActivateCurrentLinkSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate-current-link", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkLabelHandleSignalStructs.ActivateLinkSignal> Signal_ActivateLink(this GtkLabelHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLabelHandleSignalStructs.ActivateLinkSignal> obs) =>
		{
			GtkLabelHandleSignalDelegates.activate_link handler = ( MentorLake.Gtk.GtkLabelHandle self,  string uri,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelHandleSignalStructs.ActivateLinkSignal()
				{
					Self = self, Uri = uri, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate-link", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkLabelHandleSignalStructs.CopyClipboardSignal> Signal_CopyClipboard(this GtkLabelHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLabelHandleSignalStructs.CopyClipboardSignal> obs) =>
		{
			GtkLabelHandleSignalDelegates.copy_clipboard handler = ( MentorLake.Gtk.GtkLabelHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelHandleSignalStructs.CopyClipboardSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "copy-clipboard", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkLabelHandleSignalStructs.MoveCursorSignal> Signal_MoveCursor(this GtkLabelHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLabelHandleSignalStructs.MoveCursorSignal> obs) =>
		{
			GtkLabelHandleSignalDelegates.move_cursor handler = ( MentorLake.Gtk.GtkLabelHandle self,  MentorLake.Gtk.GtkMovementStep step,  int count,  bool extend_selection,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelHandleSignalStructs.MoveCursorSignal()
				{
					Self = self, Step = step, Count = count, ExtendSelection = extend_selection, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move-cursor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkLabelHandleSignalStructs.PopulatePopupSignal> Signal_PopulatePopup(this GtkLabelHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLabelHandleSignalStructs.PopulatePopupSignal> obs) =>
		{
			GtkLabelHandleSignalDelegates.populate_popup handler = ( MentorLake.Gtk.GtkLabelHandle self,  MentorLake.Gtk.GtkMenuHandle menu,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelHandleSignalStructs.PopulatePopupSignal()
				{
					Self = self, Menu = menu, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "populate-popup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkLabelHandleSignalStructs
{

public struct ActivateCurrentLinkSignal
{
	public MentorLake.Gtk.GtkLabelHandle Self;
	public IntPtr UserData;
}

public struct ActivateLinkSignal
{
	public MentorLake.Gtk.GtkLabelHandle Self;
	public string Uri;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct CopyClipboardSignal
{
	public MentorLake.Gtk.GtkLabelHandle Self;
	public IntPtr UserData;
}

public struct MoveCursorSignal
{
	public MentorLake.Gtk.GtkLabelHandle Self;
	public MentorLake.Gtk.GtkMovementStep Step;
	public int Count;
	public bool ExtendSelection;
	public IntPtr UserData;
}

public struct PopulatePopupSignal
{
	public MentorLake.Gtk.GtkLabelHandle Self;
	public MentorLake.Gtk.GtkMenuHandle Menu;
	public IntPtr UserData;
}
}

public static class GtkLabelHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate_current_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool activate_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle self, string uri, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void copy_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle self, MentorLake.Gtk.GtkMovementStep step, int count, bool extend_selection, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void populate_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, IntPtr user_data);

}


public static class GtkLabelHandleExtensions
{
	public static double GetAngle(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_angle(label);
	}

	public static MentorLake.Pango.PangoAttrListHandle GetAttributes(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_attributes(label);
	}

	public static string GetCurrentUri(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_current_uri(label);
	}

	public static MentorLake.Pango.PangoEllipsizeMode GetEllipsize(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_ellipsize(label);
	}

	public static MentorLake.Gtk.GtkJustification GetJustify(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_justify(label);
	}

	public static string GetLabel(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_label(label);
	}

	public static MentorLake.Pango.PangoLayoutHandle GetLayout(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_layout(label);
	}

	public static T GetLayoutOffsets<T>(this T label, out int x, out int y) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_get_layout_offsets(label, out x, out y);
		return label;
	}

	public static bool GetLineWrap(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_line_wrap(label);
	}

	public static MentorLake.Pango.PangoWrapMode GetLineWrapMode(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_line_wrap_mode(label);
	}

	public static int GetLines(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_lines(label);
	}

	public static int GetMaxWidthChars(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_max_width_chars(label);
	}

	public static uint GetMnemonicKeyval(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_mnemonic_keyval(label);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetMnemonicWidget(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_mnemonic_widget(label);
	}

	public static bool GetSelectable(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_selectable(label);
	}

	public static bool GetSelectionBounds(this MentorLake.Gtk.GtkLabelHandle label, out int start, out int end)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_selection_bounds(label, out start, out end);
	}

	public static bool GetSingleLineMode(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_single_line_mode(label);
	}

	public static string GetText(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_text(label);
	}

	public static bool GetTrackVisitedLinks(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_track_visited_links(label);
	}

	public static bool GetUseMarkup(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_use_markup(label);
	}

	public static bool GetUseUnderline(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_use_underline(label);
	}

	public static int GetWidthChars(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_width_chars(label);
	}

	public static float GetXalign(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_xalign(label);
	}

	public static float GetYalign(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_yalign(label);
	}

	public static T SelectRegion<T>(this T label, int start_offset, int end_offset) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_select_region(label, start_offset, end_offset);
		return label;
	}

	public static T SetAngle<T>(this T label, double angle) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_angle(label, angle);
		return label;
	}

	public static T SetAttributes<T>(this T label, MentorLake.Pango.PangoAttrListHandle attrs) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_attributes(label, attrs);
		return label;
	}

	public static T SetEllipsize<T>(this T label, MentorLake.Pango.PangoEllipsizeMode mode) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_ellipsize(label, mode);
		return label;
	}

	public static T SetJustify<T>(this T label, MentorLake.Gtk.GtkJustification jtype) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_justify(label, jtype);
		return label;
	}

	public static T SetLabel<T>(this T label, string str) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_label(label, str);
		return label;
	}

	public static T SetLineWrap<T>(this T label, bool wrap) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_line_wrap(label, wrap);
		return label;
	}

	public static T SetLineWrapMode<T>(this T label, MentorLake.Pango.PangoWrapMode wrap_mode) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_line_wrap_mode(label, wrap_mode);
		return label;
	}

	public static T SetLines<T>(this T label, int lines) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_lines(label, lines);
		return label;
	}

	public static T SetMarkup<T>(this T label, string str) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_markup(label, str);
		return label;
	}

	public static T SetMarkupWithMnemonic<T>(this T label, string str) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_markup_with_mnemonic(label, str);
		return label;
	}

	public static T SetMaxWidthChars<T>(this T label, int n_chars) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_max_width_chars(label, n_chars);
		return label;
	}

	public static T SetMnemonicWidget<T>(this T label, MentorLake.Gtk.GtkWidgetHandle widget) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_mnemonic_widget(label, widget);
		return label;
	}

	public static T SetPattern<T>(this T label, string pattern) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_pattern(label, pattern);
		return label;
	}

	public static T SetSelectable<T>(this T label, bool setting) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_selectable(label, setting);
		return label;
	}

	public static T SetSingleLineMode<T>(this T label, bool single_line_mode) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_single_line_mode(label, single_line_mode);
		return label;
	}

	public static T SetText<T>(this T label, string str) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_text(label, str);
		return label;
	}

	public static T SetTextWithMnemonic<T>(this T label, string str) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_text_with_mnemonic(label, str);
		return label;
	}

	public static T SetTrackVisitedLinks<T>(this T label, bool track_links) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_track_visited_links(label, track_links);
		return label;
	}

	public static T SetUseMarkup<T>(this T label, bool setting) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_use_markup(label, setting);
		return label;
	}

	public static T SetUseUnderline<T>(this T label, bool setting) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_use_underline(label, setting);
		return label;
	}

	public static T SetWidthChars<T>(this T label, int n_chars) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_width_chars(label, n_chars);
		return label;
	}

	public static T SetXalign<T>(this T label, float xalign) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_xalign(label, xalign);
		return label;
	}

	public static T SetYalign<T>(this T label, float yalign) where T : GtkLabelHandle
	{
		if (label.IsInvalid || label.IsClosed) throw new Exception("Invalid or closed handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_yalign(label, yalign);
		return label;
	}

}

internal class GtkLabelHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkLabelHandle gtk_label_new(string str);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkLabelHandle gtk_label_new_with_mnemonic(string str);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_label_get_angle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttrListHandle gtk_label_get_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_label_get_current_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoEllipsizeMode gtk_label_get_ellipsize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkJustification gtk_label_get_justify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_label_get_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLayoutHandle gtk_label_get_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_get_layout_offsets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, out int x, out int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_label_get_line_wrap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoWrapMode gtk_label_get_line_wrap_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_label_get_lines([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_label_get_max_width_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_label_get_mnemonic_keyval([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_label_get_mnemonic_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_label_get_selectable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_label_get_selection_bounds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, out int start, out int end);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_label_get_single_line_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_label_get_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_label_get_track_visited_links([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_label_get_use_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_label_get_use_underline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_label_get_width_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern float gtk_label_get_xalign([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern float gtk_label_get_yalign([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_select_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, int start_offset, int end_offset);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_angle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, double angle);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle attrs);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_ellipsize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, MentorLake.Pango.PangoEllipsizeMode mode);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_justify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, MentorLake.Gtk.GtkJustification jtype);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, string str);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_line_wrap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, bool wrap);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_line_wrap_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, MentorLake.Pango.PangoWrapMode wrap_mode);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_lines([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, int lines);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, string str);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_markup_with_mnemonic([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, string str);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_max_width_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, int n_chars);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_mnemonic_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_pattern([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, string pattern);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_selectable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_single_line_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, bool single_line_mode);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, string str);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_text_with_mnemonic([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, string str);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_track_visited_links([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, bool track_links);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_use_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_use_underline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_width_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, int n_chars);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_xalign([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, float xalign);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_yalign([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, float yalign);

}
