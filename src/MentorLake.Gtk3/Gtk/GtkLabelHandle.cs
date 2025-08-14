namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkLabel widget displays a small amount of text. As the name
/// implies, most labels are used to label another widget such as a
/// #GtkButton, a #GtkMenuItem, or a #GtkComboBox.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// |[<!-- language="plain" -->
/// label
/// ├── [selection]
/// ├── [link]
/// ┊
/// ╰── [link]
/// ]|
/// </para>
/// <para>
/// GtkLabel has a single CSS node with the name label. A wide variety
/// of style classes may be applied to labels, such as .title, .subtitle,
/// .dim-label, etc. In the #GtkShortcutsWindow, labels are used wth the
/// .keycap style class.
/// </para>
/// <para>
/// If the label has a selection, it gets a subnode with name selection.
/// </para>
/// <para>
/// If the label has links, there is one subnode per link. These subnodes
/// carry the link or visited state depending on whether they have been
/// visited.
/// </para>
/// <para>
/// # GtkLabel as GtkBuildable
/// </para>
/// <para>
/// The GtkLabel implementation of the GtkBuildable interface supports a
/// custom `<attributes>` element, which supports any number of `<attribute>`
/// elements. The `<attribute>` element has attributes named “name“, “value“,
/// “start“ and “end“ and allows you to specify #PangoAttribute values for
/// this label.
/// </para>
/// <para>
/// An example of a UI definition fragment specifying Pango attributes:
/// </para>
/// <para>
/// |[<!-- language="xml" -->
/// <object class="GtkLabel">
///   <attributes>
///     <attribute name="weight" value="PANGO_WEIGHT_BOLD"/>
///     <attribute name="background" value="red" start="5" end="10"/>
///   </attributes>
/// </object>
/// ]|
/// </para>
/// <para>
/// The start and end attributes specify the range of characters to which the
/// Pango attribute applies. If start and end are not specified, the attribute is
/// applied to the whole text. Note that specifying ranges does not make much
/// sense with translatable attributes. Use markup embedded in the translatable
/// content instead.
/// </para>
/// <para>
/// # Mnemonics
/// </para>
/// <para>
/// Labels may contain “mnemonics”. Mnemonics are
/// underlined characters in the label, used for keyboard navigation.
/// Mnemonics are created by providing a string with an underscore before
/// the mnemonic character, such as `"_File"`, to the
/// functions gtk_label_new_with_mnemonic() or
/// gtk_label_set_text_with_mnemonic().
/// </para>
/// <para>
/// Mnemonics automatically activate any activatable widget the label is
/// inside, such as a #GtkButton; if the label is not inside the
/// mnemonic’s target widget, you have to tell the label about the target
/// using gtk_label_set_mnemonic_widget(). Here’s a simple example where
/// the label is inside a button:
/// </para>
/// <para>
/// |[<!-- language="C" -->
///   // Pressing Alt+H will activate this button
///   GtkWidget *button = gtk_button_new ();
///   GtkWidget *label = gtk_label_new_with_mnemonic ("_Hello");
///   gtk_container_add (GTK_CONTAINER (button), label);
/// ]|
/// </para>
/// <para>
/// There’s a convenience function to create buttons with a mnemonic label
/// already inside:
/// </para>
/// <para>
/// |[<!-- language="C" -->
///   // Pressing Alt+H will activate this button
///   GtkWidget *button = gtk_button_new_with_mnemonic ("_Hello");
/// ]|
/// </para>
/// <para>
/// To create a mnemonic for a widget alongside the label, such as a
/// #GtkEntry, you have to point the label at the entry with
/// gtk_label_set_mnemonic_widget():
/// </para>
/// <para>
/// |[<!-- language="C" -->
///   // Pressing Alt+H will focus the entry
///   GtkWidget *entry = gtk_entry_new ();
///   GtkWidget *label = gtk_label_new_with_mnemonic ("_Hello");
///   gtk_label_set_mnemonic_widget (GTK_LABEL (label), entry);
/// ]|
/// </para>
/// <para>
/// # Markup (styled text)
/// </para>
/// <para>
/// To make it easy to format text in a label (changing colors,
/// fonts, etc.), label text can be provided in a simple
/// [markup format][PangoMarkupFormat].
/// </para>
/// <para>
/// Here’s how to create a label with a small font:
/// |[<!-- language="C" -->
///   GtkWidget *label = gtk_label_new (NULL);
///   gtk_label_set_markup (GTK_LABEL (label), "<small>Small text</small>");
/// ]|
/// </para>
/// <para>
/// (See [complete documentation][PangoMarkupFormat] of available
/// tags in the Pango manual.)
/// </para>
/// <para>
/// The markup passed to gtk_label_set_markup() must be valid; for example,
/// literal <, > and & characters must be escaped as &lt;, &gt;, and &amp;.
/// If you pass text obtained from the user, file, or a network to
/// gtk_label_set_markup(), you’ll want to escape it with
/// g_markup_escape_text() or g_markup_printf_escaped().
/// </para>
/// <para>
/// Markup strings are just a convenient way to set the #PangoAttrList on
/// a label; gtk_label_set_attributes() may be a simpler way to set
/// attributes in some cases. Be careful though; #PangoAttrList tends to
/// cause internationalization problems, unless you’re applying attributes
/// to the entire string (i.e. unless you set the range of each attribute
/// to [0, %G_MAXINT)). The reason is that specifying the start_index and
/// end_index for a #PangoAttribute requires knowledge of the exact string
/// being displayed, so translations will cause problems.
/// </para>
/// <para>
/// # Selectable labels
/// </para>
/// <para>
/// Labels can be made selectable with gtk_label_set_selectable().
/// Selectable labels allow the user to copy the label contents to
/// the clipboard. Only labels that contain useful-to-copy information
/// — such as error messages — should be made selectable.
/// </para>
/// <para>
/// # Text layout # {#label-text-layout}
/// </para>
/// <para>
/// A label can contain any number of paragraphs, but will have
/// performance problems if it contains more than a small number.
/// Paragraphs are separated by newlines or other paragraph separators
/// understood by Pango.
/// </para>
/// <para>
/// Labels can automatically wrap text if you call
/// gtk_label_set_line_wrap().
/// </para>
/// <para>
/// gtk_label_set_justify() sets how the lines in a label align
/// with one another. If you want to set how the label as a whole
/// aligns in its available space, see the #GtkWidget:halign and
/// #GtkWidget:valign properties.
/// </para>
/// <para>
/// The #GtkLabel:width-chars and #GtkLabel:max-width-chars properties
/// can be used to control the size allocation of ellipsized or wrapped
/// labels. For ellipsizing labels, if either is specified (and less
/// than the actual text size), it is used as the minimum width, and the actual
/// text size is used as the natural width of the label. For wrapping labels,
/// width-chars is used as the minimum width, if specified, and max-width-chars
/// is used as the natural width. Even if max-width-chars specified, wrapping
/// labels will be rewrapped to use all of the available width.
/// </para>
/// <para>
/// Note that the interpretation of #GtkLabel:width-chars and
/// #GtkLabel:max-width-chars has changed a bit with the introduction of
/// [width-for-height geometry management.][geometry-management]
/// </para>
/// <para>
/// # Links
/// </para>
/// <para>
/// Since 2.18, GTK+ supports markup for clickable hyperlinks in addition
/// to regular Pango markup. The markup for links is borrowed from HTML,
/// using the `<a>` with “href“ and “title“ attributes. GTK+ renders links
/// similar to the way they appear in web browsers, with colored, underlined
/// text. The “title“ attribute is displayed as a tooltip on the link.
/// </para>
/// <para>
/// An example looks like this:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// const gchar *text =
/// "Go to the"
/// "<a href=\"http://www.gtk.org title=\"&lt;i&gt;Our&lt;/i&gt; website\">"
/// "GTK+ website</a> for more...";
/// GtkWidget *label = gtk_label_new (NULL);
/// gtk_label_set_markup (GTK_LABEL (label), text);
/// ]|
/// </para>
/// <para>
/// It is possible to implement custom handling for links and their tooltips with
/// the #GtkLabel::activate-link signal and the gtk_label_get_current_uri() function.
/// </para>
/// </summary>

public class GtkLabelHandle : GtkMiscHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new label with the given text inside it. You can
/// pass %NULL to get an empty label widget.
/// </para>
/// </summary>

/// <param name="str">
/// The text of the label
/// </param>
/// <return>
/// the new #GtkLabel
/// </return>

	public static MentorLake.Gtk.GtkLabelHandle New(string str)
	{
		return GtkLabelHandleExterns.gtk_label_new(str);
	}

/// <summary>
/// <para>
/// Creates a new #GtkLabel, containing the text in @str.
/// </para>
/// <para>
/// If characters in @str are preceded by an underscore, they are
/// underlined. If you need a literal underscore character in a label, use
/// '__' (two underscores). The first underlined character represents a
/// keyboard accelerator called a mnemonic. The mnemonic key can be used
/// to activate another widget, chosen automatically, or explicitly using
/// gtk_label_set_mnemonic_widget().
/// </para>
/// <para>
/// If gtk_label_set_mnemonic_widget() is not called, then the first
/// activatable ancestor of the #GtkLabel will be chosen as the mnemonic
/// widget. For instance, if the label is inside a button or menu item,
/// the button or menu item will automatically become the mnemonic widget
/// and be activated by the mnemonic.
/// </para>
/// </summary>

/// <param name="str">
/// The text of the label, with an underscore in front of the
///       mnemonic character
/// </param>
/// <return>
/// the new #GtkLabel
/// </return>

	public static MentorLake.Gtk.GtkLabelHandle NewWithMnemonic(string str)
	{
		return GtkLabelHandleExterns.gtk_label_new_with_mnemonic(str);
	}

}
public static class GtkLabelHandleSignalExtensions
{
/// <summary>
/// <para>
/// A [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user activates a link in the label.
/// </para>
/// <para>
/// Applications may also emit the signal with g_signal_emit_by_name()
/// if they need to control activation of URIs programmatically.
/// </para>
/// <para>
/// The default bindings for this signal are all forms of the Enter key.
/// </para>
/// </summary>

	public static IObservable<GtkLabelHandleSignalStructs.ActivateCurrentLinkSignal> Signal_ActivateCurrentLink(this GtkLabelHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLabelHandleSignalStructs.ActivateCurrentLinkSignal> obs) =>
		{
			GtkLabelHandleSignalDelegates.activate_current_link handler = ( MentorLake.Gtk.GtkLabelHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelHandleSignalStructs.ActivateCurrentLinkSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate-current-link", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// The signal which gets emitted to activate a URI.
/// Applications may connect to it to override the default behaviour,
/// which is to call gtk_show_uri_on_window().
/// </para>
/// </summary>

	public static IObservable<GtkLabelHandleSignalStructs.ActivateLinkSignal> Signal_ActivateLink(this GtkLabelHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLabelHandleSignalStructs.ActivateLinkSignal> obs) =>
		{
			GtkLabelHandleSignalDelegates.activate_link handler = ( MentorLake.Gtk.GtkLabelHandle self,  string uri,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelHandleSignalStructs.ActivateLinkSignal()
				{
					Self = self, Uri = uri, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate-link", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// The ::copy-clipboard signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to copy the selection to the clipboard.
/// </para>
/// <para>
/// The default binding for this signal is Ctrl-c.
/// </para>
/// </summary>

	public static IObservable<GtkLabelHandleSignalStructs.CopyClipboardSignal> Signal_CopyClipboard(this GtkLabelHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLabelHandleSignalStructs.CopyClipboardSignal> obs) =>
		{
			GtkLabelHandleSignalDelegates.copy_clipboard handler = ( MentorLake.Gtk.GtkLabelHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelHandleSignalStructs.CopyClipboardSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "copy-clipboard", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// The ::move-cursor signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user initiates a cursor movement.
/// If the cursor is not visible in @entry, this signal causes
/// the viewport to be moved instead.
/// </para>
/// <para>
/// Applications should not connect to it, but may emit it with
/// g_signal_emit_by_name() if they need to control the cursor
/// programmatically.
/// </para>
/// <para>
/// The default bindings for this signal come in two variants,
/// the variant with the Shift modifier extends the selection,
/// the variant without the Shift modifer does not.
/// There are too many key combinations to list them all here.
/// - Arrow keys move by individual characters/lines
/// - Ctrl-arrow key combinations move by words/paragraphs
/// - Home/End keys move to the ends of the buffer
/// </para>
/// </summary>

	public static IObservable<GtkLabelHandleSignalStructs.MoveCursorSignal> Signal_MoveCursor(this GtkLabelHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLabelHandleSignalStructs.MoveCursorSignal> obs) =>
		{
			GtkLabelHandleSignalDelegates.move_cursor handler = ( MentorLake.Gtk.GtkLabelHandle self,  MentorLake.Gtk.GtkMovementStep step,  int count,  bool extend_selection,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelHandleSignalStructs.MoveCursorSignal()
				{
					Self = self, Step = step, Count = count, ExtendSelection = extend_selection, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move-cursor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// The ::populate-popup signal gets emitted before showing the
/// context menu of the label. Note that only selectable labels
/// have context menus.
/// </para>
/// <para>
/// If you need to add items to the context menu, connect
/// to this signal and append your menuitems to the @menu.
/// </para>
/// </summary>

	public static IObservable<GtkLabelHandleSignalStructs.PopulatePopupSignal> Signal_PopulatePopup(this GtkLabelHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLabelHandleSignalStructs.PopulatePopupSignal> obs) =>
		{
			GtkLabelHandleSignalDelegates.populate_popup handler = ( MentorLake.Gtk.GtkLabelHandle self,  MentorLake.Gtk.GtkMenuHandle menu,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelHandleSignalStructs.PopulatePopupSignal()
				{
					Self = self, Menu = menu, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "populate-popup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkLabelHandleSignalStructs
{

public class ActivateCurrentLinkSignal
{

	public MentorLake.Gtk.GtkLabelHandle Self;

	public IntPtr UserData;
}

public class ActivateLinkSignal
{

	public MentorLake.Gtk.GtkLabelHandle Self;
/// <summary>
/// <para>
/// the URI that is activated
/// </para>
/// </summary>

	public string Uri;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if the link has been activated
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class CopyClipboardSignal
{

	public MentorLake.Gtk.GtkLabelHandle Self;

	public IntPtr UserData;
}

public class MoveCursorSignal
{

	public MentorLake.Gtk.GtkLabelHandle Self;
/// <summary>
/// <para>
/// the granularity of the move, as a #GtkMovementStep
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkMovementStep Step;
/// <summary>
/// <para>
/// the number of @step units to move
/// </para>
/// </summary>

	public int Count;
/// <summary>
/// <para>
/// %TRUE if the move should extend the selection
/// </para>
/// </summary>

	public bool ExtendSelection;

	public IntPtr UserData;
}

public class PopulatePopupSignal
{

	public MentorLake.Gtk.GtkLabelHandle Self;
/// <summary>
/// <para>
/// the menu that is being populated
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkMenuHandle Menu;

	public IntPtr UserData;
}
}

public static class GtkLabelHandleSignalDelegates
{

/// <summary>
/// <para>
/// A [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user activates a link in the label.
/// </para>
/// <para>
/// Applications may also emit the signal with g_signal_emit_by_name()
/// if they need to control activation of URIs programmatically.
/// </para>
/// <para>
/// The default bindings for this signal are all forms of the Enter key.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate_current_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The signal which gets emitted to activate a URI.
/// Applications may connect to it to override the default behaviour,
/// which is to call gtk_show_uri_on_window().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="uri">
/// the URI that is activated
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if the link has been activated
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool activate_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle self, string uri, IntPtr user_data);


/// <summary>
/// <para>
/// The ::copy-clipboard signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to copy the selection to the clipboard.
/// </para>
/// <para>
/// The default binding for this signal is Ctrl-c.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void copy_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::move-cursor signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user initiates a cursor movement.
/// If the cursor is not visible in @entry, this signal causes
/// the viewport to be moved instead.
/// </para>
/// <para>
/// Applications should not connect to it, but may emit it with
/// g_signal_emit_by_name() if they need to control the cursor
/// programmatically.
/// </para>
/// <para>
/// The default bindings for this signal come in two variants,
/// the variant with the Shift modifier extends the selection,
/// the variant without the Shift modifer does not.
/// There are too many key combinations to list them all here.
/// - Arrow keys move by individual characters/lines
/// - Ctrl-arrow key combinations move by words/paragraphs
/// - Home/End keys move to the ends of the buffer
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="step">
/// the granularity of the move, as a #GtkMovementStep
/// </param>
/// <param name="count">
/// the number of @step units to move
/// </param>
/// <param name="extend_selection">
/// %TRUE if the move should extend the selection
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle self, MentorLake.Gtk.GtkMovementStep step, int count, bool extend_selection, IntPtr user_data);


/// <summary>
/// <para>
/// The ::populate-popup signal gets emitted before showing the
/// context menu of the label. Note that only selectable labels
/// have context menus.
/// </para>
/// <para>
/// If you need to add items to the context menu, connect
/// to this signal and append your menuitems to the @menu.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="menu">
/// the menu that is being populated
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void populate_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, IntPtr user_data);

}


public static class GtkLabelHandleExtensions
{
/// <summary>
/// <para>
/// Gets the angle of rotation for the label. See
/// gtk_label_set_angle().
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <return>
/// the angle of rotation for the label
/// </return>

	public static double GetAngle(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_angle(label);
	}

/// <summary>
/// <para>
/// Gets the attribute list that was set on the label using
/// gtk_label_set_attributes(), if any. This function does
/// not reflect attributes that come from the labels markup
/// (see gtk_label_set_markup()). If you want to get the
/// effective attributes for the label, use
/// pango_layout_get_attribute (gtk_label_get_layout (label)).
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <return>
/// the attribute list, or %NULL
///     if none was set.
/// </return>

	public static MentorLake.Pango.PangoAttrListHandle GetAttributes(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_attributes(label);
	}

/// <summary>
/// <para>
/// Returns the URI for the currently active link in the label.
/// The active link is the one under the mouse pointer or, in a
/// selectable label, the link in which the text cursor is currently
/// positioned.
/// </para>
/// <para>
/// This function is intended for use in a #GtkLabel::activate-link handler
/// or for use in a #GtkWidget::query-tooltip handler.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <return>
/// the currently active URI. The string is owned by GTK+ and must
///   not be freed or modified.
/// </return>

	public static string GetCurrentUri(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_current_uri(label);
	}

/// <summary>
/// <para>
/// Returns the ellipsizing position of the label. See gtk_label_set_ellipsize().
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <return>
/// #PangoEllipsizeMode
/// </return>

	public static MentorLake.Pango.PangoEllipsizeMode GetEllipsize(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_ellipsize(label);
	}

/// <summary>
/// <para>
/// Returns the justification of the label. See gtk_label_set_justify().
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <return>
/// #GtkJustification
/// </return>

	public static MentorLake.Gtk.GtkJustification GetJustify(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_justify(label);
	}

/// <summary>
/// <para>
/// Fetches the text from a label widget including any embedded
/// underlines indicating mnemonics and Pango markup. (See
/// gtk_label_get_text()).
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <return>
/// the text of the label widget. This string is
///   owned by the widget and must not be modified or freed.
/// </return>

	public static string GetLabel(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_label(label);
	}

/// <summary>
/// <para>
/// Gets the #PangoLayout used to display the label.
/// The layout is useful to e.g. convert text positions to
/// pixel positions, in combination with gtk_label_get_layout_offsets().
/// The returned layout is owned by the @label so need not be
/// freed by the caller. The @label is free to recreate its layout at
/// any time, so it should be considered read-only.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <return>
/// the #PangoLayout for this label
/// </return>

	public static MentorLake.Pango.PangoLayoutHandle GetLayout(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_layout(label);
	}

/// <summary>
/// <para>
/// Obtains the coordinates where the label will draw the #PangoLayout
/// representing the text in the label; useful to convert mouse events
/// into coordinates inside the #PangoLayout, e.g. to take some action
/// if some part of the label is clicked. Of course you will need to
/// create a #GtkEventBox to receive the events, and pack the label
/// inside it, since labels are windowless (they return %FALSE from
/// gtk_widget_get_has_window()). Remember
/// when using the #PangoLayout functions you need to convert to
/// and from pixels using PANGO_PIXELS() or #PANGO_SCALE.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="x">
/// location to store X offset of layout, or %NULL
/// </param>
/// <param name="y">
/// location to store Y offset of layout, or %NULL
/// </param>

	public static T GetLayoutOffsets<T>(this T label, out int x, out int y) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_get_layout_offsets(label, out x, out y);
		return label;
	}

/// <summary>
/// <para>
/// Returns whether lines in the label are automatically wrapped.
/// See gtk_label_set_line_wrap().
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <return>
/// %TRUE if the lines of the label are automatically wrapped.
/// </return>

	public static bool GetLineWrap(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_line_wrap(label);
	}

/// <summary>
/// <para>
/// Returns line wrap mode used by the label. See gtk_label_set_line_wrap_mode().
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <return>
/// %TRUE if the lines of the label are automatically wrapped.
/// </return>

	public static MentorLake.Pango.PangoWrapMode GetLineWrapMode(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_line_wrap_mode(label);
	}

/// <summary>
/// <para>
/// Gets the number of lines to which an ellipsized, wrapping
/// label should be limited. See gtk_label_set_lines().
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <return>
/// The number of lines
/// </return>

	public static int GetLines(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_lines(label);
	}

/// <summary>
/// <para>
/// Retrieves the desired maximum width of @label, in characters. See
/// gtk_label_set_width_chars().
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <return>
/// the maximum width of the label in characters.
/// </return>

	public static int GetMaxWidthChars(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_max_width_chars(label);
	}

/// <summary>
/// <para>
/// If the label has been set so that it has an mnemonic key this function
/// returns the keyval used for the mnemonic accelerator. If there is no
/// mnemonic set up it returns #GDK_KEY_VoidSymbol.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <return>
/// GDK keyval usable for accelerators, or #GDK_KEY_VoidSymbol
/// </return>

	public static uint GetMnemonicKeyval(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_mnemonic_keyval(label);
	}

/// <summary>
/// <para>
/// Retrieves the target of the mnemonic (keyboard shortcut) of this
/// label. See gtk_label_set_mnemonic_widget().
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <return>
/// the target of the label’s mnemonic,
///     or %NULL if none has been set and the default algorithm will be used.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetMnemonicWidget(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_mnemonic_widget(label);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_label_set_selectable().
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <return>
/// %TRUE if the user can copy text from the label
/// </return>

	public static bool GetSelectable(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_selectable(label);
	}

/// <summary>
/// <para>
/// Gets the selected range of characters in the label, returning %TRUE
/// if there’s a selection.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="start">
/// return location for start of selection, as a character offset
/// </param>
/// <param name="end">
/// return location for end of selection, as a character offset
/// </param>
/// <return>
/// %TRUE if selection is non-empty
/// </return>

	public static bool GetSelectionBounds(this MentorLake.Gtk.GtkLabelHandle label, out int start, out int end)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_selection_bounds(label, out start, out end);
	}

/// <summary>
/// <para>
/// Returns whether the label is in single line mode.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <return>
/// %TRUE when the label is in single line mode.
/// </return>

	public static bool GetSingleLineMode(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_single_line_mode(label);
	}

/// <summary>
/// <para>
/// Fetches the text from a label widget, as displayed on the
/// screen. This does not include any embedded underlines
/// indicating mnemonics or Pango markup. (See gtk_label_get_label())
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <return>
/// the text in the label widget. This is the internal
///   string used by the label, and must not be modified.
/// </return>

	public static string GetText(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_text(label);
	}

/// <summary>
/// <para>
/// Returns whether the label is currently keeping track
/// of clicked links.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <return>
/// %TRUE if clicked links are remembered
/// </return>

	public static bool GetTrackVisitedLinks(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_track_visited_links(label);
	}

/// <summary>
/// <para>
/// Returns whether the label’s text is interpreted as marked up with
/// the [Pango text markup language][PangoMarkupFormat].
/// See gtk_label_set_use_markup ().
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <return>
/// %TRUE if the label’s text will be parsed for markup.
/// </return>

	public static bool GetUseMarkup(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_use_markup(label);
	}

/// <summary>
/// <para>
/// Returns whether an embedded underline in the label indicates a
/// mnemonic. See gtk_label_set_use_underline().
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <return>
/// %TRUE whether an embedded underline in the label indicates
///               the mnemonic accelerator keys.
/// </return>

	public static bool GetUseUnderline(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_use_underline(label);
	}

/// <summary>
/// <para>
/// Retrieves the desired width of @label, in characters. See
/// gtk_label_set_width_chars().
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <return>
/// the width of the label in characters.
/// </return>

	public static int GetWidthChars(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_width_chars(label);
	}

/// <summary>
/// <para>
/// Gets the #GtkLabel:xalign property for @label.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <return>
/// the xalign property
/// </return>

	public static float GetXalign(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_xalign(label);
	}

/// <summary>
/// <para>
/// Gets the #GtkLabel:yalign property for @label.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <return>
/// the yalign property
/// </return>

	public static float GetYalign(this MentorLake.Gtk.GtkLabelHandle label)
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		return GtkLabelHandleExterns.gtk_label_get_yalign(label);
	}

/// <summary>
/// <para>
/// Selects a range of characters in the label, if the label is selectable.
/// See gtk_label_set_selectable(). If the label is not selectable,
/// this function has no effect. If @start_offset or
/// @end_offset are -1, then the end of the label will be substituted.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="start_offset">
/// start offset (in characters not bytes)
/// </param>
/// <param name="end_offset">
/// end offset (in characters not bytes)
/// </param>

	public static T SelectRegion<T>(this T label, int start_offset, int end_offset) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_select_region(label, start_offset, end_offset);
		return label;
	}

/// <summary>
/// <para>
/// Sets the angle of rotation for the label. An angle of 90 reads from
/// from bottom to top, an angle of 270, from top to bottom. The angle
/// setting for the label is ignored if the label is selectable,
/// wrapped, or ellipsized.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="angle">
/// the angle that the baseline of the label makes with
///   the horizontal, in degrees, measured counterclockwise
/// </param>

	public static T SetAngle<T>(this T label, double angle) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_angle(label, angle);
		return label;
	}

/// <summary>
/// <para>
/// Sets a #PangoAttrList; the attributes in the list are applied to the
/// label text.
/// </para>
/// <para>
/// The attributes set with this function will be applied
/// and merged with any other attributes previously effected by way
/// of the #GtkLabel:use-underline or #GtkLabel:use-markup properties.
/// While it is not recommended to mix markup strings with manually set
/// attributes, if you must; know that the attributes will be applied
/// to the label after the markup string is parsed.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="attrs">
/// a #PangoAttrList, or %NULL
/// </param>

	public static T SetAttributes<T>(this T label, MentorLake.Pango.PangoAttrListHandle attrs) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_attributes(label, attrs);
		return label;
	}

/// <summary>
/// <para>
/// Sets the mode used to ellipsize (add an ellipsis: "...") to the text
/// if there is not enough space to render the entire string.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="mode">
/// a #PangoEllipsizeMode
/// </param>

	public static T SetEllipsize<T>(this T label, MentorLake.Pango.PangoEllipsizeMode mode) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_ellipsize(label, mode);
		return label;
	}

/// <summary>
/// <para>
/// Sets the alignment of the lines in the text of the label relative to
/// each other. %GTK_JUSTIFY_LEFT is the default value when the widget is
/// first created with gtk_label_new(). If you instead want to set the
/// alignment of the label as a whole, use gtk_widget_set_halign() instead.
/// gtk_label_set_justify() has no effect on labels containing only a
/// single line.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="jtype">
/// a #GtkJustification
/// </param>

	public static T SetJustify<T>(this T label, MentorLake.Gtk.GtkJustification jtype) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_justify(label, jtype);
		return label;
	}

/// <summary>
/// <para>
/// Sets the text of the label. The label is interpreted as
/// including embedded underlines and/or Pango markup depending
/// on the values of the #GtkLabel:use-underline and
/// #GtkLabel:use-markup properties.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="str">
/// the new text to set for the label
/// </param>

	public static T SetLabel<T>(this T label, string str) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_label(label, str);
		return label;
	}

/// <summary>
/// <para>
/// Toggles line wrapping within the #GtkLabel widget. %TRUE makes it break
/// lines if text exceeds the widget’s size. %FALSE lets the text get cut off
/// by the edge of the widget if it exceeds the widget size.
/// </para>
/// <para>
/// Note that setting line wrapping to %TRUE does not make the label
/// wrap at its parent container’s width, because GTK+ widgets
/// conceptually can’t make their requisition depend on the parent
/// container’s size. For a label that wraps at a specific position,
/// set the label’s width using gtk_widget_set_size_request().
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="wrap">
/// the setting
/// </param>

	public static T SetLineWrap<T>(this T label, bool wrap) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_line_wrap(label, wrap);
		return label;
	}

/// <summary>
/// <para>
/// If line wrapping is on (see gtk_label_set_line_wrap()) this controls how
/// the line wrapping is done. The default is %PANGO_WRAP_WORD which means
/// wrap on word boundaries.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="wrap_mode">
/// the line wrapping mode
/// </param>

	public static T SetLineWrapMode<T>(this T label, MentorLake.Pango.PangoWrapMode wrap_mode) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_line_wrap_mode(label, wrap_mode);
		return label;
	}

/// <summary>
/// <para>
/// Sets the number of lines to which an ellipsized, wrapping label
/// should be limited. This has no effect if the label is not wrapping
/// or ellipsized. Set this to -1 if you don’t want to limit the
/// number of lines.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="lines">
/// the desired number of lines, or -1
/// </param>

	public static T SetLines<T>(this T label, int lines) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_lines(label, lines);
		return label;
	}

/// <summary>
/// <para>
/// Parses @str which is marked up with the
/// [Pango text markup language][PangoMarkupFormat], setting the
/// label’s text and attribute list based on the parse results.
/// </para>
/// <para>
/// If the @str is external data, you may need to escape it with
/// g_markup_escape_text() or g_markup_printf_escaped():
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// GtkWidget *label = gtk_label_new (NULL);
/// const char *str = "some text";
/// const char *format = "<span style=\"italic\">\%s</span>";
/// char *markup;
/// </para>
/// <para>
/// markup = g_markup_printf_escaped (format, str);
/// gtk_label_set_markup (GTK_LABEL (label), markup);
/// g_free (markup);
/// ]|
/// </para>
/// <para>
/// This function will set the #GtkLabel:use-markup property to %TRUE as
/// a side effect.
/// </para>
/// <para>
/// If you set the label contents using the #GtkLabel:label property you
/// should also ensure that you set the #GtkLabel:use-markup property
/// accordingly.
/// </para>
/// <para>
/// See also: gtk_label_set_text()
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="str">
/// a markup string (see [Pango markup format][PangoMarkupFormat])
/// </param>

	public static T SetMarkup<T>(this T label, string str) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_markup(label, str);
		return label;
	}

/// <summary>
/// <para>
/// Parses @str which is marked up with the
/// [Pango text markup language][PangoMarkupFormat],
/// setting the label’s text and attribute list based on the parse results.
/// If characters in @str are preceded by an underscore, they are underlined
/// indicating that they represent a keyboard accelerator called a mnemonic.
/// </para>
/// <para>
/// The mnemonic key can be used to activate another widget, chosen
/// automatically, or explicitly using gtk_label_set_mnemonic_widget().
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="str">
/// a markup string (see
///     [Pango markup format][PangoMarkupFormat])
/// </param>

	public static T SetMarkupWithMnemonic<T>(this T label, string str) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_markup_with_mnemonic(label, str);
		return label;
	}

/// <summary>
/// <para>
/// Sets the desired maximum width in characters of @label to @n_chars.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="n_chars">
/// the new desired maximum width, in characters.
/// </param>

	public static T SetMaxWidthChars<T>(this T label, int n_chars) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_max_width_chars(label, n_chars);
		return label;
	}

/// <summary>
/// <para>
/// If the label has been set so that it has an mnemonic key (using
/// i.e. gtk_label_set_markup_with_mnemonic(),
/// gtk_label_set_text_with_mnemonic(), gtk_label_new_with_mnemonic()
/// or the “use_underline” property) the label can be associated with a
/// widget that is the target of the mnemonic. When the label is inside
/// a widget (like a #GtkButton or a #GtkNotebook tab) it is
/// automatically associated with the correct widget, but sometimes
/// (i.e. when the target is a #GtkEntry next to the label) you need to
/// set it explicitly using this function.
/// </para>
/// <para>
/// The target widget will be accelerated by emitting the
/// GtkWidget::mnemonic-activate signal on it. The default handler for
/// this signal will activate the widget if there are no mnemonic collisions
/// and toggle focus between the colliding widgets otherwise.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="widget">
/// the target #GtkWidget, or %NULL to unset
/// </param>

	public static T SetMnemonicWidget<T>(this T label, MentorLake.Gtk.GtkWidgetHandle widget) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_mnemonic_widget(label, widget);
		return label;
	}

/// <summary>
/// <para>
/// The pattern of underlines you want under the existing text within the
/// #GtkLabel widget.  For example if the current text of the label says
/// “FooBarBaz” passing a pattern of “___   ___” will underline
/// “Foo” and “Baz” but not “Bar”.
/// </para>
/// </summary>

/// <param name="label">
/// The #GtkLabel you want to set the pattern to.
/// </param>
/// <param name="pattern">
/// The pattern as described above.
/// </param>

	public static T SetPattern<T>(this T label, string pattern) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_pattern(label, pattern);
		return label;
	}

/// <summary>
/// <para>
/// Selectable labels allow the user to select text from the label, for
/// copy-and-paste.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="setting">
/// %TRUE to allow selecting text in the label
/// </param>

	public static T SetSelectable<T>(this T label, bool setting) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_selectable(label, setting);
		return label;
	}

/// <summary>
/// <para>
/// Sets whether the label is in single line mode.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="single_line_mode">
/// %TRUE if the label should be in single line mode
/// </param>

	public static T SetSingleLineMode<T>(this T label, bool single_line_mode) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_single_line_mode(label, single_line_mode);
		return label;
	}

/// <summary>
/// <para>
/// Sets the text within the #GtkLabel widget. It overwrites any text that
/// was there before.
/// </para>
/// <para>
/// This function will clear any previously set mnemonic accelerators, and
/// set the #GtkLabel:use-underline property to %FALSE as a side effect.
/// </para>
/// <para>
/// This function will set the #GtkLabel:use-markup property to %FALSE
/// as a side effect.
/// </para>
/// <para>
/// See also: gtk_label_set_markup()
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="str">
/// The text you want to set
/// </param>

	public static T SetText<T>(this T label, string str) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_text(label, str);
		return label;
	}

/// <summary>
/// <para>
/// Sets the label’s text from the string @str.
/// If characters in @str are preceded by an underscore, they are underlined
/// indicating that they represent a keyboard accelerator called a mnemonic.
/// The mnemonic key can be used to activate another widget, chosen
/// automatically, or explicitly using gtk_label_set_mnemonic_widget().
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="str">
/// a string
/// </param>

	public static T SetTextWithMnemonic<T>(this T label, string str) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_text_with_mnemonic(label, str);
		return label;
	}

/// <summary>
/// <para>
/// Sets whether the label should keep track of clicked
/// links (and use a different color for them).
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="track_links">
/// %TRUE to track visited links
/// </param>

	public static T SetTrackVisitedLinks<T>(this T label, bool track_links) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_track_visited_links(label, track_links);
		return label;
	}

/// <summary>
/// <para>
/// Sets whether the text of the label contains markup in
/// [Pango’s text markup language][PangoMarkupFormat].
/// See gtk_label_set_markup().
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="setting">
/// %TRUE if the label’s text should be parsed for markup.
/// </param>

	public static T SetUseMarkup<T>(this T label, bool setting) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_use_markup(label, setting);
		return label;
	}

/// <summary>
/// <para>
/// If true, an underline in the text indicates the next character should be
/// used for the mnemonic accelerator key.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="setting">
/// %TRUE if underlines in the text indicate mnemonics
/// </param>

	public static T SetUseUnderline<T>(this T label, bool setting) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_use_underline(label, setting);
		return label;
	}

/// <summary>
/// <para>
/// Sets the desired width in characters of @label to @n_chars.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="n_chars">
/// the new desired width, in characters.
/// </param>

	public static T SetWidthChars<T>(this T label, int n_chars) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_width_chars(label, n_chars);
		return label;
	}

/// <summary>
/// <para>
/// Sets the #GtkLabel:xalign property for @label.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="xalign">
/// the new xalign value, between 0 and 1
/// </param>

	public static T SetXalign<T>(this T label, float xalign) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_xalign(label, xalign);
		return label;
	}

/// <summary>
/// <para>
/// Sets the #GtkLabel:yalign property for @label.
/// </para>
/// </summary>

/// <param name="label">
/// a #GtkLabel
/// </param>
/// <param name="yalign">
/// the new yalign value, between 0 and 1
/// </param>

	public static T SetYalign<T>(this T label, float yalign) where T : GtkLabelHandle
	{
		if (label.IsInvalid) throw new Exception("Invalid handle (GtkLabelHandle)");
		GtkLabelHandleExterns.gtk_label_set_yalign(label, yalign);
		return label;
	}

}

internal class GtkLabelHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))]
	internal static extern MentorLake.Gtk.GtkLabelHandle gtk_label_new(string str);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))]
	internal static extern MentorLake.Gtk.GtkLabelHandle gtk_label_new_with_mnemonic(string str);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_label_get_angle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))]
	internal static extern MentorLake.Pango.PangoAttrListHandle gtk_label_get_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_label_get_current_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoEllipsizeMode gtk_label_get_ellipsize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkJustification gtk_label_get_justify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_label_get_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))]
	internal static extern MentorLake.Pango.PangoLayoutHandle gtk_label_get_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_get_layout_offsets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, out int x, out int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_label_get_line_wrap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoWrapMode gtk_label_get_line_wrap_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_label_get_lines([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_label_get_max_width_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_label_get_mnemonic_keyval([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_label_get_mnemonic_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_label_get_selectable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_label_get_selection_bounds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, out int start, out int end);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_label_get_single_line_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_label_get_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_label_get_track_visited_links([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_label_get_use_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_label_get_use_underline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_label_get_width_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern float gtk_label_get_xalign([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern float gtk_label_get_yalign([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_select_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, int start_offset, int end_offset);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_angle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, double angle);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle attrs);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_ellipsize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, MentorLake.Pango.PangoEllipsizeMode mode);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_justify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, MentorLake.Gtk.GtkJustification jtype);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, string str);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_line_wrap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, bool wrap);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_line_wrap_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, MentorLake.Pango.PangoWrapMode wrap_mode);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_lines([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, int lines);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, string str);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_markup_with_mnemonic([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, string str);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_max_width_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, int n_chars);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_mnemonic_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_pattern([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, string pattern);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_selectable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_single_line_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, bool single_line_mode);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, string str);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_text_with_mnemonic([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, string str);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_track_visited_links([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, bool track_links);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_use_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_use_underline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_width_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, int n_chars);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_xalign([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, float xalign);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_label_set_yalign([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLabelHandle>))] MentorLake.Gtk.GtkLabelHandle label, float yalign);

}
