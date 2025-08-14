namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkAppChooserDialog shows a #GtkAppChooserWidget inside a #GtkDialog.
/// </para>
/// <para>
/// Note that #GtkAppChooserDialog does not have any interesting methods
/// of its own. Instead, you should get the embedded #GtkAppChooserWidget
/// using gtk_app_chooser_dialog_get_widget() and call its methods if
/// the generic #GtkAppChooser interface is not sufficient for your needs.
/// </para>
/// <para>
/// To set the heading that is shown above the #GtkAppChooserWidget,
/// use gtk_app_chooser_dialog_set_heading().
/// </para>
/// </summary>

public class GtkAppChooserDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkAppChooserHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkAppChooserDialog for the provided #GFile,
/// to allow the user to select an application for it.
/// </para>
/// </summary>

/// <param name="parent">
/// a #GtkWindow, or %NULL
/// </param>
/// <param name="flags">
/// flags for this dialog
/// </param>
/// <param name="file">
/// a #GFile
/// </param>
/// <return>
/// a newly created #GtkAppChooserDialog
/// </return>

	public static MentorLake.Gtk.GtkAppChooserDialogHandle New(MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkDialogFlags flags, MentorLake.Gio.GFileHandle file)
	{
		return GtkAppChooserDialogHandleExterns.gtk_app_chooser_dialog_new(parent, flags, file);
	}

/// <summary>
/// <para>
/// Creates a new #GtkAppChooserDialog for the provided content type,
/// to allow the user to select an application for it.
/// </para>
/// </summary>

/// <param name="parent">
/// a #GtkWindow, or %NULL
/// </param>
/// <param name="flags">
/// flags for this dialog
/// </param>
/// <param name="content_type">
/// a content type string
/// </param>
/// <return>
/// a newly created #GtkAppChooserDialog
/// </return>

	public static MentorLake.Gtk.GtkAppChooserDialogHandle NewForContentType(MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkDialogFlags flags, string content_type)
	{
		return GtkAppChooserDialogHandleExterns.gtk_app_chooser_dialog_new_for_content_type(parent, flags, content_type);
	}

}

public static class GtkAppChooserDialogHandleExtensions
{
/// <summary>
/// <para>
/// Returns the text to display at the top of the dialog.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserDialog
/// </param>
/// <return>
/// the text to display at the top of the dialog, or %NULL, in which
///     case a default text is displayed
/// </return>

	public static string GetHeading(this MentorLake.Gtk.GtkAppChooserDialogHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserDialogHandle)");
		return GtkAppChooserDialogHandleExterns.gtk_app_chooser_dialog_get_heading(self);
	}

/// <summary>
/// <para>
/// Returns the #GtkAppChooserWidget of this dialog.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserDialog
/// </param>
/// <return>
/// the #GtkAppChooserWidget of @self
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetWidget(this MentorLake.Gtk.GtkAppChooserDialogHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserDialogHandle)");
		return GtkAppChooserDialogHandleExterns.gtk_app_chooser_dialog_get_widget(self);
	}

/// <summary>
/// <para>
/// Sets the text to display at the top of the dialog.
/// If the heading is not set, the dialog displays a default text.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserDialog
/// </param>
/// <param name="heading">
/// a string containing Pango markup
/// </param>

	public static T SetHeading<T>(this T self, string heading) where T : GtkAppChooserDialogHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserDialogHandle)");
		GtkAppChooserDialogHandleExterns.gtk_app_chooser_dialog_set_heading(self, heading);
		return self;
	}

}

internal class GtkAppChooserDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserDialogHandle>))]
	internal static extern MentorLake.Gtk.GtkAppChooserDialogHandle gtk_app_chooser_dialog_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkDialogFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserDialogHandle>))]
	internal static extern MentorLake.Gtk.GtkAppChooserDialogHandle gtk_app_chooser_dialog_new_for_content_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkDialogFlags flags, string content_type);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_app_chooser_dialog_get_heading([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserDialogHandle>))] MentorLake.Gtk.GtkAppChooserDialogHandle self);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_app_chooser_dialog_get_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserDialogHandle>))] MentorLake.Gtk.GtkAppChooserDialogHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_app_chooser_dialog_set_heading([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserDialogHandle>))] MentorLake.Gtk.GtkAppChooserDialogHandle self, string heading);

}
