namespace MentorLake.Gtk;

public class GtkRadioButtonAccessibleHandle : GtkToggleButtonAccessibleHandle, AtkActionHandle, AtkComponentHandle, AtkImageHandle
{
}
public static class GtkRadioButtonAccessibleHandleSignalExtensions
{

	public static IObservable<GtkRadioButtonAccessibleHandleSignalStructs.BoundsChangedSignal> Signal_BoundsChanged(this GtkRadioButtonAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRadioButtonAccessibleHandleSignalStructs.BoundsChangedSignal> obs) =>
		{
			GtkRadioButtonAccessibleHandleSignalDelegates.bounds_changed handler = ( MentorLake.Atk.AtkComponentHandle self,  MentorLake.Atk.AtkRectangleHandle arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRadioButtonAccessibleHandleSignalStructs.BoundsChangedSignal()
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

public static class GtkRadioButtonAccessibleHandleSignalStructs
{

public class BoundsChangedSignal
{
	public MentorLake.Atk.AtkComponentHandle Self;
	public MentorLake.Atk.AtkRectangleHandle Arg1;
	public IntPtr UserData;
}
}

public static class GtkRadioButtonAccessibleHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void bounds_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRectangleHandle>))] MentorLake.Atk.AtkRectangleHandle arg1, IntPtr user_data);

}


public static class GtkRadioButtonAccessibleHandleExtensions
{
}

internal class GtkRadioButtonAccessibleHandleExterns
{
}
