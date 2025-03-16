namespace MentorLake.Gtk;

public class GtkMessageDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkMessageDialogHandle New(MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkDialogFlags flags, MentorLake.Gtk.GtkMessageType type, MentorLake.Gtk.GtkButtonsType buttons, string message_format, IntPtr @__arglist)
	{
		return GtkMessageDialogHandleExterns.gtk_message_dialog_new(parent, flags, type, buttons, message_format, @__arglist);
	}

	public static MentorLake.Gtk.GtkMessageDialogHandle NewWithMarkup(MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkDialogFlags flags, MentorLake.Gtk.GtkMessageType type, MentorLake.Gtk.GtkButtonsType buttons, string message_format, IntPtr @__arglist)
	{
		return GtkMessageDialogHandleExterns.gtk_message_dialog_new_with_markup(parent, flags, type, buttons, message_format, @__arglist);
	}

}

public static class GtkMessageDialogHandleExtensions
{
	public static T FormatSecondaryMarkup<T>(this T message_dialog, string message_format, IntPtr @__arglist) where T : GtkMessageDialogHandle
	{
		GtkMessageDialogHandleExterns.gtk_message_dialog_format_secondary_markup(message_dialog, message_format, @__arglist);
		return message_dialog;
	}

	public static T FormatSecondaryText<T>(this T message_dialog, string message_format, IntPtr @__arglist) where T : GtkMessageDialogHandle
	{
		GtkMessageDialogHandleExterns.gtk_message_dialog_format_secondary_text(message_dialog, message_format, @__arglist);
		return message_dialog;
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetImage(this MentorLake.Gtk.GtkMessageDialogHandle dialog)
	{
		return GtkMessageDialogHandleExterns.gtk_message_dialog_get_image(dialog);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetMessageArea(this MentorLake.Gtk.GtkMessageDialogHandle message_dialog)
	{
		return GtkMessageDialogHandleExterns.gtk_message_dialog_get_message_area(message_dialog);
	}

	public static T SetImage<T>(this T dialog, MentorLake.Gtk.GtkWidgetHandle image) where T : GtkMessageDialogHandle
	{
		GtkMessageDialogHandleExterns.gtk_message_dialog_set_image(dialog, image);
		return dialog;
	}

	public static T SetMarkup<T>(this T message_dialog, string str) where T : GtkMessageDialogHandle
	{
		GtkMessageDialogHandleExterns.gtk_message_dialog_set_markup(message_dialog, str);
		return message_dialog;
	}

}

internal class GtkMessageDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkMessageDialogHandle gtk_message_dialog_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkDialogFlags flags, MentorLake.Gtk.GtkMessageType type, MentorLake.Gtk.GtkButtonsType buttons, string message_format, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkMessageDialogHandle gtk_message_dialog_new_with_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkDialogFlags flags, MentorLake.Gtk.GtkMessageType type, MentorLake.Gtk.GtkButtonsType buttons, string message_format, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_message_dialog_format_secondary_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMessageDialogHandle>))] MentorLake.Gtk.GtkMessageDialogHandle message_dialog, string message_format, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_message_dialog_format_secondary_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMessageDialogHandle>))] MentorLake.Gtk.GtkMessageDialogHandle message_dialog, string message_format, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_message_dialog_get_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMessageDialogHandle>))] MentorLake.Gtk.GtkMessageDialogHandle dialog);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_message_dialog_get_message_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMessageDialogHandle>))] MentorLake.Gtk.GtkMessageDialogHandle message_dialog);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_message_dialog_set_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMessageDialogHandle>))] MentorLake.Gtk.GtkMessageDialogHandle dialog, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle image);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_message_dialog_set_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMessageDialogHandle>))] MentorLake.Gtk.GtkMessageDialogHandle message_dialog, string str);

}
