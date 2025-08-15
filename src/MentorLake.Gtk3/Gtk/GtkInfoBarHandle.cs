namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkInfoBar is a widget that can be used to show messages to
/// the user without showing a dialog. It is often temporarily shown
/// at the top or bottom of a document. In contrast to #GtkDialog, which
/// has a action area at the bottom, #GtkInfoBar has an action area
/// at the side.
/// </para>
/// <para>
/// The API of #GtkInfoBar is very similar to #GtkDialog, allowing you
/// to add buttons to the action area with gtk_info_bar_add_button() or
/// gtk_info_bar_new_with_buttons(). The sensitivity of action widgets
/// can be controlled with gtk_info_bar_set_response_sensitive().
/// To add widgets to the main content area of a #GtkInfoBar, use
/// gtk_info_bar_get_content_area() and add your widgets to the container.
/// </para>
/// <para>
/// Similar to #GtkMessageDialog, the contents of a #GtkInfoBar can by
/// classified as error message, warning, informational message, etc,
/// by using gtk_info_bar_set_message_type(). GTK+ may use the message type
/// to determine how the message is displayed.
/// </para>
/// <para>
/// A simple example for using a #GtkInfoBar:
/// <code>
/// GtkWidget *widget, *message_label, *content_area;
/// GtkWidget *widget, *message_label, *content_area;
/// GtkWidget *grid;
/// GtkInfoBar *bar;
/// 
/// // set up info bar
/// widget = gtk_info_bar_new ();
/// bar = GTK_INFO_BAR (widget);
/// grid = gtk_grid_new ();
/// 
/// gtk_widget_set_no_show_all (widget, TRUE);
/// message_label = gtk_label_new (&quot;&quot;);
/// content_area = gtk_info_bar_get_content_area (bar);
/// gtk_container_add (GTK_CONTAINER (content_area),
///                    message_label);
/// gtk_info_bar_add_button (bar,
///                          _(&quot;_OK&quot;),
///                          GTK_RESPONSE_OK);
/// g_signal_connect (bar,
///                   &quot;response&quot;,
///                   G_CALLBACK (gtk_widget_hide),
///                   NULL);
/// gtk_grid_attach (GTK_GRID (grid),
///                  widget,
///                  0, 2, 1, 1);
/// 
/// // ...
/// 
/// // show an error message
/// gtk_label_set_text (GTK_LABEL (message_label), &quot;An error occurred!&quot;);
/// gtk_info_bar_set_message_type (bar,
///                                GTK_MESSAGE_ERROR);
/// gtk_widget_show (bar);
/// </code>
/// # GtkInfoBar as GtkBuildable
/// </para>
/// <para>
/// The GtkInfoBar implementation of the GtkBuildable interface exposes
/// the content area and action area as internal children with the names
/// “content_area” and “action_area”.
/// </para>
/// <para>
/// GtkInfoBar supports a custom `&amp;lt;action-widgets&amp;gt;` element, which can contain
/// multiple `&amp;lt;action-widget&amp;gt;` elements. The “response” attribute specifies a
/// numeric response, and the content of the element is the id of widget
/// (which should be a child of the dialogs @action_area).
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkInfoBar has a single CSS node with name infobar. The node may get
/// one of the style classes .info, .warning, .error or .question, depending
/// on the message type.
/// </para>
/// </summary>

public class GtkInfoBarHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkInfoBar object.
/// </para>
/// </summary>

/// <return>
/// a new #GtkInfoBar object
/// </return>

	public static MentorLake.Gtk.GtkInfoBarHandle New()
	{
		return GtkInfoBarHandleExterns.gtk_info_bar_new();
	}

/// <summary>
/// <para>
/// Creates a new #GtkInfoBar with buttons. Button text/response ID
/// pairs should be listed, with a %NULL pointer ending the list.
/// Button text can be either a stock ID such as %GTK_STOCK_OK, or
/// some arbitrary text. A response ID can be any positive number,
/// or one of the values in the #GtkResponseType enumeration. If the
/// user clicks one of these dialog buttons, GtkInfoBar will emit
/// the “response” signal with the corresponding response ID.
/// </para>
/// </summary>

/// <param name="first_button_text">
/// stock ID or text to go in first button, or %NULL
/// </param>
/// <param name="@__arglist">
/// response ID for first button, then additional buttons, ending
///    with %NULL
/// </param>
/// <return>
/// a new #GtkInfoBar
/// </return>

	public static MentorLake.Gtk.GtkInfoBarHandle NewWithButtons(string first_button_text, IntPtr @__arglist)
	{
		return GtkInfoBarHandleExterns.gtk_info_bar_new_with_buttons(first_button_text, @__arglist);
	}

}
public static class GtkInfoBarHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::close signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user uses a keybinding to dismiss
/// the info bar.
/// </para>
/// <para>
/// The default binding for this signal is the Escape key.
/// </para>
/// </summary>

	public static IObservable<GtkInfoBarHandleSignalStructs.CloseSignal> Signal_Close(this GtkInfoBarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkInfoBarHandleSignalStructs.CloseSignal> obs) =>
		{
			GtkInfoBarHandleSignalDelegates.close handler = ( MentorLake.Gtk.GtkInfoBarHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkInfoBarHandleSignalStructs.CloseSignal()
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
/// Emitted when an action widget is clicked or the application programmer
/// calls gtk_dialog_response(). The @response_id depends on which action
/// widget was clicked.
/// </para>
/// </summary>

	public static IObservable<GtkInfoBarHandleSignalStructs.ResponseSignal> Signal_Response(this GtkInfoBarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkInfoBarHandleSignalStructs.ResponseSignal> obs) =>
		{
			GtkInfoBarHandleSignalDelegates.response handler = ( MentorLake.Gtk.GtkInfoBarHandle self,  MentorLake.Gtk.GtkResponseType response_id,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkInfoBarHandleSignalStructs.ResponseSignal()
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

public static class GtkInfoBarHandleSignalStructs
{

public class CloseSignal
{

	public MentorLake.Gtk.GtkInfoBarHandle Self;

	public IntPtr UserData;
}

public class ResponseSignal
{

	public MentorLake.Gtk.GtkInfoBarHandle Self;
/// <summary>
/// <para>
/// the response ID
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkResponseType ResponseId;

	public IntPtr UserData;
}
}

public static class GtkInfoBarHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::close signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user uses a keybinding to dismiss
/// the info bar.
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
public delegate void close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when an action widget is clicked or the application programmer
/// calls gtk_dialog_response(). The @response_id depends on which action
/// widget was clicked.
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
public delegate void response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle self, MentorLake.Gtk.GtkResponseType response_id, IntPtr user_data);

}


public static class GtkInfoBarHandleExtensions
{
/// <summary>
/// <para>
/// Add an activatable widget to the action area of a #GtkInfoBar,
/// connecting a signal handler that will emit the #GtkInfoBar::response
/// signal on the message area when the widget is activated. The widget
/// is appended to the end of the message areas action area.
/// </para>
/// </summary>

/// <param name="info_bar">
/// a #GtkInfoBar
/// </param>
/// <param name="child">
/// an activatable widget
/// </param>
/// <param name="response_id">
/// response ID for @child
/// </param>

	public static T AddActionWidget<T>(this T info_bar, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkResponseType response_id) where T : GtkInfoBarHandle
	{
		if (info_bar.IsInvalid) throw new Exception("Invalid handle (GtkInfoBarHandle)");
		GtkInfoBarHandleExterns.gtk_info_bar_add_action_widget(info_bar, child, response_id);
		return info_bar;
	}

/// <summary>
/// <para>
/// Adds a button with the given text and sets things up so that
/// clicking the button will emit the “response” signal with the given
/// response_id. The button is appended to the end of the info bars&apos;s
/// action area. The button widget is returned, but usually you don&apos;t
/// need it.
/// </para>
/// </summary>

/// <param name="info_bar">
/// a #GtkInfoBar
/// </param>
/// <param name="button_text">
/// text of button
/// </param>
/// <param name="response_id">
/// response ID for the button
/// </param>
/// <return>
/// the #GtkButton widget
/// that was added
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle AddButton(this MentorLake.Gtk.GtkInfoBarHandle info_bar, string button_text, MentorLake.Gtk.GtkResponseType response_id)
	{
		if (info_bar.IsInvalid) throw new Exception("Invalid handle (GtkInfoBarHandle)");
		return GtkInfoBarHandleExterns.gtk_info_bar_add_button(info_bar, button_text, response_id);
	}

/// <summary>
/// <para>
/// Adds more buttons, same as calling gtk_info_bar_add_button()
/// repeatedly. The variable argument list should be %NULL-terminated
/// as with gtk_info_bar_new_with_buttons(). Each button must have both
/// text and response ID.
/// </para>
/// </summary>

/// <param name="info_bar">
/// a #GtkInfoBar
/// </param>
/// <param name="first_button_text">
/// button text or stock ID
/// </param>
/// <param name="@__arglist">
/// response ID for first button, then more text-response_id pairs,
///     ending with %NULL
/// </param>

	public static T AddButtons<T>(this T info_bar, string first_button_text, IntPtr @__arglist) where T : GtkInfoBarHandle
	{
		if (info_bar.IsInvalid) throw new Exception("Invalid handle (GtkInfoBarHandle)");
		GtkInfoBarHandleExterns.gtk_info_bar_add_buttons(info_bar, first_button_text, @__arglist);
		return info_bar;
	}

/// <summary>
/// <para>
/// Returns the action area of @info_bar.
/// </para>
/// </summary>

/// <param name="info_bar">
/// a #GtkInfoBar
/// </param>
/// <return>
/// the action area
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetActionArea(this MentorLake.Gtk.GtkInfoBarHandle info_bar)
	{
		if (info_bar.IsInvalid) throw new Exception("Invalid handle (GtkInfoBarHandle)");
		return GtkInfoBarHandleExterns.gtk_info_bar_get_action_area(info_bar);
	}

/// <summary>
/// <para>
/// Returns the content area of @info_bar.
/// </para>
/// </summary>

/// <param name="info_bar">
/// a #GtkInfoBar
/// </param>
/// <return>
/// the content area
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetContentArea(this MentorLake.Gtk.GtkInfoBarHandle info_bar)
	{
		if (info_bar.IsInvalid) throw new Exception("Invalid handle (GtkInfoBarHandle)");
		return GtkInfoBarHandleExterns.gtk_info_bar_get_content_area(info_bar);
	}

/// <summary>
/// <para>
/// Returns the message type of the message area.
/// </para>
/// </summary>

/// <param name="info_bar">
/// a #GtkInfoBar
/// </param>
/// <return>
/// the message type of the message area.
/// </return>

	public static MentorLake.Gtk.GtkMessageType GetMessageType(this MentorLake.Gtk.GtkInfoBarHandle info_bar)
	{
		if (info_bar.IsInvalid) throw new Exception("Invalid handle (GtkInfoBarHandle)");
		return GtkInfoBarHandleExterns.gtk_info_bar_get_message_type(info_bar);
	}


/// <param name="info_bar">
/// a #GtkInfoBar
/// </param>
/// <return>
/// the current value of the GtkInfoBar:revealed property.
/// </return>

	public static bool GetRevealed(this MentorLake.Gtk.GtkInfoBarHandle info_bar)
	{
		if (info_bar.IsInvalid) throw new Exception("Invalid handle (GtkInfoBarHandle)");
		return GtkInfoBarHandleExterns.gtk_info_bar_get_revealed(info_bar);
	}

/// <summary>
/// <para>
/// Returns whether the widget will display a standard close button.
/// </para>
/// </summary>

/// <param name="info_bar">
/// a #GtkInfoBar
/// </param>
/// <return>
/// %TRUE if the widget displays standard close button
/// </return>

	public static bool GetShowCloseButton(this MentorLake.Gtk.GtkInfoBarHandle info_bar)
	{
		if (info_bar.IsInvalid) throw new Exception("Invalid handle (GtkInfoBarHandle)");
		return GtkInfoBarHandleExterns.gtk_info_bar_get_show_close_button(info_bar);
	}

/// <summary>
/// <para>
/// Emits the “response” signal with the given @response_id.
/// </para>
/// </summary>

/// <param name="info_bar">
/// a #GtkInfoBar
/// </param>
/// <param name="response_id">
/// a response ID
/// </param>

	public static T Response<T>(this T info_bar, MentorLake.Gtk.GtkResponseType response_id) where T : GtkInfoBarHandle
	{
		if (info_bar.IsInvalid) throw new Exception("Invalid handle (GtkInfoBarHandle)");
		GtkInfoBarHandleExterns.gtk_info_bar_response(info_bar, response_id);
		return info_bar;
	}

/// <summary>
/// <para>
/// Sets the last widget in the info bar’s action area with
/// the given response_id as the default widget for the dialog.
/// Pressing “Enter” normally activates the default widget.
/// </para>
/// <para>
/// Note that this function currently requires @info_bar to
/// be added to a widget hierarchy.
/// </para>
/// </summary>

/// <param name="info_bar">
/// a #GtkInfoBar
/// </param>
/// <param name="response_id">
/// a response ID
/// </param>

	public static T SetDefaultResponse<T>(this T info_bar, MentorLake.Gtk.GtkResponseType response_id) where T : GtkInfoBarHandle
	{
		if (info_bar.IsInvalid) throw new Exception("Invalid handle (GtkInfoBarHandle)");
		GtkInfoBarHandleExterns.gtk_info_bar_set_default_response(info_bar, response_id);
		return info_bar;
	}

/// <summary>
/// <para>
/// Sets the message type of the message area.
/// </para>
/// <para>
/// GTK+ uses this type to determine how the message is displayed.
/// </para>
/// </summary>

/// <param name="info_bar">
/// a #GtkInfoBar
/// </param>
/// <param name="message_type">
/// a #GtkMessageType
/// </param>

	public static T SetMessageType<T>(this T info_bar, MentorLake.Gtk.GtkMessageType message_type) where T : GtkInfoBarHandle
	{
		if (info_bar.IsInvalid) throw new Exception("Invalid handle (GtkInfoBarHandle)");
		GtkInfoBarHandleExterns.gtk_info_bar_set_message_type(info_bar, message_type);
		return info_bar;
	}

/// <summary>
/// <para>
/// Calls gtk_widget_set_sensitive (widget, setting) for each
/// widget in the info bars’s action area with the given response_id.
/// A convenient way to sensitize/desensitize dialog buttons.
/// </para>
/// </summary>

/// <param name="info_bar">
/// a #GtkInfoBar
/// </param>
/// <param name="response_id">
/// a response ID
/// </param>
/// <param name="setting">
/// TRUE for sensitive
/// </param>

	public static T SetResponseSensitive<T>(this T info_bar, MentorLake.Gtk.GtkResponseType response_id, bool setting) where T : GtkInfoBarHandle
	{
		if (info_bar.IsInvalid) throw new Exception("Invalid handle (GtkInfoBarHandle)");
		GtkInfoBarHandleExterns.gtk_info_bar_set_response_sensitive(info_bar, response_id, setting);
		return info_bar;
	}

/// <summary>
/// <para>
/// Sets the GtkInfoBar:revealed property to @revealed. This will cause
/// @info_bar to show up with a slide-in transition.
/// </para>
/// <para>
/// Note that this property does not automatically show @info_bar and thus won’t
/// have any effect if it is invisible.
/// </para>
/// </summary>

/// <param name="info_bar">
/// a #GtkInfoBar
/// </param>
/// <param name="revealed">
/// The new value of the property
/// </param>

	public static T SetRevealed<T>(this T info_bar, bool revealed) where T : GtkInfoBarHandle
	{
		if (info_bar.IsInvalid) throw new Exception("Invalid handle (GtkInfoBarHandle)");
		GtkInfoBarHandleExterns.gtk_info_bar_set_revealed(info_bar, revealed);
		return info_bar;
	}

/// <summary>
/// <para>
/// If true, a standard close button is shown. When clicked it emits
/// the response %GTK_RESPONSE_CLOSE.
/// </para>
/// </summary>

/// <param name="info_bar">
/// a #GtkInfoBar
/// </param>
/// <param name="setting">
/// %TRUE to include a close button
/// </param>

	public static T SetShowCloseButton<T>(this T info_bar, bool setting) where T : GtkInfoBarHandle
	{
		if (info_bar.IsInvalid) throw new Exception("Invalid handle (GtkInfoBarHandle)");
		GtkInfoBarHandleExterns.gtk_info_bar_set_show_close_button(info_bar, setting);
		return info_bar;
	}

}

internal class GtkInfoBarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))]
	internal static extern MentorLake.Gtk.GtkInfoBarHandle gtk_info_bar_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))]
	internal static extern MentorLake.Gtk.GtkInfoBarHandle gtk_info_bar_new_with_buttons(string first_button_text, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_info_bar_add_action_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkResponseType response_id);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_info_bar_add_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar, string button_text, MentorLake.Gtk.GtkResponseType response_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_info_bar_add_buttons([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar, string first_button_text, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_info_bar_get_action_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_info_bar_get_content_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkMessageType gtk_info_bar_get_message_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_info_bar_get_revealed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_info_bar_get_show_close_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_info_bar_response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar, MentorLake.Gtk.GtkResponseType response_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_info_bar_set_default_response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar, MentorLake.Gtk.GtkResponseType response_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_info_bar_set_message_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar, MentorLake.Gtk.GtkMessageType message_type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_info_bar_set_response_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar, MentorLake.Gtk.GtkResponseType response_id, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_info_bar_set_revealed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar, bool revealed);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_info_bar_set_show_close_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar, bool setting);

}
