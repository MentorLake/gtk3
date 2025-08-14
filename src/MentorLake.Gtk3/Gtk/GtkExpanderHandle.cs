namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkExpander allows the user to hide or show its child by clicking
/// on an expander triangle similar to the triangles used in a #GtkTreeView.
/// </para>
/// <para>
/// Normally you use an expander as you would use any other descendant
/// of #GtkBin; you create the child widget and use gtk_container_add()
/// to add it to the expander. When the expander is toggled, it will take
/// care of showing and hiding the child automatically.
/// </para>
/// <para>
/// # Special Usage
/// </para>
/// <para>
/// There are situations in which you may prefer to show and hide the
/// expanded widget yourself, such as when you want to actually create
/// the widget at expansion time. In this case, create a #GtkExpander
/// but do not add a child to it. The expander widget has an
/// #GtkExpander:expanded property which can be used to monitor
/// its expansion state. You should watch this property with a signal
/// connection as follows:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// static void
/// expander_callback (GObject    *object,
///                    GParamSpec *param_spec,
///                    gpointer    user_data)
/// {
///   GtkExpander *expander;
/// </para>
/// <para>
///   expander = GTK_EXPANDER (object);
/// </para>
/// <para>
///   if (gtk_expander_get_expanded (expander))
///     {
///       // Show or create widgets
///     }
///   else
///     {
///       // Hide or destroy widgets
///     }
/// }
/// </para>
/// <para>
/// static void
/// create_expander (void)
/// {
///   GtkWidget *expander = gtk_expander_new_with_mnemonic ("_More Options");
///   g_signal_connect (expander, "notify::expanded",
///                     G_CALLBACK (expander_callback), NULL);
/// </para>
/// <para>
///   // ...
/// }
/// ]|
/// </para>
/// <para>
/// # GtkExpander as GtkBuildable
/// </para>
/// <para>
/// The GtkExpander implementation of the GtkBuildable interface supports
/// placing a child in the label position by specifying “label” as the
/// “type” attribute of a `<child>` element. A normal content child can be
/// specified without specifying a `<child>` type attribute.
/// </para>
/// <para>
/// An example of a UI definition fragment with GtkExpander:
/// </para>
/// <para>
/// |[<!-- language="xml" -->
/// <object class="GtkExpander">
///   <child type="label">
///     <object class="GtkLabel" id="expander-label"/>
///   </child>
///   <child>
///     <object class="GtkEntry" id="expander-content"/>
///   </child>
/// </object>
/// ]|
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// |[<!-- language="plain" -->
/// expander
/// ├── title
/// │   ├── arrow
/// │   ╰── <label widget>
/// ╰── <child>
/// ]|
/// </para>
/// <para>
/// GtkExpander has three CSS nodes, the main node with the name expander,
/// a subnode with name title and node below it with name arrow. The arrow of an
/// expander that is showing its child gets the :checked pseudoclass added to it.
/// </para>
/// </summary>

public class GtkExpanderHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new expander using @label as the text of the label.
/// </para>
/// </summary>

/// <param name="label">
/// the text of the label
/// </param>
/// <return>
/// a new #GtkExpander widget.
/// </return>

	public static MentorLake.Gtk.GtkExpanderHandle New(string label)
	{
		return GtkExpanderHandleExterns.gtk_expander_new(label);
	}

/// <summary>
/// <para>
/// Creates a new expander using @label as the text of the label.
/// If characters in @label are preceded by an underscore, they are underlined.
/// If you need a literal underscore character in a label, use “__” (two
/// underscores). The first underlined character represents a keyboard
/// accelerator called a mnemonic.
/// Pressing Alt and that key activates the button.
/// </para>
/// </summary>

/// <param name="label">
/// the text of the label with an underscore
///     in front of the mnemonic character
/// </param>
/// <return>
/// a new #GtkExpander widget.
/// </return>

	public static MentorLake.Gtk.GtkExpanderHandle NewWithMnemonic(string label)
	{
		return GtkExpanderHandleExterns.gtk_expander_new_with_mnemonic(label);
	}

}
public static class GtkExpanderHandleSignalExtensions
{

	public static IObservable<GtkExpanderHandleSignalStructs.ActivateSignal> Signal_Activate(this GtkExpanderHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkExpanderHandleSignalStructs.ActivateSignal> obs) =>
		{
			GtkExpanderHandleSignalDelegates.activate handler = ( MentorLake.Gtk.GtkExpanderHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkExpanderHandleSignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkExpanderHandleSignalStructs
{

public class ActivateSignal
{

	public MentorLake.Gtk.GtkExpanderHandle Self;

	public IntPtr UserData;
}
}

public static class GtkExpanderHandleSignalDelegates
{


/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle self, IntPtr user_data);

}


public static class GtkExpanderHandleExtensions
{
/// <summary>
/// <para>
/// Queries a #GtkExpander and returns its current state. Returns %TRUE
/// if the child widget is revealed.
/// </para>
/// <para>
/// See gtk_expander_set_expanded().
/// </para>
/// </summary>

/// <param name="expander">
/// a #GtkExpander
/// </param>
/// <return>
/// the current state of the expander
/// </return>

	public static bool GetExpanded(this MentorLake.Gtk.GtkExpanderHandle expander)
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		return GtkExpanderHandleExterns.gtk_expander_get_expanded(expander);
	}

/// <summary>
/// <para>
/// Fetches the text from a label widget including any embedded
/// underlines indicating mnemonics and Pango markup, as set by
/// gtk_expander_set_label(). If the label text has not been set the
/// return value will be %NULL. This will be the case if you create an
/// empty button with gtk_button_new() to use as a container.
/// </para>
/// <para>
/// Note that this function behaved differently in versions prior to
/// 2.14 and used to return the label text stripped of embedded
/// underlines indicating mnemonics and Pango markup. This problem can
/// be avoided by fetching the label text directly from the label
/// widget.
/// </para>
/// </summary>

/// <param name="expander">
/// a #GtkExpander
/// </param>
/// <return>
/// The text of the label widget. This string is owned
///     by the widget and must not be modified or freed.
/// </return>

	public static string GetLabel(this MentorLake.Gtk.GtkExpanderHandle expander)
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		return GtkExpanderHandleExterns.gtk_expander_get_label(expander);
	}

/// <summary>
/// <para>
/// Returns whether the label widget will fill all available
/// horizontal space allocated to @expander.
/// </para>
/// </summary>

/// <param name="expander">
/// a #GtkExpander
/// </param>
/// <return>
/// %TRUE if the label widget will fill all
///     available horizontal space
/// </return>

	public static bool GetLabelFill(this MentorLake.Gtk.GtkExpanderHandle expander)
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		return GtkExpanderHandleExterns.gtk_expander_get_label_fill(expander);
	}

/// <summary>
/// <para>
/// Retrieves the label widget for the frame. See
/// gtk_expander_set_label_widget().
/// </para>
/// </summary>

/// <param name="expander">
/// a #GtkExpander
/// </param>
/// <return>
/// the label widget,
///     or %NULL if there is none
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetLabelWidget(this MentorLake.Gtk.GtkExpanderHandle expander)
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		return GtkExpanderHandleExterns.gtk_expander_get_label_widget(expander);
	}

/// <summary>
/// <para>
/// Returns whether the expander will resize the toplevel widget
/// containing the expander upon resizing and collpasing.
/// </para>
/// </summary>

/// <param name="expander">
/// a #GtkExpander
/// </param>
/// <return>
/// the “resize toplevel” setting.
/// </return>

	public static bool GetResizeToplevel(this MentorLake.Gtk.GtkExpanderHandle expander)
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		return GtkExpanderHandleExterns.gtk_expander_get_resize_toplevel(expander);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_expander_set_spacing().
/// </para>
/// </summary>

/// <param name="expander">
/// a #GtkExpander
/// </param>
/// <return>
/// spacing between the expander and child
/// </return>

	public static int GetSpacing(this MentorLake.Gtk.GtkExpanderHandle expander)
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		return GtkExpanderHandleExterns.gtk_expander_get_spacing(expander);
	}

/// <summary>
/// <para>
/// Returns whether the label’s text is interpreted as marked up with
/// the [Pango text markup language][PangoMarkupFormat].
/// See gtk_expander_set_use_markup().
/// </para>
/// </summary>

/// <param name="expander">
/// a #GtkExpander
/// </param>
/// <return>
/// %TRUE if the label’s text will be parsed for markup
/// </return>

	public static bool GetUseMarkup(this MentorLake.Gtk.GtkExpanderHandle expander)
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		return GtkExpanderHandleExterns.gtk_expander_get_use_markup(expander);
	}

/// <summary>
/// <para>
/// Returns whether an embedded underline in the expander label
/// indicates a mnemonic. See gtk_expander_set_use_underline().
/// </para>
/// </summary>

/// <param name="expander">
/// a #GtkExpander
/// </param>
/// <return>
/// %TRUE if an embedded underline in the expander
///     label indicates the mnemonic accelerator keys
/// </return>

	public static bool GetUseUnderline(this MentorLake.Gtk.GtkExpanderHandle expander)
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		return GtkExpanderHandleExterns.gtk_expander_get_use_underline(expander);
	}

/// <summary>
/// <para>
/// Sets the state of the expander. Set to %TRUE, if you want
/// the child widget to be revealed, and %FALSE if you want the
/// child widget to be hidden.
/// </para>
/// </summary>

/// <param name="expander">
/// a #GtkExpander
/// </param>
/// <param name="expanded">
/// whether the child widget is revealed
/// </param>

	public static T SetExpanded<T>(this T expander, bool expanded) where T : GtkExpanderHandle
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		GtkExpanderHandleExterns.gtk_expander_set_expanded(expander, expanded);
		return expander;
	}

/// <summary>
/// <para>
/// Sets the text of the label of the expander to @label.
/// </para>
/// <para>
/// This will also clear any previously set labels.
/// </para>
/// </summary>

/// <param name="expander">
/// a #GtkExpander
/// </param>
/// <param name="label">
/// a string
/// </param>

	public static T SetLabel<T>(this T expander, string label) where T : GtkExpanderHandle
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		GtkExpanderHandleExterns.gtk_expander_set_label(expander, label);
		return expander;
	}

/// <summary>
/// <para>
/// Sets whether the label widget should fill all available
/// horizontal space allocated to @expander.
/// </para>
/// <para>
/// Note that this function has no effect since 3.20.
/// </para>
/// </summary>

/// <param name="expander">
/// a #GtkExpander
/// </param>
/// <param name="label_fill">
/// %TRUE if the label should should fill
///     all available horizontal space
/// </param>

	public static T SetLabelFill<T>(this T expander, bool label_fill) where T : GtkExpanderHandle
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		GtkExpanderHandleExterns.gtk_expander_set_label_fill(expander, label_fill);
		return expander;
	}

/// <summary>
/// <para>
/// Set the label widget for the expander. This is the widget
/// that will appear embedded alongside the expander arrow.
/// </para>
/// </summary>

/// <param name="expander">
/// a #GtkExpander
/// </param>
/// <param name="label_widget">
/// the new label widget
/// </param>

	public static T SetLabelWidget<T>(this T expander, MentorLake.Gtk.GtkWidgetHandle label_widget) where T : GtkExpanderHandle
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		GtkExpanderHandleExterns.gtk_expander_set_label_widget(expander, label_widget);
		return expander;
	}

/// <summary>
/// <para>
/// Sets whether the expander will resize the toplevel widget
/// containing the expander upon resizing and collpasing.
/// </para>
/// </summary>

/// <param name="expander">
/// a #GtkExpander
/// </param>
/// <param name="resize_toplevel">
/// whether to resize the toplevel
/// </param>

	public static T SetResizeToplevel<T>(this T expander, bool resize_toplevel) where T : GtkExpanderHandle
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		GtkExpanderHandleExterns.gtk_expander_set_resize_toplevel(expander, resize_toplevel);
		return expander;
	}

/// <summary>
/// <para>
/// Sets the spacing field of @expander, which is the number of
/// pixels to place between expander and the child.
/// </para>
/// </summary>

/// <param name="expander">
/// a #GtkExpander
/// </param>
/// <param name="spacing">
/// distance between the expander and child in pixels
/// </param>

	public static T SetSpacing<T>(this T expander, int spacing) where T : GtkExpanderHandle
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		GtkExpanderHandleExterns.gtk_expander_set_spacing(expander, spacing);
		return expander;
	}

/// <summary>
/// <para>
/// Sets whether the text of the label contains markup in
/// [Pango’s text markup language][PangoMarkupFormat].
/// See gtk_label_set_markup().
/// </para>
/// </summary>

/// <param name="expander">
/// a #GtkExpander
/// </param>
/// <param name="use_markup">
/// %TRUE if the label’s text should be parsed for markup
/// </param>

	public static T SetUseMarkup<T>(this T expander, bool use_markup) where T : GtkExpanderHandle
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		GtkExpanderHandleExterns.gtk_expander_set_use_markup(expander, use_markup);
		return expander;
	}

/// <summary>
/// <para>
/// If true, an underline in the text of the expander label indicates
/// the next character should be used for the mnemonic accelerator key.
/// </para>
/// </summary>

/// <param name="expander">
/// a #GtkExpander
/// </param>
/// <param name="use_underline">
/// %TRUE if underlines in the text indicate mnemonics
/// </param>

	public static T SetUseUnderline<T>(this T expander, bool use_underline) where T : GtkExpanderHandle
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		GtkExpanderHandleExterns.gtk_expander_set_use_underline(expander, use_underline);
		return expander;
	}

}

internal class GtkExpanderHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))]
	internal static extern MentorLake.Gtk.GtkExpanderHandle gtk_expander_new(string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))]
	internal static extern MentorLake.Gtk.GtkExpanderHandle gtk_expander_new_with_mnemonic(string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_expander_get_expanded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_expander_get_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_expander_get_label_fill([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_expander_get_label_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_expander_get_resize_toplevel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_expander_get_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_expander_get_use_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_expander_get_use_underline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_expander_set_expanded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander, bool expanded);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_expander_set_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_expander_set_label_fill([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander, bool label_fill);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_expander_set_label_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle label_widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_expander_set_resize_toplevel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander, bool resize_toplevel);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_expander_set_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander, int spacing);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_expander_set_use_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander, bool use_markup);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_expander_set_use_underline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander, bool use_underline);

}
