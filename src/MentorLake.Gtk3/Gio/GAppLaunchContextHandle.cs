namespace MentorLake.Gio;

public class GAppLaunchContextHandle : GObjectHandle
{
	public static MentorLake.Gio.GAppLaunchContextHandle New()
	{
		return GAppLaunchContextHandleExterns.g_app_launch_context_new();
	}

}
public static class GAppLaunchContextHandleSignalExtensions
{

	public static IObservable<GAppLaunchContextHandleSignalStructs.LaunchFailedSignal> Signal_LaunchFailed(this GAppLaunchContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GAppLaunchContextHandleSignalStructs.LaunchFailedSignal> obs) =>
		{
			GAppLaunchContextHandleSignalDelegates.launch_failed handler = ( MentorLake.Gio.GAppLaunchContextHandle self,  string startup_notify_id,  IntPtr user_data) =>
			{
				

				var signalStruct = new GAppLaunchContextHandleSignalStructs.LaunchFailedSignal()
				{
					Self = self, StartupNotifyId = startup_notify_id, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "launch-failed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GAppLaunchContextHandleSignalStructs.LaunchStartedSignal> Signal_LaunchStarted(this GAppLaunchContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GAppLaunchContextHandleSignalStructs.LaunchStartedSignal> obs) =>
		{
			GAppLaunchContextHandleSignalDelegates.launch_started handler = ( MentorLake.Gio.GAppLaunchContextHandle self,  MentorLake.Gio.GAppInfoHandle info,  MentorLake.GLib.GVariantHandle platform_data,  IntPtr user_data) =>
			{
				

				var signalStruct = new GAppLaunchContextHandleSignalStructs.LaunchStartedSignal()
				{
					Self = self, Info = info, PlatformData = platform_data, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "launch-started", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GAppLaunchContextHandleSignalStructs.LaunchedSignal> Signal_Launched(this GAppLaunchContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GAppLaunchContextHandleSignalStructs.LaunchedSignal> obs) =>
		{
			GAppLaunchContextHandleSignalDelegates.launched handler = ( MentorLake.Gio.GAppLaunchContextHandle self,  MentorLake.Gio.GAppInfoHandle info,  MentorLake.GLib.GVariantHandle platform_data,  IntPtr user_data) =>
			{
				

				var signalStruct = new GAppLaunchContextHandleSignalStructs.LaunchedSignal()
				{
					Self = self, Info = info, PlatformData = platform_data, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "launched", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GAppLaunchContextHandleSignalStructs
{

public struct LaunchFailedSignal
{
	public MentorLake.Gio.GAppLaunchContextHandle Self;
	public string StartupNotifyId;
	public IntPtr UserData;
}

public struct LaunchStartedSignal
{
	public MentorLake.Gio.GAppLaunchContextHandle Self;
	public MentorLake.Gio.GAppInfoHandle Info;
	public MentorLake.GLib.GVariantHandle PlatformData;
	public IntPtr UserData;
}

public struct LaunchedSignal
{
	public MentorLake.Gio.GAppLaunchContextHandle Self;
	public MentorLake.Gio.GAppInfoHandle Info;
	public MentorLake.GLib.GVariantHandle PlatformData;
	public IntPtr UserData;
}
}

public static class GAppLaunchContextHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void launch_failed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle self, string startup_notify_id, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void launch_started([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle platform_data, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void launched([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle platform_data, IntPtr user_data);

}


public static class GAppLaunchContextHandleExtensions
{
	public static string GetDisplay(this MentorLake.Gio.GAppLaunchContextHandle context, MentorLake.Gio.GAppInfoHandle info, MentorLake.GLib.GListHandle files)
	{
		return GAppLaunchContextHandleExterns.g_app_launch_context_get_display(context, info, files);
	}

	public static string[] GetEnvironment(this MentorLake.Gio.GAppLaunchContextHandle context)
	{
		return GAppLaunchContextHandleExterns.g_app_launch_context_get_environment(context);
	}

	public static string GetStartupNotifyId(this MentorLake.Gio.GAppLaunchContextHandle context, MentorLake.Gio.GAppInfoHandle info, MentorLake.GLib.GListHandle files)
	{
		return GAppLaunchContextHandleExterns.g_app_launch_context_get_startup_notify_id(context, info, files);
	}

	public static T LaunchFailed<T>(this T context, string startup_notify_id) where T : GAppLaunchContextHandle
	{
		GAppLaunchContextHandleExterns.g_app_launch_context_launch_failed(context, startup_notify_id);
		return context;
	}

	public static T Setenv<T>(this T context, string variable, string value) where T : GAppLaunchContextHandle
	{
		GAppLaunchContextHandleExterns.g_app_launch_context_setenv(context, variable, value);
		return context;
	}

	public static T Unsetenv<T>(this T context, string variable) where T : GAppLaunchContextHandle
	{
		GAppLaunchContextHandleExterns.g_app_launch_context_unsetenv(context, variable);
		return context;
	}

}

internal class GAppLaunchContextHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GAppLaunchContextHandle g_app_launch_context_new();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_app_launch_context_get_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle files);

	[DllImport(GioLibrary.Name)]
	internal static extern string[] g_app_launch_context_get_environment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle context);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_app_launch_context_get_startup_notify_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle files);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_app_launch_context_launch_failed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle context, string startup_notify_id);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_app_launch_context_setenv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle context, string variable, string value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_app_launch_context_unsetenv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle context, string variable);

}
