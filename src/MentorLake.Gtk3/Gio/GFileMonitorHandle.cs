namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Monitors a file or directory for changes.
/// </para>
/// <para>
/// To obtain a `GFileMonitor` for a file or directory, use
/// [method@Gio.File.monitor], [method@Gio.File.monitor_file], or
/// [method@Gio.File.monitor_directory].
/// </para>
/// <para>
/// To get informed about changes to the file or directory you are
/// monitoring, connect to the [signal@Gio.FileMonitor::changed] signal. The
/// signal will be emitted in the thread-default main context (see
/// [method@GLib.MainContext.push_thread_default]) of the thread that the monitor
/// was created in (though if the global default main context is blocked, this
/// may cause notifications to be blocked even if the thread-default
/// context is still running).
/// </para>
/// </summary>

public class GFileMonitorHandle : GObjectHandle
{
}
public static class GFileMonitorHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when @file has been changed.
/// </para>
/// <para>
/// If using %G_FILE_MONITOR_WATCH_MOVES on a directory monitor, and
/// the information is available (and if supported by the backend),
/// @event_type may be %G_FILE_MONITOR_EVENT_RENAMED,
/// %G_FILE_MONITOR_EVENT_MOVED_IN or %G_FILE_MONITOR_EVENT_MOVED_OUT.
/// </para>
/// <para>
/// In all cases @file will be a child of the monitored directory.  For
/// renames, @file will be the old name and @other_file is the new
/// name.  For "moved in" events, @file is the name of the file that
/// appeared and @other_file is the old name that it was moved from (in
/// another directory).  For "moved out" events, @file is the name of
/// the file that used to be in this directory and @other_file is the
/// name of the file at its new location.
/// </para>
/// <para>
/// It makes sense to treat %G_FILE_MONITOR_EVENT_MOVED_IN as
/// equivalent to %G_FILE_MONITOR_EVENT_CREATED and
/// %G_FILE_MONITOR_EVENT_MOVED_OUT as equivalent to
/// %G_FILE_MONITOR_EVENT_DELETED, with extra information.
/// %G_FILE_MONITOR_EVENT_RENAMED is equivalent to a delete/create
/// pair.  This is exactly how the events will be reported in the case
/// that the %G_FILE_MONITOR_WATCH_MOVES flag is not in use.
/// </para>
/// <para>
/// If using the deprecated flag %G_FILE_MONITOR_SEND_MOVED flag and @event_type is
/// %G_FILE_MONITOR_EVENT_MOVED, @file will be set to a #GFile containing the
/// old path, and @other_file will be set to a #GFile containing the new path.
/// </para>
/// <para>
/// In all the other cases, @other_file will be set to #NULL.
/// </para>
/// </summary>

	public static IObservable<GFileMonitorHandleSignalStructs.ChangedSignal> Signal_Changed(this GFileMonitorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GFileMonitorHandleSignalStructs.ChangedSignal> obs) =>
		{
			GFileMonitorHandleSignalDelegates.changed handler = ( MentorLake.Gio.GFileMonitorHandle self,  MentorLake.Gio.GFileHandle file,  MentorLake.Gio.GFileHandle other_file,  MentorLake.Gio.GFileMonitorEvent event_type,  IntPtr user_data) =>
			{
				

				var signalStruct = new GFileMonitorHandleSignalStructs.ChangedSignal()
				{
					Self = self, File = file, OtherFile = other_file, EventType = event_type, UserData = user_data
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

public static class GFileMonitorHandleSignalStructs
{

public class ChangedSignal
{

	public MentorLake.Gio.GFileMonitorHandle Self;
/// <summary>
/// <para>
/// a #GFile.
/// </para>
/// </summary>

	public MentorLake.Gio.GFileHandle File;
/// <summary>
/// <para>
/// a #GFile or #NULL.
/// </para>
/// </summary>

	public MentorLake.Gio.GFileHandle OtherFile;
/// <summary>
/// <para>
/// a #GFileMonitorEvent.
/// </para>
/// </summary>

	public MentorLake.Gio.GFileMonitorEvent EventType;

	public IntPtr UserData;
}
}

public static class GFileMonitorHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when @file has been changed.
/// </para>
/// <para>
/// If using %G_FILE_MONITOR_WATCH_MOVES on a directory monitor, and
/// the information is available (and if supported by the backend),
/// @event_type may be %G_FILE_MONITOR_EVENT_RENAMED,
/// %G_FILE_MONITOR_EVENT_MOVED_IN or %G_FILE_MONITOR_EVENT_MOVED_OUT.
/// </para>
/// <para>
/// In all cases @file will be a child of the monitored directory.  For
/// renames, @file will be the old name and @other_file is the new
/// name.  For "moved in" events, @file is the name of the file that
/// appeared and @other_file is the old name that it was moved from (in
/// another directory).  For "moved out" events, @file is the name of
/// the file that used to be in this directory and @other_file is the
/// name of the file at its new location.
/// </para>
/// <para>
/// It makes sense to treat %G_FILE_MONITOR_EVENT_MOVED_IN as
/// equivalent to %G_FILE_MONITOR_EVENT_CREATED and
/// %G_FILE_MONITOR_EVENT_MOVED_OUT as equivalent to
/// %G_FILE_MONITOR_EVENT_DELETED, with extra information.
/// %G_FILE_MONITOR_EVENT_RENAMED is equivalent to a delete/create
/// pair.  This is exactly how the events will be reported in the case
/// that the %G_FILE_MONITOR_WATCH_MOVES flag is not in use.
/// </para>
/// <para>
/// If using the deprecated flag %G_FILE_MONITOR_SEND_MOVED flag and @event_type is
/// %G_FILE_MONITOR_EVENT_MOVED, @file will be set to a #GFile containing the
/// old path, and @other_file will be set to a #GFile containing the new path.
/// </para>
/// <para>
/// In all the other cases, @other_file will be set to #NULL.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="file">
/// a #GFile.
/// </param>
/// <param name="other_file">
/// a #GFile or #NULL.
/// </param>
/// <param name="event_type">
/// a #GFileMonitorEvent.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileMonitorHandle>))] MentorLake.Gio.GFileMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle other_file, MentorLake.Gio.GFileMonitorEvent event_type, IntPtr user_data);

}


public static class GFileMonitorHandleExtensions
{
/// <summary>
/// <para>
/// Cancels a file monitor.
/// </para>
/// </summary>

/// <param name="monitor">
/// a #GFileMonitor.
/// </param>
/// <return>
/// always %TRUE
/// </return>

	public static bool Cancel(this MentorLake.Gio.GFileMonitorHandle monitor)
	{
		if (monitor.IsInvalid) throw new Exception("Invalid handle (GFileMonitorHandle)");
		return GFileMonitorHandleExterns.g_file_monitor_cancel(monitor);
	}

/// <summary>
/// <para>
/// Emits the #GFileMonitor::changed signal if a change
/// has taken place. Should be called from file monitor
/// implementations only.
/// </para>
/// <para>
/// Implementations are responsible to call this method from the
/// [thread-default main context][g-main-context-push-thread-default] of the
/// thread that the monitor was created in.
/// </para>
/// </summary>

/// <param name="monitor">
/// a #GFileMonitor.
/// </param>
/// <param name="child">
/// a #GFile.
/// </param>
/// <param name="other_file">
/// a #GFile.
/// </param>
/// <param name="event_type">
/// a set of #GFileMonitorEvent flags.
/// </param>

	public static T EmitEvent<T>(this T monitor, MentorLake.Gio.GFileHandle child, MentorLake.Gio.GFileHandle other_file, MentorLake.Gio.GFileMonitorEvent event_type) where T : GFileMonitorHandle
	{
		if (monitor.IsInvalid) throw new Exception("Invalid handle (GFileMonitorHandle)");
		GFileMonitorHandleExterns.g_file_monitor_emit_event(monitor, child, other_file, event_type);
		return monitor;
	}

/// <summary>
/// <para>
/// Returns whether the monitor is canceled.
/// </para>
/// </summary>

/// <param name="monitor">
/// a #GFileMonitor
/// </param>
/// <return>
/// %TRUE if monitor is canceled. %FALSE otherwise.
/// </return>

	public static bool IsCancelled(this MentorLake.Gio.GFileMonitorHandle monitor)
	{
		if (monitor.IsInvalid) throw new Exception("Invalid handle (GFileMonitorHandle)");
		return GFileMonitorHandleExterns.g_file_monitor_is_cancelled(monitor);
	}

/// <summary>
/// <para>
/// Sets the rate limit to which the @monitor will report
/// consecutive change events to the same file.
/// </para>
/// </summary>

/// <param name="monitor">
/// a #GFileMonitor.
/// </param>
/// <param name="limit_msecs">
/// a non-negative integer with the limit in milliseconds
///     to poll for changes
/// </param>

	public static T SetRateLimit<T>(this T monitor, int limit_msecs) where T : GFileMonitorHandle
	{
		if (monitor.IsInvalid) throw new Exception("Invalid handle (GFileMonitorHandle)");
		GFileMonitorHandleExterns.g_file_monitor_set_rate_limit(monitor, limit_msecs);
		return monitor;
	}

}

internal class GFileMonitorHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_monitor_cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileMonitorHandle>))] MentorLake.Gio.GFileMonitorHandle monitor);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_monitor_emit_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileMonitorHandle>))] MentorLake.Gio.GFileMonitorHandle monitor, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle other_file, MentorLake.Gio.GFileMonitorEvent event_type);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_monitor_is_cancelled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileMonitorHandle>))] MentorLake.Gio.GFileMonitorHandle monitor);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_monitor_set_rate_limit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileMonitorHandle>))] MentorLake.Gio.GFileMonitorHandle monitor, int limit_msecs);

}
