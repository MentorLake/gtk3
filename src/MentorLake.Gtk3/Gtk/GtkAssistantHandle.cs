namespace MentorLake.Gtk;

public class GtkAssistantHandle : GtkWindowHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkAssistantHandle New()
	{
		return GtkAssistantHandleExterns.gtk_assistant_new();
	}

}
public static class GtkAssistantHandleSignalExtensions
{

	public static IObservable<GtkAssistantHandleSignalStructs.ApplySignal> Signal_Apply(this GtkAssistantHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAssistantHandleSignalStructs.ApplySignal> obs) =>
		{
			GtkAssistantHandleSignalDelegates.apply handler = ( MentorLake.Gtk.GtkAssistantHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAssistantHandleSignalStructs.ApplySignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "apply", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkAssistantHandleSignalStructs.CancelSignal> Signal_Cancel(this GtkAssistantHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAssistantHandleSignalStructs.CancelSignal> obs) =>
		{
			GtkAssistantHandleSignalDelegates.cancel handler = ( MentorLake.Gtk.GtkAssistantHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAssistantHandleSignalStructs.CancelSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "cancel", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkAssistantHandleSignalStructs.CloseSignal> Signal_Close(this GtkAssistantHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAssistantHandleSignalStructs.CloseSignal> obs) =>
		{
			GtkAssistantHandleSignalDelegates.close handler = ( MentorLake.Gtk.GtkAssistantHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAssistantHandleSignalStructs.CloseSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "close", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkAssistantHandleSignalStructs.EscapeSignal> Signal_Escape(this GtkAssistantHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAssistantHandleSignalStructs.EscapeSignal> obs) =>
		{
			GtkAssistantHandleSignalDelegates.escape handler = ( MentorLake.Gtk.GtkAssistantHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAssistantHandleSignalStructs.EscapeSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "escape", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkAssistantHandleSignalStructs.PrepareSignal> Signal_Prepare(this GtkAssistantHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAssistantHandleSignalStructs.PrepareSignal> obs) =>
		{
			GtkAssistantHandleSignalDelegates.prepare handler = ( MentorLake.Gtk.GtkAssistantHandle self,  MentorLake.Gtk.GtkWidgetHandle page,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAssistantHandleSignalStructs.PrepareSignal()
				{
					Self = self, Page = page, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "prepare", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkAssistantHandleSignalStructs
{

public struct ApplySignal
{
	public MentorLake.Gtk.GtkAssistantHandle Self;
	public IntPtr UserData;
}

public struct CancelSignal
{
	public MentorLake.Gtk.GtkAssistantHandle Self;
	public IntPtr UserData;
}

public struct CloseSignal
{
	public MentorLake.Gtk.GtkAssistantHandle Self;
	public IntPtr UserData;
}

public struct EscapeSignal
{
	public MentorLake.Gtk.GtkAssistantHandle Self;
	public IntPtr UserData;
}

public struct PrepareSignal
{
	public MentorLake.Gtk.GtkAssistantHandle Self;
	public MentorLake.Gtk.GtkWidgetHandle Page;
	public IntPtr UserData;
}
}

public static class GtkAssistantHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void apply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void escape([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void prepare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page, IntPtr user_data);

}


public static class GtkAssistantHandleExtensions
{
	public static T AddActionWidget<T>(this T assistant, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_add_action_widget(assistant, child);
		return assistant;
	}

	public static int AppendPage(this MentorLake.Gtk.GtkAssistantHandle assistant, MentorLake.Gtk.GtkWidgetHandle page)
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_append_page(assistant, page);
	}

	public static T Commit<T>(this T assistant) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_commit(assistant);
		return assistant;
	}

	public static int GetCurrentPage(this MentorLake.Gtk.GtkAssistantHandle assistant)
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_get_current_page(assistant);
	}

	public static int GetNPages(this MentorLake.Gtk.GtkAssistantHandle assistant)
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_get_n_pages(assistant);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetNthPage(this MentorLake.Gtk.GtkAssistantHandle assistant, int page_num)
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_get_nth_page(assistant, page_num);
	}

	public static bool GetPageComplete(this MentorLake.Gtk.GtkAssistantHandle assistant, MentorLake.Gtk.GtkWidgetHandle page)
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_get_page_complete(assistant, page);
	}

	public static bool GetPageHasPadding(this MentorLake.Gtk.GtkAssistantHandle assistant, MentorLake.Gtk.GtkWidgetHandle page)
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_get_page_has_padding(assistant, page);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetPageHeaderImage(this MentorLake.Gtk.GtkAssistantHandle assistant, MentorLake.Gtk.GtkWidgetHandle page)
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_get_page_header_image(assistant, page);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetPageSideImage(this MentorLake.Gtk.GtkAssistantHandle assistant, MentorLake.Gtk.GtkWidgetHandle page)
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_get_page_side_image(assistant, page);
	}

	public static string GetPageTitle(this MentorLake.Gtk.GtkAssistantHandle assistant, MentorLake.Gtk.GtkWidgetHandle page)
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_get_page_title(assistant, page);
	}

	public static MentorLake.Gtk.GtkAssistantPageType GetPageType(this MentorLake.Gtk.GtkAssistantHandle assistant, MentorLake.Gtk.GtkWidgetHandle page)
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_get_page_type(assistant, page);
	}

	public static int InsertPage(this MentorLake.Gtk.GtkAssistantHandle assistant, MentorLake.Gtk.GtkWidgetHandle page, int position)
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_insert_page(assistant, page, position);
	}

	public static T NextPage<T>(this T assistant) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_next_page(assistant);
		return assistant;
	}

	public static int PrependPage(this MentorLake.Gtk.GtkAssistantHandle assistant, MentorLake.Gtk.GtkWidgetHandle page)
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_prepend_page(assistant, page);
	}

	public static T PreviousPage<T>(this T assistant) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_previous_page(assistant);
		return assistant;
	}

	public static T RemoveActionWidget<T>(this T assistant, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_remove_action_widget(assistant, child);
		return assistant;
	}

	public static T RemovePage<T>(this T assistant, int page_num) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_remove_page(assistant, page_num);
		return assistant;
	}

	public static T SetCurrentPage<T>(this T assistant, int page_num) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_set_current_page(assistant, page_num);
		return assistant;
	}

	public static T SetForwardPageFunc<T>(this T assistant, MentorLake.Gtk.GtkAssistantPageFunc page_func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_set_forward_page_func(assistant, page_func, data, destroy);
		return assistant;
	}

	public static T SetPageComplete<T>(this T assistant, MentorLake.Gtk.GtkWidgetHandle page, bool complete) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_set_page_complete(assistant, page, complete);
		return assistant;
	}

	public static T SetPageHasPadding<T>(this T assistant, MentorLake.Gtk.GtkWidgetHandle page, bool has_padding) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_set_page_has_padding(assistant, page, has_padding);
		return assistant;
	}

	public static T SetPageHeaderImage<T>(this T assistant, MentorLake.Gtk.GtkWidgetHandle page, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_set_page_header_image(assistant, page, pixbuf);
		return assistant;
	}

	public static T SetPageSideImage<T>(this T assistant, MentorLake.Gtk.GtkWidgetHandle page, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_set_page_side_image(assistant, page, pixbuf);
		return assistant;
	}

	public static T SetPageTitle<T>(this T assistant, MentorLake.Gtk.GtkWidgetHandle page, string title) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_set_page_title(assistant, page, title);
		return assistant;
	}

	public static T SetPageType<T>(this T assistant, MentorLake.Gtk.GtkWidgetHandle page, MentorLake.Gtk.GtkAssistantPageType type) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_set_page_type(assistant, page, type);
		return assistant;
	}

	public static T UpdateButtonsState<T>(this T assistant) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid || assistant.IsClosed) throw new Exception("Invalid or closed handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_update_buttons_state(assistant);
		return assistant;
	}

}

internal class GtkAssistantHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAssistantHandle gtk_assistant_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_add_action_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_assistant_append_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_commit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_assistant_get_current_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_assistant_get_n_pages([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_assistant_get_nth_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, int page_num);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_assistant_get_page_complete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_assistant_get_page_has_padding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_assistant_get_page_header_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_assistant_get_page_side_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_assistant_get_page_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAssistantPageType gtk_assistant_get_page_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_assistant_insert_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_next_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_assistant_prepend_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_previous_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_remove_action_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_remove_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, int page_num);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_set_current_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, int page_num);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_set_forward_page_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, MentorLake.Gtk.GtkAssistantPageFunc page_func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_set_page_complete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page, bool complete);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_set_page_has_padding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page, bool has_padding);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_set_page_header_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_set_page_side_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_set_page_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page, string title);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_set_page_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page, MentorLake.Gtk.GtkAssistantPageType type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_update_buttons_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant);

}
