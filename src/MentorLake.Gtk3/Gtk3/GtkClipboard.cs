namespace MentorLake.Gtk3.Gtk3;

public class GtkClipboardHandle : GObjectHandle
{
	public static GtkClipboardHandle Get(GdkAtom selection)
	{
		return GtkClipboardExterns.gtk_clipboard_get(selection);
	}

	public static GtkClipboardHandle GetDefault(GdkDisplayHandle display)
	{
		return GtkClipboardExterns.gtk_clipboard_get_default(display);
	}

	public static GtkClipboardHandle GetForDisplay(GdkDisplayHandle display, GdkAtom selection)
	{
		return GtkClipboardExterns.gtk_clipboard_get_for_display(display, selection);
	}

}

public static class GtkClipboardSignalExtensions
{

	public static IObservable<GtkClipboardSignalStructs.OwnerChangeSignal> Signal_OwnerChange(this GtkClipboardHandle instance)
	{
		return Observable.Create((IObserver<GtkClipboardSignalStructs.OwnerChangeSignal> obs) =>
		{
			GtkClipboardSignalDelegates.owner_change handler = (GtkClipboardHandle self, GdkEventOwnerChange @event, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkClipboardSignalStructs.OwnerChangeSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "owner_change", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkClipboardSignalStructs
{

public struct OwnerChangeSignal
{
	public GtkClipboardHandle Self;
	public GdkEventOwnerChange Event;
	public IntPtr UserData;
}
}

public static class GtkClipboardSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void owner_change([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkClipboardHandle>))] GtkClipboardHandle self, GdkEventOwnerChange @event, IntPtr user_data);

}


public static class GtkClipboardHandleExtensions
{
	public static GtkClipboardHandle Clear(this GtkClipboardHandle clipboard)
	{
		GtkClipboardExterns.gtk_clipboard_clear(clipboard);
		return clipboard;
	}

	public static GdkDisplayHandle GetDisplay(this GtkClipboardHandle clipboard)
	{
		return GtkClipboardExterns.gtk_clipboard_get_display(clipboard);
	}

	public static GObjectHandle GetOwner(this GtkClipboardHandle clipboard)
	{
		return GtkClipboardExterns.gtk_clipboard_get_owner(clipboard);
	}

	public static GdkAtom GetSelection(this GtkClipboardHandle clipboard)
	{
		return GtkClipboardExterns.gtk_clipboard_get_selection(clipboard);
	}

	public static GtkClipboardHandle RequestContents(this GtkClipboardHandle clipboard, GdkAtom target, GtkClipboardReceivedFunc callback, IntPtr user_data)
	{
		GtkClipboardExterns.gtk_clipboard_request_contents(clipboard, target, callback, user_data);
		return clipboard;
	}

	public static GtkClipboardHandle RequestImage(this GtkClipboardHandle clipboard, GtkClipboardImageReceivedFunc callback, IntPtr user_data)
	{
		GtkClipboardExterns.gtk_clipboard_request_image(clipboard, callback, user_data);
		return clipboard;
	}

	public static GtkClipboardHandle RequestRichText(this GtkClipboardHandle clipboard, GtkTextBufferHandle buffer, GtkClipboardRichTextReceivedFunc callback, IntPtr user_data)
	{
		GtkClipboardExterns.gtk_clipboard_request_rich_text(clipboard, buffer, callback, user_data);
		return clipboard;
	}

	public static GtkClipboardHandle RequestTargets(this GtkClipboardHandle clipboard, GtkClipboardTargetsReceivedFunc callback, IntPtr user_data)
	{
		GtkClipboardExterns.gtk_clipboard_request_targets(clipboard, callback, user_data);
		return clipboard;
	}

	public static GtkClipboardHandle RequestText(this GtkClipboardHandle clipboard, GtkClipboardTextReceivedFunc callback, IntPtr user_data)
	{
		GtkClipboardExterns.gtk_clipboard_request_text(clipboard, callback, user_data);
		return clipboard;
	}

	public static GtkClipboardHandle RequestUris(this GtkClipboardHandle clipboard, GtkClipboardURIReceivedFunc callback, IntPtr user_data)
	{
		GtkClipboardExterns.gtk_clipboard_request_uris(clipboard, callback, user_data);
		return clipboard;
	}

	public static GtkClipboardHandle SetCanStore(this GtkClipboardHandle clipboard, GtkTargetEntry[] targets, int n_targets)
	{
		GtkClipboardExterns.gtk_clipboard_set_can_store(clipboard, targets, n_targets);
		return clipboard;
	}

	public static GtkClipboardHandle SetImage(this GtkClipboardHandle clipboard, GdkPixbufHandle pixbuf)
	{
		GtkClipboardExterns.gtk_clipboard_set_image(clipboard, pixbuf);
		return clipboard;
	}

	public static GtkClipboardHandle SetText(this GtkClipboardHandle clipboard, string text, int len)
	{
		GtkClipboardExterns.gtk_clipboard_set_text(clipboard, text, len);
		return clipboard;
	}

	public static bool SetWithData(this GtkClipboardHandle clipboard, GtkTargetEntry[] targets, uint n_targets, GtkClipboardGetFunc get_func, GtkClipboardClearFunc clear_func, IntPtr user_data)
	{
		return GtkClipboardExterns.gtk_clipboard_set_with_data(clipboard, targets, n_targets, get_func, clear_func, user_data);
	}

	public static bool SetWithOwner(this GtkClipboardHandle clipboard, GtkTargetEntry[] targets, uint n_targets, GtkClipboardGetFunc get_func, GtkClipboardClearFunc clear_func, GObjectHandle owner)
	{
		return GtkClipboardExterns.gtk_clipboard_set_with_owner(clipboard, targets, n_targets, get_func, clear_func, owner);
	}

	public static GtkClipboardHandle Store(this GtkClipboardHandle clipboard)
	{
		GtkClipboardExterns.gtk_clipboard_store(clipboard);
		return clipboard;
	}

	public static GtkSelectionDataHandle WaitForContents(this GtkClipboardHandle clipboard, GdkAtom target)
	{
		return GtkClipboardExterns.gtk_clipboard_wait_for_contents(clipboard, target);
	}

	public static GdkPixbufHandle WaitForImage(this GtkClipboardHandle clipboard)
	{
		return GtkClipboardExterns.gtk_clipboard_wait_for_image(clipboard);
	}

	public static IntPtr WaitForRichText(this GtkClipboardHandle clipboard, GtkTextBufferHandle buffer, out GdkAtom format, out UIntPtr length)
	{
		return GtkClipboardExterns.gtk_clipboard_wait_for_rich_text(clipboard, buffer, out format, out length);
	}

	public static bool WaitForTargets(this GtkClipboardHandle clipboard, out GdkAtom[] targets, out int n_targets)
	{
		return GtkClipboardExterns.gtk_clipboard_wait_for_targets(clipboard, out targets, out n_targets);
	}

	public static string WaitForText(this GtkClipboardHandle clipboard)
	{
		return GtkClipboardExterns.gtk_clipboard_wait_for_text(clipboard);
	}

	public static IntPtr WaitForUris(this GtkClipboardHandle clipboard)
	{
		return GtkClipboardExterns.gtk_clipboard_wait_for_uris(clipboard);
	}

	public static bool WaitIsImageAvailable(this GtkClipboardHandle clipboard)
	{
		return GtkClipboardExterns.gtk_clipboard_wait_is_image_available(clipboard);
	}

	public static bool WaitIsRichTextAvailable(this GtkClipboardHandle clipboard, GtkTextBufferHandle buffer)
	{
		return GtkClipboardExterns.gtk_clipboard_wait_is_rich_text_available(clipboard, buffer);
	}

	public static bool WaitIsTargetAvailable(this GtkClipboardHandle clipboard, GdkAtom target)
	{
		return GtkClipboardExterns.gtk_clipboard_wait_is_target_available(clipboard, target);
	}

	public static bool WaitIsTextAvailable(this GtkClipboardHandle clipboard)
	{
		return GtkClipboardExterns.gtk_clipboard_wait_is_text_available(clipboard);
	}

	public static bool WaitIsUrisAvailable(this GtkClipboardHandle clipboard)
	{
		return GtkClipboardExterns.gtk_clipboard_wait_is_uris_available(clipboard);
	}

}

internal class GtkClipboardExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_clipboard_clear(GtkClipboardHandle clipboard);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkDisplayHandle gtk_clipboard_get_display(GtkClipboardHandle clipboard);

	[DllImport(Libraries.Gtk3)]
	internal static extern GObjectHandle gtk_clipboard_get_owner(GtkClipboardHandle clipboard);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkAtom gtk_clipboard_get_selection(GtkClipboardHandle clipboard);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_clipboard_request_contents(GtkClipboardHandle clipboard, GdkAtom target, GtkClipboardReceivedFunc callback, IntPtr user_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_clipboard_request_image(GtkClipboardHandle clipboard, GtkClipboardImageReceivedFunc callback, IntPtr user_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_clipboard_request_rich_text(GtkClipboardHandle clipboard, GtkTextBufferHandle buffer, GtkClipboardRichTextReceivedFunc callback, IntPtr user_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_clipboard_request_targets(GtkClipboardHandle clipboard, GtkClipboardTargetsReceivedFunc callback, IntPtr user_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_clipboard_request_text(GtkClipboardHandle clipboard, GtkClipboardTextReceivedFunc callback, IntPtr user_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_clipboard_request_uris(GtkClipboardHandle clipboard, GtkClipboardURIReceivedFunc callback, IntPtr user_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_clipboard_set_can_store(GtkClipboardHandle clipboard, GtkTargetEntry[] targets, int n_targets);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_clipboard_set_image(GtkClipboardHandle clipboard, GdkPixbufHandle pixbuf);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_clipboard_set_text(GtkClipboardHandle clipboard, string text, int len);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_clipboard_set_with_data(GtkClipboardHandle clipboard, GtkTargetEntry[] targets, uint n_targets, GtkClipboardGetFunc get_func, GtkClipboardClearFunc clear_func, IntPtr user_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_clipboard_set_with_owner(GtkClipboardHandle clipboard, GtkTargetEntry[] targets, uint n_targets, GtkClipboardGetFunc get_func, GtkClipboardClearFunc clear_func, GObjectHandle owner);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_clipboard_store(GtkClipboardHandle clipboard);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSelectionDataHandle gtk_clipboard_wait_for_contents(GtkClipboardHandle clipboard, GdkAtom target);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_clipboard_wait_for_image(GtkClipboardHandle clipboard);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_clipboard_wait_for_rich_text(GtkClipboardHandle clipboard, GtkTextBufferHandle buffer, out GdkAtom format, out UIntPtr length);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_clipboard_wait_for_targets(GtkClipboardHandle clipboard, out GdkAtom[] targets, out int n_targets);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_clipboard_wait_for_text(GtkClipboardHandle clipboard);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_clipboard_wait_for_uris(GtkClipboardHandle clipboard);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_clipboard_wait_is_image_available(GtkClipboardHandle clipboard);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_clipboard_wait_is_rich_text_available(GtkClipboardHandle clipboard, GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_clipboard_wait_is_target_available(GtkClipboardHandle clipboard, GdkAtom target);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_clipboard_wait_is_text_available(GtkClipboardHandle clipboard);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_clipboard_wait_is_uris_available(GtkClipboardHandle clipboard);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkClipboardHandle gtk_clipboard_get(GdkAtom selection);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkClipboardHandle gtk_clipboard_get_default(GdkDisplayHandle display);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkClipboardHandle gtk_clipboard_get_for_display(GdkDisplayHandle display, GdkAtom selection);

}
