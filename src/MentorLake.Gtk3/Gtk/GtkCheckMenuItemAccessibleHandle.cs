namespace MentorLake.Gtk;


public class GtkCheckMenuItemAccessibleHandle : GtkMenuItemAccessibleHandle, AtkActionHandle, AtkComponentHandle, AtkSelectionHandle
{
}
public static class GtkCheckMenuItemAccessibleHandleSignalExtensions
{
/// <summary>
/// <para>
/// The 'bounds-changed" signal is emitted when the position or
/// size of the component changes.
/// </para>
/// </summary>

	public static IObservable<GtkCheckMenuItemAccessibleHandleSignalStructs.BoundsChangedSignal> Signal_BoundsChanged(this GtkCheckMenuItemAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCheckMenuItemAccessibleHandleSignalStructs.BoundsChangedSignal> obs) =>
		{
			GtkCheckMenuItemAccessibleHandleSignalDelegates.bounds_changed handler = ( MentorLake.Atk.AtkComponentHandle self,  MentorLake.Atk.AtkRectangleHandle arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCheckMenuItemAccessibleHandleSignalStructs.BoundsChangedSignal()
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
/// <summary>
/// <para>
/// The "selection-changed" signal is emitted by an object which
/// implements AtkSelection interface when the selection changes.
/// </para>
/// </summary>

	public static IObservable<GtkCheckMenuItemAccessibleHandleSignalStructs.SelectionChangedSignal> Signal_SelectionChanged(this GtkCheckMenuItemAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCheckMenuItemAccessibleHandleSignalStructs.SelectionChangedSignal> obs) =>
		{
			GtkCheckMenuItemAccessibleHandleSignalDelegates.selection_changed handler = ( MentorLake.Atk.AtkSelectionHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCheckMenuItemAccessibleHandleSignalStructs.SelectionChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selection-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkCheckMenuItemAccessibleHandleSignalStructs
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

public class SelectionChangedSignal
{

	public MentorLake.Atk.AtkSelectionHandle Self;

	public IntPtr UserData;
}
}

public static class GtkCheckMenuItemAccessibleHandleSignalDelegates
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


/// <summary>
/// <para>
/// The "selection-changed" signal is emitted by an object which
/// implements AtkSelection interface when the selection changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkSelectionHandleImpl>))] MentorLake.Atk.AtkSelectionHandle self, IntPtr user_data);

}


public static class GtkCheckMenuItemAccessibleHandleExtensions
{
}

internal class GtkCheckMenuItemAccessibleHandleExterns
{
}
