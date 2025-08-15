namespace MentorLake.Atk;

/// <summary>
/// <para>
/// Toplevel for embedding into other processes
/// </para>
/// <para>
/// See [class@AtkSocket]
/// </para>
/// </summary>

public class AtkPlugHandle : AtkObjectHandle, AtkComponentHandle
{
/// <summary>
/// <para>
/// Creates a new #AtkPlug instance.
/// </para>
/// </summary>

/// <return>
/// the newly created #AtkPlug
/// </return>

	public static MentorLake.Atk.AtkPlugHandle New()
	{
		return AtkPlugHandleExterns.atk_plug_new();
	}

}
public static class AtkPlugHandleSignalExtensions
{
/// <summary>
/// <para>
/// The &apos;bounds-changed&quot; signal is emitted when the position or
/// size of the component changes.
/// </para>
/// </summary>

	public static IObservable<AtkPlugHandleSignalStructs.BoundsChangedSignal> Signal_BoundsChanged(this AtkPlugHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkPlugHandleSignalStructs.BoundsChangedSignal> obs) =>
		{
			AtkPlugHandleSignalDelegates.bounds_changed handler = ( MentorLake.Atk.AtkComponentHandle self,  MentorLake.Atk.AtkRectangleHandle arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkPlugHandleSignalStructs.BoundsChangedSignal()
				{
					Self = self, Arg1 = arg1, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "bounds-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class AtkPlugHandleSignalStructs
{

public class BoundsChangedSignal
{

	public MentorLake.Atk.AtkComponentHandle Self;
/// <summary>
/// <para>
/// The AtkRectangle giving the new position and size.
/// </para>
/// </summary>

	public MentorLake.Atk.AtkRectangleHandle Arg1;

	public IntPtr UserData;
}
}

public static class AtkPlugHandleSignalDelegates
{

/// <summary>
/// <para>
/// The &apos;bounds-changed&quot; signal is emitted when the position or
/// size of the component changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// The AtkRectangle giving the new position and size.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void bounds_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRectangleHandle>))] MentorLake.Atk.AtkRectangleHandle arg1, IntPtr user_data);

}


public static class AtkPlugHandleExtensions
{
/// <summary>
/// <para>
/// Gets the unique ID of an #AtkPlug object, which can be used to
/// embed inside of an #AtkSocket using atk_socket_embed().
/// </para>
/// <para>
/// Internally, this calls a class function that should be registered
/// by the IPC layer (usually at-spi2-atk). The implementor of an
/// #AtkPlug object should call this function (after atk-bridge is
/// loaded) and pass the value to the process implementing the
/// #AtkSocket, so it could embed the plug.
/// </para>
/// </summary>

/// <param name="plug">
/// an #AtkPlug
/// </param>
/// <return>
/// the unique ID for the plug
/// </return>

	public static string GetId(this MentorLake.Atk.AtkPlugHandle plug)
	{
		if (plug.IsInvalid) throw new Exception("Invalid handle (AtkPlugHandle)");
		return AtkPlugHandleExterns.atk_plug_get_id(plug);
	}

}

internal class AtkPlugHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Atk.AtkPlugHandle>))]
	internal static extern MentorLake.Atk.AtkPlugHandle atk_plug_new();

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_plug_get_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkPlugHandle>))] MentorLake.Atk.AtkPlugHandle plug);

}
