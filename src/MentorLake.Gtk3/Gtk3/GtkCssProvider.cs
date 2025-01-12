namespace MentorLake.Gtk3.Gtk3;

public class GtkCssProviderHandle : GObjectHandle, GtkStyleProviderHandle
{
	public static GtkCssProviderHandle New()
	{
		return GtkCssProviderExterns.gtk_css_provider_new();
	}

	public static GtkCssProviderHandle GetDefault()
	{
		return GtkCssProviderExterns.gtk_css_provider_get_default();
	}

	public static GtkCssProviderHandle GetNamed(string name, string variant)
	{
		return GtkCssProviderExterns.gtk_css_provider_get_named(name, variant);
	}

}

public static class GtkCssProviderSignalExtensions
{

	public static IObservable<GtkCssProviderSignalStructs.ParsingErrorSignal> Signal_ParsingError(this GtkCssProviderHandle instance)
	{
		return Observable.Create((IObserver<GtkCssProviderSignalStructs.ParsingErrorSignal> obs) =>
		{
			GtkCssProviderSignalDelegates.parsing_error handler = (GtkCssProviderHandle self, GtkCssSectionHandle section, GErrorHandle error, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCssProviderSignalStructs.ParsingErrorSignal()
				{
					Self = self, Section = section, Error = error, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "parsing_error", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkCssProviderSignalStructs
{

public struct ParsingErrorSignal
{
	public GtkCssProviderHandle Self;
	public GtkCssSectionHandle Section;
	public GErrorHandle Error;
	public IntPtr UserData;
}
}

public static class GtkCssProviderSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void parsing_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCssProviderHandle>))] GtkCssProviderHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCssSectionHandle>))] GtkCssSectionHandle section, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GErrorHandle>))] GErrorHandle error, IntPtr user_data);

}


public static class GtkCssProviderHandleExtensions
{
	public static bool LoadFromData(this GtkCssProviderHandle css_provider, string data, UIntPtr length, out GErrorHandle error)
	{
		return GtkCssProviderExterns.gtk_css_provider_load_from_data(css_provider, data, length, out error);
	}

	public static bool LoadFromFile(this GtkCssProviderHandle css_provider, GFileHandle file, out GErrorHandle error)
	{
		return GtkCssProviderExterns.gtk_css_provider_load_from_file(css_provider, file, out error);
	}

	public static bool LoadFromPath(this GtkCssProviderHandle css_provider, string path, out GErrorHandle error)
	{
		return GtkCssProviderExterns.gtk_css_provider_load_from_path(css_provider, path, out error);
	}

	public static GtkCssProviderHandle LoadFromResource(this GtkCssProviderHandle css_provider, string resource_path)
	{
		GtkCssProviderExterns.gtk_css_provider_load_from_resource(css_provider, resource_path);
		return css_provider;
	}

	public static string ToString(this GtkCssProviderHandle provider)
	{
		return GtkCssProviderExterns.gtk_css_provider_to_string(provider);
	}

}

internal class GtkCssProviderExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCssProviderHandle gtk_css_provider_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_css_provider_load_from_data(GtkCssProviderHandle css_provider, string data, UIntPtr length, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_css_provider_load_from_file(GtkCssProviderHandle css_provider, GFileHandle file, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_css_provider_load_from_path(GtkCssProviderHandle css_provider, string path, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_css_provider_load_from_resource(GtkCssProviderHandle css_provider, string resource_path);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_css_provider_to_string(GtkCssProviderHandle provider);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCssProviderHandle gtk_css_provider_get_default();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCssProviderHandle gtk_css_provider_get_named(string name, string variant);

}
