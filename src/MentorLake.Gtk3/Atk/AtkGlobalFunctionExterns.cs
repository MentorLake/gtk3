namespace MentorLake.Gtk3.Atk;

public class AtkGlobalFunction
{
	[DllImport(Libraries.Atk)]
	internal static extern uint atk_get_binary_age();

	[DllImport(Libraries.Atk)]
	internal static extern uint atk_add_focus_tracker(AtkEventListener focus_tracker);

	[DllImport(Libraries.Atk)]
	internal static extern AtkRegistryHandle atk_get_default_registry();

	[DllImport(Libraries.Atk)]
	internal static extern void atk_remove_global_event_listener(uint listener_id);

	[DllImport(Libraries.Atk)]
	internal static extern uint atk_get_minor_version();

	[DllImport(Libraries.Atk)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_get_toolkit_name();

	[DllImport(Libraries.Atk)]
	internal static extern AtkObjectHandle atk_get_focus_object();

	[DllImport(Libraries.Atk)]
	internal static extern uint atk_add_key_event_listener(AtkKeySnoopFunc listener, IntPtr data);

	[DllImport(Libraries.Atk)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_get_version();

	[DllImport(Libraries.Atk)]
	internal static extern uint atk_get_micro_version();

	[DllImport(Libraries.Atk)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_get_toolkit_version();

	[DllImport(Libraries.Atk)]
	internal static extern void atk_remove_focus_tracker(uint tracker_id);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_remove_key_event_listener(uint listener_id);

	[DllImport(Libraries.Atk)]
	internal static extern AtkObjectHandle atk_get_root();

	[DllImport(Libraries.Atk)]
	internal static extern void atk_focus_tracker_init(AtkEventListenerInit init);

	[DllImport(Libraries.Atk)]
	internal static extern uint atk_get_major_version();

	[DllImport(Libraries.Atk)]
	internal static extern uint atk_get_interface_age();

	[DllImport(Libraries.Atk)]
	internal static extern uint atk_add_global_event_listener(GSignalEmissionHook listener, string event_type);

}
