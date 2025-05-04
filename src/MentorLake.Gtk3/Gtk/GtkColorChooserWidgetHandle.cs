namespace MentorLake.Gtk;

public class GtkColorChooserWidgetHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkColorChooserHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkColorChooserWidgetHandle New()
	{
		return GtkColorChooserWidgetHandleExterns.gtk_color_chooser_widget_new();
	}

}
public static class GtkColorChooserWidgetHandleSignalExtensions
{

	public static IObservable<GtkColorChooserWidgetHandleSignalStructs.ColorActivatedSignal> Signal_ColorActivated(this GtkColorChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkColorChooserWidgetHandleSignalStructs.ColorActivatedSignal> obs) =>
		{
			GtkColorChooserWidgetHandleSignalDelegates.color_activated handler = ( MentorLake.Gtk.GtkColorChooserHandle self,  MentorLake.Gdk.GdkRGBAHandle color,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkColorChooserWidgetHandleSignalStructs.ColorActivatedSignal()
				{
					Self = self, Color = color, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "color-activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkColorChooserWidgetHandleSignalStructs
{

public class ColorActivatedSignal
{
	public MentorLake.Gtk.GtkColorChooserHandle Self;
	public MentorLake.Gdk.GdkRGBAHandle Color;
	public IntPtr UserData;
}
}

public static class GtkColorChooserWidgetHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void color_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorChooserHandleImpl>))] MentorLake.Gtk.GtkColorChooserHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle color, IntPtr user_data);

}


public static class GtkColorChooserWidgetHandleExtensions
{
}

internal class GtkColorChooserWidgetHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkColorChooserWidgetHandle gtk_color_chooser_widget_new();

}
