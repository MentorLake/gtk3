namespace MentorLake.Gtk;


public class GtkProgressBarAccessibleHandle : GtkWidgetAccessibleHandle, AtkComponentHandle, AtkValueHandle
{
}
public static class GtkProgressBarAccessibleHandleSignalExtensions
{
/// <summary>
/// <para>
/// The 'bounds-changed" signal is emitted when the position or
/// size of the component changes.
/// </para>
/// </summary>

	public static IObservable<GtkProgressBarAccessibleHandleSignalStructs.BoundsChangedSignal> Signal_BoundsChanged(this GtkProgressBarAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkProgressBarAccessibleHandleSignalStructs.BoundsChangedSignal> obs) =>
		{
			GtkProgressBarAccessibleHandleSignalDelegates.bounds_changed handler = ( MentorLake.Atk.AtkComponentHandle self,  MentorLake.Atk.AtkRectangleHandle arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkProgressBarAccessibleHandleSignalStructs.BoundsChangedSignal()
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
/// The 'value-changed' signal is emitted when the current value
/// that represent the object changes. @value is the numerical
/// representation of this new value.  @text is the human
/// readable text alternative of @value, and can be NULL if it is
/// not available. Note that if there is a textual description
/// associated with the new numeric value, that description
/// should be included regardless of whether or not it has also
/// changed.
/// </para>
/// <para>
/// Example: a password meter whose value changes as the user
/// types their new password. Appropiate value text would be
/// "weak", "acceptable" and "strong".
/// </para>
/// </summary>

	public static IObservable<GtkProgressBarAccessibleHandleSignalStructs.ValueChangedSignal> Signal_ValueChanged(this GtkProgressBarAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkProgressBarAccessibleHandleSignalStructs.ValueChangedSignal> obs) =>
		{
			GtkProgressBarAccessibleHandleSignalDelegates.value_changed handler = ( MentorLake.Atk.AtkValueHandle self,  double value,  string text,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkProgressBarAccessibleHandleSignalStructs.ValueChangedSignal()
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

public static class GtkProgressBarAccessibleHandleSignalStructs
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

public class ValueChangedSignal
{

	public MentorLake.Atk.AtkValueHandle Self;
/// <summary>
/// <para>
/// the new value in a numerical form.
/// </para>
/// </summary>

	public double Value;
/// <summary>
/// <para>
/// human readable text alternative (also called
/// description) of this object. NULL if not available.
/// </para>
/// </summary>

	public string Text;

	public IntPtr UserData;
}
}

public static class GtkProgressBarAccessibleHandleSignalDelegates
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
/// The 'value-changed' signal is emitted when the current value
/// that represent the object changes. @value is the numerical
/// representation of this new value.  @text is the human
/// readable text alternative of @value, and can be NULL if it is
/// not available. Note that if there is a textual description
/// associated with the new numeric value, that description
/// should be included regardless of whether or not it has also
/// changed.
/// </para>
/// <para>
/// Example: a password meter whose value changes as the user
/// types their new password. Appropiate value text would be
/// "weak", "acceptable" and "strong".
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="value">
/// the new value in a numerical form.
/// </param>
/// <param name="text">
/// human readable text alternative (also called
/// description) of this object. NULL if not available.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void value_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle self, double value, string text, IntPtr user_data);

}


public static class GtkProgressBarAccessibleHandleExtensions
{
}

internal class GtkProgressBarAccessibleHandleExterns
{
}
