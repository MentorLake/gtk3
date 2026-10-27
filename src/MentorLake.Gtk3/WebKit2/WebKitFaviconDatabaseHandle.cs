namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Provides access to the icons associated with web sites.
/// </para>
/// <para>
/// WebKit will automatically look for available icons in &amp;lt;link&amp;gt;
/// elements on opened pages as well as an existing favicon.ico and
/// load the images found into a memory cache if possible. That cache
/// is frozen to an on-disk database for persistence.
/// </para>
/// <para>
/// If #WebKitSettings:enable-private-browsing is %TRUE, new icons
/// won&apos;t be added to the on-disk database and no existing icons will
/// be deleted from it. Nevertheless, WebKit will still store them in
/// the in-memory cache during the current execution.
/// </para>
/// </summary>

public class WebKitFaviconDatabaseHandle : GObjectHandle
{
}
public static class WebKitFaviconDatabaseHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when the favicon URI of @page_uri has
/// been changed to @favicon_uri in the database. You can connect
/// to this signal and call webkit_favicon_database_get_favicon()
/// to get the favicon. If you are interested in the favicon of a
/// #WebKitWebView it&apos;s easier to use the #WebKitWebView:favicon
/// property. See webkit_web_view_get_favicon() for more details.
/// </para>
/// </summary>

	public static IObservable<WebKitFaviconDatabaseHandleSignalStructs.FaviconChangedSignal> Signal_FaviconChanged(this WebKitFaviconDatabaseHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitFaviconDatabaseHandleSignalStructs.FaviconChangedSignal> obs) =>
		{
			WebKitFaviconDatabaseHandleSignalDelegates.favicon_changed handler = ( MentorLake.WebKit2.WebKitFaviconDatabaseHandle self,  string page_uri,  string favicon_uri,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitFaviconDatabaseHandleSignalStructs.FaviconChangedSignal()
				{
					Self = self, PageUri = page_uri, FaviconUri = favicon_uri, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "favicon-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class WebKitFaviconDatabaseHandleSignalStructs
{

public class FaviconChangedSignal
{

	public MentorLake.WebKit2.WebKitFaviconDatabaseHandle Self;
/// <summary>
/// <para>
/// the URI of the Web page containing the icon
/// </para>
/// </summary>

	public string PageUri;
/// <summary>
/// <para>
/// the URI of the favicon
/// </para>
/// </summary>

	public string FaviconUri;

	public IntPtr UserData;
}
}

public static class WebKitFaviconDatabaseHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when the favicon URI of @page_uri has
/// been changed to @favicon_uri in the database. You can connect
/// to this signal and call webkit_favicon_database_get_favicon()
/// to get the favicon. If you are interested in the favicon of a
/// #WebKitWebView it&apos;s easier to use the #WebKitWebView:favicon
/// property. See webkit_web_view_get_favicon() for more details.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="page_uri">
/// the URI of the Web page containing the icon
/// </param>
/// <param name="favicon_uri">
/// the URI of the favicon
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void favicon_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFaviconDatabaseHandle>))] MentorLake.WebKit2.WebKitFaviconDatabaseHandle self, string page_uri, string favicon_uri, IntPtr user_data);

}


public static class WebKitFaviconDatabaseHandleExtensions
{
/// <summary>
/// <para>
/// Clears all icons from the database.
/// </para>
/// </summary>

/// <param name="database">
/// a #WebKitFaviconDatabase
/// </param>

	public static T Clear<T>(this T database) where T : WebKitFaviconDatabaseHandle
	{
		if (database.IsInvalid) throw new Exception("Invalid handle (WebKitFaviconDatabaseHandle)");
		WebKitFaviconDatabaseHandleExterns.webkit_favicon_database_clear(database);
		return database;
	}

/// <summary>
/// <para>
/// Asynchronously obtains a favicon image.
/// </para>
/// <para>
/// Asynchronously obtains an image of the favicon for the
/// given page URI. It returns the cached icon if it&apos;s in the database
/// asynchronously waiting for the icon to be read from the database.
/// </para>
/// <para>
/// This is an asynchronous method. When the operation is finished, callback will
/// be invoked. You can then call webkit_favicon_database_get_favicon_finish()
/// to get the result of the operation.
/// </para>
/// </summary>

/// <param name="database">
/// a #WebKitFaviconDatabase
/// </param>
/// <param name="page_uri">
/// URI of the page for which we want to retrieve the favicon
/// </param>
/// <param name="cancellable">
/// A #GCancellable or %NULL.
/// </param>
/// <param name="callback">
/// A #GAsyncReadyCallback to call when the request is
///            satisfied or %NULL if you don&apos;t care about the result.
/// </param>
/// <param name="user_data">
/// The data to pass to @callback.
/// </param>

	public static T GetFavicon<T>(this T database, string page_uri, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitFaviconDatabaseHandle
	{
		if (database.IsInvalid) throw new Exception("Invalid handle (WebKitFaviconDatabaseHandle)");
		WebKitFaviconDatabaseHandleExterns.webkit_favicon_database_get_favicon(database, page_uri, cancellable, callback, user_data);
		return database;
	}

/// <summary>
/// <para>
/// Finishes an operation started with webkit_favicon_database_get_favicon().
/// </para>
/// </summary>

/// <param name="database">
/// a #WebKitFaviconDatabase
/// </param>
/// <param name="result">
/// A #GAsyncResult obtained from the #GAsyncReadyCallback passed to webkit_favicon_database_get_favicon()
/// </param>
/// <return>
/// a new favicon image, or %NULL in case of error.
/// </return>

	public static MentorLake.cairo.cairo_surface_tHandle GetFaviconFinish(this MentorLake.WebKit2.WebKitFaviconDatabaseHandle database, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (database.IsInvalid) throw new Exception("Invalid handle (WebKitFaviconDatabaseHandle)");
		var externCallResult = WebKitFaviconDatabaseHandleExterns.webkit_favicon_database_get_favicon_finish(database, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Obtains the URI of the favicon for the given @page_uri.
/// </para>
/// </summary>

/// <param name="database">
/// a #WebKitFaviconDatabase
/// </param>
/// <param name="page_uri">
/// URI of the page containing the icon
/// </param>
/// <return>
/// a newly allocated URI for the favicon, or %NULL if the
/// database doesn&apos;t have a favicon for @page_uri.
/// </return>

	public static string GetFaviconUri(this MentorLake.WebKit2.WebKitFaviconDatabaseHandle database, string page_uri)
	{
		if (database.IsInvalid) throw new Exception("Invalid handle (WebKitFaviconDatabaseHandle)");
		return WebKitFaviconDatabaseHandleExterns.webkit_favicon_database_get_favicon_uri(database, page_uri);
	}

}

internal class WebKitFaviconDatabaseHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_favicon_database_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFaviconDatabaseHandle>))] MentorLake.WebKit2.WebKitFaviconDatabaseHandle database);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_favicon_database_get_favicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFaviconDatabaseHandle>))] MentorLake.WebKit2.WebKitFaviconDatabaseHandle database, string page_uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle webkit_favicon_database_get_favicon_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFaviconDatabaseHandle>))] MentorLake.WebKit2.WebKitFaviconDatabaseHandle database, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_favicon_database_get_favicon_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFaviconDatabaseHandle>))] MentorLake.WebKit2.WebKitFaviconDatabaseHandle database, string page_uri);

}
