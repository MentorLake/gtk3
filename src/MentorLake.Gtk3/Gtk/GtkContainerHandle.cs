namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A GTK+ user interface is constructed by nesting widgets inside widgets.
/// Container widgets are the inner nodes in the resulting tree of widgets:
/// they contain other widgets. So, for example, you might have a #GtkWindow
/// containing a #GtkFrame containing a #GtkLabel. If you wanted an image instead
/// of a textual label inside the frame, you might replace the #GtkLabel widget
/// with a #GtkImage widget.
/// </para>
/// <para>
/// There are two major kinds of container widgets in GTK+. Both are subclasses
/// of the abstract GtkContainer base class.
/// </para>
/// <para>
/// The first type of container widget has a single child widget and derives
/// from #GtkBin. These containers are decorators, which
/// add some kind of functionality to the child. For example, a #GtkButton makes
/// its child into a clickable button; a #GtkFrame draws a frame around its child
/// and a #GtkWindow places its child widget inside a top-level window.
/// </para>
/// <para>
/// The second type of container can have more than one child; its purpose is to
/// manage layout. This means that these containers assign
/// sizes and positions to their children. For example, a #GtkHBox arranges its
/// children in a horizontal row, and a #GtkGrid arranges the widgets it contains
/// in a two-dimensional grid.
/// </para>
/// <para>
/// For implementations of #GtkContainer the virtual method #GtkContainerClass.forall()
/// is always required, since it's used for drawing and other internal operations
/// on the children.
/// If the #GtkContainer implementation expect to have non internal children
/// it's needed to implement both #GtkContainerClass.add() and #GtkContainerClass.remove().
/// If the GtkContainer implementation has internal children, they should be added
/// with gtk_widget_set_parent() on init() and removed with gtk_widget_unparent()
/// in the #GtkWidgetClass.destroy() implementation.
/// See more about implementing custom widgets at https://wiki.gnome.org/HowDoI/CustomWidgets
/// </para>
/// <para>
/// # Height for width geometry management
/// </para>
/// <para>
/// GTK+ uses a height-for-width (and width-for-height) geometry management system.
/// Height-for-width means that a widget can change how much vertical space it needs,
/// depending on the amount of horizontal space that it is given (and similar for
/// width-for-height).
/// </para>
/// <para>
/// There are some things to keep in mind when implementing container widgets
/// that make use of GTK+’s height for width geometry management system. First,
/// it’s important to note that a container must prioritize one of its
/// dimensions, that is to say that a widget or container can only have a
/// #GtkSizeRequestMode that is %GTK_SIZE_REQUEST_HEIGHT_FOR_WIDTH or
/// %GTK_SIZE_REQUEST_WIDTH_FOR_HEIGHT. However, every widget and container
/// must be able to respond to the APIs for both dimensions, i.e. even if a
/// widget has a request mode that is height-for-width, it is possible that
/// its parent will request its sizes using the width-for-height APIs.
/// </para>
/// <para>
/// To ensure that everything works properly, here are some guidelines to follow
/// when implementing height-for-width (or width-for-height) containers.
/// </para>
/// <para>
/// Each request mode involves 2 virtual methods. Height-for-width apis run
/// through gtk_widget_get_preferred_width() and then through gtk_widget_get_preferred_height_for_width().
/// When handling requests in the opposite #GtkSizeRequestMode it is important that
/// every widget request at least enough space to display all of its content at all times.
/// </para>
/// <para>
/// When gtk_widget_get_preferred_height() is called on a container that is height-for-width,
/// the container must return the height for its minimum width. This is easily achieved by
/// simply calling the reverse apis implemented for itself as follows:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// static void
/// foo_container_get_preferred_height (GtkWidget *widget,
///                                     gint *min_height,
///                                     gint *nat_height)
/// {
///    if (i_am_in_height_for_width_mode)
///      {
///        gint min_width;
/// </para>
/// <para>
///        GTK_WIDGET_GET_CLASS (widget)->get_preferred_width (widget,
///                                                            &min_width,
///                                                            NULL);
///        GTK_WIDGET_GET_CLASS (widget)->get_preferred_height_for_width
///                                                           (widget,
///                                                            min_width,
///                                                            min_height,
///                                                            nat_height);
///      }
///    else
///      {
///        ... many containers support both request modes, execute the
///        real width-for-height request here by returning the
///        collective heights of all widgets that are stacked
///        vertically (or whatever is appropriate for this container)
///        ...
///      }
/// }
/// ]|
/// </para>
/// <para>
/// Similarly, when gtk_widget_get_preferred_width_for_height() is called for a container or widget
/// that is height-for-width, it then only needs to return the base minimum width like so:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// static void
/// foo_container_get_preferred_width_for_height (GtkWidget *widget,
///                                               gint for_height,
///                                               gint *min_width,
///                                               gint *nat_width)
/// {
///    if (i_am_in_height_for_width_mode)
///      {
///        GTK_WIDGET_GET_CLASS (widget)->get_preferred_width (widget,
///                                                            min_width,
///                                                            nat_width);
///      }
///    else
///      {
///        ... execute the real width-for-height request here based on
///        the required width of the children collectively if the
///        container were to be allocated the said height ...
///      }
/// }
/// ]|
/// </para>
/// <para>
/// Height for width requests are generally implemented in terms of a virtual allocation
/// of widgets in the input orientation. Assuming an height-for-width request mode, a container
/// would implement the get_preferred_height_for_width() virtual function by first calling
/// gtk_widget_get_preferred_width() for each of its children.
/// </para>
/// <para>
/// For each potential group of children that are lined up horizontally, the values returned by
/// gtk_widget_get_preferred_width() should be collected in an array of #GtkRequestedSize structures.
/// Any child spacing should be removed from the input @for_width and then the collective size should be
/// allocated using the gtk_distribute_natural_allocation() convenience function.
/// </para>
/// <para>
/// The container will then move on to request the preferred height for each child by using
/// gtk_widget_get_preferred_height_for_width() and using the sizes stored in the #GtkRequestedSize array.
/// </para>
/// <para>
/// To allocate a height-for-width container, it’s again important
/// to consider that a container must prioritize one dimension over the other. So if
/// a container is a height-for-width container it must first allocate all widgets horizontally
/// using a #GtkRequestedSize array and gtk_distribute_natural_allocation() and then add any
/// extra space (if and where appropriate) for the widget to expand.
/// </para>
/// <para>
/// After adding all the expand space, the container assumes it was allocated sufficient
/// height to fit all of its content. At this time, the container must use the total horizontal sizes
/// of each widget to request the height-for-width of each of its children and store the requests in a
/// #GtkRequestedSize array for any widgets that stack vertically (for tabular containers this can
/// be generalized into the heights and widths of rows and columns).
/// The vertical space must then again be distributed using gtk_distribute_natural_allocation()
/// while this time considering the allocated height of the widget minus any vertical spacing
/// that the container adds. Then vertical expand space should be added where appropriate and available
/// and the container should go on to actually allocating the child widgets.
/// </para>
/// <para>
/// See [GtkWidget’s geometry management section][geometry-management]
/// to learn more about implementing height-for-width geometry management for widgets.
/// </para>
/// <para>
/// # Child properties
/// </para>
/// <para>
/// GtkContainer introduces child properties.
/// These are object properties that are not specific
/// to either the container or the contained widget, but rather to their relation.
/// Typical examples of child properties are the position or pack-type of a widget
/// which is contained in a #GtkBox.
/// </para>
/// <para>
/// Use gtk_container_class_install_child_property() to install child properties
/// for a container class and gtk_container_class_find_child_property() or
/// gtk_container_class_list_child_properties() to get information about existing
/// child properties.
/// </para>
/// <para>
/// To set the value of a child property, use gtk_container_child_set_property(),
/// gtk_container_child_set() or gtk_container_child_set_valist().
/// To obtain the value of a child property, use
/// gtk_container_child_get_property(), gtk_container_child_get() or
/// gtk_container_child_get_valist(). To emit notification about child property
/// changes, use gtk_widget_child_notify().
/// </para>
/// <para>
/// # GtkContainer as GtkBuildable
/// </para>
/// <para>
/// The GtkContainer implementation of the GtkBuildable interface supports
/// a `<packing>` element for children, which can contain multiple `<property>`
/// elements that specify child properties for the child.
/// </para>
/// <para>
/// Since 2.16, child properties can also be marked as translatable using
/// the same “translatable”, “comments” and “context” attributes that are used
/// for regular properties.
/// </para>
/// <para>
/// Since 3.16, containers can have a `<focus-chain>` element containing multiple
/// `<widget>` elements, one for each child that should be added to the focus
/// chain. The ”name” attribute gives the id of the widget.
/// </para>
/// <para>
/// An example of these properties in UI definitions:
/// </para>
/// <para>
/// |[<!-- language="xml" -->
/// <object class="GtkBox">
///   <child>
///     <object class="GtkEntry" id="entry1"/>
///     <packing>
///       <property name="pack-type">start</property>
///     </packing>
///   </child>
///   <child>
///     <object class="GtkEntry" id="entry2"/>
///   </child>
///   <focus-chain>
///     <widget name="entry1"/>
///     <widget name="entry2"/>
///   </focus-chain>
/// </object>
/// ]|
/// </para>
/// </summary>

public class GtkContainerHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
}
public static class GtkContainerHandleSignalExtensions
{

	public static IObservable<GtkContainerHandleSignalStructs.AddSignal> Signal_Add(this GtkContainerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkContainerHandleSignalStructs.AddSignal> obs) =>
		{
			GtkContainerHandleSignalDelegates.add handler = ( MentorLake.Gtk.GtkContainerHandle self,  MentorLake.Gtk.GtkWidgetHandle @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkContainerHandleSignalStructs.AddSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "add", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkContainerHandleSignalStructs.CheckResizeSignal> Signal_CheckResize(this GtkContainerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkContainerHandleSignalStructs.CheckResizeSignal> obs) =>
		{
			GtkContainerHandleSignalDelegates.check_resize handler = ( MentorLake.Gtk.GtkContainerHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkContainerHandleSignalStructs.CheckResizeSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "check-resize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkContainerHandleSignalStructs.RemoveSignal> Signal_Remove(this GtkContainerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkContainerHandleSignalStructs.RemoveSignal> obs) =>
		{
			GtkContainerHandleSignalDelegates.remove handler = ( MentorLake.Gtk.GtkContainerHandle self,  MentorLake.Gtk.GtkWidgetHandle @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkContainerHandleSignalStructs.RemoveSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "remove", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkContainerHandleSignalStructs.SetFocusChildSignal> Signal_SetFocusChild(this GtkContainerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkContainerHandleSignalStructs.SetFocusChildSignal> obs) =>
		{
			GtkContainerHandleSignalDelegates.set_focus_child handler = ( MentorLake.Gtk.GtkContainerHandle self,  MentorLake.Gtk.GtkWidgetHandle @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkContainerHandleSignalStructs.SetFocusChildSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "set-focus-child", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkContainerHandleSignalStructs
{

public class AddSignal
{

	public MentorLake.Gtk.GtkContainerHandle Self;

	public MentorLake.Gtk.GtkWidgetHandle Object;

	public IntPtr UserData;
}

public class CheckResizeSignal
{

	public MentorLake.Gtk.GtkContainerHandle Self;

	public IntPtr UserData;
}

public class RemoveSignal
{

	public MentorLake.Gtk.GtkContainerHandle Self;

	public MentorLake.Gtk.GtkWidgetHandle Object;

	public IntPtr UserData;
}

public class SetFocusChildSignal
{

	public MentorLake.Gtk.GtkContainerHandle Self;

	public MentorLake.Gtk.GtkWidgetHandle Object;

	public IntPtr UserData;
}
}

public static class GtkContainerHandleSignalDelegates
{


/// <param name="self">
/// </param>
/// <param name="@object">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle @object, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void check_resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle self, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="@object">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle @object, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="@object">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void set_focus_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle @object, IntPtr user_data);

}


public static class GtkContainerHandleExtensions
{
/// <summary>
/// <para>
/// Adds @widget to @container. Typically used for simple containers
/// such as #GtkWindow, #GtkFrame, or #GtkButton; for more complicated
/// layout containers such as #GtkBox or #GtkGrid, this function will
/// pick default packing parameters that may not be correct.  So
/// consider functions such as gtk_box_pack_start() and
/// gtk_grid_attach() as an alternative to gtk_container_add() in
/// those cases. A widget may be added to only one container at a time;
/// you can’t place the same widget inside two different containers.
/// </para>
/// <para>
/// Note that some containers, such as #GtkScrolledWindow or #GtkListBox,
/// may add intermediate children between the added widget and the
/// container.
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <param name="widget">
/// a widget to be placed inside @container
/// </param>

	public static T Add<T>(this T container, MentorLake.Gtk.GtkWidgetHandle widget) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_add(container, widget);
		return container;
	}

/// <summary>
/// <para>
/// Adds @widget to @container, setting child properties at the same time.
/// See gtk_container_add() and gtk_container_child_set() for more details.
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <param name="widget">
/// a widget to be placed inside @container
/// </param>
/// <param name="first_prop_name">
/// the name of the first child property to set
/// </param>
/// <param name="@__arglist">
/// a %NULL-terminated list of property names and values, starting
///     with @first_prop_name
/// </param>

	public static T AddWithProperties<T>(this T container, MentorLake.Gtk.GtkWidgetHandle widget, string first_prop_name, IntPtr @__arglist) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_add_with_properties(container, widget, first_prop_name, @__arglist);
		return container;
	}


/// <param name="container">
/// </param>

	public static T CheckResize<T>(this T container) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_check_resize(container);
		return container;
	}

/// <summary>
/// <para>
/// Gets the values of one or more child properties for @child and @container.
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <param name="child">
/// a widget which is a child of @container
/// </param>
/// <param name="first_prop_name">
/// the name of the first property to get
/// </param>
/// <param name="@__arglist">
/// return location for the first property, followed
///     optionally by more name/return location pairs, followed by %NULL
/// </param>

	public static T ChildGet<T>(this T container, MentorLake.Gtk.GtkWidgetHandle child, string first_prop_name, IntPtr @__arglist) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_child_get(container, child, first_prop_name, @__arglist);
		return container;
	}

/// <summary>
/// <para>
/// Gets the value of a child property for @child and @container.
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <param name="child">
/// a widget which is a child of @container
/// </param>
/// <param name="property_name">
/// the name of the property to get
/// </param>
/// <param name="value">
/// a location to return the value
/// </param>

	public static T ChildGetProperty<T>(this T container, MentorLake.Gtk.GtkWidgetHandle child, string property_name, out MentorLake.GObject.GValue value) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_child_get_property(container, child, property_name, out value);
		return container;
	}

/// <summary>
/// <para>
/// Gets the values of one or more child properties for @child and @container.
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <param name="child">
/// a widget which is a child of @container
/// </param>
/// <param name="first_property_name">
/// the name of the first property to get
/// </param>
/// <param name="var_args">
/// return location for the first property, followed
///     optionally by more name/return location pairs, followed by %NULL
/// </param>

	public static T ChildGetValist<T>(this T container, MentorLake.Gtk.GtkWidgetHandle child, string first_property_name, IntPtr var_args) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_child_get_valist(container, child, first_property_name, var_args);
		return container;
	}

/// <summary>
/// <para>
/// Emits a #GtkWidget::child-notify signal for the
/// [child property][child-properties]
/// @child_property on the child.
/// </para>
/// <para>
/// This is an analogue of g_object_notify() for child properties.
/// </para>
/// <para>
/// Also see gtk_widget_child_notify().
/// </para>
/// </summary>

/// <param name="container">
/// the #GtkContainer
/// </param>
/// <param name="child">
/// the child widget
/// </param>
/// <param name="child_property">
/// the name of a child property installed on
///     the class of @container
/// </param>

	public static T ChildNotify<T>(this T container, MentorLake.Gtk.GtkWidgetHandle child, string child_property) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_child_notify(container, child, child_property);
		return container;
	}

/// <summary>
/// <para>
/// Emits a #GtkWidget::child-notify signal for the
/// [child property][child-properties] specified by
/// @pspec on the child.
/// </para>
/// <para>
/// This is an analogue of g_object_notify_by_pspec() for child properties.
/// </para>
/// </summary>

/// <param name="container">
/// the #GtkContainer
/// </param>
/// <param name="child">
/// the child widget
/// </param>
/// <param name="pspec">
/// the #GParamSpec of a child property instealled on
///     the class of @container
/// </param>

	public static T ChildNotifyByPspec<T>(this T container, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.GObject.GParamSpecHandle pspec) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_child_notify_by_pspec(container, child, pspec);
		return container;
	}

/// <summary>
/// <para>
/// Sets one or more child properties for @child and @container.
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <param name="child">
/// a widget which is a child of @container
/// </param>
/// <param name="first_prop_name">
/// the name of the first property to set
/// </param>
/// <param name="@__arglist">
/// a %NULL-terminated list of property names and values, starting
///     with @first_prop_name
/// </param>

	public static T ChildSet<T>(this T container, MentorLake.Gtk.GtkWidgetHandle child, string first_prop_name, IntPtr @__arglist) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_child_set(container, child, first_prop_name, @__arglist);
		return container;
	}

/// <summary>
/// <para>
/// Sets a child property for @child and @container.
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <param name="child">
/// a widget which is a child of @container
/// </param>
/// <param name="property_name">
/// the name of the property to set
/// </param>
/// <param name="value">
/// the value to set the property to
/// </param>

	public static T ChildSetProperty<T>(this T container, MentorLake.Gtk.GtkWidgetHandle child, string property_name, MentorLake.GObject.GValueHandle value) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_child_set_property(container, child, property_name, value);
		return container;
	}

/// <summary>
/// <para>
/// Sets one or more child properties for @child and @container.
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <param name="child">
/// a widget which is a child of @container
/// </param>
/// <param name="first_property_name">
/// the name of the first property to set
/// </param>
/// <param name="var_args">
/// a %NULL-terminated list of property names and values, starting
///           with @first_prop_name
/// </param>

	public static T ChildSetValist<T>(this T container, MentorLake.Gtk.GtkWidgetHandle child, string first_property_name, IntPtr var_args) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_child_set_valist(container, child, first_property_name, var_args);
		return container;
	}

/// <summary>
/// <para>
/// Returns the type of the children supported by the container.
/// </para>
/// <para>
/// Note that this may return %G_TYPE_NONE to indicate that no more
/// children can be added, e.g. for a #GtkPaned which already has two
/// children.
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <return>
/// a #GType.
/// </return>

	public static MentorLake.GObject.GType ChildType(this MentorLake.Gtk.GtkContainerHandle container)
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		return GtkContainerHandleExterns.gtk_container_child_type(container);
	}

/// <summary>
/// <para>
/// Invokes @callback on each direct child of @container, including
/// children that are considered “internal” (implementation details
/// of the container). “Internal” children generally weren’t added
/// by the user of the container, but were added by the container
/// implementation itself.
/// </para>
/// <para>
/// Most applications should use gtk_container_foreach(), rather
/// than gtk_container_forall().
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <param name="callback">
/// a callback
/// </param>
/// <param name="callback_data">
/// callback user data
/// </param>

	public static T Forall<T>(this T container, MentorLake.Gtk.GtkCallback callback, IntPtr callback_data) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_forall(container, callback, callback_data);
		return container;
	}

/// <summary>
/// <para>
/// Invokes @callback on each non-internal child of @container.
/// See gtk_container_forall() for details on what constitutes
/// an “internal” child. For all practical purposes, this function
/// should iterate over precisely those child widgets that were
/// added to the container by the application with explicit add()
/// calls.
/// </para>
/// <para>
/// It is permissible to remove the child from the @callback handler.
/// </para>
/// <para>
/// Most applications should use gtk_container_foreach(),
/// rather than gtk_container_forall().
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <param name="callback">
/// a callback
/// </param>
/// <param name="callback_data">
/// callback user data
/// </param>

	public static T Foreach<T>(this T container, MentorLake.Gtk.GtkCallback callback, IntPtr callback_data) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_foreach(container, callback, callback_data);
		return container;
	}

/// <summary>
/// <para>
/// Retrieves the border width of the container. See
/// gtk_container_set_border_width().
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <return>
/// the current border width
/// </return>

	public static uint GetBorderWidth(this MentorLake.Gtk.GtkContainerHandle container)
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		return GtkContainerHandleExterns.gtk_container_get_border_width(container);
	}

/// <summary>
/// <para>
/// Returns the container’s non-internal children. See
/// gtk_container_forall() for details on what constitutes an "internal" child.
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <return>
/// a newly-allocated list of the container’s non-internal children.
/// </return>

	public static MentorLake.GLib.GListHandle GetChildren(this MentorLake.Gtk.GtkContainerHandle container)
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		return GtkContainerHandleExterns.gtk_container_get_children(container);
	}

/// <summary>
/// <para>
/// Retrieves the focus chain of the container, if one has been
/// set explicitly. If no focus chain has been explicitly
/// set, GTK+ computes the focus chain based on the positions
/// of the children. In that case, GTK+ stores %NULL in
/// @focusable_widgets and returns %FALSE.
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <param name="focusable_widgets">
/// location
///                     to store the focus chain of the
///                     container, or %NULL. You should free this list
///                     using g_list_free() when you are done with it, however
///                     no additional reference count is added to the
///                     individual widgets in the focus chain.
/// </param>
/// <return>
/// %TRUE if the focus chain of the container
/// has been set explicitly.
/// </return>

	public static bool GetFocusChain(this MentorLake.Gtk.GtkContainerHandle container, out MentorLake.GLib.GListHandle focusable_widgets)
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		return GtkContainerHandleExterns.gtk_container_get_focus_chain(container, out focusable_widgets);
	}

/// <summary>
/// <para>
/// Returns the current focus child widget inside @container. This is not the
/// currently focused widget. That can be obtained by calling
/// gtk_window_get_focus().
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <return>
/// The child widget which will receive the
///          focus inside @container when the @container is focused,
///          or %NULL if none is set.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetFocusChild(this MentorLake.Gtk.GtkContainerHandle container)
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		return GtkContainerHandleExterns.gtk_container_get_focus_child(container);
	}

/// <summary>
/// <para>
/// Retrieves the horizontal focus adjustment for the container. See
/// gtk_container_set_focus_hadjustment ().
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <return>
/// the horizontal focus adjustment, or %NULL if
///   none has been set.
/// </return>

	public static MentorLake.Gtk.GtkAdjustmentHandle GetFocusHadjustment(this MentorLake.Gtk.GtkContainerHandle container)
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		return GtkContainerHandleExterns.gtk_container_get_focus_hadjustment(container);
	}

/// <summary>
/// <para>
/// Retrieves the vertical focus adjustment for the container. See
/// gtk_container_set_focus_vadjustment().
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <return>
/// the vertical focus adjustment, or
///   %NULL if none has been set.
/// </return>

	public static MentorLake.Gtk.GtkAdjustmentHandle GetFocusVadjustment(this MentorLake.Gtk.GtkContainerHandle container)
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		return GtkContainerHandleExterns.gtk_container_get_focus_vadjustment(container);
	}

/// <summary>
/// <para>
/// Returns a newly created widget path representing all the widget hierarchy
/// from the toplevel down to and including @child.
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <param name="child">
/// a child of @container
/// </param>
/// <return>
/// A newly created #GtkWidgetPath
/// </return>

	public static MentorLake.Gtk.GtkWidgetPathHandle GetPathForChild(this MentorLake.Gtk.GtkContainerHandle container, MentorLake.Gtk.GtkWidgetHandle child)
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		return GtkContainerHandleExterns.gtk_container_get_path_for_child(container, child);
	}

/// <summary>
/// <para>
/// Returns the resize mode for the container. See
/// gtk_container_set_resize_mode ().
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <return>
/// the current resize mode
/// </return>

	public static MentorLake.Gtk.GtkResizeMode GetResizeMode(this MentorLake.Gtk.GtkContainerHandle container)
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		return GtkContainerHandleExterns.gtk_container_get_resize_mode(container);
	}

/// <summary>
/// <para>
/// When a container receives a call to the draw function, it must send
/// synthetic #GtkWidget::draw calls to all children that don’t have their
/// own #GdkWindows. This function provides a convenient way of doing this.
/// A container, when it receives a call to its #GtkWidget::draw function,
/// calls gtk_container_propagate_draw() once for each child, passing in
/// the @cr the container received.
/// </para>
/// <para>
/// gtk_container_propagate_draw() takes care of translating the origin of @cr,
/// and deciding whether the draw needs to be sent to the child. It is a
/// convenient and optimized way of getting the same effect as calling
/// gtk_widget_draw() on the child directly.
/// </para>
/// <para>
/// In most cases, a container can simply either inherit the
/// #GtkWidget::draw implementation from #GtkContainer, or do some drawing
/// and then chain to the ::draw implementation from #GtkContainer.
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <param name="child">
/// a child of @container
/// </param>
/// <param name="cr">
/// Cairo context as passed to the container. If you want to use @cr
///   in container’s draw function, consider using cairo_save() and
///   cairo_restore() before calling this function.
/// </param>

	public static T PropagateDraw<T>(this T container, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.cairo.cairo_tHandle cr) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_propagate_draw(container, child, cr);
		return container;
	}

/// <summary>
/// <para>
/// Removes @widget from @container. @widget must be inside @container.
/// Note that @container will own a reference to @widget, and that this
/// may be the last reference held; so removing a widget from its
/// container can destroy that widget. If you want to use @widget
/// again, you need to add a reference to it before removing it from
/// a container, using g_object_ref(). If you don’t want to use @widget
/// again it’s usually more efficient to simply destroy it directly
/// using gtk_widget_destroy() since this will remove it from the
/// container and help break any circular reference count cycles.
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <param name="widget">
/// a current child of @container
/// </param>

	public static T Remove<T>(this T container, MentorLake.Gtk.GtkWidgetHandle widget) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_remove(container, widget);
		return container;
	}


/// <param name="container">
/// a #GtkContainer
/// </param>

	public static T ResizeChildren<T>(this T container) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_resize_children(container);
		return container;
	}

/// <summary>
/// <para>
/// Sets the border width of the container.
/// </para>
/// <para>
/// The border width of a container is the amount of space to leave
/// around the outside of the container. The only exception to this is
/// #GtkWindow; because toplevel windows can’t leave space outside,
/// they leave the space inside. The border is added on all sides of
/// the container. To add space to only one side, use a specific
/// #GtkWidget:margin property on the child widget, for example
/// #GtkWidget:margin-top.
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <param name="border_width">
/// amount of blank space to leave outside
///   the container. Valid values are in the range 0-65535 pixels.
/// </param>

	public static T SetBorderWidth<T>(this T container, uint border_width) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_set_border_width(container, border_width);
		return container;
	}

/// <summary>
/// <para>
/// Sets a focus chain, overriding the one computed automatically by GTK+.
/// </para>
/// <para>
/// In principle each widget in the chain should be a descendant of the
/// container, but this is not enforced by this method, since it’s allowed
/// to set the focus chain before you pack the widgets, or have a widget
/// in the chain that isn’t always packed. The necessary checks are done
/// when the focus chain is actually traversed.
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <param name="focusable_widgets">
/// 
///     the new focus chain
/// </param>

	public static T SetFocusChain<T>(this T container, MentorLake.GLib.GListHandle focusable_widgets) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_set_focus_chain(container, focusable_widgets);
		return container;
	}

/// <summary>
/// <para>
/// Sets, or unsets if @child is %NULL, the focused child of @container.
/// </para>
/// <para>
/// This function emits the GtkContainer::set_focus_child signal of
/// @container. Implementations of #GtkContainer can override the
/// default behaviour by overriding the class closure of this signal.
/// </para>
/// <para>
/// This is function is mostly meant to be used by widgets. Applications can use
/// gtk_widget_grab_focus() to manually set the focus to a specific widget.
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <param name="child">
/// a #GtkWidget, or %NULL
/// </param>

	public static T SetFocusChild<T>(this T container, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_set_focus_child(container, child);
		return container;
	}

/// <summary>
/// <para>
/// Hooks up an adjustment to focus handling in a container, so when a child
/// of the container is focused, the adjustment is scrolled to show that
/// widget. This function sets the horizontal alignment.
/// See gtk_scrolled_window_get_hadjustment() for a typical way of obtaining
/// the adjustment and gtk_container_set_focus_vadjustment() for setting
/// the vertical adjustment.
/// </para>
/// <para>
/// The adjustments have to be in pixel units and in the same coordinate
/// system as the allocation for immediate children of the container.
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <param name="adjustment">
/// an adjustment which should be adjusted when the focus is
///   moved among the descendents of @container
/// </param>

	public static T SetFocusHadjustment<T>(this T container, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_set_focus_hadjustment(container, adjustment);
		return container;
	}

/// <summary>
/// <para>
/// Hooks up an adjustment to focus handling in a container, so when a
/// child of the container is focused, the adjustment is scrolled to
/// show that widget. This function sets the vertical alignment. See
/// gtk_scrolled_window_get_vadjustment() for a typical way of obtaining
/// the adjustment and gtk_container_set_focus_hadjustment() for setting
/// the horizontal adjustment.
/// </para>
/// <para>
/// The adjustments have to be in pixel units and in the same coordinate
/// system as the allocation for immediate children of the container.
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <param name="adjustment">
/// an adjustment which should be adjusted when the focus
///   is moved among the descendents of @container
/// </param>

	public static T SetFocusVadjustment<T>(this T container, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_set_focus_vadjustment(container, adjustment);
		return container;
	}

/// <summary>
/// <para>
/// Sets the @reallocate_redraws flag of the container to the given value.
/// </para>
/// <para>
/// Containers requesting reallocation redraws get automatically
/// redrawn if any of their children changed allocation.
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <param name="needs_redraws">
/// the new value for the container’s @reallocate_redraws flag
/// </param>

	public static T SetReallocateRedraws<T>(this T container, bool needs_redraws) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_set_reallocate_redraws(container, needs_redraws);
		return container;
	}

/// <summary>
/// <para>
/// Sets the resize mode for the container.
/// </para>
/// <para>
/// The resize mode of a container determines whether a resize request
/// will be passed to the container’s parent, queued for later execution
/// or executed immediately.
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>
/// <param name="resize_mode">
/// the new resize mode
/// </param>

	public static T SetResizeMode<T>(this T container, MentorLake.Gtk.GtkResizeMode resize_mode) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_set_resize_mode(container, resize_mode);
		return container;
	}

/// <summary>
/// <para>
/// Removes a focus chain explicitly set with gtk_container_set_focus_chain().
/// </para>
/// </summary>

/// <param name="container">
/// a #GtkContainer
/// </param>

	public static T UnsetFocusChain<T>(this T container) where T : GtkContainerHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_unset_focus_chain(container);
		return container;
	}

}

internal class GtkContainerHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_add_with_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string first_prop_name, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_check_resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_child_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, string first_prop_name, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_child_get_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, string property_name, out MentorLake.GObject.GValue value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_child_get_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, string first_property_name, IntPtr var_args);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_child_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, string child_property);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_child_notify_by_pspec([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_child_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, string first_prop_name, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_child_set_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, string property_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_child_set_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, string first_property_name, IntPtr var_args);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GObject.GType gtk_container_child_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_forall([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, MentorLake.Gtk.GtkCallback callback, IntPtr callback_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, MentorLake.Gtk.GtkCallback callback, IntPtr callback_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_container_get_border_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_container_get_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_container_get_focus_chain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] out MentorLake.GLib.GListHandle focusable_widgets);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_container_get_focus_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_container_get_focus_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_container_get_focus_vadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetPathHandle gtk_container_get_path_for_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkResizeMode gtk_container_get_resize_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_propagate_draw([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_resize_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_set_border_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, uint border_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_set_focus_chain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle focusable_widgets);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_set_focus_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_set_focus_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_set_focus_vadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_set_reallocate_redraws([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, bool needs_redraws);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_set_resize_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, MentorLake.Gtk.GtkResizeMode resize_mode);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_unset_focus_chain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container);

}
