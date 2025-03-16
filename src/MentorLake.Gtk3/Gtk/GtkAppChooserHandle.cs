namespace MentorLake.Gtk;

public interface GtkAppChooserHandle
{
}

internal class GtkAppChooserHandleImpl : BaseSafeHandle, GtkAppChooserHandle
{
}

public static class GtkAppChooserHandleExtensions
{
	public static MentorLake.Gio.GAppInfoHandle GetAppInfo(this MentorLake.Gtk.GtkAppChooserHandle self)
	{
		return GtkAppChooserHandleExterns.gtk_app_chooser_get_app_info(self);
	}

	public static string GetContentType(this MentorLake.Gtk.GtkAppChooserHandle self)
	{
		return GtkAppChooserHandleExterns.gtk_app_chooser_get_content_type(self);
	}

	public static T Refresh<T>(this T self) where T : GtkAppChooserHandle
	{
		GtkAppChooserHandleExterns.gtk_app_chooser_refresh(self);
		return self;
	}

}

internal class GtkAppChooserHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gio.GAppInfoHandle gtk_app_chooser_get_app_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserHandleImpl>))] MentorLake.Gtk.GtkAppChooserHandle self);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_app_chooser_get_content_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserHandleImpl>))] MentorLake.Gtk.GtkAppChooserHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_app_chooser_refresh([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserHandleImpl>))] MentorLake.Gtk.GtkAppChooserHandle self);

}
