namespace MentorLake.Gtk;

public class GtkLevelBarAccessibleHandle : GtkWidgetAccessibleHandle, AtkComponentHandle, AtkValueHandle
{
}
public static class GtkLevelBarAccessibleHandleSignalExtensions
{

	public static IObservable<GtkLevelBarAccessibleHandleSignalStructs.BoundsChangedSignal> Signal_BoundsChanged(this GtkLevelBarAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLevelBarAccessibleHandleSignalStructs.BoundsChangedSignal> obs) =>
		{
			GtkLevelBarAccessibleHandleSignalDelegates.bounds_changed handler = ( MentorLake.Atk.AtkComponentHandle self,  MentorLake.Atk.AtkRectangleHandle arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLevelBarAccessibleHandleSignalStructs.BoundsChangedSignal()
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

	public static IObservable<GtkLevelBarAccessibleHandleSignalStructs.ValueChangedSignal> Signal_ValueChanged(this GtkLevelBarAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLevelBarAccessibleHandleSignalStructs.ValueChangedSignal> obs) =>
		{
			GtkLevelBarAccessibleHandleSignalDelegates.value_changed handler = ( MentorLake.Atk.AtkValueHandle self,  double value,  string text,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLevelBarAccessibleHandleSignalStructs.ValueChangedSignal()
				{
					Self = self, Value = value, Text = text, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "value-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkLevelBarAccessibleHandleSignalStructs
{

public class BoundsChangedSignal
{
	public MentorLake.Atk.AtkComponentHandle Self;
	public MentorLake.Atk.AtkRectangleHandle Arg1;
	public IntPtr UserData;
}

public class ValueChangedSignal
{
	public MentorLake.Atk.AtkValueHandle Self;
	public double Value;
	public string Text;
	public IntPtr UserData;
}
}

public static class GtkLevelBarAccessibleHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void bounds_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRectangleHandle>))] MentorLake.Atk.AtkRectangleHandle arg1, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void value_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle self, double value, string text, IntPtr user_data);

}


public static class GtkLevelBarAccessibleHandleExtensions
{
}

internal class GtkLevelBarAccessibleHandleExterns
{
}
