namespace MentorLake.Atk;

public class AtkSocketHandle : AtkObjectHandle, AtkComponentHandle
{
	public static MentorLake.Atk.AtkSocketHandle New()
	{
		return AtkSocketHandleExterns.atk_socket_new();
	}

}
public static class AtkSocketHandleSignalExtensions
{

	public static IObservable<AtkSocketHandleSignalStructs.BoundsChangedSignal> Signal_BoundsChanged(this AtkSocketHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkSocketHandleSignalStructs.BoundsChangedSignal> obs) =>
		{
			AtkSocketHandleSignalDelegates.bounds_changed handler = ( MentorLake.Atk.AtkComponentHandle self,  MentorLake.Atk.AtkRectangleHandle arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkSocketHandleSignalStructs.BoundsChangedSignal()
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

public static class AtkSocketHandleSignalStructs
{

public class BoundsChangedSignal
{
	public MentorLake.Atk.AtkComponentHandle Self;
	public MentorLake.Atk.AtkRectangleHandle Arg1;
	public IntPtr UserData;
}
}

public static class AtkSocketHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void bounds_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRectangleHandle>))] MentorLake.Atk.AtkRectangleHandle arg1, IntPtr user_data);

}


public static class AtkSocketHandleExtensions
{
	public static T Embed<T>(this T obj, string plug_id) where T : AtkSocketHandle
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkSocketHandle)");
		AtkSocketHandleExterns.atk_socket_embed(obj, plug_id);
		return obj;
	}

	public static bool IsOccupied(this MentorLake.Atk.AtkSocketHandle obj)
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkSocketHandle)");
		return AtkSocketHandleExterns.atk_socket_is_occupied(obj);
	}

}

internal class AtkSocketHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Atk.AtkSocketHandle>))]
	internal static extern MentorLake.Atk.AtkSocketHandle atk_socket_new();

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_socket_embed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkSocketHandle>))] MentorLake.Atk.AtkSocketHandle obj, string plug_id);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_socket_is_occupied([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkSocketHandle>))] MentorLake.Atk.AtkSocketHandle obj);

}
