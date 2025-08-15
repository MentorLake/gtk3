namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GAppInfoMonitor` monitors application information for changes.
/// </para>
/// <para>
/// `GAppInfoMonitor` is a very simple object used for monitoring the app
/// info database for changes (newly installed or removed applications).
/// </para>
/// <para>
/// Call [func@Gio.AppInfoMonitor.get] to get a `GAppInfoMonitor` and connect
/// to the [signal@Gio.AppInfoMonitor::changed] signal. The signal will be emitted once when
/// the app info database changes, and will not be emitted again until after the
/// next call to [func@Gio.AppInfo.get_all] or another `g_app_info_*()` function.
/// This is because monitoring the app info database for changes is expensive.
/// </para>
/// <para>
/// The following functions will re-arm the [signal@Gio.AppInfoMonitor::changed]
/// signal so it can be emitted again:
/// </para>
/// <para>
///  - [func@Gio.AppInfo.get_all]
///  - [func@Gio.AppInfo.get_all_for_type]
///  - [func@Gio.AppInfo.get_default_for_type]
///  - [func@Gio.AppInfo.get_fallback_for_type]
///  - [func@Gio.AppInfo.get_recommended_for_type]
///  - &amp;lt;see href=&quot;../gio-unix/type_func.DesktopAppInfo.get_implementation.html&quot;&amp;gt;g_desktop_app_info_get_implementations()&amp;lt;/see&amp;gt;
///  - &amp;lt;see href=&quot;../gio-unix/ctor.DesktopAppInfo.new.html&quot;&amp;gt;g_desktop_app_info_new()&amp;lt;/see&amp;gt;
///  - &amp;lt;see href=&quot;../gio-unix/ctor.DesktopAppInfo.new_from_filename.html&quot;&amp;gt;g_desktop_app_info_new_from_filename()&amp;lt;/see&amp;gt;
///  - &amp;lt;see href=&quot;../gio-unix/ctor.DesktopAppInfo.new_from_keyfile.html&quot;&amp;gt;g_desktop_app_info_new_from_keyfile()&amp;lt;/see&amp;gt;
///  - &amp;lt;see href=&quot;../gio-unix/type_func.DesktopAppInfo.search.html&quot;&amp;gt;g_desktop_app_info_search()&amp;lt;/see&amp;gt;
/// </para>
/// <para>
/// The latter functions are available if using
/// &amp;lt;see href=&quot;../gio-unix/class.DesktopAppInfo.html&quot;&amp;gt;GDesktopAppInfo&amp;lt;/see&amp;gt; from
/// `gio-unix-2.0.pc` (GIR namespace `GioUnix-2.0`).
/// </para>
/// <para>
/// In the usual case, applications should try to make note of the change
/// (doing things like invalidating caches) but not act on it. In
/// particular, applications should avoid making calls to `GAppInfo` APIs
/// in response to the change signal, deferring these until the time that
/// the updated data is actually required. The exception to this case is when
/// application information is actually being displayed on the screen
/// (for example, during a search or when the list of all applications is shown).
/// The reason for this is that changes to the list of installed applications
/// often come in groups (like during system updates) and rescanning the list
/// on every change is pointless and expensive.
/// </para>
/// </summary>

public class GAppInfoMonitorHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Gets the #GAppInfoMonitor for the current thread-default main
/// context.
/// </para>
/// <para>
/// The #GAppInfoMonitor will emit a “changed” signal in the
/// thread-default main context whenever the list of installed
/// applications (as reported by g_app_info_get_all()) may have changed.
/// </para>
/// <para>
/// The #GAppInfoMonitor::changed signal will only be emitted once until
/// g_app_info_get_all() (or another `g_app_info_*()` function) is called. Doing
/// so will re-arm the signal ready to notify about the next change.
/// </para>
/// <para>
/// You must only call g_object_unref() on the return value from under
/// the same main context as you created it.
/// </para>
/// </summary>

/// <return>
/// a reference to a #GAppInfoMonitor
/// </return>

	public static MentorLake.Gio.GAppInfoMonitorHandle Get()
	{
		return GAppInfoMonitorHandleExterns.g_app_info_monitor_get();
	}

}
public static class GAppInfoMonitorHandleSignalExtensions
{
/// <summary>
/// <para>
/// Signal emitted when the app info database changes, when applications are
/// installed or removed.
/// </para>
/// </summary>

	public static IObservable<GAppInfoMonitorHandleSignalStructs.ChangedSignal> Signal_Changed(this GAppInfoMonitorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GAppInfoMonitorHandleSignalStructs.ChangedSignal> obs) =>
		{
			GAppInfoMonitorHandleSignalDelegates.changed handler = ( MentorLake.Gio.GAppInfoMonitorHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GAppInfoMonitorHandleSignalStructs.ChangedSignal()
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

public static class GAppInfoMonitorHandleSignalStructs
{

public class ChangedSignal
{

	public MentorLake.Gio.GAppInfoMonitorHandle Self;

	public IntPtr UserData;
}
}

public static class GAppInfoMonitorHandleSignalDelegates
{

/// <summary>
/// <para>
/// Signal emitted when the app info database changes, when applications are
/// installed or removed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoMonitorHandle>))] MentorLake.Gio.GAppInfoMonitorHandle self, IntPtr user_data);

}


public static class GAppInfoMonitorHandleExtensions
{
}

internal class GAppInfoMonitorHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GAppInfoMonitorHandle>))]
	internal static extern MentorLake.Gio.GAppInfoMonitorHandle g_app_info_monitor_get();

}
