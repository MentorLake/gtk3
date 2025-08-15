namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GMenuModel` represents the contents of a menu — an ordered list of
/// menu items. The items are associated with actions, which can be
/// activated through them. Items can be grouped in sections, and may
/// have submenus associated with them. Both items and sections usually
/// have some representation data, such as labels or icons. The type of
/// the associated action (ie whether it is stateful, and what kind of
/// state it has) can influence the representation of the item.
/// </para>
/// <para>
/// The conceptual model of menus in `GMenuModel` is hierarchical:
/// sections and submenus are again represented by `GMenuModel`s.
/// Menus themselves do not define their own roles. Rather, the role
/// of a particular `GMenuModel` is defined by the item that references
/// it (or, in the case of the ‘root’ menu, is defined by the context
/// in which it is used).
/// </para>
/// <para>
/// As an example, consider the visible portions of this menu:
/// </para>
/// <para>
/// ## An example menu
/// </para>
/// <para>
/// ![](menu-example.png)
/// </para>
/// <para>
/// While this kind of deeply nested menu is no longer considered good UI
/// practice, it serves as a good example of the concepts in `GMenuModel`.
/// There are 8 ‘menus’ visible in the screenshot: one menubar, two
/// submenus and 5 sections:
/// </para>
/// <para>
/// - the toplevel menubar (containing 4 items)
/// - the View submenu (containing 3 sections)
/// - the first section of the View submenu (containing 2 items)
/// - the second section of the View submenu (containing 1 item)
/// - the final section of the View submenu (containing 1 item)
/// - the Highlight Mode submenu (containing 2 sections)
/// - the Sources section (containing 2 items)
/// - the Markup section (containing 2 items)
/// </para>
/// <para>
/// The [example](#a-menu-example) illustrates the conceptual connection between
/// these 8 menus. Each large block in the figure represents a menu and the
/// smaller blocks within the large block represent items in that menu. Some
/// items contain references to other menus.
/// </para>
/// <para>
/// ## A menu example
/// </para>
/// <para>
/// &amp;lt;picture&amp;gt;
///   &amp;lt;source srcset=&quot;menu-model-dark.svg&quot; media=&quot;(prefers-color-scheme: dark)&quot;&amp;gt;
///   &amp;lt;img src=&quot;menu-model-light.svg&quot; alt=&quot;menu model&quot;&amp;gt;
/// &amp;lt;/picture&amp;gt;
/// </para>
/// <para>
/// Notice that the separators visible in the [example](#an-example-menu)
/// appear nowhere in the [menu model](#a-menu-example). This is because
/// separators are not explicitly represented in the menu model. Instead,
/// a separator is inserted between any two non-empty sections of a menu.
/// Section items can have labels just like any other item. In that case,
/// a display system may show a section header instead of a separator.
/// </para>
/// <para>
/// The motivation for this abstract model of application controls is
/// that modern user interfaces tend to make these controls available
/// outside the application. Examples include global menus, jumplists,
/// dash boards, etc. To support such uses, it is necessary to ‘export’
/// information about actions and their representation in menus, which
/// is exactly what the action group exporter and the menu model exporter do for
/// [iface@Gio.ActionGroup] and [class@Gio.MenuModel]. The client-side
/// counterparts to make use of the exported information are
/// [class@Gio.DBusActionGroup] and [class@Gio.DBusMenuModel].
/// </para>
/// <para>
/// The API of `GMenuModel` is very generic, with iterators for the
/// attributes and links of an item, see
/// [method@Gio.MenuModel.iterate_item_attributes] and
/// [method@Gio.MenuModel.iterate_item_links]. The ‘standard’ attributes and
/// link types have predefined names: `G_MENU_ATTRIBUTE_LABEL`,
/// `G_MENU_ATTRIBUTE_ACTION`, `G_MENU_ATTRIBUTE_TARGET`, `G_MENU_LINK_SECTION`
/// and `G_MENU_LINK_SUBMENU`.
/// </para>
/// <para>
/// Items in a `GMenuModel` represent active controls if they refer to
/// an action that can get activated when the user interacts with the
/// menu item. The reference to the action is encoded by the string ID
/// in the `G_MENU_ATTRIBUTE_ACTION` attribute. An action ID uniquely
/// identifies an action in an action group. Which action group(s) provide
/// actions depends on the context in which the menu model is used.
/// E.g. when the model is exported as the application menu of a
/// &amp;lt;see href=&quot;https://docs.gtk.org/gtk4/class.Application.html&quot;&amp;gt;GtkApplication&amp;lt;/see&amp;gt;,
/// actions can be application-wide or window-specific (and thus come from
/// two different action groups). By convention, the application-wide actions
/// have names that start with `app.`, while the names of window-specific
/// actions start with `win.`.
/// </para>
/// <para>
/// While a wide variety of stateful actions is possible, the following
/// is the minimum that is expected to be supported by all users of exported
/// menu information:
/// - an action with no parameter type and no state
/// - an action with no parameter type and boolean state
/// - an action with string parameter type and string state
/// </para>
/// <para>
/// ## Stateless
/// </para>
/// <para>
/// A stateless action typically corresponds to an ordinary menu item.
/// </para>
/// <para>
/// Selecting such a menu item will activate the action (with no parameter).
/// </para>
/// <para>
/// ## Boolean State
/// </para>
/// <para>
/// An action with a boolean state will most typically be used with a ‘toggle’
/// or ‘switch’ menu item. The state can be set directly, but activating the
/// action (with no parameter) results in the state being toggled.
/// </para>
/// <para>
/// Selecting a toggle menu item will activate the action. The menu item should
/// be rendered as ‘checked’ when the state is true.
/// </para>
/// <para>
/// ## String Parameter and State
/// </para>
/// <para>
/// Actions with string parameters and state will most typically be used to
/// represent an enumerated choice over the items available for a group of
/// radio menu items. Activating the action with a string parameter is
/// equivalent to setting that parameter as the state.
/// </para>
/// <para>
/// Radio menu items, in addition to being associated with the action, will
/// have a target value. Selecting that menu item will result in activation
/// of the action with the target value as the parameter. The menu item should
/// be rendered as ‘selected’ when the state of the action is equal to the
/// target value of the menu item.
/// </para>
/// </summary>

public class GMenuModelHandle : GObjectHandle
{
}
public static class GMenuModelHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when a change has occurred to the menu.
/// </para>
/// <para>
/// The only changes that can occur to a menu is that items are removed
/// or added.  Items may not change (except by being removed and added
/// back in the same location).  This signal is capable of describing
/// both of those changes (at the same time).
/// </para>
/// <para>
/// The signal means that starting at the index @position, @removed
/// items were removed and @added items were added in their place.  If
/// @removed is zero then only items were added.  If @added is zero
/// then only items were removed.
/// </para>
/// <para>
/// As an example, if the menu contains items a, b, c, d (in that
/// order) and the signal (2, 1, 3) occurs then the new composition of
/// the menu will be a, b, _, _, _, d (with each _ representing some
/// new item).
/// </para>
/// <para>
/// Signal handlers may query the model (particularly the added items)
/// and expect to see the results of the modification that is being
/// reported.  The signal is emitted after the modification.
/// </para>
/// </summary>

	public static IObservable<GMenuModelHandleSignalStructs.ItemsChangedSignal> Signal_ItemsChanged(this GMenuModelHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GMenuModelHandleSignalStructs.ItemsChangedSignal> obs) =>
		{
			GMenuModelHandleSignalDelegates.items_changed handler = ( MentorLake.Gio.GMenuModelHandle self,  int position,  int removed,  int added,  IntPtr user_data) =>
			{
				

				var signalStruct = new GMenuModelHandleSignalStructs.ItemsChangedSignal()
				{
					Self = self, Position = position, Removed = removed, Added = added, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "items-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GMenuModelHandleSignalStructs
{

public class ItemsChangedSignal
{

	public MentorLake.Gio.GMenuModelHandle Self;
/// <summary>
/// <para>
/// the position of the change
/// </para>
/// </summary>

	public int Position;
/// <summary>
/// <para>
/// the number of items removed
/// </para>
/// </summary>

	public int Removed;
/// <summary>
/// <para>
/// the number of items added
/// </para>
/// </summary>

	public int Added;

	public IntPtr UserData;
}
}

public static class GMenuModelHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when a change has occurred to the menu.
/// </para>
/// <para>
/// The only changes that can occur to a menu is that items are removed
/// or added.  Items may not change (except by being removed and added
/// back in the same location).  This signal is capable of describing
/// both of those changes (at the same time).
/// </para>
/// <para>
/// The signal means that starting at the index @position, @removed
/// items were removed and @added items were added in their place.  If
/// @removed is zero then only items were added.  If @added is zero
/// then only items were removed.
/// </para>
/// <para>
/// As an example, if the menu contains items a, b, c, d (in that
/// order) and the signal (2, 1, 3) occurs then the new composition of
/// the menu will be a, b, _, _, _, d (with each _ representing some
/// new item).
/// </para>
/// <para>
/// Signal handlers may query the model (particularly the added items)
/// and expect to see the results of the modification that is being
/// reported.  The signal is emitted after the modification.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="position">
/// the position of the change
/// </param>
/// <param name="removed">
/// the number of items removed
/// </param>
/// <param name="added">
/// the number of items added
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void items_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle self, int position, int removed, int added, IntPtr user_data);

}


public static class GMenuModelHandleExtensions
{
/// <summary>
/// <para>
/// Queries item at position @item_index in @model for the attribute
/// specified by @attribute.
/// </para>
/// <para>
/// If the attribute exists and matches the #GVariantType corresponding
/// to @format_string then @format_string is used to deconstruct the
/// value into the positional parameters and %TRUE is returned.
/// </para>
/// <para>
/// If the attribute does not exist, or it does exist but has the wrong
/// type, then the positional parameters are ignored and %FALSE is
/// returned.
/// </para>
/// <para>
/// This function is a mix of g_menu_model_get_item_attribute_value() and
/// g_variant_get(), followed by a g_variant_unref().  As such,
/// @format_string must make a complete copy of the data (since the
/// #GVariant may go away after the call to g_variant_unref()).  In
/// particular, no &apos;&amp;&apos; characters are allowed in @format_string.
/// </para>
/// </summary>

/// <param name="model">
/// a #GMenuModel
/// </param>
/// <param name="item_index">
/// the index of the item
/// </param>
/// <param name="attribute">
/// the attribute to query
/// </param>
/// <param name="format_string">
/// a #GVariant format string
/// </param>
/// <param name="@__arglist">
/// positional parameters, as per @format_string
/// </param>
/// <return>
/// %TRUE if the named attribute was found with the expected
///     type
/// </return>

	public static bool GetItemAttribute(this MentorLake.Gio.GMenuModelHandle model, int item_index, string attribute, string format_string, IntPtr @__arglist)
	{
		if (model.IsInvalid) throw new Exception("Invalid handle (GMenuModelHandle)");
		return GMenuModelHandleExterns.g_menu_model_get_item_attribute(model, item_index, attribute, format_string, @__arglist);
	}

/// <summary>
/// <para>
/// Queries the item at position @item_index in @model for the attribute
/// specified by @attribute.
/// </para>
/// <para>
/// If @expected_type is non-%NULL then it specifies the expected type of
/// the attribute.  If it is %NULL then any type will be accepted.
/// </para>
/// <para>
/// If the attribute exists and matches @expected_type (or if the
/// expected type is unspecified) then the value is returned.
/// </para>
/// <para>
/// If the attribute does not exist, or does not match the expected type
/// then %NULL is returned.
/// </para>
/// </summary>

/// <param name="model">
/// a #GMenuModel
/// </param>
/// <param name="item_index">
/// the index of the item
/// </param>
/// <param name="attribute">
/// the attribute to query
/// </param>
/// <param name="expected_type">
/// the expected type of the attribute, or
///     %NULL
/// </param>
/// <return>
/// the value of the attribute
/// </return>

	public static MentorLake.GLib.GVariantHandle GetItemAttributeValue(this MentorLake.Gio.GMenuModelHandle model, int item_index, string attribute, MentorLake.GLib.GVariantTypeHandle expected_type)
	{
		if (model.IsInvalid) throw new Exception("Invalid handle (GMenuModelHandle)");
		return GMenuModelHandleExterns.g_menu_model_get_item_attribute_value(model, item_index, attribute, expected_type);
	}

/// <summary>
/// <para>
/// Queries the item at position @item_index in @model for the link
/// specified by @link.
/// </para>
/// <para>
/// If the link exists, the linked #GMenuModel is returned.  If the link
/// does not exist, %NULL is returned.
/// </para>
/// </summary>

/// <param name="model">
/// a #GMenuModel
/// </param>
/// <param name="item_index">
/// the index of the item
/// </param>
/// <param name="link">
/// the link to query
/// </param>
/// <return>
/// the linked #GMenuModel, or %NULL
/// </return>

	public static MentorLake.Gio.GMenuModelHandle GetItemLink(this MentorLake.Gio.GMenuModelHandle model, int item_index, string link)
	{
		if (model.IsInvalid) throw new Exception("Invalid handle (GMenuModelHandle)");
		return GMenuModelHandleExterns.g_menu_model_get_item_link(model, item_index, link);
	}

/// <summary>
/// <para>
/// Query the number of items in @model.
/// </para>
/// </summary>

/// <param name="model">
/// a #GMenuModel
/// </param>
/// <return>
/// the number of items
/// </return>

	public static int GetNItems(this MentorLake.Gio.GMenuModelHandle model)
	{
		if (model.IsInvalid) throw new Exception("Invalid handle (GMenuModelHandle)");
		return GMenuModelHandleExterns.g_menu_model_get_n_items(model);
	}

/// <summary>
/// <para>
/// Queries if @model is mutable.
/// </para>
/// <para>
/// An immutable #GMenuModel will never emit the #GMenuModel::items-changed
/// signal. Consumers of the model may make optimisations accordingly.
/// </para>
/// </summary>

/// <param name="model">
/// a #GMenuModel
/// </param>
/// <return>
/// %TRUE if the model is mutable (ie: &quot;items-changed&quot; may be
///     emitted).
/// </return>

	public static bool IsMutable(this MentorLake.Gio.GMenuModelHandle model)
	{
		if (model.IsInvalid) throw new Exception("Invalid handle (GMenuModelHandle)");
		return GMenuModelHandleExterns.g_menu_model_is_mutable(model);
	}

/// <summary>
/// <para>
/// Requests emission of the #GMenuModel::items-changed signal on @model.
/// </para>
/// <para>
/// This function should never be called except by #GMenuModel
/// subclasses.  Any other calls to this function will very likely lead
/// to a violation of the interface of the model.
/// </para>
/// <para>
/// The implementation should update its internal representation of the
/// menu before emitting the signal.  The implementation should further
/// expect to receive queries about the new state of the menu (and
/// particularly added menu items) while signal handlers are running.
/// </para>
/// <para>
/// The implementation must dispatch this call directly from a mainloop
/// entry and not in response to calls -- particularly those from the
/// #GMenuModel API.  Said another way: the menu must not change while
/// user code is running without returning to the mainloop.
/// </para>
/// </summary>

/// <param name="model">
/// a #GMenuModel
/// </param>
/// <param name="position">
/// the position of the change
/// </param>
/// <param name="removed">
/// the number of items removed
/// </param>
/// <param name="added">
/// the number of items added
/// </param>

	public static T ItemsChanged<T>(this T model, int position, int removed, int added) where T : GMenuModelHandle
	{
		if (model.IsInvalid) throw new Exception("Invalid handle (GMenuModelHandle)");
		GMenuModelHandleExterns.g_menu_model_items_changed(model, position, removed, added);
		return model;
	}

/// <summary>
/// <para>
/// Creates a #GMenuAttributeIter to iterate over the attributes of
/// the item at position @item_index in @model.
/// </para>
/// <para>
/// You must free the iterator with g_object_unref() when you are done.
/// </para>
/// </summary>

/// <param name="model">
/// a #GMenuModel
/// </param>
/// <param name="item_index">
/// the index of the item
/// </param>
/// <return>
/// a new #GMenuAttributeIter
/// </return>

	public static MentorLake.Gio.GMenuAttributeIterHandle IterateItemAttributes(this MentorLake.Gio.GMenuModelHandle model, int item_index)
	{
		if (model.IsInvalid) throw new Exception("Invalid handle (GMenuModelHandle)");
		return GMenuModelHandleExterns.g_menu_model_iterate_item_attributes(model, item_index);
	}

/// <summary>
/// <para>
/// Creates a #GMenuLinkIter to iterate over the links of the item at
/// position @item_index in @model.
/// </para>
/// <para>
/// You must free the iterator with g_object_unref() when you are done.
/// </para>
/// </summary>

/// <param name="model">
/// a #GMenuModel
/// </param>
/// <param name="item_index">
/// the index of the item
/// </param>
/// <return>
/// a new #GMenuLinkIter
/// </return>

	public static MentorLake.Gio.GMenuLinkIterHandle IterateItemLinks(this MentorLake.Gio.GMenuModelHandle model, int item_index)
	{
		if (model.IsInvalid) throw new Exception("Invalid handle (GMenuModelHandle)");
		return GMenuModelHandleExterns.g_menu_model_iterate_item_links(model, item_index);
	}

}

internal class GMenuModelHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_menu_model_get_item_attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model, int item_index, string attribute, string format_string, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_menu_model_get_item_attribute_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model, int item_index, string attribute, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle expected_type);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))]
	internal static extern MentorLake.Gio.GMenuModelHandle g_menu_model_get_item_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model, int item_index, string link);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_menu_model_get_n_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_menu_model_is_mutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_model_items_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model, int position, int removed, int added);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GMenuAttributeIterHandle>))]
	internal static extern MentorLake.Gio.GMenuAttributeIterHandle g_menu_model_iterate_item_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model, int item_index);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GMenuLinkIterHandle>))]
	internal static extern MentorLake.Gio.GMenuLinkIterHandle g_menu_model_iterate_item_links([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model, int item_index);

}
