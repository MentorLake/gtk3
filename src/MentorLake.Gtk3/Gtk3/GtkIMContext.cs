namespace MentorLake.Gtk3.Gtk3;

public class GtkIMContextHandle : GObjectHandle
{
}

public static class GtkIMContextSignalExtensions
{

	public static IObservable<GtkIMContextSignalStructs.CommitSignal> Signal_Commit(this GtkIMContextHandle instance)
	{
		return Observable.Create((IObserver<GtkIMContextSignalStructs.CommitSignal> obs) =>
		{
			GtkIMContextSignalDelegates.commit handler = (GtkIMContextHandle self, string str, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIMContextSignalStructs.CommitSignal()
				{
					Self = self, Str = str, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "commit", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkIMContextSignalStructs.DeleteSurroundingSignal> Signal_DeleteSurrounding(this GtkIMContextHandle instance)
	{
		return Observable.Create((IObserver<GtkIMContextSignalStructs.DeleteSurroundingSignal> obs) =>
		{
			GtkIMContextSignalDelegates.delete_surrounding handler = (GtkIMContextHandle self, int offset, int n_chars, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIMContextSignalStructs.DeleteSurroundingSignal()
				{
					Self = self, Offset = offset, NChars = n_chars, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "delete_surrounding", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkIMContextSignalStructs.PreeditChangedSignal> Signal_PreeditChanged(this GtkIMContextHandle instance)
	{
		return Observable.Create((IObserver<GtkIMContextSignalStructs.PreeditChangedSignal> obs) =>
		{
			GtkIMContextSignalDelegates.preedit_changed handler = (GtkIMContextHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIMContextSignalStructs.PreeditChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "preedit_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkIMContextSignalStructs.PreeditEndSignal> Signal_PreeditEnd(this GtkIMContextHandle instance)
	{
		return Observable.Create((IObserver<GtkIMContextSignalStructs.PreeditEndSignal> obs) =>
		{
			GtkIMContextSignalDelegates.preedit_end handler = (GtkIMContextHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIMContextSignalStructs.PreeditEndSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "preedit_end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkIMContextSignalStructs.PreeditStartSignal> Signal_PreeditStart(this GtkIMContextHandle instance)
	{
		return Observable.Create((IObserver<GtkIMContextSignalStructs.PreeditStartSignal> obs) =>
		{
			GtkIMContextSignalDelegates.preedit_start handler = (GtkIMContextHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIMContextSignalStructs.PreeditStartSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "preedit_start", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkIMContextSignalStructs.RetrieveSurroundingSignal> Signal_RetrieveSurrounding(this GtkIMContextHandle instance)
	{
		return Observable.Create((IObserver<GtkIMContextSignalStructs.RetrieveSurroundingSignal> obs) =>
		{
			GtkIMContextSignalDelegates.retrieve_surrounding handler = (GtkIMContextHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIMContextSignalStructs.RetrieveSurroundingSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "retrieve_surrounding", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkIMContextSignalStructs
{

public struct CommitSignal
{
	public GtkIMContextHandle Self;
	public string Str;
	public IntPtr UserData;
}

public struct DeleteSurroundingSignal
{
	public GtkIMContextHandle Self;
	public int Offset;
	public int NChars;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct PreeditChangedSignal
{
	public GtkIMContextHandle Self;
	public IntPtr UserData;
}

public struct PreeditEndSignal
{
	public GtkIMContextHandle Self;
	public IntPtr UserData;
}

public struct PreeditStartSignal
{
	public GtkIMContextHandle Self;
	public IntPtr UserData;
}

public struct RetrieveSurroundingSignal
{
	public GtkIMContextHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkIMContextSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void commit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkIMContextHandle>))] GtkIMContextHandle self, string str, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool delete_surrounding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkIMContextHandle>))] GtkIMContextHandle self, int offset, int n_chars, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void preedit_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkIMContextHandle>))] GtkIMContextHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void preedit_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkIMContextHandle>))] GtkIMContextHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void preedit_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkIMContextHandle>))] GtkIMContextHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool retrieve_surrounding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkIMContextHandle>))] GtkIMContextHandle self, IntPtr user_data);

}


public static class GtkIMContextHandleExtensions
{
	public static bool GtkImContextDeleteSurrounding(this GtkIMContextHandle context, int offset, int n_chars)
	{
		return GtkIMContextExterns.gtk_im_context_delete_surrounding(context, offset, n_chars);
	}

	public static bool GtkImContextFilterKeypress(this GtkIMContextHandle context, GdkEventKeyHandle @event)
	{
		return GtkIMContextExterns.gtk_im_context_filter_keypress(context, @event);
	}

	public static T GtkImContextFocusIn<T>(this T context) where T : GtkIMContextHandle
	{
		GtkIMContextExterns.gtk_im_context_focus_in(context);
		return context;
	}

	public static T GtkImContextFocusOut<T>(this T context) where T : GtkIMContextHandle
	{
		GtkIMContextExterns.gtk_im_context_focus_out(context);
		return context;
	}

	public static T GtkImContextGetPreeditString<T>(this T context, out string str, out PangoAttrListHandle attrs, out int cursor_pos) where T : GtkIMContextHandle
	{
		GtkIMContextExterns.gtk_im_context_get_preedit_string(context, out str, out attrs, out cursor_pos);
		return context;
	}

	public static bool GtkImContextGetSurrounding(this GtkIMContextHandle context, out string text, out int cursor_index)
	{
		return GtkIMContextExterns.gtk_im_context_get_surrounding(context, out text, out cursor_index);
	}

	public static T GtkImContextReset<T>(this T context) where T : GtkIMContextHandle
	{
		GtkIMContextExterns.gtk_im_context_reset(context);
		return context;
	}

	public static T GtkImContextSetClientWindow<T>(this T context, GdkWindowHandle window) where T : GtkIMContextHandle
	{
		GtkIMContextExterns.gtk_im_context_set_client_window(context, window);
		return context;
	}

	public static T GtkImContextSetCursorLocation<T>(this T context, GdkRectangleHandle area) where T : GtkIMContextHandle
	{
		GtkIMContextExterns.gtk_im_context_set_cursor_location(context, area);
		return context;
	}

	public static T GtkImContextSetSurrounding<T>(this T context, string text, int len, int cursor_index) where T : GtkIMContextHandle
	{
		GtkIMContextExterns.gtk_im_context_set_surrounding(context, text, len, cursor_index);
		return context;
	}

	public static T GtkImContextSetUsePreedit<T>(this T context, bool use_preedit) where T : GtkIMContextHandle
	{
		GtkIMContextExterns.gtk_im_context_set_use_preedit(context, use_preedit);
		return context;
	}

}

internal class GtkIMContextExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_im_context_delete_surrounding(GtkIMContextHandle context, int offset, int n_chars);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_im_context_filter_keypress(GtkIMContextHandle context, GdkEventKeyHandle @event);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_im_context_focus_in(GtkIMContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_im_context_focus_out(GtkIMContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_im_context_get_preedit_string(GtkIMContextHandle context, out string str, out PangoAttrListHandle attrs, out int cursor_pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_im_context_get_surrounding(GtkIMContextHandle context, out string text, out int cursor_index);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_im_context_reset(GtkIMContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_im_context_set_client_window(GtkIMContextHandle context, GdkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_im_context_set_cursor_location(GtkIMContextHandle context, GdkRectangleHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_im_context_set_surrounding(GtkIMContextHandle context, string text, int len, int cursor_index);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_im_context_set_use_preedit(GtkIMContextHandle context, bool use_preedit);

}
