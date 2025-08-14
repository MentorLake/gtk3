namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Activatable widgets can be connected to a #GtkAction and reflects
/// the state of its action. A #GtkActivatable can also provide feedback
/// through its action, as they are responsible for activating their
/// related actions.
/// </para>
/// <para>
/// # Implementing GtkActivatable
/// </para>
/// <para>
/// When extending a class that is already #GtkActivatable; it is only
/// necessary to implement the #GtkActivatable->sync_action_properties()
/// and #GtkActivatable->update() methods and chain up to the parent
/// implementation, however when introducing
/// a new #GtkActivatable class; the #GtkActivatable:related-action and
/// #GtkActivatable:use-action-appearance properties need to be handled by
/// the implementor. Handling these properties is mostly a matter of installing
/// the action pointer and boolean flag on your instance, and calling
/// gtk_activatable_do_set_related_action() and
/// gtk_activatable_sync_action_properties() at the appropriate times.
/// </para>
/// <para>
/// ## A class fragment implementing #GtkActivatable
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// </para>
/// <para>
/// enum {
/// ...
/// </para>
/// <para>
/// PROP_ACTIVATABLE_RELATED_ACTION,
/// PROP_ACTIVATABLE_USE_ACTION_APPEARANCE
/// }
/// </para>
/// <para>
/// struct _FooBarPrivate
/// {
/// </para>
/// <para>
///   ...
/// </para>
/// <para>
///   GtkAction      *action;
///   gboolean        use_action_appearance;
/// };
/// </para>
/// <para>
/// ...
/// </para>
/// <para>
/// static void foo_bar_activatable_interface_init         (GtkActivatableIface  *iface);
/// static void foo_bar_activatable_update                 (GtkActivatable       *activatable,
/// 						           GtkAction            *action,
/// 						           const gchar          *property_name);
/// static void foo_bar_activatable_sync_action_properties (GtkActivatable       *activatable,
/// 						           GtkAction            *action);
/// ...
/// </para>
/// <para>
/// </para>
/// <para>
/// static void
/// foo_bar_class_init (FooBarClass *klass)
/// {
/// </para>
/// <para>
///   ...
/// </para>
/// <para>
///   g_object_class_override_property (gobject_class, PROP_ACTIVATABLE_RELATED_ACTION, "related-action");
///   g_object_class_override_property (gobject_class, PROP_ACTIVATABLE_USE_ACTION_APPEARANCE, "use-action-appearance");
/// </para>
/// <para>
///   ...
/// }
/// </para>
/// <para>
/// </para>
/// <para>
/// static void
/// foo_bar_activatable_interface_init (GtkActivatableIface  *iface)
/// {
///   iface->update = foo_bar_activatable_update;
///   iface->sync_action_properties = foo_bar_activatable_sync_action_properties;
/// }
/// </para>
/// <para>
/// ... Break the reference using gtk_activatable_do_set_related_action()...
/// </para>
/// <para>
/// static void
/// foo_bar_dispose (GObject *object)
/// {
///   FooBar *bar = FOO_BAR (object);
///   FooBarPrivate *priv = FOO_BAR_GET_PRIVATE (bar);
/// </para>
/// <para>
///   ...
/// </para>
/// <para>
///   if (priv->action)
///     {
///       gtk_activatable_do_set_related_action (GTK_ACTIVATABLE (bar), NULL);
///       priv->action = NULL;
///     }
///   G_OBJECT_CLASS (foo_bar_parent_class)->dispose (object);
/// }
/// </para>
/// <para>
/// ... Handle the “related-action” and “use-action-appearance” properties ...
/// </para>
/// <para>
/// static void
/// foo_bar_set_property (GObject         *object,
///                       guint            prop_id,
///                       const GValue    *value,
///                       GParamSpec      *pspec)
/// {
///   FooBar *bar = FOO_BAR (object);
///   FooBarPrivate *priv = FOO_BAR_GET_PRIVATE (bar);
/// </para>
/// <para>
///   switch (prop_id)
///     {
/// </para>
/// <para>
///       ...
/// </para>
/// <para>
///     case PROP_ACTIVATABLE_RELATED_ACTION:
///       foo_bar_set_related_action (bar, g_value_get_object (value));
///       break;
///     case PROP_ACTIVATABLE_USE_ACTION_APPEARANCE:
///       foo_bar_set_use_action_appearance (bar, g_value_get_boolean (value));
///       break;
///     default:
///       G_OBJECT_WARN_INVALID_PROPERTY_ID (object, prop_id, pspec);
///       break;
///     }
/// }
/// </para>
/// <para>
/// static void
/// foo_bar_get_property (GObject         *object,
///                          guint            prop_id,
///                          GValue          *value,
///                          GParamSpec      *pspec)
/// {
///   FooBar *bar = FOO_BAR (object);
///   FooBarPrivate *priv = FOO_BAR_GET_PRIVATE (bar);
/// </para>
/// <para>
///   switch (prop_id)
///     {
/// </para>
/// <para>
///       ...
/// </para>
/// <para>
///     case PROP_ACTIVATABLE_RELATED_ACTION:
///       g_value_set_object (value, priv->action);
///       break;
///     case PROP_ACTIVATABLE_USE_ACTION_APPEARANCE:
///       g_value_set_boolean (value, priv->use_action_appearance);
///       break;
///     default:
///       G_OBJECT_WARN_INVALID_PROPERTY_ID (object, prop_id, pspec);
///       break;
///     }
/// }
/// </para>
/// <para>
/// </para>
/// <para>
/// static void
/// foo_bar_set_use_action_appearance (FooBar   *bar,
/// 				   gboolean  use_appearance)
/// {
///   FooBarPrivate *priv = FOO_BAR_GET_PRIVATE (bar);
/// </para>
/// <para>
///   if (priv->use_action_appearance != use_appearance)
///     {
///       priv->use_action_appearance = use_appearance;
/// </para>
/// <para>
///       gtk_activatable_sync_action_properties (GTK_ACTIVATABLE (bar), priv->action);
///     }
/// }
/// </para>
/// <para>
/// ... call gtk_activatable_do_set_related_action() and then assign the action pointer,
/// no need to reference the action here since gtk_activatable_do_set_related_action() already
/// holds a reference here for you...
/// static void
/// foo_bar_set_related_action (FooBar    *bar,
/// 			    GtkAction *action)
/// {
///   FooBarPrivate *priv = FOO_BAR_GET_PRIVATE (bar);
/// </para>
/// <para>
///   if (priv->action == action)
///     return;
/// </para>
/// <para>
///   gtk_activatable_do_set_related_action (GTK_ACTIVATABLE (bar), action);
/// </para>
/// <para>
///   priv->action = action;
/// }
/// </para>
/// <para>
/// ... Selectively reset and update activatable depending on the use-action-appearance property ...
/// static void
/// gtk_button_activatable_sync_action_properties (GtkActivatable       *activatable,
/// 		                                  GtkAction            *action)
/// {
///   GtkButtonPrivate *priv = GTK_BUTTON_GET_PRIVATE (activatable);
/// </para>
/// <para>
///   if (!action)
///     return;
/// </para>
/// <para>
///   if (gtk_action_is_visible (action))
///     gtk_widget_show (GTK_WIDGET (activatable));
///   else
///     gtk_widget_hide (GTK_WIDGET (activatable));
/// </para>
/// <para>
///   gtk_widget_set_sensitive (GTK_WIDGET (activatable), gtk_action_is_sensitive (action));
/// </para>
/// <para>
///   ...
/// </para>
/// <para>
///   if (priv->use_action_appearance)
///     {
///       if (gtk_action_get_stock_id (action))
/// 	foo_bar_set_stock (button, gtk_action_get_stock_id (action));
///       else if (gtk_action_get_label (action))
/// 	foo_bar_set_label (button, gtk_action_get_label (action));
/// </para>
/// <para>
///       ...
/// </para>
/// <para>
///     }
/// }
/// </para>
/// <para>
/// static void
/// foo_bar_activatable_update (GtkActivatable       *activatable,
/// 			       GtkAction            *action,
/// 			       const gchar          *property_name)
/// {
///   FooBarPrivate *priv = FOO_BAR_GET_PRIVATE (activatable);
/// </para>
/// <para>
///   if (strcmp (property_name, "visible") == 0)
///     {
///       if (gtk_action_is_visible (action))
/// 	gtk_widget_show (GTK_WIDGET (activatable));
///       else
/// 	gtk_widget_hide (GTK_WIDGET (activatable));
///     }
///   else if (strcmp (property_name, "sensitive") == 0)
///     gtk_widget_set_sensitive (GTK_WIDGET (activatable), gtk_action_is_sensitive (action));
/// </para>
/// <para>
///   ...
/// </para>
/// <para>
///   if (!priv->use_action_appearance)
///     return;
/// </para>
/// <para>
///   if (strcmp (property_name, "stock-id") == 0)
///     foo_bar_set_stock (button, gtk_action_get_stock_id (action));
///   else if (strcmp (property_name, "label") == 0)
///     foo_bar_set_label (button, gtk_action_get_label (action));
/// </para>
/// <para>
///   ...
/// }
/// ]|
/// </para>
/// </summary>

public interface GtkActivatableHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkActivatableHandleImpl : BaseSafeHandle, GtkActivatableHandle
{
}

public static class GtkActivatableHandleExtensions
{
/// <summary>
/// <para>
/// This is a utility function for #GtkActivatable implementors.
/// </para>
/// <para>
/// When implementing #GtkActivatable you must call this when
/// handling changes of the #GtkActivatable:related-action, and
/// you must also use this to break references in #GObject->dispose().
/// </para>
/// <para>
/// This function adds a reference to the currently set related
/// action for you, it also makes sure the #GtkActivatable->update()
/// method is called when the related #GtkAction properties change
/// and registers to the action’s proxy list.
/// </para>
/// <para>
/// > Be careful to call this before setting the local
/// > copy of the #GtkAction property, since this function uses
/// > gtk_activatable_get_related_action() to retrieve the
/// > previous action.
/// </para>
/// </summary>

/// <param name="activatable">
/// a #GtkActivatable
/// </param>
/// <param name="action">
/// the #GtkAction to set
/// </param>

	public static T DoSetRelatedAction<T>(this T activatable, MentorLake.Gtk.GtkActionHandle action) where T : GtkActivatableHandle
	{
		if (activatable.IsInvalid) throw new Exception("Invalid handle (GtkActivatableHandle)");
		GtkActivatableHandleExterns.gtk_activatable_do_set_related_action(activatable, action);
		return activatable;
	}

/// <summary>
/// <para>
/// Gets the related #GtkAction for @activatable.
/// </para>
/// </summary>

/// <param name="activatable">
/// a #GtkActivatable
/// </param>
/// <return>
/// the related #GtkAction if one is set.
/// </return>

	public static MentorLake.Gtk.GtkActionHandle GetRelatedAction(this MentorLake.Gtk.GtkActivatableHandle activatable)
	{
		if (activatable.IsInvalid) throw new Exception("Invalid handle (GtkActivatableHandle)");
		return GtkActivatableHandleExterns.gtk_activatable_get_related_action(activatable);
	}

/// <summary>
/// <para>
/// Gets whether this activatable should reset its layout
/// and appearance when setting the related action or when
/// the action changes appearance.
/// </para>
/// </summary>

/// <param name="activatable">
/// a #GtkActivatable
/// </param>
/// <return>
/// whether @activatable uses its actions appearance.
/// </return>

	public static bool GetUseActionAppearance(this MentorLake.Gtk.GtkActivatableHandle activatable)
	{
		if (activatable.IsInvalid) throw new Exception("Invalid handle (GtkActivatableHandle)");
		return GtkActivatableHandleExterns.gtk_activatable_get_use_action_appearance(activatable);
	}

/// <summary>
/// <para>
/// Sets the related action on the @activatable object.
/// </para>
/// <para>
/// > #GtkActivatable implementors need to handle the #GtkActivatable:related-action
/// > property and call gtk_activatable_do_set_related_action() when it changes.
/// </para>
/// </summary>

/// <param name="activatable">
/// a #GtkActivatable
/// </param>
/// <param name="action">
/// the #GtkAction to set
/// </param>

	public static T SetRelatedAction<T>(this T activatable, MentorLake.Gtk.GtkActionHandle action) where T : GtkActivatableHandle
	{
		if (activatable.IsInvalid) throw new Exception("Invalid handle (GtkActivatableHandle)");
		GtkActivatableHandleExterns.gtk_activatable_set_related_action(activatable, action);
		return activatable;
	}

/// <summary>
/// <para>
/// Sets whether this activatable should reset its layout and appearance
/// when setting the related action or when the action changes appearance
/// </para>
/// <para>
/// > #GtkActivatable implementors need to handle the
/// > #GtkActivatable:use-action-appearance property and call
/// > gtk_activatable_sync_action_properties() to update @activatable
/// > if needed.
/// </para>
/// </summary>

/// <param name="activatable">
/// a #GtkActivatable
/// </param>
/// <param name="use_appearance">
/// whether to use the actions appearance
/// </param>

	public static T SetUseActionAppearance<T>(this T activatable, bool use_appearance) where T : GtkActivatableHandle
	{
		if (activatable.IsInvalid) throw new Exception("Invalid handle (GtkActivatableHandle)");
		GtkActivatableHandleExterns.gtk_activatable_set_use_action_appearance(activatable, use_appearance);
		return activatable;
	}

/// <summary>
/// <para>
/// This is called to update the activatable completely, this is called
/// internally when the #GtkActivatable:related-action property is set
/// or unset and by the implementing class when
/// #GtkActivatable:use-action-appearance changes.
/// </para>
/// </summary>

/// <param name="activatable">
/// a #GtkActivatable
/// </param>
/// <param name="action">
/// the related #GtkAction or %NULL
/// </param>

	public static T SyncActionProperties<T>(this T activatable, MentorLake.Gtk.GtkActionHandle action) where T : GtkActivatableHandle
	{
		if (activatable.IsInvalid) throw new Exception("Invalid handle (GtkActivatableHandle)");
		GtkActivatableHandleExterns.gtk_activatable_sync_action_properties(activatable, action);
		return activatable;
	}

}

internal class GtkActivatableHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_activatable_do_set_related_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActivatableHandleImpl>))] MentorLake.Gtk.GtkActivatableHandle activatable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))]
	internal static extern MentorLake.Gtk.GtkActionHandle gtk_activatable_get_related_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActivatableHandleImpl>))] MentorLake.Gtk.GtkActivatableHandle activatable);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_activatable_get_use_action_appearance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActivatableHandleImpl>))] MentorLake.Gtk.GtkActivatableHandle activatable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_activatable_set_related_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActivatableHandleImpl>))] MentorLake.Gtk.GtkActivatableHandle activatable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_activatable_set_use_action_appearance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActivatableHandleImpl>))] MentorLake.Gtk.GtkActivatableHandle activatable, bool use_appearance);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_activatable_sync_action_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActivatableHandleImpl>))] MentorLake.Gtk.GtkActivatableHandle activatable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

}
