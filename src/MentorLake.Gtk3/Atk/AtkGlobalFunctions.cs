namespace MentorLake.Atk;

public class AtkGlobalFunctions
{
	public static uint AddFocusTracker(MentorLake.Atk.AtkEventListener focus_tracker)
	{
		return AtkGlobalFunctionsExterns.atk_add_focus_tracker(focus_tracker);
	}

	public static uint AddGlobalEventListener(MentorLake.GObject.GSignalEmissionHook listener, string event_type)
	{
		return AtkGlobalFunctionsExterns.atk_add_global_event_listener(listener, event_type);
	}

	public static uint AddKeyEventListener(MentorLake.Atk.AtkKeySnoopFunc listener, IntPtr data)
	{
		return AtkGlobalFunctionsExterns.atk_add_key_event_listener(listener, data);
	}

	public static void AttributeSetFree(MentorLake.Atk.AtkAttributeSetHandle attrib_set)
	{
		AtkGlobalFunctionsExterns.atk_attribute_set_free(attrib_set);
	}

	public static void FocusTrackerInit(MentorLake.Atk.AtkEventListenerInit init)
	{
		AtkGlobalFunctionsExterns.atk_focus_tracker_init(init);
	}

	public static void FocusTrackerNotify(MentorLake.Atk.AtkObjectHandle @object)
	{
		AtkGlobalFunctionsExterns.atk_focus_tracker_notify(@object);
	}

	public static uint GetBinaryAge()
	{
		return AtkGlobalFunctionsExterns.atk_get_binary_age();
	}

	public static MentorLake.Atk.AtkRegistryHandle GetDefaultRegistry()
	{
		return AtkGlobalFunctionsExterns.atk_get_default_registry();
	}

	public static MentorLake.Atk.AtkObjectHandle GetFocusObject()
	{
		return AtkGlobalFunctionsExterns.atk_get_focus_object();
	}

	public static uint GetInterfaceAge()
	{
		return AtkGlobalFunctionsExterns.atk_get_interface_age();
	}

	public static uint GetMajorVersion()
	{
		return AtkGlobalFunctionsExterns.atk_get_major_version();
	}

	public static uint GetMicroVersion()
	{
		return AtkGlobalFunctionsExterns.atk_get_micro_version();
	}

	public static uint GetMinorVersion()
	{
		return AtkGlobalFunctionsExterns.atk_get_minor_version();
	}

	public static MentorLake.Atk.AtkObjectHandle GetRoot()
	{
		return AtkGlobalFunctionsExterns.atk_get_root();
	}

	public static string GetToolkitName()
	{
		return AtkGlobalFunctionsExterns.atk_get_toolkit_name();
	}

	public static string GetToolkitVersion()
	{
		return AtkGlobalFunctionsExterns.atk_get_toolkit_version();
	}

	public static string GetVersion()
	{
		return AtkGlobalFunctionsExterns.atk_get_version();
	}

	public static MentorLake.Atk.AtkRelationType RelationTypeForName(string name)
	{
		return AtkGlobalFunctionsExterns.atk_relation_type_for_name(name);
	}

	public static string RelationTypeGetName(MentorLake.Atk.AtkRelationType type)
	{
		return AtkGlobalFunctionsExterns.atk_relation_type_get_name(type);
	}

	public static MentorLake.Atk.AtkRelationType RelationTypeRegister(string name)
	{
		return AtkGlobalFunctionsExterns.atk_relation_type_register(name);
	}

	public static void RemoveFocusTracker(uint tracker_id)
	{
		AtkGlobalFunctionsExterns.atk_remove_focus_tracker(tracker_id);
	}

	public static void RemoveGlobalEventListener(uint listener_id)
	{
		AtkGlobalFunctionsExterns.atk_remove_global_event_listener(listener_id);
	}

	public static void RemoveKeyEventListener(uint listener_id)
	{
		AtkGlobalFunctionsExterns.atk_remove_key_event_listener(listener_id);
	}

	public static MentorLake.Atk.AtkRole RoleForName(string name)
	{
		return AtkGlobalFunctionsExterns.atk_role_for_name(name);
	}

	public static string RoleGetLocalizedName(MentorLake.Atk.AtkRole role)
	{
		return AtkGlobalFunctionsExterns.atk_role_get_localized_name(role);
	}

	public static string RoleGetName(MentorLake.Atk.AtkRole role)
	{
		return AtkGlobalFunctionsExterns.atk_role_get_name(role);
	}

	public static MentorLake.Atk.AtkRole RoleRegister(string name)
	{
		return AtkGlobalFunctionsExterns.atk_role_register(name);
	}

	public static MentorLake.Atk.AtkStateType StateTypeForName(string name)
	{
		return AtkGlobalFunctionsExterns.atk_state_type_for_name(name);
	}

	public static string StateTypeGetName(MentorLake.Atk.AtkStateType type)
	{
		return AtkGlobalFunctionsExterns.atk_state_type_get_name(type);
	}

	public static MentorLake.Atk.AtkStateType StateTypeRegister(string name)
	{
		return AtkGlobalFunctionsExterns.atk_state_type_register(name);
	}

	public static MentorLake.Atk.AtkTextAttribute TextAttributeForName(string name)
	{
		return AtkGlobalFunctionsExterns.atk_text_attribute_for_name(name);
	}

	public static string TextAttributeGetName(MentorLake.Atk.AtkTextAttribute attr)
	{
		return AtkGlobalFunctionsExterns.atk_text_attribute_get_name(attr);
	}

	public static string TextAttributeGetValue(MentorLake.Atk.AtkTextAttribute attr, int index_)
	{
		return AtkGlobalFunctionsExterns.atk_text_attribute_get_value(attr, index_);
	}

	public static MentorLake.Atk.AtkTextAttribute TextAttributeRegister(string name)
	{
		return AtkGlobalFunctionsExterns.atk_text_attribute_register(name);
	}

	public static void TextFreeRanges(MentorLake.Atk.AtkTextRangeHandle[] ranges)
	{
		AtkGlobalFunctionsExterns.atk_text_free_ranges(ranges);
	}

	public static string ValueTypeGetLocalizedName(MentorLake.Atk.AtkValueType value_type)
	{
		return AtkGlobalFunctionsExterns.atk_value_type_get_localized_name(value_type);
	}

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
