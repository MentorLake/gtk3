namespace MentorLake.Gtk;

public class GtkFileChooserDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkFileChooserHandle
{
	public static MentorLake.Gtk.GtkFileChooserDialogHandle New(string title, MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkFileChooserAction action, string first_button_text, IntPtr @__arglist)
	{
		return GtkFileChooserDialogHandleExterns.gtk_file_chooser_dialog_new(title, parent, action, first_button_text, @__arglist);
	}

}

public static class GtkFileChooserDialogHandleExtensions
{
}

internal class GtkFileChooserDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkFileChooserDialogHandle gtk_file_chooser_dialog_new(string title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkFileChooserAction action, string first_button_text, IntPtr @__arglist);

}
