namespace MentorLake.Gtk;

public class GtkOverlayHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkOverlayHandle New()
	{
		return GtkOverlayHandleExterns.gtk_overlay_new();
	}

}
public static class GtkOverlayHandleSignalExtensions
{

	public static IObservable<GtkOverlayHandleSignalStructs.GetChildPositionSignal> Signal_GetChildPosition(this GtkOverlayHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkOverlayHandleSignalStructs.GetChildPositionSignal> obs) =>
		{
			GtkOverlayHandleSignalDelegates.get_child_position handler = ( MentorLake.Gtk.GtkOverlayHandle self,  MentorLake.Gtk.GtkWidgetHandle widget, out MentorLake.Gdk.GdkRectangleHandle allocation,  IntPtr user_data) =>
			{
				allocation = default;

				var signalStruct = new GtkOverlayHandleSignalStructs.GetChildPositionSignal()
				{
					Self = self, Widget = widget, Allocation = allocation, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "get-child-position", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkOverlayHandleSignalStructs
{

public class GetChildPositionSignal
{
	public MentorLake.Gtk.GtkOverlayHandle Self;
	public MentorLake.Gtk.GtkWidgetHandle Widget;
	public MentorLake.Gdk.GdkRectangleHandle Allocation;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkOverlayHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool get_child_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkOverlayHandle>))] MentorLake.Gtk.GtkOverlayHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] out MentorLake.Gdk.GdkRectangleHandle allocation, IntPtr user_data);

}


public static class GtkOverlayHandleExtensions
{
	public static T AddOverlay<T>(this T overlay, MentorLake.Gtk.GtkWidgetHandle widget) where T : GtkOverlayHandle
	{
		if (overlay.IsInvalid) throw new Exception("Invalid handle (GtkOverlayHandle)");
		GtkOverlayHandleExterns.gtk_overlay_add_overlay(overlay, widget);
		return overlay;
	}

	public static bool GetOverlayPassThrough(this MentorLake.Gtk.GtkOverlayHandle overlay, MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (overlay.IsInvalid) throw new Exception("Invalid handle (GtkOverlayHandle)");
		return GtkOverlayHandleExterns.gtk_overlay_get_overlay_pass_through(overlay, widget);
	}

	public static T ReorderOverlay<T>(this T overlay, MentorLake.Gtk.GtkWidgetHandle child, int index_) where T : GtkOverlayHandle
	{
		if (overlay.IsInvalid) throw new Exception("Invalid handle (GtkOverlayHandle)");
		GtkOverlayHandleExterns.gtk_overlay_reorder_overlay(overlay, child, index_);
		return overlay;
	}

	public static T SetOverlayPassThrough<T>(this T overlay, MentorLake.Gtk.GtkWidgetHandle widget, bool pass_through) where T : GtkOverlayHandle
	{
		if (overlay.IsInvalid) throw new Exception("Invalid handle (GtkOverlayHandle)");
		GtkOverlayHandleExterns.gtk_overlay_set_overlay_pass_through(overlay, widget, pass_through);
		return overlay;
	}

}

internal class GtkOverlayHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkOverlayHandle>))]
	internal static extern MentorLake.Gtk.GtkOverlayHandle gtk_overlay_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_overlay_add_overlay([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkOverlayHandle>))] MentorLake.Gtk.GtkOverlayHandle overlay, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_overlay_get_overlay_pass_through([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkOverlayHandle>))] MentorLake.Gtk.GtkOverlayHandle overlay, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_overlay_reorder_overlay([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkOverlayHandle>))] MentorLake.Gtk.GtkOverlayHandle overlay, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, int index_);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_overlay_set_overlay_pass_through([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkOverlayHandle>))] MentorLake.Gtk.GtkOverlayHandle overlay, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool pass_through);

}
