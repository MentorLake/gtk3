namespace MentorLake.Gtk;

public class GtkColorChooserDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkColorChooserHandle
{
	public static MentorLake.Gtk.GtkColorChooserDialogHandle New(string title, MentorLake.Gtk.GtkWindowHandle parent)
	{
		return GtkColorChooserDialogHandleExterns.gtk_color_chooser_dialog_new(title, parent);
	}

}

public static class GtkColorChooserDialogHandleExtensions
{
}

internal class GtkColorChooserDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkColorChooserDialogHandle gtk_color_chooser_dialog_new(string title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent);

}
