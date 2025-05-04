namespace MentorLake.Gtk;

public class GtkStatusbarHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkStatusbarHandle New()
	{
		return GtkStatusbarHandleExterns.gtk_statusbar_new();
	}

}
public static class GtkStatusbarHandleSignalExtensions
{

	public static IObservable<GtkStatusbarHandleSignalStructs.TextPoppedSignal> Signal_TextPopped(this GtkStatusbarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkStatusbarHandleSignalStructs.TextPoppedSignal> obs) =>
		{
			GtkStatusbarHandleSignalDelegates.text_popped handler = ( MentorLake.Gtk.GtkStatusbarHandle self,  uint context_id,  string text,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusbarHandleSignalStructs.TextPoppedSignal()
				{
					Self = self, ContextId = context_id, Text = text, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "text-popped", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkStatusbarHandleSignalStructs.TextPushedSignal> Signal_TextPushed(this GtkStatusbarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkStatusbarHandleSignalStructs.TextPushedSignal> obs) =>
		{
			GtkStatusbarHandleSignalDelegates.text_pushed handler = ( MentorLake.Gtk.GtkStatusbarHandle self,  uint context_id,  string text,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusbarHandleSignalStructs.TextPushedSignal()
				{
					Self = self, ContextId = context_id, Text = text, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "text-pushed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkStatusbarHandleSignalStructs
{

public class TextPoppedSignal
{
	public MentorLake.Gtk.GtkStatusbarHandle Self;
	public uint ContextId;
	public string Text;
	public IntPtr UserData;
}

public class TextPushedSignal
{
	public MentorLake.Gtk.GtkStatusbarHandle Self;
	public uint ContextId;
	public string Text;
	public IntPtr UserData;
}
}

public static class GtkStatusbarHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_popped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusbarHandle>))] MentorLake.Gtk.GtkStatusbarHandle self, uint context_id, string text, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_pushed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusbarHandle>))] MentorLake.Gtk.GtkStatusbarHandle self, uint context_id, string text, IntPtr user_data);

}


public static class GtkStatusbarHandleExtensions
{
	public static uint GetContextId(this MentorLake.Gtk.GtkStatusbarHandle statusbar, string context_description)
	{
		if (statusbar.IsInvalid || statusbar.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusbarHandle)");
		return GtkStatusbarHandleExterns.gtk_statusbar_get_context_id(statusbar, context_description);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetMessageArea(this MentorLake.Gtk.GtkStatusbarHandle statusbar)
	{
		if (statusbar.IsInvalid || statusbar.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusbarHandle)");
		return GtkStatusbarHandleExterns.gtk_statusbar_get_message_area(statusbar);
	}

	public static T Pop<T>(this T statusbar, uint context_id) where T : GtkStatusbarHandle
	{
		if (statusbar.IsInvalid || statusbar.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusbarHandle)");
		GtkStatusbarHandleExterns.gtk_statusbar_pop(statusbar, context_id);
		return statusbar;
	}

	public static uint Push(this MentorLake.Gtk.GtkStatusbarHandle statusbar, uint context_id, string text)
	{
		if (statusbar.IsInvalid || statusbar.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusbarHandle)");
		return GtkStatusbarHandleExterns.gtk_statusbar_push(statusbar, context_id, text);
	}

	public static T Remove<T>(this T statusbar, uint context_id, uint message_id) where T : GtkStatusbarHandle
	{
		if (statusbar.IsInvalid || statusbar.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusbarHandle)");
		GtkStatusbarHandleExterns.gtk_statusbar_remove(statusbar, context_id, message_id);
		return statusbar;
	}

	public static T RemoveAll<T>(this T statusbar, uint context_id) where T : GtkStatusbarHandle
	{
		if (statusbar.IsInvalid || statusbar.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusbarHandle)");
		GtkStatusbarHandleExterns.gtk_statusbar_remove_all(statusbar, context_id);
		return statusbar;
	}

}

internal class GtkStatusbarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStatusbarHandle gtk_statusbar_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_statusbar_get_context_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusbarHandle>))] MentorLake.Gtk.GtkStatusbarHandle statusbar, string context_description);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_statusbar_get_message_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusbarHandle>))] MentorLake.Gtk.GtkStatusbarHandle statusbar);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_statusbar_pop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusbarHandle>))] MentorLake.Gtk.GtkStatusbarHandle statusbar, uint context_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_statusbar_push([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusbarHandle>))] MentorLake.Gtk.GtkStatusbarHandle statusbar, uint context_id, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_statusbar_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusbarHandle>))] MentorLake.Gtk.GtkStatusbarHandle statusbar, uint context_id, uint message_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_statusbar_remove_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusbarHandle>))] MentorLake.Gtk.GtkStatusbarHandle statusbar, uint context_id);

}
