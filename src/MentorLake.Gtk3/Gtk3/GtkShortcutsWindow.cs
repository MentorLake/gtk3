namespace MentorLake.Gtk3.Gtk3;

public class GtkShortcutsWindowHandle : GtkWindowHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
}

public static class GtkShortcutsWindowSignalExtensions
{

	public static IObservable<GtkShortcutsWindowSignalStructs.CloseSignal> Signal_Close(this GtkShortcutsWindowHandle instance)
	{
		return Observable.Create((IObserver<GtkShortcutsWindowSignalStructs.CloseSignal> obs) =>
		{
			GtkShortcutsWindowSignalDelegates.close handler = (GtkShortcutsWindowHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkShortcutsWindowSignalStructs.CloseSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "close", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkShortcutsWindowSignalStructs.SearchSignal> Signal_Search(this GtkShortcutsWindowHandle instance)
	{
		return Observable.Create((IObserver<GtkShortcutsWindowSignalStructs.SearchSignal> obs) =>
		{
			GtkShortcutsWindowSignalDelegates.search handler = (GtkShortcutsWindowHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkShortcutsWindowSignalStructs.SearchSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "search", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkShortcutsWindowSignalStructs
{

public struct CloseSignal
{
	public GtkShortcutsWindowHandle Self;
	public IntPtr UserData;
}

public struct SearchSignal
{
	public GtkShortcutsWindowHandle Self;
	public IntPtr UserData;
}
}

public static class GtkShortcutsWindowSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkShortcutsWindowHandle>))] GtkShortcutsWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void search([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkShortcutsWindowHandle>))] GtkShortcutsWindowHandle self, IntPtr user_data);

}


public static class GtkShortcutsWindowHandleExtensions
{
}

internal class GtkShortcutsWindowExterns
{
}
