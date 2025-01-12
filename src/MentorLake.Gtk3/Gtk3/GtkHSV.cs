namespace MentorLake.Gtk3.Gtk3;

public class GtkHSVHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkHSVHandle GtkHsvNew()
	{
		return GtkHSVExterns.gtk_hsv_new();
	}

	public static void GtkHsvToRgb(double h, double s, double v, out double r, out double g, out double b)
	{
		GtkHSVExterns.gtk_hsv_to_rgb(h, s, v, out r, out g, out b);
	}

}

public static class GtkHSVSignalExtensions
{

	public static IObservable<GtkHSVSignalStructs.ChangedSignal> Signal_Changed(this GtkHSVHandle instance)
	{
		return Observable.Create((IObserver<GtkHSVSignalStructs.ChangedSignal> obs) =>
		{
			GtkHSVSignalDelegates.changed handler = (GtkHSVHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkHSVSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkHSVSignalStructs.MoveSignal> Signal_Move(this GtkHSVHandle instance)
	{
		return Observable.Create((IObserver<GtkHSVSignalStructs.MoveSignal> obs) =>
		{
			GtkHSVSignalDelegates.move handler = (GtkHSVHandle self, GtkDirectionType @object, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkHSVSignalStructs.MoveSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "move", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkHSVSignalStructs
{

public struct ChangedSignal
{
	public GtkHSVHandle Self;
	public IntPtr UserData;
}

public struct MoveSignal
{
	public GtkHSVHandle Self;
	public GtkDirectionType Object;
	public IntPtr UserData;
}
}

public static class GtkHSVSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkHSVHandle>))] GtkHSVHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkHSVHandle>))] GtkHSVHandle self, GtkDirectionType @object, IntPtr user_data);

}


public static class GtkHSVHandleExtensions
{
	public static GtkHSVHandle GtkHsvGetColor(this GtkHSVHandle hsv, out double h, out double s, out double v)
	{
		GtkHSVExterns.gtk_hsv_get_color(hsv, out h, out s, out v);
		return hsv;
	}

	public static GtkHSVHandle GtkHsvGetMetrics(this GtkHSVHandle hsv, out int size, out int ring_width)
	{
		GtkHSVExterns.gtk_hsv_get_metrics(hsv, out size, out ring_width);
		return hsv;
	}

	public static bool GtkHsvIsAdjusting(this GtkHSVHandle hsv)
	{
		return GtkHSVExterns.gtk_hsv_is_adjusting(hsv);
	}

	public static GtkHSVHandle GtkHsvSetColor(this GtkHSVHandle hsv, double h, double s, double v)
	{
		GtkHSVExterns.gtk_hsv_set_color(hsv, h, s, v);
		return hsv;
	}

	public static GtkHSVHandle GtkHsvSetMetrics(this GtkHSVHandle hsv, int size, int ring_width)
	{
		GtkHSVExterns.gtk_hsv_set_metrics(hsv, size, ring_width);
		return hsv;
	}

}

internal class GtkHSVExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkHSVHandle gtk_hsv_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_hsv_get_color(GtkHSVHandle hsv, out double h, out double s, out double v);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_hsv_get_metrics(GtkHSVHandle hsv, out int size, out int ring_width);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_hsv_is_adjusting(GtkHSVHandle hsv);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_hsv_set_color(GtkHSVHandle hsv, double h, double s, double v);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_hsv_set_metrics(GtkHSVHandle hsv, int size, int ring_width);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_hsv_to_rgb(double h, double s, double v, out double r, out double g, out double b);

}
