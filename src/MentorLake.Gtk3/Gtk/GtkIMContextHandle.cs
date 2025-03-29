namespace MentorLake.Gtk;

public class GtkIMContextHandle : GObjectHandle
{
}
public static class GtkIMContextHandleSignalExtensions
{

	public static IObservable<GtkIMContextHandleSignalStructs.CommitSignal> Signal_Commit(this GtkIMContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIMContextHandleSignalStructs.CommitSignal> obs) =>
		{
			GtkIMContextHandleSignalDelegates.commit handler = ( MentorLake.Gtk.GtkIMContextHandle self,  string str,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIMContextHandleSignalStructs.CommitSignal()
				{
					Self = self, Str = str, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "commit", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkIMContextHandleSignalStructs.DeleteSurroundingSignal> Signal_DeleteSurrounding(this GtkIMContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIMContextHandleSignalStructs.DeleteSurroundingSignal> obs) =>
		{
			GtkIMContextHandleSignalDelegates.delete_surrounding handler = ( MentorLake.Gtk.GtkIMContextHandle self,  int offset,  int n_chars,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIMContextHandleSignalStructs.DeleteSurroundingSignal()
				{
					Self = self, Offset = offset, NChars = n_chars, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "delete-surrounding", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkIMContextHandleSignalStructs.PreeditChangedSignal> Signal_PreeditChanged(this GtkIMContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIMContextHandleSignalStructs.PreeditChangedSignal> obs) =>
		{
			GtkIMContextHandleSignalDelegates.preedit_changed handler = ( MentorLake.Gtk.GtkIMContextHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIMContextHandleSignalStructs.PreeditChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "preedit-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkIMContextHandleSignalStructs.PreeditEndSignal> Signal_PreeditEnd(this GtkIMContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIMContextHandleSignalStructs.PreeditEndSignal> obs) =>
		{
			GtkIMContextHandleSignalDelegates.preedit_end handler = ( MentorLake.Gtk.GtkIMContextHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIMContextHandleSignalStructs.PreeditEndSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "preedit-end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkIMContextHandleSignalStructs.PreeditStartSignal> Signal_PreeditStart(this GtkIMContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIMContextHandleSignalStructs.PreeditStartSignal> obs) =>
		{
			GtkIMContextHandleSignalDelegates.preedit_start handler = ( MentorLake.Gtk.GtkIMContextHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIMContextHandleSignalStructs.PreeditStartSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "preedit-start", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkIMContextHandleSignalStructs.RetrieveSurroundingSignal> Signal_RetrieveSurrounding(this GtkIMContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIMContextHandleSignalStructs.RetrieveSurroundingSignal> obs) =>
		{
			GtkIMContextHandleSignalDelegates.retrieve_surrounding handler = ( MentorLake.Gtk.GtkIMContextHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIMContextHandleSignalStructs.RetrieveSurroundingSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "retrieve-surrounding", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkIMContextHandleSignalStructs
{

public struct CommitSignal
{
	public MentorLake.Gtk.GtkIMContextHandle Self;
	public string Str;
	public IntPtr UserData;
}

public struct DeleteSurroundingSignal
{
	public MentorLake.Gtk.GtkIMContextHandle Self;
	public int Offset;
	public int NChars;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct PreeditChangedSignal
{
	public MentorLake.Gtk.GtkIMContextHandle Self;
	public IntPtr UserData;
}

public struct PreeditEndSignal
{
	public MentorLake.Gtk.GtkIMContextHandle Self;
	public IntPtr UserData;
}

public struct PreeditStartSignal
{
	public MentorLake.Gtk.GtkIMContextHandle Self;
	public IntPtr UserData;
}

public struct RetrieveSurroundingSignal
{
	public MentorLake.Gtk.GtkIMContextHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkIMContextHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void commit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextHandle>))] MentorLake.Gtk.GtkIMContextHandle self, string str, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool delete_surrounding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextHandle>))] MentorLake.Gtk.GtkIMContextHandle self, int offset, int n_chars, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void preedit_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextHandle>))] MentorLake.Gtk.GtkIMContextHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void preedit_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextHandle>))] MentorLake.Gtk.GtkIMContextHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void preedit_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextHandle>))] MentorLake.Gtk.GtkIMContextHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool retrieve_surrounding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextHandle>))] MentorLake.Gtk.GtkIMContextHandle self, IntPtr user_data);

}


public static class GtkIMContextHandleExtensions
{
	public static bool DeleteSurrounding(this MentorLake.Gtk.GtkIMContextHandle context, int offset, int n_chars)
	{
		if (context.IsInvalid || context.IsClosed) throw new Exception("Invalid or closed handle (GtkIMContextHandle)");
		return GtkIMContextHandleExterns.gtk_im_context_delete_surrounding(context, offset, n_chars);
	}

	public static bool FilterKeypress(this MentorLake.Gtk.GtkIMContextHandle context, MentorLake.Gdk.GdkEventKeyHandle @event)
	{
		if (context.IsInvalid || context.IsClosed) throw new Exception("Invalid or closed handle (GtkIMContextHandle)");
		return GtkIMContextHandleExterns.gtk_im_context_filter_keypress(context, @event);
	}

	public static T FocusIn<T>(this T context) where T : GtkIMContextHandle
	{
		if (context.IsInvalid || context.IsClosed) throw new Exception("Invalid or closed handle (GtkIMContextHandle)");
		GtkIMContextHandleExterns.gtk_im_context_focus_in(context);
		return context;
	}

	public static T FocusOut<T>(this T context) where T : GtkIMContextHandle
	{
		if (context.IsInvalid || context.IsClosed) throw new Exception("Invalid or closed handle (GtkIMContextHandle)");
		GtkIMContextHandleExterns.gtk_im_context_focus_out(context);
		return context;
	}

	public static T GetPreeditString<T>(this T context, out string str, out MentorLake.Pango.PangoAttrListHandle attrs, out int cursor_pos) where T : GtkIMContextHandle
	{
		if (context.IsInvalid || context.IsClosed) throw new Exception("Invalid or closed handle (GtkIMContextHandle)");
		GtkIMContextHandleExterns.gtk_im_context_get_preedit_string(context, out str, out attrs, out cursor_pos);
		return context;
	}

	public static bool GetSurrounding(this MentorLake.Gtk.GtkIMContextHandle context, out string text, out int cursor_index)
	{
		if (context.IsInvalid || context.IsClosed) throw new Exception("Invalid or closed handle (GtkIMContextHandle)");
		return GtkIMContextHandleExterns.gtk_im_context_get_surrounding(context, out text, out cursor_index);
	}

	public static T Reset<T>(this T context) where T : GtkIMContextHandle
	{
		if (context.IsInvalid || context.IsClosed) throw new Exception("Invalid or closed handle (GtkIMContextHandle)");
		GtkIMContextHandleExterns.gtk_im_context_reset(context);
		return context;
	}

	public static T SetClientWindow<T>(this T context, MentorLake.Gdk.GdkWindowHandle window) where T : GtkIMContextHandle
	{
		if (context.IsInvalid || context.IsClosed) throw new Exception("Invalid or closed handle (GtkIMContextHandle)");
		GtkIMContextHandleExterns.gtk_im_context_set_client_window(context, window);
		return context;
	}

	public static T SetCursorLocation<T>(this T context, MentorLake.Gdk.GdkRectangleHandle area) where T : GtkIMContextHandle
	{
		if (context.IsInvalid || context.IsClosed) throw new Exception("Invalid or closed handle (GtkIMContextHandle)");
		GtkIMContextHandleExterns.gtk_im_context_set_cursor_location(context, area);
		return context;
	}

	public static T SetSurrounding<T>(this T context, string text, int len, int cursor_index) where T : GtkIMContextHandle
	{
		if (context.IsInvalid || context.IsClosed) throw new Exception("Invalid or closed handle (GtkIMContextHandle)");
		GtkIMContextHandleExterns.gtk_im_context_set_surrounding(context, text, len, cursor_index);
		return context;
	}

	public static T SetUsePreedit<T>(this T context, bool use_preedit) where T : GtkIMContextHandle
	{
		if (context.IsInvalid || context.IsClosed) throw new Exception("Invalid or closed handle (GtkIMContextHandle)");
		GtkIMContextHandleExterns.gtk_im_context_set_use_preedit(context, use_preedit);
		return context;
	}

}

internal class GtkIMContextHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_im_context_delete_surrounding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextHandle>))] MentorLake.Gtk.GtkIMContextHandle context, int offset, int n_chars);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_im_context_filter_keypress([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextHandle>))] MentorLake.Gtk.GtkIMContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventKeyHandle>))] MentorLake.Gdk.GdkEventKeyHandle @event);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_im_context_focus_in([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextHandle>))] MentorLake.Gtk.GtkIMContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_im_context_focus_out([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextHandle>))] MentorLake.Gtk.GtkIMContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_im_context_get_preedit_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextHandle>))] MentorLake.Gtk.GtkIMContextHandle context, out string str, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] out MentorLake.Pango.PangoAttrListHandle attrs, out int cursor_pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_im_context_get_surrounding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextHandle>))] MentorLake.Gtk.GtkIMContextHandle context, out string text, out int cursor_index);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_im_context_reset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextHandle>))] MentorLake.Gtk.GtkIMContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_im_context_set_client_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextHandle>))] MentorLake.Gtk.GtkIMContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_im_context_set_cursor_location([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextHandle>))] MentorLake.Gtk.GtkIMContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle area);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_im_context_set_surrounding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextHandle>))] MentorLake.Gtk.GtkIMContextHandle context, string text, int len, int cursor_index);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_im_context_set_use_preedit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextHandle>))] MentorLake.Gtk.GtkIMContextHandle context, bool use_preedit);

}
