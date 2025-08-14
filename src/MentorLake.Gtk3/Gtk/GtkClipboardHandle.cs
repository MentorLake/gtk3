namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkClipboard object represents a clipboard of data shared
/// between different processes or between different widgets in
/// the same process. Each clipboard is identified by a name encoded as a
/// #GdkAtom. (Conversion to and from strings can be done with
/// gdk_atom_intern() and gdk_atom_name().) The default clipboard
/// corresponds to the “CLIPBOARD” atom; another commonly used clipboard
/// is the “PRIMARY” clipboard, which, in X, traditionally contains
/// the currently selected text.
/// </para>
/// <para>
/// To support having a number of different formats on the clipboard
/// at the same time, the clipboard mechanism allows providing
/// callbacks instead of the actual data.  When you set the contents
/// of the clipboard, you can either supply the data directly (via
/// functions like gtk_clipboard_set_text()), or you can supply a
/// callback to be called at a later time when the data is needed (via
/// gtk_clipboard_set_with_data() or gtk_clipboard_set_with_owner().)
/// Providing a callback also avoids having to make copies of the data
/// when it is not needed.
/// </para>
/// <para>
/// gtk_clipboard_set_with_data() and gtk_clipboard_set_with_owner()
/// are quite similar; the choice between the two depends mostly on
/// which is more convenient in a particular situation.
/// The former is most useful when you want to have a blob of data
/// with callbacks to convert it into the various data types that you
/// advertise. When the @clear_func you provided is called, you
/// simply free the data blob. The latter is more useful when the
/// contents of clipboard reflect the internal state of a #GObject
/// (As an example, for the PRIMARY clipboard, when an entry widget
/// provides the clipboard’s contents the contents are simply the
/// text within the selected region.) If the contents change, the
/// entry widget can call gtk_clipboard_set_with_owner() to update
/// the timestamp for clipboard ownership, without having to worry
/// about @clear_func being called.
/// </para>
/// <para>
/// Requesting the data from the clipboard is essentially
/// asynchronous. If the contents of the clipboard are provided within
/// the same process, then a direct function call will be made to
/// retrieve the data, but if they are provided by another process,
/// then the data needs to be retrieved from the other process, which
/// may take some time. To avoid blocking the user interface, the call
/// to request the selection, gtk_clipboard_request_contents() takes a
/// callback that will be called when the contents are received (or
/// when the request fails.) If you don’t want to deal with providing
/// a separate callback, you can also use gtk_clipboard_wait_for_contents().
/// What this does is run the GLib main loop recursively waiting for
/// the contents. This can simplify the code flow, but you still have
/// to be aware that other callbacks in your program can be called
/// while this recursive mainloop is running.
/// </para>
/// <para>
/// Along with the functions to get the clipboard contents as an
/// arbitrary data chunk, there are also functions to retrieve
/// it as text, gtk_clipboard_request_text() and
/// gtk_clipboard_wait_for_text(). These functions take care of
/// determining which formats are advertised by the clipboard
/// provider, asking for the clipboard in the best available format
/// and converting the results into the UTF-8 encoding. (The standard
/// form for representing strings in GTK+.)
/// </para>
/// </summary>

public class GtkClipboardHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Returns the clipboard object for the given selection.
/// See gtk_clipboard_get_for_display() for complete details.
/// </para>
/// </summary>

/// <param name="selection">
/// a #GdkAtom which identifies the clipboard to use
/// </param>
/// <return>
/// the appropriate clipboard object. If no clipboard
///     already exists, a new one will be created. Once a clipboard
///     object has been created, it is persistent and, since it is
///     owned by GTK+, must not be freed or unreffed.
/// </return>

	public static MentorLake.Gtk.GtkClipboardHandle Get(MentorLake.Gdk.GdkAtom selection)
	{
		return GtkClipboardHandleExterns.gtk_clipboard_get(selection);
	}

/// <summary>
/// <para>
/// Returns the default clipboard object for use with cut/copy/paste menu items
/// and keyboard shortcuts.
/// </para>
/// </summary>

/// <param name="display">
/// the #GdkDisplay for which the clipboard is to be retrieved.
/// </param>
/// <return>
/// the default clipboard object.
/// </return>

	public static MentorLake.Gtk.GtkClipboardHandle GetDefault(MentorLake.Gdk.GdkDisplayHandle display)
	{
		return GtkClipboardHandleExterns.gtk_clipboard_get_default(display);
	}

/// <summary>
/// <para>
/// Returns the clipboard object for the given selection.
/// Cut/copy/paste menu items and keyboard shortcuts should use
/// the default clipboard, returned by passing %GDK_SELECTION_CLIPBOARD for @selection.
/// (%GDK_NONE is supported as a synonym for GDK_SELECTION_CLIPBOARD
/// for backwards compatibility reasons.)
/// The currently-selected object or text should be provided on the clipboard
/// identified by #GDK_SELECTION_PRIMARY. Cut/copy/paste menu items
/// conceptually copy the contents of the #GDK_SELECTION_PRIMARY clipboard
/// to the default clipboard, i.e. they copy the selection to what the
/// user sees as the clipboard.
/// </para>
/// <para>
/// (Passing #GDK_NONE is the same as using `gdk_atom_intern
/// ("CLIPBOARD", FALSE)`.
/// </para>
/// <para>
/// See the
/// [FreeDesktop Clipboard Specification](http://www.freedesktop.org/Standards/clipboards-spec)
/// for a detailed discussion of the “CLIPBOARD” vs. “PRIMARY”
/// selections under the X window system. On Win32 the
/// #GDK_SELECTION_PRIMARY clipboard is essentially ignored.)
/// </para>
/// <para>
/// It’s possible to have arbitrary named clipboards; if you do invent
/// new clipboards, you should prefix the selection name with an
/// underscore (because the ICCCM requires that nonstandard atoms are
/// underscore-prefixed), and namespace it as well. For example,
/// if your application called “Foo” has a special-purpose
/// clipboard, you might call it “_FOO_SPECIAL_CLIPBOARD”.
/// </para>
/// </summary>

/// <param name="display">
/// the #GdkDisplay for which the clipboard is to be retrieved or created.
/// </param>
/// <param name="selection">
/// a #GdkAtom which identifies the clipboard to use.
/// </param>
/// <return>
/// the appropriate clipboard object. If no
///   clipboard already exists, a new one will be created. Once a clipboard
///   object has been created, it is persistent and, since it is owned by
///   GTK+, must not be freed or unrefd.
/// </return>

	public static MentorLake.Gtk.GtkClipboardHandle GetForDisplay(MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkAtom selection)
	{
		return GtkClipboardHandleExterns.gtk_clipboard_get_for_display(display, selection);
	}

}
public static class GtkClipboardHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::owner-change signal is emitted when GTK+ receives an
/// event that indicates that the ownership of the selection
/// associated with @clipboard has changed.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// the @GdkEventOwnerChange event
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventOwnerChangeHandle Event;

	public IntPtr UserData;
}
}

public static class GtkClipboardHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::owner-change signal is emitted when GTK+ receives an
/// event that indicates that the ownership of the selection
/// associated with @clipboard has changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the @GdkEventOwnerChange event
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void owner_change([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventOwnerChangeHandle>))] MentorLake.Gdk.GdkEventOwnerChangeHandle @event, IntPtr user_data);

}


public static class GtkClipboardHandleExtensions
{
/// <summary>
/// <para>
/// Clears the contents of the clipboard. Generally this should only
/// be called between the time you call gtk_clipboard_set_with_owner()
/// or gtk_clipboard_set_with_data(),
/// and when the @clear_func you supplied is called. Otherwise, the
/// clipboard may be owned by someone else.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>

	public static T Clear<T>(this T clipboard) where T : GtkClipboardHandle
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		GtkClipboardHandleExterns.gtk_clipboard_clear(clipboard);
		return clipboard;
	}

/// <summary>
/// <para>
/// Gets the #GdkDisplay associated with @clipboard
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <return>
/// the #GdkDisplay associated with @clipboard
/// </return>

	public static MentorLake.Gdk.GdkDisplayHandle GetDisplay(this MentorLake.Gtk.GtkClipboardHandle clipboard)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_get_display(clipboard);
	}

/// <summary>
/// <para>
/// If the clipboard contents callbacks were set with
/// gtk_clipboard_set_with_owner(), and the gtk_clipboard_set_with_data() or
/// gtk_clipboard_clear() has not subsequently called, returns the owner set
/// by gtk_clipboard_set_with_owner().
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <return>
/// the owner of the clipboard, if any;
///     otherwise %NULL.
/// </return>

	public static MentorLake.GObject.GObjectHandle GetOwner(this MentorLake.Gtk.GtkClipboardHandle clipboard)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_get_owner(clipboard);
	}

/// <summary>
/// <para>
/// Gets the selection that this clipboard is for.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <return>
/// the selection
/// </return>

	public static MentorLake.Gdk.GdkAtom GetSelection(this MentorLake.Gtk.GtkClipboardHandle clipboard)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_get_selection(clipboard);
	}

/// <summary>
/// <para>
/// Requests the contents of clipboard as the given target.
/// When the results of the result are later received the supplied callback
/// will be called.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <param name="target">
/// an atom representing the form into which the clipboard
///     owner should convert the selection.
/// </param>
/// <param name="callback">
/// A function to call when the results are received
///     (or the retrieval fails). If the retrieval fails the length field of
///     @selection_data will be negative.
/// </param>
/// <param name="user_data">
/// user data to pass to @callback
/// </param>

	public static T RequestContents<T>(this T clipboard, MentorLake.Gdk.GdkAtom target, MentorLake.Gtk.GtkClipboardReceivedFunc callback, IntPtr user_data) where T : GtkClipboardHandle
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		GtkClipboardHandleExterns.gtk_clipboard_request_contents(clipboard, target, callback, user_data);
		return clipboard;
	}

/// <summary>
/// <para>
/// Requests the contents of the clipboard as image. When the image is
/// later received, it will be converted to a #GdkPixbuf, and
/// @callback will be called.
/// </para>
/// <para>
/// The @pixbuf parameter to @callback will contain the resulting
/// #GdkPixbuf if the request succeeded, or %NULL if it failed. This
/// could happen for various reasons, in particular if the clipboard
/// was empty or if the contents of the clipboard could not be
/// converted into an image.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <param name="callback">
/// a function to call when the image is received,
///     or the retrieval fails. (It will always be called one way or the other.)
/// </param>
/// <param name="user_data">
/// user data to pass to @callback.
/// </param>

	public static T RequestImage<T>(this T clipboard, MentorLake.Gtk.GtkClipboardImageReceivedFunc callback, IntPtr user_data) where T : GtkClipboardHandle
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		GtkClipboardHandleExterns.gtk_clipboard_request_image(clipboard, callback, user_data);
		return clipboard;
	}

/// <summary>
/// <para>
/// Requests the contents of the clipboard as rich text. When the rich
/// text is later received, @callback will be called.
/// </para>
/// <para>
/// The @text parameter to @callback will contain the resulting rich
/// text if the request succeeded, or %NULL if it failed. The @length
/// parameter will contain @text’s length. This function can fail for
/// various reasons, in particular if the clipboard was empty or if the
/// contents of the clipboard could not be converted into rich text form.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="callback">
/// a function to call when the text is received,
///     or the retrieval fails. (It will always be called one way or the other.)
/// </param>
/// <param name="user_data">
/// user data to pass to @callback.
/// </param>

	public static T RequestRichText<T>(this T clipboard, MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gtk.GtkClipboardRichTextReceivedFunc callback, IntPtr user_data) where T : GtkClipboardHandle
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		GtkClipboardHandleExterns.gtk_clipboard_request_rich_text(clipboard, buffer, callback, user_data);
		return clipboard;
	}

/// <summary>
/// <para>
/// Requests the contents of the clipboard as list of supported targets.
/// When the list is later received, @callback will be called.
/// </para>
/// <para>
/// The @targets parameter to @callback will contain the resulting targets if
/// the request succeeded, or %NULL if it failed.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <param name="callback">
/// a function to call when the targets are
///     received, or the retrieval fails. (It will always be called
///     one way or the other.)
/// </param>
/// <param name="user_data">
/// user data to pass to @callback.
/// </param>

	public static T RequestTargets<T>(this T clipboard, MentorLake.Gtk.GtkClipboardTargetsReceivedFunc callback, IntPtr user_data) where T : GtkClipboardHandle
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		GtkClipboardHandleExterns.gtk_clipboard_request_targets(clipboard, callback, user_data);
		return clipboard;
	}

/// <summary>
/// <para>
/// Requests the contents of the clipboard as text. When the text is
/// later received, it will be converted to UTF-8 if necessary, and
/// @callback will be called.
/// </para>
/// <para>
/// The @text parameter to @callback will contain the resulting text if
/// the request succeeded, or %NULL if it failed. This could happen for
/// various reasons, in particular if the clipboard was empty or if the
/// contents of the clipboard could not be converted into text form.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <param name="callback">
/// a function to call when the text is received,
///     or the retrieval fails. (It will always be called one way or the other.)
/// </param>
/// <param name="user_data">
/// user data to pass to @callback.
/// </param>

	public static T RequestText<T>(this T clipboard, MentorLake.Gtk.GtkClipboardTextReceivedFunc callback, IntPtr user_data) where T : GtkClipboardHandle
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		GtkClipboardHandleExterns.gtk_clipboard_request_text(clipboard, callback, user_data);
		return clipboard;
	}

/// <summary>
/// <para>
/// Requests the contents of the clipboard as URIs. When the URIs are
/// later received @callback will be called.
/// </para>
/// <para>
/// The @uris parameter to @callback will contain the resulting array of
/// URIs if the request succeeded, or %NULL if it failed. This could happen
/// for various reasons, in particular if the clipboard was empty or if the
/// contents of the clipboard could not be converted into URI form.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <param name="callback">
/// a function to call when the URIs are received,
///     or the retrieval fails. (It will always be called one way or the other.)
/// </param>
/// <param name="user_data">
/// user data to pass to @callback.
/// </param>

	public static T RequestUris<T>(this T clipboard, MentorLake.Gtk.GtkClipboardURIReceivedFunc callback, IntPtr user_data) where T : GtkClipboardHandle
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		GtkClipboardHandleExterns.gtk_clipboard_request_uris(clipboard, callback, user_data);
		return clipboard;
	}

/// <summary>
/// <para>
/// Hints that the clipboard data should be stored somewhere when the
/// application exits or when gtk_clipboard_store () is called.
/// </para>
/// <para>
/// This value is reset when the clipboard owner changes.
/// Where the clipboard data is stored is platform dependent,
/// see gdk_display_store_clipboard () for more information.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <param name="targets">
/// array containing
///           information about which forms should be stored or %NULL
///           to indicate that all forms should be stored.
/// </param>
/// <param name="n_targets">
/// number of elements in @targets
/// </param>

	public static T SetCanStore<T>(this T clipboard, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets) where T : GtkClipboardHandle
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		GtkClipboardHandleExterns.gtk_clipboard_set_can_store(clipboard, targets, n_targets);
		return clipboard;
	}

/// <summary>
/// <para>
/// Sets the contents of the clipboard to the given #GdkPixbuf.
/// GTK+ will take responsibility for responding for requests
/// for the image, and for converting the image into the
/// requested format.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard object
/// </param>
/// <param name="pixbuf">
/// a #GdkPixbuf
/// </param>

	public static T SetImage<T>(this T clipboard, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf) where T : GtkClipboardHandle
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		GtkClipboardHandleExterns.gtk_clipboard_set_image(clipboard, pixbuf);
		return clipboard;
	}

/// <summary>
/// <para>
/// Sets the contents of the clipboard to the given UTF-8 string. GTK+ will
/// make a copy of the text and take responsibility for responding
/// for requests for the text, and for converting the text into
/// the requested format.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard object
/// </param>
/// <param name="text">
/// a UTF-8 string.
/// </param>
/// <param name="len">
/// length of @text, in bytes, or -1, in which case
///             the length will be determined with strlen().
/// </param>

	public static T SetText<T>(this T clipboard, string text, int len) where T : GtkClipboardHandle
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		GtkClipboardHandleExterns.gtk_clipboard_set_text(clipboard, text, len);
		return clipboard;
	}

/// <summary>
/// <para>
/// Virtually sets the contents of the specified clipboard by providing
/// a list of supported formats for the clipboard data and a function
/// to call to get the actual data when it is requested.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <param name="targets">
/// array containing information
///     about the available forms for the clipboard data
/// </param>
/// <param name="n_targets">
/// number of elements in @targets
/// </param>
/// <param name="get_func">
/// function to call to get the actual clipboard data
/// </param>
/// <param name="clear_func">
/// when the clipboard contents are set again,
///     this function will be called, and @get_func will not be subsequently
///     called.
/// </param>
/// <param name="user_data">
/// user data to pass to @get_func and @clear_func.
/// </param>
/// <return>
/// %TRUE if setting the clipboard data succeeded.
///    If setting the clipboard data failed the provided callback
///    functions will be ignored.
/// </return>

	public static bool SetWithData(this MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gtk.GtkTargetEntry[] targets, uint n_targets, MentorLake.Gtk.GtkClipboardGetFunc get_func, MentorLake.Gtk.GtkClipboardClearFunc clear_func, IntPtr user_data)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_set_with_data(clipboard, targets, n_targets, get_func, clear_func, user_data);
	}

/// <summary>
/// <para>
/// Virtually sets the contents of the specified clipboard by providing
/// a list of supported formats for the clipboard data and a function
/// to call to get the actual data when it is requested.
/// </para>
/// <para>
/// The difference between this function and gtk_clipboard_set_with_data()
/// is that instead of an generic @user_data pointer, a #GObject is passed
/// in.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <param name="targets">
/// array containing information
///     about the available forms for the clipboard data
/// </param>
/// <param name="n_targets">
/// number of elements in @targets
/// </param>
/// <param name="get_func">
/// function to call to get the actual clipboard data
/// </param>
/// <param name="clear_func">
/// when the clipboard contents are set again,
///     this function will be called, and @get_func will not be subsequently
///     called
/// </param>
/// <param name="owner">
/// an object that “owns” the data. This object will be passed
///     to the callbacks when called
/// </param>
/// <return>
/// %TRUE if setting the clipboard data succeeded.
///     If setting the clipboard data failed the provided callback
///     functions will be ignored.
/// </return>

	public static bool SetWithOwner(this MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gtk.GtkTargetEntry[] targets, uint n_targets, MentorLake.Gtk.GtkClipboardGetFunc get_func, MentorLake.Gtk.GtkClipboardClearFunc clear_func, MentorLake.GObject.GObjectHandle owner)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_set_with_owner(clipboard, targets, n_targets, get_func, clear_func, owner);
	}

/// <summary>
/// <para>
/// Stores the current clipboard data somewhere so that it will stay
/// around after the application has quit.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>

	public static T Store<T>(this T clipboard) where T : GtkClipboardHandle
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		GtkClipboardHandleExterns.gtk_clipboard_store(clipboard);
		return clipboard;
	}

/// <summary>
/// <para>
/// Requests the contents of the clipboard using the given target.
/// This function waits for the data to be received using the main
/// loop, so events, timeouts, etc, may be dispatched during the wait.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <param name="target">
/// an atom representing the form into which the clipboard
///          owner should convert the selection.
/// </param>
/// <return>
/// a newly-allocated #GtkSelectionData object or %NULL
///               if retrieving the given target failed. If non-%NULL,
///               this value must be freed with gtk_selection_data_free()
///               when you are finished with it.
/// </return>

	public static MentorLake.Gtk.GtkSelectionDataHandle WaitForContents(this MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gdk.GdkAtom target)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_wait_for_contents(clipboard, target);
	}

/// <summary>
/// <para>
/// Requests the contents of the clipboard as image and converts
/// the result to a #GdkPixbuf. This function waits for
/// the data to be received using the main loop, so events,
/// timeouts, etc, may be dispatched during the wait.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <return>
/// a newly-allocated #GdkPixbuf
///     object which must be disposed with g_object_unref(), or
///     %NULL if retrieving the selection data failed. (This could
///     happen for various reasons, in particular if the clipboard
///     was empty or if the contents of the clipboard could not be
///     converted into an image.)
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle WaitForImage(this MentorLake.Gtk.GtkClipboardHandle clipboard)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_wait_for_image(clipboard);
	}

/// <summary>
/// <para>
/// Requests the contents of the clipboard as rich text.  This function
/// waits for the data to be received using the main loop, so events,
/// timeouts, etc, may be dispatched during the wait.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="format">
/// return location for the format of the returned data
/// </param>
/// <param name="length">
/// return location for the length of the returned data
/// </param>
/// <return>
/// a
///               newly-allocated binary block of data which must be
///               freed with g_free(), or %NULL if retrieving the
///               selection data failed. (This could happen for various
///               reasons, in particular if the clipboard was empty or
///               if the contents of the clipboard could not be
///               converted into text form.)
/// </return>

	public static byte[] WaitForRichText(this MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gtk.GtkTextBufferHandle buffer, out MentorLake.Gdk.GdkAtom format, out UIntPtr length)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_wait_for_rich_text(clipboard, buffer, out format, out length);
	}

/// <summary>
/// <para>
/// Returns a list of targets that are present on the clipboard, or %NULL
/// if there aren’t any targets available. The returned list must be
/// freed with g_free().
/// This function waits for the data to be received using the main
/// loop, so events, timeouts, etc, may be dispatched during the wait.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <param name="targets">
/// location
///           to store an array of targets. The result stored here must
///           be freed with g_free().
/// </param>
/// <param name="n_targets">
/// location to store number of items in @targets.
/// </param>
/// <return>
/// %TRUE if any targets are present on the clipboard,
///               otherwise %FALSE.
/// </return>

	public static bool WaitForTargets(this MentorLake.Gtk.GtkClipboardHandle clipboard, out MentorLake.Gdk.GdkAtom[] targets, out int n_targets)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_wait_for_targets(clipboard, out targets, out n_targets);
	}

/// <summary>
/// <para>
/// Requests the contents of the clipboard as text and converts
/// the result to UTF-8 if necessary. This function waits for
/// the data to be received using the main loop, so events,
/// timeouts, etc, may be dispatched during the wait.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <return>
/// a newly-allocated UTF-8 string which must
///               be freed with g_free(), or %NULL if retrieving
///               the selection data failed. (This could happen
///               for various reasons, in particular if the
///               clipboard was empty or if the contents of the
///               clipboard could not be converted into text form.)
/// </return>

	public static string WaitForText(this MentorLake.Gtk.GtkClipboardHandle clipboard)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_wait_for_text(clipboard);
	}

/// <summary>
/// <para>
/// Requests the contents of the clipboard as URIs. This function waits
/// for the data to be received using the main loop, so events,
/// timeouts, etc, may be dispatched during the wait.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <return>
/// 
///     a newly-allocated %NULL-terminated array of strings which must
///     be freed with g_strfreev(), or %NULL if retrieving the
///     selection data failed. (This could happen for various reasons,
///     in particular if the clipboard was empty or if the contents of
///     the clipboard could not be converted into URI form.)
/// </return>

	public static string[] WaitForUris(this MentorLake.Gtk.GtkClipboardHandle clipboard)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_wait_for_uris(clipboard);
	}

/// <summary>
/// <para>
/// Test to see if there is an image available to be pasted
/// This is done by requesting the TARGETS atom and checking
/// if it contains any of the supported image targets. This function
/// waits for the data to be received using the main loop, so events,
/// timeouts, etc, may be dispatched during the wait.
/// </para>
/// <para>
/// This function is a little faster than calling
/// gtk_clipboard_wait_for_image() since it doesn’t need to retrieve
/// the actual image data.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <return>
/// %TRUE is there is an image available, %FALSE otherwise.
/// </return>

	public static bool WaitIsImageAvailable(this MentorLake.Gtk.GtkClipboardHandle clipboard)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_wait_is_image_available(clipboard);
	}

/// <summary>
/// <para>
/// Test to see if there is rich text available to be pasted
/// This is done by requesting the TARGETS atom and checking
/// if it contains any of the supported rich text targets. This function
/// waits for the data to be received using the main loop, so events,
/// timeouts, etc, may be dispatched during the wait.
/// </para>
/// <para>
/// This function is a little faster than calling
/// gtk_clipboard_wait_for_rich_text() since it doesn’t need to retrieve
/// the actual text.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <return>
/// %TRUE is there is rich text available, %FALSE otherwise.
/// </return>

	public static bool WaitIsRichTextAvailable(this MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_wait_is_rich_text_available(clipboard, buffer);
	}

/// <summary>
/// <para>
/// Checks if a clipboard supports pasting data of a given type. This
/// function can be used to determine if a “Paste” menu item should be
/// insensitive or not.
/// </para>
/// <para>
/// If you want to see if there’s text available on the clipboard, use
/// gtk_clipboard_wait_is_text_available () instead.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <param name="target">
/// A #GdkAtom indicating which target to look for.
/// </param>
/// <return>
/// %TRUE if the target is available, %FALSE otherwise.
/// </return>

	public static bool WaitIsTargetAvailable(this MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gdk.GdkAtom target)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_wait_is_target_available(clipboard, target);
	}

/// <summary>
/// <para>
/// Test to see if there is text available to be pasted
/// This is done by requesting the TARGETS atom and checking
/// if it contains any of the supported text targets. This function
/// waits for the data to be received using the main loop, so events,
/// timeouts, etc, may be dispatched during the wait.
/// </para>
/// <para>
/// This function is a little faster than calling
/// gtk_clipboard_wait_for_text() since it doesn’t need to retrieve
/// the actual text.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <return>
/// %TRUE is there is text available, %FALSE otherwise.
/// </return>

	public static bool WaitIsTextAvailable(this MentorLake.Gtk.GtkClipboardHandle clipboard)
	{
		if (clipboard.IsInvalid) throw new Exception("Invalid handle (GtkClipboardHandle)");
		return GtkClipboardHandleExterns.gtk_clipboard_wait_is_text_available(clipboard);
	}

/// <summary>
/// <para>
/// Test to see if there is a list of URIs available to be pasted
/// This is done by requesting the TARGETS atom and checking
/// if it contains the URI targets. This function
/// waits for the data to be received using the main loop, so events,
/// timeouts, etc, may be dispatched during the wait.
/// </para>
/// <para>
/// This function is a little faster than calling
/// gtk_clipboard_wait_for_uris() since it doesn’t need to retrieve
/// the actual URI data.
/// </para>
/// </summary>

/// <param name="clipboard">
/// a #GtkClipboard
/// </param>
/// <return>
/// %TRUE is there is an URI list available, %FALSE otherwise.
/// </return>

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
	internal static extern bool gtk_clipboard_wait_for_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out MentorLake.Gdk.GdkAtom[] targets, out int n_targets);

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
