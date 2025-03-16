namespace MentorLake.Gtk;

public class GtkAboutDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkAboutDialogHandle New()
	{
		return GtkAboutDialogHandleExterns.gtk_about_dialog_new();
	}

}
public static class GtkAboutDialogHandleSignalExtensions
{

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

public struct ActivateLinkSignal
{
	public MentorLake.Gtk.GtkAboutDialogHandle Self;
	public string Uri;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkAboutDialogHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool activate_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle self, string uri, IntPtr user_data);

}


public static class GtkAboutDialogHandleExtensions
{
	public static T AddCreditSection<T>(this T about, string section_name, string[] people) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogHandleExterns.gtk_about_dialog_add_credit_section(about, section_name, people);
		return about;
	}

	public static string[] GetArtists(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_artists(about);
	}

	public static string[] GetAuthors(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_authors(about);
	}

	public static string GetComments(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_comments(about);
	}

	public static string GetCopyright(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_copyright(about);
	}

	public static string[] GetDocumenters(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_documenters(about);
	}

	public static string GetLicense(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_license(about);
	}

	public static MentorLake.Gtk.GtkLicense GetLicenseType(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_license_type(about);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetLogo(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_logo(about);
	}

	public static string GetLogoIconName(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_logo_icon_name(about);
	}

	public static string GetProgramName(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_program_name(about);
	}

	public static string GetTranslatorCredits(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_translator_credits(about);
	}

	public static string GetVersion(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_version(about);
	}

	public static string GetWebsite(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_website(about);
	}

	public static string GetWebsiteLabel(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_website_label(about);
	}

	public static bool GetWrapLicense(this MentorLake.Gtk.GtkAboutDialogHandle about)
	{
		return GtkAboutDialogHandleExterns.gtk_about_dialog_get_wrap_license(about);
	}

	public static T SetArtists<T>(this T about, string[] artists) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_artists(about, artists);
		return about;
	}

	public static T SetAuthors<T>(this T about, string[] authors) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_authors(about, authors);
		return about;
	}

	public static T SetComments<T>(this T about, string comments) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_comments(about, comments);
		return about;
	}

	public static T SetCopyright<T>(this T about, string copyright) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_copyright(about, copyright);
		return about;
	}

	public static T SetDocumenters<T>(this T about, string[] documenters) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_documenters(about, documenters);
		return about;
	}

	public static T SetLicense<T>(this T about, string license) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_license(about, license);
		return about;
	}

	public static T SetLicenseType<T>(this T about, MentorLake.Gtk.GtkLicense license_type) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_license_type(about, license_type);
		return about;
	}

	public static T SetLogo<T>(this T about, MentorLake.GdkPixbuf.GdkPixbufHandle logo) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_logo(about, logo);
		return about;
	}

	public static T SetLogoIconName<T>(this T about, string icon_name) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_logo_icon_name(about, icon_name);
		return about;
	}

	public static T SetProgramName<T>(this T about, string name) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_program_name(about, name);
		return about;
	}

	public static T SetTranslatorCredits<T>(this T about, string translator_credits) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_translator_credits(about, translator_credits);
		return about;
	}

	public static T SetVersion<T>(this T about, string version) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_version(about, version);
		return about;
	}

	public static T SetWebsite<T>(this T about, string website) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_website(about, website);
		return about;
	}

	public static T SetWebsiteLabel<T>(this T about, string website_label) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_website_label(about, website_label);
		return about;
	}

	public static T SetWrapLicense<T>(this T about, bool wrap_license) where T : GtkAboutDialogHandle
	{
		GtkAboutDialogHandleExterns.gtk_about_dialog_set_wrap_license(about, wrap_license);
		return about;
	}

}

internal class GtkAboutDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAboutDialogHandle gtk_about_dialog_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_about_dialog_add_credit_section([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about, string section_name, string[] people);

	[DllImport(GtkLibrary.Name)]
	internal static extern string[] gtk_about_dialog_get_artists([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about);

	[DllImport(GtkLibrary.Name)]
	internal static extern string[] gtk_about_dialog_get_authors([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_about_dialog_get_comments([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_about_dialog_get_copyright([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about);

	[DllImport(GtkLibrary.Name)]
	internal static extern string[] gtk_about_dialog_get_documenters([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_about_dialog_get_license([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkLicense gtk_about_dialog_get_license_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAboutDialogHandle>))] MentorLake.Gtk.GtkAboutDialogHandle about);

	[DllImport(GtkLibrary.Name)]
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
