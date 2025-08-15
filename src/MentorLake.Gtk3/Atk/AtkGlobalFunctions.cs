namespace MentorLake.Atk;

public class AtkGlobalFunctions
{
/// <summary>
/// <para>
/// Adds the specified function to the list of functions to be called
/// when an object receives focus.
/// </para>
/// </summary>

/// <param name="focus_tracker">
/// Function to be added to the list of functions to be called
/// when an object receives focus.
/// </param>
/// <return>
/// added focus tracker id, or 0 on failure.
/// </return>

	public static uint AddFocusTracker(MentorLake.Atk.AtkEventListener focus_tracker)
	{
		return AtkGlobalFunctionsExterns.atk_add_focus_tracker(focus_tracker);
	}

/// <summary>
/// <para>
/// Adds the specified function to the list of functions to be called
/// when an ATK event of type event_type occurs.
/// </para>
/// <para>
/// The format of event_type is the following:
///  &quot;ATK:&amp;lt;atk_type&amp;gt;:&amp;lt;atk_event&amp;gt;:&amp;lt;atk_event_detail&amp;gt;
/// </para>
/// <para>
/// Where &quot;ATK&quot; works as the namespace, &amp;lt;atk_interface&amp;gt; is the name of
/// the ATK type (interface or object), &amp;lt;atk_event&amp;gt; is the name of the
/// signal defined on that interface and &amp;lt;atk_event_detail&amp;gt; is the
/// gsignal detail of that signal. You can find more info about gsignal
/// details here:
/// http://developer.gnome.org/gobject/stable/gobject-Signals.html
/// </para>
/// <para>
/// The first three parameters are mandatory. The last one is optional.
/// </para>
/// <para>
/// For example:
///   ATK:AtkObject:state-change
///   ATK:AtkText:text-selection-changed
///   ATK:AtkText:text-insert:system
/// </para>
/// <para>
/// Toolkit implementor note: ATK provides a default implementation for
/// this virtual method. ATK implementors are discouraged from
/// reimplementing this method.
/// </para>
/// <para>
/// Toolkit implementor note: this method is not intended to be used by
/// ATK implementors but by ATK consumers.
/// </para>
/// <para>
/// ATK consumers note: as this method adds a listener for a given ATK
/// type, that type should be already registered on the GType system
/// before calling this method. A simple way to do that is creating an
/// instance of #AtkNoOpObject. This class implements all ATK
/// interfaces, so creating the instance will register all ATK types as
/// a collateral effect.
/// </para>
/// </summary>

/// <param name="listener">
/// the listener to notify
/// </param>
/// <param name="event_type">
/// the type of event for which notification is requested
/// </param>
/// <return>
/// added event listener id, or 0 on failure.
/// </return>

	public static uint AddGlobalEventListener(MentorLake.GObject.GSignalEmissionHook listener, string event_type)
	{
		return AtkGlobalFunctionsExterns.atk_add_global_event_listener(listener, event_type);
	}

/// <summary>
/// <para>
/// Adds the specified function to the list of functions to be called
///        when a key event occurs.  The @data element will be passed to the
///        #AtkKeySnoopFunc (@listener) as the @func_data param, on notification.
/// </para>
/// </summary>

/// <param name="listener">
/// the listener to notify
/// </param>
/// <param name="data">
/// a #gpointer that points to a block of data that should be sent to the registered listeners,
///        along with the event notification, when it occurs.
/// </param>
/// <return>
/// added event listener id, or 0 on failure.
/// </return>

	public static uint AddKeyEventListener(MentorLake.Atk.AtkKeySnoopFunc listener, IntPtr data)
	{
		return AtkGlobalFunctionsExterns.atk_add_key_event_listener(listener, data);
	}

/// <summary>
/// <para>
/// Frees the memory used by an #AtkAttributeSet, including all its
/// #AtkAttributes.
/// </para>
/// </summary>

/// <param name="attrib_set">
/// The #AtkAttributeSet to free
/// </param>

	public static void AttributeSetFree(MentorLake.Atk.AtkAttributeSetHandle attrib_set)
	{
		AtkGlobalFunctionsExterns.atk_attribute_set_free(attrib_set);
	}

/// <summary>
/// <para>
/// Specifies the function to be called for focus tracker initialization.
/// This function should be called by an implementation of the
/// ATK interface if any specific work needs to be done to enable
/// focus tracking.
/// </para>
/// </summary>

/// <param name="init">
/// Function to be called for focus tracker initialization
/// </param>

	public static void FocusTrackerInit(MentorLake.Atk.AtkEventListenerInit init)
	{
		AtkGlobalFunctionsExterns.atk_focus_tracker_init(init);
	}

/// <summary>
/// <para>
/// Cause the focus tracker functions which have been specified to be
/// executed for the object.
/// </para>
/// </summary>

/// <param name="@object">
/// an #AtkObject
/// </param>

	public static void FocusTrackerNotify(MentorLake.Atk.AtkObjectHandle @object)
	{
		AtkGlobalFunctionsExterns.atk_focus_tracker_notify(@object);
	}

/// <summary>
/// <para>
/// Returns the binary age as passed to libtool when building the ATK
/// library the process is running against.
/// </para>
/// </summary>

/// <return>
/// the binary age of the ATK library
/// </return>

	public static uint GetBinaryAge()
	{
		return AtkGlobalFunctionsExterns.atk_get_binary_age();
	}

/// <summary>
/// <para>
/// Gets a default implementation of the #AtkObjectFactory/type
/// registry.
/// Note: For most toolkit maintainers, this will be the correct
/// registry for registering new #AtkObject factories. Following
/// a call to this function, maintainers may call atk_registry_set_factory_type()
/// to associate an #AtkObjectFactory subclass with the GType of objects
/// for whom accessibility information will be provided.
/// </para>
/// </summary>

/// <return>
/// a default implementation of the
/// #AtkObjectFactory/type registry
/// </return>

	public static MentorLake.Atk.AtkRegistryHandle GetDefaultRegistry()
	{
		return AtkGlobalFunctionsExterns.atk_get_default_registry();
	}

/// <summary>
/// <para>
/// Gets the currently focused object.
/// </para>
/// </summary>

/// <return>
/// the currently focused object for the current
/// application
/// </return>

	public static MentorLake.Atk.AtkObjectHandle GetFocusObject()
	{
		return AtkGlobalFunctionsExterns.atk_get_focus_object();
	}

/// <summary>
/// <para>
/// Returns the interface age as passed to libtool when building the
/// ATK library the process is running against.
/// </para>
/// </summary>

/// <return>
/// the interface age of the ATK library
/// </return>

	public static uint GetInterfaceAge()
	{
		return AtkGlobalFunctionsExterns.atk_get_interface_age();
	}

/// <summary>
/// <para>
/// Returns the major version number of the ATK library.  (e.g. in ATK
/// version 2.7.4 this is 2.)
/// </para>
/// <para>
/// This function is in the library, so it represents the ATK library
/// your code is running against. In contrast, the #ATK_MAJOR_VERSION
/// macro represents the major version of the ATK headers you have
/// included when compiling your code.
/// </para>
/// </summary>

/// <return>
/// the major version number of the ATK library
/// </return>

	public static uint GetMajorVersion()
	{
		return AtkGlobalFunctionsExterns.atk_get_major_version();
	}

/// <summary>
/// <para>
/// Returns the micro version number of the ATK library.  (e.g. in ATK
/// version 2.7.4 this is 4.)
/// </para>
/// <para>
/// This function is in the library, so it represents the ATK library
/// your code is are running against. In contrast, the
/// #ATK_MICRO_VERSION macro represents the micro version of the ATK
/// headers you have included when compiling your code.
/// </para>
/// </summary>

/// <return>
/// the micro version number of the ATK library
/// </return>

	public static uint GetMicroVersion()
	{
		return AtkGlobalFunctionsExterns.atk_get_micro_version();
	}

/// <summary>
/// <para>
/// Returns the minor version number of the ATK library.  (e.g. in ATK
/// version 2.7.4 this is 7.)
/// </para>
/// <para>
/// This function is in the library, so it represents the ATK library
/// your code is are running against. In contrast, the
/// #ATK_MINOR_VERSION macro represents the minor version of the ATK
/// headers you have included when compiling your code.
/// </para>
/// </summary>

/// <return>
/// the minor version number of the ATK library
/// </return>

	public static uint GetMinorVersion()
	{
		return AtkGlobalFunctionsExterns.atk_get_minor_version();
	}

/// <summary>
/// <para>
/// Gets the root accessible container for the current application.
/// </para>
/// </summary>

/// <return>
/// the root accessible container for the current
/// application
/// </return>

	public static MentorLake.Atk.AtkObjectHandle GetRoot()
	{
		return AtkGlobalFunctionsExterns.atk_get_root();
	}

/// <summary>
/// <para>
/// Gets name string for the GUI toolkit implementing ATK for this application.
/// </para>
/// </summary>

/// <return>
/// name string for the GUI toolkit implementing ATK for this application
/// </return>

	public static string GetToolkitName()
	{
		return AtkGlobalFunctionsExterns.atk_get_toolkit_name();
	}

/// <summary>
/// <para>
/// Gets version string for the GUI toolkit implementing ATK for this application.
/// </para>
/// </summary>

/// <return>
/// version string for the GUI toolkit implementing ATK for this application
/// </return>

	public static string GetToolkitVersion()
	{
		return AtkGlobalFunctionsExterns.atk_get_toolkit_version();
	}

/// <summary>
/// <para>
/// Gets the current version for ATK.
/// </para>
/// </summary>

/// <return>
/// version string for ATK
/// </return>

	public static string GetVersion()
	{
		return AtkGlobalFunctionsExterns.atk_get_version();
	}

/// <summary>
/// <para>
/// Get the #AtkRelationType type corresponding to a relation name.
/// </para>
/// </summary>

/// <param name="name">
/// a string which is the (non-localized) name of an ATK relation type.
/// </param>
/// <return>
/// the #AtkRelationType enumerated type corresponding to the specified name,
///          or #ATK_RELATION_NULL if no matching relation type is found.
/// </return>

	public static MentorLake.Atk.AtkRelationType RelationTypeForName(string name)
	{
		return AtkGlobalFunctionsExterns.atk_relation_type_for_name(name);
	}

/// <summary>
/// <para>
/// Gets the description string describing the #AtkRelationType @type.
/// </para>
/// </summary>

/// <param name="type">
/// The #AtkRelationType whose name is required
/// </param>
/// <return>
/// the string describing the AtkRelationType
/// </return>

	public static string RelationTypeGetName(MentorLake.Atk.AtkRelationType type)
	{
		return AtkGlobalFunctionsExterns.atk_relation_type_get_name(type);
	}

/// <summary>
/// <para>
/// Associate @name with a new #AtkRelationType
/// </para>
/// </summary>

/// <param name="name">
/// a name string
/// </param>
/// <return>
/// an #AtkRelationType associated with @name
/// </return>

	public static MentorLake.Atk.AtkRelationType RelationTypeRegister(string name)
	{
		return AtkGlobalFunctionsExterns.atk_relation_type_register(name);
	}

/// <summary>
/// <para>
/// Removes the specified focus tracker from the list of functions
/// to be called when any object receives focus.
/// </para>
/// </summary>

/// <param name="tracker_id">
/// the id of the focus tracker to remove
/// </param>

	public static void RemoveFocusTracker(uint tracker_id)
	{
		AtkGlobalFunctionsExterns.atk_remove_focus_tracker(tracker_id);
	}

/// <summary>
/// <para>
/// @listener_id is the value returned by #atk_add_global_event_listener
/// when you registered that event listener.
/// </para>
/// <para>
/// Toolkit implementor note: ATK provides a default implementation for
/// this virtual method. ATK implementors are discouraged from
/// reimplementing this method.
/// </para>
/// <para>
/// Toolkit implementor note: this method is not intended to be used by
/// ATK implementors but by ATK consumers.
/// </para>
/// <para>
/// Removes the specified event listener
/// </para>
/// </summary>

/// <param name="listener_id">
/// the id of the event listener to remove
/// </param>

	public static void RemoveGlobalEventListener(uint listener_id)
	{
		AtkGlobalFunctionsExterns.atk_remove_global_event_listener(listener_id);
	}

/// <summary>
/// <para>
/// @listener_id is the value returned by #atk_add_key_event_listener
/// when you registered that event listener.
/// </para>
/// <para>
/// Removes the specified event listener.
/// </para>
/// </summary>

/// <param name="listener_id">
/// the id of the event listener to remove
/// </param>

	public static void RemoveKeyEventListener(uint listener_id)
	{
		AtkGlobalFunctionsExterns.atk_remove_key_event_listener(listener_id);
	}

/// <summary>
/// <para>
/// Get the #AtkRole type corresponding to a rolew name.
/// </para>
/// </summary>

/// <param name="name">
/// a string which is the (non-localized) name of an ATK role.
/// </param>
/// <return>
/// the #AtkRole enumerated type corresponding to the specified name,
///          or #ATK_ROLE_INVALID if no matching role is found.
/// </return>

	public static MentorLake.Atk.AtkRole RoleForName(string name)
	{
		return AtkGlobalFunctionsExterns.atk_role_for_name(name);
	}

/// <summary>
/// <para>
/// Gets the localized description string describing the #AtkRole @role.
/// </para>
/// </summary>

/// <param name="role">
/// The #AtkRole whose localized name is required
/// </param>
/// <return>
/// the localized string describing the AtkRole
/// </return>

	public static string RoleGetLocalizedName(MentorLake.Atk.AtkRole role)
	{
		return AtkGlobalFunctionsExterns.atk_role_get_localized_name(role);
	}

/// <summary>
/// <para>
/// Gets the description string describing the #AtkRole @role.
/// </para>
/// </summary>

/// <param name="role">
/// The #AtkRole whose name is required
/// </param>
/// <return>
/// the string describing the AtkRole
/// </return>

	public static string RoleGetName(MentorLake.Atk.AtkRole role)
	{
		return AtkGlobalFunctionsExterns.atk_role_get_name(role);
	}

/// <summary>
/// <para>
/// Registers the role specified by @name. @name must be a meaningful
/// name. So it should not be empty, or consisting on whitespaces.
/// </para>
/// </summary>

/// <param name="name">
/// a character string describing the new role.
/// </param>
/// <return>
/// an #AtkRole for the new role if added
/// properly. ATK_ROLE_INVALID in case of error.
/// </return>

	public static MentorLake.Atk.AtkRole RoleRegister(string name)
	{
		return AtkGlobalFunctionsExterns.atk_role_register(name);
	}

/// <summary>
/// <para>
/// Gets the #AtkStateType corresponding to the description string @name.
/// </para>
/// </summary>

/// <param name="name">
/// a character string state name
/// </param>
/// <return>
/// an #AtkStateType corresponding to @name
/// </return>

	public static MentorLake.Atk.AtkStateType StateTypeForName(string name)
	{
		return AtkGlobalFunctionsExterns.atk_state_type_for_name(name);
	}

/// <summary>
/// <para>
/// Gets the description string describing the #AtkStateType @type.
/// </para>
/// </summary>

/// <param name="type">
/// The #AtkStateType whose name is required
/// </param>
/// <return>
/// the string describing the AtkStateType
/// </return>

	public static string StateTypeGetName(MentorLake.Atk.AtkStateType type)
	{
		return AtkGlobalFunctionsExterns.atk_state_type_get_name(type);
	}

/// <summary>
/// <para>
/// Register a new object state.
/// </para>
/// </summary>

/// <param name="name">
/// a character string describing the new state.
/// </param>
/// <return>
/// an #AtkState value for the new state.
/// </return>

	public static MentorLake.Atk.AtkStateType StateTypeRegister(string name)
	{
		return AtkGlobalFunctionsExterns.atk_state_type_register(name);
	}

/// <summary>
/// <para>
/// Get the #AtkTextAttribute type corresponding to a text attribute name.
/// </para>
/// </summary>

/// <param name="name">
/// a string which is the (non-localized) name of an ATK text attribute.
/// </param>
/// <return>
/// the #AtkTextAttribute enumerated type corresponding to the specified
///          name, or #ATK_TEXT_ATTRIBUTE_INVALID if no matching text attribute
///          is found.
/// </return>

	public static MentorLake.Atk.AtkTextAttribute TextAttributeForName(string name)
	{
		return AtkGlobalFunctionsExterns.atk_text_attribute_for_name(name);
	}

/// <summary>
/// <para>
/// Gets the name corresponding to the #AtkTextAttribute
/// </para>
/// </summary>

/// <param name="attr">
/// The #AtkTextAttribute whose name is required
/// </param>
/// <return>
/// a string containing the name; this string should not be freed
/// </return>

	public static string TextAttributeGetName(MentorLake.Atk.AtkTextAttribute attr)
	{
		return AtkGlobalFunctionsExterns.atk_text_attribute_get_name(attr);
	}

/// <summary>
/// <para>
/// Gets the value for the index of the #AtkTextAttribute
/// </para>
/// </summary>

/// <param name="attr">
/// The #AtkTextAttribute for which a value is required
/// </param>
/// <param name="index_">
/// The index of the required value
/// </param>
/// <return>
/// a string containing the value; this string
/// should not be freed; %NULL is returned if there are no values
/// maintained for the attr value.
/// </return>

	public static string TextAttributeGetValue(MentorLake.Atk.AtkTextAttribute attr, int index_)
	{
		return AtkGlobalFunctionsExterns.atk_text_attribute_get_value(attr, index_);
	}

/// <summary>
/// <para>
/// Associate @name with a new #AtkTextAttribute
/// </para>
/// </summary>

/// <param name="name">
/// a name string
/// </param>
/// <return>
/// an #AtkTextAttribute associated with @name
/// </return>

	public static MentorLake.Atk.AtkTextAttribute TextAttributeRegister(string name)
	{
		return AtkGlobalFunctionsExterns.atk_text_attribute_register(name);
	}

/// <summary>
/// <para>
/// Frees the memory associated with an array of AtkTextRange. It is assumed
/// that the array was returned by the function atk_text_get_bounded_ranges
/// and is NULL terminated.
/// </para>
/// </summary>

/// <param name="ranges">
/// A pointer to an array of #AtkTextRange which is
///   to be freed.
/// </param>

	public static void TextFreeRanges(MentorLake.Atk.AtkTextRangeHandle[] ranges)
	{
		AtkGlobalFunctionsExterns.atk_text_free_ranges(ranges);
	}

/// <summary>
/// <para>
/// Gets the localized description string describing the #AtkValueType @value_type.
/// </para>
/// </summary>

/// <param name="value_type">
/// The #AtkValueType whose localized name is required
/// </param>
/// <return>
/// the localized string describing the #AtkValueType
/// </return>

	public static string ValueTypeGetLocalizedName(MentorLake.Atk.AtkValueType value_type)
	{
		return AtkGlobalFunctionsExterns.atk_value_type_get_localized_name(value_type);
	}

/// <summary>
/// <para>
/// Gets the description string describing the #AtkValueType @value_type.
/// </para>
/// </summary>

/// <param name="value_type">
/// The #AtkValueType whose name is required
/// </param>
/// <return>
/// the string describing the #AtkValueType
/// </return>

	public static string ValueTypeGetName(MentorLake.Atk.AtkValueType value_type)
	{
		return AtkGlobalFunctionsExterns.atk_value_type_get_name(value_type);
	}

}

internal class AtkGlobalFunctionsExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern uint atk_add_focus_tracker(MentorLake.Atk.AtkEventListener focus_tracker);

	[DllImport(AtkLibrary.Name)]
	internal static extern uint atk_add_global_event_listener(MentorLake.GObject.GSignalEmissionHook listener, string event_type);

	[DllImport(AtkLibrary.Name)]
	internal static extern uint atk_add_key_event_listener(MentorLake.Atk.AtkKeySnoopFunc listener, IntPtr data);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_attribute_set_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkAttributeSetHandle>))] MentorLake.Atk.AtkAttributeSetHandle attrib_set);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_focus_tracker_init(MentorLake.Atk.AtkEventListenerInit init);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_focus_tracker_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle @object);

	[DllImport(AtkLibrary.Name)]
	internal static extern uint atk_get_binary_age();

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Atk.AtkRegistryHandle>))]
	internal static extern MentorLake.Atk.AtkRegistryHandle atk_get_default_registry();

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))]
	internal static extern MentorLake.Atk.AtkObjectHandle atk_get_focus_object();

	[DllImport(AtkLibrary.Name)]
	internal static extern uint atk_get_interface_age();

	[DllImport(AtkLibrary.Name)]
	internal static extern uint atk_get_major_version();

	[DllImport(AtkLibrary.Name)]
	internal static extern uint atk_get_micro_version();

	[DllImport(AtkLibrary.Name)]
	internal static extern uint atk_get_minor_version();

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))]
	internal static extern MentorLake.Atk.AtkObjectHandle atk_get_root();

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_get_toolkit_name();

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_get_toolkit_version();

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_get_version();

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkRelationType atk_relation_type_for_name(string name);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_relation_type_get_name(MentorLake.Atk.AtkRelationType type);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkRelationType atk_relation_type_register(string name);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_remove_focus_tracker(uint tracker_id);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_remove_global_event_listener(uint listener_id);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_remove_key_event_listener(uint listener_id);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkRole atk_role_for_name(string name);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_role_get_localized_name(MentorLake.Atk.AtkRole role);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_role_get_name(MentorLake.Atk.AtkRole role);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkRole atk_role_register(string name);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkStateType atk_state_type_for_name(string name);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_state_type_get_name(MentorLake.Atk.AtkStateType type);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkStateType atk_state_type_register(string name);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkTextAttribute atk_text_attribute_for_name(string name);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_text_attribute_get_name(MentorLake.Atk.AtkTextAttribute attr);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_text_attribute_get_value(MentorLake.Atk.AtkTextAttribute attr, int index_);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkTextAttribute atk_text_attribute_register(string name);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_text_free_ranges([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextRangeHandle>))] MentorLake.Atk.AtkTextRangeHandle[] ranges);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_value_type_get_localized_name(MentorLake.Atk.AtkValueType value_type);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_value_type_get_name(MentorLake.Atk.AtkValueType value_type);

}
