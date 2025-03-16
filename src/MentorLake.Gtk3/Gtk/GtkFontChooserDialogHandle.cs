namespace MentorLake.Gtk;

public class GtkFontChooserDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkFontChooserHandle
{
	public static MentorLake.Gtk.GtkFontChooserDialogHandle New(string title, MentorLake.Gtk.GtkWindowHandle parent)
	{
		return GtkFontChooserDialogHandleExterns.gtk_font_chooser_dialog_new(title, parent);
	}

}

public static class GtkFontChooserDialogHandleExtensions
{
}

internal class GtkFontChooserDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkFontChooserDialogHandle gtk_font_chooser_dialog_new(string title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent);

}
