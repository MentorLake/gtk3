namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Integrating the launch with the launching application. This is used to
/// handle for instance startup notification and launching the new application
/// on the same screen as the launching window.
/// </para>
/// </summary>

public class GAppLaunchContextHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new application launch context. This is not normally used,
/// instead you instantiate a subclass of this, such as
/// &amp;lt;see href=&quot;https://docs.gtk.org/gdk4/class.AppLaunchContext.html&quot;&amp;gt;GdkAppLaunchContext&amp;lt;/see&amp;gt;.
/// </para>
/// </summary>

/// <return>
/// a launch context.
/// </return>

	public static MentorLake.Gio.GAppLaunchContextHandle New()
	{
		return GAppLaunchContextHandleExterns.g_app_launch_context_new();
	}

}
public static class GAppLaunchContextHandleSignalExtensions
{
/// <summary>
/// <para>
/// The [signal@Gio.AppLaunchContext::launch-failed] signal is emitted when a
/// [iface@Gio.AppInfo] launch fails. The startup notification id is provided,
/// so that the launcher can cancel the startup notification.
/// </para>
/// <para>
/// Because a launch operation may involve spawning multiple instances of the
/// target application, you should expect this signal to be emitted multiple
/// times, one for each spawned instance.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The [signal@Gio.AppLaunchContext::launch-started] signal is emitted when a
/// [iface@Gio.AppInfo] is about to be launched. If non-null the
/// @platform_data is an GVariant dictionary mapping strings to variants
/// (ie `a{sv}`), which contains additional, platform-specific data about this
/// launch. On UNIX, at least the `startup-notification-id` keys will be
/// present.
/// </para>
/// <para>
/// The value of the `startup-notification-id` key (type `s`) is a startup
/// notification ID corresponding to the format from the [startup-notification
/// specification](https://specifications.freedesktop.org/startup-notification-spec/startup-notification-0.1.txt).
/// It allows tracking the progress of the launchee through startup.
/// </para>
/// <para>
/// It is guaranteed that this signal is followed by either a
/// [signal@Gio.AppLaunchContext::launched] or
/// [signal@Gio.AppLaunchContext::launch-failed] signal.
/// </para>
/// <para>
/// Because a launch operation may involve spawning multiple instances of the
/// target application, you should expect this signal to be emitted multiple
/// times, one for each spawned instance.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The [signal@Gio.AppLaunchContext::launched] signal is emitted when a
/// [iface@Gio.AppInfo] is successfully launched.
/// </para>
/// <para>
/// Because a launch operation may involve spawning multiple instances of the
/// target application, you should expect this signal to be emitted multiple
/// times, one time for each spawned instance.
/// </para>
/// <para>
/// The @platform_data is an GVariant dictionary mapping
/// strings to variants (ie `a{sv}`), which contains additional,
/// platform-specific data about this launch. On UNIX, at least the
/// `pid` and `startup-notification-id` keys will be present.
/// </para>
/// <para>
/// Since 2.72 the `pid` may be 0 if the process id wasn’t known (for
/// example if the process was launched via D-Bus). The `pid` may not be
/// set at all in subsequent releases.
/// </para>
/// <para>
/// On Windows, `pid` is guaranteed to be valid only for the duration of the
/// [signal@Gio.AppLaunchContext::launched] signal emission; after the signal
/// is emitted, GLib will call [func@GLib.spawn_close_pid]. If you need to
/// keep the [alias@GLib.Pid] after the signal has been emitted, then you can
/// duplicate `pid` using `DuplicateHandle()`.
/// </para>
/// </summary>

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

public class LaunchFailedSignal
{

	public MentorLake.Gio.GAppLaunchContextHandle Self;
/// <summary>
/// <para>
/// the startup notification id for the failed launch
/// </para>
/// </summary>

	public string StartupNotifyId;

	public IntPtr UserData;
}

public class LaunchStartedSignal
{

	public MentorLake.Gio.GAppLaunchContextHandle Self;
/// <summary>
/// <para>
/// the [iface@Gio.AppInfo] that is about to be launched
/// </para>
/// </summary>

	public MentorLake.Gio.GAppInfoHandle Info;
/// <summary>
/// <para>
/// additional platform-specific data for this launch
/// </para>
/// </summary>

	public MentorLake.GLib.GVariantHandle PlatformData;

	public IntPtr UserData;
}

public class LaunchedSignal
{

	public MentorLake.Gio.GAppLaunchContextHandle Self;
/// <summary>
/// <para>
/// the [iface@Gio.AppInfo] that was just launched
/// </para>
/// </summary>

	public MentorLake.Gio.GAppInfoHandle Info;
/// <summary>
/// <para>
/// additional platform-specific data for this launch
/// </para>
/// </summary>

	public MentorLake.GLib.GVariantHandle PlatformData;

	public IntPtr UserData;
}
}

public static class GAppLaunchContextHandleSignalDelegates
{

/// <summary>
/// <para>
/// The [signal@Gio.AppLaunchContext::launch-failed] signal is emitted when a
/// [iface@Gio.AppInfo] launch fails. The startup notification id is provided,
/// so that the launcher can cancel the startup notification.
/// </para>
/// <para>
/// Because a launch operation may involve spawning multiple instances of the
/// target application, you should expect this signal to be emitted multiple
/// times, one for each spawned instance.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="startup_notify_id">
/// the startup notification id for the failed launch
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void launch_failed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle self, string startup_notify_id, IntPtr user_data);


/// <summary>
/// <para>
/// The [signal@Gio.AppLaunchContext::launch-started] signal is emitted when a
/// [iface@Gio.AppInfo] is about to be launched. If non-null the
/// @platform_data is an GVariant dictionary mapping strings to variants
/// (ie `a{sv}`), which contains additional, platform-specific data about this
/// launch. On UNIX, at least the `startup-notification-id` keys will be
/// present.
/// </para>
/// <para>
/// The value of the `startup-notification-id` key (type `s`) is a startup
/// notification ID corresponding to the format from the [startup-notification
/// specification](https://specifications.freedesktop.org/startup-notification-spec/startup-notification-0.1.txt).
/// It allows tracking the progress of the launchee through startup.
/// </para>
/// <para>
/// It is guaranteed that this signal is followed by either a
/// [signal@Gio.AppLaunchContext::launched] or
/// [signal@Gio.AppLaunchContext::launch-failed] signal.
/// </para>
/// <para>
/// Because a launch operation may involve spawning multiple instances of the
/// target application, you should expect this signal to be emitted multiple
/// times, one for each spawned instance.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="info">
/// the [iface@Gio.AppInfo] that is about to be launched
/// </param>
/// <param name="platform_data">
/// additional platform-specific data for this launch
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void launch_started([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle platform_data, IntPtr user_data);


/// <summary>
/// <para>
/// The [signal@Gio.AppLaunchContext::launched] signal is emitted when a
/// [iface@Gio.AppInfo] is successfully launched.
/// </para>
/// <para>
/// Because a launch operation may involve spawning multiple instances of the
/// target application, you should expect this signal to be emitted multiple
/// times, one time for each spawned instance.
/// </para>
/// <para>
/// The @platform_data is an GVariant dictionary mapping
/// strings to variants (ie `a{sv}`), which contains additional,
/// platform-specific data about this launch. On UNIX, at least the
/// `pid` and `startup-notification-id` keys will be present.
/// </para>
/// <para>
/// Since 2.72 the `pid` may be 0 if the process id wasn’t known (for
/// example if the process was launched via D-Bus). The `pid` may not be
/// set at all in subsequent releases.
/// </para>
/// <para>
/// On Windows, `pid` is guaranteed to be valid only for the duration of the
/// [signal@Gio.AppLaunchContext::launched] signal emission; after the signal
/// is emitted, GLib will call [func@GLib.spawn_close_pid]. If you need to
/// keep the [alias@GLib.Pid] after the signal has been emitted, then you can
/// duplicate `pid` using `DuplicateHandle()`.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="info">
/// the [iface@Gio.AppInfo] that was just launched
/// </param>
/// <param name="platform_data">
/// additional platform-specific data for this launch
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void launched([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle platform_data, IntPtr user_data);

}


public static class GAppLaunchContextHandleExtensions
{
/// <summary>
/// <para>
/// Gets the display string for the @context. This is used to ensure new
/// applications are started on the same display as the launching
/// application, by setting the `DISPLAY` environment variable.
/// </para>
/// </summary>

/// <param name="context">
/// the launch context
/// </param>
/// <param name="info">
/// the app info
/// </param>
/// <param name="files">
/// a list of [iface@Gio.File] objects
/// </param>
/// <return>
/// a display string for the display.
/// </return>

	public static string GetDisplay(this MentorLake.Gio.GAppLaunchContextHandle context, MentorLake.Gio.GAppInfoHandle info, MentorLake.GLib.GListHandle files)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GAppLaunchContextHandle)");
		return GAppLaunchContextHandleExterns.g_app_launch_context_get_display(context, info, files);
	}

/// <summary>
/// <para>
/// Gets the complete environment variable list to be passed to
/// the child process when @context is used to launch an application.
/// This is a `NULL`-terminated array of strings, where each string has
/// the form `KEY=VALUE`.
/// </para>
/// </summary>

/// <param name="context">
/// the launch context
/// </param>
/// <return>
/// 
///   the child’s environment
/// </return>

	public static string[] GetEnvironment(this MentorLake.Gio.GAppLaunchContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GAppLaunchContextHandle)");
		return GAppLaunchContextHandleExterns.g_app_launch_context_get_environment(context);
	}

/// <summary>
/// <para>
/// Initiates startup notification for the application and returns the
/// `XDG_ACTIVATION_TOKEN` or `DESKTOP_STARTUP_ID` for the launched operation,
/// if supported.
/// </para>
/// <para>
/// The returned token may be referred to equivalently as an ‘activation token’
/// (using Wayland terminology) or a ‘startup sequence ID’ (using X11 terminology).
/// The two [are interoperable](https://gitlab.freedesktop.org/wayland/wayland-protocols/-/blob/main/staging/xdg-activation/x11-interoperation.rst).
/// </para>
/// <para>
/// Activation tokens are defined in the [XDG Activation Protocol](https://wayland.app/protocols/xdg-activation-v1),
/// and startup notification IDs are defined in the
/// [freedesktop.org Startup Notification Protocol](http://standards.freedesktop.org/startup-notification-spec/startup-notification-latest.txt).
/// </para>
/// <para>
/// Support for the XDG Activation Protocol was added in GLib 2.76.
/// Since GLib 2.82 @info and @files can be `NULL`. If that’s not supported by the backend,
/// the returned token will be `NULL`.
/// </para>
/// </summary>

/// <param name="context">
/// the launch context
/// </param>
/// <param name="info">
/// the app info
/// </param>
/// <param name="files">
/// a list of [iface@Gio.File] objects
/// </param>
/// <return>
/// a startup notification ID for the application, or `NULL` if
///   not supported.
/// </return>

	public static string GetStartupNotifyId(this MentorLake.Gio.GAppLaunchContextHandle context, MentorLake.Gio.GAppInfoHandle info, MentorLake.GLib.GListHandle files)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GAppLaunchContextHandle)");
		return GAppLaunchContextHandleExterns.g_app_launch_context_get_startup_notify_id(context, info, files);
	}

/// <summary>
/// <para>
/// Called when an application has failed to launch, so that it can cancel
/// the application startup notification started in
/// [method@Gio.AppLaunchContext.get_startup_notify_id].
/// </para>
/// </summary>

/// <param name="context">
/// the launch context
/// </param>
/// <param name="startup_notify_id">
/// the startup notification id that was returned by
///   [method@Gio.AppLaunchContext.get_startup_notify_id].
/// </param>

	public static T LaunchFailed<T>(this T context, string startup_notify_id) where T : GAppLaunchContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GAppLaunchContextHandle)");
		GAppLaunchContextHandleExterns.g_app_launch_context_launch_failed(context, startup_notify_id);
		return context;
	}

/// <summary>
/// <para>
/// Arranges for @variable to be set to @value in the child’s environment when
/// @context is used to launch an application.
/// </para>
/// </summary>

/// <param name="context">
/// the launch context
/// </param>
/// <param name="variable">
/// the environment variable to set
/// </param>
/// <param name="value">
/// the value for to set the variable to.
/// </param>

	public static T Setenv<T>(this T context, string variable, string value) where T : GAppLaunchContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GAppLaunchContextHandle)");
		GAppLaunchContextHandleExterns.g_app_launch_context_setenv(context, variable, value);
		return context;
	}

/// <summary>
/// <para>
/// Arranges for @variable to be unset in the child’s environment when @context
/// is used to launch an application.
/// </para>
/// </summary>

/// <param name="context">
/// the launch context
/// </param>
/// <param name="variable">
/// the environment variable to remove
/// </param>

	public static T Unsetenv<T>(this T context, string variable) where T : GAppLaunchContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GAppLaunchContextHandle)");
		GAppLaunchContextHandleExterns.g_app_launch_context_unsetenv(context, variable);
		return context;
	}

}

internal class GAppLaunchContextHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))]
	internal static extern MentorLake.Gio.GAppLaunchContextHandle g_app_launch_context_new();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_app_launch_context_get_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle files);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
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
