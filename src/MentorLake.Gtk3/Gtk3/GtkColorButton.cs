namespace MentorLake.Gtk3.Gtk3;

public class GtkColorButtonHandle : GtkButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle, GtkColorChooserHandle
{
	public static GtkColorButtonHandle New()
	{
		return GtkColorButtonExterns.gtk_color_button_new();
	}

	public static GtkColorButtonHandle NewWithColor(GdkColorHandle color)
	{
		return GtkColorButtonExterns.gtk_color_button_new_with_color(color);
	}

	public static GtkColorButtonHandle NewWithRgba(GdkRGBAHandle rgba)
	{
		return GtkColorButtonExterns.gtk_color_button_new_with_rgba(rgba);
	}

}

public static class GtkColorButtonSignalExtensions
{

	public static IObservable<GtkColorButtonSignalStructs.ColorSetSignal> Signal_ColorSet(this GtkColorButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkColorButtonSignalStructs.ColorSetSignal> obs) =>
		{
			GtkColorButtonSignalDelegates.color_set handler = (GtkColorButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkColorButtonSignalStructs.ColorSetSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "color_set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkColorButtonSignalStructs
{

public struct ColorSetSignal
{
	public GtkColorButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkColorButtonSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void color_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkColorButtonHandle>))] GtkColorButtonHandle self, IntPtr user_data);

}


public static class GtkColorButtonHandleExtensions
{
	public static ushort GetAlpha(this GtkColorButtonHandle button)
	{
		return GtkColorButtonExterns.gtk_color_button_get_alpha(button);
	}

	public static GtkColorButtonHandle GetColor(this GtkColorButtonHandle button, out GdkColor color)
	{
		GtkColorButtonExterns.gtk_color_button_get_color(button, out color);
		return button;
	}

	public static GtkColorButtonHandle GetRgba(this GtkColorButtonHandle button, out GdkRGBA rgba)
	{
		GtkColorButtonExterns.gtk_color_button_get_rgba(button, out rgba);
		return button;
	}

	public static string GetTitle(this GtkColorButtonHandle button)
	{
		return GtkColorButtonExterns.gtk_color_button_get_title(button);
	}

	public static bool GetUseAlpha(this GtkColorButtonHandle button)
	{
		return GtkColorButtonExterns.gtk_color_button_get_use_alpha(button);
	}

	public static GtkColorButtonHandle SetAlpha(this GtkColorButtonHandle button, ushort alpha)
	{
		GtkColorButtonExterns.gtk_color_button_set_alpha(button, alpha);
		return button;
	}

	public static GtkColorButtonHandle SetColor(this GtkColorButtonHandle button, GdkColorHandle color)
	{
		GtkColorButtonExterns.gtk_color_button_set_color(button, color);
		return button;
	}

	public static GtkColorButtonHandle SetRgba(this GtkColorButtonHandle button, GdkRGBAHandle rgba)
	{
		GtkColorButtonExterns.gtk_color_button_set_rgba(button, rgba);
		return button;
	}

	public static GtkColorButtonHandle SetTitle(this GtkColorButtonHandle button, string title)
	{
		GtkColorButtonExterns.gtk_color_button_set_title(button, title);
		return button;
	}

	public static GtkColorButtonHandle SetUseAlpha(this GtkColorButtonHandle button, bool use_alpha)
	{
		GtkColorButtonExterns.gtk_color_button_set_use_alpha(button, use_alpha);
		return button;
	}

}

internal class GtkColorButtonExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkColorButtonHandle gtk_color_button_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkColorButtonHandle gtk_color_button_new_with_color(GdkColorHandle color);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkColorButtonHandle gtk_color_button_new_with_rgba(GdkRGBAHandle rgba);

	[DllImport(Libraries.Gtk3)]
	internal static extern ushort gtk_color_button_get_alpha(GtkColorButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_button_get_color(GtkColorButtonHandle button, out GdkColor color);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_button_get_rgba(GtkColorButtonHandle button, out GdkRGBA rgba);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_color_button_get_title(GtkColorButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_color_button_get_use_alpha(GtkColorButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_button_set_alpha(GtkColorButtonHandle button, ushort alpha);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_button_set_color(GtkColorButtonHandle button, GdkColorHandle color);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_button_set_rgba(GtkColorButtonHandle button, GdkRGBAHandle rgba);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_button_set_title(GtkColorButtonHandle button, string title);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_button_set_use_alpha(GtkColorButtonHandle button, bool use_alpha);

}
