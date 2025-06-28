namespace MentorLake.Gtk;

public class GtkClipboardHandle : GObjectHandle
{
	public static MentorLake.Gtk.GtkClipboardHandle Get(MentorLake.Gdk.GdkAtom selection)
	{
		return GtkClipboardHandleExterns.gtk_clipboard_get(selection);
	}

	public static MentorLake.Gtk.GtkClipboardHandle GetDefault(MentorLake.Gdk.GdkDisplayHandle display)
	{
		return GtkClipboardHandleExterns.gtk_clipboard_get_default(display);
	}

	public static MentorLake.Gtk.GtkClipboardHandle GetForDisplay(MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkAtom selection)
	{
		return GtkClipboardHandleExterns.gtk_clipboard_get_for_display(display, selection);
	}

}
public static class GtkClipboardHandleSignalExtensions
{

	public static IObservable<GtkClipboardHandleSignalStructs.OwnerChangeSignal> Signal_OwnerChange(this GtkClipboardHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkClipboardHandleSignalStructs.OwnerChangeSignal> obs) =>
		{
			GtkClipboardHandleSignalDelegates.owner_change handler = ( MentorLake.Gtk.GtkClipboardHandle self,  MentorLake.Gdk.GdkEventOwnerChangeHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkClipboardHandleSignalStructs.OwnerChangeSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "owner-change", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkClipboardHandleSignalStructs
{

public class OwnerChangeSignal
{
	public MentorLake.Gtk.GtkClipboardHandle Self;
	public MentorLake.Gdk.GdkEventOwnerChangeHandle Event;
	public IntPtr UserData;
}
}

public static class GtkClipboardHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void owner_change([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventOwnerChangeHandle>))] MentorLake.Gdk.GdkEventOwnerChangeHandle @event, IntPtr user_data);

}


public static class GtkClipboardHandleExtensions
{
	public static T Clear<T>(this T clipboard) where T : GtkClipboardHandle
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		GtkClipboardHandleExterns.gtk_clipboard_clear(clipboard);
		return clipboard;
	}

	public static MentorLake.Gdk.GdkDisplayHandle GetDisplay(this MentorLake.Gtk.GtkClipboardHandle clipboard)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_get_display(clipboard);
	}

	public static MentorLake.GObject.GObjectHandle GetOwner(this MentorLake.Gtk.GtkClipboardHandle clipboard)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_get_owner(clipboard);
	}

	public static MentorLake.Gdk.GdkAtom GetSelection(this MentorLake.Gtk.GtkClipboardHandle clipboard)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_get_selection(clipboard);
	}

	public static T RequestContents<T>(this T clipboard, MentorLake.Gdk.GdkAtom target, MentorLake.Gtk.GtkClipboardReceivedFunc callback, IntPtr user_data) where T : GtkClipboardHandle
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		GtkClipboardHandleExterns.gtk_clipboard_request_contents(clipboard, target, callback, user_data);
		return clipboard;
	}

	public static T RequestImage<T>(this T clipboard, MentorLake.Gtk.GtkClipboardImageReceivedFunc callback, IntPtr user_data) where T : GtkClipboardHandle
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		GtkClipboardHandleExterns.gtk_clipboard_request_image(clipboard, callback, user_data);
		return clipboard;
	}

	public static T RequestRichText<T>(this T clipboard, MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gtk.GtkClipboardRichTextReceivedFunc callback, IntPtr user_data) where T : GtkClipboardHandle
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		GtkClipboardHandleExterns.gtk_clipboard_request_rich_text(clipboard, buffer, callback, user_data);
		return clipboard;
	}

	public static T RequestTargets<T>(this T clipboard, MentorLake.Gtk.GtkClipboardTargetsReceivedFunc callback, IntPtr user_data) where T : GtkClipboardHandle
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		GtkClipboardHandleExterns.gtk_clipboard_request_targets(clipboard, callback, user_data);
		return clipboard;
	}

	public static T RequestText<T>(this T clipboard, MentorLake.Gtk.GtkClipboardTextReceivedFunc callback, IntPtr user_data) where T : GtkClipboardHandle
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		GtkClipboardHandleExterns.gtk_clipboard_request_text(clipboard, callback, user_data);
		return clipboard;
	}

	public static T RequestUris<T>(this T clipboard, MentorLake.Gtk.GtkClipboardURIReceivedFunc callback, IntPtr user_data) where T : GtkClipboardHandle
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		GtkClipboardHandleExterns.gtk_clipboard_request_uris(clipboard, callback, user_data);
		return clipboard;
	}

	public static T SetCanStore<T>(this T clipboard, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets) where T : GtkClipboardHandle
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		GtkClipboardHandleExterns.gtk_clipboard_set_can_store(clipboard, targets, n_targets);
		return clipboard;
	}

	public static T SetImage<T>(this T clipboard, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf) where T : GtkClipboardHandle
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		GtkClipboardHandleExterns.gtk_clipboard_set_image(clipboard, pixbuf);
		return clipboard;
	}

	public static T SetText<T>(this T clipboard, string text, int len) where T : GtkClipboardHandle
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		GtkClipboardHandleExterns.gtk_clipboard_set_text(clipboard, text, len);
		return clipboard;
	}

	public static bool SetWithData(this MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gtk.GtkTargetEntry[] targets, uint n_targets, MentorLake.Gtk.GtkClipboardGetFunc get_func, MentorLake.Gtk.GtkClipboardClearFunc clear_func, IntPtr user_data)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_set_with_data(clipboard, targets, n_targets, get_func, clear_func, user_data);
	}

	public static bool SetWithOwner(this MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gtk.GtkTargetEntry[] targets, uint n_targets, MentorLake.Gtk.GtkClipboardGetFunc get_func, MentorLake.Gtk.GtkClipboardClearFunc clear_func, MentorLake.GObject.GObjectHandle owner)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_set_with_owner(clipboard, targets, n_targets, get_func, clear_func, owner);
	}

	public static T Store<T>(this T clipboard) where T : GtkClipboardHandle
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		GtkClipboardHandleExterns.gtk_clipboard_store(clipboard);
		return clipboard;
	}

	public static MentorLake.Gtk.GtkSelectionDataHandle WaitForContents(this MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gdk.GdkAtom target)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_wait_for_contents(clipboard, target);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle WaitForImage(this MentorLake.Gtk.GtkClipboardHandle clipboard)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_wait_for_image(clipboard);
	}

	public static byte[] WaitForRichText(this MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gtk.GtkTextBufferHandle buffer, out MentorLake.Gdk.GdkAtom format, out UIntPtr length)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_wait_for_rich_text(clipboard, buffer, out format, out length);
	}

	public static bool WaitForTargets(this MentorLake.Gtk.GtkClipboardHandle clipboard, out MentorLake.Gdk.GdkAtom[] targets, out int n_targets)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_wait_for_targets(clipboard, out targets, out n_targets);
	}

	public static string WaitForText(this MentorLake.Gtk.GtkClipboardHandle clipboard)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_wait_for_text(clipboard);
	}

	public static string[] WaitForUris(this MentorLake.Gtk.GtkClipboardHandle clipboard)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_wait_for_uris(clipboard);
	}

	public static bool WaitIsImageAvailable(this MentorLake.Gtk.GtkClipboardHandle clipboard)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_wait_is_image_available(clipboard);
	}

	public static bool WaitIsRichTextAvailable(this MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_wait_is_rich_text_available(clipboard, buffer);
	}

	public static bool WaitIsTargetAvailable(this MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gdk.GdkAtom target)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_wait_is_target_available(clipboard, target);
	}

	public static bool WaitIsTextAvailable(this MentorLake.Gtk.GtkClipboardHandle clipboard)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_wait_is_text_available(clipboard);
	}

	public static bool WaitIsUrisAvailable(this MentorLake.Gtk.GtkClipboardHandle clipboard)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_wait_is_uris_available(clipboard);
	}

}

internal class GtkClipboardHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_clipboard_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))]
	internal static extern MentorLake.Gdk.GdkDisplayHandle gtk_clipboard_get_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle gtk_clipboard_get_owner([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkAtom gtk_clipboard_get_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_clipboard_request_contents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gdk.GdkAtom target, MentorLake.Gtk.GtkClipboardReceivedFunc callback, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_clipboard_request_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gtk.GtkClipboardImageReceivedFunc callback, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_clipboard_request_rich_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gtk.GtkClipboardRichTextReceivedFunc callback, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_clipboard_request_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gtk.GtkClipboardTargetsReceivedFunc callback, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_clipboard_request_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gtk.GtkClipboardTextReceivedFunc callback, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_clipboard_request_uris([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gtk.GtkClipboardURIReceivedFunc callback, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_clipboard_set_can_store([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_clipboard_set_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_clipboard_set_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, string text, int len);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_clipboard_set_with_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gtk.GtkTargetEntry[] targets, uint n_targets, MentorLake.Gtk.GtkClipboardGetFunc get_func, MentorLake.Gtk.GtkClipboardClearFunc clear_func, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_clipboard_set_with_owner([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gtk.GtkTargetEntry[] targets, uint n_targets, MentorLake.Gtk.GtkClipboardGetFunc get_func, MentorLake.Gtk.GtkClipboardClearFunc clear_func, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle owner);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_clipboard_store([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))]
	internal static extern MentorLake.Gtk.GtkSelectionDataHandle gtk_clipboard_wait_for_contents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gdk.GdkAtom target);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_clipboard_wait_for_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard);

	[DllImport(GtkLibrary.Name)]
	internal static extern byte[] gtk_clipboard_wait_for_rich_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, out MentorLake.Gdk.GdkAtom format, out UIntPtr length);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_clipboard_wait_for_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, out MentorLake.Gdk.GdkAtom[] targets, out int n_targets);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_clipboard_wait_for_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] gtk_clipboard_wait_for_uris([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_clipboard_wait_is_image_available([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_clipboard_wait_is_rich_text_available([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_clipboard_wait_is_target_available([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gdk.GdkAtom target);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_clipboard_wait_is_text_available([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_clipboard_wait_is_uris_available([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))]
	internal static extern MentorLake.Gtk.GtkClipboardHandle gtk_clipboard_get(MentorLake.Gdk.GdkAtom selection);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))]
	internal static extern MentorLake.Gtk.GtkClipboardHandle gtk_clipboard_get_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))]
	internal static extern MentorLake.Gtk.GtkClipboardHandle gtk_clipboard_get_for_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkAtom selection);

}
