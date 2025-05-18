namespace MentorLake.Gtk;

public class GtkScaleHandle : GtkRangeHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkScaleHandle New(MentorLake.Gtk.GtkOrientation orientation, MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		return GtkScaleHandleExterns.gtk_scale_new(orientation, adjustment);
	}

	public static MentorLake.Gtk.GtkScaleHandle NewWithRange(MentorLake.Gtk.GtkOrientation orientation, double min, double max, double step)
	{
		return GtkScaleHandleExterns.gtk_scale_new_with_range(orientation, min, max, step);
	}

}
public static class GtkScaleHandleSignalExtensions
{

	public static IObservable<GtkScaleHandleSignalStructs.FormatValueSignal> Signal_FormatValue(this GtkScaleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkScaleHandleSignalStructs.FormatValueSignal> obs) =>
		{
			GtkScaleHandleSignalDelegates.format_value handler = ( MentorLake.Gtk.GtkScaleHandle self,  double value,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScaleHandleSignalStructs.FormatValueSignal()
				{
					Self = self, Value = value, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "format-value", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkScaleHandleSignalStructs
{

public class FormatValueSignal
{
	public MentorLake.Gtk.GtkScaleHandle Self;
	public double Value;
	public IntPtr UserData;
	public string ReturnValue;
}
}

public static class GtkScaleHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string format_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle self, double value, IntPtr user_data);

}


public static class GtkScaleHandleExtensions
{
	public static T AddMark<T>(this T scale, double value, MentorLake.Gtk.GtkPositionType position, string markup) where T : GtkScaleHandle
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		GtkScaleHandleExterns.gtk_scale_add_mark(scale, value, position, markup);
		return scale;
	}

	public static T ClearMarks<T>(this T scale) where T : GtkScaleHandle
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		GtkScaleHandleExterns.gtk_scale_clear_marks(scale);
		return scale;
	}

	public static int GetDigits(this MentorLake.Gtk.GtkScaleHandle scale)
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		return GtkScaleHandleExterns.gtk_scale_get_digits(scale);
	}

	public static bool GetDrawValue(this MentorLake.Gtk.GtkScaleHandle scale)
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		return GtkScaleHandleExterns.gtk_scale_get_draw_value(scale);
	}

	public static bool GetHasOrigin(this MentorLake.Gtk.GtkScaleHandle scale)
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		return GtkScaleHandleExterns.gtk_scale_get_has_origin(scale);
	}

	public static MentorLake.Pango.PangoLayoutHandle GetLayout(this MentorLake.Gtk.GtkScaleHandle scale)
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		return GtkScaleHandleExterns.gtk_scale_get_layout(scale);
	}

	public static T GetLayoutOffsets<T>(this T scale, out int x, out int y) where T : GtkScaleHandle
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		GtkScaleHandleExterns.gtk_scale_get_layout_offsets(scale, out x, out y);
		return scale;
	}

	public static MentorLake.Gtk.GtkPositionType GetValuePos(this MentorLake.Gtk.GtkScaleHandle scale)
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		return GtkScaleHandleExterns.gtk_scale_get_value_pos(scale);
	}

	public static T SetDigits<T>(this T scale, int digits) where T : GtkScaleHandle
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		GtkScaleHandleExterns.gtk_scale_set_digits(scale, digits);
		return scale;
	}

	public static T SetDrawValue<T>(this T scale, bool draw_value) where T : GtkScaleHandle
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		GtkScaleHandleExterns.gtk_scale_set_draw_value(scale, draw_value);
		return scale;
	}

	public static T SetHasOrigin<T>(this T scale, bool has_origin) where T : GtkScaleHandle
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		GtkScaleHandleExterns.gtk_scale_set_has_origin(scale, has_origin);
		return scale;
	}

	public static T SetValuePos<T>(this T scale, MentorLake.Gtk.GtkPositionType pos) where T : GtkScaleHandle
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		GtkScaleHandleExterns.gtk_scale_set_value_pos(scale, pos);
		return scale;
	}

}

internal class GtkScaleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))]
	internal static extern MentorLake.Gtk.GtkScaleHandle gtk_scale_new(MentorLake.Gtk.GtkOrientation orientation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))]
	internal static extern MentorLake.Gtk.GtkScaleHandle gtk_scale_new_with_range(MentorLake.Gtk.GtkOrientation orientation, double min, double max, double step);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scale_add_mark([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale, double value, MentorLake.Gtk.GtkPositionType position, string markup);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scale_clear_marks([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_scale_get_digits([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_scale_get_draw_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_scale_get_has_origin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))]
	internal static extern MentorLake.Pango.PangoLayoutHandle gtk_scale_get_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scale_get_layout_offsets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale, out int x, out int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPositionType gtk_scale_get_value_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scale_set_digits([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale, int digits);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scale_set_draw_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale, bool draw_value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scale_set_has_origin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale, bool has_origin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scale_set_value_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale, MentorLake.Gtk.GtkPositionType pos);

}
