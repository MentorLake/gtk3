namespace MentorLake.Gio;

public class GDebugControllerDBusHandle : GObjectHandle, GDebugControllerHandle, GInitableHandle
{
	public static MentorLake.Gio.GDebugControllerDBusHandle New(MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDebugControllerDBusHandleExterns.g_debug_controller_dbus_new(connection, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}
public static class GDebugControllerDBusHandleSignalExtensions
{

	public static IObservable<GDebugControllerDBusHandleSignalStructs.AuthorizeSignal> Signal_Authorize(this GDebugControllerDBusHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDebugControllerDBusHandleSignalStructs.AuthorizeSignal> obs) =>
		{
			GDebugControllerDBusHandleSignalDelegates.authorize handler = ( MentorLake.Gio.GDebugControllerDBusHandle self,  MentorLake.Gio.GDBusMethodInvocationHandle invocation,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDebugControllerDBusHandleSignalStructs.AuthorizeSignal()
				{
					Self = self, Invocation = invocation, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "authorize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GDebugControllerDBusHandleSignalStructs
{

public class AuthorizeSignal
{
	public MentorLake.Gio.GDebugControllerDBusHandle Self;
	public MentorLake.Gio.GDBusMethodInvocationHandle Invocation;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GDebugControllerDBusHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool authorize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDebugControllerDBusHandle>))] MentorLake.Gio.GDebugControllerDBusHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, IntPtr user_data);

}


public static class GDebugControllerDBusHandleExtensions
{
	public static T Stop<T>(this T self) where T : GDebugControllerDBusHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GDebugControllerDBusHandle)");
		GDebugControllerDBusHandleExterns.g_debug_controller_dbus_stop(self);
		return self;
	}

}

internal class GDebugControllerDBusHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDebugControllerDBusHandle>))]
	internal static extern MentorLake.Gio.GDebugControllerDBusHandle g_debug_controller_dbus_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_debug_controller_dbus_stop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDebugControllerDBusHandle>))] MentorLake.Gio.GDebugControllerDBusHandle self);

}
