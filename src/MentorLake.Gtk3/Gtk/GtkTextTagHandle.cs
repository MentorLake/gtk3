namespace MentorLake.Gtk;

public class GtkTextTagHandle : GObjectHandle
{
	public static MentorLake.Gtk.GtkTextTagHandle New(string name)
	{
		return GtkTextTagHandleExterns.gtk_text_tag_new(name);
	}

}
public static class GtkTextTagHandleSignalExtensions
{

	public static IObservable<GtkTextTagHandleSignalStructs.EventSignal> Signal_Event(this GtkTextTagHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextTagHandleSignalStructs.EventSignal> obs) =>
		{
			GtkTextTagHandleSignalDelegates.@event handler = ( MentorLake.Gtk.GtkTextTagHandle self,  MentorLake.GObject.GObjectHandle @object,  MentorLake.Gdk.GdkEventHandle @event,  MentorLake.Gtk.GtkTextIterHandle iter,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextTagHandleSignalStructs.EventSignal()
				{
					Self = self, Object = @object, Event = @event, Iter = iter, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkTextTagHandleSignalStructs
{

public class EventSignal
{
	public MentorLake.Gtk.GtkTextTagHandle Self;
	public MentorLake.GObject.GObjectHandle Object;
	public MentorLake.Gdk.GdkEventHandle Event;
	public MentorLake.Gtk.GtkTextIterHandle Iter;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkTextTagHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool @event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, IntPtr user_data);

}


public static class GtkTextTagHandleExtensions
{
	public static T Changed<T>(this T tag, bool size_changed) where T : GtkTextTagHandle
	{
		if (tag.IsInvalid) throw new Exception("Invalid handle (GtkTextTagHandle)");
		GtkTextTagHandleExterns.gtk_text_tag_changed(tag, size_changed);
		return tag;
	}

	public static bool Event(this MentorLake.Gtk.GtkTextTagHandle tag, MentorLake.GObject.GObjectHandle event_object, MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (tag.IsInvalid) throw new Exception("Invalid handle (GtkTextTagHandle)");
		return GtkTextTagHandleExterns.gtk_text_tag_event(tag, event_object, @event, iter);
	}

	public static int GetPriority(this MentorLake.Gtk.GtkTextTagHandle tag)
	{
		if (tag.IsInvalid) throw new Exception("Invalid handle (GtkTextTagHandle)");
		return GtkTextTagHandleExterns.gtk_text_tag_get_priority(tag);
	}

	public static T SetPriority<T>(this T tag, int priority) where T : GtkTextTagHandle
	{
		if (tag.IsInvalid) throw new Exception("Invalid handle (GtkTextTagHandle)");
		GtkTextTagHandleExterns.gtk_text_tag_set_priority(tag, priority);
		return tag;
	}

}

internal class GtkTextTagHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))]
	internal static extern MentorLake.Gtk.GtkTextTagHandle gtk_text_tag_new(string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_tag_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag, bool size_changed);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_tag_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle event_object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_tag_get_priority([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_tag_set_priority([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag, int priority);

}
