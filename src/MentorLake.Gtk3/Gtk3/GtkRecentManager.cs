namespace MentorLake.Gtk3.Gtk3;

public class GtkRecentManagerHandle : GObjectHandle
{
	public static GtkRecentManagerHandle New()
	{
		return GtkRecentManagerExterns.gtk_recent_manager_new();
	}

	public static GtkRecentManagerHandle GetDefault()
	{
		return GtkRecentManagerExterns.gtk_recent_manager_get_default();
	}

}

public static class GtkRecentManagerSignalExtensions
{

	public static IObservable<GtkRecentManagerSignalStructs.ChangedSignal> Signal_Changed(this GtkRecentManagerHandle instance)
	{
		return Observable.Create((IObserver<GtkRecentManagerSignalStructs.ChangedSignal> obs) =>
		{
			GtkRecentManagerSignalDelegates.changed handler = (GtkRecentManagerHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRecentManagerSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkRecentManagerSignalStructs
{

public struct ChangedSignal
{
	public GtkRecentManagerHandle Self;
	public IntPtr UserData;
}
}

public static class GtkRecentManagerSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkRecentManagerHandle>))] GtkRecentManagerHandle self, IntPtr user_data);

}


public static class GtkRecentManagerHandleExtensions
{
	public static bool AddFull(this GtkRecentManagerHandle manager, string uri, GtkRecentDataHandle recent_data)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_add_full(manager, uri, recent_data);
	}

	public static bool AddItem(this GtkRecentManagerHandle manager, string uri)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_add_item(manager, uri);
	}

	public static GListHandle GetItems(this GtkRecentManagerHandle manager)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_get_items(manager);
	}

	public static bool HasItem(this GtkRecentManagerHandle manager, string uri)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_has_item(manager, uri);
	}

	public static GtkRecentInfoHandle LookupItem(this GtkRecentManagerHandle manager, string uri, out GErrorHandle error)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_lookup_item(manager, uri, out error);
	}

	public static bool MoveItem(this GtkRecentManagerHandle manager, string uri, string new_uri, out GErrorHandle error)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_move_item(manager, uri, new_uri, out error);
	}

	public static int PurgeItems(this GtkRecentManagerHandle manager, out GErrorHandle error)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_purge_items(manager, out error);
	}

	public static bool RemoveItem(this GtkRecentManagerHandle manager, string uri, out GErrorHandle error)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_remove_item(manager, uri, out error);
	}

}

internal class GtkRecentManagerExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRecentManagerHandle gtk_recent_manager_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_recent_manager_add_full(GtkRecentManagerHandle manager, string uri, GtkRecentDataHandle recent_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_recent_manager_add_item(GtkRecentManagerHandle manager, string uri);

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_recent_manager_get_items(GtkRecentManagerHandle manager);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_recent_manager_has_item(GtkRecentManagerHandle manager, string uri);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRecentInfoHandle gtk_recent_manager_lookup_item(GtkRecentManagerHandle manager, string uri, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_recent_manager_move_item(GtkRecentManagerHandle manager, string uri, string new_uri, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_recent_manager_purge_items(GtkRecentManagerHandle manager, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_recent_manager_remove_item(GtkRecentManagerHandle manager, string uri, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRecentManagerHandle gtk_recent_manager_get_default();

}
