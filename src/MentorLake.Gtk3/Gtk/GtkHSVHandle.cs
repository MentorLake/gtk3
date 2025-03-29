namespace MentorLake.Gtk;

public class GtkHSVHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkHSVHandle New()
	{
		return GtkHSVHandleExterns.gtk_hsv_new();
	}

	public static void ToRgb(double h, double s, double v, out double r, out double g, out double b)
	{
		GtkHSVHandleExterns.gtk_hsv_to_rgb(h, s, v, out r, out g, out b);
	}

}
public static class GtkHSVHandleSignalExtensions
{

	public static IObservable<GtkHSVHandleSignalStructs.ChangedSignal> Signal_Changed(this GtkHSVHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkHSVHandleSignalStructs.ChangedSignal> obs) =>
		{
			GtkHSVHandleSignalDelegates.changed handler = ( MentorLake.Gtk.GtkHSVHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkHSVHandleSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkHSVHandleSignalStructs.MoveSignal> Signal_Move(this GtkHSVHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkHSVHandleSignalStructs.MoveSignal> obs) =>
		{
			GtkHSVHandleSignalDelegates.move handler = ( MentorLake.Gtk.GtkHSVHandle self,  MentorLake.Gtk.GtkDirectionType @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkHSVHandleSignalStructs.MoveSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkHSVHandleSignalStructs
{

public struct ChangedSignal
{
	public MentorLake.Gtk.GtkHSVHandle Self;
	public IntPtr UserData;
}

public struct MoveSignal
{
	public MentorLake.Gtk.GtkHSVHandle Self;
	public MentorLake.Gtk.GtkDirectionType Object;
	public IntPtr UserData;
}
}

public static class GtkHSVHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHSVHandle>))] MentorLake.Gtk.GtkHSVHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHSVHandle>))] MentorLake.Gtk.GtkHSVHandle self, MentorLake.Gtk.GtkDirectionType @object, IntPtr user_data);

}


public static class GtkHSVHandleExtensions
{
	public static T GetColor<T>(this T hsv, out double h, out double s, out double v) where T : GtkHSVHandle
	{
		if (hsv.IsInvalid || hsv.IsClosed) throw new Exception("Invalid or closed handle (GtkHSVHandle)");
		GtkHSVHandleExterns.gtk_hsv_get_color(hsv, out h, out s, out v);
		return hsv;
	}

	public static T GetMetrics<T>(this T hsv, out int size, out int ring_width) where T : GtkHSVHandle
	{
		if (hsv.IsInvalid || hsv.IsClosed) throw new Exception("Invalid or closed handle (GtkHSVHandle)");
		GtkHSVHandleExterns.gtk_hsv_get_metrics(hsv, out size, out ring_width);
		return hsv;
	}

	public static bool IsAdjusting(this MentorLake.Gtk.GtkHSVHandle hsv)
	{
		if (hsv.IsInvalid || hsv.IsClosed) throw new Exception("Invalid or closed handle (GtkHSVHandle)");
		return GtkHSVHandleExterns.gtk_hsv_is_adjusting(hsv);
	}

	public static T SetColor<T>(this T hsv, double h, double s, double v) where T : GtkHSVHandle
	{
		if (hsv.IsInvalid || hsv.IsClosed) throw new Exception("Invalid or closed handle (GtkHSVHandle)");
		GtkHSVHandleExterns.gtk_hsv_set_color(hsv, h, s, v);
		return hsv;
	}

	public static T SetMetrics<T>(this T hsv, int size, int ring_width) where T : GtkHSVHandle
	{
		if (hsv.IsInvalid || hsv.IsClosed) throw new Exception("Invalid or closed handle (GtkHSVHandle)");
		GtkHSVHandleExterns.gtk_hsv_set_metrics(hsv, size, ring_width);
		return hsv;
	}

}

internal class GtkHSVHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkHSVHandle gtk_hsv_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_hsv_get_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHSVHandle>))] MentorLake.Gtk.GtkHSVHandle hsv, out double h, out double s, out double v);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_hsv_get_metrics([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHSVHandle>))] MentorLake.Gtk.GtkHSVHandle hsv, out int size, out int ring_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_hsv_is_adjusting([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHSVHandle>))] MentorLake.Gtk.GtkHSVHandle hsv);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_hsv_set_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHSVHandle>))] MentorLake.Gtk.GtkHSVHandle hsv, double h, double s, double v);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_hsv_set_metrics([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHSVHandle>))] MentorLake.Gtk.GtkHSVHandle hsv, int size, int ring_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_hsv_to_rgb(double h, double s, double v, out double r, out double g, out double b);

}
