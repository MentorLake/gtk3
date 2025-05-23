namespace MentorLake.Gtk;

public class GtkColorSelectionDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkColorSelectionDialogHandle New(string title)
	{
		return GtkColorSelectionDialogHandleExterns.gtk_color_selection_dialog_new(title);
	}

}

public static class GtkColorSelectionDialogHandleExtensions
{
	public static MentorLake.Gtk.GtkWidgetHandle GetColorSelection(this MentorLake.Gtk.GtkColorSelectionDialogHandle colorsel)
	{
		if (colorsel.IsInvalid) throw new Exception("Invalid handle (GtkColorSelectionDialogHandle)");
		return GtkColorSelectionDialogHandleExterns.gtk_color_selection_dialog_get_color_selection(colorsel);
	}

}

internal class GtkColorSelectionDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkColorSelectionDialogHandle>))]
	internal static extern MentorLake.Gtk.GtkColorSelectionDialogHandle gtk_color_selection_dialog_new(string title);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_color_selection_dialog_get_color_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorSelectionDialogHandle>))] MentorLake.Gtk.GtkColorSelectionDialogHandle colorsel);

}
