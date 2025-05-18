namespace MentorLake.Gtk;

public class GtkFontChooserDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkFontChooserHandle
{
	public static MentorLake.Gtk.GtkFontChooserDialogHandle New(string title, MentorLake.Gtk.GtkWindowHandle parent)
	{
		return GtkFontChooserDialogHandleExterns.gtk_font_chooser_dialog_new(title, parent);
	}

}
public static class GtkFontChooserDialogHandleSignalExtensions
{

	public static IObservable<GtkFontChooserDialogHandleSignalStructs.FontActivatedSignal> Signal_FontActivated(this GtkFontChooserDialogHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFontChooserDialogHandleSignalStructs.FontActivatedSignal> obs) =>
		{
			GtkFontChooserDialogHandleSignalDelegates.font_activated handler = ( MentorLake.Gtk.GtkFontChooserHandle self,  string fontname,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFontChooserDialogHandleSignalStructs.FontActivatedSignal()
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

public static class GtkFontChooserDialogHandleSignalStructs
{

public class FontActivatedSignal
{
	public MentorLake.Gtk.GtkFontChooserHandle Self;
	public string Fontname;
	public IntPtr UserData;
}
}

public static class GtkFontChooserDialogHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void font_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle self, string fontname, IntPtr user_data);

}


public static class GtkFontChooserDialogHandleExtensions
{
}

internal class GtkFontChooserDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserDialogHandle>))]
	internal static extern MentorLake.Gtk.GtkFontChooserDialogHandle gtk_font_chooser_dialog_new(string title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent);

}
