namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkHSV is the “color wheel” part of a complete color selector widget.
/// It allows to select a color by determining its HSV components in an
/// intuitive way. Moving the selection around the outer ring changes the hue,
/// and moving the selection point inside the inner triangle changes value and
/// saturation.
/// </para>
/// <para>
/// #GtkHSV has been deprecated together with #GtkColorSelection, where
/// it was used.
/// </para>
/// </summary>

public class GtkHSVHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new HSV color selector.
/// </para>
/// </summary>

/// <return>
/// A newly-created HSV color selector.
/// </return>

	public static MentorLake.Gtk.GtkHSVHandle New()
	{
		return GtkHSVHandleExterns.gtk_hsv_new();
	}

/// <summary>
/// <para>
/// Converts a color from HSV space to RGB.
/// </para>
/// <para>
/// Input values must be in the [0.0, 1.0] range;
/// output values will be in the same range.
/// </para>
/// </summary>

/// <param name="h">
/// Hue
/// </param>
/// <param name="s">
/// Saturation
/// </param>
/// <param name="v">
/// Value
/// </param>
/// <param name="r">
/// Return value for the red component
/// </param>
/// <param name="g">
/// Return value for the green component
/// </param>
/// <param name="b">
/// Return value for the blue component
/// </param>

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

public class ChangedSignal
{

	public MentorLake.Gtk.GtkHSVHandle Self;

	public IntPtr UserData;
}

public class MoveSignal
{

	public MentorLake.Gtk.GtkHSVHandle Self;

	public MentorLake.Gtk.GtkDirectionType Object;

	public IntPtr UserData;
}
}

public static class GtkHSVHandleSignalDelegates
{


/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHSVHandle>))] MentorLake.Gtk.GtkHSVHandle self, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="@object">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHSVHandle>))] MentorLake.Gtk.GtkHSVHandle self, MentorLake.Gtk.GtkDirectionType @object, IntPtr user_data);

}


public static class GtkHSVHandleExtensions
{
/// <summary>
/// <para>
/// Queries the current color in an HSV color selector.
/// Returned values will be in the [0.0, 1.0] range.
/// </para>
/// </summary>

/// <param name="hsv">
/// An HSV color selector
/// </param>
/// <param name="h">
/// Return value for the hue
/// </param>
/// <param name="s">
/// Return value for the saturation
/// </param>
/// <param name="v">
/// Return value for the value
/// </param>

	public static T GetColor<T>(this T hsv, out double h, out double s, out double v) where T : GtkHSVHandle
	{
		if (hsv.IsInvalid) throw new Exception("Invalid handle (GtkHSVHandle)");
		GtkHSVHandleExterns.gtk_hsv_get_color(hsv, out h, out s, out v);
		return hsv;
	}

/// <summary>
/// <para>
/// Queries the size and ring width of an HSV color selector.
/// </para>
/// </summary>

/// <param name="hsv">
/// An HSV color selector
/// </param>
/// <param name="size">
/// Return value for the diameter of the hue ring
/// </param>
/// <param name="ring_width">
/// Return value for the width of the hue ring
/// </param>

	public static T GetMetrics<T>(this T hsv, out int size, out int ring_width) where T : GtkHSVHandle
	{
		if (hsv.IsInvalid) throw new Exception("Invalid handle (GtkHSVHandle)");
		GtkHSVHandleExterns.gtk_hsv_get_metrics(hsv, out size, out ring_width);
		return hsv;
	}

/// <summary>
/// <para>
/// An HSV color selector can be said to be adjusting if multiple rapid
/// changes are being made to its value, for example, when the user is
/// adjusting the value with the mouse. This function queries whether
/// the HSV color selector is being adjusted or not.
/// </para>
/// </summary>

/// <param name="hsv">
/// A #GtkHSV
/// </param>
/// <return>
/// %TRUE if clients can ignore changes to the color value,
///     since they may be transitory, or %FALSE if they should consider
///     the color value status to be final.
/// </return>

	public static bool IsAdjusting(this MentorLake.Gtk.GtkHSVHandle hsv)
	{
		if (hsv.IsInvalid) throw new Exception("Invalid handle (GtkHSVHandle)");
		return GtkHSVHandleExterns.gtk_hsv_is_adjusting(hsv);
	}

/// <summary>
/// <para>
/// Sets the current color in an HSV color selector.
/// Color component values must be in the [0.0, 1.0] range.
/// </para>
/// </summary>

/// <param name="hsv">
/// An HSV color selector
/// </param>
/// <param name="h">
/// Hue
/// </param>
/// <param name="s">
/// Saturation
/// </param>
/// <param name="v">
/// Value
/// </param>

	public static T SetColor<T>(this T hsv, double h, double s, double v) where T : GtkHSVHandle
	{
		if (hsv.IsInvalid) throw new Exception("Invalid handle (GtkHSVHandle)");
		GtkHSVHandleExterns.gtk_hsv_set_color(hsv, h, s, v);
		return hsv;
	}

/// <summary>
/// <para>
/// Sets the size and ring width of an HSV color selector.
/// </para>
/// </summary>

/// <param name="hsv">
/// An HSV color selector
/// </param>
/// <param name="size">
/// Diameter for the hue ring
/// </param>
/// <param name="ring_width">
/// Width of the hue ring
/// </param>

	public static T SetMetrics<T>(this T hsv, int size, int ring_width) where T : GtkHSVHandle
	{
		if (hsv.IsInvalid) throw new Exception("Invalid handle (GtkHSVHandle)");
		GtkHSVHandleExterns.gtk_hsv_set_metrics(hsv, size, ring_width);
		return hsv;
	}

}

internal class GtkHSVHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkHSVHandle>))]
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
