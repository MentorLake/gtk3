namespace MentorLake.Gtk3.Gtk3;

public class GtkStatusbarHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkStatusbarHandle New()
	{
		return GtkStatusbarExterns.gtk_statusbar_new();
	}

}

public static class GtkStatusbarSignalExtensions
{

	public static IObservable<GtkStatusbarSignalStructs.TextPoppedSignal> Signal_TextPopped(this GtkStatusbarHandle instance)
	{
		return Observable.Create((IObserver<GtkStatusbarSignalStructs.TextPoppedSignal> obs) =>
		{
			GtkStatusbarSignalDelegates.text_popped handler = (GtkStatusbarHandle self, uint context_id, string text, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusbarSignalStructs.TextPoppedSignal()
				{
					Self = self, ContextId = context_id, Text = text, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "text_popped", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkStatusbarSignalStructs.TextPushedSignal> Signal_TextPushed(this GtkStatusbarHandle instance)
	{
		return Observable.Create((IObserver<GtkStatusbarSignalStructs.TextPushedSignal> obs) =>
		{
			GtkStatusbarSignalDelegates.text_pushed handler = (GtkStatusbarHandle self, uint context_id, string text, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusbarSignalStructs.TextPushedSignal()
				{
					Self = self, ContextId = context_id, Text = text, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "text_pushed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkStatusbarSignalStructs
{

public struct TextPoppedSignal
{
	public GtkStatusbarHandle Self;
	public uint ContextId;
	public string Text;
	public IntPtr UserData;
}

public struct TextPushedSignal
{
	public GtkStatusbarHandle Self;
	public uint ContextId;
	public string Text;
	public IntPtr UserData;
}
}

public static class GtkStatusbarSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_popped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkStatusbarHandle>))] GtkStatusbarHandle self, uint context_id, string text, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_pushed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkStatusbarHandle>))] GtkStatusbarHandle self, uint context_id, string text, IntPtr user_data);

}


public static class GtkStatusbarHandleExtensions
{
	public static uint GetContextId(this GtkStatusbarHandle statusbar, string context_description)
	{
		return GtkStatusbarExterns.gtk_statusbar_get_context_id(statusbar, context_description);
	}

	public static GtkWidgetHandle GetMessageArea(this GtkStatusbarHandle statusbar)
	{
		return GtkStatusbarExterns.gtk_statusbar_get_message_area(statusbar);
	}

	public static T Pop<T>(this T statusbar, uint context_id) where T : GtkStatusbarHandle
	{
		GtkStatusbarExterns.gtk_statusbar_pop(statusbar, context_id);
		return statusbar;
	}

	public static uint Push(this GtkStatusbarHandle statusbar, uint context_id, string text)
	{
		return GtkStatusbarExterns.gtk_statusbar_push(statusbar, context_id, text);
	}

	public static T Remove<T>(this T statusbar, uint context_id, uint message_id) where T : GtkStatusbarHandle
	{
		GtkStatusbarExterns.gtk_statusbar_remove(statusbar, context_id, message_id);
		return statusbar;
	}

	public static T RemoveAll<T>(this T statusbar, uint context_id) where T : GtkStatusbarHandle
	{
		GtkStatusbarExterns.gtk_statusbar_remove_all(statusbar, context_id);
		return statusbar;
	}

}

internal class GtkStatusbarExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStatusbarHandle gtk_statusbar_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_statusbar_get_context_id(GtkStatusbarHandle statusbar, string context_description);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_statusbar_get_message_area(GtkStatusbarHandle statusbar);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_statusbar_pop(GtkStatusbarHandle statusbar, uint context_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_statusbar_push(GtkStatusbarHandle statusbar, uint context_id, string text);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_statusbar_remove(GtkStatusbarHandle statusbar, uint context_id, uint message_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_statusbar_remove_all(GtkStatusbarHandle statusbar, uint context_id);

}
