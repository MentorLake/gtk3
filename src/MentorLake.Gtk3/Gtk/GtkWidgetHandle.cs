namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkWidget is the base class all widgets in GTK+ derive from. It manages the
/// widget lifecycle, states and style.
/// </para>
/// <para>
/// # Height-for-width Geometry Management # {#geometry-management}
/// </para>
/// <para>
/// GTK+ uses a height-for-width (and width-for-height) geometry management
/// system. Height-for-width means that a widget can change how much
/// vertical space it needs, depending on the amount of horizontal space
/// that it is given (and similar for width-for-height). The most common
/// example is a label that reflows to fill up the available width, wraps
/// to fewer lines, and therefore needs less height.
/// </para>
/// <para>
/// Height-for-width geometry management is implemented in GTK+ by way
/// of five virtual methods:
/// </para>
/// <para>
/// - #GtkWidgetClass.get_request_mode()
/// - #GtkWidgetClass.get_preferred_width()
/// - #GtkWidgetClass.get_preferred_height()
/// - #GtkWidgetClass.get_preferred_height_for_width()
/// - #GtkWidgetClass.get_preferred_width_for_height()
/// - #GtkWidgetClass.get_preferred_height_and_baseline_for_width()
/// </para>
/// <para>
/// There are some important things to keep in mind when implementing
/// height-for-width and when using it in container implementations.
/// </para>
/// <para>
/// The geometry management system will query a widget hierarchy in
/// only one orientation at a time. When widgets are initially queried
/// for their minimum sizes it is generally done in two initial passes
/// in the #GtkSizeRequestMode chosen by the toplevel.
/// </para>
/// <para>
/// For example, when queried in the normal
/// %GTK_SIZE_REQUEST_HEIGHT_FOR_WIDTH mode:
/// First, the default minimum and natural width for each widget
/// in the interface will be computed using gtk_widget_get_preferred_width().
/// Because the preferred widths for each container depend on the preferred
/// widths of their children, this information propagates up the hierarchy,
/// and finally a minimum and natural width is determined for the entire
/// toplevel. Next, the toplevel will use the minimum width to query for the
/// minimum height contextual to that width using
/// gtk_widget_get_preferred_height_for_width(), which will also be a highly
/// recursive operation. The minimum height for the minimum width is normally
/// used to set the minimum size constraint on the toplevel
/// (unless gtk_window_set_geometry_hints() is explicitly used instead).
/// </para>
/// <para>
/// After the toplevel window has initially requested its size in both
/// dimensions it can go on to allocate itself a reasonable size (or a size
/// previously specified with gtk_window_set_default_size()). During the
/// recursive allocation process it’s important to note that request cycles
/// will be recursively executed while container widgets allocate their children.
/// Each container widget, once allocated a size, will go on to first share the
/// space in one orientation among its children and then request each child&apos;s
/// height for its target allocated width or its width for allocated height,
/// depending. In this way a #GtkWidget will typically be requested its size
/// a number of times before actually being allocated a size. The size a
/// widget is finally allocated can of course differ from the size it has
/// requested. For this reason, #GtkWidget caches a  small number of results
/// to avoid re-querying for the same sizes in one allocation cycle.
/// </para>
/// <para>
/// See
/// [GtkContainer’s geometry management section][container-geometry-management]
/// to learn more about how height-for-width allocations are performed
/// by container widgets.
/// </para>
/// <para>
/// If a widget does move content around to intelligently use up the
/// allocated size then it must support the request in both
/// #GtkSizeRequestModes even if the widget in question only
/// trades sizes in a single orientation.
/// </para>
/// <para>
/// For instance, a #GtkLabel that does height-for-width word wrapping
/// will not expect to have #GtkWidgetClass.get_preferred_height() called
/// because that call is specific to a width-for-height request. In this
/// case the label must return the height required for its own minimum
/// possible width. By following this rule any widget that handles
/// height-for-width or width-for-height requests will always be allocated
/// at least enough space to fit its own content.
/// </para>
/// <para>
/// Here are some examples of how a %GTK_SIZE_REQUEST_HEIGHT_FOR_WIDTH widget
/// generally deals with width-for-height requests, for #GtkWidgetClass.get_preferred_height()
/// it will do:
/// </para>
/// <code>
/// static void
/// static void
/// foo_widget_get_preferred_height (GtkWidget *widget,
///                                  gint *min_height,
///                                  gint *nat_height)
/// {
///    if (i_am_in_height_for_width_mode)
///      {
///        gint min_width, nat_width;
/// 
///        GTK_WIDGET_GET_CLASS (widget)-&amp;gt;get_preferred_width (widget,
///                                                            &amp;min_width,
///                                                            &amp;nat_width);
///        GTK_WIDGET_GET_CLASS (widget)-&amp;gt;get_preferred_height_for_width
///                                                           (widget,
///                                                            min_width,
///                                                            min_height,
///                                                            nat_height);
///      }
///    else
///      {
///         ... some widgets do both. For instance, if a GtkLabel is
///         rotated to 90 degrees it will return the minimum and
///         natural height for the rotated label here.
///      }
/// }
/// </code>
/// <para>
/// And in #GtkWidgetClass.get_preferred_width_for_height() it will simply return
/// the minimum and natural width:
/// <code>
/// static void
/// static void
/// foo_widget_get_preferred_width_for_height (GtkWidget *widget,
///                                            gint for_height,
///                                            gint *min_width,
///                                            gint *nat_width)
/// {
///    if (i_am_in_height_for_width_mode)
///      {
///        GTK_WIDGET_GET_CLASS (widget)-&amp;gt;get_preferred_width (widget,
///                                                            min_width,
///                                                            nat_width);
///      }
///    else
///      {
///         ... again if a widget is sometimes operating in
///         width-for-height mode (like a rotated GtkLabel) it can go
///         ahead and do its real width for height calculation here.
///      }
/// }
/// </code>
/// Often a widget needs to get its own request during size request or
/// allocation. For example, when computing height it may need to also
/// compute width. Or when deciding how to use an allocation, the widget
/// may need to know its natural size. In these cases, the widget should
/// be careful to call its virtual methods directly, like this:
/// </para>
/// <code>
/// GTK_WIDGET_GET_CLASS(widget)-&amp;gt;get_preferred_width (widget,
/// GTK_WIDGET_GET_CLASS(widget)-&amp;gt;get_preferred_width (widget,
///                                                    &amp;min,
///                                                    &amp;natural);
/// </code>
/// <para>
/// It will not work to use the wrapper functions, such as
/// gtk_widget_get_preferred_width() inside your own size request
/// implementation. These return a request adjusted by #GtkSizeGroup
/// and by the #GtkWidgetClass.adjust_size_request() virtual method. If a
/// widget used the wrappers inside its virtual method implementations,
/// then the adjustments (such as widget margins) would be applied
/// twice. GTK+ therefore does not allow this and will warn if you try
/// to do it.
/// </para>
/// <para>
/// Of course if you are getting the size request for
/// another widget, such as a child of a
/// container, you must use the wrapper APIs.
/// Otherwise, you would not properly consider widget margins,
/// #GtkSizeGroup, and so forth.
/// </para>
/// <para>
/// Since 3.10 GTK+ also supports baseline vertical alignment of widgets. This
/// means that widgets are positioned such that the typographical baseline of
/// widgets in the same row are aligned. This happens if a widget supports baselines,
/// has a vertical alignment of %GTK_ALIGN_BASELINE, and is inside a container
/// that supports baselines and has a natural “row” that it aligns to the baseline,
/// or a baseline assigned to it by the grandparent.
/// </para>
/// <para>
/// Baseline alignment support for a widget is done by the #GtkWidgetClass.get_preferred_height_and_baseline_for_width()
/// virtual function. It allows you to report a baseline in combination with the
/// minimum and natural height. If there is no baseline you can return -1 to indicate
/// this. The default implementation of this virtual function calls into the
/// #GtkWidgetClass.get_preferred_height() and #GtkWidgetClass.get_preferred_height_for_width(),
/// so if baselines are not supported it doesn’t need to be implemented.
/// </para>
/// <para>
/// If a widget ends up baseline aligned it will be allocated all the space in the parent
/// as if it was %GTK_ALIGN_FILL, but the selected baseline can be found via gtk_widget_get_allocated_baseline().
/// If this has a value other than -1 you need to align the widget such that the baseline
/// appears at the position.
/// </para>
/// <para>
/// # Style Properties
/// </para>
/// <para>
/// #GtkWidget introduces “style
/// properties” - these are basically object properties that are stored
/// not on the object, but in the style object associated to the widget. Style
/// properties are set in [resource files][gtk3-Resource-Files].
/// This mechanism is used for configuring such things as the location of the
/// scrollbar arrows through the theme, giving theme authors more control over the
/// look of applications without the need to write a theme engine in C.
/// </para>
/// <para>
/// Use gtk_widget_class_install_style_property() to install style properties for
/// a widget class, gtk_widget_class_find_style_property() or
/// gtk_widget_class_list_style_properties() to get information about existing
/// style properties and gtk_widget_style_get_property(), gtk_widget_style_get() or
/// gtk_widget_style_get_valist() to obtain the value of a style property.
/// </para>
/// <para>
/// # GtkWidget as GtkBuildable
/// </para>
/// <para>
/// The GtkWidget implementation of the GtkBuildable interface supports a
/// custom `&amp;lt;accelerator&amp;gt;` element, which has attributes named ”key”, ”modifiers”
/// and ”signal” and allows to specify accelerators.
/// </para>
/// <para>
/// An example of a UI definition fragment specifying an accelerator:
/// </para>
/// <code>
/// &amp;lt;object class=&quot;GtkButton&quot;&amp;gt;
/// &amp;lt;object class=&quot;GtkButton&quot;&amp;gt;
///   &amp;lt;accelerator key=&quot;q&quot; modifiers=&quot;GDK_CONTROL_MASK&quot; signal=&quot;clicked&quot;/&amp;gt;
/// &amp;lt;/object&amp;gt;
/// </code>
/// <para>
/// In addition to accelerators, GtkWidget also support a custom `&amp;lt;accessible&amp;gt;`
/// element, which supports actions and relations. Properties on the accessible
/// implementation of an object can be set by accessing the internal child
/// “accessible” of a #GtkWidget.
/// </para>
/// <para>
/// An example of a UI definition fragment specifying an accessible:
/// </para>
/// <code>
/// &amp;lt;object class=&quot;GtkLabel&quot; id=&quot;label1&quot;/&amp;gt;
/// &amp;lt;object class=&quot;GtkLabel&quot; id=&quot;label1&quot;/&amp;gt;
///   &amp;lt;property name=&quot;label&quot;&amp;gt;I am a Label for a Button&amp;lt;/property&amp;gt;
/// &amp;lt;/object&amp;gt;
/// &amp;lt;object class=&quot;GtkButton&quot; id=&quot;button1&quot;&amp;gt;
///   &amp;lt;accessibility&amp;gt;
///     &amp;lt;action action_name=&quot;click&quot; translatable=&quot;yes&quot;&amp;gt;Click the button.&amp;lt;/action&amp;gt;
///     &amp;lt;relation target=&quot;label1&quot; type=&quot;labelled-by&quot;/&amp;gt;
///   &amp;lt;/accessibility&amp;gt;
///   &amp;lt;child internal-child=&quot;accessible&quot;&amp;gt;
///     &amp;lt;object class=&quot;AtkObject&quot; id=&quot;a11y-button1&quot;&amp;gt;
///       &amp;lt;property name=&quot;accessible-name&quot;&amp;gt;Clickable Button&amp;lt;/property&amp;gt;
///     &amp;lt;/object&amp;gt;
///   &amp;lt;/child&amp;gt;
/// &amp;lt;/object&amp;gt;
/// </code>
/// <para>
/// Finally, GtkWidget allows style information such as style classes to
/// be associated with widgets, using the custom `&amp;lt;style&amp;gt;` element:
/// </para>
/// <code>
/// &amp;lt;object class=&quot;GtkButton&quot; id=&quot;button1&quot;&amp;gt;
/// &amp;lt;object class=&quot;GtkButton&quot; id=&quot;button1&quot;&amp;gt;
///   &amp;lt;style&amp;gt;
///     &amp;lt;class name=&quot;my-special-button-class&quot;/&amp;gt;
///     &amp;lt;class name=&quot;dark-button&quot;/&amp;gt;
///   &amp;lt;/style&amp;gt;
/// &amp;lt;/object&amp;gt;
/// </code>
/// <para>
/// # Building composite widgets from template XML ## {#composite-templates}
/// </para>
/// <para>
/// GtkWidget exposes some facilities to automate the procedure
/// of creating composite widgets using #GtkBuilder interface description
/// language.
/// </para>
/// <para>
/// To create composite widgets with #GtkBuilder XML, one must associate
/// the interface description with the widget class at class initialization
/// time using gtk_widget_class_set_template().
/// </para>
/// <para>
/// The interface description semantics expected in composite template descriptions
/// is slightly different from regular #GtkBuilder XML.
/// </para>
/// <para>
/// Unlike regular interface descriptions, gtk_widget_class_set_template() will
/// expect a `&amp;lt;template&amp;gt;` tag as a direct child of the toplevel `&amp;lt;interface&amp;gt;`
/// tag. The `&amp;lt;template&amp;gt;` tag must specify the “class” attribute which must be
/// the type name of the widget. Optionally, the “parent” attribute may be
/// specified to specify the direct parent type of the widget type, this is
/// ignored by the GtkBuilder but required for Glade to introspect what kind
/// of properties and internal children exist for a given type when the actual
/// type does not exist.
/// </para>
/// <para>
/// The XML which is contained inside the `&amp;lt;template&amp;gt;` tag behaves as if it were
/// added to the `&amp;lt;object&amp;gt;` tag defining &quot;widget&quot; itself. You may set properties
/// on @widget by inserting `&amp;lt;property&amp;gt;` tags into the `&amp;lt;template&amp;gt;` tag, and also
/// add `&amp;lt;child&amp;gt;` tags to add children and extend &quot;widget&quot; in the normal way you
/// would with `&amp;lt;object&amp;gt;` tags.
/// </para>
/// <para>
/// Additionally, `&amp;lt;object&amp;gt;` tags can also be added before and after the initial
/// `&amp;lt;template&amp;gt;` tag in the normal way, allowing one to define auxiliary objects
/// which might be referenced by other widgets declared as children of the
/// `&amp;lt;template&amp;gt;` tag.
/// </para>
/// <para>
/// An example of a GtkBuilder Template Definition:
/// </para>
/// <code>
/// &amp;lt;interface&amp;gt;
/// &amp;lt;interface&amp;gt;
///   &amp;lt;template class=&quot;FooWidget&quot; parent=&quot;GtkBox&quot;&amp;gt;
///     &amp;lt;property name=&quot;orientation&quot;&amp;gt;GTK_ORIENTATION_HORIZONTAL&amp;lt;/property&amp;gt;
///     &amp;lt;property name=&quot;spacing&quot;&amp;gt;4&amp;lt;/property&amp;gt;
///     &amp;lt;child&amp;gt;
///       &amp;lt;object class=&quot;GtkButton&quot; id=&quot;hello_button&quot;&amp;gt;
///         &amp;lt;property name=&quot;label&quot;&amp;gt;Hello World&amp;lt;/property&amp;gt;
///         &amp;lt;signal name=&quot;clicked&quot; handler=&quot;hello_button_clicked&quot; object=&quot;FooWidget&quot; swapped=&quot;yes&quot;/&amp;gt;
///       &amp;lt;/object&amp;gt;
///     &amp;lt;/child&amp;gt;
///     &amp;lt;child&amp;gt;
///       &amp;lt;object class=&quot;GtkButton&quot; id=&quot;goodbye_button&quot;&amp;gt;
///         &amp;lt;property name=&quot;label&quot;&amp;gt;Goodbye World&amp;lt;/property&amp;gt;
///       &amp;lt;/object&amp;gt;
///     &amp;lt;/child&amp;gt;
///   &amp;lt;/template&amp;gt;
/// &amp;lt;/interface&amp;gt;
/// </code>
/// <para>
/// Typically, you&apos;ll place the template fragment into a file that is
/// bundled with your project, using #GResource. In order to load the
/// template, you need to call gtk_widget_class_set_template_from_resource()
/// from the class initialization of your #GtkWidget type:
/// </para>
/// <code>
/// static void
/// static void
/// foo_widget_class_init (FooWidgetClass *klass)
/// {
///   // ...
/// 
///   gtk_widget_class_set_template_from_resource (GTK_WIDGET_CLASS (klass),
///                                                &quot;/com/example/ui/foowidget.ui&quot;);
/// }
/// </code>
/// <para>
/// You will also need to call gtk_widget_init_template() from the instance
/// initialization function:
/// </para>
/// <code>
/// static void
/// static void
/// foo_widget_init (FooWidget *self)
/// {
///   // ...
///   gtk_widget_init_template (GTK_WIDGET (self));
/// }
/// </code>
/// <para>
/// You can access widgets defined in the template using the
/// gtk_widget_get_template_child() function, but you will typically declare
/// a pointer in the instance private data structure of your type using the same
/// name as the widget in the template definition, and call
/// gtk_widget_class_bind_template_child_private() with that name, e.g.
/// </para>
/// <code>
/// typedef struct {
/// typedef struct {
///   GtkWidget *hello_button;
///   GtkWidget *goodbye_button;
/// } FooWidgetPrivate;
/// 
/// G_DEFINE_TYPE_WITH_PRIVATE (FooWidget, foo_widget, GTK_TYPE_BOX)
/// 
/// static void
/// foo_widget_class_init (FooWidgetClass *klass)
/// {
///   // ...
///   gtk_widget_class_set_template_from_resource (GTK_WIDGET_CLASS (klass),
///                                                &quot;/com/example/ui/foowidget.ui&quot;);
///   gtk_widget_class_bind_template_child_private (GTK_WIDGET_CLASS (klass),
///                                                 FooWidget, hello_button);
///   gtk_widget_class_bind_template_child_private (GTK_WIDGET_CLASS (klass),
///                                                 FooWidget, goodbye_button);
/// }
/// 
/// static void
/// foo_widget_init (FooWidget *widget)
/// {
/// 
/// }
/// </code>
/// <para>
/// You can also use gtk_widget_class_bind_template_callback() to connect a signal
/// callback defined in the template with a function visible in the scope of the
/// class, e.g.
/// </para>
/// <code>
/// // the signal handler has the instance and user data swapped
/// // the signal handler has the instance and user data swapped
/// // because of the swapped=&quot;yes&quot; attribute in the template XML
/// static void
/// hello_button_clicked (FooWidget *self,
///                       GtkButton *button)
/// {
///   g_print (&quot;Hello, world!\n&quot;);
/// }
/// 
/// static void
/// foo_widget_class_init (FooWidgetClass *klass)
/// {
///   // ...
///   gtk_widget_class_set_template_from_resource (GTK_WIDGET_CLASS (klass),
///                                                &quot;/com/example/ui/foowidget.ui&quot;);
///   gtk_widget_class_bind_template_callback (GTK_WIDGET_CLASS (klass), hello_button_clicked);
/// }
/// </code>
/// </summary>

public class GtkWidgetHandle : GInitiallyUnownedHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// This is a convenience function for creating a widget and setting
/// its properties in one go. For example you might write:
/// `gtk_widget_new (GTK_TYPE_LABEL, &quot;label&quot;, &quot;Hello World&quot;, &quot;xalign&quot;,
/// 0.0, NULL)` to create a left-aligned label. Equivalent to
/// g_object_new(), but returns a widget so you don’t have to
/// cast the object yourself.
/// </para>
/// </summary>

/// <param name="type">
/// type ID of the widget to create
/// </param>
/// <param name="first_property_name">
/// name of first property to set
/// </param>
/// <param name="@__arglist">
/// value of first property, followed by more properties,
///     %NULL-terminated
/// </param>
/// <return>
/// a new #GtkWidget of type @widget_type
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle New(MentorLake.GObject.GType type, string first_property_name, IntPtr @__arglist)
	{
		return GtkWidgetHandleExterns.gtk_widget_new(type, first_property_name, @__arglist);
	}

/// <summary>
/// <para>
/// Obtains the current default reading direction. See
/// gtk_widget_set_default_direction().
/// </para>
/// </summary>

/// <return>
/// the current default direction.
/// </return>

	public static MentorLake.Gtk.GtkTextDirection GetDefaultDirection()
	{
		return GtkWidgetHandleExterns.gtk_widget_get_default_direction();
	}

/// <summary>
/// <para>
/// Returns the default style used by all widgets initially.
/// </para>
/// </summary>

/// <return>
/// the default style. This #GtkStyle
///     object is owned by GTK+ and should not be modified or freed.
/// </return>

	public static MentorLake.Gtk.GtkStyleHandle GetDefaultStyle()
	{
		return GtkWidgetHandleExterns.gtk_widget_get_default_style();
	}

/// <summary>
/// <para>
/// Cancels the effect of a previous call to gtk_widget_push_composite_child().
/// </para>
/// </summary>


	public static void PopCompositeChild()
	{
		GtkWidgetHandleExterns.gtk_widget_pop_composite_child();
	}

/// <summary>
/// <para>
/// Makes all newly-created widgets as composite children until
/// the corresponding gtk_widget_pop_composite_child() call.
/// </para>
/// <para>
/// A composite child is a child that’s an implementation detail of the
/// container it’s inside and should not be visible to people using the
/// container. Composite children aren’t treated differently by GTK+ (but
/// see gtk_container_foreach() vs. gtk_container_forall()), but e.g. GUI
/// builders might want to treat them in a different way.
/// </para>
/// </summary>


	public static void PushCompositeChild()
	{
		GtkWidgetHandleExterns.gtk_widget_push_composite_child();
	}

/// <summary>
/// <para>
/// Sets the default reading direction for widgets where the
/// direction has not been explicitly set by gtk_widget_set_direction().
/// </para>
/// </summary>

/// <param name="dir">
/// the new default direction. This cannot be
///        %GTK_TEXT_DIR_NONE.
/// </param>

	public static void SetDefaultDirection(MentorLake.Gtk.GtkTextDirection dir)
	{
		GtkWidgetHandleExterns.gtk_widget_set_default_direction(dir);
	}

}
public static class GtkWidgetHandleSignalExtensions
{

	public static IObservable<GtkWidgetHandleSignalStructs.AccelClosuresChangedSignal> Signal_AccelClosuresChanged(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.AccelClosuresChangedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.accel_closures_changed handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.AccelClosuresChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "accel-closures-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::button-press-event signal will be emitted when a button
/// (typically from a mouse) is pressed.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the
/// widget needs to enable the #GDK_BUTTON_PRESS_MASK mask.
/// </para>
/// <para>
/// This signal will be sent to the grab widget if there is one.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.ButtonPressEventSignal> Signal_ButtonPressEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.ButtonPressEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.button_press_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventButtonHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.ButtonPressEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "button-press-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::button-release-event signal will be emitted when a button
/// (typically from a mouse) is released.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the
/// widget needs to enable the #GDK_BUTTON_RELEASE_MASK mask.
/// </para>
/// <para>
/// This signal will be sent to the grab widget if there is one.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.ButtonReleaseEventSignal> Signal_ButtonReleaseEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.ButtonReleaseEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.button_release_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventButtonHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.ButtonReleaseEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "button-release-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Determines whether an accelerator that activates the signal
/// identified by @signal_id can currently be activated.
/// This signal is present to allow applications and derived
/// widgets to override the default #GtkWidget handling
/// for determining whether an accelerator can be activated.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.CanActivateAccelSignal> Signal_CanActivateAccel(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.CanActivateAccelSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.can_activate_accel handler = ( MentorLake.Gtk.GtkWidgetHandle self,  uint signal_id,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.CanActivateAccelSignal()
				{
					Self = self, SignalId = signal_id, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "can-activate-accel", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::child-notify signal is emitted for each
/// [child property][child-properties]  that has
/// changed on an object. The signal&apos;s detail holds the property name.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.ChildNotifySignal> Signal_ChildNotify(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.ChildNotifySignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.child_notify handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.GObject.GParamSpecHandle child_property,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.ChildNotifySignal()
				{
					Self = self, ChildProperty = child_property, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "child-notify", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::composited-changed signal is emitted when the composited
/// status of @widgets screen changes.
/// See gdk_screen_is_composited().
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.CompositedChangedSignal> Signal_CompositedChanged(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.CompositedChangedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.composited_changed handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.CompositedChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "composited-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::configure-event signal will be emitted when the size, position or
/// stacking of the @widget&apos;s window has changed.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_STRUCTURE_MASK mask. GDK will enable this mask
/// automatically for all new windows.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.ConfigureEventSignal> Signal_ConfigureEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.ConfigureEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.configure_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventConfigureHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.ConfigureEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "configure-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when a redirected window belonging to @widget gets drawn into.
/// The region/area members of the event shows what area of the redirected
/// drawable was drawn into.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.DamageEventSignal> Signal_DamageEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DamageEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.damage_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventExposeHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DamageEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "damage-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::delete-event signal is emitted if a user requests that
/// a toplevel window is closed. The default handler for this signal
/// destroys the window. Connecting gtk_widget_hide_on_delete() to
/// this signal will cause the window to be hidden instead, so that
/// it can later be shown again without reconstructing it.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.DeleteEventSignal> Signal_DeleteEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DeleteEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.delete_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DeleteEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "delete-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Signals that all holders of a reference to the widget should release
/// the reference that they hold. May result in finalization of the widget
/// if all references are released.
/// </para>
/// <para>
/// This signal is not suitable for saving widget state.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.DestroySignal> Signal_Destroy(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DestroySignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.destroy handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DestroySignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "destroy", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::destroy-event signal is emitted when a #GdkWindow is destroyed.
/// You rarely get this signal, because most widgets disconnect themselves
/// from their window before they destroy it, so no widget owns the
/// window at destroy time.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_STRUCTURE_MASK mask. GDK will enable this mask
/// automatically for all new windows.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.DestroyEventSignal> Signal_DestroyEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DestroyEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.destroy_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DestroyEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "destroy-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::direction-changed signal is emitted when the text direction
/// of a widget changes.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.DirectionChangedSignal> Signal_DirectionChanged(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DirectionChangedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.direction_changed handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkTextDirection previous_direction,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DirectionChangedSignal()
				{
					Self = self, PreviousDirection = previous_direction, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "direction-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::drag-begin signal is emitted on the drag source when a drag is
/// started. A typical reason to connect to this signal is to set up a
/// custom drag icon with e.g. gtk_drag_source_set_icon_pixbuf().
/// </para>
/// <para>
/// Note that some widgets set up a drag icon in the default handler of
/// this signal, so you may have to use g_signal_connect_after() to
/// override what the default handler did.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.DragBeginSignal> Signal_DragBegin(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DragBeginSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.drag_begin handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkDragContextHandle context,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DragBeginSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-begin", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::drag-data-delete signal is emitted on the drag source when a drag
/// with the action %GDK_ACTION_MOVE is successfully completed. The signal
/// handler is responsible for deleting the data that has been dropped. What
/// &quot;delete&quot; means depends on the context of the drag operation.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.DragDataDeleteSignal> Signal_DragDataDelete(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DragDataDeleteSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.drag_data_delete handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkDragContextHandle context,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DragDataDeleteSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-data-delete", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::drag-data-get signal is emitted on the drag source when the drop
/// site requests the data which is dragged. It is the responsibility of
/// the signal handler to fill @data with the data in the format which
/// is indicated by @info. See gtk_selection_data_set() and
/// gtk_selection_data_set_text().
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.DragDataGetSignal> Signal_DragDataGet(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DragDataGetSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.drag_data_get handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkDragContextHandle context,  MentorLake.Gtk.GtkSelectionDataHandle data,  uint info,  uint time,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DragDataGetSignal()
				{
					Self = self, Context = context, Data = data, Info = info, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-data-get", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::drag-data-received signal is emitted on the drop site when the
/// dragged data has been received. If the data was received in order to
/// determine whether the drop will be accepted, the handler is expected
/// to call gdk_drag_status() and not finish the drag.
/// If the data was received in response to a #GtkWidget::drag-drop signal
/// (and this is the last target to be received), the handler for this
/// signal is expected to process the received data and then call
/// gtk_drag_finish(), setting the @success parameter depending on
/// whether the data was processed successfully.
/// </para>
/// <para>
/// Applications must create some means to determine why the signal was emitted
/// and therefore whether to call gdk_drag_status() or gtk_drag_finish().
/// </para>
/// <para>
/// The handler may inspect the selected action with
/// gdk_drag_context_get_selected_action() before calling
/// gtk_drag_finish(), e.g. to implement %GDK_ACTION_ASK as
/// shown in the following example:
/// <code>
/// void
/// void
/// drag_data_received (GtkWidget          *widget,
///                     GdkDragContext     *context,
///                     gint                x,
///                     gint                y,
///                     GtkSelectionData   *data,
///                     guint               info,
///                     guint               time)
/// {
///   if ((data-&amp;gt;length &amp;gt;= 0) &amp;&amp; (data-&amp;gt;format == 8))
///     {
///       GdkDragAction action;
/// 
///       // handle data here
/// 
///       action = gdk_drag_context_get_selected_action (context);
///       if (action == GDK_ACTION_ASK)
///         {
///           GtkWidget *dialog;
///           gint response;
/// 
///           dialog = gtk_message_dialog_new (NULL,
///                                            GTK_DIALOG_MODAL |
///                                            GTK_DIALOG_DESTROY_WITH_PARENT,
///                                            GTK_MESSAGE_INFO,
///                                            GTK_BUTTONS_YES_NO,
///                                            &quot;Move the data ?\n&quot;);
///           response = gtk_dialog_run (GTK_DIALOG (dialog));
///           gtk_widget_destroy (dialog);
/// 
///           if (response == GTK_RESPONSE_YES)
///             action = GDK_ACTION_MOVE;
///           else
///             action = GDK_ACTION_COPY;
///          }
/// 
///       gtk_drag_finish (context, TRUE, action == GDK_ACTION_MOVE, time);
///     }
///   else
///     gtk_drag_finish (context, FALSE, FALSE, time);
///  }
/// </code>
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.DragDataReceivedSignal> Signal_DragDataReceived(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DragDataReceivedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.drag_data_received handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkDragContextHandle context,  int x,  int y,  MentorLake.Gtk.GtkSelectionDataHandle data,  uint info,  uint time,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DragDataReceivedSignal()
				{
					Self = self, Context = context, X = x, Y = y, Data = data, Info = info, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-data-received", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::drag-drop signal is emitted on the drop site when the user drops
/// the data onto the widget. The signal handler must determine whether
/// the cursor position is in a drop zone or not. If it is not in a drop
/// zone, it returns %FALSE and no further processing is necessary.
/// Otherwise, the handler returns %TRUE. In this case, the handler must
/// ensure that gtk_drag_finish() is called to let the source know that
/// the drop is done. The call to gtk_drag_finish() can be done either
/// directly or in a #GtkWidget::drag-data-received handler which gets
/// triggered by calling gtk_drag_get_data() to receive the data for one
/// or more of the supported targets.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.DragDropSignal> Signal_DragDrop(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DragDropSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.drag_drop handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkDragContextHandle context,  int x,  int y,  uint time,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DragDropSignal()
				{
					Self = self, Context = context, X = x, Y = y, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-drop", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::drag-end signal is emitted on the drag source when a drag is
/// finished.  A typical reason to connect to this signal is to undo
/// things done in #GtkWidget::drag-begin.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.DragEndSignal> Signal_DragEnd(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DragEndSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.drag_end handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkDragContextHandle context,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DragEndSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::drag-failed signal is emitted on the drag source when a drag has
/// failed. The signal handler may hook custom code to handle a failed DnD
/// operation based on the type of error, it returns %TRUE is the failure has
/// been already handled (not showing the default &quot;drag operation failed&quot;
/// animation), otherwise it returns %FALSE.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.DragFailedSignal> Signal_DragFailed(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DragFailedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.drag_failed handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkDragContextHandle context,  MentorLake.Gtk.GtkDragResult result,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DragFailedSignal()
				{
					Self = self, Context = context, Result = result, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-failed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::drag-leave signal is emitted on the drop site when the cursor
/// leaves the widget. A typical reason to connect to this signal is to
/// undo things done in #GtkWidget::drag-motion, e.g. undo highlighting
/// with gtk_drag_unhighlight().
/// </para>
/// 
/// <para>
/// Likewise, the #GtkWidget::drag-leave signal is also emitted before the
/// ::drag-drop signal, for instance to allow cleaning up of a preview item
/// created in the #GtkWidget::drag-motion signal handler.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.DragLeaveSignal> Signal_DragLeave(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DragLeaveSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.drag_leave handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkDragContextHandle context,  uint time,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DragLeaveSignal()
				{
					Self = self, Context = context, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-leave", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::drag-motion signal is emitted on the drop site when the user
/// moves the cursor over the widget during a drag. The signal handler
/// must determine whether the cursor position is in a drop zone or not.
/// If it is not in a drop zone, it returns %FALSE and no further processing
/// is necessary. Otherwise, the handler returns %TRUE. In this case, the
/// handler is responsible for providing the necessary information for
/// displaying feedback to the user, by calling gdk_drag_status().
/// </para>
/// <para>
/// If the decision whether the drop will be accepted or rejected can&apos;t be
/// made based solely on the cursor position and the type of the data, the
/// handler may inspect the dragged data by calling gtk_drag_get_data() and
/// defer the gdk_drag_status() call to the #GtkWidget::drag-data-received
/// handler. Note that you must pass #GTK_DEST_DEFAULT_DROP,
/// #GTK_DEST_DEFAULT_MOTION or #GTK_DEST_DEFAULT_ALL to gtk_drag_dest_set()
/// when using the drag-motion signal that way.
/// </para>
/// <para>
/// Also note that there is no drag-enter signal. The drag receiver has to
/// keep track of whether he has received any drag-motion signals since the
/// last #GtkWidget::drag-leave and if not, treat the drag-motion signal as
/// an &quot;enter&quot; signal. Upon an &quot;enter&quot;, the handler will typically highlight
/// the drop site with gtk_drag_highlight().
/// <code>
/// static void
/// static void
/// drag_motion (GtkWidget      *widget,
///              GdkDragContext *context,
///              gint            x,
///              gint            y,
///              guint           time)
/// {
///   GdkAtom target;
/// 
///   PrivateData *private_data = GET_PRIVATE_DATA (widget);
/// 
///   if (!private_data-&amp;gt;drag_highlight)
///    {
///      private_data-&amp;gt;drag_highlight = 1;
///      gtk_drag_highlight (widget);
///    }
/// 
///   target = gtk_drag_dest_find_target (widget, context, NULL);
///   if (target == GDK_NONE)
///     gdk_drag_status (context, 0, time);
///   else
///    {
///      private_data-&amp;gt;pending_status
///         = gdk_drag_context_get_suggested_action (context);
///      gtk_drag_get_data (widget, context, target, time);
///    }
/// 
///   return TRUE;
/// }
/// 
/// static void
/// drag_data_received (GtkWidget        *widget,
///                     GdkDragContext   *context,
///                     gint              x,
///                     gint              y,
///                     GtkSelectionData *selection_data,
///                     guint             info,
///                     guint             time)
/// {
///   PrivateData *private_data = GET_PRIVATE_DATA (widget);
/// 
///   if (private_data-&amp;gt;suggested_action)
///    {
///      private_data-&amp;gt;suggested_action = 0;
/// 
///      // We are getting this data due to a request in drag_motion,
///      // rather than due to a request in drag_drop, so we are just
///      // supposed to call gdk_drag_status(), not actually paste in
///      // the data.
/// 
///      str = gtk_selection_data_get_text (selection_data);
///      if (!data_is_acceptable (str))
///        gdk_drag_status (context, 0, time);
///      else
///        gdk_drag_status (context,
///                         private_data-&amp;gt;suggested_action,
///                         time);
///    }
///   else
///    {
///      // accept the drop
///    }
/// }
/// </code>
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.DragMotionSignal> Signal_DragMotion(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DragMotionSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.drag_motion handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkDragContextHandle context,  int x,  int y,  uint time,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DragMotionSignal()
				{
					Self = self, Context = context, X = x, Y = y, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-motion", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when a widget is supposed to render itself.
/// The @widget&apos;s top left corner must be painted at the origin of
/// the passed in context and be sized to the values returned by
/// gtk_widget_get_allocated_width() and
/// gtk_widget_get_allocated_height().
/// </para>
/// <para>
/// Signal handlers connected to this signal can modify the cairo
/// context passed as @cr in any way they like and don&apos;t need to
/// restore it. The signal emission takes care of calling cairo_save()
/// before and cairo_restore() after invoking the handler.
/// </para>
/// <para>
/// The signal handler will get a @cr with a clip region already set to the
/// widget&apos;s dirty region, i.e. to the area that needs repainting.  Complicated
/// widgets that want to avoid redrawing themselves completely can get the full
/// extents of the clip region with gdk_cairo_get_clip_rectangle(), or they can
/// get a finer-grained representation of the dirty region with
/// cairo_copy_clip_rectangle_list().
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.DrawSignal> Signal_Draw(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DrawSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.draw handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.cairo.cairo_tHandle cr,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DrawSignal()
				{
					Self = self, Cr = cr, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "draw", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::enter-notify-event will be emitted when the pointer enters
/// the @widget&apos;s window.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_ENTER_NOTIFY_MASK mask.
/// </para>
/// <para>
/// This signal will be sent to the grab widget if there is one.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.EnterNotifyEventSignal> Signal_EnterNotifyEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.EnterNotifyEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.enter_notify_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventCrossingHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.EnterNotifyEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "enter-notify-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The GTK+ main loop will emit three signals for each GDK event delivered
/// to a widget: one generic ::event signal, another, more specific,
/// signal that matches the type of event delivered (e.g.
/// #GtkWidget::key-press-event) and finally a generic
/// #GtkWidget::event-after signal.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.EventSignal> Signal_Event(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.EventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.@event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.EventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// After the emission of the #GtkWidget::event signal and (optionally)
/// the second more specific signal, ::event-after will be emitted
/// regardless of the previous two signals handlers return values.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.EventAfterSignal> Signal_EventAfter(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.EventAfterSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.event_after handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.EventAfterSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "event-after", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.FocusSignal> Signal_Focus(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.FocusSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.focus handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkDirectionType direction,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.FocusSignal()
				{
					Self = self, Direction = direction, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::focus-in-event signal will be emitted when the keyboard focus
/// enters the @widget&apos;s window.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_FOCUS_CHANGE_MASK mask.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.FocusInEventSignal> Signal_FocusInEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.FocusInEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.focus_in_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventFocusHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.FocusInEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "focus-in-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::focus-out-event signal will be emitted when the keyboard focus
/// leaves the @widget&apos;s window.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_FOCUS_CHANGE_MASK mask.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.FocusOutEventSignal> Signal_FocusOutEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.FocusOutEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.focus_out_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventFocusHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.FocusOutEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "focus-out-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when a pointer or keyboard grab on a window belonging
/// to @widget gets broken.
/// </para>
/// <para>
/// On X11, this happens when the grab window becomes unviewable
/// (i.e. it or one of its ancestors is unmapped), or if the same
/// application grabs the pointer or keyboard again.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.GrabBrokenEventSignal> Signal_GrabBrokenEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.GrabBrokenEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.grab_broken_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventGrabBrokenHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.GrabBrokenEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "grab-broken-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.GrabFocusSignal> Signal_GrabFocus(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.GrabFocusSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.grab_focus handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.GrabFocusSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "grab-focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::grab-notify signal is emitted when a widget becomes
/// shadowed by a GTK+ grab (not a pointer or keyboard grab) on
/// another widget, or when it becomes unshadowed due to a grab
/// being removed.
/// </para>
/// <para>
/// A widget is shadowed by a gtk_grab_add() when the topmost
/// grab widget in the grab stack of its window group is not
/// its ancestor.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.GrabNotifySignal> Signal_GrabNotify(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.GrabNotifySignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.grab_notify handler = ( MentorLake.Gtk.GtkWidgetHandle self,  bool was_grabbed,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.GrabNotifySignal()
				{
					Self = self, WasGrabbed = was_grabbed, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "grab-notify", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::hide signal is emitted when @widget is hidden, for example with
/// gtk_widget_hide().
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.HideSignal> Signal_Hide(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.HideSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.hide handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.HideSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "hide", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::hierarchy-changed signal is emitted when the
/// anchored state of a widget changes. A widget is
/// “anchored” when its toplevel
/// ancestor is a #GtkWindow. This signal is emitted when
/// a widget changes from un-anchored to anchored or vice-versa.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.HierarchyChangedSignal> Signal_HierarchyChanged(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.HierarchyChangedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.hierarchy_changed handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkWidgetHandle previous_toplevel,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.HierarchyChangedSignal()
				{
					Self = self, PreviousToplevel = previous_toplevel, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "hierarchy-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::key-press-event signal is emitted when a key is pressed. The signal
/// emission will reoccur at the key-repeat rate when the key is kept pressed.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_KEY_PRESS_MASK mask.
/// </para>
/// <para>
/// This signal will be sent to the grab widget if there is one.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.KeyPressEventSignal> Signal_KeyPressEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.KeyPressEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.key_press_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventKeyHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.KeyPressEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "key-press-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::key-release-event signal is emitted when a key is released.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_KEY_RELEASE_MASK mask.
/// </para>
/// <para>
/// This signal will be sent to the grab widget if there is one.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.KeyReleaseEventSignal> Signal_KeyReleaseEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.KeyReleaseEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.key_release_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventKeyHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.KeyReleaseEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "key-release-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Gets emitted if keyboard navigation fails.
/// See gtk_widget_keynav_failed() for details.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.KeynavFailedSignal> Signal_KeynavFailed(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.KeynavFailedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.keynav_failed handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkDirectionType direction,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.KeynavFailedSignal()
				{
					Self = self, Direction = direction, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "keynav-failed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::leave-notify-event will be emitted when the pointer leaves
/// the @widget&apos;s window.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_LEAVE_NOTIFY_MASK mask.
/// </para>
/// <para>
/// This signal will be sent to the grab widget if there is one.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.LeaveNotifyEventSignal> Signal_LeaveNotifyEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.LeaveNotifyEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.leave_notify_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventCrossingHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.LeaveNotifyEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "leave-notify-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::map signal is emitted when @widget is going to be mapped, that is
/// when the widget is visible (which is controlled with
/// gtk_widget_set_visible()) and all its parents up to the toplevel widget
/// are also visible. Once the map has occurred, #GtkWidget::map-event will
/// be emitted.
/// </para>
/// <para>
/// The ::map signal can be used to determine whether a widget will be drawn,
/// for instance it can resume an animation that was stopped during the
/// emission of #GtkWidget::unmap.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.MapSignal> Signal_Map(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.MapSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.map handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.MapSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "map", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::map-event signal will be emitted when the @widget&apos;s window is
/// mapped. A window is mapped when it becomes visible on the screen.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_STRUCTURE_MASK mask. GDK will enable this mask
/// automatically for all new windows.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.MapEventSignal> Signal_MapEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.MapEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.map_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventAnyHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.MapEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "map-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The default handler for this signal activates @widget if @group_cycling
/// is %FALSE, or just makes @widget grab focus if @group_cycling is %TRUE.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.MnemonicActivateSignal> Signal_MnemonicActivate(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.MnemonicActivateSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.mnemonic_activate handler = ( MentorLake.Gtk.GtkWidgetHandle self,  bool group_cycling,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.MnemonicActivateSignal()
				{
					Self = self, GroupCycling = group_cycling, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "mnemonic-activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::motion-notify-event signal is emitted when the pointer moves
/// over the widget&apos;s #GdkWindow.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget
/// needs to enable the #GDK_POINTER_MOTION_MASK mask.
/// </para>
/// <para>
/// This signal will be sent to the grab widget if there is one.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.MotionNotifyEventSignal> Signal_MotionNotifyEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.MotionNotifyEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.motion_notify_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventMotionHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.MotionNotifyEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "motion-notify-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.MoveFocusSignal> Signal_MoveFocus(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.MoveFocusSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.move_focus handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkDirectionType direction,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.MoveFocusSignal()
				{
					Self = self, Direction = direction, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move-focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::parent-set signal is emitted when a new parent
/// has been set on a widget.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.ParentSetSignal> Signal_ParentSet(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.ParentSetSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.parent_set handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkWidgetHandle old_parent,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.ParentSetSignal()
				{
					Self = self, OldParent = old_parent, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "parent-set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal gets emitted whenever a widget should pop up a context
/// menu. This usually happens through the standard key binding mechanism;
/// by pressing a certain key while a widget is focused, the user can cause
/// the widget to pop up a menu.  For example, the #GtkEntry widget creates
/// a menu with clipboard commands. See the
/// [Popup Menu Migration Checklist][checklist-popup-menu]
/// for an example of how to use this signal.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.PopupMenuSignal> Signal_PopupMenu(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.PopupMenuSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.popup_menu handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.PopupMenuSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "popup-menu", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::property-notify-event signal will be emitted when a property on
/// the @widget&apos;s window has been changed or deleted.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_PROPERTY_CHANGE_MASK mask.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.PropertyNotifyEventSignal> Signal_PropertyNotifyEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.PropertyNotifyEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.property_notify_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventPropertyHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.PropertyNotifyEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "property-notify-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// To receive this signal the #GdkWindow associated to the widget needs
/// to enable the #GDK_PROXIMITY_IN_MASK mask.
/// </para>
/// <para>
/// This signal will be sent to the grab widget if there is one.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.ProximityInEventSignal> Signal_ProximityInEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.ProximityInEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.proximity_in_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventProximityHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.ProximityInEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "proximity-in-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// To receive this signal the #GdkWindow associated to the widget needs
/// to enable the #GDK_PROXIMITY_OUT_MASK mask.
/// </para>
/// <para>
/// This signal will be sent to the grab widget if there is one.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.ProximityOutEventSignal> Signal_ProximityOutEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.ProximityOutEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.proximity_out_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventProximityHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.ProximityOutEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "proximity-out-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when #GtkWidget:has-tooltip is %TRUE and the hover timeout
/// has expired with the cursor hovering &quot;above&quot; @widget; or emitted when @widget got
/// focus in keyboard mode.
/// </para>
/// <para>
/// Using the given coordinates, the signal handler should determine
/// whether a tooltip should be shown for @widget. If this is the case
/// %TRUE should be returned, %FALSE otherwise.  Note that if
/// @keyboard_mode is %TRUE, the values of @x and @y are undefined and
/// should not be used.
/// </para>
/// <para>
/// The signal handler is free to manipulate @tooltip with the therefore
/// destined function calls.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.QueryTooltipSignal> Signal_QueryTooltip(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.QueryTooltipSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.query_tooltip handler = ( MentorLake.Gtk.GtkWidgetHandle self,  int x,  int y,  bool keyboard_mode,  MentorLake.Gtk.GtkTooltipHandle tooltip,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.QueryTooltipSignal()
				{
					Self = self, X = x, Y = y, KeyboardMode = keyboard_mode, Tooltip = tooltip, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "query-tooltip", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::realize signal is emitted when @widget is associated with a
/// #GdkWindow, which means that gtk_widget_realize() has been called or the
/// widget has been mapped (that is, it is going to be drawn).
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.RealizeSignal> Signal_Realize(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.RealizeSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.realize handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.RealizeSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "realize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::screen-changed signal gets emitted when the
/// screen of a widget has changed.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.ScreenChangedSignal> Signal_ScreenChanged(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.ScreenChangedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.screen_changed handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkScreenHandle previous_screen,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.ScreenChangedSignal()
				{
					Self = self, PreviousScreen = previous_screen, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "screen-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::scroll-event signal is emitted when a button in the 4 to 7
/// range is pressed. Wheel mice are usually configured to generate
/// button press events for buttons 4 and 5 when the wheel is turned.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_SCROLL_MASK mask.
/// </para>
/// <para>
/// This signal will be sent to the grab widget if there is one.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.ScrollEventSignal> Signal_ScrollEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.ScrollEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.scroll_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventScrollHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.ScrollEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "scroll-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::selection-clear-event signal will be emitted when the
/// the @widget&apos;s window has lost ownership of a selection.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.SelectionClearEventSignal> Signal_SelectionClearEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.SelectionClearEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.selection_clear_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventSelectionHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.SelectionClearEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selection-clear-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.SelectionGetSignal> Signal_SelectionGet(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.SelectionGetSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.selection_get handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkSelectionDataHandle data,  uint info,  uint time,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.SelectionGetSignal()
				{
					Self = self, Data = data, Info = info, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selection-get", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.SelectionNotifyEventSignal> Signal_SelectionNotifyEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.SelectionNotifyEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.selection_notify_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventSelectionHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.SelectionNotifyEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selection-notify-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.SelectionReceivedSignal> Signal_SelectionReceived(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.SelectionReceivedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.selection_received handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkSelectionDataHandle data,  uint time,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.SelectionReceivedSignal()
				{
					Self = self, Data = data, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selection-received", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::selection-request-event signal will be emitted when
/// another client requests ownership of the selection owned by
/// the @widget&apos;s window.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.SelectionRequestEventSignal> Signal_SelectionRequestEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.SelectionRequestEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.selection_request_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventSelectionHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.SelectionRequestEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selection-request-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::show signal is emitted when @widget is shown, for example with
/// gtk_widget_show().
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.ShowSignal> Signal_Show(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.ShowSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.show handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.ShowSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "show", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.ShowHelpSignal> Signal_ShowHelp(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.ShowHelpSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.show_help handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkWidgetHelpType help_type,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.ShowHelpSignal()
				{
					Self = self, HelpType = help_type, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "show-help", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.SizeAllocateSignal> Signal_SizeAllocate(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.SizeAllocateSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.size_allocate handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkAllocationHandle allocation,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.SizeAllocateSignal()
				{
					Self = self, Allocation = allocation, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "size-allocate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::state-changed signal is emitted when the widget state changes.
/// See gtk_widget_get_state().
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.StateChangedSignal> Signal_StateChanged(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.StateChangedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.state_changed handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkStateType state,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.StateChangedSignal()
				{
					Self = self, State = state, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "state-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::state-flags-changed signal is emitted when the widget state
/// changes, see gtk_widget_get_state_flags().
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.StateFlagsChangedSignal> Signal_StateFlagsChanged(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.StateFlagsChangedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.state_flags_changed handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkStateFlags flags,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.StateFlagsChangedSignal()
				{
					Self = self, Flags = flags, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "state-flags-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::style-set signal is emitted when a new style has been set
/// on a widget. Note that style-modifying functions like
/// gtk_widget_modify_base() also cause this signal to be emitted.
/// </para>
/// <para>
/// Note that this signal is emitted for changes to the deprecated
/// #GtkStyle. To track changes to the #GtkStyleContext associated
/// with a widget, use the #GtkWidget::style-updated signal.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.StyleSetSignal> Signal_StyleSet(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.StyleSetSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.style_set handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkStyleHandle previous_style,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.StyleSetSignal()
				{
					Self = self, PreviousStyle = previous_style, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "style-set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::style-updated signal is a convenience signal that is emitted when the
/// #GtkStyleContext::changed signal is emitted on the @widget&apos;s associated
/// #GtkStyleContext as returned by gtk_widget_get_style_context().
/// </para>
/// <para>
/// Note that style-modifying functions like gtk_widget_override_color() also
/// cause this signal to be emitted.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.StyleUpdatedSignal> Signal_StyleUpdated(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.StyleUpdatedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.style_updated handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.StyleUpdatedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "style-updated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.TouchEventSignal> Signal_TouchEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.TouchEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.touch_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventHandle @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.TouchEventSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "touch-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::unmap signal is emitted when @widget is going to be unmapped, which
/// means that either it or any of its parents up to the toplevel widget have
/// been set as hidden.
/// </para>
/// <para>
/// As ::unmap indicates that a widget will not be shown any longer, it can be
/// used to, for example, stop an animation on the widget.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.UnmapSignal> Signal_Unmap(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.UnmapSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.unmap handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.UnmapSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "unmap", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::unmap-event signal will be emitted when the @widget&apos;s window is
/// unmapped. A window is unmapped when it becomes invisible on the screen.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_STRUCTURE_MASK mask. GDK will enable this mask
/// automatically for all new windows.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.UnmapEventSignal> Signal_UnmapEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.UnmapEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.unmap_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventAnyHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.UnmapEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "unmap-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::unrealize signal is emitted when the #GdkWindow associated with
/// @widget is destroyed, which means that gtk_widget_unrealize() has been
/// called or the widget has been unmapped (that is, it is going to be
/// hidden).
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.UnrealizeSignal> Signal_Unrealize(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.UnrealizeSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.unrealize handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.UnrealizeSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "unrealize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::visibility-notify-event will be emitted when the @widget&apos;s
/// window is obscured or unobscured.
/// </para>
/// <para>
/// To receive this signal the #GdkWindow associated to the widget needs
/// to enable the #GDK_VISIBILITY_NOTIFY_MASK mask.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.VisibilityNotifyEventSignal> Signal_VisibilityNotifyEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.VisibilityNotifyEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.visibility_notify_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventVisibilityHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.VisibilityNotifyEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "visibility-notify-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::window-state-event will be emitted when the state of the
/// toplevel window associated to the @widget changes.
/// </para>
/// <para>
/// To receive this signal the #GdkWindow associated to the widget
/// needs to enable the #GDK_STRUCTURE_MASK mask. GDK will enable
/// this mask automatically for all new windows.
/// </para>
/// </summary>

	public static IObservable<GtkWidgetHandleSignalStructs.WindowStateEventSignal> Signal_WindowStateEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.WindowStateEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.window_state_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventWindowStateHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.WindowStateEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "window-state-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkWidgetHandleSignalStructs
{

public class AccelClosuresChangedSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;

	public IntPtr UserData;
}

public class ButtonPressEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEventButton which triggered
///   this signal.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventButtonHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class ButtonReleaseEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEventButton which triggered
///   this signal.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventButtonHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class CanActivateAccelSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the ID of a signal installed on @widget
/// </para>
/// </summary>

	public uint SignalId;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if the signal can be activated.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class ChildNotifySignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GParamSpec of the changed child property
/// </para>
/// </summary>

	public MentorLake.GObject.GParamSpecHandle ChildProperty;

	public IntPtr UserData;
}

public class CompositedChangedSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;

	public IntPtr UserData;
}

public class ConfigureEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEventConfigure which triggered
///   this signal.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventConfigureHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class DamageEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEventExpose event
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventExposeHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class DeleteEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the event which triggered this signal
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class DestroySignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;

	public IntPtr UserData;
}

public class DestroyEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the event which triggered this signal
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class DirectionChangedSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the previous text direction of @widget
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextDirection PreviousDirection;

	public IntPtr UserData;
}

public class DragBeginSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the drag context
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkDragContextHandle Context;

	public IntPtr UserData;
}

public class DragDataDeleteSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the drag context
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkDragContextHandle Context;

	public IntPtr UserData;
}

public class DragDataGetSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the drag context
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkDragContextHandle Context;
/// <summary>
/// <para>
/// the #GtkSelectionData to be filled with the dragged data
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkSelectionDataHandle Data;
/// <summary>
/// <para>
/// the info that has been registered with the target in the
///        #GtkTargetList
/// </para>
/// </summary>

	public uint Info;
/// <summary>
/// <para>
/// the timestamp at which the data was requested
/// </para>
/// </summary>

	public uint Time;

	public IntPtr UserData;
}

public class DragDataReceivedSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the drag context
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkDragContextHandle Context;
/// <summary>
/// <para>
/// where the drop happened
/// </para>
/// </summary>

	public int X;
/// <summary>
/// <para>
/// where the drop happened
/// </para>
/// </summary>

	public int Y;
/// <summary>
/// <para>
/// the received data
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkSelectionDataHandle Data;
/// <summary>
/// <para>
/// the info that has been registered with the target in the
///        #GtkTargetList
/// </para>
/// </summary>

	public uint Info;
/// <summary>
/// <para>
/// the timestamp at which the data was received
/// </para>
/// </summary>

	public uint Time;

	public IntPtr UserData;
}

public class DragDropSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the drag context
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkDragContextHandle Context;
/// <summary>
/// <para>
/// the x coordinate of the current cursor position
/// </para>
/// </summary>

	public int X;
/// <summary>
/// <para>
/// the y coordinate of the current cursor position
/// </para>
/// </summary>

	public int Y;
/// <summary>
/// <para>
/// the timestamp of the motion event
/// </para>
/// </summary>

	public uint Time;

	public IntPtr UserData;
/// <summary>
/// <para>
/// whether the cursor position is in a drop zone
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class DragEndSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the drag context
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkDragContextHandle Context;

	public IntPtr UserData;
}

public class DragFailedSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the drag context
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkDragContextHandle Context;
/// <summary>
/// <para>
/// the result of the drag operation
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkDragResult Result;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if the failed drag operation has been already handled.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class DragLeaveSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the drag context
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkDragContextHandle Context;
/// <summary>
/// <para>
/// the timestamp of the motion event
/// </para>
/// </summary>

	public uint Time;

	public IntPtr UserData;
}

public class DragMotionSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the drag context
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkDragContextHandle Context;
/// <summary>
/// <para>
/// the x coordinate of the current cursor position
/// </para>
/// </summary>

	public int X;
/// <summary>
/// <para>
/// the y coordinate of the current cursor position
/// </para>
/// </summary>

	public int Y;
/// <summary>
/// <para>
/// the timestamp of the motion event
/// </para>
/// </summary>

	public uint Time;

	public IntPtr UserData;
/// <summary>
/// <para>
/// whether the cursor position is in a drop zone
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class DrawSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the cairo context to draw to
/// </para>
/// </summary>

	public MentorLake.cairo.cairo_tHandle Cr;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
/// %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class EnterNotifyEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEventCrossing which triggered
///   this signal.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventCrossingHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class EventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEvent which triggered this signal
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event
/// and to cancel the emission of the second specific ::event signal.
///   %FALSE to propagate the event further and to allow the emission of
///   the second signal. The ::event-after signal is emitted regardless of
///   the return value.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class EventAfterSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEvent which triggered this signal
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventHandle Event;

	public IntPtr UserData;
}

public class FocusSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;

	public MentorLake.Gtk.GtkDirectionType Direction;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event. %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class FocusInEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEventFocus which triggered
///   this signal.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventFocusHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class FocusOutEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEventFocus which triggered this
///   signal.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventFocusHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class GrabBrokenEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEventGrabBroken event
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventGrabBrokenHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for
///   the event. %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class GrabFocusSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;

	public IntPtr UserData;
}

public class GrabNotifySignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// %FALSE if the widget becomes shadowed, %TRUE
///               if it becomes unshadowed
/// </para>
/// </summary>

	public bool WasGrabbed;

	public IntPtr UserData;
}

public class HideSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;

	public IntPtr UserData;
}

public class HierarchyChangedSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the previous toplevel ancestor, or %NULL
///   if the widget was previously unanchored
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle PreviousToplevel;

	public IntPtr UserData;
}

public class KeyPressEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEventKey which triggered this signal.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventKeyHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class KeyReleaseEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEventKey which triggered this signal.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventKeyHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class KeynavFailedSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the direction of movement
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkDirectionType Direction;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if stopping keyboard navigation is fine, %FALSE
///          if the emitting widget should try to handle the keyboard
///          navigation attempt in its parent container(s).
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class LeaveNotifyEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEventCrossing which triggered
///   this signal.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventCrossingHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class MapSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;

	public IntPtr UserData;
}

public class MapEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEventAny which triggered this signal.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventAnyHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class MnemonicActivateSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// %TRUE if there are other widgets with the same mnemonic
/// </para>
/// </summary>

	public bool GroupCycling;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
/// %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class MotionNotifyEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEventMotion which triggered
///   this signal.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventMotionHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class MoveFocusSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;

	public MentorLake.Gtk.GtkDirectionType Direction;

	public IntPtr UserData;
}

public class ParentSetSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the previous parent, or %NULL if the widget
///   just got its initial parent.
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle OldParent;

	public IntPtr UserData;
}

public class PopupMenuSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if a menu was activated
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class PropertyNotifyEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEventProperty which triggered
///   this signal.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventPropertyHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class ProximityInEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEventProximity which triggered
///   this signal.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventProximityHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class ProximityOutEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEventProximity which triggered
///   this signal.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventProximityHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class QueryTooltipSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the x coordinate of the cursor position where the request has
///     been emitted, relative to @widget&apos;s left side
/// </para>
/// </summary>

	public int X;
/// <summary>
/// <para>
/// the y coordinate of the cursor position where the request has
///     been emitted, relative to @widget&apos;s top
/// </para>
/// </summary>

	public int Y;
/// <summary>
/// <para>
/// %TRUE if the tooltip was triggered using the keyboard
/// </para>
/// </summary>

	public bool KeyboardMode;
/// <summary>
/// <para>
/// a #GtkTooltip
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTooltipHandle Tooltip;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if @tooltip should be shown right now, %FALSE otherwise.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class RealizeSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;

	public IntPtr UserData;
}

public class ScreenChangedSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the previous screen, or %NULL if the
///   widget was not associated with a screen before
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkScreenHandle PreviousScreen;

	public IntPtr UserData;
}

public class ScrollEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEventScroll which triggered
///   this signal.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventScrollHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class SelectionClearEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEventSelection which triggered
///   this signal.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventSelectionHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class SelectionGetSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;

	public MentorLake.Gtk.GtkSelectionDataHandle Data;

	public uint Info;

	public uint Time;

	public IntPtr UserData;
}

public class SelectionNotifyEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;

	public MentorLake.Gdk.GdkEventSelectionHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event. %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class SelectionReceivedSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;

	public MentorLake.Gtk.GtkSelectionDataHandle Data;

	public uint Time;

	public IntPtr UserData;
}

public class SelectionRequestEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEventSelection which triggered
///   this signal.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventSelectionHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class ShowSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;

	public IntPtr UserData;
}

public class ShowHelpSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;

	public MentorLake.Gtk.GtkWidgetHelpType HelpType;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
/// %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class SizeAllocateSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the region which has been
///   allocated to the widget.
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkAllocationHandle Allocation;

	public IntPtr UserData;
}

public class StateChangedSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the previous state
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkStateType State;

	public IntPtr UserData;
}

public class StateFlagsChangedSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// The previous state flags.
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkStateFlags Flags;

	public IntPtr UserData;
}

public class StyleSetSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the previous style, or %NULL if the widget
///   just got its initial style
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkStyleHandle PreviousStyle;

	public IntPtr UserData;
}

public class StyleUpdatedSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;

	public IntPtr UserData;
}

public class TouchEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;

	public MentorLake.Gdk.GdkEventHandle Object;

	public IntPtr UserData;

	public bool ReturnValue;
}

public class UnmapSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;

	public IntPtr UserData;
}

public class UnmapEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEventAny which triggered this signal
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventAnyHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class UnrealizeSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;

	public IntPtr UserData;
}

public class VisibilityNotifyEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEventVisibility which
///   triggered this signal.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventVisibilityHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class WindowStateEventSignal
{

	public MentorLake.Gtk.GtkWidgetHandle Self;
/// <summary>
/// <para>
/// the #GdkEventWindowState which
///   triggered this signal.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventWindowStateHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the
///   event. %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}
}

public static class GtkWidgetHandleSignalDelegates
{


/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void accel_closures_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::button-press-event signal will be emitted when a button
/// (typically from a mouse) is pressed.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the
/// widget needs to enable the #GDK_BUTTON_PRESS_MASK mask.
/// </para>
/// <para>
/// This signal will be sent to the grab widget if there is one.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventButton which triggered
///   this signal.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool button_press_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventButtonHandle>))] MentorLake.Gdk.GdkEventButtonHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// The ::button-release-event signal will be emitted when a button
/// (typically from a mouse) is released.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the
/// widget needs to enable the #GDK_BUTTON_RELEASE_MASK mask.
/// </para>
/// <para>
/// This signal will be sent to the grab widget if there is one.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventButton which triggered
///   this signal.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool button_release_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventButtonHandle>))] MentorLake.Gdk.GdkEventButtonHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// Determines whether an accelerator that activates the signal
/// identified by @signal_id can currently be activated.
/// This signal is present to allow applications and derived
/// widgets to override the default #GtkWidget handling
/// for determining whether an accelerator can be activated.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="signal_id">
/// the ID of a signal installed on @widget
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if the signal can be activated.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool can_activate_accel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, uint signal_id, IntPtr user_data);


/// <summary>
/// <para>
/// The ::child-notify signal is emitted for each
/// [child property][child-properties]  that has
/// changed on an object. The signal&apos;s detail holds the property name.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="child_property">
/// the #GParamSpec of the changed child property
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void child_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle child_property, IntPtr user_data);


/// <summary>
/// <para>
/// The ::composited-changed signal is emitted when the composited
/// status of @widgets screen changes.
/// See gdk_screen_is_composited().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void composited_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::configure-event signal will be emitted when the size, position or
/// stacking of the @widget&apos;s window has changed.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_STRUCTURE_MASK mask. GDK will enable this mask
/// automatically for all new windows.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventConfigure which triggered
///   this signal.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool configure_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventConfigureHandle>))] MentorLake.Gdk.GdkEventConfigureHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a redirected window belonging to @widget gets drawn into.
/// The region/area members of the event shows what area of the redirected
/// drawable was drawn into.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventExpose event
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool damage_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventExposeHandle>))] MentorLake.Gdk.GdkEventExposeHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// The ::delete-event signal is emitted if a user requests that
/// a toplevel window is closed. The default handler for this signal
/// destroys the window. Connecting gtk_widget_hide_on_delete() to
/// this signal will cause the window to be hidden instead, so that
/// it can later be shown again without reconstructing it.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the event which triggered this signal
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool delete_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// Signals that all holders of a reference to the widget should release
/// the reference that they hold. May result in finalization of the widget
/// if all references are released.
/// </para>
/// <para>
/// This signal is not suitable for saving widget state.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::destroy-event signal is emitted when a #GdkWindow is destroyed.
/// You rarely get this signal, because most widgets disconnect themselves
/// from their window before they destroy it, so no widget owns the
/// window at destroy time.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_STRUCTURE_MASK mask. GDK will enable this mask
/// automatically for all new windows.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the event which triggered this signal
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool destroy_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// The ::direction-changed signal is emitted when the text direction
/// of a widget changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="previous_direction">
/// the previous text direction of @widget
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void direction_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, MentorLake.Gtk.GtkTextDirection previous_direction, IntPtr user_data);


/// <summary>
/// <para>
/// The ::drag-begin signal is emitted on the drag source when a drag is
/// started. A typical reason to connect to this signal is to set up a
/// custom drag icon with e.g. gtk_drag_source_set_icon_pixbuf().
/// </para>
/// <para>
/// Note that some widgets set up a drag icon in the default handler of
/// this signal, so you may have to use g_signal_connect_after() to
/// override what the default handler did.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="context">
/// the drag context
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_begin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, IntPtr user_data);


/// <summary>
/// <para>
/// The ::drag-data-delete signal is emitted on the drag source when a drag
/// with the action %GDK_ACTION_MOVE is successfully completed. The signal
/// handler is responsible for deleting the data that has been dropped. What
/// &quot;delete&quot; means depends on the context of the drag operation.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="context">
/// the drag context
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_data_delete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, IntPtr user_data);


/// <summary>
/// <para>
/// The ::drag-data-get signal is emitted on the drag source when the drop
/// site requests the data which is dragged. It is the responsibility of
/// the signal handler to fill @data with the data in the format which
/// is indicated by @info. See gtk_selection_data_set() and
/// gtk_selection_data_set_text().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="context">
/// the drag context
/// </param>
/// <param name="data">
/// the #GtkSelectionData to be filled with the dragged data
/// </param>
/// <param name="info">
/// the info that has been registered with the target in the
///        #GtkTargetList
/// </param>
/// <param name="time">
/// the timestamp at which the data was requested
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_data_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle data, uint info, uint time, IntPtr user_data);


/// <summary>
/// <para>
/// The ::drag-data-received signal is emitted on the drop site when the
/// dragged data has been received. If the data was received in order to
/// determine whether the drop will be accepted, the handler is expected
/// to call gdk_drag_status() and not finish the drag.
/// If the data was received in response to a #GtkWidget::drag-drop signal
/// (and this is the last target to be received), the handler for this
/// signal is expected to process the received data and then call
/// gtk_drag_finish(), setting the @success parameter depending on
/// whether the data was processed successfully.
/// </para>
/// <para>
/// Applications must create some means to determine why the signal was emitted
/// and therefore whether to call gdk_drag_status() or gtk_drag_finish().
/// </para>
/// <para>
/// The handler may inspect the selected action with
/// gdk_drag_context_get_selected_action() before calling
/// gtk_drag_finish(), e.g. to implement %GDK_ACTION_ASK as
/// shown in the following example:
/// <code>
/// void
/// void
/// drag_data_received (GtkWidget          *widget,
///                     GdkDragContext     *context,
///                     gint                x,
///                     gint                y,
///                     GtkSelectionData   *data,
///                     guint               info,
///                     guint               time)
/// {
///   if ((data-&amp;gt;length &amp;gt;= 0) &amp;&amp; (data-&amp;gt;format == 8))
///     {
///       GdkDragAction action;
/// 
///       // handle data here
/// 
///       action = gdk_drag_context_get_selected_action (context);
///       if (action == GDK_ACTION_ASK)
///         {
///           GtkWidget *dialog;
///           gint response;
/// 
///           dialog = gtk_message_dialog_new (NULL,
///                                            GTK_DIALOG_MODAL |
///                                            GTK_DIALOG_DESTROY_WITH_PARENT,
///                                            GTK_MESSAGE_INFO,
///                                            GTK_BUTTONS_YES_NO,
///                                            &quot;Move the data ?\n&quot;);
///           response = gtk_dialog_run (GTK_DIALOG (dialog));
///           gtk_widget_destroy (dialog);
/// 
///           if (response == GTK_RESPONSE_YES)
///             action = GDK_ACTION_MOVE;
///           else
///             action = GDK_ACTION_COPY;
///          }
/// 
///       gtk_drag_finish (context, TRUE, action == GDK_ACTION_MOVE, time);
///     }
///   else
///     gtk_drag_finish (context, FALSE, FALSE, time);
///  }
/// </code>
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="context">
/// the drag context
/// </param>
/// <param name="x">
/// where the drop happened
/// </param>
/// <param name="y">
/// where the drop happened
/// </param>
/// <param name="data">
/// the received data
/// </param>
/// <param name="info">
/// the info that has been registered with the target in the
///        #GtkTargetList
/// </param>
/// <param name="time">
/// the timestamp at which the data was received
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_data_received([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, int x, int y, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle data, uint info, uint time, IntPtr user_data);


/// <summary>
/// <para>
/// The ::drag-drop signal is emitted on the drop site when the user drops
/// the data onto the widget. The signal handler must determine whether
/// the cursor position is in a drop zone or not. If it is not in a drop
/// zone, it returns %FALSE and no further processing is necessary.
/// Otherwise, the handler returns %TRUE. In this case, the handler must
/// ensure that gtk_drag_finish() is called to let the source know that
/// the drop is done. The call to gtk_drag_finish() can be done either
/// directly or in a #GtkWidget::drag-data-received handler which gets
/// triggered by calling gtk_drag_get_data() to receive the data for one
/// or more of the supported targets.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="context">
/// the drag context
/// </param>
/// <param name="x">
/// the x coordinate of the current cursor position
/// </param>
/// <param name="y">
/// the y coordinate of the current cursor position
/// </param>
/// <param name="time">
/// the timestamp of the motion event
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// whether the cursor position is in a drop zone
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool drag_drop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, int x, int y, uint time, IntPtr user_data);


/// <summary>
/// <para>
/// The ::drag-end signal is emitted on the drag source when a drag is
/// finished.  A typical reason to connect to this signal is to undo
/// things done in #GtkWidget::drag-begin.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="context">
/// the drag context
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, IntPtr user_data);


/// <summary>
/// <para>
/// The ::drag-failed signal is emitted on the drag source when a drag has
/// failed. The signal handler may hook custom code to handle a failed DnD
/// operation based on the type of error, it returns %TRUE is the failure has
/// been already handled (not showing the default &quot;drag operation failed&quot;
/// animation), otherwise it returns %FALSE.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="context">
/// the drag context
/// </param>
/// <param name="result">
/// the result of the drag operation
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if the failed drag operation has been already handled.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool drag_failed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, MentorLake.Gtk.GtkDragResult result, IntPtr user_data);


/// <summary>
/// <para>
/// The ::drag-leave signal is emitted on the drop site when the cursor
/// leaves the widget. A typical reason to connect to this signal is to
/// undo things done in #GtkWidget::drag-motion, e.g. undo highlighting
/// with gtk_drag_unhighlight().
/// </para>
/// 
/// <para>
/// Likewise, the #GtkWidget::drag-leave signal is also emitted before the
/// ::drag-drop signal, for instance to allow cleaning up of a preview item
/// created in the #GtkWidget::drag-motion signal handler.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="context">
/// the drag context
/// </param>
/// <param name="time">
/// the timestamp of the motion event
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_leave([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, uint time, IntPtr user_data);


/// <summary>
/// <para>
/// The ::drag-motion signal is emitted on the drop site when the user
/// moves the cursor over the widget during a drag. The signal handler
/// must determine whether the cursor position is in a drop zone or not.
/// If it is not in a drop zone, it returns %FALSE and no further processing
/// is necessary. Otherwise, the handler returns %TRUE. In this case, the
/// handler is responsible for providing the necessary information for
/// displaying feedback to the user, by calling gdk_drag_status().
/// </para>
/// <para>
/// If the decision whether the drop will be accepted or rejected can&apos;t be
/// made based solely on the cursor position and the type of the data, the
/// handler may inspect the dragged data by calling gtk_drag_get_data() and
/// defer the gdk_drag_status() call to the #GtkWidget::drag-data-received
/// handler. Note that you must pass #GTK_DEST_DEFAULT_DROP,
/// #GTK_DEST_DEFAULT_MOTION or #GTK_DEST_DEFAULT_ALL to gtk_drag_dest_set()
/// when using the drag-motion signal that way.
/// </para>
/// <para>
/// Also note that there is no drag-enter signal. The drag receiver has to
/// keep track of whether he has received any drag-motion signals since the
/// last #GtkWidget::drag-leave and if not, treat the drag-motion signal as
/// an &quot;enter&quot; signal. Upon an &quot;enter&quot;, the handler will typically highlight
/// the drop site with gtk_drag_highlight().
/// <code>
/// static void
/// static void
/// drag_motion (GtkWidget      *widget,
///              GdkDragContext *context,
///              gint            x,
///              gint            y,
///              guint           time)
/// {
///   GdkAtom target;
/// 
///   PrivateData *private_data = GET_PRIVATE_DATA (widget);
/// 
///   if (!private_data-&amp;gt;drag_highlight)
///    {
///      private_data-&amp;gt;drag_highlight = 1;
///      gtk_drag_highlight (widget);
///    }
/// 
///   target = gtk_drag_dest_find_target (widget, context, NULL);
///   if (target == GDK_NONE)
///     gdk_drag_status (context, 0, time);
///   else
///    {
///      private_data-&amp;gt;pending_status
///         = gdk_drag_context_get_suggested_action (context);
///      gtk_drag_get_data (widget, context, target, time);
///    }
/// 
///   return TRUE;
/// }
/// 
/// static void
/// drag_data_received (GtkWidget        *widget,
///                     GdkDragContext   *context,
///                     gint              x,
///                     gint              y,
///                     GtkSelectionData *selection_data,
///                     guint             info,
///                     guint             time)
/// {
///   PrivateData *private_data = GET_PRIVATE_DATA (widget);
/// 
///   if (private_data-&amp;gt;suggested_action)
///    {
///      private_data-&amp;gt;suggested_action = 0;
/// 
///      // We are getting this data due to a request in drag_motion,
///      // rather than due to a request in drag_drop, so we are just
///      // supposed to call gdk_drag_status(), not actually paste in
///      // the data.
/// 
///      str = gtk_selection_data_get_text (selection_data);
///      if (!data_is_acceptable (str))
///        gdk_drag_status (context, 0, time);
///      else
///        gdk_drag_status (context,
///                         private_data-&amp;gt;suggested_action,
///                         time);
///    }
///   else
///    {
///      // accept the drop
///    }
/// }
/// </code>
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="context">
/// the drag context
/// </param>
/// <param name="x">
/// the x coordinate of the current cursor position
/// </param>
/// <param name="y">
/// the y coordinate of the current cursor position
/// </param>
/// <param name="time">
/// the timestamp of the motion event
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// whether the cursor position is in a drop zone
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool drag_motion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, int x, int y, uint time, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when a widget is supposed to render itself.
/// The @widget&apos;s top left corner must be painted at the origin of
/// the passed in context and be sized to the values returned by
/// gtk_widget_get_allocated_width() and
/// gtk_widget_get_allocated_height().
/// </para>
/// <para>
/// Signal handlers connected to this signal can modify the cairo
/// context passed as @cr in any way they like and don&apos;t need to
/// restore it. The signal emission takes care of calling cairo_save()
/// before and cairo_restore() after invoking the handler.
/// </para>
/// <para>
/// The signal handler will get a @cr with a clip region already set to the
/// widget&apos;s dirty region, i.e. to the area that needs repainting.  Complicated
/// widgets that want to avoid redrawing themselves completely can get the full
/// extents of the clip region with gdk_cairo_get_clip_rectangle(), or they can
/// get a finer-grained representation of the dirty region with
/// cairo_copy_clip_rectangle_list().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="cr">
/// the cairo context to draw to
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
/// %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool draw([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, IntPtr user_data);


/// <summary>
/// <para>
/// The ::enter-notify-event will be emitted when the pointer enters
/// the @widget&apos;s window.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_ENTER_NOTIFY_MASK mask.
/// </para>
/// <para>
/// This signal will be sent to the grab widget if there is one.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventCrossing which triggered
///   this signal.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool enter_notify_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventCrossingHandle>))] MentorLake.Gdk.GdkEventCrossingHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// The GTK+ main loop will emit three signals for each GDK event delivered
/// to a widget: one generic ::event signal, another, more specific,
/// signal that matches the type of event delivered (e.g.
/// #GtkWidget::key-press-event) and finally a generic
/// #GtkWidget::event-after signal.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEvent which triggered this signal
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event
/// and to cancel the emission of the second specific ::event signal.
///   %FALSE to propagate the event further and to allow the emission of
///   the second signal. The ::event-after signal is emitted regardless of
///   the return value.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool @event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// After the emission of the #GtkWidget::event signal and (optionally)
/// the second more specific signal, ::event-after will be emitted
/// regardless of the previous two signals handlers return values.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEvent which triggered this signal
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void event_after([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="direction">
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event. %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, MentorLake.Gtk.GtkDirectionType direction, IntPtr user_data);


/// <summary>
/// <para>
/// The ::focus-in-event signal will be emitted when the keyboard focus
/// enters the @widget&apos;s window.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_FOCUS_CHANGE_MASK mask.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventFocus which triggered
///   this signal.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool focus_in_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventFocusHandle>))] MentorLake.Gdk.GdkEventFocusHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// The ::focus-out-event signal will be emitted when the keyboard focus
/// leaves the @widget&apos;s window.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_FOCUS_CHANGE_MASK mask.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventFocus which triggered this
///   signal.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool focus_out_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventFocusHandle>))] MentorLake.Gdk.GdkEventFocusHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a pointer or keyboard grab on a window belonging
/// to @widget gets broken.
/// </para>
/// <para>
/// On X11, this happens when the grab window becomes unviewable
/// (i.e. it or one of its ancestors is unmapped), or if the same
/// application grabs the pointer or keyboard again.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventGrabBroken event
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for
///   the event. %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool grab_broken_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventGrabBrokenHandle>))] MentorLake.Gdk.GdkEventGrabBrokenHandle @event, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void grab_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::grab-notify signal is emitted when a widget becomes
/// shadowed by a GTK+ grab (not a pointer or keyboard grab) on
/// another widget, or when it becomes unshadowed due to a grab
/// being removed.
/// </para>
/// <para>
/// A widget is shadowed by a gtk_grab_add() when the topmost
/// grab widget in the grab stack of its window group is not
/// its ancestor.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="was_grabbed">
/// %FALSE if the widget becomes shadowed, %TRUE
///               if it becomes unshadowed
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void grab_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, bool was_grabbed, IntPtr user_data);


/// <summary>
/// <para>
/// The ::hide signal is emitted when @widget is hidden, for example with
/// gtk_widget_hide().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void hide([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::hierarchy-changed signal is emitted when the
/// anchored state of a widget changes. A widget is
/// “anchored” when its toplevel
/// ancestor is a #GtkWindow. This signal is emitted when
/// a widget changes from un-anchored to anchored or vice-versa.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="previous_toplevel">
/// the previous toplevel ancestor, or %NULL
///   if the widget was previously unanchored
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void hierarchy_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle previous_toplevel, IntPtr user_data);


/// <summary>
/// <para>
/// The ::key-press-event signal is emitted when a key is pressed. The signal
/// emission will reoccur at the key-repeat rate when the key is kept pressed.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_KEY_PRESS_MASK mask.
/// </para>
/// <para>
/// This signal will be sent to the grab widget if there is one.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventKey which triggered this signal.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool key_press_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventKeyHandle>))] MentorLake.Gdk.GdkEventKeyHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// The ::key-release-event signal is emitted when a key is released.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_KEY_RELEASE_MASK mask.
/// </para>
/// <para>
/// This signal will be sent to the grab widget if there is one.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventKey which triggered this signal.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool key_release_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventKeyHandle>))] MentorLake.Gdk.GdkEventKeyHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// Gets emitted if keyboard navigation fails.
/// See gtk_widget_keynav_failed() for details.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="direction">
/// the direction of movement
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if stopping keyboard navigation is fine, %FALSE
///          if the emitting widget should try to handle the keyboard
///          navigation attempt in its parent container(s).
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool keynav_failed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, MentorLake.Gtk.GtkDirectionType direction, IntPtr user_data);


/// <summary>
/// <para>
/// The ::leave-notify-event will be emitted when the pointer leaves
/// the @widget&apos;s window.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_LEAVE_NOTIFY_MASK mask.
/// </para>
/// <para>
/// This signal will be sent to the grab widget if there is one.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventCrossing which triggered
///   this signal.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool leave_notify_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventCrossingHandle>))] MentorLake.Gdk.GdkEventCrossingHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// The ::map signal is emitted when @widget is going to be mapped, that is
/// when the widget is visible (which is controlled with
/// gtk_widget_set_visible()) and all its parents up to the toplevel widget
/// are also visible. Once the map has occurred, #GtkWidget::map-event will
/// be emitted.
/// </para>
/// <para>
/// The ::map signal can be used to determine whether a widget will be drawn,
/// for instance it can resume an animation that was stopped during the
/// emission of #GtkWidget::unmap.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void map([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::map-event signal will be emitted when the @widget&apos;s window is
/// mapped. A window is mapped when it becomes visible on the screen.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_STRUCTURE_MASK mask. GDK will enable this mask
/// automatically for all new windows.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventAny which triggered this signal.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool map_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventAnyHandle>))] MentorLake.Gdk.GdkEventAnyHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// The default handler for this signal activates @widget if @group_cycling
/// is %FALSE, or just makes @widget grab focus if @group_cycling is %TRUE.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="group_cycling">
/// %TRUE if there are other widgets with the same mnemonic
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
/// %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool mnemonic_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, bool group_cycling, IntPtr user_data);


/// <summary>
/// <para>
/// The ::motion-notify-event signal is emitted when the pointer moves
/// over the widget&apos;s #GdkWindow.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget
/// needs to enable the #GDK_POINTER_MOTION_MASK mask.
/// </para>
/// <para>
/// This signal will be sent to the grab widget if there is one.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventMotion which triggered
///   this signal.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool motion_notify_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventMotionHandle>))] MentorLake.Gdk.GdkEventMotionHandle @event, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="direction">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, MentorLake.Gtk.GtkDirectionType direction, IntPtr user_data);


/// <summary>
/// <para>
/// The ::parent-set signal is emitted when a new parent
/// has been set on a widget.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="old_parent">
/// the previous parent, or %NULL if the widget
///   just got its initial parent.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void parent_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle old_parent, IntPtr user_data);


/// <summary>
/// <para>
/// This signal gets emitted whenever a widget should pop up a context
/// menu. This usually happens through the standard key binding mechanism;
/// by pressing a certain key while a widget is focused, the user can cause
/// the widget to pop up a menu.  For example, the #GtkEntry widget creates
/// a menu with clipboard commands. See the
/// [Popup Menu Migration Checklist][checklist-popup-menu]
/// for an example of how to use this signal.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if a menu was activated
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool popup_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::property-notify-event signal will be emitted when a property on
/// the @widget&apos;s window has been changed or deleted.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_PROPERTY_CHANGE_MASK mask.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventProperty which triggered
///   this signal.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool property_notify_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventPropertyHandle>))] MentorLake.Gdk.GdkEventPropertyHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// To receive this signal the #GdkWindow associated to the widget needs
/// to enable the #GDK_PROXIMITY_IN_MASK mask.
/// </para>
/// <para>
/// This signal will be sent to the grab widget if there is one.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventProximity which triggered
///   this signal.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool proximity_in_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventProximityHandle>))] MentorLake.Gdk.GdkEventProximityHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// To receive this signal the #GdkWindow associated to the widget needs
/// to enable the #GDK_PROXIMITY_OUT_MASK mask.
/// </para>
/// <para>
/// This signal will be sent to the grab widget if there is one.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventProximity which triggered
///   this signal.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool proximity_out_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventProximityHandle>))] MentorLake.Gdk.GdkEventProximityHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when #GtkWidget:has-tooltip is %TRUE and the hover timeout
/// has expired with the cursor hovering &quot;above&quot; @widget; or emitted when @widget got
/// focus in keyboard mode.
/// </para>
/// <para>
/// Using the given coordinates, the signal handler should determine
/// whether a tooltip should be shown for @widget. If this is the case
/// %TRUE should be returned, %FALSE otherwise.  Note that if
/// @keyboard_mode is %TRUE, the values of @x and @y are undefined and
/// should not be used.
/// </para>
/// <para>
/// The signal handler is free to manipulate @tooltip with the therefore
/// destined function calls.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="x">
/// the x coordinate of the cursor position where the request has
///     been emitted, relative to @widget&apos;s left side
/// </param>
/// <param name="y">
/// the y coordinate of the cursor position where the request has
///     been emitted, relative to @widget&apos;s top
/// </param>
/// <param name="keyboard_mode">
/// %TRUE if the tooltip was triggered using the keyboard
/// </param>
/// <param name="tooltip">
/// a #GtkTooltip
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if @tooltip should be shown right now, %FALSE otherwise.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool query_tooltip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, int x, int y, bool keyboard_mode, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTooltipHandle>))] MentorLake.Gtk.GtkTooltipHandle tooltip, IntPtr user_data);


/// <summary>
/// <para>
/// The ::realize signal is emitted when @widget is associated with a
/// #GdkWindow, which means that gtk_widget_realize() has been called or the
/// widget has been mapped (that is, it is going to be drawn).
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void realize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::screen-changed signal gets emitted when the
/// screen of a widget has changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="previous_screen">
/// the previous screen, or %NULL if the
///   widget was not associated with a screen before
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void screen_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle previous_screen, IntPtr user_data);


/// <summary>
/// <para>
/// The ::scroll-event signal is emitted when a button in the 4 to 7
/// range is pressed. Wheel mice are usually configured to generate
/// button press events for buttons 4 and 5 when the wheel is turned.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_SCROLL_MASK mask.
/// </para>
/// <para>
/// This signal will be sent to the grab widget if there is one.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventScroll which triggered
///   this signal.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool scroll_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventScrollHandle>))] MentorLake.Gdk.GdkEventScrollHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// The ::selection-clear-event signal will be emitted when the
/// the @widget&apos;s window has lost ownership of a selection.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventSelection which triggered
///   this signal.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool selection_clear_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSelectionHandle>))] MentorLake.Gdk.GdkEventSelectionHandle @event, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="data">
/// </param>
/// <param name="info">
/// </param>
/// <param name="time">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle data, uint info, uint time, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="@event">
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event. %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool selection_notify_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSelectionHandle>))] MentorLake.Gdk.GdkEventSelectionHandle @event, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="data">
/// </param>
/// <param name="time">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_received([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle data, uint time, IntPtr user_data);


/// <summary>
/// <para>
/// The ::selection-request-event signal will be emitted when
/// another client requests ownership of the selection owned by
/// the @widget&apos;s window.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventSelection which triggered
///   this signal.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool selection_request_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSelectionHandle>))] MentorLake.Gdk.GdkEventSelectionHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// The ::show signal is emitted when @widget is shown, for example with
/// gtk_widget_show().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="help_type">
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
/// %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool show_help([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, MentorLake.Gtk.GtkWidgetHelpType help_type, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="allocation">
/// the region which has been
///   allocated to the widget.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void size_allocate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAllocationHandle>))] MentorLake.Gtk.GtkAllocationHandle allocation, IntPtr user_data);


/// <summary>
/// <para>
/// The ::state-changed signal is emitted when the widget state changes.
/// See gtk_widget_get_state().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="state">
/// the previous state
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void state_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, MentorLake.Gtk.GtkStateType state, IntPtr user_data);


/// <summary>
/// <para>
/// The ::state-flags-changed signal is emitted when the widget state
/// changes, see gtk_widget_get_state_flags().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="flags">
/// The previous state flags.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void state_flags_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, MentorLake.Gtk.GtkStateFlags flags, IntPtr user_data);


/// <summary>
/// <para>
/// The ::style-set signal is emitted when a new style has been set
/// on a widget. Note that style-modifying functions like
/// gtk_widget_modify_base() also cause this signal to be emitted.
/// </para>
/// <para>
/// Note that this signal is emitted for changes to the deprecated
/// #GtkStyle. To track changes to the #GtkStyleContext associated
/// with a widget, use the #GtkWidget::style-updated signal.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="previous_style">
/// the previous style, or %NULL if the widget
///   just got its initial style
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void style_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle previous_style, IntPtr user_data);


/// <summary>
/// <para>
/// The ::style-updated signal is a convenience signal that is emitted when the
/// #GtkStyleContext::changed signal is emitted on the @widget&apos;s associated
/// #GtkStyleContext as returned by gtk_widget_get_style_context().
/// </para>
/// <para>
/// Note that style-modifying functions like gtk_widget_override_color() also
/// cause this signal to be emitted.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void style_updated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="@object">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool touch_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @object, IntPtr user_data);


/// <summary>
/// <para>
/// The ::unmap signal is emitted when @widget is going to be unmapped, which
/// means that either it or any of its parents up to the toplevel widget have
/// been set as hidden.
/// </para>
/// <para>
/// As ::unmap indicates that a widget will not be shown any longer, it can be
/// used to, for example, stop an animation on the widget.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unmap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::unmap-event signal will be emitted when the @widget&apos;s window is
/// unmapped. A window is unmapped when it becomes invisible on the screen.
/// </para>
/// <para>
/// To receive this signal, the #GdkWindow associated to the widget needs
/// to enable the #GDK_STRUCTURE_MASK mask. GDK will enable this mask
/// automatically for all new windows.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventAny which triggered this signal
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool unmap_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventAnyHandle>))] MentorLake.Gdk.GdkEventAnyHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// The ::unrealize signal is emitted when the #GdkWindow associated with
/// @widget is destroyed, which means that gtk_widget_unrealize() has been
/// called or the widget has been unmapped (that is, it is going to be
/// hidden).
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unrealize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::visibility-notify-event will be emitted when the @widget&apos;s
/// window is obscured or unobscured.
/// </para>
/// <para>
/// To receive this signal the #GdkWindow associated to the widget needs
/// to enable the #GDK_VISIBILITY_NOTIFY_MASK mask.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventVisibility which
///   triggered this signal.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool visibility_notify_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventVisibilityHandle>))] MentorLake.Gdk.GdkEventVisibilityHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// The ::window-state-event will be emitted when the state of the
/// toplevel window associated to the @widget changes.
/// </para>
/// <para>
/// To receive this signal the #GdkWindow associated to the widget
/// needs to enable the #GDK_STRUCTURE_MASK mask. GDK will enable
/// this mask automatically for all new windows.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventWindowState which
///   triggered this signal.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the
///   event. %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool window_state_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventWindowStateHandle>))] MentorLake.Gdk.GdkEventWindowStateHandle @event, IntPtr user_data);

}


public static class GtkWidgetHandleExtensions
{
/// <summary>
/// <para>
/// For widgets that can be “activated” (buttons, menu items, etc.)
/// this function activates them. Activation is what happens when you
/// press Enter on a widget during key navigation. If @widget isn&apos;t
/// activatable, the function returns %FALSE.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget that’s activatable
/// </param>
/// <return>
/// %TRUE if the widget was activatable
/// </return>

	public static bool Activate(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_activate(widget);
	}

/// <summary>
/// <para>
/// Installs an accelerator for this @widget in @accel_group that causes
/// @accel_signal to be emitted if the accelerator is activated.
/// The @accel_group needs to be added to the widget’s toplevel via
/// gtk_window_add_accel_group(), and the signal must be of type %G_SIGNAL_ACTION.
/// Accelerators added through this function are not user changeable during
/// runtime. If you want to support accelerators that can be changed by the
/// user, use gtk_accel_map_add_entry() and gtk_widget_set_accel_path() or
/// gtk_menu_item_set_accel_path() instead.
/// </para>
/// </summary>

/// <param name="widget">
/// widget to install an accelerator on
/// </param>
/// <param name="accel_signal">
/// widget signal to emit on accelerator activation
/// </param>
/// <param name="accel_group">
/// accel group for this widget, added to its toplevel
/// </param>
/// <param name="accel_key">
/// GDK keyval of the accelerator
/// </param>
/// <param name="accel_mods">
/// modifier key combination of the accelerator
/// </param>
/// <param name="accel_flags">
/// flag accelerators, e.g. %GTK_ACCEL_VISIBLE
/// </param>

	public static T AddAccelerator<T>(this T widget, string accel_signal, MentorLake.Gtk.GtkAccelGroupHandle accel_group, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods, MentorLake.Gtk.GtkAccelFlags accel_flags) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_add_accelerator(widget, accel_signal, accel_group, accel_key, accel_mods, accel_flags);
		return widget;
	}

/// <summary>
/// <para>
/// Adds the device events in the bitfield @events to the event mask for
/// @widget. See gtk_widget_set_device_events() for details.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="device">
/// a #GdkDevice
/// </param>
/// <param name="events">
/// an event mask, see #GdkEventMask
/// </param>

	public static T AddDeviceEvents<T>(this T widget, MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gdk.GdkEventMask events) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_add_device_events(widget, device, events);
		return widget;
	}

/// <summary>
/// <para>
/// Adds the events in the bitfield @events to the event mask for
/// @widget. See gtk_widget_set_events() and the
/// [input handling overview][event-masks] for details.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="events">
/// an event mask, see #GdkEventMask
/// </param>

	public static T AddEvents<T>(this T widget, int events) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_add_events(widget, events);
		return widget;
	}

/// <summary>
/// <para>
/// Adds a widget to the list of mnemonic labels for
/// this widget. (See gtk_widget_list_mnemonic_labels()). Note the
/// list of mnemonic labels for the widget is cleared when the
/// widget is destroyed, so the caller must make sure to update
/// its internal state at this point as well, by using a connection
/// to the #GtkWidget::destroy signal or a weak notifier.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="label">
/// a #GtkWidget that acts as a mnemonic label for @widget
/// </param>

	public static T AddMnemonicLabel<T>(this T widget, MentorLake.Gtk.GtkWidgetHandle label) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_add_mnemonic_label(widget, label);
		return widget;
	}

/// <summary>
/// <para>
/// Queues an animation frame update and adds a callback to be called
/// before each frame. Until the tick callback is removed, it will be
/// called frequently (usually at the frame rate of the output device
/// or as quickly as the application can be repainted, whichever is
/// slower). For this reason, is most suitable for handling graphics
/// that change every frame or every few frames. The tick callback does
/// not automatically imply a relayout or repaint. If you want a
/// repaint or relayout, and aren’t changing widget properties that
/// would trigger that (for example, changing the text of a #GtkLabel),
/// then you will have to call gtk_widget_queue_resize() or
/// gtk_widget_queue_draw_area() yourself.
/// </para>
/// <para>
/// gdk_frame_clock_get_frame_time() should generally be used for timing
/// continuous animations and
/// gdk_frame_timings_get_predicted_presentation_time() if you are
/// trying to display isolated frames at particular times.
/// </para>
/// <para>
/// This is a more convenient alternative to connecting directly to the
/// #GdkFrameClock::update signal of #GdkFrameClock, since you don&apos;t
/// have to worry about when a #GdkFrameClock is assigned to a widget.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="callback">
/// function to call for updating animations
/// </param>
/// <param name="user_data">
/// data to pass to @callback
/// </param>
/// <param name="notify">
/// function to call to free @user_data when the callback is removed.
/// </param>
/// <return>
/// an id for the connection of this callback. Remove the callback
///     by passing it to gtk_widget_remove_tick_callback()
/// </return>

	public static uint AddTickCallback(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkTickCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_add_tick_callback(widget, callback, user_data, notify);
	}

/// <summary>
/// <para>
/// Determines whether an accelerator that activates the signal
/// identified by @signal_id can currently be activated.
/// This is done by emitting the #GtkWidget::can-activate-accel
/// signal on @widget; if the signal isn’t overridden by a
/// handler or in a derived widget, then the default check is
/// that the widget must be sensitive, and the widget and all
/// its ancestors mapped.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="signal_id">
/// the ID of a signal installed on @widget
/// </param>
/// <return>
/// %TRUE if the accelerator can be activated.
/// </return>

	public static bool CanActivateAccel(this MentorLake.Gtk.GtkWidgetHandle widget, uint signal_id)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_can_activate_accel(widget, signal_id);
	}

/// <summary>
/// <para>
/// This function is used by custom widget implementations; if you&apos;re
/// writing an app, you’d use gtk_widget_grab_focus() to move the focus
/// to a particular widget, and gtk_container_set_focus_chain() to
/// change the focus tab order. So you may want to investigate those
/// functions instead.
/// </para>
/// <para>
/// gtk_widget_child_focus() is called by containers as the user moves
/// around the window using keyboard shortcuts. @direction indicates
/// what kind of motion is taking place (up, down, left, right, tab
/// forward, tab backward). gtk_widget_child_focus() emits the
/// #GtkWidget::focus signal; widgets override the default handler
/// for this signal in order to implement appropriate focus behavior.
/// </para>
/// <para>
/// The default ::focus handler for a widget should return %TRUE if
/// moving in @direction left the focus on a focusable location inside
/// that widget, and %FALSE if moving in @direction moved the focus
/// outside the widget. If returning %TRUE, widgets normally
/// call gtk_widget_grab_focus() to place the focus accordingly;
/// if returning %FALSE, they don’t modify the current focus location.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="direction">
/// direction of focus movement
/// </param>
/// <return>
/// %TRUE if focus ended up inside @widget
/// </return>

	public static bool ChildFocus(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkDirectionType direction)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_child_focus(widget, direction);
	}

/// <summary>
/// <para>
/// Emits a #GtkWidget::child-notify signal for the
/// [child property][child-properties] @child_property
/// on @widget.
/// </para>
/// <para>
/// This is the analogue of g_object_notify() for child properties.
/// </para>
/// <para>
/// Also see gtk_container_child_notify().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="child_property">
/// the name of a child property installed on the
///                  class of @widget’s parent
/// </param>

	public static T ChildNotify<T>(this T widget, string child_property) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_child_notify(widget, child_property);
		return widget;
	}

/// <summary>
/// <para>
/// Same as gtk_widget_path(), but always uses the name of a widget’s type,
/// never uses a custom name set with gtk_widget_set_name().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="path_length">
/// location to store the length of the
///     class path, or %NULL
/// </param>
/// <param name="path">
/// location to store the class path as an
///     allocated string, or %NULL
/// </param>
/// <param name="path_reversed">
/// location to store the reverse
///     class path as an allocated string, or %NULL
/// </param>

	public static T ClassPath<T>(this T widget, out uint path_length, out string path, out string path_reversed) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_class_path(widget, out path_length, out path, out path_reversed);
		return widget;
	}

/// <summary>
/// <para>
/// Computes whether a container should give this widget extra space
/// when possible. Containers should check this, rather than
/// looking at gtk_widget_get_hexpand() or gtk_widget_get_vexpand().
/// </para>
/// <para>
/// This function already checks whether the widget is visible, so
/// visibility does not need to be checked separately. Non-visible
/// widgets are not expanded.
/// </para>
/// <para>
/// The computed expand value uses either the expand setting explicitly
/// set on the widget itself, or, if none has been explicitly set,
/// the widget may expand if some of its children do.
/// </para>
/// </summary>

/// <param name="widget">
/// the widget
/// </param>
/// <param name="orientation">
/// expand direction
/// </param>
/// <return>
/// whether widget tree rooted here should be expanded
/// </return>

	public static bool ComputeExpand(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkOrientation orientation)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_compute_expand(widget, orientation);
	}

/// <summary>
/// <para>
/// Creates a new #PangoContext with the appropriate font map,
/// font options, font description, and base direction for drawing
/// text for this widget. See also gtk_widget_get_pango_context().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the new #PangoContext
/// </return>

	public static MentorLake.Pango.PangoContextHandle CreatePangoContext(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_create_pango_context(widget);
	}

/// <summary>
/// <para>
/// Creates a new #PangoLayout with the appropriate font map,
/// font description, and base direction for drawing text for
/// this widget.
/// </para>
/// <para>
/// If you keep a #PangoLayout created in this way around, you need
/// to re-create it when the widget #PangoContext is replaced.
/// This can be tracked by using the #GtkWidget::screen-changed signal
/// on the widget.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="text">
/// text to set on the layout (can be %NULL)
/// </param>
/// <return>
/// the new #PangoLayout
/// </return>

	public static MentorLake.Pango.PangoLayoutHandle CreatePangoLayout(this MentorLake.Gtk.GtkWidgetHandle widget, string text)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_create_pango_layout(widget, text);
	}

/// <summary>
/// <para>
/// Destroys a widget.
/// </para>
/// <para>
/// When a widget is destroyed all references it holds on other objects
/// will be released:
/// </para>
/// <para>
///  - if the widget is inside a container, it will be removed from its
///  parent
///  - if the widget is a container, all its children will be destroyed,
///  recursively
///  - if the widget is a top level, it will be removed from the list
///  of top level widgets that GTK+ maintains internally
/// </para>
/// <para>
/// It&apos;s expected that all references held on the widget will also
/// be released; you should connect to the #GtkWidget::destroy signal
/// if you hold a reference to @widget and you wish to remove it when
/// this function is called. It is not necessary to do so if you are
/// implementing a #GtkContainer, as you&apos;ll be able to use the
/// #GtkContainerClass.remove() virtual function for that.
/// </para>
/// <para>
/// It&apos;s important to notice that gtk_widget_destroy() will only cause
/// the @widget to be finalized if no additional references, acquired
/// using g_object_ref(), are held on it. In case additional references
/// are in place, the @widget will be in an &quot;inert&quot; state after calling
/// this function; @widget will still point to valid memory, allowing you
/// to release the references you hold, but you may not query the widget&apos;s
/// own state.
/// </para>
/// <para>
/// You should typically call this function on top level widgets, and
/// rarely on child widgets.
/// </para>
/// <para>
/// See also: gtk_container_remove()
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T Destroy<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_destroy(widget);
		return widget;
	}

/// <summary>
/// <para>
/// This function sets *@widget_pointer to %NULL if @widget_pointer !=
/// %NULL.  It’s intended to be used as a callback connected to the
/// “destroy” signal of a widget. You connect gtk_widget_destroyed()
/// as a signal handler, and pass the address of your widget variable
/// as user data. Then when the widget is destroyed, the variable will
/// be set to %NULL. Useful for example to avoid multiple copies
/// of the same dialog.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="widget_pointer">
/// address of a variable that contains @widget
/// </param>

	public static T Destroyed<T>(this T widget, ref MentorLake.Gtk.GtkWidgetHandle widget_pointer) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_destroyed(widget, ref widget_pointer);
		return widget;
	}

/// <summary>
/// <para>
/// Returns %TRUE if @device has been shadowed by a GTK+
/// device grab on another widget, so it would stop sending
/// events to @widget. This may be used in the
/// #GtkWidget::grab-notify signal to check for specific
/// devices. See gtk_device_grab_add().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="device">
/// a #GdkDevice
/// </param>
/// <return>
/// %TRUE if there is an ongoing grab on @device
///          by another #GtkWidget than @widget.
/// </return>

	public static bool DeviceIsShadowed(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_device_is_shadowed(widget, device);
	}

/// <summary>
/// <para>
/// This function is equivalent to gtk_drag_begin_with_coordinates(),
/// passing -1, -1 as coordinates.
/// </para>
/// </summary>

/// <param name="widget">
/// the source widget
/// </param>
/// <param name="targets">
/// The targets (data formats) in which the
///    source can provide the data
/// </param>
/// <param name="actions">
/// A bitmask of the allowed drag actions for this drag
/// </param>
/// <param name="button">
/// The button the user clicked to start the drag
/// </param>
/// <param name="@event">
/// The event that triggered the start of the drag,
///    or %NULL if none can be obtained.
/// </param>
/// <return>
/// the context for this drag
/// </return>

	public static MentorLake.Gdk.GdkDragContextHandle DragBegin(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkTargetListHandle targets, MentorLake.Gdk.GdkDragAction actions, int button, MentorLake.Gdk.GdkEventHandle @event)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_drag_begin(widget, targets, actions, button, @event);
	}

/// <summary>
/// <para>
/// Initiates a drag on the source side. The function only needs to be used
/// when the application is starting drags itself, and is not needed when
/// gtk_drag_source_set() is used.
/// </para>
/// <para>
/// The @event is used to retrieve the timestamp that will be used internally to
/// grab the pointer.  If @event is %NULL, then %GDK_CURRENT_TIME will be used.
/// However, you should try to pass a real event in all cases, since that can be
/// used to get information about the drag.
/// </para>
/// <para>
/// Generally there are three cases when you want to start a drag by hand by
/// calling this function:
/// </para>
/// <para>
/// 1. During a #GtkWidget::button-press-event handler, if you want to start a drag
/// immediately when the user presses the mouse button.  Pass the @event
/// that you have in your #GtkWidget::button-press-event handler.
/// </para>
/// <para>
/// 2. During a #GtkWidget::motion-notify-event handler, if you want to start a drag
/// when the mouse moves past a certain threshold distance after a button-press.
/// Pass the @event that you have in your #GtkWidget::motion-notify-event handler.
/// </para>
/// <para>
/// 3. During a timeout handler, if you want to start a drag after the mouse
/// button is held down for some time.  Try to save the last event that you got
/// from the mouse, using gdk_event_copy(), and pass it to this function
/// (remember to free the event with gdk_event_free() when you are done).
/// If you really cannot pass a real event, pass %NULL instead.
/// </para>
/// </summary>

/// <param name="widget">
/// the source widget
/// </param>
/// <param name="targets">
/// The targets (data formats) in which the
///    source can provide the data
/// </param>
/// <param name="actions">
/// A bitmask of the allowed drag actions for this drag
/// </param>
/// <param name="button">
/// The button the user clicked to start the drag
/// </param>
/// <param name="@event">
/// The event that triggered the start of the drag,
///    or %NULL if none can be obtained.
/// </param>
/// <param name="x">
/// The initial x coordinate to start dragging from, in the coordinate space
///    of @widget. If -1 is passed, the coordinates are retrieved from @event or
///    the current pointer position
/// </param>
/// <param name="y">
/// The initial y coordinate to start dragging from, in the coordinate space
///    of @widget. If -1 is passed, the coordinates are retrieved from @event or
///    the current pointer position
/// </param>
/// <return>
/// the context for this drag
/// </return>

	public static MentorLake.Gdk.GdkDragContextHandle DragBeginWithCoordinates(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkTargetListHandle targets, MentorLake.Gdk.GdkDragAction actions, int button, MentorLake.Gdk.GdkEventHandle @event, int x, int y)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_drag_begin_with_coordinates(widget, targets, actions, button, @event, x, y);
	}

/// <summary>
/// <para>
/// Checks to see if a mouse drag starting at (@start_x, @start_y) and ending
/// at (@current_x, @current_y) has passed the GTK+ drag threshold, and thus
/// should trigger the beginning of a drag-and-drop operation.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="start_x">
/// X coordinate of start of drag
/// </param>
/// <param name="start_y">
/// Y coordinate of start of drag
/// </param>
/// <param name="current_x">
/// current X coordinate
/// </param>
/// <param name="current_y">
/// current Y coordinate
/// </param>
/// <return>
/// %TRUE if the drag threshold has been passed.
/// </return>

	public static bool DragCheckThreshold(this MentorLake.Gtk.GtkWidgetHandle widget, int start_x, int start_y, int current_x, int current_y)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_drag_check_threshold(widget, start_x, start_y, current_x, current_y);
	}

/// <summary>
/// <para>
/// Add the image targets supported by #GtkSelectionData to
/// the target list of the drag destination. The targets
/// are added with @info = 0. If you need another value,
/// use gtk_target_list_add_image_targets() and
/// gtk_drag_dest_set_target_list().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget that’s a drag destination
/// </param>

	public static T DragDestAddImageTargets<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_dest_add_image_targets(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Add the text targets supported by #GtkSelectionData to
/// the target list of the drag destination. The targets
/// are added with @info = 0. If you need another value,
/// use gtk_target_list_add_text_targets() and
/// gtk_drag_dest_set_target_list().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget that’s a drag destination
/// </param>

	public static T DragDestAddTextTargets<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_dest_add_text_targets(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Add the URI targets supported by #GtkSelectionData to
/// the target list of the drag destination. The targets
/// are added with @info = 0. If you need another value,
/// use gtk_target_list_add_uri_targets() and
/// gtk_drag_dest_set_target_list().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget that’s a drag destination
/// </param>

	public static T DragDestAddUriTargets<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_dest_add_uri_targets(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Looks for a match between the supported targets of @context and the
/// @dest_target_list, returning the first matching target, otherwise
/// returning %GDK_NONE. @dest_target_list should usually be the return
/// value from gtk_drag_dest_get_target_list(), but some widgets may
/// have different valid targets for different parts of the widget; in
/// that case, they will have to implement a drag_motion handler that
/// passes the correct target list to this function.
/// </para>
/// </summary>

/// <param name="widget">
/// drag destination widget
/// </param>
/// <param name="context">
/// drag context
/// </param>
/// <param name="target_list">
/// list of droppable targets, or %NULL to use
///    gtk_drag_dest_get_target_list (@widget).
/// </param>
/// <return>
/// first target that the source offers
///     and the dest can accept, or %GDK_NONE
/// </return>

	public static MentorLake.Gdk.GdkAtom DragDestFindTarget(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkDragContextHandle context, MentorLake.Gtk.GtkTargetListHandle target_list)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_drag_dest_find_target(widget, context, target_list);
	}

/// <summary>
/// <para>
/// Returns the list of targets this widget can accept from
/// drag-and-drop.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the #GtkTargetList, or %NULL if none
/// </return>

	public static MentorLake.Gtk.GtkTargetListHandle DragDestGetTargetList(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_drag_dest_get_target_list(widget);
	}

/// <summary>
/// <para>
/// Returns whether the widget has been configured to always
/// emit #GtkWidget::drag-motion signals.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget that’s a drag destination
/// </param>
/// <return>
/// %TRUE if the widget always emits
///   #GtkWidget::drag-motion events
/// </return>

	public static bool DragDestGetTrackMotion(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_drag_dest_get_track_motion(widget);
	}

/// <summary>
/// <para>
/// Sets a widget as a potential drop destination, and adds default behaviors.
/// </para>
/// <para>
/// The default behaviors listed in @flags have an effect similar
/// to installing default handlers for the widget’s drag-and-drop signals
/// (#GtkWidget::drag-motion, #GtkWidget::drag-drop, ...). They all exist
/// for convenience. When passing #GTK_DEST_DEFAULT_ALL for instance it is
/// sufficient to connect to the widget’s #GtkWidget::drag-data-received
/// signal to get primitive, but consistent drag-and-drop support.
/// </para>
/// <para>
/// Things become more complicated when you try to preview the dragged data,
/// as described in the documentation for #GtkWidget::drag-motion. The default
/// behaviors described by @flags make some assumptions, that can conflict
/// with your own signal handlers. For instance #GTK_DEST_DEFAULT_DROP causes
/// invokations of gdk_drag_status() in the context of #GtkWidget::drag-motion,
/// and invokations of gtk_drag_finish() in #GtkWidget::drag-data-received.
/// Especially the later is dramatic, when your own #GtkWidget::drag-motion
/// handler calls gtk_drag_get_data() to inspect the dragged data.
/// </para>
/// <para>
/// There’s no way to set a default action here, you can use the
/// #GtkWidget::drag-motion callback for that. Here’s an example which selects
/// the action to use depending on whether the control key is pressed or not:
/// <code>
/// static void
/// static void
/// drag_motion (GtkWidget *widget,
///              GdkDragContext *context,
///              gint x,
///              gint y,
///              guint time)
/// {
///   GdkModifierType mask;
/// 
///   gdk_window_get_pointer (gtk_widget_get_window (widget),
///                           NULL, NULL, &amp;mask);
///   if (mask &amp; GDK_CONTROL_MASK)
///     gdk_drag_status (context, GDK_ACTION_COPY, time);
///   else
///     gdk_drag_status (context, GDK_ACTION_MOVE, time);
/// }
/// </code>
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="flags">
/// which types of default drag behavior to use
/// </param>
/// <param name="targets">
/// a pointer to an array of
///     #GtkTargetEntrys indicating the drop types that this @widget will
///     accept, or %NULL. Later you can access the list with
///     gtk_drag_dest_get_target_list() and gtk_drag_dest_find_target().
/// </param>
/// <param name="n_targets">
/// the number of entries in @targets
/// </param>
/// <param name="actions">
/// a bitmask of possible actions for a drop onto this @widget.
/// </param>

	public static T DragDestSet<T>(this T widget, MentorLake.Gtk.GtkDestDefaults flags, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets, MentorLake.Gdk.GdkDragAction actions) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_dest_set(widget, flags, targets, n_targets, actions);
		return widget;
	}

/// <summary>
/// <para>
/// Sets this widget as a proxy for drops to another window.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="proxy_window">
/// the window to which to forward drag events
/// </param>
/// <param name="protocol">
/// the drag protocol which the @proxy_window accepts
///   (You can use gdk_drag_get_protocol() to determine this)
/// </param>
/// <param name="use_coordinates">
/// If %TRUE, send the same coordinates to the
///   destination, because it is an embedded
///   subwindow.
/// </param>

	public static T DragDestSetProxy<T>(this T widget, MentorLake.Gdk.GdkWindowHandle proxy_window, MentorLake.Gdk.GdkDragProtocol protocol, bool use_coordinates) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_dest_set_proxy(widget, proxy_window, protocol, use_coordinates);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the target types that this widget can accept from drag-and-drop.
/// The widget must first be made into a drag destination with
/// gtk_drag_dest_set().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget that’s a drag destination
/// </param>
/// <param name="target_list">
/// list of droppable targets, or %NULL for none
/// </param>

	public static T DragDestSetTargetList<T>(this T widget, MentorLake.Gtk.GtkTargetListHandle target_list) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_dest_set_target_list(widget, target_list);
		return widget;
	}

/// <summary>
/// <para>
/// Tells the widget to emit #GtkWidget::drag-motion and
/// #GtkWidget::drag-leave events regardless of the targets and the
/// %GTK_DEST_DEFAULT_MOTION flag.
/// </para>
/// <para>
/// This may be used when a widget wants to do generic
/// actions regardless of the targets that the source offers.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget that’s a drag destination
/// </param>
/// <param name="track_motion">
/// whether to accept all targets
/// </param>

	public static T DragDestSetTrackMotion<T>(this T widget, bool track_motion) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_dest_set_track_motion(widget, track_motion);
		return widget;
	}

/// <summary>
/// <para>
/// Clears information about a drop destination set with
/// gtk_drag_dest_set(). The widget will no longer receive
/// notification of drags.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T DragDestUnset<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_dest_unset(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Gets the data associated with a drag. When the data
/// is received or the retrieval fails, GTK+ will emit a
/// #GtkWidget::drag-data-received signal. Failure of the retrieval
/// is indicated by the length field of the @selection_data
/// signal parameter being negative. However, when gtk_drag_get_data()
/// is called implicitely because the %GTK_DEST_DEFAULT_DROP was set,
/// then the widget will not receive notification of failed
/// drops.
/// </para>
/// </summary>

/// <param name="widget">
/// the widget that will receive the
///   #GtkWidget::drag-data-received signal
/// </param>
/// <param name="context">
/// the drag context
/// </param>
/// <param name="target">
/// the target (form of the data) to retrieve
/// </param>
/// <param name="time_">
/// a timestamp for retrieving the data. This will
///   generally be the time received in a #GtkWidget::drag-motion
///   or #GtkWidget::drag-drop signal
/// </param>

	public static T DragGetData<T>(this T widget, MentorLake.Gdk.GdkDragContextHandle context, MentorLake.Gdk.GdkAtom target, uint time_) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_get_data(widget, context, target, time_);
		return widget;
	}

/// <summary>
/// <para>
/// Highlights a widget as a currently hovered drop target.
/// To end the highlight, call gtk_drag_unhighlight().
/// GTK+ calls this automatically if %GTK_DEST_DEFAULT_HIGHLIGHT is set.
/// </para>
/// </summary>

/// <param name="widget">
/// a widget to highlight
/// </param>

	public static T DragHighlight<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_highlight(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Add the writable image targets supported by #GtkSelectionData to
/// the target list of the drag source. The targets
/// are added with @info = 0. If you need another value,
/// use gtk_target_list_add_image_targets() and
/// gtk_drag_source_set_target_list().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget that’s is a drag source
/// </param>

	public static T DragSourceAddImageTargets<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_source_add_image_targets(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Add the text targets supported by #GtkSelectionData to
/// the target list of the drag source.  The targets
/// are added with @info = 0. If you need another value,
/// use gtk_target_list_add_text_targets() and
/// gtk_drag_source_set_target_list().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget that’s is a drag source
/// </param>

	public static T DragSourceAddTextTargets<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_source_add_text_targets(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Add the URI targets supported by #GtkSelectionData to
/// the target list of the drag source.  The targets
/// are added with @info = 0. If you need another value,
/// use gtk_target_list_add_uri_targets() and
/// gtk_drag_source_set_target_list().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget that’s is a drag source
/// </param>

	public static T DragSourceAddUriTargets<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_source_add_uri_targets(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Gets the list of targets this widget can provide for
/// drag-and-drop.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the #GtkTargetList, or %NULL if none
/// </return>

	public static MentorLake.Gtk.GtkTargetListHandle DragSourceGetTargetList(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_drag_source_get_target_list(widget);
	}

/// <summary>
/// <para>
/// Sets up a widget so that GTK+ will start a drag operation when the user
/// clicks and drags on the widget. The widget must have a window.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="start_button_mask">
/// the bitmask of buttons that can start the drag
/// </param>
/// <param name="targets">
/// the table of targets
///     that the drag will support, may be %NULL
/// </param>
/// <param name="n_targets">
/// the number of items in @targets
/// </param>
/// <param name="actions">
/// the bitmask of possible actions for a drag from this widget
/// </param>

	public static T DragSourceSet<T>(this T widget, MentorLake.Gdk.GdkModifierType start_button_mask, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets, MentorLake.Gdk.GdkDragAction actions) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_source_set(widget, start_button_mask, targets, n_targets, actions);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the icon that will be used for drags from a particular source
/// to @icon. See the docs for #GtkIconTheme for more details.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="icon">
/// A #GIcon
/// </param>

	public static T DragSourceSetIconGicon<T>(this T widget, MentorLake.Gio.GIconHandle icon) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_source_set_icon_gicon(widget, icon);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the icon that will be used for drags from a particular source
/// to a themed icon. See the docs for #GtkIconTheme for more details.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="icon_name">
/// name of icon to use
/// </param>

	public static T DragSourceSetIconName<T>(this T widget, string icon_name) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_source_set_icon_name(widget, icon_name);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the icon that will be used for drags from a particular widget
/// from a #GdkPixbuf. GTK+ retains a reference for @pixbuf and will
/// release it when it is no longer needed.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="pixbuf">
/// the #GdkPixbuf for the drag icon
/// </param>

	public static T DragSourceSetIconPixbuf<T>(this T widget, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_source_set_icon_pixbuf(widget, pixbuf);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the icon that will be used for drags from a particular source
/// to a stock icon.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="stock_id">
/// the ID of the stock icon to use
/// </param>

	public static T DragSourceSetIconStock<T>(this T widget, string stock_id) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_source_set_icon_stock(widget, stock_id);
		return widget;
	}

/// <summary>
/// <para>
/// Changes the target types that this widget offers for drag-and-drop.
/// The widget must first be made into a drag source with
/// gtk_drag_source_set().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget that’s a drag source
/// </param>
/// <param name="target_list">
/// list of draggable targets, or %NULL for none
/// </param>

	public static T DragSourceSetTargetList<T>(this T widget, MentorLake.Gtk.GtkTargetListHandle target_list) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_source_set_target_list(widget, target_list);
		return widget;
	}

/// <summary>
/// <para>
/// Undoes the effects of gtk_drag_source_set().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T DragSourceUnset<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_source_unset(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Removes a highlight set by gtk_drag_highlight() from
/// a widget.
/// </para>
/// </summary>

/// <param name="widget">
/// a widget to remove the highlight from
/// </param>

	public static T DragUnhighlight<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_unhighlight(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Draws @widget to @cr. The top left corner of the widget will be
/// drawn to the currently set origin point of @cr.
/// </para>
/// <para>
/// You should pass a cairo context as @cr argument that is in an
/// original state. Otherwise the resulting drawing is undefined. For
/// example changing the operator using cairo_set_operator() or the
/// line width using cairo_set_line_width() might have unwanted side
/// effects.
/// You may however change the context’s transform matrix - like with
/// cairo_scale(), cairo_translate() or cairo_set_matrix() and clip
/// region with cairo_clip() prior to calling this function. Also, it
/// is fine to modify the context with cairo_save() and
/// cairo_push_group() prior to calling this function.
/// </para>
/// <para>
/// Note that special-purpose widgets may contain special code for
/// rendering to the screen and might appear differently on screen
/// and when rendered using gtk_widget_draw().
/// </para>
/// </summary>

/// <param name="widget">
/// the widget to draw. It must be drawable (see
///   gtk_widget_is_drawable()) and a size must have been allocated.
/// </param>
/// <param name="cr">
/// a cairo context to draw to
/// </param>

	public static T Draw<T>(this T widget, MentorLake.cairo.cairo_tHandle cr) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_draw(widget, cr);
		return widget;
	}

/// <summary>
/// <para>
/// Ensures that @widget has a style (@widget-&amp;gt;style).
/// </para>
/// <para>
/// Not a very useful function; most of the time, if you
/// want the style, the widget is realized, and realized
/// widgets are guaranteed to have a style already.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T EnsureStyle<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_ensure_style(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Notifies the user about an input-related error on this widget.
/// If the #GtkSettings:gtk-error-bell setting is %TRUE, it calls
/// gdk_window_beep(), otherwise it does nothing.
/// </para>
/// <para>
/// Note that the effect of gdk_window_beep() can be configured in many
/// ways, depending on the windowing backend and the desktop environment
/// or window manager that is used.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T ErrorBell<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_error_bell(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Rarely-used function. This function is used to emit
/// the event signals on a widget (those signals should never
/// be emitted without using this function to do so).
/// If you want to synthesize an event though, don’t use this function;
/// instead, use gtk_main_do_event() so the event will behave as if
/// it were in the event queue. Don’t synthesize expose events; instead,
/// use gdk_window_invalidate_rect() to invalidate a region of the
/// window.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <return>
/// return from the event signal emission (%TRUE if
///               the event was handled)
/// </return>

	public static bool Event(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkEventHandle @event)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_event(widget, @event);
	}

/// <summary>
/// <para>
/// Stops emission of #GtkWidget::child-notify signals on @widget. The
/// signals are queued until gtk_widget_thaw_child_notify() is called
/// on @widget.
/// </para>
/// <para>
/// This is the analogue of g_object_freeze_notify() for child properties.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T FreezeChildNotify<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_freeze_child_notify(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Returns the accessible object that describes the widget to an
/// assistive technology.
/// </para>
/// <para>
/// If accessibility support is not available, this #AtkObject
/// instance may be a no-op. Likewise, if no class-specific #AtkObject
/// implementation is available for the widget instance in question,
/// it will inherit an #AtkObject implementation from the first ancestor
/// class for which such an implementation is defined.
/// </para>
/// <para>
/// The documentation of the
/// [ATK](http://developer.gnome.org/atk/stable/)
/// library contains more information about accessible objects and their uses.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the #AtkObject associated with @widget
/// </return>

	public static MentorLake.Atk.AtkObjectHandle GetAccessible(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_accessible(widget);
	}

/// <summary>
/// <para>
/// Retrieves the #GActionGroup that was registered using @prefix. The resulting
/// #GActionGroup may have been registered to @widget or any #GtkWidget in its
/// ancestry.
/// </para>
/// <para>
/// If no action group was found matching @prefix, then %NULL is returned.
/// </para>
/// </summary>

/// <param name="widget">
/// A #GtkWidget
/// </param>
/// <param name="prefix">
/// The “prefix” of the action group.
/// </param>
/// <return>
/// A #GActionGroup or %NULL.
/// </return>

	public static MentorLake.Gio.GActionGroupHandle GetActionGroup(this MentorLake.Gtk.GtkWidgetHandle widget, string prefix)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_action_group(widget, prefix);
	}

/// <summary>
/// <para>
/// Returns the baseline that has currently been allocated to @widget.
/// This function is intended to be used when implementing handlers
/// for the #GtkWidget::draw function, and when allocating child
/// widgets in #GtkWidget::size_allocate.
/// </para>
/// </summary>

/// <param name="widget">
/// the widget to query
/// </param>
/// <return>
/// the baseline of the @widget, or -1 if none
/// </return>

	public static int GetAllocatedBaseline(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_allocated_baseline(widget);
	}

/// <summary>
/// <para>
/// Returns the height that has currently been allocated to @widget.
/// This function is intended to be used when implementing handlers
/// for the #GtkWidget::draw function.
/// </para>
/// </summary>

/// <param name="widget">
/// the widget to query
/// </param>
/// <return>
/// the height of the @widget
/// </return>

	public static int GetAllocatedHeight(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_allocated_height(widget);
	}

/// <summary>
/// <para>
/// Retrieves the widget’s allocated size.
/// </para>
/// <para>
/// This function returns the last values passed to
/// gtk_widget_size_allocate_with_baseline(). The value differs from
/// the size returned in gtk_widget_get_allocation() in that functions
/// like gtk_widget_set_halign() can adjust the allocation, but not
/// the value returned by this function.
/// </para>
/// <para>
/// If a widget is not visible, its allocated size is 0.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="allocation">
/// a pointer to a #GtkAllocation to copy to
/// </param>
/// <param name="baseline">
/// a pointer to an integer to copy to
/// </param>

	public static T GetAllocatedSize<T>(this T widget, out MentorLake.Gtk.GtkAllocation allocation, out int baseline) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_allocated_size(widget, out allocation, out baseline);
		return widget;
	}

/// <summary>
/// <para>
/// Returns the width that has currently been allocated to @widget.
/// This function is intended to be used when implementing handlers
/// for the #GtkWidget::draw function.
/// </para>
/// </summary>

/// <param name="widget">
/// the widget to query
/// </param>
/// <return>
/// the width of the @widget
/// </return>

	public static int GetAllocatedWidth(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_allocated_width(widget);
	}

/// <summary>
/// <para>
/// Retrieves the widget’s allocation.
/// </para>
/// <para>
/// Note, when implementing a #GtkContainer: a widget’s allocation will
/// be its “adjusted” allocation, that is, the widget’s parent
/// container typically calls gtk_widget_size_allocate() with an
/// allocation, and that allocation is then adjusted (to handle margin
/// and alignment for example) before assignment to the widget.
/// gtk_widget_get_allocation() returns the adjusted allocation that
/// was actually assigned to the widget. The adjusted allocation is
/// guaranteed to be completely contained within the
/// gtk_widget_size_allocate() allocation, however. So a #GtkContainer
/// is guaranteed that its children stay inside the assigned bounds,
/// but not that they have exactly the bounds the container assigned.
/// There is no way to get the original allocation assigned by
/// gtk_widget_size_allocate(), since it isn’t stored; if a container
/// implementation needs that information it will have to track it itself.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="allocation">
/// a pointer to a #GtkAllocation to copy to
/// </param>

	public static T GetAllocation<T>(this T widget, out MentorLake.Gtk.GtkAllocation allocation) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_allocation(widget, out allocation);
		return widget;
	}

/// <summary>
/// <para>
/// Gets the first ancestor of @widget with type @widget_type. For example,
/// `gtk_widget_get_ancestor (widget, GTK_TYPE_BOX)` gets
/// the first #GtkBox that’s an ancestor of @widget. No reference will be
/// added to the returned widget; it should not be unreferenced. See note
/// about checking for a toplevel #GtkWindow in the docs for
/// gtk_widget_get_toplevel().
/// </para>
/// <para>
/// Note that unlike gtk_widget_is_ancestor(), gtk_widget_get_ancestor()
/// considers @widget to be an ancestor of itself.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="widget_type">
/// ancestor type
/// </param>
/// <return>
/// the ancestor widget, or %NULL if not found
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetAncestor(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.GObject.GType widget_type)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_ancestor(widget, widget_type);
	}

/// <summary>
/// <para>
/// Determines whether the application intends to draw on the widget in
/// an #GtkWidget::draw handler.
/// </para>
/// <para>
/// See gtk_widget_set_app_paintable()
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if the widget is app paintable
/// </return>

	public static bool GetAppPaintable(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_app_paintable(widget);
	}

/// <summary>
/// <para>
/// Determines whether @widget can be a default widget. See
/// gtk_widget_set_can_default().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if @widget can be a default widget, %FALSE otherwise
/// </return>

	public static bool GetCanDefault(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_can_default(widget);
	}

/// <summary>
/// <para>
/// Determines whether @widget can own the input focus. See
/// gtk_widget_set_can_focus().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if @widget can own the input focus, %FALSE otherwise
/// </return>

	public static bool GetCanFocus(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_can_focus(widget);
	}

/// <summary>
/// <para>
/// This function is only for use in widget implementations. Obtains
/// @widget-&amp;gt;requisition, unless someone has forced a particular
/// geometry on the widget (e.g. with gtk_widget_set_size_request()),
/// in which case it returns that geometry instead of the widget&apos;s
/// requisition.
/// </para>
/// <para>
/// This function differs from gtk_widget_size_request() in that
/// it retrieves the last size request value from @widget-&amp;gt;requisition,
/// while gtk_widget_size_request() actually calls the &quot;size_request&quot; method
/// on @widget to compute the size request and fill in @widget-&amp;gt;requisition,
/// and only then returns @widget-&amp;gt;requisition.
/// </para>
/// <para>
/// Because this function does not call the “size_request” method, it
/// can only be used when you know that @widget-&amp;gt;requisition is
/// up-to-date, that is, gtk_widget_size_request() has been called
/// since the last time a resize was queued. In general, only container
/// implementations have this information; applications should use
/// gtk_widget_size_request().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="requisition">
/// a #GtkRequisition to be filled in
/// </param>

	public static T GetChildRequisition<T>(this T widget, out MentorLake.Gtk.GtkRequisition requisition) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_child_requisition(widget, out requisition);
		return widget;
	}

/// <summary>
/// <para>
/// Gets the value set with gtk_widget_set_child_visible().
/// If you feel a need to use this function, your code probably
/// needs reorganization.
/// </para>
/// <para>
/// This function is only useful for container implementations and
/// never should be called by an application.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if the widget is mapped with the parent.
/// </return>

	public static bool GetChildVisible(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_child_visible(widget);
	}

/// <summary>
/// <para>
/// Retrieves the widget’s clip area.
/// </para>
/// <para>
/// The clip area is the area in which all of @widget&apos;s drawing will
/// happen. Other toolkits call it the bounding box.
/// </para>
/// <para>
/// Historically, in GTK+ the clip area has been equal to the allocation
/// retrieved via gtk_widget_get_allocation().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="clip">
/// a pointer to a #GtkAllocation to copy to
/// </param>

	public static T GetClip<T>(this T widget, out MentorLake.Gtk.GtkAllocation clip) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_clip(widget, out clip);
		return widget;
	}

/// <summary>
/// <para>
/// Returns the clipboard object for the given selection to
/// be used with @widget. @widget must have a #GdkDisplay
/// associated with it, so must be attached to a toplevel
/// window.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="selection">
/// a #GdkAtom which identifies the clipboard
///             to use. %GDK_SELECTION_CLIPBOARD gives the
///             default clipboard. Another common value
///             is %GDK_SELECTION_PRIMARY, which gives
///             the primary X selection.
/// </param>
/// <return>
/// the appropriate clipboard object. If no
///             clipboard already exists, a new one will
///             be created. Once a clipboard object has
///             been created, it is persistent for all time.
/// </return>

	public static MentorLake.Gtk.GtkClipboardHandle GetClipboard(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkAtom selection)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_clipboard(widget, selection);
	}

/// <summary>
/// <para>
/// Obtains the composite name of a widget.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the composite name of @widget, or %NULL if @widget is not
///   a composite child. The string should be freed when it is no
///   longer needed.
/// </return>

	public static string GetCompositeName(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_composite_name(widget);
	}

/// <summary>
/// <para>
/// Returns whether @device can interact with @widget and its
/// children. See gtk_widget_set_device_enabled().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="device">
/// a #GdkDevice
/// </param>
/// <return>
/// %TRUE is @device is enabled for @widget
/// </return>

	public static bool GetDeviceEnabled(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_device_enabled(widget, device);
	}

/// <summary>
/// <para>
/// Returns the events mask for the widget corresponding to an specific device. These
/// are the events that the widget will receive when @device operates on it.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="device">
/// a #GdkDevice
/// </param>
/// <return>
/// device event mask for @widget
/// </return>

	public static MentorLake.Gdk.GdkEventMask GetDeviceEvents(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_device_events(widget, device);
	}

/// <summary>
/// <para>
/// Gets the reading direction for a particular widget. See
/// gtk_widget_set_direction().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the reading direction for the widget.
/// </return>

	public static MentorLake.Gtk.GtkTextDirection GetDirection(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_direction(widget);
	}

/// <summary>
/// <para>
/// Get the #GdkDisplay for the toplevel window associated with
/// this widget. This function can only be called after the widget
/// has been added to a widget hierarchy with a #GtkWindow at the top.
/// </para>
/// <para>
/// In general, you should only create display specific
/// resources when a widget has been realized, and you should
/// free those resources when the widget is unrealized.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the #GdkDisplay for the toplevel for this widget.
/// </return>

	public static MentorLake.Gdk.GdkDisplayHandle GetDisplay(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_display(widget);
	}

/// <summary>
/// <para>
/// Determines whether the widget is double buffered.
/// </para>
/// <para>
/// See gtk_widget_set_double_buffered()
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if the widget is double buffered
/// </return>

	public static bool GetDoubleBuffered(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_double_buffered(widget);
	}

/// <summary>
/// <para>
/// Returns the event mask (see #GdkEventMask) for the widget. These are the
/// events that the widget will receive.
/// </para>
/// <para>
/// Note: Internally, the widget event mask will be the logical OR of the event
/// mask set through gtk_widget_set_events() or gtk_widget_add_events(), and the
/// event mask necessary to cater for every #GtkEventController created for the
/// widget.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// event mask for @widget
/// </return>

	public static int GetEvents(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_events(widget);
	}

/// <summary>
/// <para>
/// Returns whether the widget should grab focus when it is clicked with the mouse.
/// See gtk_widget_set_focus_on_click().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if the widget should grab focus when it is clicked with
///               the mouse.
/// </return>

	public static bool GetFocusOnClick(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_focus_on_click(widget);
	}

/// <summary>
/// <para>
/// Gets the font map that has been set with gtk_widget_set_font_map().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// A #PangoFontMap, or %NULL
/// </return>

	public static MentorLake.Pango.PangoFontMapHandle GetFontMap(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_font_map(widget);
	}

/// <summary>
/// <para>
/// Returns the #cairo_font_options_t used for Pango rendering. When not set,
/// the defaults font options for the #GdkScreen will be used.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the #cairo_font_options_t or %NULL if not set
/// </return>

	public static MentorLake.cairo.cairo_font_options_tHandle GetFontOptions(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_font_options(widget);
	}

/// <summary>
/// <para>
/// Obtains the frame clock for a widget. The frame clock is a global
/// “ticker” that can be used to drive animations and repaints.  The
/// most common reason to get the frame clock is to call
/// gdk_frame_clock_get_frame_time(), in order to get a time to use for
/// animating. For example you might record the start of the animation
/// with an initial value from gdk_frame_clock_get_frame_time(), and
/// then update the animation by calling
/// gdk_frame_clock_get_frame_time() again during each repaint.
/// </para>
/// <para>
/// gdk_frame_clock_request_phase() will result in a new frame on the
/// clock, but won’t necessarily repaint any widgets. To repaint a
/// widget, you have to use gtk_widget_queue_draw() which invalidates
/// the widget (thus scheduling it to receive a draw on the next
/// frame). gtk_widget_queue_draw() will also end up requesting a frame
/// on the appropriate frame clock.
/// </para>
/// <para>
/// A widget’s frame clock will not change while the widget is
/// mapped. Reparenting a widget (which implies a temporary unmap) can
/// change the widget’s frame clock.
/// </para>
/// <para>
/// Unrealized widgets do not have a frame clock.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// a #GdkFrameClock,
/// or %NULL if widget is unrealized
/// </return>

	public static MentorLake.Gdk.GdkFrameClockHandle GetFrameClock(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_frame_clock(widget);
	}

/// <summary>
/// <para>
/// Gets the value of the #GtkWidget:halign property.
/// </para>
/// <para>
/// For backwards compatibility reasons this method will never return
/// %GTK_ALIGN_BASELINE, but instead it will convert it to
/// %GTK_ALIGN_FILL. Baselines are not supported for horizontal
/// alignment.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the horizontal alignment of @widget
/// </return>

	public static MentorLake.Gtk.GtkAlign GetHalign(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_halign(widget);
	}

/// <summary>
/// <para>
/// Returns the current value of the has-tooltip property.  See
/// #GtkWidget:has-tooltip for more information.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// current value of has-tooltip on @widget.
/// </return>

	public static bool GetHasTooltip(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_has_tooltip(widget);
	}

/// <summary>
/// <para>
/// Determines whether @widget has a #GdkWindow of its own. See
/// gtk_widget_set_has_window().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if @widget has a window, %FALSE otherwise
/// </return>

	public static bool GetHasWindow(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_has_window(widget);
	}

/// <summary>
/// <para>
/// Gets whether the widget would like any available extra horizontal
/// space. When a user resizes a #GtkWindow, widgets with expand=TRUE
/// generally receive the extra space. For example, a list or
/// scrollable area or document in your window would often be set to
/// expand.
/// </para>
/// <para>
/// Containers should use gtk_widget_compute_expand() rather than
/// this function, to see whether a widget, or any of its children,
/// has the expand flag set. If any child of a widget wants to
/// expand, the parent may ask to expand also.
/// </para>
/// <para>
/// This function only looks at the widget’s own hexpand flag, rather
/// than computing whether the entire widget tree rooted at this widget
/// wants to expand.
/// </para>
/// </summary>

/// <param name="widget">
/// the widget
/// </param>
/// <return>
/// whether hexpand flag is set
/// </return>

	public static bool GetHexpand(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_hexpand(widget);
	}

/// <summary>
/// <para>
/// Gets whether gtk_widget_set_hexpand() has been used to
/// explicitly set the expand flag on this widget.
/// </para>
/// <para>
/// If hexpand is set, then it overrides any computed
/// expand value based on child widgets. If hexpand is not
/// set, then the expand value depends on whether any
/// children of the widget would like to expand.
/// </para>
/// <para>
/// There are few reasons to use this function, but it’s here
/// for completeness and consistency.
/// </para>
/// </summary>

/// <param name="widget">
/// the widget
/// </param>
/// <return>
/// whether hexpand has been explicitly set
/// </return>

	public static bool GetHexpandSet(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_hexpand_set(widget);
	}

/// <summary>
/// <para>
/// Whether the widget is mapped.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if the widget is mapped, %FALSE otherwise.
/// </return>

	public static bool GetMapped(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_mapped(widget);
	}

/// <summary>
/// <para>
/// Gets the value of the #GtkWidget:margin-bottom property.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// The bottom margin of @widget
/// </return>

	public static int GetMarginBottom(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_margin_bottom(widget);
	}

/// <summary>
/// <para>
/// Gets the value of the #GtkWidget:margin-end property.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// The end margin of @widget
/// </return>

	public static int GetMarginEnd(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_margin_end(widget);
	}

/// <summary>
/// <para>
/// Gets the value of the #GtkWidget:margin-left property.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// The left margin of @widget
/// </return>

	public static int GetMarginLeft(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_margin_left(widget);
	}

/// <summary>
/// <para>
/// Gets the value of the #GtkWidget:margin-right property.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// The right margin of @widget
/// </return>

	public static int GetMarginRight(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_margin_right(widget);
	}

/// <summary>
/// <para>
/// Gets the value of the #GtkWidget:margin-start property.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// The start margin of @widget
/// </return>

	public static int GetMarginStart(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_margin_start(widget);
	}

/// <summary>
/// <para>
/// Gets the value of the #GtkWidget:margin-top property.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// The top margin of @widget
/// </return>

	public static int GetMarginTop(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_margin_top(widget);
	}

/// <summary>
/// <para>
/// Returns the modifier mask the @widget’s windowing system backend
/// uses for a particular purpose.
/// </para>
/// <para>
/// See gdk_keymap_get_modifier_mask().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="intent">
/// the use case for the modifier mask
/// </param>
/// <return>
/// the modifier mask used for @intent.
/// </return>

	public static MentorLake.Gdk.GdkModifierType GetModifierMask(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkModifierIntent intent)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_modifier_mask(widget, intent);
	}

/// <summary>
/// <para>
/// Returns the current modifier style for the widget. (As set by
/// gtk_widget_modify_style().) If no style has previously set, a new
/// #GtkRcStyle will be created with all values unset, and set as the
/// modifier style for the widget. If you make changes to this rc
/// style, you must call gtk_widget_modify_style(), passing in the
/// returned rc style, to make sure that your changes take effect.
/// </para>
/// <para>
/// Caution: passing the style back to gtk_widget_modify_style() will
/// normally end up destroying it, because gtk_widget_modify_style() copies
/// the passed-in style and sets the copy as the new modifier style,
/// thus dropping any reference to the old modifier style. Add a reference
/// to the modifier style if you want to keep it alive.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the modifier style for the widget.
///     This rc style is owned by the widget. If you want to keep a
///     pointer to value this around, you must add a refcount using
///     g_object_ref().
/// </return>

	public static MentorLake.Gtk.GtkRcStyleHandle GetModifierStyle(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_modifier_style(widget);
	}

/// <summary>
/// <para>
/// Retrieves the name of a widget. See gtk_widget_set_name() for the
/// significance of widget names.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// name of the widget. This string is owned by GTK+ and
/// should not be modified or freed
/// </return>

	public static string GetName(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_name(widget);
	}

/// <summary>
/// <para>
/// Returns the current value of the #GtkWidget:no-show-all property,
/// which determines whether calls to gtk_widget_show_all()
/// will affect this widget.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the current value of the “no-show-all” property.
/// </return>

	public static bool GetNoShowAll(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_no_show_all(widget);
	}

/// <summary>
/// <para>
/// Fetches the requested opacity for this widget.
/// See gtk_widget_set_opacity().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the requested opacity for this widget.
/// </return>

	public static double GetOpacity(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_opacity(widget);
	}

/// <summary>
/// <para>
/// Gets a #PangoContext with the appropriate font map, font description,
/// and base direction for this widget. Unlike the context returned
/// by gtk_widget_create_pango_context(), this context is owned by
/// the widget (it can be used until the screen for the widget changes
/// or the widget is removed from its toplevel), and will be updated to
/// match any changes to the widget’s attributes. This can be tracked
/// by using the #GtkWidget::screen-changed signal on the widget.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the #PangoContext for the widget.
/// </return>

	public static MentorLake.Pango.PangoContextHandle GetPangoContext(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_pango_context(widget);
	}

/// <summary>
/// <para>
/// Returns the parent container of @widget.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the parent container of @widget, or %NULL
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetParent(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_parent(widget);
	}

/// <summary>
/// <para>
/// Gets @widget’s parent window, or %NULL if it does not have one.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget.
/// </param>
/// <return>
/// the parent window of @widget, or %NULL
/// if it does not have a parent window.
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetParentWindow(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_parent_window(widget);
	}

/// <summary>
/// <para>
/// Returns the #GtkWidgetPath representing @widget, if the widget
/// is not connected to a toplevel widget, a partial path will be
/// created.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// The #GtkWidgetPath representing @widget
/// </return>

	public static MentorLake.Gtk.GtkWidgetPathHandle GetPath(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_path(widget);
	}

/// <summary>
/// <para>
/// Obtains the location of the mouse pointer in widget coordinates.
/// Widget coordinates are a bit odd; for historical reasons, they are
/// defined as @widget-&amp;gt;window coordinates for widgets that return %TRUE for
/// gtk_widget_get_has_window(); and are relative to @widget-&amp;gt;allocation.x,
/// @widget-&amp;gt;allocation.y otherwise.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="x">
/// return location for the X coordinate, or %NULL
/// </param>
/// <param name="y">
/// return location for the Y coordinate, or %NULL
/// </param>

	public static T GetPointer<T>(this T widget, out int x, out int y) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_pointer(widget, out x, out y);
		return widget;
	}

/// <summary>
/// <para>
/// Retrieves a widget’s initial minimum and natural height.
/// </para>
/// <para>
/// This call is specific to width-for-height requests.
/// </para>
/// <para>
/// The returned request will be modified by the
/// GtkWidgetClass::adjust_size_request virtual method and by any
/// #GtkSizeGroups that have been applied. That is, the returned request
/// is the one that should be used for layout, not necessarily the one
/// returned by the widget itself.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget instance
/// </param>
/// <param name="minimum_height">
/// location to store the minimum height, or %NULL
/// </param>
/// <param name="natural_height">
/// location to store the natural height, or %NULL
/// </param>

	public static T GetPreferredHeight<T>(this T widget, out int minimum_height, out int natural_height) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_preferred_height(widget, out minimum_height, out natural_height);
		return widget;
	}

/// <summary>
/// <para>
/// Retrieves a widget’s minimum and natural height and the corresponding baselines if it would be given
/// the specified @width, or the default height if @width is -1. The baselines may be -1 which means
/// that no baseline is requested for this widget.
/// </para>
/// <para>
/// The returned request will be modified by the
/// GtkWidgetClass::adjust_size_request and GtkWidgetClass::adjust_baseline_request virtual methods
/// and by any #GtkSizeGroups that have been applied. That is, the returned request
/// is the one that should be used for layout, not necessarily the one
/// returned by the widget itself.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget instance
/// </param>
/// <param name="width">
/// the width which is available for allocation, or -1 if none
/// </param>
/// <param name="minimum_height">
/// location for storing the minimum height, or %NULL
/// </param>
/// <param name="natural_height">
/// location for storing the natural height, or %NULL
/// </param>
/// <param name="minimum_baseline">
/// location for storing the baseline for the minimum height, or %NULL
/// </param>
/// <param name="natural_baseline">
/// location for storing the baseline for the natural height, or %NULL
/// </param>

	public static T GetPreferredHeightAndBaselineForWidth<T>(this T widget, int width, out int minimum_height, out int natural_height, out int minimum_baseline, out int natural_baseline) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_preferred_height_and_baseline_for_width(widget, width, out minimum_height, out natural_height, out minimum_baseline, out natural_baseline);
		return widget;
	}

/// <summary>
/// <para>
/// Retrieves a widget’s minimum and natural height if it would be given
/// the specified @width.
/// </para>
/// <para>
/// The returned request will be modified by the
/// GtkWidgetClass::adjust_size_request virtual method and by any
/// #GtkSizeGroups that have been applied. That is, the returned request
/// is the one that should be used for layout, not necessarily the one
/// returned by the widget itself.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget instance
/// </param>
/// <param name="width">
/// the width which is available for allocation
/// </param>
/// <param name="minimum_height">
/// location for storing the minimum height, or %NULL
/// </param>
/// <param name="natural_height">
/// location for storing the natural height, or %NULL
/// </param>

	public static T GetPreferredHeightForWidth<T>(this T widget, int width, out int minimum_height, out int natural_height) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_preferred_height_for_width(widget, width, out minimum_height, out natural_height);
		return widget;
	}

/// <summary>
/// <para>
/// Retrieves the minimum and natural size of a widget, taking
/// into account the widget’s preference for height-for-width management.
/// </para>
/// <para>
/// This is used to retrieve a suitable size by container widgets which do
/// not impose any restrictions on the child placement. It can be used
/// to deduce toplevel window and menu sizes as well as child widgets in
/// free-form containers such as GtkLayout.
/// </para>
/// <para>
/// Handle with care. Note that the natural height of a height-for-width
/// widget will generally be a smaller size than the minimum height, since the required
/// height for the natural width is generally smaller than the required height for
/// the minimum width.
/// </para>
/// <para>
/// Use gtk_widget_get_preferred_height_and_baseline_for_width() if you want to support
/// baseline alignment.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget instance
/// </param>
/// <param name="minimum_size">
/// location for storing the minimum size, or %NULL
/// </param>
/// <param name="natural_size">
/// location for storing the natural size, or %NULL
/// </param>

	public static T GetPreferredSize<T>(this T widget, out MentorLake.Gtk.GtkRequisition minimum_size, out MentorLake.Gtk.GtkRequisition natural_size) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_preferred_size(widget, out minimum_size, out natural_size);
		return widget;
	}

/// <summary>
/// <para>
/// Retrieves a widget’s initial minimum and natural width.
/// </para>
/// <para>
/// This call is specific to height-for-width requests.
/// </para>
/// <para>
/// The returned request will be modified by the
/// GtkWidgetClass::adjust_size_request virtual method and by any
/// #GtkSizeGroups that have been applied. That is, the returned request
/// is the one that should be used for layout, not necessarily the one
/// returned by the widget itself.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget instance
/// </param>
/// <param name="minimum_width">
/// location to store the minimum width, or %NULL
/// </param>
/// <param name="natural_width">
/// location to store the natural width, or %NULL
/// </param>

	public static T GetPreferredWidth<T>(this T widget, out int minimum_width, out int natural_width) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_preferred_width(widget, out minimum_width, out natural_width);
		return widget;
	}

/// <summary>
/// <para>
/// Retrieves a widget’s minimum and natural width if it would be given
/// the specified @height.
/// </para>
/// <para>
/// The returned request will be modified by the
/// GtkWidgetClass::adjust_size_request virtual method and by any
/// #GtkSizeGroups that have been applied. That is, the returned request
/// is the one that should be used for layout, not necessarily the one
/// returned by the widget itself.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget instance
/// </param>
/// <param name="height">
/// the height which is available for allocation
/// </param>
/// <param name="minimum_width">
/// location for storing the minimum width, or %NULL
/// </param>
/// <param name="natural_width">
/// location for storing the natural width, or %NULL
/// </param>

	public static T GetPreferredWidthForHeight<T>(this T widget, int height, out int minimum_width, out int natural_width) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_preferred_width_for_height(widget, height, out minimum_width, out natural_width);
		return widget;
	}

/// <summary>
/// <para>
/// Determines whether @widget is realized.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if @widget is realized, %FALSE otherwise
/// </return>

	public static bool GetRealized(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_realized(widget);
	}

/// <summary>
/// <para>
/// Determines whether @widget is always treated as the default widget
/// within its toplevel when it has the focus, even if another widget
/// is the default.
/// </para>
/// <para>
/// See gtk_widget_set_receives_default().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if @widget acts as the default widget when focused,
///               %FALSE otherwise
/// </return>

	public static bool GetReceivesDefault(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_receives_default(widget);
	}

/// <summary>
/// <para>
/// Gets whether the widget prefers a height-for-width layout
/// or a width-for-height layout.
/// </para>
/// <para>
/// #GtkBin widgets generally propagate the preference of
/// their child, container widgets need to request something either in
/// context of their children or in context of their allocation
/// capabilities.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget instance
/// </param>
/// <return>
/// The #GtkSizeRequestMode preferred by @widget.
/// </return>

	public static MentorLake.Gtk.GtkSizeRequestMode GetRequestMode(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_request_mode(widget);
	}

/// <summary>
/// <para>
/// Retrieves the widget’s requisition.
/// </para>
/// <para>
/// This function should only be used by widget implementations in
/// order to figure whether the widget’s requisition has actually
/// changed after some internal state change (so that they can call
/// gtk_widget_queue_resize() instead of gtk_widget_queue_draw()).
/// </para>
/// <para>
/// Normally, gtk_widget_size_request() should be used.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="requisition">
/// a pointer to a #GtkRequisition to copy to
/// </param>

	public static T GetRequisition<T>(this T widget, out MentorLake.Gtk.GtkRequisition requisition) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_requisition(widget, out requisition);
		return widget;
	}

/// <summary>
/// <para>
/// Get the root window where this widget is located. This function can
/// only be called after the widget has been added to a widget
/// hierarchy with #GtkWindow at the top.
/// </para>
/// <para>
/// The root window is useful for such purposes as creating a popup
/// #GdkWindow associated with the window. In general, you should only
/// create display specific resources when a widget has been realized,
/// and you should free those resources when the widget is unrealized.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the #GdkWindow root window for the toplevel for this widget.
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetRootWindow(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_root_window(widget);
	}

/// <summary>
/// <para>
/// Retrieves the internal scale factor that maps from window coordinates
/// to the actual device pixels. On traditional systems this is 1, on
/// high density outputs, it can be a higher value (typically 2).
/// </para>
/// <para>
/// See gdk_window_get_scale_factor().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the scale factor for @widget
/// </return>

	public static int GetScaleFactor(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_scale_factor(widget);
	}

/// <summary>
/// <para>
/// Get the #GdkScreen from the toplevel window associated with
/// this widget. This function can only be called after the widget
/// has been added to a widget hierarchy with a #GtkWindow
/// at the top.
/// </para>
/// <para>
/// In general, you should only create screen specific
/// resources when a widget has been realized, and you should
/// free those resources when the widget is unrealized.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the #GdkScreen for the toplevel for this widget.
/// </return>

	public static MentorLake.Gdk.GdkScreenHandle GetScreen(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_screen(widget);
	}

/// <summary>
/// <para>
/// Returns the widget’s sensitivity (in the sense of returning
/// the value that has been set using gtk_widget_set_sensitive()).
/// </para>
/// <para>
/// The effective sensitivity of a widget is however determined by both its
/// own and its parent widget’s sensitivity. See gtk_widget_is_sensitive().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if the widget is sensitive
/// </return>

	public static bool GetSensitive(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_sensitive(widget);
	}

/// <summary>
/// <para>
/// Gets the settings object holding the settings used for this widget.
/// </para>
/// <para>
/// Note that this function can only be called when the #GtkWidget
/// is attached to a toplevel, since the settings object is specific
/// to a particular #GdkScreen.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the relevant #GtkSettings object
/// </return>

	public static MentorLake.Gtk.GtkSettingsHandle GetSettings(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_settings(widget);
	}

/// <summary>
/// <para>
/// Gets the size request that was explicitly set for the widget using
/// gtk_widget_set_size_request(). A value of -1 stored in @width or
/// @height indicates that that dimension has not been set explicitly
/// and the natural requisition of the widget will be used instead. See
/// gtk_widget_set_size_request(). To get the size a widget will
/// actually request, call gtk_widget_get_preferred_size() instead of
/// this function.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="width">
/// return location for width, or %NULL
/// </param>
/// <param name="height">
/// return location for height, or %NULL
/// </param>

	public static T GetSizeRequest<T>(this T widget, out int width, out int height) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_size_request(widget, out width, out height);
		return widget;
	}

/// <summary>
/// <para>
/// Returns the widget’s state. See gtk_widget_set_state().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the state of @widget.
/// </return>

	public static MentorLake.Gtk.GtkStateType GetState(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_state(widget);
	}

/// <summary>
/// <para>
/// Returns the widget state as a flag set. It is worth mentioning
/// that the effective %GTK_STATE_FLAG_INSENSITIVE state will be
/// returned, that is, also based on parent insensitivity, even if
/// @widget itself is sensitive.
/// </para>
/// <para>
/// Also note that if you are looking for a way to obtain the
/// #GtkStateFlags to pass to a #GtkStyleContext method, you
/// should look at gtk_style_context_get_state().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// The state flags for widget
/// </return>

	public static MentorLake.Gtk.GtkStateFlags GetStateFlags(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_state_flags(widget);
	}

/// <summary>
/// <para>
/// Simply an accessor function that returns @widget-&amp;gt;style.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the widget’s #GtkStyle
/// </return>

	public static MentorLake.Gtk.GtkStyleHandle GetStyle(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_style(widget);
	}

/// <summary>
/// <para>
/// Returns the style context associated to @widget. The returned object is
/// guaranteed to be the same for the lifetime of @widget.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// a #GtkStyleContext. This memory is owned by @widget and
///          must not be freed.
/// </return>

	public static MentorLake.Gtk.GtkStyleContextHandle GetStyleContext(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_style_context(widget);
	}

/// <summary>
/// <para>
/// Returns %TRUE if @widget is multiple pointer aware. See
/// gtk_widget_set_support_multidevice() for more information.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if @widget is multidevice aware.
/// </return>

	public static bool GetSupportMultidevice(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_support_multidevice(widget);
	}

/// <summary>
/// <para>
/// Fetch an object build from the template XML for @widget_type in this @widget instance.
/// </para>
/// <para>
/// This will only report children which were previously declared with
/// gtk_widget_class_bind_template_child_full() or one of its
/// variants.
/// </para>
/// <para>
/// This function is only meant to be called for code which is private to the @widget_type which
/// declared the child and is meant for language bindings which cannot easily make use
/// of the GObject structure offsets.
/// </para>
/// </summary>

/// <param name="widget">
/// A #GtkWidget
/// </param>
/// <param name="widget_type">
/// The #GType to get a template child for
/// </param>
/// <param name="name">
/// The “id” of the child defined in the template XML
/// </param>
/// <return>
/// The object built in the template XML with the id @name
/// </return>

	public static MentorLake.GObject.GObjectHandle GetTemplateChild(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.GObject.GType widget_type, string name)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_template_child(widget, widget_type, name);
	}

/// <summary>
/// <para>
/// Gets the contents of the tooltip for @widget.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the tooltip text, or %NULL. You should free the
///   returned string with g_free() when done.
/// </return>

	public static string GetTooltipMarkup(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_tooltip_markup(widget);
	}

/// <summary>
/// <para>
/// Gets the contents of the tooltip for @widget.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the tooltip text, or %NULL. You should free the
///   returned string with g_free() when done.
/// </return>

	public static string GetTooltipText(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_tooltip_text(widget);
	}

/// <summary>
/// <para>
/// Returns the #GtkWindow of the current tooltip. This can be the
/// GtkWindow created by default, or the custom tooltip window set
/// using gtk_widget_set_tooltip_window().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// The #GtkWindow of the current tooltip.
/// </return>

	public static MentorLake.Gtk.GtkWindowHandle GetTooltipWindow(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_tooltip_window(widget);
	}

/// <summary>
/// <para>
/// This function returns the topmost widget in the container hierarchy
/// @widget is a part of. If @widget has no parent widgets, it will be
/// returned as the topmost widget. No reference will be added to the
/// returned widget; it should not be unreferenced.
/// </para>
/// <para>
/// Note the difference in behavior vs. gtk_widget_get_ancestor();
/// `gtk_widget_get_ancestor (widget, GTK_TYPE_WINDOW)`
/// would return
/// %NULL if @widget wasn’t inside a toplevel window, and if the
/// window was inside a #GtkWindow-derived widget which was in turn
/// inside the toplevel #GtkWindow. While the second case may
/// seem unlikely, it actually happens when a #GtkPlug is embedded
/// inside a #GtkSocket within the same application.
/// </para>
/// <para>
/// To reliably find the toplevel #GtkWindow, use
/// gtk_widget_get_toplevel() and call GTK_IS_WINDOW()
/// on the result. For instance, to get the title of a widget&apos;s toplevel
/// window, one might use:
/// <code>
/// static const char *
/// static const char *
/// get_widget_toplevel_title (GtkWidget *widget)
/// {
///   GtkWidget *toplevel = gtk_widget_get_toplevel (widget);
///   if (GTK_IS_WINDOW (toplevel))
///     {
///       return gtk_window_get_title (GTK_WINDOW (toplevel));
///     }
/// 
///   return NULL;
/// }
/// </code>
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the topmost ancestor of @widget, or @widget itself
///    if there’s no ancestor.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetToplevel(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_toplevel(widget);
	}

/// <summary>
/// <para>
/// Gets the value of the #GtkWidget:valign property.
/// </para>
/// <para>
/// For backwards compatibility reasons this method will never return
/// %GTK_ALIGN_BASELINE, but instead it will convert it to
/// %GTK_ALIGN_FILL. If your widget want to support baseline aligned
/// children it must use gtk_widget_get_valign_with_baseline(), or
/// `g_object_get (widget, &quot;valign&quot;, &amp;value, NULL)`, which will
/// also report the true value.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the vertical alignment of @widget, ignoring baseline alignment
/// </return>

	public static MentorLake.Gtk.GtkAlign GetValign(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_valign(widget);
	}

/// <summary>
/// <para>
/// Gets the value of the #GtkWidget:valign property, including
/// %GTK_ALIGN_BASELINE.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the vertical alignment of @widget
/// </return>

	public static MentorLake.Gtk.GtkAlign GetValignWithBaseline(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_valign_with_baseline(widget);
	}

/// <summary>
/// <para>
/// Gets whether the widget would like any available extra vertical
/// space.
/// </para>
/// <para>
/// See gtk_widget_get_hexpand() for more detail.
/// </para>
/// </summary>

/// <param name="widget">
/// the widget
/// </param>
/// <return>
/// whether vexpand flag is set
/// </return>

	public static bool GetVexpand(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_vexpand(widget);
	}

/// <summary>
/// <para>
/// Gets whether gtk_widget_set_vexpand() has been used to
/// explicitly set the expand flag on this widget.
/// </para>
/// <para>
/// See gtk_widget_get_hexpand_set() for more detail.
/// </para>
/// </summary>

/// <param name="widget">
/// the widget
/// </param>
/// <return>
/// whether vexpand has been explicitly set
/// </return>

	public static bool GetVexpandSet(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_vexpand_set(widget);
	}

/// <summary>
/// <para>
/// Determines whether the widget is visible. If you want to
/// take into account whether the widget’s parent is also marked as
/// visible, use gtk_widget_is_visible() instead.
/// </para>
/// <para>
/// This function does not check if the widget is obscured in any way.
/// </para>
/// <para>
/// See gtk_widget_set_visible().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if the widget is visible
/// </return>

	public static bool GetVisible(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_visible(widget);
	}

/// <summary>
/// <para>
/// Gets the visual that will be used to render @widget.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the visual for @widget
/// </return>

	public static MentorLake.Gdk.GdkVisualHandle GetVisual(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_visual(widget);
	}

/// <summary>
/// <para>
/// Returns the widget’s window if it is realized, %NULL otherwise
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// @widget’s window.
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetWindow(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_window(widget);
	}

/// <summary>
/// <para>
/// Makes @widget the current grabbed widget.
/// </para>
/// <para>
/// This means that interaction with other widgets in the same
/// application is blocked and mouse as well as keyboard events
/// are delivered to this widget.
/// </para>
/// <para>
/// If @widget is not sensitive, it is not set as the current
/// grabbed widget and this function does nothing.
/// </para>
/// </summary>

/// <param name="widget">
/// The widget that grabs keyboard and pointer events
/// </param>

	public static T GrabAdd<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_grab_add(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Causes @widget to become the default widget. @widget must be able to be
/// a default widget; typically you would ensure this yourself
/// by calling gtk_widget_set_can_default() with a %TRUE value.
/// The default widget is activated when
/// the user presses Enter in a window. Default widgets must be
/// activatable, that is, gtk_widget_activate() should affect them. Note
/// that #GtkEntry widgets require the “activates-default” property
/// set to %TRUE before they activate the default widget when Enter
/// is pressed and the #GtkEntry is focused.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T GrabDefault<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_grab_default(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Causes @widget to have the keyboard focus for the #GtkWindow it&apos;s
/// inside. @widget must be a focusable widget, such as a #GtkEntry;
/// something like #GtkFrame won’t work.
/// </para>
/// <para>
/// More precisely, it must have the %GTK_CAN_FOCUS flag set. Use
/// gtk_widget_set_can_focus() to modify that flag.
/// </para>
/// <para>
/// The widget also needs to be realized and mapped. This is indicated by the
/// related signals. Grabbing the focus immediately after creating the widget
/// will likely fail and cause critical warnings.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T GrabFocus<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_grab_focus(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Removes the grab from the given widget.
/// </para>
/// <para>
/// You have to pair calls to gtk_grab_add() and gtk_grab_remove().
/// </para>
/// <para>
/// If @widget does not have the grab, this function does nothing.
/// </para>
/// </summary>

/// <param name="widget">
/// The widget which gives up the grab
/// </param>

	public static T GrabRemove<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_grab_remove(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Determines whether @widget is the current default widget within its
/// toplevel. See gtk_widget_set_can_default().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if @widget is the current default widget within
///     its toplevel, %FALSE otherwise
/// </return>

	public static bool HasDefault(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_has_default(widget);
	}

/// <summary>
/// <para>
/// Determines if the widget has the global input focus. See
/// gtk_widget_is_focus() for the difference between having the global
/// input focus, and only having the focus within a toplevel.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if the widget has the global input focus.
/// </return>

	public static bool HasFocus(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_has_focus(widget);
	}

/// <summary>
/// <para>
/// Determines whether the widget is currently grabbing events, so it
/// is the only widget receiving input events (keyboard and mouse).
/// </para>
/// <para>
/// See also gtk_grab_add().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if the widget is in the grab_widgets stack
/// </return>

	public static bool HasGrab(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_has_grab(widget);
	}

/// <summary>
/// <para>
/// Determines if the widget style has been looked up through the rc mechanism.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if the widget has been looked up through the rc
///   mechanism, %FALSE otherwise.
/// </return>

	public static bool HasRcStyle(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_has_rc_style(widget);
	}

/// <summary>
/// <para>
/// Checks whether there is a #GdkScreen is associated with
/// this widget. All toplevel widgets have an associated
/// screen, and all widgets added into a hierarchy with a toplevel
/// window at the top.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if there is a #GdkScreen associated
///   with the widget.
/// </return>

	public static bool HasScreen(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_has_screen(widget);
	}

/// <summary>
/// <para>
/// Determines if the widget should show a visible indication that
/// it has the global input focus. This is a convenience function for
/// use in ::draw handlers that takes into account whether focus
/// indication should currently be shown in the toplevel window of
/// @widget. See gtk_window_get_focus_visible() for more information
/// about focus indication.
/// </para>
/// <para>
/// To find out if the widget has the global input focus, use
/// gtk_widget_has_focus().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if the widget should display a “focus rectangle”
/// </return>

	public static bool HasVisibleFocus(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_has_visible_focus(widget);
	}

/// <summary>
/// <para>
/// Reverses the effects of gtk_widget_show(), causing the widget to be
/// hidden (invisible to the user).
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T Hide<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_hide(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Utility function; intended to be connected to the #GtkWidget::delete-event
/// signal on a #GtkWindow. The function calls gtk_widget_hide() on its
/// argument, then returns %TRUE. If connected to ::delete-event, the
/// result is that clicking the close button for a window (on the
/// window frame, top right corner usually) will hide but not destroy
/// the window. By default, GTK+ destroys windows when ::delete-event
/// is received.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE
/// </return>

	public static bool HideOnDelete(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_hide_on_delete(widget);
	}

/// <summary>
/// <para>
/// Returns whether the widget is currently being destroyed.
/// This information can sometimes be used to avoid doing
/// unnecessary work.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if @widget is being destroyed
/// </return>

	public static bool InDestruction(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_in_destruction(widget);
	}

/// <summary>
/// <para>
/// Creates and initializes child widgets defined in templates. This
/// function must be called in the instance initializer for any
/// class which assigned itself a template using gtk_widget_class_set_template()
/// </para>
/// <para>
/// It is important to call this function in the instance initializer
/// of a #GtkWidget subclass and not in #GObject.constructed() or
/// #GObject.constructor() for two reasons.
/// </para>
/// <para>
/// One reason is that generally derived widgets will assume that parent
/// class composite widgets have been created in their instance
/// initializers.
/// </para>
/// <para>
/// Another reason is that when calling g_object_new() on a widget with
/// composite templates, it’s important to build the composite widgets
/// before the construct properties are set. Properties passed to g_object_new()
/// should take precedence over properties set in the private template XML.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T InitTemplate<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_init_template(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Sets an input shape for this widget’s GDK window. This allows for
/// windows which react to mouse click in a nonrectangular region, see
/// gdk_window_input_shape_combine_region() for more information.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="region">
/// shape to be added, or %NULL to remove an existing shape
/// </param>

	public static T InputShapeCombineRegion<T>(this T widget, MentorLake.cairo.cairo_region_tHandle region) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_input_shape_combine_region(widget, region);
		return widget;
	}

/// <summary>
/// <para>
/// Inserts @group into @widget. Children of @widget that implement
/// #GtkActionable can then be associated with actions in @group by
/// setting their “action-name” to
/// @prefix.`action-name`.
/// </para>
/// <para>
/// If @group is %NULL, a previously inserted group for @name is removed
/// from @widget.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="name">
/// the prefix for actions in @group
/// </param>
/// <param name="group">
/// a #GActionGroup, or %NULL
/// </param>

	public static T InsertActionGroup<T>(this T widget, string name, MentorLake.Gio.GActionGroupHandle group) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_insert_action_group(widget, name, group);
		return widget;
	}

/// <summary>
/// <para>
/// Computes the intersection of a @widget’s area and @area, storing
/// the intersection in @intersection, and returns %TRUE if there was
/// an intersection.  @intersection may be %NULL if you’re only
/// interested in whether there was an intersection.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="area">
/// a rectangle
/// </param>
/// <param name="intersection">
/// rectangle to store
///   intersection of @widget and @area
/// </param>
/// <return>
/// %TRUE if there was an intersection
/// </return>

	public static bool Intersect(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkRectangleHandle area, out MentorLake.Gdk.GdkRectangle intersection)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_intersect(widget, area, out intersection);
	}

/// <summary>
/// <para>
/// Determines whether @widget is somewhere inside @ancestor, possibly with
/// intermediate containers.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="ancestor">
/// another #GtkWidget
/// </param>
/// <return>
/// %TRUE if @ancestor contains @widget as a child,
///    grandchild, great grandchild, etc.
/// </return>

	public static bool IsAncestor(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkWidgetHandle ancestor)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_is_ancestor(widget, ancestor);
	}

/// <summary>
/// <para>
/// Whether @widget can rely on having its alpha channel
/// drawn correctly. On X11 this function returns whether a
/// compositing manager is running for @widget’s screen.
/// </para>
/// <para>
/// Please note that the semantics of this call will change
/// in the future if used on a widget that has a composited
/// window in its hierarchy (as set by gdk_window_set_composited()).
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if the widget can rely on its alpha
/// channel being drawn correctly.
/// </return>

	public static bool IsComposited(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_is_composited(widget);
	}

/// <summary>
/// <para>
/// Determines whether @widget can be drawn to. A widget can be drawn
/// to if it is mapped and visible.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if @widget is drawable, %FALSE otherwise
/// </return>

	public static bool IsDrawable(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_is_drawable(widget);
	}

/// <summary>
/// <para>
/// Determines if the widget is the focus widget within its
/// toplevel. (This does not mean that the #GtkWidget:has-focus property is
/// necessarily set; #GtkWidget:has-focus will only be set if the
/// toplevel widget additionally has the global input focus.)
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if the widget is the focus widget.
/// </return>

	public static bool IsFocus(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_is_focus(widget);
	}

/// <summary>
/// <para>
/// Returns the widget’s effective sensitivity, which means
/// it is sensitive itself and also its parent widget is sensitive
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if the widget is effectively sensitive
/// </return>

	public static bool IsSensitive(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_is_sensitive(widget);
	}

/// <summary>
/// <para>
/// Determines whether @widget is a toplevel widget.
/// </para>
/// <para>
/// Currently only #GtkWindow and #GtkInvisible (and out-of-process
/// #GtkPlugs) are toplevel widgets. Toplevel widgets have no parent
/// widget.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if @widget is a toplevel, %FALSE otherwise
/// </return>

	public static bool IsToplevel(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_is_toplevel(widget);
	}

/// <summary>
/// <para>
/// Determines whether the widget and all its parents are marked as
/// visible.
/// </para>
/// <para>
/// This function does not check if the widget is obscured in any way.
/// </para>
/// <para>
/// See also gtk_widget_get_visible() and gtk_widget_set_visible()
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// %TRUE if the widget and all its parents are visible
/// </return>

	public static bool IsVisible(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_is_visible(widget);
	}

/// <summary>
/// <para>
/// This function should be called whenever keyboard navigation within
/// a single widget hits a boundary. The function emits the
/// #GtkWidget::keynav-failed signal on the widget and its return
/// value should be interpreted in a way similar to the return value of
/// gtk_widget_child_focus():
/// </para>
/// <para>
/// When %TRUE is returned, stay in the widget, the failed keyboard
/// navigation is OK and/or there is nowhere we can/should move the
/// focus to.
/// </para>
/// <para>
/// When %FALSE is returned, the caller should continue with keyboard
/// navigation outside the widget, e.g. by calling
/// gtk_widget_child_focus() on the widget’s toplevel.
/// </para>
/// <para>
/// The default ::keynav-failed handler returns %FALSE for
/// %GTK_DIR_TAB_FORWARD and %GTK_DIR_TAB_BACKWARD. For the other
/// values of #GtkDirectionType it returns %TRUE.
/// </para>
/// <para>
/// Whenever the default handler returns %TRUE, it also calls
/// gtk_widget_error_bell() to notify the user of the failed keyboard
/// navigation.
/// </para>
/// <para>
/// A use case for providing an own implementation of ::keynav-failed
/// (either by connecting to it or by overriding it) would be a row of
/// #GtkEntry widgets where the user should be able to navigate the
/// entire row with the cursor keys, as e.g. known from user interfaces
/// that require entering license keys.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="direction">
/// direction of focus movement
/// </param>
/// <return>
/// %TRUE if stopping keyboard navigation is fine, %FALSE
///               if the emitting widget should try to handle the keyboard
///               navigation attempt in its parent container(s).
/// </return>

	public static bool KeynavFailed(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkDirectionType direction)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_keynav_failed(widget, direction);
	}

/// <summary>
/// <para>
/// Lists the closures used by @widget for accelerator group connections
/// with gtk_accel_group_connect_by_path() or gtk_accel_group_connect().
/// The closures can be used to monitor accelerator changes on @widget,
/// by connecting to the @GtkAccelGroup::accel-changed signal of the
/// #GtkAccelGroup of a closure which can be found out with
/// gtk_accel_group_from_accel_closure().
/// </para>
/// </summary>

/// <param name="widget">
/// widget to list accelerator closures for
/// </param>
/// <return>
/// 
///     a newly allocated #GList of closures
/// </return>

	public static MentorLake.GLib.GListHandle ListAccelClosures(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_list_accel_closures(widget);
	}

/// <summary>
/// <para>
/// Retrieves a %NULL-terminated array of strings containing the prefixes of
/// #GActionGroup&apos;s available to @widget.
/// </para>
/// </summary>

/// <param name="widget">
/// A #GtkWidget
/// </param>
/// <return>
/// a %NULL-terminated array of strings.
/// </return>

	public static string[] ListActionPrefixes(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_list_action_prefixes(widget);
	}

/// <summary>
/// <para>
/// Returns a newly allocated list of the widgets, normally labels, for
/// which this widget is the target of a mnemonic (see for example,
/// gtk_label_set_mnemonic_widget()).
/// </para>
/// <para>
/// The widgets in the list are not individually referenced. If you
/// want to iterate through the list and perform actions involving
/// callbacks that might destroy the widgets, you
/// must call `g_list_foreach (result,
/// (GFunc)g_object_ref, NULL)` first, and then unref all the
/// widgets afterwards.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the list of
///  mnemonic labels; free this list
///  with g_list_free() when you are done with it.
/// </return>

	public static MentorLake.GLib.GListHandle ListMnemonicLabels(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_list_mnemonic_labels(widget);
	}

/// <summary>
/// <para>
/// This function is only for use in widget implementations. Causes
/// a widget to be mapped if it isn’t already.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T Map<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_map(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Emits the #GtkWidget::mnemonic-activate signal.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="group_cycling">
/// %TRUE if there are other widgets with the same mnemonic
/// </param>
/// <return>
/// %TRUE if the signal has been handled
/// </return>

	public static bool MnemonicActivate(this MentorLake.Gtk.GtkWidgetHandle widget, bool group_cycling)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_mnemonic_activate(widget, group_cycling);
	}

/// <summary>
/// <para>
/// Sets the base color for a widget in a particular state.
/// All other style values are left untouched. The base color
/// is the background color used along with the text color
/// (see gtk_widget_modify_text()) for widgets such as #GtkEntry
/// and #GtkTextView. See also gtk_widget_modify_style().
/// </para>
/// <para>
/// &amp;gt; Note that “no window” widgets (which have the %GTK_NO_WINDOW
/// &amp;gt; flag set) draw on their parent container’s window and thus may
/// &amp;gt; not draw any background themselves. This is the case for e.g.
/// &amp;gt; #GtkLabel.
/// &amp;gt;
/// &amp;gt; To modify the background of such widgets, you have to set the
/// &amp;gt; base color on their parent; if you want to set the background
/// &amp;gt; of a rectangular area around a label, try placing the label in
/// &amp;gt; a #GtkEventBox widget and setting the base color on that.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="state">
/// the state for which to set the base color
/// </param>
/// <param name="color">
/// the color to assign (does not need to
///     be allocated), or %NULL to undo the effect of previous
///     calls to of gtk_widget_modify_base().
/// </param>

	public static T ModifyBase<T>(this T widget, MentorLake.Gtk.GtkStateType state, MentorLake.Gdk.GdkColorHandle color) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_modify_base(widget, state, color);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the background color for a widget in a particular state.
/// </para>
/// <para>
/// All other style values are left untouched.
/// See also gtk_widget_modify_style().
/// </para>
/// <para>
/// &amp;gt; Note that “no window” widgets (which have the %GTK_NO_WINDOW
/// &amp;gt; flag set) draw on their parent container’s window and thus may
/// &amp;gt; not draw any background themselves. This is the case for e.g.
/// &amp;gt; #GtkLabel.
/// &amp;gt;
/// &amp;gt; To modify the background of such widgets, you have to set the
/// &amp;gt; background color on their parent; if you want to set the background
/// &amp;gt; of a rectangular area around a label, try placing the label in
/// &amp;gt; a #GtkEventBox widget and setting the background color on that.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="state">
/// the state for which to set the background color
/// </param>
/// <param name="color">
/// the color to assign (does not need
///     to be allocated), or %NULL to undo the effect of previous
///     calls to of gtk_widget_modify_bg().
/// </param>

	public static T ModifyBg<T>(this T widget, MentorLake.Gtk.GtkStateType state, MentorLake.Gdk.GdkColorHandle color) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_modify_bg(widget, state, color);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the cursor color to use in a widget, overriding the #GtkWidget
/// cursor-color and secondary-cursor-color
/// style properties.
/// </para>
/// <para>
/// All other style values are left untouched.
/// See also gtk_widget_modify_style().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="primary">
/// the color to use for primary cursor (does not
///     need to be allocated), or %NULL to undo the effect of previous
///     calls to of gtk_widget_modify_cursor().
/// </param>
/// <param name="secondary">
/// the color to use for secondary cursor (does
///     not need to be allocated), or %NULL to undo the effect of
///     previous calls to of gtk_widget_modify_cursor().
/// </param>

	public static T ModifyCursor<T>(this T widget, MentorLake.Gdk.GdkColorHandle primary, MentorLake.Gdk.GdkColorHandle secondary) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_modify_cursor(widget, primary, secondary);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the foreground color for a widget in a particular state.
/// </para>
/// <para>
/// All other style values are left untouched.
/// See also gtk_widget_modify_style().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="state">
/// the state for which to set the foreground color
/// </param>
/// <param name="color">
/// the color to assign (does not need to be allocated),
///     or %NULL to undo the effect of previous calls to
///     of gtk_widget_modify_fg().
/// </param>

	public static T ModifyFg<T>(this T widget, MentorLake.Gtk.GtkStateType state, MentorLake.Gdk.GdkColorHandle color) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_modify_fg(widget, state, color);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the font to use for a widget.
/// </para>
/// <para>
/// All other style values are left untouched.
/// See also gtk_widget_modify_style().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="font_desc">
/// the font description to use, or %NULL
///     to undo the effect of previous calls to gtk_widget_modify_font()
/// </param>

	public static T ModifyFont<T>(this T widget, MentorLake.Pango.PangoFontDescriptionHandle font_desc) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_modify_font(widget, font_desc);
		return widget;
	}

/// <summary>
/// <para>
/// Modifies style values on the widget.
/// </para>
/// <para>
/// Modifications made using this technique take precedence over
/// style values set via an RC file, however, they will be overridden
/// if a style is explicitly set on the widget using gtk_widget_set_style().
/// The #GtkRcStyle-struct is designed so each field can either be
/// set or unset, so it is possible, using this function, to modify some
/// style values and leave the others unchanged.
/// </para>
/// <para>
/// Note that modifications made with this function are not cumulative
/// with previous calls to gtk_widget_modify_style() or with such
/// functions as gtk_widget_modify_fg(). If you wish to retain
/// previous values, you must first call gtk_widget_get_modifier_style(),
/// make your modifications to the returned style, then call
/// gtk_widget_modify_style() with that style. On the other hand,
/// if you first call gtk_widget_modify_style(), subsequent calls
/// to such functions gtk_widget_modify_fg() will have a cumulative
/// effect with the initial modifications.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="style">
/// the #GtkRcStyle-struct holding the style modifications
/// </param>

	public static T ModifyStyle<T>(this T widget, MentorLake.Gtk.GtkRcStyleHandle style) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_modify_style(widget, style);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the text color for a widget in a particular state.
/// </para>
/// <para>
/// All other style values are left untouched.
/// The text color is the foreground color used along with the
/// base color (see gtk_widget_modify_base()) for widgets such
/// as #GtkEntry and #GtkTextView.
/// See also gtk_widget_modify_style().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="state">
/// the state for which to set the text color
/// </param>
/// <param name="color">
/// the color to assign (does not need to
///     be allocated), or %NULL to undo the effect of previous
///     calls to of gtk_widget_modify_text().
/// </param>

	public static T ModifyText<T>(this T widget, MentorLake.Gtk.GtkStateType state, MentorLake.Gdk.GdkColorHandle color) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_modify_text(widget, state, color);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the background color to use for a widget.
/// </para>
/// <para>
/// All other style values are left untouched.
/// See gtk_widget_override_color().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="state">
/// the state for which to set the background color
/// </param>
/// <param name="color">
/// the color to assign, or %NULL to undo the effect
///     of previous calls to gtk_widget_override_background_color()
/// </param>

	public static T OverrideBackgroundColor<T>(this T widget, MentorLake.Gtk.GtkStateFlags state, MentorLake.Gdk.GdkRGBAHandle color) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_override_background_color(widget, state, color);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the color to use for a widget.
/// </para>
/// <para>
/// All other style values are left untouched.
/// </para>
/// <para>
/// This function does not act recursively. Setting the color of a
/// container does not affect its children. Note that some widgets that
/// you may not think of as containers, for instance #GtkButtons,
/// are actually containers.
/// </para>
/// <para>
/// This API is mostly meant as a quick way for applications to
/// change a widget appearance. If you are developing a widgets
/// library and intend this change to be themeable, it is better
/// done by setting meaningful CSS classes in your
/// widget/container implementation through gtk_style_context_add_class().
/// </para>
/// <para>
/// This way, your widget library can install a #GtkCssProvider
/// with the %GTK_STYLE_PROVIDER_PRIORITY_FALLBACK priority in order
/// to provide a default styling for those widgets that need so, and
/// this theming may fully overridden by the user’s theme.
/// </para>
/// <para>
/// Note that for complex widgets this may bring in undesired
/// results (such as uniform background color everywhere), in
/// these cases it is better to fully style such widgets through a
/// #GtkCssProvider with the %GTK_STYLE_PROVIDER_PRIORITY_APPLICATION
/// priority.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="state">
/// the state for which to set the color
/// </param>
/// <param name="color">
/// the color to assign, or %NULL to undo the effect
///     of previous calls to gtk_widget_override_color()
/// </param>

	public static T OverrideColor<T>(this T widget, MentorLake.Gtk.GtkStateFlags state, MentorLake.Gdk.GdkRGBAHandle color) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_override_color(widget, state, color);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the cursor color to use in a widget, overriding the
/// cursor-color and secondary-cursor-color
/// style properties. All other style values are left untouched.
/// See also gtk_widget_modify_style().
/// </para>
/// <para>
/// Note that the underlying properties have the #GdkColor type,
/// so the alpha value in @primary and @secondary will be ignored.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="cursor">
/// the color to use for primary cursor (does not need to be
///     allocated), or %NULL to undo the effect of previous calls to
///     of gtk_widget_override_cursor().
/// </param>
/// <param name="secondary_cursor">
/// the color to use for secondary cursor (does not
///     need to be allocated), or %NULL to undo the effect of previous
///     calls to of gtk_widget_override_cursor().
/// </param>

	public static T OverrideCursor<T>(this T widget, MentorLake.Gdk.GdkRGBAHandle cursor, MentorLake.Gdk.GdkRGBAHandle secondary_cursor) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_override_cursor(widget, cursor, secondary_cursor);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the font to use for a widget. All other style values are
/// left untouched. See gtk_widget_override_color().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="font_desc">
/// the font description to use, or %NULL to undo
///     the effect of previous calls to gtk_widget_override_font()
/// </param>

	public static T OverrideFont<T>(this T widget, MentorLake.Pango.PangoFontDescriptionHandle font_desc) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_override_font(widget, font_desc);
		return widget;
	}

/// <summary>
/// <para>
/// Sets a symbolic color for a widget.
/// </para>
/// <para>
/// All other style values are left untouched.
/// See gtk_widget_override_color() for overriding the foreground
/// or background color.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="name">
/// the name of the symbolic color to modify
/// </param>
/// <param name="color">
/// the color to assign (does not need
///     to be allocated), or %NULL to undo the effect of previous
///     calls to gtk_widget_override_symbolic_color()
/// </param>

	public static T OverrideSymbolicColor<T>(this T widget, string name, MentorLake.Gdk.GdkRGBAHandle color) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_override_symbolic_color(widget, name, color);
		return widget;
	}

/// <summary>
/// <para>
/// Obtains the full path to @widget. The path is simply the name of a
/// widget and all its parents in the container hierarchy, separated by
/// periods. The name of a widget comes from
/// gtk_widget_get_name(). Paths are used to apply styles to a widget
/// in gtkrc configuration files. Widget names are the type of the
/// widget by default (e.g. “GtkButton”) or can be set to an
/// application-specific value with gtk_widget_set_name(). By setting
/// the name of a widget, you allow users or theme authors to apply
/// styles to that specific widget in their gtkrc
/// file. @path_reversed_p fills in the path in reverse order,
/// i.e. starting with @widget’s name instead of starting with the name
/// of @widget’s outermost ancestor.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="path_length">
/// location to store length of the path,
///     or %NULL
/// </param>
/// <param name="path">
/// location to store allocated path string,
///     or %NULL
/// </param>
/// <param name="path_reversed">
/// location to store allocated reverse
///     path string, or %NULL
/// </param>

	public static T Path<T>(this T widget, out uint path_length, out string path, out string path_reversed) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_path(widget, out path_length, out path, out path_reversed);
		return widget;
	}

/// <summary>
/// <para>
/// This function is only for use in widget implementations.
/// </para>
/// <para>
/// Flags the widget for a rerun of the GtkWidgetClass::size_allocate
/// function. Use this function instead of gtk_widget_queue_resize()
/// when the @widget&apos;s size request didn&apos;t change but it wants to
/// reposition its contents.
/// </para>
/// <para>
/// An example user of this function is gtk_widget_set_halign().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T QueueAllocate<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_queue_allocate(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Mark @widget as needing to recompute its expand flags. Call
/// this function when setting legacy expand child properties
/// on the child of a container.
/// </para>
/// <para>
/// See gtk_widget_compute_expand().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T QueueComputeExpand<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_queue_compute_expand(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Equivalent to calling gtk_widget_queue_draw_area() for the
/// entire area of a widget.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T QueueDraw<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_queue_draw(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Convenience function that calls gtk_widget_queue_draw_region() on
/// the region created from the given coordinates.
/// </para>
/// <para>
/// The region here is specified in widget coordinates.
/// Widget coordinates are a bit odd; for historical reasons, they are
/// defined as @widget-&amp;gt;window coordinates for widgets that return %TRUE for
/// gtk_widget_get_has_window(), and are relative to @widget-&amp;gt;allocation.x,
/// @widget-&amp;gt;allocation.y otherwise.
/// </para>
/// <para>
/// @width or @height may be 0, in this case this function does
/// nothing. Negative values for @width and @height are not allowed.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="x">
/// x coordinate of upper-left corner of rectangle to redraw
/// </param>
/// <param name="y">
/// y coordinate of upper-left corner of rectangle to redraw
/// </param>
/// <param name="width">
/// width of region to draw
/// </param>
/// <param name="height">
/// height of region to draw
/// </param>

	public static T QueueDrawArea<T>(this T widget, int x, int y, int width, int height) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_queue_draw_area(widget, x, y, width, height);
		return widget;
	}

/// <summary>
/// <para>
/// Invalidates the area of @widget defined by @region by calling
/// gdk_window_invalidate_region() on the widget’s window and all its
/// child windows. Once the main loop becomes idle (after the current
/// batch of events has been processed, roughly), the window will
/// receive expose events for the union of all regions that have been
/// invalidated.
/// </para>
/// <para>
/// Normally you would only use this function in widget
/// implementations. You might also use it to schedule a redraw of a
/// #GtkDrawingArea or some portion thereof.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="region">
/// region to draw
/// </param>

	public static T QueueDrawRegion<T>(this T widget, MentorLake.cairo.cairo_region_tHandle region) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_queue_draw_region(widget, region);
		return widget;
	}

/// <summary>
/// <para>
/// This function is only for use in widget implementations.
/// Flags a widget to have its size renegotiated; should
/// be called when a widget for some reason has a new size request.
/// For example, when you change the text in a #GtkLabel, #GtkLabel
/// queues a resize to ensure there’s enough space for the new text.
/// </para>
/// <para>
/// Note that you cannot call gtk_widget_queue_resize() on a widget
/// from inside its implementation of the GtkWidgetClass::size_allocate
/// virtual method. Calls to gtk_widget_queue_resize() from inside
/// GtkWidgetClass::size_allocate will be silently ignored.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T QueueResize<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_queue_resize(widget);
		return widget;
	}

/// <summary>
/// <para>
/// This function works like gtk_widget_queue_resize(),
/// except that the widget is not invalidated.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T QueueResizeNoRedraw<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_queue_resize_no_redraw(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Creates the GDK (windowing system) resources associated with a
/// widget.  For example, @widget-&amp;gt;window will be created when a widget
/// is realized.  Normally realization happens implicitly; if you show
/// a widget and all its parent containers, then the widget will be
/// realized and mapped automatically.
/// </para>
/// <para>
/// Realizing a widget requires all
/// the widget’s parent widgets to be realized; calling
/// gtk_widget_realize() realizes the widget’s parents in addition to
/// @widget itself. If a widget is not yet inside a toplevel window
/// when you realize it, bad things will happen.
/// </para>
/// <para>
/// This function is primarily used in widget implementations, and
/// isn’t very useful otherwise. Many times when you think you might
/// need it, a better approach is to connect to a signal that will be
/// called after the widget is realized automatically, such as
/// #GtkWidget::draw. Or simply g_signal_connect () to the
/// #GtkWidget::realize signal.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T Realize<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_realize(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Computes the intersection of a @widget’s area and @region, returning
/// the intersection. The result may be empty, use cairo_region_is_empty() to
/// check.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="region">
/// a #cairo_region_t, in the same coordinate system as
///          @widget-&amp;gt;allocation. That is, relative to @widget-&amp;gt;window
///          for widgets which return %FALSE from gtk_widget_get_has_window();
///          relative to the parent window of @widget-&amp;gt;window otherwise.
/// </param>
/// <return>
/// A newly allocated region holding the intersection of @widget
///     and @region.
/// </return>

	public static MentorLake.cairo.cairo_region_tHandle RegionIntersect(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.cairo.cairo_region_tHandle region)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_region_intersect(widget, region);
	}

/// <summary>
/// <para>
/// Registers a #GdkWindow with the widget and sets it up so that
/// the widget receives events for it. Call gtk_widget_unregister_window()
/// when destroying the window.
/// </para>
/// <para>
/// Before 3.8 you needed to call gdk_window_set_user_data() directly to set
/// this up. This is now deprecated and you should use gtk_widget_register_window()
/// instead. Old code will keep working as is, although some new features like
/// transparency might not work perfectly.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="window">
/// a #GdkWindow
/// </param>

	public static T RegisterWindow<T>(this T widget, MentorLake.Gdk.GdkWindowHandle window) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_register_window(widget, window);
		return widget;
	}

/// <summary>
/// <para>
/// Removes an accelerator from @widget, previously installed with
/// gtk_widget_add_accelerator().
/// </para>
/// </summary>

/// <param name="widget">
/// widget to install an accelerator on
/// </param>
/// <param name="accel_group">
/// accel group for this widget
/// </param>
/// <param name="accel_key">
/// GDK keyval of the accelerator
/// </param>
/// <param name="accel_mods">
/// modifier key combination of the accelerator
/// </param>
/// <return>
/// whether an accelerator was installed and could be removed
/// </return>

	public static bool RemoveAccelerator(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkAccelGroupHandle accel_group, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_remove_accelerator(widget, accel_group, accel_key, accel_mods);
	}

/// <summary>
/// <para>
/// Removes a widget from the list of mnemonic labels for
/// this widget. (See gtk_widget_list_mnemonic_labels()). The widget
/// must have previously been added to the list with
/// gtk_widget_add_mnemonic_label().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="label">
/// a #GtkWidget that was previously set as a mnemonic label for
///         @widget with gtk_widget_add_mnemonic_label().
/// </param>

	public static T RemoveMnemonicLabel<T>(this T widget, MentorLake.Gtk.GtkWidgetHandle label) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_remove_mnemonic_label(widget, label);
		return widget;
	}

/// <summary>
/// <para>
/// Removes a tick callback previously registered with
/// gtk_widget_add_tick_callback().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="id">
/// an id returned by gtk_widget_add_tick_callback()
/// </param>

	public static T RemoveTickCallback<T>(this T widget, uint id) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_remove_tick_callback(widget, id);
		return widget;
	}

/// <summary>
/// <para>
/// A convenience function that uses the theme settings for @widget
/// to look up @stock_id and render it to a pixbuf. @stock_id should
/// be a stock icon ID such as #GTK_STOCK_OPEN or #GTK_STOCK_OK. @size
/// should be a size such as #GTK_ICON_SIZE_MENU. @detail should be a
/// string that identifies the widget or code doing the rendering, so
/// that theme engines can special-case rendering for that widget or
/// code.
/// </para>
/// <para>
/// The pixels in the returned #GdkPixbuf are shared with the rest of
/// the application and should not be modified. The pixbuf should be
/// freed after use with g_object_unref().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="stock_id">
/// a stock ID
/// </param>
/// <param name="size">
/// a stock size (#GtkIconSize). A size of `(GtkIconSize)-1`
///     means render at the size of the source and don’t scale (if there are
///     multiple source sizes, GTK+ picks one of the available sizes).
/// </param>
/// <param name="detail">
/// render detail to pass to theme engine
/// </param>
/// <return>
/// a new pixbuf, or %NULL if the
///     stock ID wasn’t known
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle RenderIcon(this MentorLake.Gtk.GtkWidgetHandle widget, string stock_id, MentorLake.Gtk.GtkIconSize size, string detail)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_render_icon(widget, stock_id, size, detail);
	}

/// <summary>
/// <para>
/// A convenience function that uses the theme engine and style
/// settings for @widget to look up @stock_id and render it to
/// a pixbuf. @stock_id should be a stock icon ID such as
/// #GTK_STOCK_OPEN or #GTK_STOCK_OK. @size should be a size
/// such as #GTK_ICON_SIZE_MENU.
/// </para>
/// <para>
/// The pixels in the returned #GdkPixbuf are shared with the rest of
/// the application and should not be modified. The pixbuf should be freed
/// after use with g_object_unref().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="stock_id">
/// a stock ID
/// </param>
/// <param name="size">
/// a stock size (#GtkIconSize). A size of `(GtkIconSize)-1`
///     means render at the size of the source and don’t scale (if there are
///     multiple source sizes, GTK+ picks one of the available sizes).
/// </param>
/// <return>
/// a new pixbuf, or %NULL if the
///     stock ID wasn’t known
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle RenderIconPixbuf(this MentorLake.Gtk.GtkWidgetHandle widget, string stock_id, MentorLake.Gtk.GtkIconSize size)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_render_icon_pixbuf(widget, stock_id, size);
	}

/// <summary>
/// <para>
/// Moves a widget from one #GtkContainer to another, handling reference
/// count issues to avoid destroying the widget.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="new_parent">
/// a #GtkContainer to move the widget into
/// </param>

	public static T Reparent<T>(this T widget, MentorLake.Gtk.GtkWidgetHandle new_parent) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_reparent(widget, new_parent);
		return widget;
	}

/// <summary>
/// <para>
/// Reset the styles of @widget and all descendents, so when
/// they are looked up again, they get the correct values
/// for the currently loaded RC file settings.
/// </para>
/// <para>
/// This function is not useful for applications.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget.
/// </param>

	public static T ResetRcStyles<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_reset_rc_styles(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Updates the style context of @widget and all descendants
/// by updating its widget path. #GtkContainers may want
/// to use this on a child when reordering it in a way that a different
/// style might apply to it. See also gtk_container_get_path_for_child().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T ResetStyle<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_reset_style(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Very rarely-used function. This function is used to emit
/// an expose event on a widget. This function is not normally used
/// directly. The only time it is used is when propagating an expose
/// event to a windowless child widget (gtk_widget_get_has_window() is %FALSE),
/// and that is normally done using gtk_container_propagate_draw().
/// </para>
/// <para>
/// If you want to force an area of a window to be redrawn,
/// use gdk_window_invalidate_rect() or gdk_window_invalidate_region().
/// To cause the redraw to be done immediately, follow that call
/// with a call to gdk_window_process_updates().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="@event">
/// a expose #GdkEvent
/// </param>
/// <return>
/// return from the event signal emission (%TRUE if
///   the event was handled)
/// </return>

	public static int SendExpose(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkEventHandle @event)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_send_expose(widget, @event);
	}

/// <summary>
/// <para>
/// Sends the focus change @event to @widget
/// </para>
/// <para>
/// This function is not meant to be used by applications. The only time it
/// should be used is when it is necessary for a #GtkWidget to assign focus
/// to a widget that is semantically owned by the first widget even though
/// it’s not a direct child - for instance, a search entry in a floating
/// window similar to the quick search in #GtkTreeView.
/// </para>
/// <para>
/// An example of its usage is:
/// </para>
/// <code>
///   GdkEvent *fevent = gdk_event_new (GDK_FOCUS_CHANGE);
///   GdkEvent *fevent = gdk_event_new (GDK_FOCUS_CHANGE);
/// 
///   fevent-&amp;gt;focus_change.type = GDK_FOCUS_CHANGE;
///   fevent-&amp;gt;focus_change.in = TRUE;
///   fevent-&amp;gt;focus_change.window = _gtk_widget_get_window (widget);
///   if (fevent-&amp;gt;focus_change.window != NULL)
///     g_object_ref (fevent-&amp;gt;focus_change.window);
/// 
///   gtk_widget_send_focus_change (widget, fevent);
/// 
///   gdk_event_free (event);
/// </code>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="@event">
/// a #GdkEvent of type GDK_FOCUS_CHANGE
/// </param>
/// <return>
/// the return value from the event signal emission: %TRUE
///   if the event was handled, and %FALSE otherwise
/// </return>

	public static bool SendFocusChange(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkEventHandle @event)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_send_focus_change(widget, @event);
	}

/// <summary>
/// <para>
/// Given an accelerator group, @accel_group, and an accelerator path,
/// @accel_path, sets up an accelerator in @accel_group so whenever the
/// key binding that is defined for @accel_path is pressed, @widget
/// will be activated.  This removes any accelerators (for any
/// accelerator group) installed by previous calls to
/// gtk_widget_set_accel_path(). Associating accelerators with
/// paths allows them to be modified by the user and the modifications
/// to be saved for future use. (See gtk_accel_map_save().)
/// </para>
/// <para>
/// This function is a low level function that would most likely
/// be used by a menu creation system like #GtkUIManager. If you
/// use #GtkUIManager, setting up accelerator paths will be done
/// automatically.
/// </para>
/// <para>
/// Even when you you aren’t using #GtkUIManager, if you only want to
/// set up accelerators on menu items gtk_menu_item_set_accel_path()
/// provides a somewhat more convenient interface.
/// </para>
/// <para>
/// Note that @accel_path string will be stored in a #GQuark. Therefore, if you
/// pass a static string, you can save some memory by interning it first with
/// g_intern_static_string().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="accel_path">
/// path used to look up the accelerator
/// </param>
/// <param name="accel_group">
/// a #GtkAccelGroup.
/// </param>

	public static T SetAccelPath<T>(this T widget, string accel_path, MentorLake.Gtk.GtkAccelGroupHandle accel_group) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_accel_path(widget, accel_path, accel_group);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the widget’s allocation.  This should not be used
/// directly, but from within a widget’s size_allocate method.
/// </para>
/// <para>
/// The allocation set should be the “adjusted” or actual
/// allocation. If you’re implementing a #GtkContainer, you want to use
/// gtk_widget_size_allocate() instead of gtk_widget_set_allocation().
/// The GtkWidgetClass::adjust_size_allocation virtual method adjusts the
/// allocation inside gtk_widget_size_allocate() to create an adjusted
/// allocation.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="allocation">
/// a pointer to a #GtkAllocation to copy from
/// </param>

	public static T SetAllocation<T>(this T widget, MentorLake.Gtk.GtkAllocationHandle allocation) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_allocation(widget, allocation);
		return widget;
	}

/// <summary>
/// <para>
/// Sets whether the application intends to draw on the widget in
/// an #GtkWidget::draw handler.
/// </para>
/// <para>
/// This is a hint to the widget and does not affect the behavior of
/// the GTK+ core; many widgets ignore this flag entirely. For widgets
/// that do pay attention to the flag, such as #GtkEventBox and #GtkWindow,
/// the effect is to suppress default themed drawing of the widget&apos;s
/// background. (Children of the widget will still be drawn.) The application
/// is then entirely responsible for drawing the widget background.
/// </para>
/// <para>
/// Note that the background is still drawn when the widget is mapped.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="app_paintable">
/// %TRUE if the application will paint on the widget
/// </param>

	public static T SetAppPaintable<T>(this T widget, bool app_paintable) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_app_paintable(widget, app_paintable);
		return widget;
	}

/// <summary>
/// <para>
/// Specifies whether @widget can be a default widget. See
/// gtk_widget_grab_default() for details about the meaning of
/// “default”.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="can_default">
/// whether or not @widget can be a default widget.
/// </param>

	public static T SetCanDefault<T>(this T widget, bool can_default) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_can_default(widget, can_default);
		return widget;
	}

/// <summary>
/// <para>
/// Specifies whether @widget can own the input focus. See
/// gtk_widget_grab_focus() for actually setting the input focus on a
/// widget.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="can_focus">
/// whether or not @widget can own the input focus.
/// </param>

	public static T SetCanFocus<T>(this T widget, bool can_focus) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_can_focus(widget, can_focus);
		return widget;
	}

/// <summary>
/// <para>
/// Sets whether @widget should be mapped along with its when its parent
/// is mapped and @widget has been shown with gtk_widget_show().
/// </para>
/// <para>
/// The child visibility can be set for widget before it is added to
/// a container with gtk_widget_set_parent(), to avoid mapping
/// children unnecessary before immediately unmapping them. However
/// it will be reset to its default state of %TRUE when the widget
/// is removed from a container.
/// </para>
/// <para>
/// Note that changing the child visibility of a widget does not
/// queue a resize on the widget. Most of the time, the size of
/// a widget is computed from all visible children, whether or
/// not they are mapped. If this is not the case, the container
/// can queue a resize itself.
/// </para>
/// <para>
/// This function is only useful for container implementations and
/// never should be called by an application.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="is_visible">
/// if %TRUE, @widget should be mapped along with its parent.
/// </param>

	public static T SetChildVisible<T>(this T widget, bool is_visible) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_child_visible(widget, is_visible);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the widget’s clip.  This must not be used directly,
/// but from within a widget’s size_allocate method.
/// It must be called after gtk_widget_set_allocation() (or after chaining up
/// to the parent class), because that function resets the clip.
/// </para>
/// <para>
/// The clip set should be the area that @widget draws on. If @widget is a
/// #GtkContainer, the area must contain all children&apos;s clips.
/// </para>
/// <para>
/// If this function is not called by @widget during a ::size-allocate handler,
/// the clip will be set to @widget&apos;s allocation.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="clip">
/// a pointer to a #GtkAllocation to copy from
/// </param>

	public static T SetClip<T>(this T widget, MentorLake.Gtk.GtkAllocationHandle clip) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_clip(widget, clip);
		return widget;
	}

/// <summary>
/// <para>
/// Sets a widgets composite name. The widget must be
/// a composite child of its parent; see gtk_widget_push_composite_child().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget.
/// </param>
/// <param name="name">
/// the name to set
/// </param>

	public static T SetCompositeName<T>(this T widget, string name) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_composite_name(widget, name);
		return widget;
	}

/// <summary>
/// <para>
/// Enables or disables a #GdkDevice to interact with @widget
/// and all its children.
/// </para>
/// <para>
/// It does so by descending through the #GdkWindow hierarchy
/// and enabling the same mask that is has for core events
/// (i.e. the one that gdk_window_get_events() returns).
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="device">
/// a #GdkDevice
/// </param>
/// <param name="enabled">
/// whether to enable the device
/// </param>

	public static T SetDeviceEnabled<T>(this T widget, MentorLake.Gdk.GdkDeviceHandle device, bool enabled) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_device_enabled(widget, device, enabled);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the device event mask (see #GdkEventMask) for a widget. The event
/// mask determines which events a widget will receive from @device. Keep
/// in mind that different widgets have different default event masks, and by
/// changing the event mask you may disrupt a widget’s functionality,
/// so be careful. This function must be called while a widget is
/// unrealized. Consider gtk_widget_add_device_events() for widgets that are
/// already realized, or if you want to preserve the existing event
/// mask. This function can’t be used with windowless widgets (which return
/// %FALSE from gtk_widget_get_has_window());
/// to get events on those widgets, place them inside a #GtkEventBox
/// and receive events on the event box.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="device">
/// a #GdkDevice
/// </param>
/// <param name="events">
/// event mask
/// </param>

	public static T SetDeviceEvents<T>(this T widget, MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gdk.GdkEventMask events) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_device_events(widget, device, events);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the reading direction on a particular widget. This direction
/// controls the primary direction for widgets containing text,
/// and also the direction in which the children of a container are
/// packed. The ability to set the direction is present in order
/// so that correct localization into languages with right-to-left
/// reading directions can be done. Generally, applications will
/// let the default reading direction present, except for containers
/// where the containers are arranged in an order that is explicitly
/// visual rather than logical (such as buttons for text justification).
/// </para>
/// <para>
/// If the direction is set to %GTK_TEXT_DIR_NONE, then the value
/// set by gtk_widget_set_default_direction() will be used.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="dir">
/// the new direction
/// </param>

	public static T SetDirection<T>(this T widget, MentorLake.Gtk.GtkTextDirection dir) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_direction(widget, dir);
		return widget;
	}

/// <summary>
/// <para>
/// Widgets are double buffered by default; you can use this function
/// to turn off the buffering. “Double buffered” simply means that
/// gdk_window_begin_draw_frame() and gdk_window_end_draw_frame() are called
/// automatically around expose events sent to the
/// widget. gdk_window_begin_draw_frame() diverts all drawing to a widget&apos;s
/// window to an offscreen buffer, and gdk_window_end_draw_frame() draws the
/// buffer to the screen. The result is that users see the window
/// update in one smooth step, and don’t see individual graphics
/// primitives being rendered.
/// </para>
/// <para>
/// In very simple terms, double buffered widgets don’t flicker,
/// so you would only use this function to turn off double buffering
/// if you had special needs and really knew what you were doing.
/// </para>
/// <para>
/// Note: if you turn off double-buffering, you have to handle
/// expose events, since even the clearing to the background color or
/// pixmap will not happen automatically (as it is done in
/// gdk_window_begin_draw_frame()).
/// </para>
/// <para>
/// In 3.10 GTK and GDK have been restructured for translucent drawing. Since
/// then expose events for double-buffered widgets are culled into a single
/// event to the toplevel GDK window. If you now unset double buffering, you
/// will cause a separate rendering pass for every widget. This will likely
/// cause rendering problems - in particular related to stacking - and usually
/// increases rendering times significantly.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="double_buffered">
/// %TRUE to double-buffer a widget
/// </param>

	public static T SetDoubleBuffered<T>(this T widget, bool double_buffered) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_double_buffered(widget, double_buffered);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the event mask (see #GdkEventMask) for a widget. The event
/// mask determines which events a widget will receive. Keep in mind
/// that different widgets have different default event masks, and by
/// changing the event mask you may disrupt a widget’s functionality,
/// so be careful. This function must be called while a widget is
/// unrealized. Consider gtk_widget_add_events() for widgets that are
/// already realized, or if you want to preserve the existing event
/// mask. This function can’t be used with widgets that have no window.
/// (See gtk_widget_get_has_window()).  To get events on those widgets,
/// place them inside a #GtkEventBox and receive events on the event
/// box.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="events">
/// event mask
/// </param>

	public static T SetEvents<T>(this T widget, int events) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_events(widget, events);
		return widget;
	}

/// <summary>
/// <para>
/// Sets whether the widget should grab focus when it is clicked with the mouse.
/// Making mouse clicks not grab focus is useful in places like toolbars where
/// you don’t want the keyboard focus removed from the main area of the
/// application.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="focus_on_click">
/// whether the widget should grab focus when clicked with the mouse
/// </param>

	public static T SetFocusOnClick<T>(this T widget, bool focus_on_click) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_focus_on_click(widget, focus_on_click);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the font map to use for Pango rendering. When not set, the widget
/// will inherit the font map from its parent.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="font_map">
/// a #PangoFontMap, or %NULL to unset any previously
///     set font map
/// </param>

	public static T SetFontMap<T>(this T widget, MentorLake.Pango.PangoFontMapHandle font_map) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_font_map(widget, font_map);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the #cairo_font_options_t used for Pango rendering in this widget.
/// When not set, the default font options for the #GdkScreen will be used.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="options">
/// a #cairo_font_options_t, or %NULL to unset any
///   previously set default font options.
/// </param>

	public static T SetFontOptions<T>(this T widget, MentorLake.cairo.cairo_font_options_tHandle options) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_font_options(widget, options);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the horizontal alignment of @widget.
/// See the #GtkWidget:halign property.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="align">
/// the horizontal alignment
/// </param>

	public static T SetHalign<T>(this T widget, MentorLake.Gtk.GtkAlign align) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_halign(widget, align);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the has-tooltip property on @widget to @has_tooltip.  See
/// #GtkWidget:has-tooltip for more information.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="has_tooltip">
/// whether or not @widget has a tooltip.
/// </param>

	public static T SetHasTooltip<T>(this T widget, bool has_tooltip) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_has_tooltip(widget, has_tooltip);
		return widget;
	}

/// <summary>
/// <para>
/// Specifies whether @widget has a #GdkWindow of its own. Note that
/// all realized widgets have a non-%NULL “window” pointer
/// (gtk_widget_get_window() never returns a %NULL window when a widget
/// is realized), but for many of them it’s actually the #GdkWindow of
/// one of its parent widgets. Widgets that do not create a %window for
/// themselves in #GtkWidget::realize must announce this by
/// calling this function with @has_window = %FALSE.
/// </para>
/// <para>
/// This function should only be called by widget implementations,
/// and they should call it in their init() function.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="has_window">
/// whether or not @widget has a window.
/// </param>

	public static T SetHasWindow<T>(this T widget, bool has_window) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_has_window(widget, has_window);
		return widget;
	}

/// <summary>
/// <para>
/// Sets whether the widget would like any available extra horizontal
/// space. When a user resizes a #GtkWindow, widgets with expand=TRUE
/// generally receive the extra space. For example, a list or
/// scrollable area or document in your window would often be set to
/// expand.
/// </para>
/// <para>
/// Call this function to set the expand flag if you would like your
/// widget to become larger horizontally when the window has extra
/// room.
/// </para>
/// <para>
/// By default, widgets automatically expand if any of their children
/// want to expand. (To see if a widget will automatically expand given
/// its current children and state, call gtk_widget_compute_expand(). A
/// container can decide how the expandability of children affects the
/// expansion of the container by overriding the compute_expand virtual
/// method on #GtkWidget.).
/// </para>
/// <para>
/// Setting hexpand explicitly with this function will override the
/// automatic expand behavior.
/// </para>
/// <para>
/// This function forces the widget to expand or not to expand,
/// regardless of children.  The override occurs because
/// gtk_widget_set_hexpand() sets the hexpand-set property (see
/// gtk_widget_set_hexpand_set()) which causes the widget’s hexpand
/// value to be used, rather than looking at children and widget state.
/// </para>
/// </summary>

/// <param name="widget">
/// the widget
/// </param>
/// <param name="expand">
/// whether to expand
/// </param>

	public static T SetHexpand<T>(this T widget, bool expand) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_hexpand(widget, expand);
		return widget;
	}

/// <summary>
/// <para>
/// Sets whether the hexpand flag (see gtk_widget_get_hexpand()) will
/// be used.
/// </para>
/// <para>
/// The hexpand-set property will be set automatically when you call
/// gtk_widget_set_hexpand() to set hexpand, so the most likely
/// reason to use this function would be to unset an explicit expand
/// flag.
/// </para>
/// <para>
/// If hexpand is set, then it overrides any computed
/// expand value based on child widgets. If hexpand is not
/// set, then the expand value depends on whether any
/// children of the widget would like to expand.
/// </para>
/// <para>
/// There are few reasons to use this function, but it’s here
/// for completeness and consistency.
/// </para>
/// </summary>

/// <param name="widget">
/// the widget
/// </param>
/// <param name="set">
/// value for hexpand-set property
/// </param>

	public static T SetHexpandSet<T>(this T widget, bool set) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_hexpand_set(widget, set);
		return widget;
	}

/// <summary>
/// <para>
/// Marks the widget as being mapped.
/// </para>
/// <para>
/// This function should only ever be called in a derived widget&apos;s
/// “map” or “unmap” implementation.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="mapped">
/// %TRUE to mark the widget as mapped
/// </param>

	public static T SetMapped<T>(this T widget, bool mapped) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_mapped(widget, mapped);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the bottom margin of @widget.
/// See the #GtkWidget:margin-bottom property.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="margin">
/// the bottom margin
/// </param>

	public static T SetMarginBottom<T>(this T widget, int margin) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_margin_bottom(widget, margin);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the end margin of @widget.
/// See the #GtkWidget:margin-end property.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="margin">
/// the end margin
/// </param>

	public static T SetMarginEnd<T>(this T widget, int margin) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_margin_end(widget, margin);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the left margin of @widget.
/// See the #GtkWidget:margin-left property.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="margin">
/// the left margin
/// </param>

	public static T SetMarginLeft<T>(this T widget, int margin) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_margin_left(widget, margin);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the right margin of @widget.
/// See the #GtkWidget:margin-right property.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="margin">
/// the right margin
/// </param>

	public static T SetMarginRight<T>(this T widget, int margin) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_margin_right(widget, margin);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the start margin of @widget.
/// See the #GtkWidget:margin-start property.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="margin">
/// the start margin
/// </param>

	public static T SetMarginStart<T>(this T widget, int margin) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_margin_start(widget, margin);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the top margin of @widget.
/// See the #GtkWidget:margin-top property.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="margin">
/// the top margin
/// </param>

	public static T SetMarginTop<T>(this T widget, int margin) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_margin_top(widget, margin);
		return widget;
	}

/// <summary>
/// <para>
/// Widgets can be named, which allows you to refer to them from a
/// CSS file. You can apply a style to widgets with a particular name
/// in the CSS file. See the documentation for the CSS syntax (on the
/// same page as the docs for #GtkStyleContext).
/// </para>
/// <para>
/// Note that the CSS syntax has certain special characters to delimit
/// and represent elements in a selector (period, #, &amp;gt;, *...), so using
/// these will make your widget impossible to match by name. Any combination
/// of alphanumeric symbols, dashes and underscores will suffice.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="name">
/// name for the widget
/// </param>

	public static T SetName<T>(this T widget, string name) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_name(widget, name);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the #GtkWidget:no-show-all property, which determines whether
/// calls to gtk_widget_show_all() will affect this widget.
/// </para>
/// <para>
/// This is mostly for use in constructing widget hierarchies with externally
/// controlled visibility, see #GtkUIManager.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="no_show_all">
/// the new value for the “no-show-all” property
/// </param>

	public static T SetNoShowAll<T>(this T widget, bool no_show_all) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_no_show_all(widget, no_show_all);
		return widget;
	}

/// <summary>
/// <para>
/// Request the @widget to be rendered partially transparent,
/// with opacity 0 being fully transparent and 1 fully opaque. (Opacity values
/// are clamped to the [0,1] range.).
/// This works on both toplevel widget, and child widgets, although there
/// are some limitations:
/// </para>
/// <para>
/// For toplevel widgets this depends on the capabilities of the windowing
/// system. On X11 this has any effect only on X screens with a compositing manager
/// running. See gtk_widget_is_composited(). On Windows it should work
/// always, although setting a window’s opacity after the window has been
/// shown causes it to flicker once on Windows.
/// </para>
/// <para>
/// For child widgets it doesn’t work if any affected widget has a native window, or
/// disables double buffering.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="opacity">
/// desired opacity, between 0 and 1
/// </param>

	public static T SetOpacity<T>(this T widget, double opacity) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_opacity(widget, opacity);
		return widget;
	}

/// <summary>
/// <para>
/// This function is useful only when implementing subclasses of
/// #GtkContainer.
/// Sets the container as the parent of @widget, and takes care of
/// some details such as updating the state and style of the child
/// to reflect its new location. The opposite function is
/// gtk_widget_unparent().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="parent">
/// parent container
/// </param>

	public static T SetParent<T>(this T widget, MentorLake.Gtk.GtkWidgetHandle parent) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_parent(widget, parent);
		return widget;
	}

/// <summary>
/// <para>
/// Sets a non default parent window for @widget.
/// </para>
/// <para>
/// For #GtkWindow classes, setting a @parent_window effects whether
/// the window is a toplevel window or can be embedded into other
/// widgets.
/// </para>
/// <para>
/// For #GtkWindow classes, this needs to be called before the
/// window is realized.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget.
/// </param>
/// <param name="parent_window">
/// the new parent window.
/// </param>

	public static T SetParentWindow<T>(this T widget, MentorLake.Gdk.GdkWindowHandle parent_window) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_parent_window(widget, parent_window);
		return widget;
	}

/// <summary>
/// <para>
/// Marks the widget as being realized. This function must only be
/// called after all #GdkWindows for the @widget have been created
/// and registered.
/// </para>
/// <para>
/// This function should only ever be called in a derived widget&apos;s
/// “realize” or “unrealize” implementation.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="realized">
/// %TRUE to mark the widget as realized
/// </param>

	public static T SetRealized<T>(this T widget, bool realized) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_realized(widget, realized);
		return widget;
	}

/// <summary>
/// <para>
/// Specifies whether @widget will be treated as the default widget
/// within its toplevel when it has the focus, even if another widget
/// is the default.
/// </para>
/// <para>
/// See gtk_widget_grab_default() for details about the meaning of
/// “default”.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="receives_default">
/// whether or not @widget can be a default widget.
/// </param>

	public static T SetReceivesDefault<T>(this T widget, bool receives_default) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_receives_default(widget, receives_default);
		return widget;
	}

/// <summary>
/// <para>
/// Sets whether the entire widget is queued for drawing when its size
/// allocation changes. By default, this setting is %TRUE and
/// the entire widget is redrawn on every size change. If your widget
/// leaves the upper left unchanged when made bigger, turning this
/// setting off will improve performance.
/// </para>
/// <para>
/// Note that for widgets where gtk_widget_get_has_window() is %FALSE
/// setting this flag to %FALSE turns off all allocation on resizing:
/// the widget will not even redraw if its position changes; this is to
/// allow containers that don’t draw anything to avoid excess
/// invalidations. If you set this flag on a widget with no window that
/// does draw on @widget-&amp;gt;window, you are
/// responsible for invalidating both the old and new allocation of the
/// widget when the widget is moved and responsible for invalidating
/// regions newly when the widget increases size.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="redraw_on_allocate">
/// if %TRUE, the entire widget will be redrawn
///   when it is allocated to a new size. Otherwise, only the
///   new portion of the widget will be redrawn.
/// </param>

	public static T SetRedrawOnAllocate<T>(this T widget, bool redraw_on_allocate) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_redraw_on_allocate(widget, redraw_on_allocate);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the sensitivity of a widget. A widget is sensitive if the user
/// can interact with it. Insensitive widgets are “grayed out” and the
/// user can’t interact with them. Insensitive widgets are known as
/// “inactive”, “disabled”, or “ghosted” in some other toolkits.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="sensitive">
/// %TRUE to make the widget sensitive
/// </param>

	public static T SetSensitive<T>(this T widget, bool sensitive) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_sensitive(widget, sensitive);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the minimum size of a widget; that is, the widget’s size
/// request will be at least @width by @height. You can use this
/// function to force a widget to be larger than it normally would be.
/// </para>
/// <para>
/// In most cases, gtk_window_set_default_size() is a better choice for
/// toplevel windows than this function; setting the default size will
/// still allow users to shrink the window. Setting the size request
/// will force them to leave the window at least as large as the size
/// request. When dealing with window sizes,
/// gtk_window_set_geometry_hints() can be a useful function as well.
/// </para>
/// <para>
/// Note the inherent danger of setting any fixed size - themes,
/// translations into other languages, different fonts, and user action
/// can all change the appropriate size for a given widget. So, it&apos;s
/// basically impossible to hardcode a size that will always be
/// correct.
/// </para>
/// <para>
/// The size request of a widget is the smallest size a widget can
/// accept while still functioning well and drawing itself correctly.
/// However in some strange cases a widget may be allocated less than
/// its requested size, and in many cases a widget may be allocated more
/// space than it requested.
/// </para>
/// <para>
/// If the size request in a given direction is -1 (unset), then
/// the “natural” size request of the widget will be used instead.
/// </para>
/// <para>
/// The size request set here does not include any margin from the
/// #GtkWidget properties margin-left, margin-right, margin-top, and
/// margin-bottom, but it does include pretty much all other padding
/// or border properties set by any subclass of #GtkWidget.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="width">
/// width @widget should request, or -1 to unset
/// </param>
/// <param name="height">
/// height @widget should request, or -1 to unset
/// </param>

	public static T SetSizeRequest<T>(this T widget, int width, int height) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_size_request(widget, width, height);
		return widget;
	}

/// <summary>
/// <para>
/// This function is for use in widget implementations. Sets the state
/// of a widget (insensitive, prelighted, etc.) Usually you should set
/// the state using wrapper functions such as gtk_widget_set_sensitive().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="state">
/// new state for @widget
/// </param>

	public static T SetState<T>(this T widget, MentorLake.Gtk.GtkStateType state) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_state(widget, state);
		return widget;
	}

/// <summary>
/// <para>
/// This function is for use in widget implementations. Turns on flag
/// values in the current widget state (insensitive, prelighted, etc.).
/// </para>
/// <para>
/// This function accepts the values %GTK_STATE_FLAG_DIR_LTR and
/// %GTK_STATE_FLAG_DIR_RTL but ignores them. If you want to set the widget&apos;s
/// direction, use gtk_widget_set_direction().
/// </para>
/// <para>
/// It is worth mentioning that any other state than %GTK_STATE_FLAG_INSENSITIVE,
/// will be propagated down to all non-internal children if @widget is a
/// #GtkContainer, while %GTK_STATE_FLAG_INSENSITIVE itself will be propagated
/// down to all #GtkContainer children by different means than turning on the
/// state flag down the hierarchy, both gtk_widget_get_state_flags() and
/// gtk_widget_is_sensitive() will make use of these.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="flags">
/// State flags to turn on
/// </param>
/// <param name="clear">
/// Whether to clear state before turning on @flags
/// </param>

	public static T SetStateFlags<T>(this T widget, MentorLake.Gtk.GtkStateFlags flags, bool clear) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_state_flags(widget, flags, clear);
		return widget;
	}

/// <summary>
/// <para>
/// Used to set the #GtkStyle for a widget (@widget-&amp;gt;style). Since
/// GTK 3, this function does nothing, the passed in style is ignored.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="style">
/// a #GtkStyle, or %NULL to remove the effect
///     of a previous call to gtk_widget_set_style() and go back to
///     the default style
/// </param>

	public static T SetStyle<T>(this T widget, MentorLake.Gtk.GtkStyleHandle style) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_style(widget, style);
		return widget;
	}

/// <summary>
/// <para>
/// Enables or disables multiple pointer awareness. If this setting is %TRUE,
/// @widget will start receiving multiple, per device enter/leave events. Note
/// that if custom #GdkWindows are created in #GtkWidget::realize,
/// gdk_window_set_support_multidevice() will have to be called manually on them.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="support_multidevice">
/// %TRUE to support input from multiple devices.
/// </param>

	public static T SetSupportMultidevice<T>(this T widget, bool support_multidevice) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_support_multidevice(widget, support_multidevice);
		return widget;
	}

/// <summary>
/// <para>
/// Sets @markup as the contents of the tooltip, which is marked up with
///  the [Pango text markup language][PangoMarkupFormat].
/// </para>
/// <para>
/// This function will take care of setting #GtkWidget:has-tooltip to %TRUE
/// and of the default handler for the #GtkWidget::query-tooltip signal.
/// </para>
/// <para>
/// See also the #GtkWidget:tooltip-markup property and
/// gtk_tooltip_set_markup().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="markup">
/// the contents of the tooltip for @widget, or %NULL
/// </param>

	public static T SetTooltipMarkup<T>(this T widget, string markup) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_tooltip_markup(widget, markup);
		return widget;
	}

/// <summary>
/// <para>
/// Sets @text as the contents of the tooltip. This function will take
/// care of setting #GtkWidget:has-tooltip to %TRUE and of the default
/// handler for the #GtkWidget::query-tooltip signal.
/// </para>
/// <para>
/// See also the #GtkWidget:tooltip-text property and gtk_tooltip_set_text().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="text">
/// the contents of the tooltip for @widget
/// </param>

	public static T SetTooltipText<T>(this T widget, string text) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_tooltip_text(widget, text);
		return widget;
	}

/// <summary>
/// <para>
/// Replaces the default window used for displaying
/// tooltips with @custom_window. GTK+ will take care of showing and
/// hiding @custom_window at the right moment, to behave likewise as
/// the default tooltip window. If @custom_window is %NULL, the default
/// tooltip window will be used.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="custom_window">
/// a #GtkWindow, or %NULL
/// </param>

	public static T SetTooltipWindow<T>(this T widget, MentorLake.Gtk.GtkWindowHandle custom_window) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_tooltip_window(widget, custom_window);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the vertical alignment of @widget.
/// See the #GtkWidget:valign property.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="align">
/// the vertical alignment
/// </param>

	public static T SetValign<T>(this T widget, MentorLake.Gtk.GtkAlign align) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_valign(widget, align);
		return widget;
	}

/// <summary>
/// <para>
/// Sets whether the widget would like any available extra vertical
/// space.
/// </para>
/// <para>
/// See gtk_widget_set_hexpand() for more detail.
/// </para>
/// </summary>

/// <param name="widget">
/// the widget
/// </param>
/// <param name="expand">
/// whether to expand
/// </param>

	public static T SetVexpand<T>(this T widget, bool expand) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_vexpand(widget, expand);
		return widget;
	}

/// <summary>
/// <para>
/// Sets whether the vexpand flag (see gtk_widget_get_vexpand()) will
/// be used.
/// </para>
/// <para>
/// See gtk_widget_set_hexpand_set() for more detail.
/// </para>
/// </summary>

/// <param name="widget">
/// the widget
/// </param>
/// <param name="set">
/// value for vexpand-set property
/// </param>

	public static T SetVexpandSet<T>(this T widget, bool set) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_vexpand_set(widget, set);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the visibility state of @widget. Note that setting this to
/// %TRUE doesn’t mean the widget is actually viewable, see
/// gtk_widget_get_visible().
/// </para>
/// <para>
/// This function simply calls gtk_widget_show() or gtk_widget_hide()
/// but is nicer to use when the visibility of the widget depends on
/// some condition.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="visible">
/// whether the widget should be shown or not
/// </param>

	public static T SetVisible<T>(this T widget, bool visible) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_visible(widget, visible);
		return widget;
	}

/// <summary>
/// <para>
/// Sets the visual that should be used for by widget and its children for
/// creating #GdkWindows. The visual must be on the same #GdkScreen as
/// returned by gtk_widget_get_screen(), so handling the
/// #GtkWidget::screen-changed signal is necessary.
/// </para>
/// <para>
/// Setting a new @visual will not cause @widget to recreate its windows,
/// so you should call this function before @widget is realized.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="visual">
/// visual to be used or %NULL to unset a previous one
/// </param>

	public static T SetVisual<T>(this T widget, MentorLake.Gdk.GdkVisualHandle visual) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_visual(widget, visual);
		return widget;
	}

/// <summary>
/// <para>
/// Sets a widget’s window. This function should only be used in a
/// widget’s #GtkWidget::realize implementation. The %window passed is
/// usually either new window created with gdk_window_new(), or the
/// window of its parent widget as returned by
/// gtk_widget_get_parent_window().
/// </para>
/// <para>
/// Widgets must indicate whether they will create their own #GdkWindow
/// by calling gtk_widget_set_has_window(). This is usually done in the
/// widget’s init() function.
/// </para>
/// <para>
/// Note that this function does not add any reference to @window.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="window">
/// a #GdkWindow
/// </param>

	public static T SetWindow<T>(this T widget, MentorLake.Gdk.GdkWindowHandle window) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_window(widget, window);
		return widget;
	}

/// <summary>
/// <para>
/// Sets a shape for this widget’s GDK window. This allows for
/// transparent windows etc., see gdk_window_shape_combine_region()
/// for more information.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="region">
/// shape to be added, or %NULL to remove an existing shape
/// </param>

	public static T ShapeCombineRegion<T>(this T widget, MentorLake.cairo.cairo_region_tHandle region) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_shape_combine_region(widget, region);
		return widget;
	}

/// <summary>
/// <para>
/// Flags a widget to be displayed. Any widget that isn’t shown will
/// not appear on the screen. If you want to show all the widgets in a
/// container, it’s easier to call gtk_widget_show_all() on the
/// container, instead of individually showing the widgets.
/// </para>
/// <para>
/// Remember that you have to show the containers containing a widget,
/// in addition to the widget itself, before it will appear onscreen.
/// </para>
/// <para>
/// When a toplevel container is shown, it is immediately realized and
/// mapped; other shown widgets are realized and mapped when their
/// toplevel container is realized and mapped.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T Show<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_show(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Recursively shows a widget, and any child widgets (if the widget is
/// a container).
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T ShowAll<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_show_all(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Shows a widget. If the widget is an unmapped toplevel widget
/// (i.e. a #GtkWindow that has not yet been shown), enter the main
/// loop and wait for the window to actually be mapped. Be careful;
/// because the main loop is running, anything can happen during
/// this function.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T ShowNow<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_show_now(widget);
		return widget;
	}

/// <summary>
/// <para>
/// This function is only used by #GtkContainer subclasses, to assign a size
/// and position to their child widgets.
/// </para>
/// <para>
/// In this function, the allocation may be adjusted. It will be forced
/// to a 1x1 minimum size, and the adjust_size_allocation virtual
/// method on the child will be used to adjust the allocation. Standard
/// adjustments include removing the widget’s margins, and applying the
/// widget’s #GtkWidget:halign and #GtkWidget:valign properties.
/// </para>
/// <para>
/// For baseline support in containers you need to use gtk_widget_size_allocate_with_baseline()
/// instead.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="allocation">
/// position and size to be allocated to @widget
/// </param>

	public static T SizeAllocate<T>(this T widget, MentorLake.Gtk.GtkAllocationHandle allocation) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_size_allocate(widget, allocation);
		return widget;
	}

/// <summary>
/// <para>
/// This function is only used by #GtkContainer subclasses, to assign a size,
/// position and (optionally) baseline to their child widgets.
/// </para>
/// <para>
/// In this function, the allocation and baseline may be adjusted. It
/// will be forced to a 1x1 minimum size, and the
/// adjust_size_allocation virtual and adjust_baseline_allocation
/// methods on the child will be used to adjust the allocation and
/// baseline. Standard adjustments include removing the widget&apos;s
/// margins, and applying the widget’s #GtkWidget:halign and
/// #GtkWidget:valign properties.
/// </para>
/// <para>
/// If the child widget does not have a valign of %GTK_ALIGN_BASELINE the
/// baseline argument is ignored and -1 is used instead.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="allocation">
/// position and size to be allocated to @widget
/// </param>
/// <param name="baseline">
/// The baseline of the child, or -1
/// </param>

	public static T SizeAllocateWithBaseline<T>(this T widget, MentorLake.Gtk.GtkAllocationHandle allocation, int baseline) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_size_allocate_with_baseline(widget, allocation, baseline);
		return widget;
	}

/// <summary>
/// <para>
/// This function is typically used when implementing a #GtkContainer
/// subclass.  Obtains the preferred size of a widget. The container
/// uses this information to arrange its child widgets and decide what
/// size allocations to give them with gtk_widget_size_allocate().
/// </para>
/// <para>
/// You can also call this function from an application, with some
/// caveats. Most notably, getting a size request requires the widget
/// to be associated with a screen, because font information may be
/// needed. Multihead-aware applications should keep this in mind.
/// </para>
/// <para>
/// Also remember that the size request is not necessarily the size
/// a widget will actually be allocated.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="requisition">
/// a #GtkRequisition to be filled in
/// </param>

	public static T SizeRequest<T>(this T widget, out MentorLake.Gtk.GtkRequisition requisition) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_size_request(widget, out requisition);
		return widget;
	}

/// <summary>
/// <para>
/// This function attaches the widget’s #GtkStyle to the widget&apos;s
/// #GdkWindow. It is a replacement for
/// </para>
/// <code>
/// widget-&amp;gt;style = gtk_style_attach (widget-&amp;gt;style, widget-&amp;gt;window);
/// widget-&amp;gt;style = gtk_style_attach (widget-&amp;gt;style, widget-&amp;gt;window);
/// </code>
/// <para>
/// and should only ever be called in a derived widget’s “realize”
/// implementation which does not chain up to its parent class&apos;
/// “realize” implementation, because one of the parent classes
/// (finally #GtkWidget) would attach the style itself.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T StyleAttach<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_style_attach(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Gets the values of a multiple style properties of @widget.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="first_property_name">
/// the name of the first property to get
/// </param>
/// <param name="@__arglist">
/// pairs of property names and locations to return the
///     property values, starting with the location for
///     @first_property_name, terminated by %NULL.
/// </param>

	public static T StyleGet<T>(this T widget, string first_property_name, IntPtr @__arglist) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_style_get(widget, first_property_name, @__arglist);
		return widget;
	}

/// <summary>
/// <para>
/// Gets the value of a style property of @widget.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="property_name">
/// the name of a style property
/// </param>
/// <param name="value">
/// location to return the property value
/// </param>

	public static T StyleGetProperty<T>(this T widget, string property_name, out MentorLake.GObject.GValue value) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_style_get_property(widget, property_name, out value);
		return widget;
	}

/// <summary>
/// <para>
/// Non-vararg variant of gtk_widget_style_get(). Used primarily by language
/// bindings.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="first_property_name">
/// the name of the first property to get
/// </param>
/// <param name="var_args">
/// a va_list of pairs of property names and
///     locations to return the property values, starting with the location
///     for @first_property_name.
/// </param>

	public static T StyleGetValist<T>(this T widget, string first_property_name, IntPtr var_args) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_style_get_valist(widget, first_property_name, var_args);
		return widget;
	}

/// <summary>
/// <para>
/// Reverts the effect of a previous call to gtk_widget_freeze_child_notify().
/// This causes all queued #GtkWidget::child-notify signals on @widget to be
/// emitted.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T ThawChildNotify<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_thaw_child_notify(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Translate coordinates relative to @src_widget’s allocation to coordinates
/// relative to @dest_widget’s allocations. In order to perform this
/// operation, both widgets must be realized, and must share a common
/// toplevel.
/// </para>
/// </summary>

/// <param name="src_widget">
/// a #GtkWidget
/// </param>
/// <param name="dest_widget">
/// a #GtkWidget
/// </param>
/// <param name="src_x">
/// X position relative to @src_widget
/// </param>
/// <param name="src_y">
/// Y position relative to @src_widget
/// </param>
/// <param name="dest_x">
/// location to store X position relative to @dest_widget
/// </param>
/// <param name="dest_y">
/// location to store Y position relative to @dest_widget
/// </param>
/// <return>
/// %FALSE if either widget was not realized, or there
///   was no common ancestor. In this case, nothing is stored in
///   *@dest_x and *@dest_y. Otherwise %TRUE.
/// </return>

	public static bool TranslateCoordinates(this MentorLake.Gtk.GtkWidgetHandle src_widget, MentorLake.Gtk.GtkWidgetHandle dest_widget, int src_x, int src_y, out int dest_x, out int dest_y)
	{
		if (src_widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_translate_coordinates(src_widget, dest_widget, src_x, src_y, out dest_x, out dest_y);
	}

/// <summary>
/// <para>
/// Triggers a tooltip query on the display where the toplevel of @widget
/// is located. See gtk_tooltip_trigger_tooltip_query() for more
/// information.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T TriggerTooltipQuery<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_trigger_tooltip_query(widget);
		return widget;
	}

/// <summary>
/// <para>
/// This function is only for use in widget implementations. Causes
/// a widget to be unmapped if it’s currently mapped.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T Unmap<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_unmap(widget);
		return widget;
	}

/// <summary>
/// <para>
/// This function is only for use in widget implementations.
/// Should be called by implementations of the remove method
/// on #GtkContainer, to dissociate a child from the container.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T Unparent<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_unparent(widget);
		return widget;
	}

/// <summary>
/// <para>
/// This function is only useful in widget implementations.
/// Causes a widget to be unrealized (frees all GDK resources
/// associated with the widget, such as @widget-&amp;gt;window).
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static T Unrealize<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_unrealize(widget);
		return widget;
	}

/// <summary>
/// <para>
/// Unregisters a #GdkWindow from the widget that was previously set up with
/// gtk_widget_register_window(). You need to call this when the window is
/// no longer used by the widget, such as when you destroy it.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="window">
/// a #GdkWindow
/// </param>

	public static T UnregisterWindow<T>(this T widget, MentorLake.Gdk.GdkWindowHandle window) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_unregister_window(widget, window);
		return widget;
	}

/// <summary>
/// <para>
/// This function is for use in widget implementations. Turns off flag
/// values for the current widget state (insensitive, prelighted, etc.).
/// See gtk_widget_set_state_flags().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="flags">
/// State flags to turn off
/// </param>

	public static T UnsetStateFlags<T>(this T widget, MentorLake.Gtk.GtkStateFlags flags) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_unset_state_flags(widget, flags);
		return widget;
	}

}

internal class GtkWidgetHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_widget_new(MentorLake.GObject.GType type, string first_property_name, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_add_accelerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string accel_signal, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods, MentorLake.Gtk.GtkAccelFlags accel_flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_add_device_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gdk.GdkEventMask events);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_add_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int events);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_add_mnemonic_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_widget_add_tick_callback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkTickCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_can_activate_accel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, uint signal_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_child_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkDirectionType direction);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_child_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string child_property);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_class_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out uint path_length, out string path, out string path_reversed);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_compute_expand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkOrientation orientation);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))]
	internal static extern MentorLake.Pango.PangoContextHandle gtk_widget_create_pango_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))]
	internal static extern MentorLake.Pango.PangoLayoutHandle gtk_widget_create_pango_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_destroyed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] ref MentorLake.Gtk.GtkWidgetHandle widget_pointer);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_device_is_shadowed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))]
	internal static extern MentorLake.Gdk.GdkDragContextHandle gtk_drag_begin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle targets, MentorLake.Gdk.GdkDragAction actions, int button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))]
	internal static extern MentorLake.Gdk.GdkDragContextHandle gtk_drag_begin_with_coordinates([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle targets, MentorLake.Gdk.GdkDragAction actions, int button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, int x, int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_drag_check_threshold([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int start_x, int start_y, int current_x, int current_y);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_dest_add_image_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_dest_add_text_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_dest_add_uri_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkAtom gtk_drag_dest_find_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle target_list);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))]
	internal static extern MentorLake.Gtk.GtkTargetListHandle gtk_drag_dest_get_target_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_drag_dest_get_track_motion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_dest_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkDestDefaults flags, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets, MentorLake.Gdk.GdkDragAction actions);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_dest_set_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle proxy_window, MentorLake.Gdk.GdkDragProtocol protocol, bool use_coordinates);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_dest_set_target_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle target_list);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_dest_set_track_motion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool track_motion);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_dest_unset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_get_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, MentorLake.Gdk.GdkAtom target, uint time_);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_highlight([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_source_add_image_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_source_add_text_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_source_add_uri_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))]
	internal static extern MentorLake.Gtk.GtkTargetListHandle gtk_drag_source_get_target_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_source_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkModifierType start_button_mask, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets, MentorLake.Gdk.GdkDragAction actions);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_source_set_icon_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_source_set_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string icon_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_source_set_icon_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_source_set_icon_stock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_source_set_target_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle target_list);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_source_unset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_unhighlight([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_draw([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_ensure_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_error_bell([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_freeze_child_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))]
	internal static extern MentorLake.Atk.AtkObjectHandle gtk_widget_get_accessible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))]
	internal static extern MentorLake.Gio.GActionGroupHandle gtk_widget_get_action_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string prefix);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_get_allocated_baseline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_get_allocated_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_allocated_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out MentorLake.Gtk.GtkAllocation allocation, out int baseline);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_get_allocated_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_allocation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out MentorLake.Gtk.GtkAllocation allocation);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_widget_get_ancestor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.GObject.GType widget_type);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_app_paintable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_can_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_can_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_child_requisition([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out MentorLake.Gtk.GtkRequisition requisition);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_child_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_clip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out MentorLake.Gtk.GtkAllocation clip);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))]
	internal static extern MentorLake.Gtk.GtkClipboardHandle gtk_widget_get_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkAtom selection);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_widget_get_composite_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_device_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkEventMask gtk_widget_get_device_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTextDirection gtk_widget_get_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))]
	internal static extern MentorLake.Gdk.GdkDisplayHandle gtk_widget_get_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_double_buffered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_get_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_focus_on_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))]
	internal static extern MentorLake.Pango.PangoFontMapHandle gtk_widget_get_font_map([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))]
	internal static extern MentorLake.cairo.cairo_font_options_tHandle gtk_widget_get_font_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))]
	internal static extern MentorLake.Gdk.GdkFrameClockHandle gtk_widget_get_frame_clock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAlign gtk_widget_get_halign([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_has_tooltip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_has_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_hexpand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_hexpand_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_mapped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_get_margin_bottom([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_get_margin_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_get_margin_left([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_get_margin_right([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_get_margin_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_get_margin_top([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkModifierType gtk_widget_get_modifier_mask([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkModifierIntent intent);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRcStyleHandle>))]
	internal static extern MentorLake.Gtk.GtkRcStyleHandle gtk_widget_get_modifier_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_widget_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_no_show_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_widget_get_opacity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))]
	internal static extern MentorLake.Pango.PangoContextHandle gtk_widget_get_pango_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_widget_get_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gtk_widget_get_parent_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetPathHandle gtk_widget_get_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out int x, out int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_preferred_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out int minimum_height, out int natural_height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_preferred_height_and_baseline_for_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height, out int minimum_baseline, out int natural_baseline);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_preferred_height_for_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_preferred_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out MentorLake.Gtk.GtkRequisition minimum_size, out MentorLake.Gtk.GtkRequisition natural_size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_preferred_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out int minimum_width, out int natural_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_preferred_width_for_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int height, out int minimum_width, out int natural_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_realized([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_receives_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSizeRequestMode gtk_widget_get_request_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_requisition([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out MentorLake.Gtk.GtkRequisition requisition);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gtk_widget_get_root_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_get_scale_factor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))]
	internal static extern MentorLake.Gdk.GdkScreenHandle gtk_widget_get_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSettingsHandle>))]
	internal static extern MentorLake.Gtk.GtkSettingsHandle gtk_widget_get_settings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_size_request([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out int width, out int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStateType gtk_widget_get_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStateFlags gtk_widget_get_state_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))]
	internal static extern MentorLake.Gtk.GtkStyleHandle gtk_widget_get_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))]
	internal static extern MentorLake.Gtk.GtkStyleContextHandle gtk_widget_get_style_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_support_multidevice([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle gtk_widget_get_template_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.GObject.GType widget_type, string name);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_widget_get_tooltip_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_widget_get_tooltip_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))]
	internal static extern MentorLake.Gtk.GtkWindowHandle gtk_widget_get_tooltip_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_widget_get_toplevel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAlign gtk_widget_get_valign([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAlign gtk_widget_get_valign_with_baseline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_vexpand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_vexpand_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkVisualHandle>))]
	internal static extern MentorLake.Gdk.GdkVisualHandle gtk_widget_get_visual([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gtk_widget_get_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_grab_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_grab_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_grab_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_grab_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_has_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_has_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_has_grab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_has_rc_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_has_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_has_visible_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_hide([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_hide_on_delete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_in_destruction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_init_template([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_input_shape_combine_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_insert_action_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle group);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_intersect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle area, out MentorLake.Gdk.GdkRectangle intersection);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_is_ancestor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle ancestor);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_is_composited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_is_drawable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_is_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_is_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_is_toplevel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_is_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_keynav_failed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkDirectionType direction);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_widget_list_accel_closures([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] gtk_widget_list_action_prefixes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_widget_list_mnemonic_labels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_map([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_mnemonic_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool group_cycling);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_modify_base([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkStateType state, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_modify_bg([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkStateType state, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_modify_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle primary, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle secondary);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_modify_fg([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkStateType state, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_modify_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle font_desc);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_modify_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRcStyleHandle>))] MentorLake.Gtk.GtkRcStyleHandle style);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_modify_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkStateType state, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_override_background_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkStateFlags state, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_override_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkStateFlags state, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_override_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle cursor, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle secondary_cursor);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_override_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle font_desc);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_override_symbolic_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out uint path_length, out string path, out string path_reversed);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_queue_allocate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_queue_compute_expand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_queue_draw([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_queue_draw_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int x, int y, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_queue_draw_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_queue_resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_queue_resize_no_redraw([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_realize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))]
	internal static extern MentorLake.cairo.cairo_region_tHandle gtk_widget_region_intersect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_register_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_remove_accelerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_remove_mnemonic_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_remove_tick_callback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, uint id);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_widget_render_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string stock_id, MentorLake.Gtk.GtkIconSize size, string detail);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_widget_render_icon_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string stock_id, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_reparent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle new_parent);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_reset_rc_styles([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_reset_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_send_expose([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_send_focus_change([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_accel_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string accel_path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_allocation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAllocationHandle>))] MentorLake.Gtk.GtkAllocationHandle allocation);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_app_paintable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool app_paintable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_can_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool can_default);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_can_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool can_focus);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_child_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool is_visible);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_clip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAllocationHandle>))] MentorLake.Gtk.GtkAllocationHandle clip);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_composite_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_device_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, bool enabled);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_device_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gdk.GdkEventMask events);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkTextDirection dir);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_double_buffered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool double_buffered);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int events);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_focus_on_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool focus_on_click);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_font_map([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle font_map);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_font_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_halign([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkAlign align);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_has_tooltip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool has_tooltip);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_has_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool has_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_hexpand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool expand);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_hexpand_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool set);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_mapped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool mapped);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_margin_bottom([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int margin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_margin_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int margin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_margin_left([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int margin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_margin_right([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int margin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_margin_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int margin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_margin_top([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int margin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_no_show_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool no_show_all);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_opacity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, double opacity);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle parent);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_parent_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle parent_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_realized([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool realized);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_receives_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool receives_default);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_redraw_on_allocate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool redraw_on_allocate);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool sensitive);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_size_request([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkStateType state);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_state_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkStateFlags flags, bool clear);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_support_multidevice([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool support_multidevice);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_tooltip_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string markup);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_tooltip_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_tooltip_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle custom_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_valign([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkAlign align);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_vexpand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool expand);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_vexpand_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool set);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool visible);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_visual([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkVisualHandle>))] MentorLake.Gdk.GdkVisualHandle visual);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_shape_combine_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_show([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_show_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_show_now([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_size_allocate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAllocationHandle>))] MentorLake.Gtk.GtkAllocationHandle allocation);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_size_allocate_with_baseline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAllocationHandle>))] MentorLake.Gtk.GtkAllocationHandle allocation, int baseline);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_size_request([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out MentorLake.Gtk.GtkRequisition requisition);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_style_attach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_style_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string first_property_name, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_style_get_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string property_name, out MentorLake.GObject.GValue value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_style_get_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string first_property_name, IntPtr var_args);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_thaw_child_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_translate_coordinates([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle src_widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle dest_widget, int src_x, int src_y, out int dest_x, out int dest_y);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_trigger_tooltip_query([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_unmap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_unparent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_unrealize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_unregister_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_unset_state_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkStateFlags flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTextDirection gtk_widget_get_default_direction();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))]
	internal static extern MentorLake.Gtk.GtkStyleHandle gtk_widget_get_default_style();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_pop_composite_child();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_push_composite_child();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_default_direction(MentorLake.Gtk.GtkTextDirection dir);

}
