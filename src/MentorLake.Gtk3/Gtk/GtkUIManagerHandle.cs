namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkUIManager constructs a user interface (menus and toolbars) from
/// one or more UI definitions, which reference actions from one or more
/// action groups.
/// </para>
/// <para>
/// > GtkUIManager is deprecated since GTK+ 3.10. To construct user interfaces
/// > from XML definitions, you should use #GtkBuilder, #GMenuModel, et al. To
/// > work with actions, use #GAction, #GtkActionable et al. These newer classes
/// > support richer functionality and integration with various desktop shells.
/// > It should be possible to migrate most/all functionality from GtkUIManager.
/// </para>
/// <para>
/// # UI Definitions # {#XML-UI}
/// </para>
/// <para>
/// The UI definitions are specified in an XML format which can be
/// roughly described by the following DTD.
/// </para>
/// <para>
/// > Do not confuse the GtkUIManager UI Definitions described here with
/// > the similarly named [GtkBuilder UI Definitions][BUILDER-UI].
/// </para>
/// <para>
/// |[
/// <!ELEMENT ui          (menubar|toolbar|popup|accelerator)* >
/// <!ELEMENT menubar     (menuitem|separator|placeholder|menu)* >
/// <!ELEMENT menu        (menuitem|separator|placeholder|menu)* >
/// <!ELEMENT popup       (menuitem|separator|placeholder|menu)* >
/// <!ELEMENT toolbar     (toolitem|separator|placeholder)* >
/// <!ELEMENT placeholder (menuitem|toolitem|separator|placeholder|menu)* >
/// <!ELEMENT menuitem     EMPTY >
/// <!ELEMENT toolitem     (menu?) >
/// <!ELEMENT separator    EMPTY >
/// <!ELEMENT accelerator  EMPTY >
/// <!ATTLIST menubar      name                      #IMPLIED
///                        action                    #IMPLIED >
/// <!ATTLIST toolbar      name                      #IMPLIED
///                        action                    #IMPLIED >
/// <!ATTLIST popup        name                      #IMPLIED
///                        action                    #IMPLIED
///                        accelerators (true|false) #IMPLIED >
/// <!ATTLIST placeholder  name                      #IMPLIED
///                        action                    #IMPLIED >
/// <!ATTLIST separator    name                      #IMPLIED
///                        action                    #IMPLIED
///                        expand       (true|false) #IMPLIED >
/// <!ATTLIST menu         name                      #IMPLIED
///                        action                    #REQUIRED
///                        position     (top|bot)    #IMPLIED >
/// <!ATTLIST menuitem     name                      #IMPLIED
///                        action                    #REQUIRED
///                        position     (top|bot)    #IMPLIED
///                        always-show-image (true|false) #IMPLIED >
/// <!ATTLIST toolitem     name                      #IMPLIED
///                        action                    #REQUIRED
///                        position     (top|bot)    #IMPLIED >
/// <!ATTLIST accelerator  name                      #IMPLIED
///                        action                    #REQUIRED >
/// ]|
/// </para>
/// <para>
/// There are some additional restrictions beyond those specified in the
/// DTD, e.g. every toolitem must have a toolbar in its anchestry and
/// every menuitem must have a menubar or popup in its anchestry. Since
/// a #GMarkupParser is used to parse the UI description, it must not only
/// be valid XML, but valid markup.
/// </para>
/// <para>
/// If a name is not specified, it defaults to the action. If an action is
/// not specified either, the element name is used. The name and action
/// attributes must not contain “/” characters after parsing (since that
/// would mess up path lookup) and must be usable as XML attributes when
/// enclosed in doublequotes, thus they must not “"” characters or references
/// to the &quot; entity.
/// </para>
/// <para>
/// # A UI definition #
/// </para>
/// <para>
/// |[<!-- language="xml" -->
/// <ui>
///   <menubar>
///     <menu name="FileMenu" action="FileMenuAction">
///       <menuitem name="New" action="New2Action" />
///       <placeholder name="FileMenuAdditions" />
///     </menu>
///     <menu name="JustifyMenu" action="JustifyMenuAction">
///       <menuitem name="Left" action="justify-left"/>
///       <menuitem name="Centre" action="justify-center"/>
///       <menuitem name="Right" action="justify-right"/>
///       <menuitem name="Fill" action="justify-fill"/>
///     </menu>
///   </menubar>
///   <toolbar action="toolbar1">
///     <placeholder name="JustifyToolItems">
///       <separator/>
///       <toolitem name="Left" action="justify-left"/>
///       <toolitem name="Centre" action="justify-center"/>
///       <toolitem name="Right" action="justify-right"/>
///       <toolitem name="Fill" action="justify-fill"/>
///       <separator/>
///     </placeholder>
///   </toolbar>
/// </ui>
/// ]|
/// </para>
/// <para>
/// The constructed widget hierarchy is very similar to the element tree
/// of the XML, with the exception that placeholders are merged into their
/// parents. The correspondence of XML elements to widgets should be
/// almost obvious:
/// </para>
/// <para>
/// - menubar
/// </para>
/// <para>
///    a #GtkMenuBar
/// </para>
/// <para>
/// - toolbar
/// </para>
/// <para>
///    a #GtkToolbar
/// </para>
/// <para>
/// - popup
/// </para>
/// <para>
///    a toplevel #GtkMenu
/// </para>
/// <para>
/// - menu
/// </para>
/// <para>
///    a #GtkMenu attached to a menuitem
/// </para>
/// <para>
/// - menuitem
/// </para>
/// <para>
///    a #GtkMenuItem subclass, the exact type depends on the action
/// </para>
/// <para>
/// - toolitem
/// </para>
/// <para>
///    a #GtkToolItem subclass, the exact type depends on the
///    action. Note that toolitem elements may contain a menu element,
///    but only if their associated action specifies a
///    #GtkMenuToolButton as proxy.
/// </para>
/// <para>
/// - separator
/// </para>
/// <para>
///    a #GtkSeparatorMenuItem or #GtkSeparatorToolItem
/// </para>
/// <para>
/// - accelerator
/// </para>
/// <para>
///    a keyboard accelerator
/// </para>
/// <para>
/// The “position” attribute determines where a constructed widget is positioned
/// wrt. to its siblings in the partially constructed tree. If it is
/// “top”, the widget is prepended, otherwise it is appended.
/// </para>
/// <para>
/// # UI Merging # {#UI-Merging}
/// </para>
/// <para>
/// The most remarkable feature of #GtkUIManager is that it can overlay a set
/// of menuitems and toolitems over another one, and demerge them later.
/// </para>
/// <para>
/// Merging is done based on the names of the XML elements. Each element is
/// identified by a path which consists of the names of its anchestors, separated
/// by slashes. For example, the menuitem named “Left” in the example above
/// has the path `/ui/menubar/JustifyMenu/Left` and the
/// toolitem with the same name has path
/// `/ui/toolbar1/JustifyToolItems/Left`.
/// </para>
/// <para>
/// # Accelerators #
/// </para>
/// <para>
/// Every action has an accelerator path. Accelerators are installed together
/// with menuitem proxies, but they can also be explicitly added with
/// `<accelerator>` elements in the UI definition. This makes it possible to
/// have accelerators for actions even if they have no visible proxies.
/// </para>
/// <para>
/// # Smart Separators # {#Smart-Separators}
/// </para>
/// <para>
/// The separators created by #GtkUIManager are “smart”, i.e. they do not show up
/// in the UI unless they end up between two visible menu or tool items. Separators
/// which are located at the very beginning or end of the menu or toolbar
/// containing them, or multiple separators next to each other, are hidden. This
/// is a useful feature, since the merging of UI elements from multiple sources
/// can make it hard or impossible to determine in advance whether a separator
/// will end up in such an unfortunate position.
/// </para>
/// <para>
/// For separators in toolbars, you can set `expand="true"` to
/// turn them from a small, visible separator to an expanding, invisible one.
/// Toolitems following an expanding separator are effectively right-aligned.
/// </para>
/// <para>
/// # Empty Menus
/// </para>
/// <para>
/// Submenus pose similar problems to separators inconnection with merging. It is
/// impossible to know in advance whether they will end up empty after merging.
/// #GtkUIManager offers two ways to treat empty submenus:
/// </para>
/// <para>
/// - make them disappear by hiding the menu item they’re attached to
/// </para>
/// <para>
/// - add an insensitive “Empty” item
/// </para>
/// <para>
/// The behaviour is chosen based on the “hide_if_empty” property of the action
/// to which the submenu is associated.
/// </para>
/// <para>
/// # GtkUIManager as GtkBuildable # {#GtkUIManager-BUILDER-UI}
/// </para>
/// <para>
/// The GtkUIManager implementation of the GtkBuildable interface accepts
/// GtkActionGroup objects as `<child>` elements in UI definitions.
/// </para>
/// <para>
/// A GtkUIManager UI definition as described above can be embedded in
/// an GtkUIManager `<object>` element in a GtkBuilder UI definition.
/// </para>
/// <para>
/// The widgets that are constructed by a GtkUIManager can be embedded in
/// other parts of the constructed user interface with the help of the
/// “constructor” attribute. See the example below.
/// </para>
/// <para>
/// ## An embedded GtkUIManager UI definition
/// </para>
/// <para>
/// |[<!-- language="xml" -->
/// <object class="GtkUIManager" id="uiman">
///   <child>
///     <object class="GtkActionGroup" id="actiongroup">
///       <child>
///         <object class="GtkAction" id="file">
///           <property name="label">_File</property>
///         </object>
///       </child>
///     </object>
///   </child>
///   <ui>
///     <menubar name="menubar1">
///       <menu action="file">
///       </menu>
///     </menubar>
///   </ui>
/// </object>
/// <object class="GtkWindow" id="main-window">
///   <child>
///     <object class="GtkMenuBar" id="menubar1" constructor="uiman"/>
///   </child>
/// </object>
/// ]|
/// </para>
/// </summary>

public class GtkUIManagerHandle : GObjectHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new ui manager object.
/// </para>
/// </summary>

/// <return>
/// a new ui manager object.
/// </return>

	public static MentorLake.Gtk.GtkUIManagerHandle New()
	{
		return GtkUIManagerHandleExterns.gtk_ui_manager_new();
	}

}
public static class GtkUIManagerHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::actions-changed signal is emitted whenever the set of actions
/// changes.
/// </para>
/// </summary>

	public static IObservable<GtkUIManagerHandleSignalStructs.ActionsChangedSignal> Signal_ActionsChanged(this GtkUIManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkUIManagerHandleSignalStructs.ActionsChangedSignal> obs) =>
		{
			GtkUIManagerHandleSignalDelegates.actions_changed handler = ( MentorLake.Gtk.GtkUIManagerHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkUIManagerHandleSignalStructs.ActionsChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "actions-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::add-widget signal is emitted for each generated menubar and toolbar.
/// It is not emitted for generated popup menus, which can be obtained by
/// gtk_ui_manager_get_widget().
/// </para>
/// </summary>

	public static IObservable<GtkUIManagerHandleSignalStructs.AddWidgetSignal> Signal_AddWidget(this GtkUIManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkUIManagerHandleSignalStructs.AddWidgetSignal> obs) =>
		{
			GtkUIManagerHandleSignalDelegates.add_widget handler = ( MentorLake.Gtk.GtkUIManagerHandle self,  MentorLake.Gtk.GtkWidgetHandle widget,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkUIManagerHandleSignalStructs.AddWidgetSignal()
				{
					Self = self, Widget = widget, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "add-widget", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::connect-proxy signal is emitted after connecting a proxy to
/// an action in the group.
/// </para>
/// <para>
/// This is intended for simple customizations for which a custom action
/// class would be too clumsy, e.g. showing tooltips for menuitems in the
/// statusbar.
/// </para>
/// </summary>

	public static IObservable<GtkUIManagerHandleSignalStructs.ConnectProxySignal> Signal_ConnectProxy(this GtkUIManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkUIManagerHandleSignalStructs.ConnectProxySignal> obs) =>
		{
			GtkUIManagerHandleSignalDelegates.connect_proxy handler = ( MentorLake.Gtk.GtkUIManagerHandle self,  MentorLake.Gtk.GtkActionHandle action,  MentorLake.Gtk.GtkWidgetHandle proxy,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkUIManagerHandleSignalStructs.ConnectProxySignal()
				{
					Self = self, Action = action, Proxy = proxy, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "connect-proxy", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::disconnect-proxy signal is emitted after disconnecting a proxy
/// from an action in the group.
/// </para>
/// </summary>

	public static IObservable<GtkUIManagerHandleSignalStructs.DisconnectProxySignal> Signal_DisconnectProxy(this GtkUIManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkUIManagerHandleSignalStructs.DisconnectProxySignal> obs) =>
		{
			GtkUIManagerHandleSignalDelegates.disconnect_proxy handler = ( MentorLake.Gtk.GtkUIManagerHandle self,  MentorLake.Gtk.GtkActionHandle action,  MentorLake.Gtk.GtkWidgetHandle proxy,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkUIManagerHandleSignalStructs.DisconnectProxySignal()
				{
					Self = self, Action = action, Proxy = proxy, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "disconnect-proxy", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::post-activate signal is emitted just after the @action
/// is activated.
/// </para>
/// <para>
/// This is intended for applications to get notification
/// just after any action is activated.
/// </para>
/// </summary>

	public static IObservable<GtkUIManagerHandleSignalStructs.PostActivateSignal> Signal_PostActivate(this GtkUIManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkUIManagerHandleSignalStructs.PostActivateSignal> obs) =>
		{
			GtkUIManagerHandleSignalDelegates.post_activate handler = ( MentorLake.Gtk.GtkUIManagerHandle self,  MentorLake.Gtk.GtkActionHandle action,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkUIManagerHandleSignalStructs.PostActivateSignal()
				{
					Self = self, Action = action, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "post-activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::pre-activate signal is emitted just before the @action
/// is activated.
/// </para>
/// <para>
/// This is intended for applications to get notification
/// just before any action is activated.
/// </para>
/// </summary>

	public static IObservable<GtkUIManagerHandleSignalStructs.PreActivateSignal> Signal_PreActivate(this GtkUIManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkUIManagerHandleSignalStructs.PreActivateSignal> obs) =>
		{
			GtkUIManagerHandleSignalDelegates.pre_activate handler = ( MentorLake.Gtk.GtkUIManagerHandle self,  MentorLake.Gtk.GtkActionHandle action,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkUIManagerHandleSignalStructs.PreActivateSignal()
				{
					Self = self, Action = action, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "pre-activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkUIManagerHandleSignalStructs
{

public class ActionsChangedSignal
{

	public MentorLake.Gtk.GtkUIManagerHandle Self;

	public IntPtr UserData;
}

public class AddWidgetSignal
{

	public MentorLake.Gtk.GtkUIManagerHandle Self;
/// <summary>
/// <para>
/// the added widget
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle Widget;

	public IntPtr UserData;
}

public class ConnectProxySignal
{

	public MentorLake.Gtk.GtkUIManagerHandle Self;
/// <summary>
/// <para>
/// the action
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkActionHandle Action;
/// <summary>
/// <para>
/// the proxy
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle Proxy;

	public IntPtr UserData;
}

public class DisconnectProxySignal
{

	public MentorLake.Gtk.GtkUIManagerHandle Self;
/// <summary>
/// <para>
/// the action
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkActionHandle Action;
/// <summary>
/// <para>
/// the proxy
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle Proxy;

	public IntPtr UserData;
}

public class PostActivateSignal
{

	public MentorLake.Gtk.GtkUIManagerHandle Self;
/// <summary>
/// <para>
/// the action
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkActionHandle Action;

	public IntPtr UserData;
}

public class PreActivateSignal
{

	public MentorLake.Gtk.GtkUIManagerHandle Self;
/// <summary>
/// <para>
/// the action
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkActionHandle Action;

	public IntPtr UserData;
}
}

public static class GtkUIManagerHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::actions-changed signal is emitted whenever the set of actions
/// changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void actions_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::add-widget signal is emitted for each generated menubar and toolbar.
/// It is not emitted for generated popup menus, which can be obtained by
/// gtk_ui_manager_get_widget().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="widget">
/// the added widget
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void add_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, IntPtr user_data);


/// <summary>
/// <para>
/// The ::connect-proxy signal is emitted after connecting a proxy to
/// an action in the group.
/// </para>
/// <para>
/// This is intended for simple customizations for which a custom action
/// class would be too clumsy, e.g. showing tooltips for menuitems in the
/// statusbar.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="action">
/// the action
/// </param>
/// <param name="proxy">
/// the proxy
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void connect_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle proxy, IntPtr user_data);


/// <summary>
/// <para>
/// The ::disconnect-proxy signal is emitted after disconnecting a proxy
/// from an action in the group.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="action">
/// the action
/// </param>
/// <param name="proxy">
/// the proxy
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void disconnect_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle proxy, IntPtr user_data);


/// <summary>
/// <para>
/// The ::post-activate signal is emitted just after the @action
/// is activated.
/// </para>
/// <para>
/// This is intended for applications to get notification
/// just after any action is activated.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="action">
/// the action
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void post_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, IntPtr user_data);


/// <summary>
/// <para>
/// The ::pre-activate signal is emitted just before the @action
/// is activated.
/// </para>
/// <para>
/// This is intended for applications to get notification
/// just before any action is activated.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="action">
/// the action
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void pre_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, IntPtr user_data);

}


public static class GtkUIManagerHandleExtensions
{
/// <summary>
/// <para>
/// Adds a UI element to the current contents of @manager.
/// </para>
/// <para>
/// If @type is %GTK_UI_MANAGER_AUTO, GTK+ inserts a menuitem, toolitem or
/// separator if such an element can be inserted at the place determined by
/// @path. Otherwise @type must indicate an element that can be inserted at
/// the place determined by @path.
/// </para>
/// <para>
/// If @path points to a menuitem or toolitem, the new element will be inserted
/// before or after this item, depending on @top.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkUIManager
/// </param>
/// <param name="merge_id">
/// the merge id for the merged UI, see gtk_ui_manager_new_merge_id()
/// </param>
/// <param name="path">
/// a path
/// </param>
/// <param name="name">
/// the name for the added UI element
/// </param>
/// <param name="action">
/// the name of the action to be proxied, or %NULL to add a separator
/// </param>
/// <param name="type">
/// the type of UI element to add.
/// </param>
/// <param name="top">
/// if %TRUE, the UI element is added before its siblings, otherwise it
///   is added after its siblings.
/// </param>

	public static T AddUi<T>(this T manager, uint merge_id, string path, string name, string action, MentorLake.Gtk.GtkUIManagerItemType type, bool top) where T : GtkUIManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		GtkUIManagerHandleExterns.gtk_ui_manager_add_ui(manager, merge_id, path, name, action, type, top);
		return manager;
	}

/// <summary>
/// <para>
/// Parses a file containing a [UI definition][XML-UI] and
/// merges it with the current contents of @manager.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkUIManager object
/// </param>
/// <param name="filename">
/// the name of the file to parse
/// </param>
/// <return>
/// The merge id for the merged UI. The merge id can be used
///   to unmerge the UI with gtk_ui_manager_remove_ui(). If an error occurred,
///   the return value is 0.
/// </return>

	public static uint AddUiFromFile(this MentorLake.Gtk.GtkUIManagerHandle manager, string filename)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		var externCallResult = GtkUIManagerHandleExterns.gtk_ui_manager_add_ui_from_file(manager, filename, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Parses a resource file containing a [UI definition][XML-UI] and
/// merges it with the current contents of @manager.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkUIManager object
/// </param>
/// <param name="resource_path">
/// the resource path of the file to parse
/// </param>
/// <return>
/// The merge id for the merged UI. The merge id can be used
///   to unmerge the UI with gtk_ui_manager_remove_ui(). If an error occurred,
///   the return value is 0.
/// </return>

	public static uint AddUiFromResource(this MentorLake.Gtk.GtkUIManagerHandle manager, string resource_path)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		var externCallResult = GtkUIManagerHandleExterns.gtk_ui_manager_add_ui_from_resource(manager, resource_path, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Parses a string containing a [UI definition][XML-UI] and merges it with
/// the current contents of @manager. An enclosing `<ui>` element is added if
/// it is missing.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkUIManager object
/// </param>
/// <param name="buffer">
/// the string to parse
/// </param>
/// <param name="length">
/// the length of @buffer (may be -1 if @buffer is nul-terminated)
/// </param>
/// <return>
/// The merge id for the merged UI. The merge id can be used
///   to unmerge the UI with gtk_ui_manager_remove_ui(). If an error occurred,
///   the return value is 0.
/// </return>

	public static uint AddUiFromString(this MentorLake.Gtk.GtkUIManagerHandle manager, string buffer, UIntPtr length)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		var externCallResult = GtkUIManagerHandleExterns.gtk_ui_manager_add_ui_from_string(manager, buffer, length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Makes sure that all pending updates to the UI have been completed.
/// </para>
/// <para>
/// This may occasionally be necessary, since #GtkUIManager updates the
/// UI in an idle function. A typical example where this function is
/// useful is to enforce that the menubar and toolbar have been added to
/// the main window before showing it:
/// |[<!-- language="C" -->
/// gtk_container_add (GTK_CONTAINER (window), vbox);
/// g_signal_connect (merge, "add-widget",
///                   G_CALLBACK (add_widget), vbox);
/// gtk_ui_manager_add_ui_from_file (merge, "my-menus");
/// gtk_ui_manager_add_ui_from_file (merge, "my-toolbars");
/// gtk_ui_manager_ensure_update (merge);
/// gtk_widget_show (window);
/// ]|
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkUIManager
/// </param>

	public static T EnsureUpdate<T>(this T manager) where T : GtkUIManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		GtkUIManagerHandleExterns.gtk_ui_manager_ensure_update(manager);
		return manager;
	}

/// <summary>
/// <para>
/// Returns the #GtkAccelGroup associated with @manager.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkUIManager object
/// </param>
/// <return>
/// the #GtkAccelGroup.
/// </return>

	public static MentorLake.Gtk.GtkAccelGroupHandle GetAccelGroup(this MentorLake.Gtk.GtkUIManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		return GtkUIManagerHandleExterns.gtk_ui_manager_get_accel_group(manager);
	}

/// <summary>
/// <para>
/// Looks up an action by following a path. See gtk_ui_manager_get_widget()
/// for more information about paths.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkUIManager
/// </param>
/// <param name="path">
/// a path
/// </param>
/// <return>
/// the action whose proxy widget is found by following the path,
///     or %NULL if no widget was found.
/// </return>

	public static MentorLake.Gtk.GtkActionHandle GetAction(this MentorLake.Gtk.GtkUIManagerHandle manager, string path)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		return GtkUIManagerHandleExterns.gtk_ui_manager_get_action(manager, path);
	}

/// <summary>
/// <para>
/// Returns the list of action groups associated with @manager.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkUIManager object
/// </param>
/// <return>
/// a #GList of
///   action groups. The list is owned by GTK+
///   and should not be modified.
/// </return>

	public static MentorLake.GLib.GListHandle GetActionGroups(this MentorLake.Gtk.GtkUIManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		return GtkUIManagerHandleExterns.gtk_ui_manager_get_action_groups(manager);
	}

/// <summary>
/// <para>
/// Returns whether menus generated by this #GtkUIManager
/// will have tearoff menu items.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkUIManager
/// </param>
/// <return>
/// whether tearoff menu items are added
/// </return>

	public static bool GetAddTearoffs(this MentorLake.Gtk.GtkUIManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		return GtkUIManagerHandleExterns.gtk_ui_manager_get_add_tearoffs(manager);
	}

/// <summary>
/// <para>
/// Obtains a list of all toplevel widgets of the requested types.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkUIManager
/// </param>
/// <param name="types">
/// specifies the types of toplevel widgets to include. Allowed
///   types are #GTK_UI_MANAGER_MENUBAR, #GTK_UI_MANAGER_TOOLBAR and
///   #GTK_UI_MANAGER_POPUP.
/// </param>
/// <return>
/// a newly-allocated #GSList of
/// all toplevel widgets of the requested types.  Free the returned list with g_slist_free().
/// </return>

	public static MentorLake.GLib.GSListHandle GetToplevels(this MentorLake.Gtk.GtkUIManagerHandle manager, MentorLake.Gtk.GtkUIManagerItemType types)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		return GtkUIManagerHandleExterns.gtk_ui_manager_get_toplevels(manager, types);
	}

/// <summary>
/// <para>
/// Creates a [UI definition][XML-UI] of the merged UI.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkUIManager
/// </param>
/// <return>
/// A newly allocated string containing an XML representation of
/// the merged UI.
/// </return>

	public static string GetUi(this MentorLake.Gtk.GtkUIManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		return GtkUIManagerHandleExterns.gtk_ui_manager_get_ui(manager);
	}

/// <summary>
/// <para>
/// Looks up a widget by following a path.
/// The path consists of the names specified in the XML description of the UI.
/// separated by “/”. Elements which don’t have a name or action attribute in
/// the XML (e.g. `<popup>`) can be addressed by their XML element name
/// (e.g. "popup"). The root element ("/ui") can be omitted in the path.
/// </para>
/// <para>
/// Note that the widget found by following a path that ends in a `<menu>`;
/// element is the menuitem to which the menu is attached, not the menu it
/// manages.
/// </para>
/// <para>
/// Also note that the widgets constructed by a ui manager are not tied to
/// the lifecycle of the ui manager. If you add the widgets returned by this
/// function to some container or explicitly ref them, they will survive the
/// destruction of the ui manager.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkUIManager
/// </param>
/// <param name="path">
/// a path
/// </param>
/// <return>
/// the widget found by following the path,
///     or %NULL if no widget was found
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetWidget(this MentorLake.Gtk.GtkUIManagerHandle manager, string path)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		return GtkUIManagerHandleExterns.gtk_ui_manager_get_widget(manager, path);
	}

/// <summary>
/// <para>
/// Inserts an action group into the list of action groups associated
/// with @manager. Actions in earlier groups hide actions with the same
/// name in later groups.
/// </para>
/// <para>
/// If @pos is larger than the number of action groups in @manager, or
/// negative, @action_group will be inserted at the end of the internal
/// list.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkUIManager object
/// </param>
/// <param name="action_group">
/// the action group to be inserted
/// </param>
/// <param name="pos">
/// the position at which the group will be inserted.
/// </param>

	public static T InsertActionGroup<T>(this T manager, MentorLake.Gtk.GtkActionGroupHandle action_group, int pos) where T : GtkUIManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		GtkUIManagerHandleExterns.gtk_ui_manager_insert_action_group(manager, action_group, pos);
		return manager;
	}

/// <summary>
/// <para>
/// Returns an unused merge id, suitable for use with
/// gtk_ui_manager_add_ui().
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkUIManager
/// </param>
/// <return>
/// an unused merge id.
/// </return>

	public static uint NewMergeId(this MentorLake.Gtk.GtkUIManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		return GtkUIManagerHandleExterns.gtk_ui_manager_new_merge_id(manager);
	}

/// <summary>
/// <para>
/// Removes an action group from the list of action groups associated
/// with @manager.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkUIManager object
/// </param>
/// <param name="action_group">
/// the action group to be removed
/// </param>

	public static T RemoveActionGroup<T>(this T manager, MentorLake.Gtk.GtkActionGroupHandle action_group) where T : GtkUIManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		GtkUIManagerHandleExterns.gtk_ui_manager_remove_action_group(manager, action_group);
		return manager;
	}

/// <summary>
/// <para>
/// Unmerges the part of @manager's content identified by @merge_id.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkUIManager object
/// </param>
/// <param name="merge_id">
/// a merge id as returned by gtk_ui_manager_add_ui_from_string()
/// </param>

	public static T RemoveUi<T>(this T manager, uint merge_id) where T : GtkUIManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		GtkUIManagerHandleExterns.gtk_ui_manager_remove_ui(manager, merge_id);
		return manager;
	}

/// <summary>
/// <para>
/// Sets the “add_tearoffs” property, which controls whether menus
/// generated by this #GtkUIManager will have tearoff menu items.
/// </para>
/// <para>
/// Note that this only affects regular menus. Generated popup
/// menus never have tearoff menu items.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkUIManager
/// </param>
/// <param name="add_tearoffs">
/// whether tearoff menu items are added
/// </param>

	public static T SetAddTearoffs<T>(this T manager, bool add_tearoffs) where T : GtkUIManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		GtkUIManagerHandleExterns.gtk_ui_manager_set_add_tearoffs(manager, add_tearoffs);
		return manager;
	}

}

internal class GtkUIManagerHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))]
	internal static extern MentorLake.Gtk.GtkUIManagerHandle gtk_ui_manager_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_ui_manager_add_ui([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager, uint merge_id, string path, string name, string action, MentorLake.Gtk.GtkUIManagerItemType type, bool top);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_ui_manager_add_ui_from_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager, string filename, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_ui_manager_add_ui_from_resource([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager, string resource_path, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_ui_manager_add_ui_from_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager, string buffer, UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_ui_manager_ensure_update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))]
	internal static extern MentorLake.Gtk.GtkAccelGroupHandle gtk_ui_manager_get_accel_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))]
	internal static extern MentorLake.Gtk.GtkActionHandle gtk_ui_manager_get_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager, string path);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_ui_manager_get_action_groups([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_ui_manager_get_add_tearoffs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_ui_manager_get_toplevels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager, MentorLake.Gtk.GtkUIManagerItemType types);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_ui_manager_get_ui([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_ui_manager_get_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager, string path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_ui_manager_insert_action_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, int pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_ui_manager_new_merge_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_ui_manager_remove_action_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_ui_manager_remove_ui([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager, uint merge_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_ui_manager_set_add_tearoffs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager, bool add_tearoffs);

}
