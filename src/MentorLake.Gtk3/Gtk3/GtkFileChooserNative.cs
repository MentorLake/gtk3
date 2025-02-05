namespace MentorLake.Gtk3.Gtk3;

public class GtkFileChooserNativeHandle : GtkNativeDialogHandle, GtkFileChooserHandle
{
	public static GtkFileChooserNativeHandle New(string title, GtkWindowHandle parent, GtkFileChooserAction action, string accept_label, string cancel_label)
	{
		return GtkFileChooserNativeExterns.gtk_file_chooser_native_new(title, parent, action, accept_label, cancel_label);
	}

}

public static class GtkFileChooserNativeHandleExtensions
{
	public static string GetAcceptLabel(this GtkFileChooserNativeHandle self)
	{
		return GtkFileChooserNativeExterns.gtk_file_chooser_native_get_accept_label(self);
	}

	public static string GetCancelLabel(this GtkFileChooserNativeHandle self)
	{
		return GtkFileChooserNativeExterns.gtk_file_chooser_native_get_cancel_label(self);
	}

	public static T SetAcceptLabel<T>(this T self, string accept_label) where T : GtkFileChooserNativeHandle
	{
		GtkFileChooserNativeExterns.gtk_file_chooser_native_set_accept_label(self, accept_label);
		return self;
	}

	public static T SetCancelLabel<T>(this T self, string cancel_label) where T : GtkFileChooserNativeHandle
	{
		GtkFileChooserNativeExterns.gtk_file_chooser_native_set_cancel_label(self, cancel_label);
		return self;
	}

}

internal class GtkFileChooserNativeExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkFileChooserNativeHandle gtk_file_chooser_native_new(string title, GtkWindowHandle parent, GtkFileChooserAction action, string accept_label, string cancel_label);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_native_get_accept_label(GtkFileChooserNativeHandle self);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_native_get_cancel_label(GtkFileChooserNativeHandle self);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_native_set_accept_label(GtkFileChooserNativeHandle self, string accept_label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_native_set_cancel_label(GtkFileChooserNativeHandle self, string cancel_label);

}
