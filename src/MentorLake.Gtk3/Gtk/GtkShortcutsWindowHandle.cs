namespace MentorLake.Gtk;

public class GtkShortcutsWindowHandle : GtkWindowHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
}
public static class GtkShortcutsWindowHandleSignalExtensions
{

	public static IObservable<GtkShortcutsWindowHandleSignalStructs.CloseSignal> Signal_Close(this GtkShortcutsWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkShortcutsWindowHandleSignalStructs.CloseSignal> obs) =>
		{
			GtkShortcutsWindowHandleSignalDelegates.close handler = ( MentorLake.Gtk.GtkShortcutsWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkShortcutsWindowHandleSignalStructs.CloseSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "close", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkShortcutsWindowHandleSignalStructs.SearchSignal> Signal_Search(this GtkShortcutsWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkShortcutsWindowHandleSignalStructs.SearchSignal> obs) =>
		{
			GtkShortcutsWindowHandleSignalDelegates.search handler = ( MentorLake.Gtk.GtkShortcutsWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkShortcutsWindowHandleSignalStructs.SearchSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "search", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkShortcutsWindowHandleSignalStructs
{

public struct CloseSignal
{
	public MentorLake.Gtk.GtkShortcutsWindowHandle Self;
	public IntPtr UserData;
}

public struct SearchSignal
{
	public MentorLake.Gtk.GtkShortcutsWindowHandle Self;
	public IntPtr UserData;
}
}

public static class GtkShortcutsWindowHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkShortcutsWindowHandle>))] MentorLake.Gtk.GtkShortcutsWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void search([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkShortcutsWindowHandle>))] MentorLake.Gtk.GtkShortcutsWindowHandle self, IntPtr user_data);

}


public static class GtkShortcutsWindowHandleExtensions
{
}

internal class GtkShortcutsWindowHandleExterns
{
}
