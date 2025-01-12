namespace MentorLake.Gtk3.Gtk3;

public class GtkAboutDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkAboutDialogHandle New()
	{
		return GtkAboutDialogExterns.gtk_about_dialog_new();
	}

}

public static class GtkAboutDialogSignalExtensions
{

	public static IObservable<GtkAboutDialogSignalStructs.ActivateLinkSignal> Signal_ActivateLink(this GtkAboutDialogHandle instance)
	{
		return Observable.Create((IObserver<GtkAboutDialogSignalStructs.ActivateLinkSignal> obs) =>
		{
			GtkAboutDialogSignalDelegates.activate_link handler = (GtkAboutDialogHandle self, string uri, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAboutDialogSignalStructs.ActivateLinkSignal()
				{
					Self = self, Uri = uri, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate_link", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkAboutDialogSignalStructs
{

public struct ActivateLinkSignal
{
	public GtkAboutDialogHandle Self;
	public string Uri;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkAboutDialogSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool activate_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkAboutDialogHandle>))] GtkAboutDialogHandle self, string uri, IntPtr user_data);

}


public static class GtkAboutDialogHandleExtensions
{
	public static T AddCreditSection<T>(this T about, string section_name, string[] people) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogExterns.gtk_about_dialog_add_credit_section(about, section_name, people);
		return about;
	}

	public static IntPtr GetArtists(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_artists(about);
	}

	public static IntPtr GetAuthors(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_authors(about);
	}

	public static string GetComments(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_comments(about);
	}

	public static string GetCopyright(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_copyright(about);
	}

	public static IntPtr GetDocumenters(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_documenters(about);
	}

	public static string GetLicense(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_license(about);
	}

	public static GtkLicense GetLicenseType(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_license_type(about);
	}

	public static GdkPixbufHandle GetLogo(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_logo(about);
	}

	public static string GetLogoIconName(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_logo_icon_name(about);
	}

	public static string GetProgramName(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_program_name(about);
	}

	public static string GetTranslatorCredits(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_translator_credits(about);
	}

	public static string GetVersion(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_version(about);
	}

	public static string GetWebsite(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_website(about);
	}

	public static string GetWebsiteLabel(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_website_label(about);
	}

	public static bool GetWrapLicense(this GtkAboutDialogHandle about)
	{
		return GtkAboutDialogExterns.gtk_about_dialog_get_wrap_license(about);
	}

	public static T SetArtists<T>(this T about, string[] artists) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_artists(about, artists);
		return about;
	}

	public static T SetAuthors<T>(this T about, string[] authors) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_authors(about, authors);
		return about;
	}

	public static T SetComments<T>(this T about, string comments) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_comments(about, comments);
		return about;
	}

	public static T SetCopyright<T>(this T about, string copyright) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_copyright(about, copyright);
		return about;
	}

	public static T SetDocumenters<T>(this T about, string[] documenters) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_documenters(about, documenters);
		return about;
	}

	public static T SetLicense<T>(this T about, string license) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_license(about, license);
		return about;
	}

	public static T SetLicenseType<T>(this T about, GtkLicense license_type) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_license_type(about, license_type);
		return about;
	}

	public static T SetLogo<T>(this T about, GdkPixbufHandle logo) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_logo(about, logo);
		return about;
	}

	public static T SetLogoIconName<T>(this T about, string icon_name) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_logo_icon_name(about, icon_name);
		return about;
	}

	public static T SetProgramName<T>(this T about, string name) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_program_name(about, name);
		return about;
	}

	public static T SetTranslatorCredits<T>(this T about, string translator_credits) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_translator_credits(about, translator_credits);
		return about;
	}

	public static T SetVersion<T>(this T about, string version) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_version(about, version);
		return about;
	}

	public static T SetWebsite<T>(this T about, string website) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_website(about, website);
		return about;
	}

	public static T SetWebsiteLabel<T>(this T about, string website_label) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_website_label(about, website_label);
		return about;
	}

	public static T SetWrapLicense<T>(this T about, bool wrap_license) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogExterns.gtk_about_dialog_set_wrap_license(about, wrap_license);
		return about;
	}

}

internal class GtkAboutDialogExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAboutDialogHandle gtk_about_dialog_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_about_dialog_add_credit_section(GtkAboutDialogHandle about, string section_name, string[] people);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_about_dialog_get_artists(GtkAboutDialogHandle about);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_about_dialog_get_authors(GtkAboutDialogHandle about);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_about_dialog_get_comments(GtkAboutDialogHandle about);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_about_dialog_get_copyright(GtkAboutDialogHandle about);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_about_dialog_get_documenters(GtkAboutDialogHandle about);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_about_dialog_get_license(GtkAboutDialogHandle about);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkLicense gtk_about_dialog_get_license_type(GtkAboutDialogHandle about);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_about_dialog_get_logo(GtkAboutDialogHandle about);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_about_dialog_get_logo_icon_name(GtkAboutDialogHandle about);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_about_dialog_get_program_name(GtkAboutDialogHandle about);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_about_dialog_get_translator_credits(GtkAboutDialogHandle about);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_about_dialog_get_version(GtkAboutDialogHandle about);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_about_dialog_get_website(GtkAboutDialogHandle about);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_about_dialog_get_website_label(GtkAboutDialogHandle about);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_about_dialog_get_wrap_license(GtkAboutDialogHandle about);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_about_dialog_set_artists(GtkAboutDialogHandle about, string[] artists);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_about_dialog_set_authors(GtkAboutDialogHandle about, string[] authors);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_about_dialog_set_comments(GtkAboutDialogHandle about, string comments);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_about_dialog_set_copyright(GtkAboutDialogHandle about, string copyright);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_about_dialog_set_documenters(GtkAboutDialogHandle about, string[] documenters);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_about_dialog_set_license(GtkAboutDialogHandle about, string license);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_about_dialog_set_license_type(GtkAboutDialogHandle about, GtkLicense license_type);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_about_dialog_set_logo(GtkAboutDialogHandle about, GdkPixbufHandle logo);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_about_dialog_set_logo_icon_name(GtkAboutDialogHandle about, string icon_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_about_dialog_set_program_name(GtkAboutDialogHandle about, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_about_dialog_set_translator_credits(GtkAboutDialogHandle about, string translator_credits);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_about_dialog_set_version(GtkAboutDialogHandle about, string version);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_about_dialog_set_website(GtkAboutDialogHandle about, string website);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_about_dialog_set_website_label(GtkAboutDialogHandle about, string website_label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_about_dialog_set_wrap_license(GtkAboutDialogHandle about, bool wrap_license);

}
