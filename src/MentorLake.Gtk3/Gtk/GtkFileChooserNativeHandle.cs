namespace MentorLake.Gtk;

public class GtkFileChooserNativeHandle : GtkNativeDialogHandle, GtkFileChooserHandle
{
	public static MentorLake.Gtk.GtkFileChooserNativeHandle New(string title, MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkFileChooserAction action, string accept_label, string cancel_label)
	{
		return GtkFileChooserNativeHandleExterns.gtk_file_chooser_native_new(title, parent, action, accept_label, cancel_label);
	}

}

public static class GtkFileChooserNativeHandleExtensions
{
	public static string GetAcceptLabel(this MentorLake.Gtk.GtkFileChooserNativeHandle self)
	{
		return GtkFileChooserNativeHandleExterns.gtk_file_chooser_native_get_accept_label(self);
	}

	public static string GetCancelLabel(this MentorLake.Gtk.GtkFileChooserNativeHandle self)
	{
		return GtkFileChooserNativeHandleExterns.gtk_file_chooser_native_get_cancel_label(self);
	}

	public static T SetAcceptLabel<T>(this T self, string accept_label) where T : GtkFileChooserNativeHandle
	{
		GtkFileChooserNativeHandleExterns.gtk_file_chooser_native_set_accept_label(self, accept_label);
		return self;
	}

	public static T SetCancelLabel<T>(this T self, string cancel_label) where T : GtkFileChooserNativeHandle
	{
		GtkFileChooserNativeHandleExterns.gtk_file_chooser_native_set_cancel_label(self, cancel_label);
		return self;
	}

}

internal class GtkFileChooserNativeHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkFileChooserNativeHandle gtk_file_chooser_native_new(string title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkFileChooserAction action, string accept_label, string cancel_label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_native_get_accept_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserNativeHandle>))] MentorLake.Gtk.GtkFileChooserNativeHandle self);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_native_get_cancel_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserNativeHandle>))] MentorLake.Gtk.GtkFileChooserNativeHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_native_set_accept_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserNativeHandle>))] MentorLake.Gtk.GtkFileChooserNativeHandle self, string accept_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_native_set_cancel_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserNativeHandle>))] MentorLake.Gtk.GtkFileChooserNativeHandle self, string cancel_label);

}
