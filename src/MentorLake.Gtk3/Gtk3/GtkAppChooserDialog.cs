namespace MentorLake.Gtk3.Gtk3;

public class GtkAppChooserDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkAppChooserHandle, GtkBuildableHandle
{
	public static GtkAppChooserDialogHandle New(GtkWindowHandle parent, GtkDialogFlags flags, GFileHandle file)
	{
		return GtkAppChooserDialogExterns.gtk_app_chooser_dialog_new(parent, flags, file);
	}

	public static GtkAppChooserDialogHandle NewForContentType(GtkWindowHandle parent, GtkDialogFlags flags, string content_type)
	{
		return GtkAppChooserDialogExterns.gtk_app_chooser_dialog_new_for_content_type(parent, flags, content_type);
	}

}

public static class GtkAppChooserDialogHandleExtensions
{
	public static string GetHeading(this GtkAppChooserDialogHandle self)
	{
		return GtkAppChooserDialogExterns.gtk_app_chooser_dialog_get_heading(self);
	}

	public static GtkWidgetHandle GetWidget(this GtkAppChooserDialogHandle self)
	{
		return GtkAppChooserDialogExterns.gtk_app_chooser_dialog_get_widget(self);
	}

	public static T SetHeading<T>(this T self, string heading) where T : GtkAppChooserDialogHandle
	{
		GtkAppChooserDialogExterns.gtk_app_chooser_dialog_set_heading(self, heading);
		return self;
	}

}

internal class GtkAppChooserDialogExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAppChooserDialogHandle gtk_app_chooser_dialog_new(GtkWindowHandle parent, GtkDialogFlags flags, GFileHandle file);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAppChooserDialogHandle gtk_app_chooser_dialog_new_for_content_type(GtkWindowHandle parent, GtkDialogFlags flags, string content_type);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_app_chooser_dialog_get_heading(GtkAppChooserDialogHandle self);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_app_chooser_dialog_get_widget(GtkAppChooserDialogHandle self);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_app_chooser_dialog_set_heading(GtkAppChooserDialogHandle self, string heading);

}
