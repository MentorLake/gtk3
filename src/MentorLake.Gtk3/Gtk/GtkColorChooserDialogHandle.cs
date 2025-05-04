namespace MentorLake.Gtk;

public class GtkColorChooserDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkColorChooserHandle
{
	public static MentorLake.Gtk.GtkColorChooserDialogHandle New(string title, MentorLake.Gtk.GtkWindowHandle parent)
	{
		return GtkColorChooserDialogHandleExterns.gtk_color_chooser_dialog_new(title, parent);
	}

}
public static class GtkColorChooserDialogHandleSignalExtensions
{

	public static IObservable<GtkColorChooserDialogHandleSignalStructs.ColorActivatedSignal> Signal_ColorActivated(this GtkColorChooserDialogHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkColorChooserDialogHandleSignalStructs.ColorActivatedSignal> obs) =>
		{
			GtkColorChooserDialogHandleSignalDelegates.color_activated handler = ( MentorLake.Gtk.GtkColorChooserHandle self,  MentorLake.Gdk.GdkRGBAHandle color,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkColorChooserDialogHandleSignalStructs.ColorActivatedSignal()
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

public static class GtkColorChooserDialogHandleSignalStructs
{

public class ColorActivatedSignal
{
	public MentorLake.Gtk.GtkColorChooserHandle Self;
	public MentorLake.Gdk.GdkRGBAHandle Color;
	public IntPtr UserData;
}
}

public static class GtkColorChooserDialogHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void color_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorChooserHandleImpl>))] MentorLake.Gtk.GtkColorChooserHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle color, IntPtr user_data);

}


public static class GtkColorChooserDialogHandleExtensions
{
}

internal class GtkColorChooserDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkColorChooserDialogHandle gtk_color_chooser_dialog_new(string title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent);

}
