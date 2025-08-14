namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkPopover is a bubble-like context window, primarily meant to
/// provide context-dependent information or options. Popovers are
/// attached to a widget, passed at construction time on gtk_popover_new(),
/// or updated afterwards through gtk_popover_set_relative_to(), by
/// default they will point to the whole widget area, although this
/// behavior can be changed through gtk_popover_set_pointing_to().
/// </para>
/// <para>
/// The position of a popover relative to the widget it is attached to
/// can also be changed through gtk_popover_set_position().
/// </para>
/// <para>
/// By default, #GtkPopover performs a GTK+ grab, in order to ensure
/// input events get redirected to it while it is shown, and also so
/// the popover is dismissed in the expected situations (clicks outside
/// the popover, or the Esc key being pressed). If no such modal behavior
/// is desired on a popover, gtk_popover_set_modal() may be called on it
/// to tweak its behavior.
/// </para>
/// <para>
/// ## GtkPopover as menu replacement
/// </para>
/// <para>
/// GtkPopover is often used to replace menus. To facilitate this, it
/// supports being populated from a #GMenuModel, using
/// gtk_popover_new_from_model(). In addition to all the regular menu
/// model features, this function supports rendering sections in the
/// model in a more compact form, as a row of icon buttons instead of
/// menu items.
/// </para>
/// <para>
/// To use this rendering, set the ”display-hint” attribute of the
/// section to ”horizontal-buttons” and set the icons of your items
/// with the ”verb-icon” attribute.
/// </para>
/// <para>
/// |[
/// <section>
///   <attribute name="display-hint">horizontal-buttons</attribute>
///   <item>
///     <attribute name="label">Cut</attribute>
///     <attribute name="action">app.cut</attribute>
///     <attribute name="verb-icon">edit-cut-symbolic</attribute>
///   </item>
///   <item>
///     <attribute name="label">Copy</attribute>
///     <attribute name="action">app.copy</attribute>
///     <attribute name="verb-icon">edit-copy-symbolic</attribute>
///   </item>
///   <item>
///     <attribute name="label">Paste</attribute>
///     <attribute name="action">app.paste</attribute>
///     <attribute name="verb-icon">edit-paste-symbolic</attribute>
///   </item>
/// </section>
/// ]|
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkPopover has a single css node called popover. It always gets the
/// .background style class and it gets the .menu style class if it is
/// menu-like (e.g. #GtkPopoverMenu or created using gtk_popover_new_from_model().
/// </para>
/// <para>
/// Particular uses of GtkPopover, such as touch selection popups
/// or magnifiers in #GtkEntry or #GtkTextView get style classes
/// like .touch-selection or .magnifier to differentiate from
/// plain popovers.
/// </para>
/// </summary>

public class GtkPopoverHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new popover to point to @relative_to
/// </para>
/// </summary>

/// <param name="relative_to">
/// #GtkWidget the popover is related to
/// </param>
/// <return>
/// a new #GtkPopover
/// </return>

	public static MentorLake.Gtk.GtkPopoverHandle New(MentorLake.Gtk.GtkWidgetHandle relative_to)
	{
		return GtkPopoverHandleExterns.gtk_popover_new(relative_to);
	}

/// <summary>
/// <para>
/// Creates a #GtkPopover and populates it according to
/// @model. The popover is pointed to the @relative_to widget.
/// </para>
/// <para>
/// The created buttons are connected to actions found in the
/// #GtkApplicationWindow to which the popover belongs - typically
/// by means of being attached to a widget that is contained within
/// the #GtkApplicationWindows widget hierarchy.
/// </para>
/// <para>
/// Actions can also be added using gtk_widget_insert_action_group()
/// on the menus attach widget or on any of its parent widgets.
/// </para>
/// </summary>

/// <param name="relative_to">
/// #GtkWidget the popover is related to
/// </param>
/// <param name="model">
/// a #GMenuModel
/// </param>
/// <return>
/// the new #GtkPopover
/// </return>

	public static MentorLake.Gtk.GtkPopoverHandle NewFromModel(MentorLake.Gtk.GtkWidgetHandle relative_to, MentorLake.Gio.GMenuModelHandle model)
	{
		return GtkPopoverHandleExterns.gtk_popover_new_from_model(relative_to, model);
	}

}
public static class GtkPopoverHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when the popover is dismissed either through
/// API or user interaction.
/// </para>
/// </summary>

	public static IObservable<GtkPopoverHandleSignalStructs.ClosedSignal> Signal_Closed(this GtkPopoverHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPopoverHandleSignalStructs.ClosedSignal> obs) =>
		{
			GtkPopoverHandleSignalDelegates.closed handler = ( MentorLake.Gtk.GtkPopoverHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPopoverHandleSignalStructs.ClosedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "closed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkPopoverHandleSignalStructs
{

public class ClosedSignal
{

	public MentorLake.Gtk.GtkPopoverHandle Self;

	public IntPtr UserData;
}
}

public static class GtkPopoverHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when the popover is dismissed either through
/// API or user interaction.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle self, IntPtr user_data);

}


public static class GtkPopoverHandleExtensions
{
/// <summary>
/// <para>
/// Establishes a binding between a #GtkPopover and a #GMenuModel.
/// </para>
/// <para>
/// The contents of @popover are removed and then refilled with menu items
/// according to @model.  When @model changes, @popover is updated.
/// Calling this function twice on @popover with different @model will
/// cause the first binding to be replaced with a binding to the new
/// model. If @model is %NULL then any previous binding is undone and
/// all children are removed.
/// </para>
/// <para>
/// If @action_namespace is non-%NULL then the effect is as if all
/// actions mentioned in the @model have their names prefixed with the
/// namespace, plus a dot.  For example, if the action “quit” is
/// mentioned and @action_namespace is “app” then the effective action
/// name is “app.quit”.
/// </para>
/// <para>
/// This function uses #GtkActionable to define the action name and
/// target values on the created menu items.  If you want to use an
/// action group other than “app” and “win”, or if you want to use a
/// #GtkMenuShell outside of a #GtkApplicationWindow, then you will need
/// to attach your own action group to the widget hierarchy using
/// gtk_widget_insert_action_group().  As an example, if you created a
/// group with a “quit” action and inserted it with the name “mygroup”
/// then you would use the action name “mygroup.quit” in your
/// #GMenuModel.
/// </para>
/// </summary>

/// <param name="popover">
/// a #GtkPopover
/// </param>
/// <param name="model">
/// the #GMenuModel to bind to or %NULL to remove
///   binding
/// </param>
/// <param name="action_namespace">
/// the namespace for actions in @model
/// </param>

	public static T BindModel<T>(this T popover, MentorLake.Gio.GMenuModelHandle model, string action_namespace) where T : GtkPopoverHandle
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		GtkPopoverHandleExterns.gtk_popover_bind_model(popover, model, action_namespace);
		return popover;
	}

/// <summary>
/// <para>
/// Returns the constraint for placing this popover.
/// See gtk_popover_set_constrain_to().
/// </para>
/// </summary>

/// <param name="popover">
/// a #GtkPopover
/// </param>
/// <return>
/// the constraint for placing this popover.
/// </return>

	public static MentorLake.Gtk.GtkPopoverConstraint GetConstrainTo(this MentorLake.Gtk.GtkPopoverHandle popover)
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		return GtkPopoverHandleExterns.gtk_popover_get_constrain_to(popover);
	}

/// <summary>
/// <para>
/// Gets the widget that should be set as the default while
/// the popover is shown.
/// </para>
/// </summary>

/// <param name="popover">
/// a #GtkPopover
/// </param>
/// <return>
/// the default widget,
/// or %NULL if there is none
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetDefaultWidget(this MentorLake.Gtk.GtkPopoverHandle popover)
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		return GtkPopoverHandleExterns.gtk_popover_get_default_widget(popover);
	}

/// <summary>
/// <para>
/// Returns whether the popover is modal, see gtk_popover_set_modal to
/// see the implications of this.
/// </para>
/// </summary>

/// <param name="popover">
/// a #GtkPopover
/// </param>
/// <return>
/// #TRUE if @popover is modal
/// </return>

	public static bool GetModal(this MentorLake.Gtk.GtkPopoverHandle popover)
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		return GtkPopoverHandleExterns.gtk_popover_get_modal(popover);
	}

/// <summary>
/// <para>
/// If a rectangle to point to has been set, this function will
/// return %TRUE and fill in @rect with such rectangle, otherwise
/// it will return %FALSE and fill in @rect with the attached
/// widget width and height if a widget exists, otherwise it will zero-out @rect.
/// </para>
/// </summary>

/// <param name="popover">
/// a #GtkPopover
/// </param>
/// <param name="rect">
/// location to store the rectangle
/// </param>
/// <return>
/// %TRUE if a rectangle to point to was set.
/// </return>

	public static bool GetPointingTo(this MentorLake.Gtk.GtkPopoverHandle popover, out MentorLake.Gdk.GdkRectangle rect)
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		return GtkPopoverHandleExterns.gtk_popover_get_pointing_to(popover, out rect);
	}

/// <summary>
/// <para>
/// Returns the preferred position of @popover.
/// </para>
/// </summary>

/// <param name="popover">
/// a #GtkPopover
/// </param>
/// <return>
/// The preferred position.
/// </return>

	public static MentorLake.Gtk.GtkPositionType GetPosition(this MentorLake.Gtk.GtkPopoverHandle popover)
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		return GtkPopoverHandleExterns.gtk_popover_get_position(popover);
	}

/// <summary>
/// <para>
/// Returns the widget @popover is currently attached to
/// </para>
/// </summary>

/// <param name="popover">
/// a #GtkPopover
/// </param>
/// <return>
/// a #GtkWidget
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetRelativeTo(this MentorLake.Gtk.GtkPopoverHandle popover)
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		return GtkPopoverHandleExterns.gtk_popover_get_relative_to(popover);
	}

/// <summary>
/// <para>
/// Returns whether show/hide transitions are enabled on this popover.
/// </para>
/// </summary>

/// <param name="popover">
/// a #GtkPopover
/// </param>
/// <return>
/// #TRUE if the show and hide transitions of the given
///          popover are enabled, #FALSE otherwise.
/// </return>

	public static bool GetTransitionsEnabled(this MentorLake.Gtk.GtkPopoverHandle popover)
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		return GtkPopoverHandleExterns.gtk_popover_get_transitions_enabled(popover);
	}

/// <summary>
/// <para>
/// Pops @popover down.This is different than a gtk_widget_hide() call
/// in that it shows the popover with a transition. If you want to hide
/// the popover without a transition, use gtk_widget_hide().
/// </para>
/// </summary>

/// <param name="popover">
/// a #GtkPopover
/// </param>

	public static T Popdown<T>(this T popover) where T : GtkPopoverHandle
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		GtkPopoverHandleExterns.gtk_popover_popdown(popover);
		return popover;
	}

/// <summary>
/// <para>
/// Pops @popover up. This is different than a gtk_widget_show() call
/// in that it shows the popover with a transition. If you want to show
/// the popover without a transition, use gtk_widget_show().
/// </para>
/// </summary>

/// <param name="popover">
/// a #GtkPopover
/// </param>

	public static T Popup<T>(this T popover) where T : GtkPopoverHandle
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		GtkPopoverHandleExterns.gtk_popover_popup(popover);
		return popover;
	}

/// <summary>
/// <para>
/// Sets a constraint for positioning this popover.
/// </para>
/// <para>
/// Note that not all platforms support placing popovers freely,
/// and may already impose constraints.
/// </para>
/// </summary>

/// <param name="popover">
/// a #GtkPopover
/// </param>
/// <param name="constraint">
/// the new constraint
/// </param>

	public static T SetConstrainTo<T>(this T popover, MentorLake.Gtk.GtkPopoverConstraint constraint) where T : GtkPopoverHandle
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		GtkPopoverHandleExterns.gtk_popover_set_constrain_to(popover, constraint);
		return popover;
	}

/// <summary>
/// <para>
/// Sets the widget that should be set as default widget while
/// the popover is shown (see gtk_window_set_default()). #GtkPopover
/// remembers the previous default widget and reestablishes it
/// when the popover is dismissed.
/// </para>
/// </summary>

/// <param name="popover">
/// a #GtkPopover
/// </param>
/// <param name="widget">
/// the new default widget, or %NULL
/// </param>

	public static T SetDefaultWidget<T>(this T popover, MentorLake.Gtk.GtkWidgetHandle widget) where T : GtkPopoverHandle
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		GtkPopoverHandleExterns.gtk_popover_set_default_widget(popover, widget);
		return popover;
	}

/// <summary>
/// <para>
/// Sets whether @popover is modal, a modal popover will grab all input
/// within the toplevel and grab the keyboard focus on it when being
/// displayed. Clicking outside the popover area or pressing Esc will
/// dismiss the popover and ungrab input.
/// </para>
/// </summary>

/// <param name="popover">
/// a #GtkPopover
/// </param>
/// <param name="modal">
/// #TRUE to make popover claim all input within the toplevel
/// </param>

	public static T SetModal<T>(this T popover, bool modal) where T : GtkPopoverHandle
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		GtkPopoverHandleExterns.gtk_popover_set_modal(popover, modal);
		return popover;
	}

/// <summary>
/// <para>
/// Sets the rectangle that @popover will point to, in the
/// coordinate space of the widget @popover is attached to,
/// see gtk_popover_set_relative_to().
/// </para>
/// </summary>

/// <param name="popover">
/// a #GtkPopover
/// </param>
/// <param name="rect">
/// rectangle to point to
/// </param>

	public static T SetPointingTo<T>(this T popover, MentorLake.Gdk.GdkRectangleHandle rect) where T : GtkPopoverHandle
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		GtkPopoverHandleExterns.gtk_popover_set_pointing_to(popover, rect);
		return popover;
	}

/// <summary>
/// <para>
/// Sets the preferred position for @popover to appear. If the @popover
/// is currently visible, it will be immediately updated.
/// </para>
/// <para>
/// This preference will be respected where possible, although
/// on lack of space (eg. if close to the window edges), the
/// #GtkPopover may choose to appear on the opposite side
/// </para>
/// </summary>

/// <param name="popover">
/// a #GtkPopover
/// </param>
/// <param name="position">
/// preferred popover position
/// </param>

	public static T SetPosition<T>(this T popover, MentorLake.Gtk.GtkPositionType position) where T : GtkPopoverHandle
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		GtkPopoverHandleExterns.gtk_popover_set_position(popover, position);
		return popover;
	}

/// <summary>
/// <para>
/// Sets a new widget to be attached to @popover. If @popover is
/// visible, the position will be updated.
/// </para>
/// <para>
/// Note: the ownership of popovers is always given to their @relative_to
/// widget, so if @relative_to is set to %NULL on an attached @popover, it
/// will be detached from its previous widget, and consequently destroyed
/// unless extra references are kept.
/// </para>
/// </summary>

/// <param name="popover">
/// a #GtkPopover
/// </param>
/// <param name="relative_to">
/// a #GtkWidget
/// </param>

	public static T SetRelativeTo<T>(this T popover, MentorLake.Gtk.GtkWidgetHandle relative_to) where T : GtkPopoverHandle
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		GtkPopoverHandleExterns.gtk_popover_set_relative_to(popover, relative_to);
		return popover;
	}

/// <summary>
/// <para>
/// Sets whether show/hide transitions are enabled on this popover
/// </para>
/// </summary>

/// <param name="popover">
/// a #GtkPopover
/// </param>
/// <param name="transitions_enabled">
/// Whether transitions are enabled
/// </param>

	public static T SetTransitionsEnabled<T>(this T popover, bool transitions_enabled) where T : GtkPopoverHandle
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		GtkPopoverHandleExterns.gtk_popover_set_transitions_enabled(popover, transitions_enabled);
		return popover;
	}

}

internal class GtkPopoverHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))]
	internal static extern MentorLake.Gtk.GtkPopoverHandle gtk_popover_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle relative_to);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))]
	internal static extern MentorLake.Gtk.GtkPopoverHandle gtk_popover_new_from_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle relative_to, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_popover_bind_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model, string action_namespace);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPopoverConstraint gtk_popover_get_constrain_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_popover_get_default_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_popover_get_modal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_popover_get_pointing_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover, out MentorLake.Gdk.GdkRectangle rect);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPositionType gtk_popover_get_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_popover_get_relative_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_popover_get_transitions_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_popover_popdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_popover_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_popover_set_constrain_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover, MentorLake.Gtk.GtkPopoverConstraint constraint);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_popover_set_default_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_popover_set_modal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover, bool modal);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_popover_set_pointing_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle rect);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_popover_set_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover, MentorLake.Gtk.GtkPositionType position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_popover_set_relative_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle relative_to);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_popover_set_transitions_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover, bool transitions_enabled);

}
