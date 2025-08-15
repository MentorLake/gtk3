namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkMessageDialog presents a dialog with some message text. It’s simply a
/// convenience widget; you could construct the equivalent of #GtkMessageDialog
/// from #GtkDialog without too much effort, but #GtkMessageDialog saves typing.
/// </para>
/// <para>
/// One difference from #GtkDialog is that #GtkMessageDialog sets the
/// #GtkWindow:skip-taskbar-hint property to %TRUE, so that the dialog is hidden
/// from the taskbar by default.
/// </para>
/// <para>
/// The easiest way to do a modal message dialog is to use gtk_dialog_run(), though
/// you can also pass in the %GTK_DIALOG_MODAL flag, gtk_dialog_run() automatically
/// makes the dialog modal and waits for the user to respond to it. gtk_dialog_run()
/// returns when any dialog button is clicked.
/// </para>
/// <para>
/// An example for using a modal dialog:
/// <code>
///  GtkDialogFlags flags = GTK_DIALOG_DESTROY_WITH_PARENT;
///  GtkDialogFlags flags = GTK_DIALOG_DESTROY_WITH_PARENT;
///  dialog = gtk_message_dialog_new (parent_window,
///                                   flags,
///                                   GTK_MESSAGE_ERROR,
///                                   GTK_BUTTONS_CLOSE,
///                                   &quot;Error reading “%s”: %s&quot;,
///                                   filename,
///                                   g_strerror (errno));
///  gtk_dialog_run (GTK_DIALOG (dialog));
///  gtk_widget_destroy (dialog);
/// </code>
/// You might do a non-modal #GtkMessageDialog as follows:
/// </para>
/// <para>
/// An example for a non-modal dialog:
/// <code>
///  GtkDialogFlags flags = GTK_DIALOG_DESTROY_WITH_PARENT;
///  GtkDialogFlags flags = GTK_DIALOG_DESTROY_WITH_PARENT;
///  dialog = gtk_message_dialog_new (parent_window,
///                                   flags,
///                                   GTK_MESSAGE_ERROR,
///                                   GTK_BUTTONS_CLOSE,
///                                   &quot;Error reading “%s”: %s&quot;,
///                                   filename,
///                                   g_strerror (errno));
/// 
///  // Destroy the dialog when the user responds to it
///  // (e.g. clicks a button)
/// 
///  g_signal_connect_swapped (dialog, &quot;response&quot;,
///                            G_CALLBACK (gtk_widget_destroy),
///                            dialog);
/// </code>
/// # GtkMessageDialog as GtkBuildable
/// </para>
/// <para>
/// The GtkMessageDialog implementation of the GtkBuildable interface exposes
/// the message area as an internal child with the name “message_area”.
/// </para>
/// </summary>

public class GtkMessageDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new message dialog, which is a simple dialog with some text
/// the user may want to see. When the user clicks a button a “response”
/// signal is emitted with response IDs from #GtkResponseType. See
/// #GtkDialog for more details.
/// </para>
/// </summary>

/// <param name="parent">
/// transient parent, or %NULL for none
/// </param>
/// <param name="flags">
/// flags
/// </param>
/// <param name="type">
/// type of message
/// </param>
/// <param name="buttons">
/// set of buttons to use
/// </param>
/// <param name="message_format">
/// printf()-style format string, or %NULL
/// </param>
/// <param name="@__arglist">
/// arguments for @message_format
/// </param>
/// <return>
/// a new #GtkMessageDialog
/// </return>

	public static MentorLake.Gtk.GtkMessageDialogHandle New(MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkDialogFlags flags, MentorLake.Gtk.GtkMessageType type, MentorLake.Gtk.GtkButtonsType buttons, string message_format, IntPtr @__arglist)
	{
		return GtkMessageDialogHandleExterns.gtk_message_dialog_new(parent, flags, type, buttons, message_format, @__arglist);
	}

/// <summary>
/// <para>
/// Creates a new message dialog, which is a simple dialog with some text that
/// is marked up with the [Pango text markup language][PangoMarkupFormat].
/// When the user clicks a button a “response” signal is emitted with
/// response IDs from #GtkResponseType. See #GtkDialog for more details.
/// </para>
/// <para>
/// Special XML characters in the printf() arguments passed to this
/// function will automatically be escaped as necessary.
/// (See g_markup_printf_escaped() for how this is implemented.)
/// Usually this is what you want, but if you have an existing
/// Pango markup string that you want to use literally as the
/// label, then you need to use gtk_message_dialog_set_markup()
/// instead, since you can’t pass the markup string either
/// as the format (it might contain “%” characters) or as a string
/// argument.
/// <code>
///  GtkWidget *dialog;
///  GtkWidget *dialog;
///  GtkDialogFlags flags = GTK_DIALOG_DESTROY_WITH_PARENT;
///  dialog = gtk_message_dialog_new (parent_window,
///                                   flags,
///                                   GTK_MESSAGE_ERROR,
///                                   GTK_BUTTONS_CLOSE,
///                                   NULL);
///  gtk_message_dialog_set_markup (GTK_MESSAGE_DIALOG (dialog),
///                                 markup);
/// </code>
/// </para>
/// </summary>

/// <param name="parent">
/// transient parent, or %NULL for none
/// </param>
/// <param name="flags">
/// flags
/// </param>
/// <param name="type">
/// type of message
/// </param>
/// <param name="buttons">
/// set of buttons to use
/// </param>
/// <param name="message_format">
/// printf()-style format string, or %NULL
/// </param>
/// <param name="@__arglist">
/// arguments for @message_format
/// </param>
/// <return>
/// a new #GtkMessageDialog
/// </return>

	public static MentorLake.Gtk.GtkMessageDialogHandle NewWithMarkup(MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkDialogFlags flags, MentorLake.Gtk.GtkMessageType type, MentorLake.Gtk.GtkButtonsType buttons, string message_format, IntPtr @__arglist)
	{
		return GtkMessageDialogHandleExterns.gtk_message_dialog_new_with_markup(parent, flags, type, buttons, message_format, @__arglist);
	}

}

public static class GtkMessageDialogHandleExtensions
{
/// <summary>
/// <para>
/// Sets the secondary text of the message dialog to be @message_format (with
/// printf()-style), which is marked up with the
/// [Pango text markup language][PangoMarkupFormat].
/// </para>
/// <para>
/// Due to an oversight, this function does not escape special XML characters
/// like gtk_message_dialog_new_with_markup() does. Thus, if the arguments
/// may contain special XML characters, you should use g_markup_printf_escaped()
/// to escape it.
/// </para>
/// <code>
/// gchar *msg;
/// gchar *msg;
/// 
/// msg = g_markup_printf_escaped (message_format, ...);
/// gtk_message_dialog_format_secondary_markup (message_dialog,
///                                             &quot;%s&quot;, msg);
/// g_free (msg);
/// </code>
/// </summary>

/// <param name="message_dialog">
/// a #GtkMessageDialog
/// </param>
/// <param name="message_format">
/// printf()-style markup string (see
///      [Pango markup format][PangoMarkupFormat]), or %NULL
/// </param>
/// <param name="@__arglist">
/// arguments for @message_format
/// </param>

	public static T FormatSecondaryMarkup<T>(this T message_dialog, string message_format, IntPtr @__arglist) where T : GtkMessageDialogHandle
	{
		if (message_dialog.IsInvalid) throw new Exception("Invalid handle (GtkMessageDialogHandle)");
		GtkMessageDialogHandleExterns.gtk_message_dialog_format_secondary_markup(message_dialog, message_format, @__arglist);
		return message_dialog;
	}

/// <summary>
/// <para>
/// Sets the secondary text of the message dialog to be @message_format
/// (with printf()-style).
/// </para>
/// </summary>

/// <param name="message_dialog">
/// a #GtkMessageDialog
/// </param>
/// <param name="message_format">
/// printf()-style format string, or %NULL
/// </param>
/// <param name="@__arglist">
/// arguments for @message_format
/// </param>

	public static T FormatSecondaryText<T>(this T message_dialog, string message_format, IntPtr @__arglist) where T : GtkMessageDialogHandle
	{
		if (message_dialog.IsInvalid) throw new Exception("Invalid handle (GtkMessageDialogHandle)");
		GtkMessageDialogHandleExterns.gtk_message_dialog_format_secondary_text(message_dialog, message_format, @__arglist);
		return message_dialog;
	}

/// <summary>
/// <para>
/// Gets the dialog’s image.
/// </para>
/// </summary>

/// <param name="dialog">
/// a #GtkMessageDialog
/// </param>
/// <return>
/// the dialog’s image
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetImage(this MentorLake.Gtk.GtkMessageDialogHandle dialog)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkMessageDialogHandle)");
		return GtkMessageDialogHandleExterns.gtk_message_dialog_get_image(dialog);
	}

/// <summary>
/// <para>
/// Returns the message area of the dialog. This is the box where the
/// dialog’s primary and secondary labels are packed. You can add your
/// own extra content to that box and it will appear below those labels.
/// See gtk_dialog_get_content_area() for the corresponding
/// function in the parent #GtkDialog.
/// </para>
/// </summary>

/// <param name="message_dialog">
/// a #GtkMessageDialog
/// </param>
/// <return>
/// A #GtkBox corresponding to the
///     “message area” in the @message_dialog.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetMessageArea(this MentorLake.Gtk.GtkMessageDialogHandle message_dialog)
	{
		if (message_dialog.IsInvalid) throw new Exception("Invalid handle (GtkMessageDialogHandle)");
		return GtkMessageDialogHandleExterns.gtk_message_dialog_get_message_area(message_dialog);
	}

/// <summary>
/// <para>
/// Sets the dialog’s image to @image.
/// </para>
/// </summary>

/// <param name="dialog">
/// a #GtkMessageDialog
/// </param>
/// <param name="image">
/// the image
/// </param>

	public static T SetImage<T>(this T dialog, MentorLake.Gtk.GtkWidgetHandle image) where T : GtkMessageDialogHandle
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkMessageDialogHandle)");
		GtkMessageDialogHandleExterns.gtk_message_dialog_set_image(dialog, image);
		return dialog;
	}

/// <summary>
/// <para>
/// Sets the text of the message dialog to be @str, which is marked
/// up with the [Pango text markup language][PangoMarkupFormat].
/// </para>
/// </summary>

/// <param name="message_dialog">
/// a #GtkMessageDialog
/// </param>
/// <param name="str">
/// markup string (see [Pango markup format][PangoMarkupFormat])
/// </param>

	public static T SetMarkup<T>(this T message_dialog, string str) where T : GtkMessageDialogHandle
	{
		if (message_dialog.IsInvalid) throw new Exception("Invalid handle (GtkMessageDialogHandle)");
		GtkMessageDialogHandleExterns.gtk_message_dialog_set_markup(message_dialog, str);
		return message_dialog;
	}

}

internal class GtkMessageDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkMessageDialogHandle>))]
	internal static extern MentorLake.Gtk.GtkMessageDialogHandle gtk_message_dialog_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkDialogFlags flags, MentorLake.Gtk.GtkMessageType type, MentorLake.Gtk.GtkButtonsType buttons, string message_format, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkMessageDialogHandle>))]
	internal static extern MentorLake.Gtk.GtkMessageDialogHandle gtk_message_dialog_new_with_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkDialogFlags flags, MentorLake.Gtk.GtkMessageType type, MentorLake.Gtk.GtkButtonsType buttons, string message_format, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_message_dialog_format_secondary_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMessageDialogHandle>))] MentorLake.Gtk.GtkMessageDialogHandle message_dialog, string message_format, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_message_dialog_format_secondary_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMessageDialogHandle>))] MentorLake.Gtk.GtkMessageDialogHandle message_dialog, string message_format, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_message_dialog_get_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMessageDialogHandle>))] MentorLake.Gtk.GtkMessageDialogHandle dialog);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_message_dialog_get_message_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMessageDialogHandle>))] MentorLake.Gtk.GtkMessageDialogHandle message_dialog);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_message_dialog_set_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMessageDialogHandle>))] MentorLake.Gtk.GtkMessageDialogHandle dialog, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle image);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_message_dialog_set_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMessageDialogHandle>))] MentorLake.Gtk.GtkMessageDialogHandle message_dialog, string str);

}
