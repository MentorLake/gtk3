namespace MentorLake.Gtk;

public class GtkCellRendererAccelHandle : GtkCellRendererTextHandle
{
	public static MentorLake.Gtk.GtkCellRendererAccelHandle New()
	{
		return GtkCellRendererAccelHandleExterns.gtk_cell_renderer_accel_new();
	}

}
public static class GtkCellRendererAccelHandleSignalExtensions
{

	public static IObservable<GtkCellRendererAccelHandleSignalStructs.AccelClearedSignal> Signal_AccelCleared(this GtkCellRendererAccelHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCellRendererAccelHandleSignalStructs.AccelClearedSignal> obs) =>
		{
			GtkCellRendererAccelHandleSignalDelegates.accel_cleared handler = ( MentorLake.Gtk.GtkCellRendererAccelHandle self,  string path_string,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellRendererAccelHandleSignalStructs.AccelClearedSignal()
				{
					Self = self, PathString = path_string, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "accel-cleared", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkCellRendererAccelHandleSignalStructs.AccelEditedSignal> Signal_AccelEdited(this GtkCellRendererAccelHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCellRendererAccelHandleSignalStructs.AccelEditedSignal> obs) =>
		{
			GtkCellRendererAccelHandleSignalDelegates.accel_edited handler = ( MentorLake.Gtk.GtkCellRendererAccelHandle self,  string path_string,  uint accel_key,  MentorLake.Gdk.GdkModifierType accel_mods,  uint hardware_keycode,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellRendererAccelHandleSignalStructs.AccelEditedSignal()
				{
					Self = self, PathString = path_string, AccelKey = accel_key, AccelMods = accel_mods, HardwareKeycode = hardware_keycode, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "accel-edited", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkCellRendererAccelHandleSignalStructs
{

public class AccelClearedSignal
{
	public MentorLake.Gtk.GtkCellRendererAccelHandle Self;
	public string PathString;
	public IntPtr UserData;
}

public class AccelEditedSignal
{
	public MentorLake.Gtk.GtkCellRendererAccelHandle Self;
	public string PathString;
	public uint AccelKey;
	public MentorLake.Gdk.GdkModifierType AccelMods;
	public uint HardwareKeycode;
	public IntPtr UserData;
}
}

public static class GtkCellRendererAccelHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void accel_cleared([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererAccelHandle>))] MentorLake.Gtk.GtkCellRendererAccelHandle self, string path_string, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void accel_edited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererAccelHandle>))] MentorLake.Gtk.GtkCellRendererAccelHandle self, string path_string, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods, uint hardware_keycode, IntPtr user_data);

}


public static class GtkCellRendererAccelHandleExtensions
{
}

internal class GtkCellRendererAccelHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCellRendererAccelHandle gtk_cell_renderer_accel_new();

}
