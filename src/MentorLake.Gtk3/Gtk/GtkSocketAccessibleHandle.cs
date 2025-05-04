namespace MentorLake.Gtk;

public class GtkSocketAccessibleHandle : GtkContainerAccessibleHandle, AtkComponentHandle
{
}
public static class GtkSocketAccessibleHandleSignalExtensions
{

	public static IObservable<GtkSocketAccessibleHandleSignalStructs.BoundsChangedSignal> Signal_BoundsChanged(this GtkSocketAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSocketAccessibleHandleSignalStructs.BoundsChangedSignal> obs) =>
		{
			GtkSocketAccessibleHandleSignalDelegates.bounds_changed handler = ( MentorLake.Atk.AtkComponentHandle self,  MentorLake.Atk.AtkRectangleHandle arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSocketAccessibleHandleSignalStructs.BoundsChangedSignal()
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

public static class GtkSocketAccessibleHandleSignalStructs
{

public class BoundsChangedSignal
{
	public MentorLake.Atk.AtkComponentHandle Self;
	public MentorLake.Atk.AtkRectangleHandle Arg1;
	public IntPtr UserData;
}
}

public static class GtkSocketAccessibleHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void bounds_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRectangleHandle>))] MentorLake.Atk.AtkRectangleHandle arg1, IntPtr user_data);

}


public static class GtkSocketAccessibleHandleExtensions
{
	public static T Embed<T>(this T socket, string path) where T : GtkSocketAccessibleHandle
	{
		if (socket.IsInvalid || socket.IsClosed) throw new Exception("Invalid or closed handle (GtkSocketAccessibleHandle)");
		GtkSocketAccessibleHandleExterns.gtk_socket_accessible_embed(socket, path);
		return socket;
	}

}

internal class GtkSocketAccessibleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_socket_accessible_embed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSocketAccessibleHandle>))] MentorLake.Gtk.GtkSocketAccessibleHandle socket, string path);

}
