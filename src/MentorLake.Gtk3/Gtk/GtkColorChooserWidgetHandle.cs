namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkColorChooserWidget widget lets the user select a
/// color. By default, the chooser presents a predefined palette
/// of colors, plus a small number of settable custom colors.
/// It is also possible to select a different color with the
/// single-color editor. To enter the single-color editing mode,
/// use the context menu of any color of the palette, or use the
/// '+' button to add a new custom color.
/// </para>
/// <para>
/// The chooser automatically remembers the last selection, as well
/// as custom colors.
/// </para>
/// <para>
/// To change the initially selected color, use gtk_color_chooser_set_rgba().
/// To get the selected color use gtk_color_chooser_get_rgba().
/// </para>
/// <para>
/// The #GtkColorChooserWidget is used in the #GtkColorChooserDialog
/// to provide a dialog for selecting colors.
/// </para>
/// <para>
/// # CSS names
/// </para>
/// <para>
/// GtkColorChooserWidget has a single CSS node with name colorchooser.
/// </para>
/// </summary>

public class GtkColorChooserWidgetHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkColorChooserHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkColorChooserWidget.
/// </para>
/// </summary>

/// <return>
/// a new #GtkColorChooserWidget
/// </return>

	public static MentorLake.Gtk.GtkColorChooserWidgetHandle New()
	{
		return GtkColorChooserWidgetHandleExterns.gtk_color_chooser_widget_new();
	}

}
public static class GtkColorChooserWidgetHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when a color is activated from the color chooser.
/// This usually happens when the user clicks a color swatch,
/// or a color is selected and the user presses one of the keys
/// Space, Shift+Space, Return or Enter.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// the color
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkRGBAHandle Color;

	public IntPtr UserData;
}
}

public static class GtkColorChooserWidgetHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when a color is activated from the color chooser.
/// This usually happens when the user clicks a color swatch,
/// or a color is selected and the user presses one of the keys
/// Space, Shift+Space, Return or Enter.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="color">
/// the color
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void color_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorChooserHandleImpl>))] MentorLake.Gtk.GtkColorChooserHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle color, IntPtr user_data);

}


public static class GtkColorChooserWidgetHandleExtensions
{
}

internal class GtkColorChooserWidgetHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkColorChooserWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkColorChooserWidgetHandle gtk_color_chooser_widget_new();

}
