namespace MentorLake.Gtk3.Gtk3;

public class GtkSearchEntryHandle : GtkEntryHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkEditableHandle
{
	public static GtkSearchEntryHandle New()
	{
		return GtkSearchEntryExterns.gtk_search_entry_new();
	}

}

public static class GtkSearchEntrySignalExtensions
{

	public static IObservable<GtkSearchEntrySignalStructs.NextMatchSignal> Signal_NextMatch(this GtkSearchEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkSearchEntrySignalStructs.NextMatchSignal> obs) =>
		{
			GtkSearchEntrySignalDelegates.next_match handler = (GtkSearchEntryHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSearchEntrySignalStructs.NextMatchSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "next_match", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkSearchEntrySignalStructs.PreviousMatchSignal> Signal_PreviousMatch(this GtkSearchEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkSearchEntrySignalStructs.PreviousMatchSignal> obs) =>
		{
			GtkSearchEntrySignalDelegates.previous_match handler = (GtkSearchEntryHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSearchEntrySignalStructs.PreviousMatchSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "previous_match", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkSearchEntrySignalStructs.SearchChangedSignal> Signal_SearchChanged(this GtkSearchEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkSearchEntrySignalStructs.SearchChangedSignal> obs) =>
		{
			GtkSearchEntrySignalDelegates.search_changed handler = (GtkSearchEntryHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSearchEntrySignalStructs.SearchChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "search_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkSearchEntrySignalStructs.StopSearchSignal> Signal_StopSearch(this GtkSearchEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkSearchEntrySignalStructs.StopSearchSignal> obs) =>
		{
			GtkSearchEntrySignalDelegates.stop_search handler = (GtkSearchEntryHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSearchEntrySignalStructs.StopSearchSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "stop_search", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkSearchEntrySignalStructs
{

public struct NextMatchSignal
{
	public GtkSearchEntryHandle Self;
	public IntPtr UserData;
}

public struct PreviousMatchSignal
{
	public GtkSearchEntryHandle Self;
	public IntPtr UserData;
}

public struct SearchChangedSignal
{
	public GtkSearchEntryHandle Self;
	public IntPtr UserData;
}

public struct StopSearchSignal
{
	public GtkSearchEntryHandle Self;
	public IntPtr UserData;
}
}

public static class GtkSearchEntrySignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void next_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSearchEntryHandle>))] GtkSearchEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void previous_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSearchEntryHandle>))] GtkSearchEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void search_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSearchEntryHandle>))] GtkSearchEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void stop_search([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSearchEntryHandle>))] GtkSearchEntryHandle self, IntPtr user_data);

}


public static class GtkSearchEntryHandleExtensions
{
	public static bool HandleEvent(this GtkSearchEntryHandle entry, GdkEventHandle @event)
	{
		return GtkSearchEntryExterns.gtk_search_entry_handle_event(entry, @event);
	}

}

internal class GtkSearchEntryExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSearchEntryHandle gtk_search_entry_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_search_entry_handle_event(GtkSearchEntryHandle entry, GdkEventHandle @event);

}
