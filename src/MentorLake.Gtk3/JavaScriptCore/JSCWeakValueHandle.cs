namespace MentorLake.JavaScriptCore;

/// <summary>
/// <para>
/// JSCWeakValue represents a weak reference to a value in a #JSCContext. It can be used
/// to keep a reference to a JavaScript value without protecting it from being garbage
/// collected and without referencing the #JSCContext either.
/// </para>
/// </summary>

public class JSCWeakValueHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Create a new #JSCWeakValue for the JavaScript value referenced by @value.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <return>
/// a new #JSCWeakValue
/// </return>

	public static MentorLake.JavaScriptCore.JSCWeakValueHandle New(MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		return JSCWeakValueHandleExterns.jsc_weak_value_new(value);
	}

}
public static class JSCWeakValueHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when the JavaScript value is destroyed.
/// </para>
/// </summary>

	public static IObservable<JSCWeakValueHandleSignalStructs.ClearedSignal> Signal_Cleared(this JSCWeakValueHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<JSCWeakValueHandleSignalStructs.ClearedSignal> obs) =>
		{
			JSCWeakValueHandleSignalDelegates.cleared handler = ( MentorLake.JavaScriptCore.JSCWeakValueHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new JSCWeakValueHandleSignalStructs.ClearedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "cleared", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class JSCWeakValueHandleSignalStructs
{

public class ClearedSignal
{

	public MentorLake.JavaScriptCore.JSCWeakValueHandle Self;

	public IntPtr UserData;
}
}

public static class JSCWeakValueHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when the JavaScript value is destroyed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cleared([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCWeakValueHandle>))] MentorLake.JavaScriptCore.JSCWeakValueHandle self, IntPtr user_data);

}


public static class JSCWeakValueHandleExtensions
{
/// <summary>
/// <para>
/// Get a #JSCValue referencing the JavaScript value of @weak_value.
/// </para>
/// </summary>

/// <param name="weak_value">
/// a #JSCWeakValue
/// </param>
/// <return>
/// a new #JSCValue or %NULL if @weak_value was cleared.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle GetValue(this MentorLake.JavaScriptCore.JSCWeakValueHandle weak_value)
	{
		if (weak_value.IsInvalid) throw new Exception("Invalid handle (JSCWeakValueHandle)");
		return JSCWeakValueHandleExterns.jsc_weak_value_get_value(weak_value);
	}

}

internal class JSCWeakValueHandleExterns
{
	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCWeakValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCWeakValueHandle jsc_weak_value_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_weak_value_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCWeakValueHandle>))] MentorLake.JavaScriptCore.JSCWeakValueHandle weak_value);

}
