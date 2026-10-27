namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Handles storage of user content filters on disk.
/// </para>
/// <para>
/// The WebKitUserContentFilterStore provides the means to import and save
/// [JSON rule sets](https://webkit.org/blog/3476/content-blockers-first-look/),
/// which can be loaded later in an efficient manner. Once filters are stored,
/// the #WebKitUserContentFilter objects which represent them can be added to
/// a #WebKitUserContentManager with webkit_user_content_manager_add_filter().
/// </para>
/// <para>
/// JSON rule sets are imported using webkit_user_content_filter_store_save() and stored
/// on disk in an implementation defined format. The contents of a filter store must be
/// managed using the #WebKitUserContentFilterStore: a list of all the stored filters
/// can be obtained with webkit_user_content_filter_store_fetch_identifiers(),
/// webkit_user_content_filter_store_load() can be used to retrieve a previously saved
/// filter, and removed from the store with webkit_user_content_filter_store_remove().
/// </para>
/// </summary>

public class WebKitUserContentFilterStoreHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Create a new #WebKitUserContentFilterStore to manipulate filters stored at @storage_path.
/// </para>
/// <para>
/// The path must point to a local filesystem, and will be created if needed.
/// </para>
/// </summary>

/// <param name="storage_path">
/// path where data for filters will be stored on disk
/// </param>
/// <return>
/// a newly created #WebKitUserContentFilterStore
/// </return>

	public static MentorLake.WebKit2.WebKitUserContentFilterStoreHandle New(string storage_path)
	{
		return WebKitUserContentFilterStoreHandleExterns.webkit_user_content_filter_store_new(storage_path);
	}

}

public static class WebKitUserContentFilterStoreHandleExtensions
{
/// <summary>
/// <para>
/// Asynchronously retrieve a list of the identifiers for all the stored filters.
/// </para>
/// <para>
/// When the operation is finished, @callback will be invoked, which then can use
/// webkit_user_content_filter_store_fetch_identifiers_finish() to obtain the list of
/// filter identifiers.
/// </para>
/// </summary>

/// <param name="store">
/// a #WebKitUserContentFilterStore
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the removal is completed
/// </param>
/// <param name="user_data">
/// the data to pass to the callback function
/// </param>

	public static T FetchIdentifiers<T>(this T store, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitUserContentFilterStoreHandle
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentFilterStoreHandle)");
		WebKitUserContentFilterStoreHandleExterns.webkit_user_content_filter_store_fetch_identifiers(store, cancellable, callback, user_data);
		return store;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous fetch of the list of stored filters.
/// </para>
/// <para>
/// Finishes an asynchronous fetch of the list of identifiers for the stored filters previously
/// started with webkit_user_content_filter_store_fetch_identifiers().
/// </para>
/// </summary>

/// <param name="store">
/// a #WebKitUserContentFilterStore
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// a %NULL-terminated list of filter identifiers.
/// </return>

	public static string[] FetchIdentifiersFinish(this MentorLake.WebKit2.WebKitUserContentFilterStoreHandle store, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentFilterStoreHandle)");
		return WebKitUserContentFilterStoreHandleExterns.webkit_user_content_filter_store_fetch_identifiers_finish(store, result);
	}

/// <summary>
/// <para>
/// Gets the storage path for user content filters.
/// </para>
/// </summary>

/// <param name="store">
/// a #WebKitUserContentFilterStore
/// </param>
/// <return>
/// path, as a string.
/// </return>

	public static string GetPath(this MentorLake.WebKit2.WebKitUserContentFilterStoreHandle store)
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentFilterStoreHandle)");
		return WebKitUserContentFilterStoreHandleExterns.webkit_user_content_filter_store_get_path(store);
	}

/// <summary>
/// <para>
/// Asynchronously load a content filter given its @identifier.
/// </para>
/// <para>
/// The filter must have been
/// previously stored using webkit_user_content_filter_store_save().
/// </para>
/// <para>
/// When the operation is finished, @callback will be invoked, which then can use
/// webkit_user_content_filter_store_load_finish() to obtain the resulting filter.
/// </para>
/// </summary>

/// <param name="store">
/// a #WebKitUserContentFilterStore
/// </param>
/// <param name="identifier">
/// a filter identifier
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the load is completed
/// </param>
/// <param name="user_data">
/// the data to pass to the callback function
/// </param>

	public static T Load<T>(this T store, string identifier, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitUserContentFilterStoreHandle
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentFilterStoreHandle)");
		WebKitUserContentFilterStoreHandleExterns.webkit_user_content_filter_store_load(store, identifier, cancellable, callback, user_data);
		return store;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous filter load previously started with
/// webkit_user_content_filter_store_load().
/// </para>
/// </summary>

/// <param name="store">
/// a #WebKitUserContentFilterStore
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #WebKitUserContentFilter, or %NULL if the load failed
/// </return>

	public static MentorLake.WebKit2.WebKitUserContentFilterHandle LoadFinish(this MentorLake.WebKit2.WebKitUserContentFilterStoreHandle store, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentFilterStoreHandle)");
		var externCallResult = WebKitUserContentFilterStoreHandleExterns.webkit_user_content_filter_store_load_finish(store, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously remove a content filter given its @identifier.
/// </para>
/// <para>
/// When the operation is finished, @callback will be invoked, which then can use
/// webkit_user_content_filter_store_remove_finish() to check whether the removal was
/// successful.
/// </para>
/// </summary>

/// <param name="store">
/// a #WebKitUserContentFilterStore
/// </param>
/// <param name="identifier">
/// a filter identifier
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the removal is completed
/// </param>
/// <param name="user_data">
/// the data to pass to the callback function
/// </param>

	public static T Remove<T>(this T store, string identifier, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitUserContentFilterStoreHandle
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentFilterStoreHandle)");
		WebKitUserContentFilterStoreHandleExterns.webkit_user_content_filter_store_remove(store, identifier, cancellable, callback, user_data);
		return store;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous filter removal previously started with
/// webkit_user_content_filter_store_remove().
/// </para>
/// </summary>

/// <param name="store">
/// a #WebKitUserContentFilterStore
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// whether the removal was successful
/// </return>

	public static bool RemoveFinish(this MentorLake.WebKit2.WebKitUserContentFilterStoreHandle store, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentFilterStoreHandle)");
		var externCallResult = WebKitUserContentFilterStoreHandleExterns.webkit_user_content_filter_store_remove_finish(store, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously save a content filter from a set source rule.
/// </para>
/// <para>
/// Asynchronously save a content filter from a source rule set in the
/// [WebKit content extesions JSON format](https://webkit.org/blog/3476/content-blockers-first-look/).
/// </para>
/// <para>
/// The @identifier can be used afterwards to refer to the filter when using
/// webkit_user_content_filter_store_remove() and webkit_user_content_filter_store_load().
/// When the @identifier has been used in the past, the new filter source will replace
/// the one saved beforehand for the same identifier.
/// </para>
/// <para>
/// When the operation is finished, @callback will be invoked, which then can use
/// webkit_user_content_filter_store_save_finish() to obtain the resulting filter.
/// </para>
/// </summary>

/// <param name="store">
/// a #WebKitUserContentFilterStore
/// </param>
/// <param name="identifier">
/// a string used to identify the saved filter
/// </param>
/// <param name="source">
/// #GBytes containing the rule set in JSON format
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when saving is completed
/// </param>
/// <param name="user_data">
/// the data to pass to the callback function
/// </param>

	public static T Save<T>(this T store, string identifier, MentorLake.GLib.GBytesHandle source, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitUserContentFilterStoreHandle
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentFilterStoreHandle)");
		WebKitUserContentFilterStoreHandleExterns.webkit_user_content_filter_store_save(store, identifier, source, cancellable, callback, user_data);
		return store;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous filter save previously started with
/// webkit_user_content_filter_store_save().
/// </para>
/// </summary>

/// <param name="store">
/// a #WebKitUserContentFilterStore
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #WebKitUserContentFilter, or %NULL if saving failed
/// </return>

	public static MentorLake.WebKit2.WebKitUserContentFilterHandle SaveFinish(this MentorLake.WebKit2.WebKitUserContentFilterStoreHandle store, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentFilterStoreHandle)");
		var externCallResult = WebKitUserContentFilterStoreHandleExterns.webkit_user_content_filter_store_save_finish(store, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously save a content filter from the contents of a file.
/// </para>
/// <para>
/// Asynchronously save a content filter from the contents of a file, which must be
/// native to the platform, as checked by g_file_is_native(). See
/// webkit_user_content_filter_store_save() for more details.
/// </para>
/// <para>
/// When the operation is finished, @callback will be invoked, which then can use
/// webkit_user_content_filter_store_save_finish() to obtain the resulting filter.
/// </para>
/// </summary>

/// <param name="store">
/// a #WebKitUserContentFilterStore
/// </param>
/// <param name="identifier">
/// a string used to identify the saved filter
/// </param>
/// <param name="file">
/// a #GFile containing the rule set in JSON format
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when saving is completed
/// </param>
/// <param name="user_data">
/// the data to pass to the callback function
/// </param>

	public static T SaveFromFile<T>(this T store, string identifier, MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitUserContentFilterStoreHandle
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentFilterStoreHandle)");
		WebKitUserContentFilterStoreHandleExterns.webkit_user_content_filter_store_save_from_file(store, identifier, file, cancellable, callback, user_data);
		return store;
	}

/// <summary>
/// <para>
/// Finishes and asynchronous filter save previously started with
/// webkit_user_content_filter_store_save_from_file().
/// </para>
/// </summary>

/// <param name="store">
/// a #WebKitUserContentFilterStore
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #WebKitUserContentFilter, or %NULL if saving failed.
/// </return>

	public static MentorLake.WebKit2.WebKitUserContentFilterHandle SaveFromFileFinish(this MentorLake.WebKit2.WebKitUserContentFilterStoreHandle store, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentFilterStoreHandle)");
		var externCallResult = WebKitUserContentFilterStoreHandleExterns.webkit_user_content_filter_store_save_from_file_finish(store, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class WebKitUserContentFilterStoreHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentFilterStoreHandle>))]
	internal static extern MentorLake.WebKit2.WebKitUserContentFilterStoreHandle webkit_user_content_filter_store_new(string storage_path);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_user_content_filter_store_fetch_identifiers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentFilterStoreHandle>))] MentorLake.WebKit2.WebKitUserContentFilterStoreHandle store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] webkit_user_content_filter_store_fetch_identifiers_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentFilterStoreHandle>))] MentorLake.WebKit2.WebKitUserContentFilterStoreHandle store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_user_content_filter_store_get_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentFilterStoreHandle>))] MentorLake.WebKit2.WebKitUserContentFilterStoreHandle store);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_user_content_filter_store_load([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentFilterStoreHandle>))] MentorLake.WebKit2.WebKitUserContentFilterStoreHandle store, string identifier, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentFilterHandle>))]
	internal static extern MentorLake.WebKit2.WebKitUserContentFilterHandle webkit_user_content_filter_store_load_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentFilterStoreHandle>))] MentorLake.WebKit2.WebKitUserContentFilterStoreHandle store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_user_content_filter_store_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentFilterStoreHandle>))] MentorLake.WebKit2.WebKitUserContentFilterStoreHandle store, string identifier, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_user_content_filter_store_remove_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentFilterStoreHandle>))] MentorLake.WebKit2.WebKitUserContentFilterStoreHandle store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_user_content_filter_store_save([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentFilterStoreHandle>))] MentorLake.WebKit2.WebKitUserContentFilterStoreHandle store, string identifier, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentFilterHandle>))]
	internal static extern MentorLake.WebKit2.WebKitUserContentFilterHandle webkit_user_content_filter_store_save_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentFilterStoreHandle>))] MentorLake.WebKit2.WebKitUserContentFilterStoreHandle store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_user_content_filter_store_save_from_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentFilterStoreHandle>))] MentorLake.WebKit2.WebKitUserContentFilterStoreHandle store, string identifier, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentFilterHandle>))]
	internal static extern MentorLake.WebKit2.WebKitUserContentFilterHandle webkit_user_content_filter_store_save_from_file_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentFilterStoreHandle>))] MentorLake.WebKit2.WebKitUserContentFilterStoreHandle store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

}
