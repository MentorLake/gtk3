namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkFontChooserWidget widget lists the available fonts,
/// styles and sizes, allowing the user to select a font. It is
/// used in the #GtkFontChooserDialog widget to provide a
/// dialog box for selecting fonts.
/// </para>
/// <para>
/// To set the font which is initially selected, use
/// gtk_font_chooser_set_font() or gtk_font_chooser_set_font_desc().
/// </para>
/// <para>
/// To get the selected font use gtk_font_chooser_get_font() or
/// gtk_font_chooser_get_font_desc().
/// </para>
/// <para>
/// To change the text which is shown in the preview area, use
/// gtk_font_chooser_set_preview_text().
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkFontChooserWidget has a single CSS node with name fontchooser.
/// </para>
/// </summary>

public class GtkFontChooserWidgetHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkFontChooserHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkFontChooserWidget.
/// </para>
/// </summary>

/// <return>
/// a new #GtkFontChooserWidget
/// </return>

	public static MentorLake.Gtk.GtkFontChooserWidgetHandle New()
	{
		return GtkFontChooserWidgetHandleExterns.gtk_font_chooser_widget_new();
	}

}
public static class GtkFontChooserWidgetHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when a font is activated.
/// This usually happens when the user double clicks an item,
/// or an item is selected and the user presses one of the keys
/// Space, Shift+Space, Return or Enter.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// the font name
/// </para>
/// </summary>

	public string Fontname;

	public IntPtr UserData;
}
}

public static class GtkFontChooserWidgetHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when a font is activated.
/// This usually happens when the user double clicks an item,
/// or an item is selected and the user presses one of the keys
/// Space, Shift+Space, Return or Enter.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="fontname">
/// the font name
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void font_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle self, string fontname, IntPtr user_data);

}


public static class GtkFontChooserWidgetHandleExtensions
{
}

internal class GtkFontChooserWidgetHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkFontChooserWidgetHandle gtk_font_chooser_widget_new();

}
