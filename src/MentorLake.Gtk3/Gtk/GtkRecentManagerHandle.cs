namespace MentorLake.Gtk;

public class GtkRecentManagerHandle : GObjectHandle
{
	public static MentorLake.Gtk.GtkRecentManagerHandle New()
	{
		return GtkRecentManagerHandleExterns.gtk_recent_manager_new();
	}

	public static MentorLake.Gtk.GtkRecentManagerHandle GetDefault()
	{
		return GtkRecentManagerHandleExterns.gtk_recent_manager_get_default();
	}

}
public static class GtkRecentManagerHandleSignalExtensions
{

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

public struct ChangedSignal
{
	public MentorLake.Gtk.GtkRecentManagerHandle Self;
	public IntPtr UserData;
}
}

public static class GtkRecentManagerHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle self, IntPtr user_data);

}


public static class GtkRecentManagerHandleExtensions
{
	public static bool AddFull(this MentorLake.Gtk.GtkRecentManagerHandle manager, string uri, MentorLake.Gtk.GtkRecentDataHandle recent_data)
	{
		return GtkRecentManagerHandleExterns.gtk_recent_manager_add_full(manager, uri, recent_data);
	}

	public static bool AddItem(this MentorLake.Gtk.GtkRecentManagerHandle manager, string uri)
	{
		return GtkRecentManagerHandleExterns.gtk_recent_manager_add_item(manager, uri);
	}

	public static MentorLake.GLib.GListHandle GetItems(this MentorLake.Gtk.GtkRecentManagerHandle manager)
	{
		return GtkRecentManagerHandleExterns.gtk_recent_manager_get_items(manager);
	}

	public static bool HasItem(this MentorLake.Gtk.GtkRecentManagerHandle manager, string uri)
	{
		return GtkRecentManagerHandleExterns.gtk_recent_manager_has_item(manager, uri);
	}

	public static MentorLake.Gtk.GtkRecentInfoHandle LookupItem(this MentorLake.Gtk.GtkRecentManagerHandle manager, string uri)
	{
		var externCallResult = GtkRecentManagerHandleExterns.gtk_recent_manager_lookup_item(manager, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool MoveItem(this MentorLake.Gtk.GtkRecentManagerHandle manager, string uri, string new_uri)
	{
		var externCallResult = GtkRecentManagerHandleExterns.gtk_recent_manager_move_item(manager, uri, new_uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static int PurgeItems(this MentorLake.Gtk.GtkRecentManagerHandle manager)
	{
		var externCallResult = GtkRecentManagerHandleExterns.gtk_recent_manager_purge_items(manager, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool RemoveItem(this MentorLake.Gtk.GtkRecentManagerHandle manager, string uri)
	{
		var externCallResult = GtkRecentManagerHandleExterns.gtk_recent_manager_remove_item(manager, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GtkRecentManagerHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRecentManagerHandle gtk_recent_manager_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_manager_add_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager, string uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentDataHandle>))] MentorLake.Gtk.GtkRecentDataHandle recent_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_manager_add_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager, string uri);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle gtk_recent_manager_get_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_manager_has_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager, string uri);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRecentInfoHandle gtk_recent_manager_lookup_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager, string uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_manager_move_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager, string uri, string new_uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_recent_manager_purge_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_manager_remove_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager, string uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRecentManagerHandle gtk_recent_manager_get_default();

}
