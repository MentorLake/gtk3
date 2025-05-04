namespace MentorLake.Gtk;

public class GtkFontChooserWidgetHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkFontChooserHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkFontChooserWidgetHandle New()
	{
		return GtkFontChooserWidgetHandleExterns.gtk_font_chooser_widget_new();
	}

}
public static class GtkFontChooserWidgetHandleSignalExtensions
{

	public static IObservable<GtkFontChooserWidgetHandleSignalStructs.FontActivatedSignal> Signal_FontActivated(this GtkFontChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFontChooserWidgetHandleSignalStructs.FontActivatedSignal> obs) =>
		{
			GtkFontChooserWidgetHandleSignalDelegates.font_activated handler = ( MentorLake.Gtk.GtkFontChooserHandle self,  string fontname,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFontChooserWidgetHandleSignalStructs.FontActivatedSignal()
				{
					Self = self, Fontname = fontname, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "font-activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkFontChooserWidgetHandleSignalStructs
{

public class FontActivatedSignal
{
	public MentorLake.Gtk.GtkFontChooserHandle Self;
	public string Fontname;
	public IntPtr UserData;
}
}

public static class GtkFontChooserWidgetHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void font_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle self, string fontname, IntPtr user_data);

}


public static class GtkFontChooserWidgetHandleExtensions
{
}

internal class GtkFontChooserWidgetHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkFontChooserWidgetHandle gtk_font_chooser_widget_new();

}
