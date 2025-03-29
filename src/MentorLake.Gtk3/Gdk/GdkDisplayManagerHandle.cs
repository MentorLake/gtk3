namespace MentorLake.Gdk;

public class GdkDisplayManagerHandle : GObjectHandle
{
	public static MentorLake.Gdk.GdkDisplayManagerHandle Get()
	{
		return GdkDisplayManagerHandleExterns.gdk_display_manager_get();
	}

}
public static class GdkDisplayManagerHandleSignalExtensions
{

	public static IObservable<GdkDisplayManagerHandleSignalStructs.DisplayOpenedSignal> Signal_DisplayOpened(this GdkDisplayManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkDisplayManagerHandleSignalStructs.DisplayOpenedSignal> obs) =>
		{
			GdkDisplayManagerHandleSignalDelegates.display_opened handler = ( MentorLake.Gdk.GdkDisplayManagerHandle self,  MentorLake.Gdk.GdkDisplayHandle display,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDisplayManagerHandleSignalStructs.DisplayOpenedSignal()
				{
					Self = self, Display = display, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "display-opened", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GdkDisplayManagerHandleSignalStructs
{

public struct DisplayOpenedSignal
{
	public MentorLake.Gdk.GdkDisplayManagerHandle Self;
	public MentorLake.Gdk.GdkDisplayHandle Display;
	public IntPtr UserData;
}
}

public static class GdkDisplayManagerHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void display_opened([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayManagerHandle>))] MentorLake.Gdk.GdkDisplayManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, IntPtr user_data);

}


public static class GdkDisplayManagerHandleExtensions
{
	public static MentorLake.Gdk.GdkDisplayHandle GetDefaultDisplay(this MentorLake.Gdk.GdkDisplayManagerHandle manager)
	{
		if (manager.IsInvalid || manager.IsClosed) throw new Exception("Invalid or closed handle (GdkDisplayManagerHandle)");
		return GdkDisplayManagerHandleExterns.gdk_display_manager_get_default_display(manager);
	}

	public static MentorLake.GLib.GSListHandle ListDisplays(this MentorLake.Gdk.GdkDisplayManagerHandle manager)
	{
		if (manager.IsInvalid || manager.IsClosed) throw new Exception("Invalid or closed handle (GdkDisplayManagerHandle)");
		return GdkDisplayManagerHandleExterns.gdk_display_manager_list_displays(manager);
	}

	public static MentorLake.Gdk.GdkDisplayHandle OpenDisplay(this MentorLake.Gdk.GdkDisplayManagerHandle manager, string name)
	{
		if (manager.IsInvalid || manager.IsClosed) throw new Exception("Invalid or closed handle (GdkDisplayManagerHandle)");
		return GdkDisplayManagerHandleExterns.gdk_display_manager_open_display(manager, name);
	}

	public static T SetDefaultDisplay<T>(this T manager, MentorLake.Gdk.GdkDisplayHandle display) where T : GdkDisplayManagerHandle
	{
		if (manager.IsInvalid || manager.IsClosed) throw new Exception("Invalid or closed handle (GdkDisplayManagerHandle)");
		GdkDisplayManagerHandleExterns.gdk_display_manager_set_default_display(manager, display);
		return manager;
	}

}

internal class GdkDisplayManagerHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDisplayHandle gdk_display_manager_get_default_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayManagerHandle>))] MentorLake.Gdk.GdkDisplayManagerHandle manager);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.GLib.GSListHandle gdk_display_manager_list_displays([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayManagerHandle>))] MentorLake.Gdk.GdkDisplayManagerHandle manager);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDisplayHandle gdk_display_manager_open_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayManagerHandle>))] MentorLake.Gdk.GdkDisplayManagerHandle manager, string name);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_display_manager_set_default_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayManagerHandle>))] MentorLake.Gdk.GdkDisplayManagerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDisplayManagerHandle gdk_display_manager_get();

}
