namespace MentorLake.Gtk;

public class GtkLevelBarHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkLevelBarHandle New()
	{
		return GtkLevelBarHandleExterns.gtk_level_bar_new();
	}

	public static MentorLake.Gtk.GtkLevelBarHandle NewForInterval(double min_value, double max_value)
	{
		return GtkLevelBarHandleExterns.gtk_level_bar_new_for_interval(min_value, max_value);
	}

}
public static class GtkLevelBarHandleSignalExtensions
{

	public static IObservable<GtkLevelBarHandleSignalStructs.OffsetChangedSignal> Signal_OffsetChanged(this GtkLevelBarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLevelBarHandleSignalStructs.OffsetChangedSignal> obs) =>
		{
			GtkLevelBarHandleSignalDelegates.offset_changed handler = ( MentorLake.Gtk.GtkLevelBarHandle self,  string name,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLevelBarHandleSignalStructs.OffsetChangedSignal()
				{
					Self = self, Name = name, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "offset-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkLevelBarHandleSignalStructs
{

public struct OffsetChangedSignal
{
	public MentorLake.Gtk.GtkLevelBarHandle Self;
	public string Name;
	public IntPtr UserData;
}
}

public static class GtkLevelBarHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void offset_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self, string name, IntPtr user_data);

}


public static class GtkLevelBarHandleExtensions
{
	public static T AddOffsetValue<T>(this T self, string name, double value) where T : GtkLevelBarHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkLevelBarHandle)");
		GtkLevelBarHandleExterns.gtk_level_bar_add_offset_value(self, name, value);
		return self;
	}

	public static bool GetInverted(this MentorLake.Gtk.GtkLevelBarHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkLevelBarHandle)");
		return GtkLevelBarHandleExterns.gtk_level_bar_get_inverted(self);
	}

	public static double GetMaxValue(this MentorLake.Gtk.GtkLevelBarHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkLevelBarHandle)");
		return GtkLevelBarHandleExterns.gtk_level_bar_get_max_value(self);
	}

	public static double GetMinValue(this MentorLake.Gtk.GtkLevelBarHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkLevelBarHandle)");
		return GtkLevelBarHandleExterns.gtk_level_bar_get_min_value(self);
	}

	public static MentorLake.Gtk.GtkLevelBarMode GetMode(this MentorLake.Gtk.GtkLevelBarHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkLevelBarHandle)");
		return GtkLevelBarHandleExterns.gtk_level_bar_get_mode(self);
	}

	public static bool GetOffsetValue(this MentorLake.Gtk.GtkLevelBarHandle self, string name, out double value)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkLevelBarHandle)");
		return GtkLevelBarHandleExterns.gtk_level_bar_get_offset_value(self, name, out value);
	}

	public static double GetValue(this MentorLake.Gtk.GtkLevelBarHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkLevelBarHandle)");
		return GtkLevelBarHandleExterns.gtk_level_bar_get_value(self);
	}

	public static T RemoveOffsetValue<T>(this T self, string name) where T : GtkLevelBarHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkLevelBarHandle)");
		GtkLevelBarHandleExterns.gtk_level_bar_remove_offset_value(self, name);
		return self;
	}

	public static T SetInverted<T>(this T self, bool inverted) where T : GtkLevelBarHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkLevelBarHandle)");
		GtkLevelBarHandleExterns.gtk_level_bar_set_inverted(self, inverted);
		return self;
	}

	public static T SetMaxValue<T>(this T self, double value) where T : GtkLevelBarHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkLevelBarHandle)");
		GtkLevelBarHandleExterns.gtk_level_bar_set_max_value(self, value);
		return self;
	}

	public static T SetMinValue<T>(this T self, double value) where T : GtkLevelBarHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkLevelBarHandle)");
		GtkLevelBarHandleExterns.gtk_level_bar_set_min_value(self, value);
		return self;
	}

	public static T SetMode<T>(this T self, MentorLake.Gtk.GtkLevelBarMode mode) where T : GtkLevelBarHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkLevelBarHandle)");
		GtkLevelBarHandleExterns.gtk_level_bar_set_mode(self, mode);
		return self;
	}

	public static T SetValue<T>(this T self, double value) where T : GtkLevelBarHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkLevelBarHandle)");
		GtkLevelBarHandleExterns.gtk_level_bar_set_value(self, value);
		return self;
	}

}

internal class GtkLevelBarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkLevelBarHandle gtk_level_bar_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkLevelBarHandle gtk_level_bar_new_for_interval(double min_value, double max_value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_level_bar_add_offset_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self, string name, double value);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_level_bar_get_inverted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_level_bar_get_max_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_level_bar_get_min_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkLevelBarMode gtk_level_bar_get_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_level_bar_get_offset_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self, string name, out double value);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_level_bar_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_level_bar_remove_offset_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_level_bar_set_inverted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self, bool inverted);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_level_bar_set_max_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self, double value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_level_bar_set_min_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self, double value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_level_bar_set_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self, MentorLake.Gtk.GtkLevelBarMode mode);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_level_bar_set_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self, double value);

}
