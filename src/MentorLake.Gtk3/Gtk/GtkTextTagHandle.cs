namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// You may wish to begin by reading the
/// [text widget conceptual overview](TextWidget.html)
/// which gives an overview of all the objects and
/// data types related to the text widget and how they work together.
/// </para>
/// <para>
/// Tags should be in the #GtkTextTagTable for a given #GtkTextBuffer
/// before using them with that buffer.
/// </para>
/// <para>
/// gtk_text_buffer_create_tag() is the best way to create tags.
/// See “gtk3-demo” for numerous examples.
/// </para>
/// <para>
/// For each property of #GtkTextTag, there is a “set” property, e.g.
/// “font-set” corresponds to “font”. These “set” properties reflect
/// whether a property has been set or not.
/// They are maintained by GTK+ and you should not set them independently.
/// </para>
/// </summary>

public class GtkTextTagHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a #GtkTextTag. Configure the tag using object arguments,
/// i.e. using g_object_set().
/// </para>
/// </summary>

/// <param name="name">
/// tag name, or %NULL
/// </param>
/// <return>
/// a new #GtkTextTag
/// </return>

	public static MentorLake.Gtk.GtkTextTagHandle New(string name)
	{
		return GtkTextTagHandleExterns.gtk_text_tag_new(name);
	}

}
public static class GtkTextTagHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::event signal is emitted when an event occurs on a region of the
/// buffer marked with this tag.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// the object the event was fired from (typically a #GtkTextView)
/// </para>
/// </summary>

	public MentorLake.GObject.GObjectHandle Object;
/// <summary>
/// <para>
/// the event which triggered the signal
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventHandle Event;
/// <summary>
/// <para>
/// a #GtkTextIter pointing at the location the event occurred
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextIterHandle Iter;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the
/// event. %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}
}

public static class GtkTextTagHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::event signal is emitted when an event occurs on a region of the
/// buffer marked with this tag.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@object">
/// the object the event was fired from (typically a #GtkTextView)
/// </param>
/// <param name="@event">
/// the event which triggered the signal
/// </param>
/// <param name="iter">
/// a #GtkTextIter pointing at the location the event occurred
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the
/// event. %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool @event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, IntPtr user_data);

}


public static class GtkTextTagHandleExtensions
{
/// <summary>
/// <para>
/// Emits the #GtkTextTagTable::tag-changed signal on the #GtkTextTagTable where
/// the tag is included.
/// </para>
/// <para>
/// The signal is already emitted when setting a #GtkTextTag property. This
/// function is useful for a #GtkTextTag subclass.
/// </para>
/// </summary>

/// <param name="tag">
/// a #GtkTextTag.
/// </param>
/// <param name="size_changed">
/// whether the change affects the #GtkTextView layout.
/// </param>

	public static T Changed<T>(this T tag, bool size_changed) where T : GtkTextTagHandle
	{
		if (tag.IsInvalid) throw new Exception("Invalid handle (GtkTextTagHandle)");
		GtkTextTagHandleExterns.gtk_text_tag_changed(tag, size_changed);
		return tag;
	}

/// <summary>
/// <para>
/// Emits the “event” signal on the #GtkTextTag.
/// </para>
/// </summary>

/// <param name="tag">
/// a #GtkTextTag
/// </param>
/// <param name="event_object">
/// object that received the event, such as a widget
/// </param>
/// <param name="@event">
/// the event
/// </param>
/// <param name="iter">
/// location where the event was received
/// </param>
/// <return>
/// result of signal emission (whether the event was handled)
/// </return>

	public static bool Event(this MentorLake.Gtk.GtkTextTagHandle tag, MentorLake.GObject.GObjectHandle event_object, MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (tag.IsInvalid) throw new Exception("Invalid handle (GtkTextTagHandle)");
		return GtkTextTagHandleExterns.gtk_text_tag_event(tag, event_object, @event, iter);
	}

/// <summary>
/// <para>
/// Get the tag priority.
/// </para>
/// </summary>

/// <param name="tag">
/// a #GtkTextTag
/// </param>
/// <return>
/// The tag’s priority.
/// </return>

	public static int GetPriority(this MentorLake.Gtk.GtkTextTagHandle tag)
	{
		if (tag.IsInvalid) throw new Exception("Invalid handle (GtkTextTagHandle)");
		return GtkTextTagHandleExterns.gtk_text_tag_get_priority(tag);
	}

/// <summary>
/// <para>
/// Sets the priority of a #GtkTextTag. Valid priorities
/// start at 0 and go to one less than gtk_text_tag_table_get_size().
/// Each tag in a table has a unique priority; setting the priority
/// of one tag shifts the priorities of all the other tags in the
/// table to maintain a unique priority for each tag. Higher priority
/// tags “win” if two tags both set the same text attribute. When adding
/// a tag to a tag table, it will be assigned the highest priority in
/// the table by default; so normally the precedence of a set of tags
/// is the order in which they were added to the table, or created with
/// gtk_text_buffer_create_tag(), which adds the tag to the buffer’s table
/// automatically.
/// </para>
/// </summary>

/// <param name="tag">
/// a #GtkTextTag
/// </param>
/// <param name="priority">
/// the new priority
/// </param>

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
