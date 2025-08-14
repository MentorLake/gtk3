namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkCssProvider is an object implementing the #GtkStyleProvider interface.
/// It is able to parse [CSS-like][css-overview] input in order to style widgets.
/// </para>
/// <para>
/// An application can make GTK+ parse a specific CSS style sheet by calling
/// gtk_css_provider_load_from_file() or gtk_css_provider_load_from_resource()
/// and adding the provider with gtk_style_context_add_provider() or
/// gtk_style_context_add_provider_for_screen().
/// </para>
/// <para>
/// In addition, certain files will be read when GTK+ is initialized. First, the
/// file `$XDG_CONFIG_HOME/gtk-3.0/gtk.css` is loaded if it exists. Then, GTK+
/// loads the first existing file among
/// `XDG_DATA_HOME/themes/THEME/gtk-VERSION/gtk.css`,
/// `$HOME/.themes/THEME/gtk-VERSION/gtk.css`,
/// `$XDG_DATA_DIRS/themes/THEME/gtk-VERSION/gtk.css` and
/// `DATADIR/share/themes/THEME/gtk-VERSION/gtk.css`, where `THEME` is the name of
/// the current theme (see the #GtkSettings:gtk-theme-name setting), `DATADIR`
/// is the prefix configured when GTK+ was compiled (unless overridden by the
/// `GTK_DATA_PREFIX` environment variable), and `VERSION` is the GTK+ version number.
/// If no file is found for the current version, GTK+ tries older versions all the
/// way back to 3.0.
/// </para>
/// <para>
/// In the same way, GTK+ tries to load a gtk-keys.css file for the current
/// key theme, as defined by #GtkSettings:gtk-key-theme-name.
/// </para>
/// </summary>

public class GtkCssProviderHandle : GObjectHandle, GtkStyleProviderHandle
{
/// <summary>
/// <para>
/// Returns a newly created #GtkCssProvider.
/// </para>
/// </summary>

/// <return>
/// A new #GtkCssProvider
/// </return>

	public static MentorLake.Gtk.GtkCssProviderHandle New()
	{
		return GtkCssProviderHandleExterns.gtk_css_provider_new();
	}

/// <summary>
/// <para>
/// Returns the provider containing the style settings used as a
/// fallback for all widgets.
/// </para>
/// </summary>

/// <return>
/// The provider used for fallback styling.
///          This memory is owned by GTK+, and you must not free it.
/// </return>

	public static MentorLake.Gtk.GtkCssProviderHandle GetDefault()
	{
		return GtkCssProviderHandleExterns.gtk_css_provider_get_default();
	}

/// <summary>
/// <para>
/// Loads a theme from the usual theme paths
/// </para>
/// </summary>

/// <param name="name">
/// A theme name
/// </param>
/// <param name="variant">
/// variant to load, for example, "dark", or
///     %NULL for the default
/// </param>
/// <return>
/// a #GtkCssProvider with the theme loaded.
///     This memory is owned by GTK+, and you must not free it.
/// </return>

	public static MentorLake.Gtk.GtkCssProviderHandle GetNamed(string name, string variant)
	{
		return GtkCssProviderHandleExterns.gtk_css_provider_get_named(name, variant);
	}

}
public static class GtkCssProviderHandleSignalExtensions
{
/// <summary>
/// <para>
/// Signals that a parsing error occurred. the @path, @line and @position
/// describe the actual location of the error as accurately as possible.
/// </para>
/// <para>
/// Parsing errors are never fatal, so the parsing will resume after
/// the error. Errors may however cause parts of the given
/// data or even all of it to not be parsed at all. So it is a useful idea
/// to check that the parsing succeeds by connecting to this signal.
/// </para>
/// <para>
/// Note that this signal may be emitted at any time as the css provider
/// may opt to defer parsing parts or all of the input to a later time
/// than when a loading function was called.
/// </para>
/// </summary>

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

public class ParsingErrorSignal
{

	public MentorLake.Gtk.GtkCssProviderHandle Self;
/// <summary>
/// <para>
/// section the error happened in
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkCssSectionHandle Section;
/// <summary>
/// <para>
/// The parsing error
/// </para>
/// </summary>

	public MentorLake.GLib.GErrorHandle Error;

	public IntPtr UserData;
}
}

public static class GtkCssProviderHandleSignalDelegates
{

/// <summary>
/// <para>
/// Signals that a parsing error occurred. the @path, @line and @position
/// describe the actual location of the error as accurately as possible.
/// </para>
/// <para>
/// Parsing errors are never fatal, so the parsing will resume after
/// the error. Errors may however cause parts of the given
/// data or even all of it to not be parsed at all. So it is a useful idea
/// to check that the parsing succeeds by connecting to this signal.
/// </para>
/// <para>
/// Note that this signal may be emitted at any time as the css provider
/// may opt to defer parsing parts or all of the input to a later time
/// than when a loading function was called.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="section">
/// section the error happened in
/// </param>
/// <param name="error">
/// The parsing error
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void parsing_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssProviderHandle>))] MentorLake.Gtk.GtkCssProviderHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssSectionHandle>))] MentorLake.Gtk.GtkCssSectionHandle section, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error, IntPtr user_data);

}


public static class GtkCssProviderHandleExtensions
{
/// <summary>
/// <para>
/// Loads @data into @css_provider, and by doing so clears any previously loaded
/// information.
/// </para>
/// </summary>

/// <param name="css_provider">
/// a #GtkCssProvider
/// </param>
/// <param name="data">
/// CSS data loaded in memory
/// </param>
/// <param name="length">
/// the length of @data in bytes, or -1 for NUL terminated strings. If
///   @length is not -1, the code will assume it is not NUL terminated and will
///   potentially do a copy.
/// </param>
/// <return>
/// %TRUE. The return value is deprecated and %FALSE will only be
///     returned for backwards compatibility reasons if an @error is not
///     %NULL and a loading error occurred. To track errors while loading
///     CSS, connect to the #GtkCssProvider::parsing-error signal.
/// </return>

	public static bool LoadFromData(this MentorLake.Gtk.GtkCssProviderHandle css_provider, byte[] data, UIntPtr length)
	{
		if (css_provider.IsInvalid) throw new Exception("Invalid handle (GtkCssProviderHandle)");
		var externCallResult = GtkCssProviderHandleExterns.gtk_css_provider_load_from_data(css_provider, data, length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Loads the data contained in @file into @css_provider, making it
/// clear any previously loaded information.
/// </para>
/// </summary>

/// <param name="css_provider">
/// a #GtkCssProvider
/// </param>
/// <param name="file">
/// #GFile pointing to a file to load
/// </param>
/// <return>
/// %TRUE. The return value is deprecated and %FALSE will only be
///     returned for backwards compatibility reasons if an @error is not
///     %NULL and a loading error occurred. To track errors while loading
///     CSS, connect to the #GtkCssProvider::parsing-error signal.
/// </return>

	public static bool LoadFromFile(this MentorLake.Gtk.GtkCssProviderHandle css_provider, MentorLake.Gio.GFileHandle file)
	{
		if (css_provider.IsInvalid) throw new Exception("Invalid handle (GtkCssProviderHandle)");
		var externCallResult = GtkCssProviderHandleExterns.gtk_css_provider_load_from_file(css_provider, file, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Loads the data contained in @path into @css_provider, making it clear
/// any previously loaded information.
/// </para>
/// </summary>

/// <param name="css_provider">
/// a #GtkCssProvider
/// </param>
/// <param name="path">
/// the path of a filename to load, in the GLib filename encoding
/// </param>
/// <return>
/// %TRUE. The return value is deprecated and %FALSE will only be
///     returned for backwards compatibility reasons if an @error is not
///     %NULL and a loading error occurred. To track errors while loading
///     CSS, connect to the #GtkCssProvider::parsing-error signal.
/// </return>

	public static bool LoadFromPath(this MentorLake.Gtk.GtkCssProviderHandle css_provider, string path)
	{
		if (css_provider.IsInvalid) throw new Exception("Invalid handle (GtkCssProviderHandle)");
		var externCallResult = GtkCssProviderHandleExterns.gtk_css_provider_load_from_path(css_provider, path, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Loads the data contained in the resource at @resource_path into
/// the #GtkCssProvider, clearing any previously loaded information.
/// </para>
/// <para>
/// To track errors while loading CSS, connect to the
/// #GtkCssProvider::parsing-error signal.
/// </para>
/// </summary>

/// <param name="css_provider">
/// a #GtkCssProvider
/// </param>
/// <param name="resource_path">
/// a #GResource resource path
/// </param>

	public static T LoadFromResource<T>(this T css_provider, string resource_path) where T : GtkCssProviderHandle
	{
		if (css_provider.IsInvalid) throw new Exception("Invalid handle (GtkCssProviderHandle)");
		GtkCssProviderHandleExterns.gtk_css_provider_load_from_resource(css_provider, resource_path);
		return css_provider;
	}

/// <summary>
/// <para>
/// Converts the @provider into a string representation in CSS
/// format.
/// </para>
/// <para>
/// Using gtk_css_provider_load_from_data() with the return value
/// from this function on a new provider created with
/// gtk_css_provider_new() will basically create a duplicate of
/// this @provider.
/// </para>
/// </summary>

/// <param name="provider">
/// the provider to write to a string
/// </param>
/// <return>
/// a new string representing the @provider.
/// </return>

	public static string ToString(this MentorLake.Gtk.GtkCssProviderHandle provider)
	{
		if (provider.IsInvalid) throw new Exception("Invalid handle (GtkCssProviderHandle)");
		return GtkCssProviderHandleExterns.gtk_css_provider_to_string(provider);
	}

}

internal class GtkCssProviderHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCssProviderHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssProviderHandle>))]
	internal static extern MentorLake.Gtk.GtkCssProviderHandle gtk_css_provider_get_default();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssProviderHandle>))]
	internal static extern MentorLake.Gtk.GtkCssProviderHandle gtk_css_provider_get_named(string name, string variant);

}
