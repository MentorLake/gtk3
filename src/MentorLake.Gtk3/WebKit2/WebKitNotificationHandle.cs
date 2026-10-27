namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Holds information about a notification that should be shown to the user.
/// </para>
/// </summary>

public class WebKitNotificationHandle : GObjectHandle
{
}
public static class WebKitNotificationHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when a notification has been clicked. See webkit_notification_clicked().
/// </para>
/// </summary>

	public static IObservable<WebKitNotificationHandleSignalStructs.ClickedSignal> Signal_Clicked(this WebKitNotificationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitNotificationHandleSignalStructs.ClickedSignal> obs) =>
		{
			WebKitNotificationHandleSignalDelegates.clicked handler = ( MentorLake.WebKit2.WebKitNotificationHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitNotificationHandleSignalStructs.ClickedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "clicked", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when a notification has been withdrawn.
/// </para>
/// <para>
/// The default handler will close the notification using libnotify, if built with
/// support for it.
/// </para>
/// </summary>

	public static IObservable<WebKitNotificationHandleSignalStructs.ClosedSignal> Signal_Closed(this WebKitNotificationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitNotificationHandleSignalStructs.ClosedSignal> obs) =>
		{
			WebKitNotificationHandleSignalDelegates.closed handler = ( MentorLake.WebKit2.WebKitNotificationHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitNotificationHandleSignalStructs.ClosedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "closed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class WebKitNotificationHandleSignalStructs
{

public class ClickedSignal
{

	public MentorLake.WebKit2.WebKitNotificationHandle Self;

	public IntPtr UserData;
}

public class ClosedSignal
{

	public MentorLake.WebKit2.WebKitNotificationHandle Self;

	public IntPtr UserData;
}
}

public static class WebKitNotificationHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when a notification has been clicked. See webkit_notification_clicked().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void clicked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNotificationHandle>))] MentorLake.WebKit2.WebKitNotificationHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a notification has been withdrawn.
/// </para>
/// <para>
/// The default handler will close the notification using libnotify, if built with
/// support for it.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNotificationHandle>))] MentorLake.WebKit2.WebKitNotificationHandle self, IntPtr user_data);

}


public static class WebKitNotificationHandleExtensions
{
/// <summary>
/// <para>
/// Tells WebKit the notification has been clicked.
/// </para>
/// <para>
/// This will emit the
/// #WebKitNotification::clicked signal.
/// </para>
/// </summary>

/// <param name="notification">
/// a #WebKitNotification
/// </param>

	public static T Clicked<T>(this T notification) where T : WebKitNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (WebKitNotificationHandle)");
		WebKitNotificationHandleExterns.webkit_notification_clicked(notification);
		return notification;
	}

/// <summary>
/// <para>
/// Closes the notification.
/// </para>
/// </summary>

/// <param name="notification">
/// a #WebKitNotification
/// </param>

	public static T Close<T>(this T notification) where T : WebKitNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (WebKitNotificationHandle)");
		WebKitNotificationHandleExterns.webkit_notification_close(notification);
		return notification;
	}

/// <summary>
/// <para>
/// Obtains the body for the notification.
/// </para>
/// </summary>

/// <param name="notification">
/// a #WebKitNotification
/// </param>
/// <return>
/// the body for the notification
/// </return>

	public static string GetBody(this MentorLake.WebKit2.WebKitNotificationHandle notification)
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (WebKitNotificationHandle)");
		return WebKitNotificationHandleExterns.webkit_notification_get_body(notification);
	}

/// <summary>
/// <para>
/// Obtains the unique id for the notification.
/// </para>
/// </summary>

/// <param name="notification">
/// a #WebKitNotification
/// </param>
/// <return>
/// the unique id for the notification
/// </return>

	public static ulong GetId(this MentorLake.WebKit2.WebKitNotificationHandle notification)
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (WebKitNotificationHandle)");
		return WebKitNotificationHandleExterns.webkit_notification_get_id(notification);
	}

/// <summary>
/// <para>
/// Obtains the tag identifier for the notification.
/// </para>
/// </summary>

/// <param name="notification">
/// a #WebKitNotification
/// </param>
/// <return>
/// the tag for the notification
/// </return>

	public static string GetTag(this MentorLake.WebKit2.WebKitNotificationHandle notification)
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (WebKitNotificationHandle)");
		return WebKitNotificationHandleExterns.webkit_notification_get_tag(notification);
	}

/// <summary>
/// <para>
/// Obtains the title for the notification.
/// </para>
/// </summary>

/// <param name="notification">
/// a #WebKitNotification
/// </param>
/// <return>
/// the title for the notification
/// </return>

	public static string GetTitle(this MentorLake.WebKit2.WebKitNotificationHandle notification)
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (WebKitNotificationHandle)");
		return WebKitNotificationHandleExterns.webkit_notification_get_title(notification);
	}

}

internal class WebKitNotificationHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_notification_clicked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNotificationHandle>))] MentorLake.WebKit2.WebKitNotificationHandle notification);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_notification_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNotificationHandle>))] MentorLake.WebKit2.WebKitNotificationHandle notification);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_notification_get_body([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNotificationHandle>))] MentorLake.WebKit2.WebKitNotificationHandle notification);

	[DllImport(WebKit2Library.Name)]
	internal static extern ulong webkit_notification_get_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNotificationHandle>))] MentorLake.WebKit2.WebKitNotificationHandle notification);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_notification_get_tag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNotificationHandle>))] MentorLake.WebKit2.WebKitNotificationHandle notification);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_notification_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNotificationHandle>))] MentorLake.WebKit2.WebKitNotificationHandle notification);

}
