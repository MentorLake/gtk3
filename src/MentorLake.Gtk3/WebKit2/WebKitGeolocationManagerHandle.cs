namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Geolocation manager.
/// </para>
/// <para>
/// WebKitGeolocationManager provides API to get the geographical position of the user.
/// Once a #WebKitGeolocationPermissionRequest is allowed, when WebKit needs to know the
/// user location #WebKitGeolocationManager::start signal is emitted. If the signal is handled
/// and returns %TRUE, the application is responsible for providing the position every time it&apos;s
/// updated by calling webkit_geolocation_manager_update_position(). The signal #WebKitGeolocationManager::stop
/// will be emitted when location updates are no longer needed.
/// </para>
/// </summary>

public class WebKitGeolocationManagerHandle : GObjectHandle
{
}
public static class WebKitGeolocationManagerHandleSignalExtensions
{
/// <summary>
/// <para>
/// The signal is emitted to notify that @manager needs to start receiving
/// position updates. After this signal is emitted the user should provide
/// the updates using webkit_geolocation_manager_update_position() every time
/// the position changes, or use webkit_geolocation_manager_failed() in case
/// it isn&apos;t possible to determine the current position.
/// </para>
/// <para>
/// If the signal is not handled, WebKit will try to determine the position
/// using GeoClue if available.
/// </para>
/// </summary>

	public static IObservable<WebKitGeolocationManagerHandleSignalStructs.StartSignal> Signal_Start(this WebKitGeolocationManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitGeolocationManagerHandleSignalStructs.StartSignal> obs) =>
		{
			WebKitGeolocationManagerHandleSignalDelegates.start handler = ( MentorLake.WebKit2.WebKitGeolocationManagerHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitGeolocationManagerHandleSignalStructs.StartSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "start", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The signal is emitted to notify that @manager doesn&apos;t need to receive
/// position updates anymore.
/// </para>
/// </summary>

	public static IObservable<WebKitGeolocationManagerHandleSignalStructs.StopSignal> Signal_Stop(this WebKitGeolocationManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitGeolocationManagerHandleSignalStructs.StopSignal> obs) =>
		{
			WebKitGeolocationManagerHandleSignalDelegates.stop handler = ( MentorLake.WebKit2.WebKitGeolocationManagerHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitGeolocationManagerHandleSignalStructs.StopSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "stop", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class WebKitGeolocationManagerHandleSignalStructs
{

public class StartSignal
{

	public MentorLake.WebKit2.WebKitGeolocationManagerHandle Self;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///    %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class StopSignal
{

	public MentorLake.WebKit2.WebKitGeolocationManagerHandle Self;

	public IntPtr UserData;
}
}

public static class WebKitGeolocationManagerHandleSignalDelegates
{

/// <summary>
/// <para>
/// The signal is emitted to notify that @manager needs to start receiving
/// position updates. After this signal is emitted the user should provide
/// the updates using webkit_geolocation_manager_update_position() every time
/// the position changes, or use webkit_geolocation_manager_failed() in case
/// it isn&apos;t possible to determine the current position.
/// </para>
/// <para>
/// If the signal is not handled, WebKit will try to determine the position
/// using GeoClue if available.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///    %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitGeolocationManagerHandle>))] MentorLake.WebKit2.WebKitGeolocationManagerHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The signal is emitted to notify that @manager doesn&apos;t need to receive
/// position updates anymore.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void stop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitGeolocationManagerHandle>))] MentorLake.WebKit2.WebKitGeolocationManagerHandle self, IntPtr user_data);

}


public static class WebKitGeolocationManagerHandleExtensions
{
/// <summary>
/// <para>
/// Notify @manager that determining the position failed.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitGeolocationManager
/// </param>
/// <param name="error_message">
/// the error message
/// </param>

	public static T Failed<T>(this T manager, string error_message) where T : WebKitGeolocationManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitGeolocationManagerHandle)");
		WebKitGeolocationManagerHandleExterns.webkit_geolocation_manager_failed(manager, error_message);
		return manager;
	}

/// <summary>
/// <para>
/// Get whether high accuracy is enabled.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitGeolocationManager
/// </param>
/// <return>
/// Whether the setting is enabled.
/// </return>

	public static bool GetEnableHighAccuracy(this MentorLake.WebKit2.WebKitGeolocationManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitGeolocationManagerHandle)");
		return WebKitGeolocationManagerHandleExterns.webkit_geolocation_manager_get_enable_high_accuracy(manager);
	}

/// <summary>
/// <para>
/// Notify @manager that position has been updated to @position.
/// </para>
/// </summary>

/// <param name="manager">
/// a #WebKitGeolocationManager
/// </param>
/// <param name="position">
/// a #WebKitGeolocationPosition
/// </param>

	public static T UpdatePosition<T>(this T manager, MentorLake.WebKit2.WebKitGeolocationPositionHandle position) where T : WebKitGeolocationManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitGeolocationManagerHandle)");
		WebKitGeolocationManagerHandleExterns.webkit_geolocation_manager_update_position(manager, position);
		return manager;
	}

}

internal class WebKitGeolocationManagerHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_geolocation_manager_failed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitGeolocationManagerHandle>))] MentorLake.WebKit2.WebKitGeolocationManagerHandle manager, string error_message);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_geolocation_manager_get_enable_high_accuracy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitGeolocationManagerHandle>))] MentorLake.WebKit2.WebKitGeolocationManagerHandle manager);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_geolocation_manager_update_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitGeolocationManagerHandle>))] MentorLake.WebKit2.WebKitGeolocationManagerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitGeolocationPositionHandle>))] MentorLake.WebKit2.WebKitGeolocationPositionHandle position);

}
