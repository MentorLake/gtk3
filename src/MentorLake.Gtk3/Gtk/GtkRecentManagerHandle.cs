namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkRecentManager provides a facility for adding, removing and
/// looking up recently used files. Each recently used file is
/// identified by its URI, and has meta-data associated to it, like
/// the names and command lines of the applications that have
/// registered it, the number of time each application has registered
/// the same file, the mime type of the file and whether the file
/// should be displayed only by the applications that have
/// registered it.
/// </para>
/// <para>
/// The recently used files list is per user.
/// </para>
/// <para>
/// The #GtkRecentManager acts like a database of all the recently
/// used files. You can create new #GtkRecentManager objects, but
/// it is more efficient to use the default manager created by GTK+.
/// </para>
/// <para>
/// Adding a new recently used file is as simple as:
/// </para>
/// <code>
/// GtkRecentManager *manager;
/// GtkRecentManager *manager;
/// 
/// manager = gtk_recent_manager_get_default ();
/// gtk_recent_manager_add_item (manager, file_uri);
/// </code>
/// <para>
/// The #GtkRecentManager will try to gather all the needed information
/// from the file itself through GIO.
/// </para>
/// <para>
/// Looking up the meta-data associated with a recently used file
/// given its URI requires calling gtk_recent_manager_lookup_item():
/// </para>
/// <code>
/// GtkRecentManager *manager;
/// GtkRecentManager *manager;
/// GtkRecentInfo *info;
/// GError *error = NULL;
/// 
/// manager = gtk_recent_manager_get_default ();
/// info = gtk_recent_manager_lookup_item (manager, file_uri, &amp;error);
/// if (error)
///   {
///     g_warning (&quot;Could not find the file: %s&quot;, error-&amp;gt;message);
///     g_error_free (error);
///   }
/// else
///  {
///    // Use the info object
///    gtk_recent_info_unref (info);
///  }
/// </code>
/// <para>
/// In order to retrieve the list of recently used files, you can use
/// gtk_recent_manager_get_items(), which returns a list of #GtkRecentInfo-structs.
/// </para>
/// <para>
/// A #GtkRecentManager is the model used to populate the contents of
/// one, or more #GtkRecentChooser implementations.
/// </para>
/// <para>
/// Note that the maximum age of the recently used files list is
/// controllable through the #GtkSettings:gtk-recent-files-max-age
/// property.
/// </para>
/// <para>
/// Recently used files are supported since GTK+ 2.10.
/// </para>
/// </summary>

public class GtkRecentManagerHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new recent manager object. Recent manager objects are used to
/// handle the list of recently used resources. A #GtkRecentManager object
/// monitors the recently used resources list, and emits the “changed” signal
/// each time something inside the list changes.
/// </para>
/// <para>
/// #GtkRecentManager objects are expensive: be sure to create them only when
/// needed. You should use gtk_recent_manager_get_default() instead.
/// </para>
/// </summary>

/// <return>
/// A newly created #GtkRecentManager object
/// </return>

	public static MentorLake.Gtk.GtkRecentManagerHandle New()
	{
		return GtkRecentManagerHandleExterns.gtk_recent_manager_new();
	}

/// <summary>
/// <para>
/// Gets a unique instance of #GtkRecentManager, that you can share
/// in your application without caring about memory management.
/// </para>
/// </summary>

/// <return>
/// A unique #GtkRecentManager. Do not ref or
///   unref it.
/// </return>

	public static MentorLake.Gtk.GtkRecentManagerHandle GetDefault()
	{
		return GtkRecentManagerHandleExterns.gtk_recent_manager_get_default();
	}

}
public static class GtkRecentManagerHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when the current recently used resources manager changes
/// its contents, either by calling gtk_recent_manager_add_item() or
/// by another application.
/// </para>
/// </summary>

	public static IObservable<GtkRecentManagerHandleSignalStructs.ChangedSignal> Signal_Changed(this GtkRecentManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRecentManagerHandleSignalStructs.ChangedSignal> obs) =>
		{
			GtkRecentManagerHandleSignalDelegates.changed handler = ( MentorLake.Gtk.GtkRecentManagerHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRecentManagerHandleSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkRecentManagerHandleSignalStructs
{

public class ChangedSignal
{

	public MentorLake.Gtk.GtkRecentManagerHandle Self;

	public IntPtr UserData;
}
}

public static class GtkRecentManagerHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when the current recently used resources manager changes
/// its contents, either by calling gtk_recent_manager_add_item() or
/// by another application.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle self, IntPtr user_data);

}


public static class GtkRecentManagerHandleExtensions
{
/// <summary>
/// <para>
/// Adds a new resource, pointed by @uri, into the recently used
/// resources list, using the metadata specified inside the
/// #GtkRecentData-struct passed in @recent_data.
/// </para>
/// <para>
/// The passed URI will be used to identify this resource inside the
/// list.
/// </para>
/// <para>
/// In order to register the new recently used resource, metadata about
/// the resource must be passed as well as the URI; the metadata is
/// stored in a #GtkRecentData-struct, which must contain the MIME
/// type of the resource pointed by the URI; the name of the application
/// that is registering the item, and a command line to be used when
/// launching the item.
/// </para>
/// <para>
/// Optionally, a #GtkRecentData-struct might contain a UTF-8 string
/// to be used when viewing the item instead of the last component of
/// the URI; a short description of the item; whether the item should
/// be considered private - that is, should be displayed only by the
/// applications that have registered it.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkRecentManager
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="recent_data">
/// metadata of the resource
/// </param>
/// <return>
/// %TRUE if the new item was successfully added to the
///     recently used resources list, %FALSE otherwise
/// </return>

	public static bool AddFull(this MentorLake.Gtk.GtkRecentManagerHandle manager, string uri, MentorLake.Gtk.GtkRecentDataHandle recent_data)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkRecentManagerHandle)");
		return GtkRecentManagerHandleExterns.gtk_recent_manager_add_full(manager, uri, recent_data);
	}

/// <summary>
/// <para>
/// Adds a new resource, pointed by @uri, into the recently used
/// resources list.
/// </para>
/// <para>
/// This function automatically retrieves some of the needed
/// metadata and setting other metadata to common default values;
/// it then feeds the data to gtk_recent_manager_add_full().
/// </para>
/// <para>
/// See gtk_recent_manager_add_full() if you want to explicitly
/// define the metadata for the resource pointed by @uri.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkRecentManager
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <return>
/// %TRUE if the new item was successfully added
///   to the recently used resources list
/// </return>

	public static bool AddItem(this MentorLake.Gtk.GtkRecentManagerHandle manager, string uri)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkRecentManagerHandle)");
		return GtkRecentManagerHandleExterns.gtk_recent_manager_add_item(manager, uri);
	}

/// <summary>
/// <para>
/// Gets the list of recently used resources.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkRecentManager
/// </param>
/// <return>
/// a list of
///   newly allocated #GtkRecentInfo objects. Use
///   gtk_recent_info_unref() on each item inside the list, and then
///   free the list itself using g_list_free().
/// </return>

	public static MentorLake.GLib.GListHandle GetItems(this MentorLake.Gtk.GtkRecentManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkRecentManagerHandle)");
		return GtkRecentManagerHandleExterns.gtk_recent_manager_get_items(manager);
	}

/// <summary>
/// <para>
/// Checks whether there is a recently used resource registered
/// with @uri inside the recent manager.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkRecentManager
/// </param>
/// <param name="uri">
/// a URI
/// </param>
/// <return>
/// %TRUE if the resource was found, %FALSE otherwise
/// </return>

	public static bool HasItem(this MentorLake.Gtk.GtkRecentManagerHandle manager, string uri)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkRecentManagerHandle)");
		return GtkRecentManagerHandleExterns.gtk_recent_manager_has_item(manager, uri);
	}

/// <summary>
/// <para>
/// Searches for a URI inside the recently used resources list, and
/// returns a #GtkRecentInfo-struct containing informations about the resource
/// like its MIME type, or its display name.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkRecentManager
/// </param>
/// <param name="uri">
/// a URI
/// </param>
/// <return>
/// a #GtkRecentInfo-struct containing information
///   about the resource pointed by @uri, or %NULL if the URI was
///   not registered in the recently used resources list. Free with
///   gtk_recent_info_unref().
/// </return>

	public static MentorLake.Gtk.GtkRecentInfoHandle LookupItem(this MentorLake.Gtk.GtkRecentManagerHandle manager, string uri)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkRecentManagerHandle)");
		var externCallResult = GtkRecentManagerHandleExterns.gtk_recent_manager_lookup_item(manager, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Changes the location of a recently used resource from @uri to @new_uri.
/// </para>
/// <para>
/// Please note that this function will not affect the resource pointed
/// by the URIs, but only the URI used in the recently used resources list.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkRecentManager
/// </param>
/// <param name="uri">
/// the URI of a recently used resource
/// </param>
/// <param name="new_uri">
/// the new URI of the recently used resource, or
///    %NULL to remove the item pointed by @uri in the list
/// </param>
/// <return>
/// %TRUE on success
/// </return>

	public static bool MoveItem(this MentorLake.Gtk.GtkRecentManagerHandle manager, string uri, string new_uri)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkRecentManagerHandle)");
		var externCallResult = GtkRecentManagerHandleExterns.gtk_recent_manager_move_item(manager, uri, new_uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Purges every item from the recently used resources list.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkRecentManager
/// </param>
/// <return>
/// the number of items that have been removed from the
///   recently used resources list
/// </return>

	public static int PurgeItems(this MentorLake.Gtk.GtkRecentManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkRecentManagerHandle)");
		var externCallResult = GtkRecentManagerHandleExterns.gtk_recent_manager_purge_items(manager, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Removes a resource pointed by @uri from the recently used resources
/// list handled by a recent manager.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkRecentManager
/// </param>
/// <param name="uri">
/// the URI of the item you wish to remove
/// </param>
/// <return>
/// %TRUE if the item pointed by @uri has been successfully
///   removed by the recently used resources list, and %FALSE otherwise
/// </return>

	public static bool RemoveItem(this MentorLake.Gtk.GtkRecentManagerHandle manager, string uri)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkRecentManagerHandle)");
		var externCallResult = GtkRecentManagerHandleExterns.gtk_recent_manager_remove_item(manager, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GtkRecentManagerHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))]
	internal static extern MentorLake.Gtk.GtkRecentManagerHandle gtk_recent_manager_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_manager_add_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager, string uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentDataHandle>))] MentorLake.Gtk.GtkRecentDataHandle recent_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_manager_add_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager, string uri);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_recent_manager_get_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_manager_has_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager, string uri);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))]
	internal static extern MentorLake.Gtk.GtkRecentInfoHandle gtk_recent_manager_lookup_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager, string uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_manager_move_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager, string uri, string new_uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_recent_manager_purge_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_manager_remove_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager, string uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))]
	internal static extern MentorLake.Gtk.GtkRecentManagerHandle gtk_recent_manager_get_default();

}
