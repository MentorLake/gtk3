namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkAppChooser is an interface that can be implemented by widgets which
/// allow the user to choose an application (typically for the purpose of
/// opening a file). The main objects that implement this interface are
/// #GtkAppChooserWidget, #GtkAppChooserDialog and #GtkAppChooserButton.
/// </para>
/// <para>
/// Applications are represented by GIO #GAppInfo objects here.
/// GIO has a concept of recommended and fallback applications for a
/// given content type. Recommended applications are those that claim
/// to handle the content type itself, while fallback also includes
/// applications that handle a more generic content type. GIO also
/// knows the default and last-used application for a given content
/// type. The #GtkAppChooserWidget provides detailed control over
/// whether the shown list of applications should include default,
/// recommended or fallback applications.
/// </para>
/// <para>
/// To obtain the application that has been selected in a #GtkAppChooser,
/// use gtk_app_chooser_get_app_info().
/// </para>
/// </summary>

public interface GtkAppChooserHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkAppChooserHandleImpl : BaseSafeHandle, GtkAppChooserHandle
{
}

public static class GtkAppChooserHandleExtensions
{
/// <summary>
/// <para>
/// Returns the currently selected application.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooser
/// </param>
/// <return>
/// a #GAppInfo for the currently selected
///     application, or %NULL if none is selected. Free with g_object_unref()
/// </return>

	public static MentorLake.Gio.GAppInfoHandle GetAppInfo(this MentorLake.Gtk.GtkAppChooserHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserHandle)");
		return GtkAppChooserHandleExterns.gtk_app_chooser_get_app_info(self);
	}

/// <summary>
/// <para>
/// Returns the current value of the #GtkAppChooser:content-type property.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooser
/// </param>
/// <return>
/// the content type of @self. Free with g_free()
/// </return>

	public static string GetContentType(this MentorLake.Gtk.GtkAppChooserHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserHandle)");
		return GtkAppChooserHandleExterns.gtk_app_chooser_get_content_type(self);
	}

/// <summary>
/// <para>
/// Reloads the list of applications.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooser
/// </param>

	public static T Refresh<T>(this T self) where T : GtkAppChooserHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserHandle)");
		GtkAppChooserHandleExterns.gtk_app_chooser_refresh(self);
		return self;
	}

}

internal class GtkAppChooserHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))]
	internal static extern MentorLake.Gio.GAppInfoHandle gtk_app_chooser_get_app_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserHandleImpl>))] MentorLake.Gtk.GtkAppChooserHandle self);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_app_chooser_get_content_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserHandleImpl>))] MentorLake.Gtk.GtkAppChooserHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_app_chooser_refresh([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserHandleImpl>))] MentorLake.Gtk.GtkAppChooserHandle self);

}
