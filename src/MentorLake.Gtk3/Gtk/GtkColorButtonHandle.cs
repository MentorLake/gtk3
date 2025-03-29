namespace MentorLake.Gtk;

public class GtkColorButtonHandle : GtkButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle, GtkColorChooserHandle
{
	public static MentorLake.Gtk.GtkColorButtonHandle New()
	{
		return GtkColorButtonHandleExterns.gtk_color_button_new();
	}

	public static MentorLake.Gtk.GtkColorButtonHandle NewWithColor(MentorLake.Gdk.GdkColorHandle color)
	{
		return GtkColorButtonHandleExterns.gtk_color_button_new_with_color(color);
	}

	public static MentorLake.Gtk.GtkColorButtonHandle NewWithRgba(MentorLake.Gdk.GdkRGBAHandle rgba)
	{
		return GtkColorButtonHandleExterns.gtk_color_button_new_with_rgba(rgba);
	}

}
public static class GtkColorButtonHandleSignalExtensions
{

	public static IObservable<GtkColorButtonHandleSignalStructs.ColorSetSignal> Signal_ColorSet(this GtkColorButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkColorButtonHandleSignalStructs.ColorSetSignal> obs) =>
		{
			GtkColorButtonHandleSignalDelegates.color_set handler = ( MentorLake.Gtk.GtkColorButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkColorButtonHandleSignalStructs.ColorSetSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "color-set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkColorButtonHandleSignalStructs
{

public struct ColorSetSignal
{
	public MentorLake.Gtk.GtkColorButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkColorButtonHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void color_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))] MentorLake.Gtk.GtkColorButtonHandle self, IntPtr user_data);

}


public static class GtkColorButtonHandleExtensions
{
	public static ushort GetAlpha(this MentorLake.Gtk.GtkColorButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkColorButtonHandle)");
		return GtkColorButtonHandleExterns.gtk_color_button_get_alpha(button);
	}

	public static T GetColor<T>(this T button, out MentorLake.Gdk.GdkColor color) where T : GtkColorButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkColorButtonHandle)");
		GtkColorButtonHandleExterns.gtk_color_button_get_color(button, out color);
		return button;
	}

	public static T GetRgba<T>(this T button, out MentorLake.Gdk.GdkRGBA rgba) where T : GtkColorButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkColorButtonHandle)");
		GtkColorButtonHandleExterns.gtk_color_button_get_rgba(button, out rgba);
		return button;
	}

	public static string GetTitle(this MentorLake.Gtk.GtkColorButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkColorButtonHandle)");
		return GtkColorButtonHandleExterns.gtk_color_button_get_title(button);
	}

	public static bool GetUseAlpha(this MentorLake.Gtk.GtkColorButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkColorButtonHandle)");
		return GtkColorButtonHandleExterns.gtk_color_button_get_use_alpha(button);
	}

	public static T SetAlpha<T>(this T button, ushort alpha) where T : GtkColorButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkColorButtonHandle)");
		GtkColorButtonHandleExterns.gtk_color_button_set_alpha(button, alpha);
		return button;
	}

	public static T SetColor<T>(this T button, MentorLake.Gdk.GdkColorHandle color) where T : GtkColorButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkColorButtonHandle)");
		GtkColorButtonHandleExterns.gtk_color_button_set_color(button, color);
		return button;
	}

	public static T SetRgba<T>(this T button, MentorLake.Gdk.GdkRGBAHandle rgba) where T : GtkColorButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkColorButtonHandle)");
		GtkColorButtonHandleExterns.gtk_color_button_set_rgba(button, rgba);
		return button;
	}

	public static T SetTitle<T>(this T button, string title) where T : GtkColorButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkColorButtonHandle)");
		GtkColorButtonHandleExterns.gtk_color_button_set_title(button, title);
		return button;
	}

	public static T SetUseAlpha<T>(this T button, bool use_alpha) where T : GtkColorButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkColorButtonHandle)");
		GtkColorButtonHandleExterns.gtk_color_button_set_use_alpha(button, use_alpha);
		return button;
	}

}

internal class GtkColorButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkColorButtonHandle gtk_color_button_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkColorButtonHandle gtk_color_button_new_with_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkColorButtonHandle gtk_color_button_new_with_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle rgba);

	[DllImport(GtkLibrary.Name)]
	internal static extern ushort gtk_color_button_get_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))] MentorLake.Gtk.GtkColorButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_button_get_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))] MentorLake.Gtk.GtkColorButtonHandle button, out MentorLake.Gdk.GdkColor color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_button_get_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))] MentorLake.Gtk.GtkColorButtonHandle button, out MentorLake.Gdk.GdkRGBA rgba);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_color_button_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))] MentorLake.Gtk.GtkColorButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_color_button_get_use_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))] MentorLake.Gtk.GtkColorButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_button_set_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))] MentorLake.Gtk.GtkColorButtonHandle button, ushort alpha);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_button_set_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))] MentorLake.Gtk.GtkColorButtonHandle button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_button_set_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))] MentorLake.Gtk.GtkColorButtonHandle button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle rgba);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_button_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))] MentorLake.Gtk.GtkColorButtonHandle button, string title);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_button_set_use_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorButtonHandle>))] MentorLake.Gtk.GtkColorButtonHandle button, bool use_alpha);

}
