namespace MentorLake.Gtk;

public class GtkCssProviderHandle : GObjectHandle, GtkStyleProviderHandle
{
	public static MentorLake.Gtk.GtkCssProviderHandle New()
	{
		return GtkCssProviderHandleExterns.gtk_css_provider_new();
	}

	public static MentorLake.Gtk.GtkCssProviderHandle GetDefault()
	{
		return GtkCssProviderHandleExterns.gtk_css_provider_get_default();
	}

	public static MentorLake.Gtk.GtkCssProviderHandle GetNamed(string name, string variant)
	{
		return GtkCssProviderHandleExterns.gtk_css_provider_get_named(name, variant);
	}

}
public static class GtkCssProviderHandleSignalExtensions
{

	public static IObservable<GtkCssProviderHandleSignalStructs.ParsingErrorSignal> Signal_ParsingError(this GtkCssProviderHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCssProviderHandleSignalStructs.ParsingErrorSignal> obs) =>
		{
			GtkCssProviderHandleSignalDelegates.parsing_error handler = ( MentorLake.Gtk.GtkCssProviderHandle self,  MentorLake.Gtk.GtkCssSectionHandle section,  MentorLake.GLib.GErrorHandle error,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCssProviderHandleSignalStructs.ParsingErrorSignal()
				{
					Self = self, Section = section, Error = error, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "parsing-error", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkCssProviderHandleSignalStructs
{

public struct ParsingErrorSignal
{
	public MentorLake.Gtk.GtkCssProviderHandle Self;
	public MentorLake.Gtk.GtkCssSectionHandle Section;
	public MentorLake.GLib.GErrorHandle Error;
	public IntPtr UserData;
}
}

public static class GtkCssProviderHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void parsing_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssProviderHandle>))] MentorLake.Gtk.GtkCssProviderHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssSectionHandle>))] MentorLake.Gtk.GtkCssSectionHandle section, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error, IntPtr user_data);

}


public static class GtkCssProviderHandleExtensions
{
	public static bool LoadFromData(this MentorLake.Gtk.GtkCssProviderHandle css_provider, byte[] data, UIntPtr length)
	{
		var externCallResult = GtkCssProviderHandleExterns.gtk_css_provider_load_from_data(css_provider, data, length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool LoadFromFile(this MentorLake.Gtk.GtkCssProviderHandle css_provider, MentorLake.Gio.GFileHandle file)
	{
		var externCallResult = GtkCssProviderHandleExterns.gtk_css_provider_load_from_file(css_provider, file, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool LoadFromPath(this MentorLake.Gtk.GtkCssProviderHandle css_provider, string path)
	{
		var externCallResult = GtkCssProviderHandleExterns.gtk_css_provider_load_from_path(css_provider, path, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T LoadFromResource<T>(this T css_provider, string resource_path) where T : GtkCssProviderHandle
	{
		GtkCssProviderHandleExterns.gtk_css_provider_load_from_resource(css_provider, resource_path);
		return css_provider;
	}

	public static string ToString(this MentorLake.Gtk.GtkCssProviderHandle provider)
	{
		return GtkCssProviderHandleExterns.gtk_css_provider_to_string(provider);
	}

}

internal class GtkCssProviderHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCssProviderHandle gtk_css_provider_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_css_provider_load_from_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssProviderHandle>))] MentorLake.Gtk.GtkCssProviderHandle css_provider, byte[] data, UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_css_provider_load_from_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssProviderHandle>))] MentorLake.Gtk.GtkCssProviderHandle css_provider, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_css_provider_load_from_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssProviderHandle>))] MentorLake.Gtk.GtkCssProviderHandle css_provider, string path, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_css_provider_load_from_resource([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssProviderHandle>))] MentorLake.Gtk.GtkCssProviderHandle css_provider, string resource_path);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_css_provider_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssProviderHandle>))] MentorLake.Gtk.GtkCssProviderHandle provider);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCssProviderHandle gtk_css_provider_get_default();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCssProviderHandle gtk_css_provider_get_named(string name, string variant);

}
