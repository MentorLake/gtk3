namespace MentorLake.Gtk;

public class GtkAppChooserDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkAppChooserHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkAppChooserDialogHandle New(MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkDialogFlags flags, MentorLake.Gio.GFileHandle file)
	{
		return GtkAppChooserDialogHandleExterns.gtk_app_chooser_dialog_new(parent, flags, file);
	}

	public static MentorLake.Gtk.GtkAppChooserDialogHandle NewForContentType(MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkDialogFlags flags, string content_type)
	{
		return GtkAppChooserDialogHandleExterns.gtk_app_chooser_dialog_new_for_content_type(parent, flags, content_type);
	}

}

public static class GtkAppChooserDialogHandleExtensions
{
	public static string GetHeading(this MentorLake.Gtk.GtkAppChooserDialogHandle self)
	{
		return GtkAppChooserDialogHandleExterns.gtk_app_chooser_dialog_get_heading(self);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetWidget(this MentorLake.Gtk.GtkAppChooserDialogHandle self)
	{
		return GtkAppChooserDialogHandleExterns.gtk_app_chooser_dialog_get_widget(self);
	}

	public static T SetHeading<T>(this T self, string heading) where T : GtkAppChooserDialogHandle
	{
		GtkAppChooserDialogHandleExterns.gtk_app_chooser_dialog_set_heading(self, heading);
		return self;
	}

}

internal class GtkAppChooserDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAppChooserDialogHandle gtk_app_chooser_dialog_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkDialogFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAppChooserDialogHandle gtk_app_chooser_dialog_new_for_content_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkDialogFlags flags, string content_type);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_app_chooser_dialog_get_heading([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserDialogHandle>))] MentorLake.Gtk.GtkAppChooserDialogHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_app_chooser_dialog_get_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserDialogHandle>))] MentorLake.Gtk.GtkAppChooserDialogHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_app_chooser_dialog_set_heading([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserDialogHandle>))] MentorLake.Gtk.GtkAppChooserDialogHandle self, string heading);

}
