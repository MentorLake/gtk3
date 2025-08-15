namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Dialog boxes are a convenient way to prompt the user for a small amount
/// of input, e.g. to display a message, ask a question, or anything else
/// that does not require extensive effort on the user’s part.
/// </para>
/// <para>
/// GTK+ treats a dialog as a window split vertically. The top section is a
/// #GtkVBox, and is where widgets such as a #GtkLabel or a #GtkEntry should
/// be packed. The bottom area is known as the
/// “action area”. This is generally used for
/// packing buttons into the dialog which may perform functions such as
/// cancel, ok, or apply.
/// </para>
/// <para>
/// #GtkDialog boxes are created with a call to gtk_dialog_new() or
/// gtk_dialog_new_with_buttons(). gtk_dialog_new_with_buttons() is
/// recommended; it allows you to set the dialog title, some convenient
/// flags, and add simple buttons.
/// </para>
/// <para>
/// If “dialog” is a newly created dialog, the two primary areas of the
/// window can be accessed through gtk_dialog_get_content_area() and
/// gtk_dialog_get_action_area(), as can be seen from the example below.
/// </para>
/// <para>
/// A “modal” dialog (that is, one which freezes the rest of the application
/// from user input), can be created by calling gtk_window_set_modal() on the
/// dialog. Use the GTK_WINDOW() macro to cast the widget returned from
/// gtk_dialog_new() into a #GtkWindow. When using gtk_dialog_new_with_buttons()
/// you can also pass the #GTK_DIALOG_MODAL flag to make a dialog modal.
/// </para>
/// <para>
/// If you add buttons to #GtkDialog using gtk_dialog_new_with_buttons(),
/// gtk_dialog_add_button(), gtk_dialog_add_buttons(), or
/// gtk_dialog_add_action_widget(), clicking the button will emit a signal
/// called #GtkDialog::response with a response ID that you specified. GTK+
/// will never assign a meaning to positive response IDs; these are entirely
/// user-defined. But for convenience, you can use the response IDs in the
/// #GtkResponseType enumeration (these all have values less than zero). If
/// a dialog receives a delete event, the #GtkDialog::response signal will
/// be emitted with a response ID of #GTK_RESPONSE_DELETE_EVENT.
/// </para>
/// <para>
/// If you want to block waiting for a dialog to return before returning
/// control flow to your code, you can call gtk_dialog_run(). This function
/// enters a recursive main loop and waits for the user to respond to the
/// dialog, returning the response ID corresponding to the button the user
/// clicked.
/// </para>
/// <para>
/// For the simple dialog in the following example, in reality you’d probably
/// use #GtkMessageDialog to save yourself some effort. But you’d need to
/// create the dialog contents manually if you had more than a simple message
/// in the dialog.
/// </para>
/// <para>
/// An example for simple GtkDialog usage:
/// <code>
/// // Function to open a dialog box with a message
/// // Function to open a dialog box with a message
/// void
/// quick_message (GtkWindow *parent, gchar *message)
/// {
///  GtkWidget *dialog, *label, *content_area;
///  GtkDialogFlags flags;
/// 
///  // Create the widgets
///  flags = GTK_DIALOG_DESTROY_WITH_PARENT;
///  dialog = gtk_dialog_new_with_buttons (&quot;Message&quot;,
///                                        parent,
///                                        flags,
///                                        _(&quot;_OK&quot;),
///                                        GTK_RESPONSE_NONE,
///                                        NULL);
///  content_area = gtk_dialog_get_content_area (GTK_DIALOG (dialog));
///  label = gtk_label_new (message);
/// 
///  // Ensure that the dialog box is destroyed when the user responds
/// 
///  g_signal_connect_swapped (dialog,
///                            &quot;response&quot;,
///                            G_CALLBACK (gtk_widget_destroy),
///                            dialog);
/// 
///  // Add the label, and show everything we’ve added
/// 
///  gtk_container_add (GTK_CONTAINER (content_area), label);
///  gtk_widget_show_all (dialog);
/// }
/// </code>
/// # GtkDialog as GtkBuildable
/// </para>
/// <para>
/// The GtkDialog implementation of the #GtkBuildable interface exposes the
/// @vbox and @action_area as internal children with the names “vbox” and
/// “action_area”.
/// </para>
/// <para>
/// GtkDialog supports a custom `&amp;lt;action-widgets&amp;gt;` element, which can contain
/// multiple `&amp;lt;action-widget&amp;gt;` elements. The “response” attribute specifies a
/// numeric response, and the content of the element is the id of widget
/// (which should be a child of the dialogs @action_area). To mark a response
/// as default, set the “default“ attribute of the `&amp;lt;action-widget&amp;gt;` element
/// to true.
/// </para>
/// <para>
/// GtkDialog supports adding action widgets by specifying “action“ as
/// the “type“ attribute of a `&amp;lt;child&amp;gt;` element. The widget will be added
/// either to the action area or the headerbar of the dialog, depending
/// on the “use-header-bar“ property. The response id has to be associated
/// with the action widget using the `&amp;lt;action-widgets&amp;gt;` element.
/// </para>
/// <para>
/// An example of a #GtkDialog UI definition fragment:
/// </para>
/// <code>
/// &amp;lt;object class=&quot;GtkDialog&quot; id=&quot;dialog1&quot;&amp;gt;
/// &amp;lt;object class=&quot;GtkDialog&quot; id=&quot;dialog1&quot;&amp;gt;
///   &amp;lt;child type=&quot;action&quot;&amp;gt;
///     &amp;lt;object class=&quot;GtkButton&quot; id=&quot;button_cancel&quot;/&amp;gt;
///   &amp;lt;/child&amp;gt;
///   &amp;lt;child type=&quot;action&quot;&amp;gt;
///     &amp;lt;object class=&quot;GtkButton&quot; id=&quot;button_ok&quot;&amp;gt;
///       &amp;lt;property name=&quot;can-default&quot;&amp;gt;True&amp;lt;/property&amp;gt;
///     &amp;lt;/object&amp;gt;
///   &amp;lt;/child&amp;gt;
///   &amp;lt;action-widgets&amp;gt;
///     &amp;lt;action-widget response=&quot;cancel&quot;&amp;gt;button_cancel&amp;lt;/action-widget&amp;gt;
///     &amp;lt;action-widget response=&quot;ok&quot; default=&quot;true&quot;&amp;gt;button_ok&amp;lt;/action-widget&amp;gt;
///   &amp;lt;/action-widgets&amp;gt;
/// &amp;lt;/object&amp;gt;
/// </code>
/// </summary>

public class GtkDialogHandle : GtkWindowHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new dialog box.
/// </para>
/// <para>
/// Widgets should not be packed into this #GtkWindow
/// directly, but into the @vbox and @action_area, as described above.
/// </para>
/// </summary>

/// <return>
/// the new dialog as a #GtkWidget
/// </return>

	public static MentorLake.Gtk.GtkDialogHandle New()
	{
		return GtkDialogHandleExterns.gtk_dialog_new();
	}

/// <summary>
/// <para>
/// Creates a new #GtkDialog with title @title (or %NULL for the default
/// title; see gtk_window_set_title()) and transient parent @parent (or
/// %NULL for none; see gtk_window_set_transient_for()). The @flags
/// argument can be used to make the dialog modal (#GTK_DIALOG_MODAL)
/// and/or to have it destroyed along with its transient parent
/// (#GTK_DIALOG_DESTROY_WITH_PARENT). After @flags, button
/// text/response ID pairs should be listed, with a %NULL pointer ending
/// the list. Button text can be arbitrary text. A response ID can be
/// any positive number, or one of the values in the #GtkResponseType
/// enumeration. If the user clicks one of these dialog buttons,
/// #GtkDialog will emit the #GtkDialog::response signal with the corresponding
/// response ID. If a #GtkDialog receives the #GtkWidget::delete-event signal,
/// it will emit ::response with a response ID of #GTK_RESPONSE_DELETE_EVENT.
/// However, destroying a dialog does not emit the ::response signal;
/// so be careful relying on ::response when using the
/// #GTK_DIALOG_DESTROY_WITH_PARENT flag. Buttons are from left to right,
/// so the first button in the list will be the leftmost button in the dialog.
/// </para>
/// <para>
/// Here’s a simple example:
/// <code>
///  GtkWidget *main_app_window; // Window the dialog should show up on
///  GtkWidget *main_app_window; // Window the dialog should show up on
///  GtkWidget *dialog;
///  GtkDialogFlags flags = GTK_DIALOG_MODAL | GTK_DIALOG_DESTROY_WITH_PARENT;
///  dialog = gtk_dialog_new_with_buttons (&quot;My dialog&quot;,
///                                        main_app_window,
///                                        flags,
///                                        _(&quot;_OK&quot;),
///                                        GTK_RESPONSE_ACCEPT,
///                                        _(&quot;_Cancel&quot;),
///                                        GTK_RESPONSE_REJECT,
///                                        NULL);
/// </code>
/// </para>
/// </summary>

/// <param name="title">
/// Title of the dialog, or %NULL
/// </param>
/// <param name="parent">
/// Transient parent of the dialog, or %NULL
/// </param>
/// <param name="flags">
/// from #GtkDialogFlags
/// </param>
/// <param name="first_button_text">
/// text to go in first button, or %NULL
/// </param>
/// <param name="@__arglist">
/// response ID for first button, then additional buttons, ending with %NULL
/// </param>
/// <return>
/// a new #GtkDialog
/// </return>

	public static MentorLake.Gtk.GtkDialogHandle NewWithButtons(string title, MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkDialogFlags flags, string first_button_text, IntPtr @__arglist)
	{
		return GtkDialogHandleExterns.gtk_dialog_new_with_buttons(title, parent, flags, first_button_text, @__arglist);
	}

}
public static class GtkDialogHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::close signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user uses a keybinding to close
/// the dialog.
/// </para>
/// <para>
/// The default binding for this signal is the Escape key.
/// </para>
/// </summary>

	public static IObservable<GtkDialogHandleSignalStructs.CloseSignal> Signal_Close(this GtkDialogHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkDialogHandleSignalStructs.CloseSignal> obs) =>
		{
			GtkDialogHandleSignalDelegates.close handler = ( MentorLake.Gtk.GtkDialogHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkDialogHandleSignalStructs.CloseSignal()
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
/// <summary>
/// <para>
/// Emitted when an action widget is clicked, the dialog receives a
/// delete event, or the application programmer calls gtk_dialog_response().
/// On a delete event, the response ID is #GTK_RESPONSE_DELETE_EVENT.
/// Otherwise, it depends on which action widget was clicked.
/// </para>
/// </summary>

	public static IObservable<GtkDialogHandleSignalStructs.ResponseSignal> Signal_Response(this GtkDialogHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkDialogHandleSignalStructs.ResponseSignal> obs) =>
		{
			GtkDialogHandleSignalDelegates.response handler = ( MentorLake.Gtk.GtkDialogHandle self,  MentorLake.Gtk.GtkResponseType response_id,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkDialogHandleSignalStructs.ResponseSignal()
				{
					Self = self, ResponseId = response_id, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "response", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkDialogHandleSignalStructs
{

public class CloseSignal
{

	public MentorLake.Gtk.GtkDialogHandle Self;

	public IntPtr UserData;
}

public class ResponseSignal
{

	public MentorLake.Gtk.GtkDialogHandle Self;
/// <summary>
/// <para>
/// the response ID
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkResponseType ResponseId;

	public IntPtr UserData;
}
}

public static class GtkDialogHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::close signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user uses a keybinding to close
/// the dialog.
/// </para>
/// <para>
/// The default binding for this signal is the Escape key.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when an action widget is clicked, the dialog receives a
/// delete event, or the application programmer calls gtk_dialog_response().
/// On a delete event, the response ID is #GTK_RESPONSE_DELETE_EVENT.
/// Otherwise, it depends on which action widget was clicked.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="response_id">
/// the response ID
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle self, MentorLake.Gtk.GtkResponseType response_id, IntPtr user_data);

}


public static class GtkDialogHandleExtensions
{
/// <summary>
/// <para>
/// Adds an activatable widget to the action area of a #GtkDialog,
/// connecting a signal handler that will emit the #GtkDialog::response
/// signal on the dialog when the widget is activated. The widget is
/// appended to the end of the dialog’s action area. If you want to add a
/// non-activatable widget, simply pack it into the @action_area field
/// of the #GtkDialog struct.
/// </para>
/// </summary>

/// <param name="dialog">
/// a #GtkDialog
/// </param>
/// <param name="child">
/// an activatable widget
/// </param>
/// <param name="response_id">
/// response ID for @child
/// </param>

	public static T AddActionWidget<T>(this T dialog, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkResponseType response_id) where T : GtkDialogHandle
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		GtkDialogHandleExterns.gtk_dialog_add_action_widget(dialog, child, response_id);
		return dialog;
	}

/// <summary>
/// <para>
/// Adds a button with the given text and sets things up so that
/// clicking the button will emit the #GtkDialog::response signal with
/// the given @response_id. The button is appended to the end of the
/// dialog’s action area. The button widget is returned, but usually
/// you don’t need it.
/// </para>
/// </summary>

/// <param name="dialog">
/// a #GtkDialog
/// </param>
/// <param name="button_text">
/// text of button
/// </param>
/// <param name="response_id">
/// response ID for the button
/// </param>
/// <return>
/// the #GtkButton widget that was added
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle AddButton(this MentorLake.Gtk.GtkDialogHandle dialog, string button_text, MentorLake.Gtk.GtkResponseType response_id)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		return GtkDialogHandleExterns.gtk_dialog_add_button(dialog, button_text, response_id);
	}

/// <summary>
/// <para>
/// Adds more buttons, same as calling gtk_dialog_add_button()
/// repeatedly.  The variable argument list should be %NULL-terminated
/// as with gtk_dialog_new_with_buttons(). Each button must have both
/// text and response ID.
/// </para>
/// </summary>

/// <param name="dialog">
/// a #GtkDialog
/// </param>
/// <param name="first_button_text">
/// button text
/// </param>
/// <param name="@__arglist">
/// response ID for first button, then more text-response_id pairs
/// </param>

	public static T AddButtons<T>(this T dialog, string first_button_text, IntPtr @__arglist) where T : GtkDialogHandle
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		GtkDialogHandleExterns.gtk_dialog_add_buttons(dialog, first_button_text, @__arglist);
		return dialog;
	}

/// <summary>
/// <para>
/// Returns the action area of @dialog.
/// </para>
/// </summary>

/// <param name="dialog">
/// a #GtkDialog
/// </param>
/// <return>
/// the action area
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetActionArea(this MentorLake.Gtk.GtkDialogHandle dialog)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		return GtkDialogHandleExterns.gtk_dialog_get_action_area(dialog);
	}

/// <summary>
/// <para>
/// Returns the content area of @dialog.
/// </para>
/// </summary>

/// <param name="dialog">
/// a #GtkDialog
/// </param>
/// <return>
/// the content area #GtkBox.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetContentArea(this MentorLake.Gtk.GtkDialogHandle dialog)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		return GtkDialogHandleExterns.gtk_dialog_get_content_area(dialog);
	}

/// <summary>
/// <para>
/// Returns the header bar of @dialog. Note that the
/// headerbar is only used by the dialog if the
/// #GtkDialog:use-header-bar property is %TRUE.
/// </para>
/// </summary>

/// <param name="dialog">
/// a #GtkDialog
/// </param>
/// <return>
/// the header bar
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetHeaderBar(this MentorLake.Gtk.GtkDialogHandle dialog)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		return GtkDialogHandleExterns.gtk_dialog_get_header_bar(dialog);
	}

/// <summary>
/// <para>
/// Gets the response id of a widget in the action area
/// of a dialog.
/// </para>
/// </summary>

/// <param name="dialog">
/// a #GtkDialog
/// </param>
/// <param name="widget">
/// a widget in the action area of @dialog
/// </param>
/// <return>
/// the response id of @widget, or %GTK_RESPONSE_NONE
///  if @widget doesn’t have a response id set.
/// </return>

	public static int GetResponseForWidget(this MentorLake.Gtk.GtkDialogHandle dialog, MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		return GtkDialogHandleExterns.gtk_dialog_get_response_for_widget(dialog, widget);
	}

/// <summary>
/// <para>
/// Gets the widget button that uses the given response ID in the action area
/// of a dialog.
/// </para>
/// </summary>

/// <param name="dialog">
/// a #GtkDialog
/// </param>
/// <param name="response_id">
/// the response ID used by the @dialog widget
/// </param>
/// <return>
/// the @widget button that uses the given
///     @response_id, or %NULL.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetWidgetForResponse(this MentorLake.Gtk.GtkDialogHandle dialog, MentorLake.Gtk.GtkResponseType response_id)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		return GtkDialogHandleExterns.gtk_dialog_get_widget_for_response(dialog, response_id);
	}

/// <summary>
/// <para>
/// Emits the #GtkDialog::response signal with the given response ID.
/// Used to indicate that the user has responded to the dialog in some way;
/// typically either you or gtk_dialog_run() will be monitoring the
/// ::response signal and take appropriate action.
/// </para>
/// </summary>

/// <param name="dialog">
/// a #GtkDialog
/// </param>
/// <param name="response_id">
/// response ID
/// </param>

	public static T Response<T>(this T dialog, MentorLake.Gtk.GtkResponseType response_id) where T : GtkDialogHandle
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		GtkDialogHandleExterns.gtk_dialog_response(dialog, response_id);
		return dialog;
	}

/// <summary>
/// <para>
/// Blocks in a recursive main loop until the @dialog either emits the
/// #GtkDialog::response signal, or is destroyed. If the dialog is
/// destroyed during the call to gtk_dialog_run(), gtk_dialog_run() returns
/// #GTK_RESPONSE_NONE. Otherwise, it returns the response ID from the
/// ::response signal emission.
/// </para>
/// <para>
/// Before entering the recursive main loop, gtk_dialog_run() calls
/// gtk_widget_show() on the dialog for you. Note that you still
/// need to show any children of the dialog yourself.
/// </para>
/// <para>
/// During gtk_dialog_run(), the default behavior of #GtkWidget::delete-event
/// is disabled; if the dialog receives ::delete_event, it will not be
/// destroyed as windows usually are, and gtk_dialog_run() will return
/// #GTK_RESPONSE_DELETE_EVENT. Also, during gtk_dialog_run() the dialog
/// will be modal. You can force gtk_dialog_run() to return at any time by
/// calling gtk_dialog_response() to emit the ::response signal. Destroying
/// the dialog during gtk_dialog_run() is a very bad idea, because your
/// post-run code won’t know whether the dialog was destroyed or not.
/// </para>
/// <para>
/// After gtk_dialog_run() returns, you are responsible for hiding or
/// destroying the dialog if you wish to do so.
/// </para>
/// <para>
/// Typical usage of this function might be:
/// <code>
///   GtkWidget *dialog = gtk_dialog_new ();
///   GtkWidget *dialog = gtk_dialog_new ();
///   // Set up dialog...
/// 
///   int result = gtk_dialog_run (GTK_DIALOG (dialog));
///   switch (result)
///     {
///       case GTK_RESPONSE_ACCEPT:
///          // do_application_specific_something ();
///          break;
///       default:
///          // do_nothing_since_dialog_was_cancelled ();
///          break;
///     }
///   gtk_widget_destroy (dialog);
/// </code>
/// Note that even though the recursive main loop gives the effect of a
/// modal dialog (it prevents the user from interacting with other
/// windows in the same window group while the dialog is run), callbacks
/// such as timeouts, IO channel watches, DND drops, etc, will
/// be triggered during a gtk_dialog_run() call.
/// </para>
/// </summary>

/// <param name="dialog">
/// a #GtkDialog
/// </param>
/// <return>
/// response ID
/// </return>

	public static int Run(this MentorLake.Gtk.GtkDialogHandle dialog)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		return GtkDialogHandleExterns.gtk_dialog_run(dialog);
	}

/// <summary>
/// <para>
/// Sets an alternative button order. If the
/// #GtkSettings:gtk-alternative-button-order setting is set to %TRUE,
/// the dialog buttons are reordered according to the order of the
/// response ids passed to this function.
/// </para>
/// <para>
/// By default, GTK+ dialogs use the button order advocated by the
/// [GNOME Human Interface Guidelines](http://library.gnome.org/devel/hig-book/stable/)
/// with the affirmative button at the far
/// right, and the cancel button left of it. But the builtin GTK+ dialogs
/// and #GtkMessageDialogs do provide an alternative button order,
/// which is more suitable on some platforms, e.g. Windows.
/// </para>
/// <para>
/// Use this function after adding all the buttons to your dialog, as the
/// following example shows:
/// </para>
/// <code>
/// cancel_button = gtk_dialog_add_button (GTK_DIALOG (dialog),
/// cancel_button = gtk_dialog_add_button (GTK_DIALOG (dialog),
///                                        _(&quot;_Cancel&quot;),
///                                        GTK_RESPONSE_CANCEL);
/// 
/// ok_button = gtk_dialog_add_button (GTK_DIALOG (dialog),
///                                    _(&quot;_OK&quot;),
///                                    GTK_RESPONSE_OK);
/// 
/// gtk_widget_grab_default (ok_button);
/// 
/// help_button = gtk_dialog_add_button (GTK_DIALOG (dialog),
///                                      _(&quot;_Help&quot;),
///                                      GTK_RESPONSE_HELP);
/// 
/// gtk_dialog_set_alternative_button_order (GTK_DIALOG (dialog),
///                                          GTK_RESPONSE_OK,
///                                          GTK_RESPONSE_CANCEL,
///                                          GTK_RESPONSE_HELP,
///                                          -1);
/// </code>
/// </summary>

/// <param name="dialog">
/// a #GtkDialog
/// </param>
/// <param name="first_response_id">
/// a response id used by one @dialog’s buttons
/// </param>
/// <param name="@__arglist">
/// a list of more response ids of @dialog’s buttons, terminated by -1
/// </param>

	public static T SetAlternativeButtonOrder<T>(this T dialog, int first_response_id, IntPtr @__arglist) where T : GtkDialogHandle
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		GtkDialogHandleExterns.gtk_dialog_set_alternative_button_order(dialog, first_response_id, @__arglist);
		return dialog;
	}

/// <summary>
/// <para>
/// Sets an alternative button order. If the
/// #GtkSettings:gtk-alternative-button-order setting is set to %TRUE,
/// the dialog buttons are reordered according to the order of the
/// response ids in @new_order.
/// </para>
/// <para>
/// See gtk_dialog_set_alternative_button_order() for more information.
/// </para>
/// <para>
/// This function is for use by language bindings.
/// </para>
/// </summary>

/// <param name="dialog">
/// a #GtkDialog
/// </param>
/// <param name="n_params">
/// the number of response ids in @new_order
/// </param>
/// <param name="new_order">
/// an array of response ids of
///     @dialog’s buttons
/// </param>

	public static T SetAlternativeButtonOrderFromArray<T>(this T dialog, int n_params, int[] new_order) where T : GtkDialogHandle
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		GtkDialogHandleExterns.gtk_dialog_set_alternative_button_order_from_array(dialog, n_params, new_order);
		return dialog;
	}

/// <summary>
/// <para>
/// Sets the last widget in the dialog’s action area with the given @response_id
/// as the default widget for the dialog. Pressing “Enter” normally activates
/// the default widget.
/// </para>
/// </summary>

/// <param name="dialog">
/// a #GtkDialog
/// </param>
/// <param name="response_id">
/// a response ID
/// </param>

	public static T SetDefaultResponse<T>(this T dialog, MentorLake.Gtk.GtkResponseType response_id) where T : GtkDialogHandle
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		GtkDialogHandleExterns.gtk_dialog_set_default_response(dialog, response_id);
		return dialog;
	}

/// <summary>
/// <para>
/// Calls `gtk_widget_set_sensitive (widget, @setting)`
/// for each widget in the dialog’s action area with the given @response_id.
/// A convenient way to sensitize/desensitize dialog buttons.
/// </para>
/// </summary>

/// <param name="dialog">
/// a #GtkDialog
/// </param>
/// <param name="response_id">
/// a response ID
/// </param>
/// <param name="setting">
/// %TRUE for sensitive
/// </param>

	public static T SetResponseSensitive<T>(this T dialog, MentorLake.Gtk.GtkResponseType response_id, bool setting) where T : GtkDialogHandle
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		GtkDialogHandleExterns.gtk_dialog_set_response_sensitive(dialog, response_id, setting);
		return dialog;
	}

}

internal class GtkDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))]
	internal static extern MentorLake.Gtk.GtkDialogHandle gtk_dialog_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))]
	internal static extern MentorLake.Gtk.GtkDialogHandle gtk_dialog_new_with_buttons(string title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkDialogFlags flags, string first_button_text, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_dialog_add_action_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkResponseType response_id);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_dialog_add_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog, string button_text, MentorLake.Gtk.GtkResponseType response_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_dialog_add_buttons([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog, string first_button_text, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_dialog_get_action_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_dialog_get_content_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_dialog_get_header_bar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_dialog_get_response_for_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_dialog_get_widget_for_response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog, MentorLake.Gtk.GtkResponseType response_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_dialog_response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog, MentorLake.Gtk.GtkResponseType response_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_dialog_run([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_dialog_set_alternative_button_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog, int first_response_id, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_dialog_set_alternative_button_order_from_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog, int n_params, int[] new_order);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_dialog_set_default_response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog, MentorLake.Gtk.GtkResponseType response_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_dialog_set_response_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog, MentorLake.Gtk.GtkResponseType response_id, bool setting);

}
