namespace MentorLake.Gtk3.Gtk3;

public class GtkTextTagHandle : GObjectHandle
{
	public static GtkTextTagHandle New(string name)
	{
		return GtkTextTagExterns.gtk_text_tag_new(name);
	}

}

public static class GtkTextTagSignalExtensions
{

	public static IObservable<GtkTextTagSignalStructs.EventSignal> Signal_Event(this GtkTextTagHandle instance)
	{
		return Observable.Create((IObserver<GtkTextTagSignalStructs.EventSignal> obs) =>
		{
			GtkTextTagSignalDelegates.@event handler = (GtkTextTagHandle self, GObjectHandle @object, GdkEventHandle @event, GtkTextIterHandle iter, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextTagSignalStructs.EventSignal()
				{
					Self = self, Object = @object, Event = @event, Iter = iter, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkTextTagSignalStructs
{

public struct EventSignal
{
	public GtkTextTagHandle Self;
	public GObjectHandle Object;
	public GdkEventHandle Event;
	public GtkTextIterHandle Iter;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkTextTagSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool @event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextTagHandle>))] GtkTextTagHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GObjectHandle>))] GObjectHandle @object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkEventHandle>))] GdkEventHandle @event, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextIterHandle>))] GtkTextIterHandle iter, IntPtr user_data);

}


public static class GtkTextTagHandleExtensions
{
	public static T Changed<T>(this T tag, bool size_changed) where T : GtkTextTagHandle
	{
		GtkTextTagExterns.gtk_text_tag_changed(tag, size_changed);
		return tag;
	}

	public static bool Event(this GtkTextTagHandle tag, GObjectHandle event_object, GdkEventHandle @event, GtkTextIterHandle iter)
	{
		return GtkTextTagExterns.gtk_text_tag_event(tag, event_object, @event, iter);
	}

	public static int GetPriority(this GtkTextTagHandle tag)
	{
		return GtkTextTagExterns.gtk_text_tag_get_priority(tag);
	}

	public static T SetPriority<T>(this T tag, int priority) where T : GtkTextTagHandle
	{
		GtkTextTagExterns.gtk_text_tag_set_priority(tag, priority);
		return tag;
	}

}

internal class GtkTextTagExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTextTagHandle gtk_text_tag_new(string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_tag_changed(GtkTextTagHandle tag, bool size_changed);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_text_tag_event(GtkTextTagHandle tag, GObjectHandle event_object, GdkEventHandle @event, GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_text_tag_get_priority(GtkTextTagHandle tag);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_tag_set_priority(GtkTextTagHandle tag, int priority);

}
