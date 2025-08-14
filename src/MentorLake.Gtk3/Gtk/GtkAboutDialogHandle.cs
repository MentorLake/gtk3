namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The GtkAboutDialog offers a simple way to display information about
/// a program like its logo, name, copyright, website and license. It is
/// also possible to give credits to the authors, documenters, translators
/// and artists who have worked on the program. An about dialog is typically
/// opened when the user selects the `About` option from the `Help` menu.
/// All parts of the dialog are optional.
/// </para>
/// <para>
/// About dialogs often contain links and email addresses. GtkAboutDialog
/// displays these as clickable links. By default, it calls gtk_show_uri_on_window()
/// when a user clicks one. The behaviour can be overridden with the
/// #GtkAboutDialog::activate-link signal.
/// </para>
/// <para>
/// To specify a person with an email address, use a string like
/// "Edgar Allan Poe <edgar\@poe.com>". To specify a website with a title,
/// use a string like "GTK+ team http://www.gtk.org".
/// </para>
/// <para>
/// To make constructing a GtkAboutDialog as convenient as possible, you can
/// use the function gtk_show_about_dialog() which constructs and shows a dialog
/// and keeps it around so that it can be shown again.
/// </para>
/// <para>
/// Note that GTK+ sets a default title of `_("About %s")` on the dialog
/// window (where \%s is replaced by the name of the application, but in
/// order to ensure proper translation of the title, applications should
/// set the title property explicitly when constructing a GtkAboutDialog,
/// as shown in the following example:
/// |[<!-- language="C" -->
/// GdkPixbuf *example_logo = gdk_pixbuf_new_from_file ("./logo.png", NULL);
/// gtk_show_about_dialog (NULL,
///                        "program-name", "ExampleCode",
///                        "logo", example_logo,
///                        "title", _("About ExampleCode"),
///                        NULL);
/// ]|
/// </para>
/// <para>
/// It is also possible to show a #GtkAboutDialog like any other #GtkDialog,
/// e.g. using gtk_dialog_run(). In this case, you might need to know that
/// the “Close” button returns the #GTK_RESPONSE_CANCEL response id.
/// </para>
/// </summary>

public class GtkAboutDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkAboutDialog.
/// </para>
/// </summary>

/// <return>
/// a newly created #GtkAboutDialog
/// </return>

	public static MentorLake.Gtk.GtkAboutDialogHandle New()
	{
		return GtkAboutDialogHandleExterns.gtk_about_dialog_new();
	}

}
public static class GtkAboutDialogHandleSignalExtensions
{
/// <summary>
/// <para>
/// The signal which gets emitted to activate a URI.
/// Applications may connect to it to override the default behaviour,
/// which is to call gtk_show_uri_on_window().
/// </para>
/// </summary>

	public static IObservable<GtkAboutDialogHandleSignalStructs.ActivateLinkSignal> Signal_ActivateLink(this GtkAboutDialogHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAboutDialogHandleSignalStructs.ActivateLinkSignal> obs) =>
		{
			GtkAboutDialogHandleSignalDelegates.activate_link handler = ( MentorLake.Gtk.GtkAboutDialogHandle self,  string uri,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAboutDialogHandleSignalStructs.ActivateLinkSignal()
				{
					Self = self, Uri = uri, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate-link", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkAboutDialogHandleSignalStructs
{

public class ActivateLinkSignal
{

	public MentorLake.Gtk.GtkAboutDialogHandle Self;
/// <summary>
/// <para>
/// the URI that is activated
/// </para>
/// </summary>

	public string Uri;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if the link has been activated
/// </para>
/// </summary>

	public bool ReturnValue;
}
}

public static class GtkAboutDialogHandleSignalDelegates
{

/// <summary>
/// <para>
/// The signal which gets emitted to activate a URI.
/// Applications may connect to it to override the default behaviour,
/// which is to call gtk_show_uri_on_window().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="uri">
/// the URI that is activated
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if the link has been activated
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool activate_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle self, string uri, IntPtr user_data);

}


public static class GtkAboutDialogHandleExtensions
{
/// <summary>
/// <para>
/// Creates a new section in the Credits page.
/// </para>
/// </summary>

/// <param name="about">
/// A #GtkAboutDialog
/// </param>
/// <param name="section_name">
/// The name of the section
/// </param>
/// <param name="people">
/// The people who belong to that section
/// </param>

	public static T AddCreditSection<T>(this T about, string section_name, string[] people) where T : GtkAboutDialogHandle
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		GtkAboutDialogHandleExterns.gtk_about_dialog_add_credit_section(about, section_name, people);
		return about;
	}

/// <summary>
/// <para>
/// Returns the string which are displayed in the artists tab
/// of the secondary credits dialog.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <return>
/// A
///  %NULL-terminated string array containing the artists. The array is
///  owned by the about dialog and must not be modified.
/// </return>

	public static string[] GetArtists(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_artists(about);
	}

/// <summary>
/// <para>
/// Returns the string which are displayed in the authors tab
/// of the secondary credits dialog.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <return>
/// A
///  %NULL-terminated string array containing the authors. The array is
///  owned by the about dialog and must not be modified.
/// </return>

	public static string[] GetAuthors(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_authors(about);
	}

/// <summary>
/// <para>
/// Returns the comments string.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <return>
/// The comments. The string is owned by the about
///  dialog and must not be modified.
/// </return>

	public static string GetComments(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_comments(about);
	}

/// <summary>
/// <para>
/// Returns the copyright string.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <return>
/// The copyright string. The string is owned by the about
///  dialog and must not be modified.
/// </return>

	public static string GetCopyright(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_copyright(about);
	}

/// <summary>
/// <para>
/// Returns the string which are displayed in the documenters
/// tab of the secondary credits dialog.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <return>
/// A
///  %NULL-terminated string array containing the documenters. The
///  array is owned by the about dialog and must not be modified.
/// </return>

	public static string[] GetDocumenters(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_documenters(about);
	}

/// <summary>
/// <para>
/// Returns the license information.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <return>
/// The license information. The string is owned by the about
///  dialog and must not be modified.
/// </return>

	public static string GetLicense(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_license(about);
	}

/// <summary>
/// <para>
/// Retrieves the license set using gtk_about_dialog_set_license_type()
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <return>
/// a #GtkLicense value
/// </return>

	public static MentorLake.Gtk.GtkLicense GetLicenseType(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_license_type(about);
	}

/// <summary>
/// <para>
/// Returns the pixbuf displayed as logo in the about dialog.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <return>
/// the pixbuf displayed as logo. The
///   pixbuf is owned by the about dialog. If you want to keep a
///   reference to it, you have to call g_object_ref() on it.
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetLogo(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_logo(about);
	}

/// <summary>
/// <para>
/// Returns the icon name displayed as logo in the about dialog.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <return>
/// the icon name displayed as logo. The string is
///   owned by the dialog. If you want to keep a reference
///   to it, you have to call g_strdup() on it.
/// </return>

	public static string GetLogoIconName(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_logo_icon_name(about);
	}

/// <summary>
/// <para>
/// Returns the program name displayed in the about dialog.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <return>
/// The program name. The string is owned by the about
///  dialog and must not be modified.
/// </return>

	public static string GetProgramName(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_program_name(about);
	}

/// <summary>
/// <para>
/// Returns the translator credits string which is displayed
/// in the translators tab of the secondary credits dialog.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <return>
/// The translator credits string. The string is
///   owned by the about dialog and must not be modified.
/// </return>

	public static string GetTranslatorCredits(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_translator_credits(about);
	}

/// <summary>
/// <para>
/// Returns the version string.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <return>
/// The version string. The string is owned by the about
///  dialog and must not be modified.
/// </return>

	public static string GetVersion(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_version(about);
	}

/// <summary>
/// <para>
/// Returns the website URL.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <return>
/// The website URL. The string is owned by the about
///  dialog and must not be modified.
/// </return>

	public static string GetWebsite(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_website(about);
	}

/// <summary>
/// <para>
/// Returns the label used for the website link.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <return>
/// The label used for the website link. The string is
///     owned by the about dialog and must not be modified.
/// </return>

	public static string GetWebsiteLabel(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_website_label(about);
	}

/// <summary>
/// <para>
/// Returns whether the license text in @about is
/// automatically wrapped.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <return>
/// %TRUE if the license text is wrapped
/// </return>

	public static bool GetWrapLicense(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_wrap_license(about);
	}

/// <summary>
/// <para>
/// Sets the strings which are displayed in the artists tab
/// of the secondary credits dialog.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <param name="artists">
/// a %NULL-terminated array of strings
/// </param>

	public static T SetArtists<T>(this T about, string[] artists) where T : GtkAboutDialogHandle
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_artists(about, artists);
		return about;
	}

/// <summary>
/// <para>
/// Sets the strings which are displayed in the authors tab
/// of the secondary credits dialog.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <param name="authors">
/// a %NULL-terminated array of strings
/// </param>

	public static T SetAuthors<T>(this T about, string[] authors) where T : GtkAboutDialogHandle
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_authors(about, authors);
		return about;
	}

/// <summary>
/// <para>
/// Sets the comments string to display in the about dialog.
/// This should be a short string of one or two lines.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <param name="comments">
/// a comments string
/// </param>

	public static T SetComments<T>(this T about, string comments) where T : GtkAboutDialogHandle
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_comments(about, comments);
		return about;
	}

/// <summary>
/// <para>
/// Sets the copyright string to display in the about dialog.
/// This should be a short string of one or two lines.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <param name="copyright">
/// the copyright string
/// </param>

	public static T SetCopyright<T>(this T about, string copyright) where T : GtkAboutDialogHandle
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_copyright(about, copyright);
		return about;
	}

/// <summary>
/// <para>
/// Sets the strings which are displayed in the documenters tab
/// of the secondary credits dialog.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <param name="documenters">
/// a %NULL-terminated array of strings
/// </param>

	public static T SetDocumenters<T>(this T about, string[] documenters) where T : GtkAboutDialogHandle
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_documenters(about, documenters);
		return about;
	}

/// <summary>
/// <para>
/// Sets the license information to be displayed in the secondary
/// license dialog. If @license is %NULL, the license button is
/// hidden.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <param name="license">
/// the license information or %NULL
/// </param>

	public static T SetLicense<T>(this T about, string license) where T : GtkAboutDialogHandle
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_license(about, license);
		return about;
	}

/// <summary>
/// <para>
/// Sets the license of the application showing the @about dialog from a
/// list of known licenses.
/// </para>
/// <para>
/// This function overrides the license set using
/// gtk_about_dialog_set_license().
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <param name="license_type">
/// the type of license
/// </param>

	public static T SetLicenseType<T>(this T about, MentorLake.Gtk.GtkLicense license_type) where T : GtkAboutDialogHandle
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_license_type(about, license_type);
		return about;
	}

/// <summary>
/// <para>
/// Sets the pixbuf to be displayed as logo in the about dialog.
/// If it is %NULL, the default window icon set with
/// gtk_window_set_default_icon() will be used.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <param name="logo">
/// a #GdkPixbuf, or %NULL
/// </param>

	public static T SetLogo<T>(this T about, MentorLake.GdkPixbuf.GdkPixbufHandle logo) where T : GtkAboutDialogHandle
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_logo(about, logo);
		return about;
	}

/// <summary>
/// <para>
/// Sets the pixbuf to be displayed as logo in the about dialog.
/// If it is %NULL, the default window icon set with
/// gtk_window_set_default_icon() will be used.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <param name="icon_name">
/// an icon name, or %NULL
/// </param>

	public static T SetLogoIconName<T>(this T about, string icon_name) where T : GtkAboutDialogHandle
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_logo_icon_name(about, icon_name);
		return about;
	}

/// <summary>
/// <para>
/// Sets the name to display in the about dialog.
/// If this is not set, it defaults to g_get_application_name().
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <param name="name">
/// the program name
/// </param>

	public static T SetProgramName<T>(this T about, string name) where T : GtkAboutDialogHandle
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_program_name(about, name);
		return about;
	}

/// <summary>
/// <para>
/// Sets the translator credits string which is displayed in
/// the translators tab of the secondary credits dialog.
/// </para>
/// <para>
/// The intended use for this string is to display the translator
/// of the language which is currently used in the user interface.
/// Using gettext(), a simple way to achieve that is to mark the
/// string for translation:
/// |[<!-- language="C" -->
/// GtkWidget *about = gtk_about_dialog_new ();
/// gtk_about_dialog_set_translator_credits (GTK_ABOUT_DIALOG (about),
///                                          _("translator-credits"));
/// ]|
/// It is a good idea to use the customary msgid “translator-credits” for this
/// purpose, since translators will already know the purpose of that msgid, and
/// since #GtkAboutDialog will detect if “translator-credits” is untranslated
/// and hide the tab.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <param name="translator_credits">
/// the translator credits
/// </param>

	public static T SetTranslatorCredits<T>(this T about, string translator_credits) where T : GtkAboutDialogHandle
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_translator_credits(about, translator_credits);
		return about;
	}

/// <summary>
/// <para>
/// Sets the version string to display in the about dialog.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <param name="version">
/// the version string
/// </param>

	public static T SetVersion<T>(this T about, string version) where T : GtkAboutDialogHandle
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_version(about, version);
		return about;
	}

/// <summary>
/// <para>
/// Sets the URL to use for the website link.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <param name="website">
/// a URL string starting with "http://"
/// </param>

	public static T SetWebsite<T>(this T about, string website) where T : GtkAboutDialogHandle
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_website(about, website);
		return about;
	}

/// <summary>
/// <para>
/// Sets the label to be used for the website link.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <param name="website_label">
/// the label used for the website link
/// </param>

	public static T SetWebsiteLabel<T>(this T about, string website_label) where T : GtkAboutDialogHandle
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_website_label(about, website_label);
		return about;
	}

/// <summary>
/// <para>
/// Sets whether the license text in @about is
/// automatically wrapped.
/// </para>
/// </summary>

/// <param name="about">
/// a #GtkAboutDialog
/// </param>
/// <param name="wrap_license">
/// whether to wrap the license
/// </param>

	public static T SetWrapLicense<T>(this T about, bool wrap_license) where T : GtkAboutDialogHandle
	{
		if (about.IsInvalid) throw new Exception("Invalid handle (GtkAboutDialogHandle)");
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_wrap_license(about, wrap_license);
		return about;
	}

}

internal class GtkAboutDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))]
	internal static extern MentorLake.Gtk.GtkAboutDialogHandle gtk_about_dialog_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_about_dialog_add_credit_section([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about, string section_name, string[] people);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] gtk_about_dialog_get_artists([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] gtk_about_dialog_get_authors([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_about_dialog_get_comments([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_about_dialog_get_copyright([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] gtk_about_dialog_get_documenters([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_about_dialog_get_license([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkLicense gtk_about_dialog_get_license_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_about_dialog_get_logo([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_about_dialog_get_logo_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_about_dialog_get_program_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_about_dialog_get_translator_credits([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_about_dialog_get_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_about_dialog_get_website([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_about_dialog_get_website_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_about_dialog_get_wrap_license([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_about_dialog_set_artists([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about, string[] artists);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_about_dialog_set_authors([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about, string[] authors);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_about_dialog_set_comments([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about, string comments);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_about_dialog_set_copyright([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about, string copyright);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_about_dialog_set_documenters([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about, string[] documenters);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_about_dialog_set_license([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about, string license);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_about_dialog_set_license_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about, MentorLake.Gtk.GtkLicense license_type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_about_dialog_set_logo([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle logo);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_about_dialog_set_logo_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about, string icon_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_about_dialog_set_program_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_about_dialog_set_translator_credits([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about, string translator_credits);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_about_dialog_set_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about, string version);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_about_dialog_set_website([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about, string website);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_about_dialog_set_website_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about, string website_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_about_dialog_set_wrap_license([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about, bool wrap_license);

}
