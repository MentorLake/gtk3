namespace MentorLake.Gtk3.Gtk3;

public class GtkOverlayHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkOverlayHandle New()
	{
		return GtkOverlayExterns.gtk_overlay_new();
	}

}

public static class GtkOverlaySignalExtensions
{

	public static IObservable<GtkOverlaySignalStructs.GetChildPositionSignal> Signal_GetChildPosition(this GtkOverlayHandle instance)
	{
		return Observable.Create((IObserver<GtkOverlaySignalStructs.GetChildPositionSignal> obs) =>
		{
			GtkOverlaySignalDelegates.get_child_position handler = (GtkOverlayHandle self, GtkWidgetHandle widget, out GdkRectangle allocation, IntPtr user_data) =>
			{
				allocation = default;

				var signalStruct = new GtkOverlaySignalStructs.GetChildPositionSignal()
				{
					Self = self, Widget = widget, Allocation = allocation, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "get_child_position", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkOverlaySignalStructs
{

public struct GetChildPositionSignal
{
	public GtkOverlayHandle Self;
	public GtkWidgetHandle Widget;
	public GdkRectangle Allocation;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkOverlaySignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool get_child_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkOverlayHandle>))] GtkOverlayHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle widget, out GdkRectangle allocation, IntPtr user_data);

}


public static class GtkOverlayHandleExtensions
{
	public static T AddOverlay<T>(this T overlay, GtkWidgetHandle widget) where T : GtkOverlayHandle
	{
		GtkOverlayExterns.gtk_overlay_add_overlay(overlay, widget);
		return overlay;
	}

	public static bool GetOverlayPassThrough(this GtkOverlayHandle overlay, GtkWidgetHandle widget)
	{
		return GtkOverlayExterns.gtk_overlay_get_overlay_pass_through(overlay, widget);
	}

	public static T ReorderOverlay<T>(this T overlay, GtkWidgetHandle child, int index_) where T : GtkOverlayHandle
	{
		GtkOverlayExterns.gtk_overlay_reorder_overlay(overlay, child, index_);
		return overlay;
	}

	public static T SetOverlayPassThrough<T>(this T overlay, GtkWidgetHandle widget, bool pass_through) where T : GtkOverlayHandle
	{
		GtkOverlayExterns.gtk_overlay_set_overlay_pass_through(overlay, widget, pass_through);
		return overlay;
	}

}

internal class GtkOverlayExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkOverlayHandle gtk_overlay_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_overlay_add_overlay(GtkOverlayHandle overlay, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_overlay_get_overlay_pass_through(GtkOverlayHandle overlay, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_overlay_reorder_overlay(GtkOverlayHandle overlay, GtkWidgetHandle child, int index_);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_overlay_set_overlay_pass_through(GtkOverlayHandle overlay, GtkWidgetHandle widget, bool pass_through);

}
