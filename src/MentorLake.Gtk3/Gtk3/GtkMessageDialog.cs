namespace MentorLake.Gtk3.Gtk3;

public class GtkMessageDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkMessageDialogHandle New(GtkWindowHandle parent, GtkDialogFlags flags, GtkMessageType type, GtkButtonsType buttons, string message_format, IntPtr @__arglist)
	{
		return GtkMessageDialogExterns.gtk_message_dialog_new(parent, flags, type, buttons, message_format, @__arglist);
	}

	public static GtkMessageDialogHandle NewWithMarkup(GtkWindowHandle parent, GtkDialogFlags flags, GtkMessageType type, GtkButtonsType buttons, string message_format, IntPtr @__arglist)
	{
		return GtkMessageDialogExterns.gtk_message_dialog_new_with_markup(parent, flags, type, buttons, message_format, @__arglist);
	}

}

public static class GtkMessageDialogHandleExtensions
{
	public static T FormatSecondaryMarkup<T>(this T message_dialog, string message_format, IntPtr @__arglist) where T : GtkMessageDialogHandle
	{
		GtkMessageDialogExterns.gtk_message_dialog_format_secondary_markup(message_dialog, message_format, @__arglist);
		return message_dialog;
	}

	public static T FormatSecondaryText<T>(this T message_dialog, string message_format, IntPtr @__arglist) where T : GtkMessageDialogHandle
	{
		GtkMessageDialogExterns.gtk_message_dialog_format_secondary_text(message_dialog, message_format, @__arglist);
		return message_dialog;
	}

	public static GtkWidgetHandle GetImage(this GtkMessageDialogHandle dialog)
	{
		return GtkMessageDialogExterns.gtk_message_dialog_get_image(dialog);
	}

	public static GtkWidgetHandle GetMessageArea(this GtkMessageDialogHandle message_dialog)
	{
		return GtkMessageDialogExterns.gtk_message_dialog_get_message_area(message_dialog);
	}

	public static T SetImage<T>(this T dialog, GtkWidgetHandle image) where T : GtkMessageDialogHandle
	{
		GtkMessageDialogExterns.gtk_message_dialog_set_image(dialog, image);
		return dialog;
	}

	public static T SetMarkup<T>(this T message_dialog, string str) where T : GtkMessageDialogHandle
	{
		GtkMessageDialogExterns.gtk_message_dialog_set_markup(message_dialog, str);
		return message_dialog;
	}

}

internal class GtkMessageDialogExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkMessageDialogHandle gtk_message_dialog_new(GtkWindowHandle parent, GtkDialogFlags flags, GtkMessageType type, GtkButtonsType buttons, string message_format, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkMessageDialogHandle gtk_message_dialog_new_with_markup(GtkWindowHandle parent, GtkDialogFlags flags, GtkMessageType type, GtkButtonsType buttons, string message_format, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_message_dialog_format_secondary_markup(GtkMessageDialogHandle message_dialog, string message_format, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_message_dialog_format_secondary_text(GtkMessageDialogHandle message_dialog, string message_format, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_message_dialog_get_image(GtkMessageDialogHandle dialog);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_message_dialog_get_message_area(GtkMessageDialogHandle message_dialog);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_message_dialog_set_image(GtkMessageDialogHandle dialog, GtkWidgetHandle image);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_message_dialog_set_markup(GtkMessageDialogHandle message_dialog, string str);

}
