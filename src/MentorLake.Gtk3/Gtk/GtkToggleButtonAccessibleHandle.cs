namespace MentorLake.Gtk;


public class GtkToggleButtonAccessibleHandle : GtkButtonAccessibleHandle, AtkActionHandle, AtkComponentHandle, AtkImageHandle
{
}
public static class GtkToggleButtonAccessibleHandleSignalExtensions
{
/// <summary>
/// <para>
/// The 'bounds-changed" signal is emitted when the position or
/// size of the component changes.
/// </para>
/// </summary>

	public static IObservable<GtkToggleButtonAccessibleHandleSignalStructs.BoundsChangedSignal> Signal_BoundsChanged(this GtkToggleButtonAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkToggleButtonAccessibleHandleSignalStructs.BoundsChangedSignal> obs) =>
		{
			GtkToggleButtonAccessibleHandleSignalDelegates.bounds_changed handler = ( MentorLake.Atk.AtkComponentHandle self,  MentorLake.Atk.AtkRectangleHandle arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToggleButtonAccessibleHandleSignalStructs.BoundsChangedSignal()
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

public static class GtkToggleButtonAccessibleHandleSignalStructs
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

public static class GtkToggleButtonAccessibleHandleSignalDelegates
{

/// <summary>
/// <para>
/// The 'bounds-changed" signal is emitted when the position or
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


public static class GtkToggleButtonAccessibleHandleExtensions
{
}

internal class GtkToggleButtonAccessibleHandleExterns
{
}
