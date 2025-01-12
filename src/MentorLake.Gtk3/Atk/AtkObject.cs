namespace MentorLake.Gtk3.Atk;

public class AtkObjectHandle : GObjectHandle
{
}

public static class AtkObjectSignalExtensions
{

	public static IObservable<AtkObjectSignalStructs.ActiveDescendantChangedSignal> Signal_ActiveDescendantChanged(this AtkObjectHandle instance)
	{
		return Observable.Create((IObserver<AtkObjectSignalStructs.ActiveDescendantChangedSignal> obs) =>
		{
			AtkObjectSignalDelegates.active_descendant_changed handler = (AtkObjectHandle self, AtkObjectHandle arg1, IntPtr user_data) =>
			{
				

				var signalStruct = new AtkObjectSignalStructs.ActiveDescendantChangedSignal()
				{
					Self = self, Arg1 = arg1, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "active_descendant_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<AtkObjectSignalStructs.ChildrenChangedSignal> Signal_ChildrenChanged(this AtkObjectHandle instance)
	{
		return Observable.Create((IObserver<AtkObjectSignalStructs.ChildrenChangedSignal> obs) =>
		{
			AtkObjectSignalDelegates.children_changed handler = (AtkObjectHandle self, uint arg1, AtkObjectHandle arg2, IntPtr user_data) =>
			{
				

				var signalStruct = new AtkObjectSignalStructs.ChildrenChangedSignal()
				{
					Self = self, Arg1 = arg1, Arg2 = arg2, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "children_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<AtkObjectSignalStructs.FocusEventSignal> Signal_FocusEvent(this AtkObjectHandle instance)
	{
		return Observable.Create((IObserver<AtkObjectSignalStructs.FocusEventSignal> obs) =>
		{
			AtkObjectSignalDelegates.focus_event handler = (AtkObjectHandle self, bool arg1, IntPtr user_data) =>
			{
				

				var signalStruct = new AtkObjectSignalStructs.FocusEventSignal()
				{
					Self = self, Arg1 = arg1, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "focus_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<AtkObjectSignalStructs.PropertyChangeSignal> Signal_PropertyChange(this AtkObjectHandle instance)
	{
		return Observable.Create((IObserver<AtkObjectSignalStructs.PropertyChangeSignal> obs) =>
		{
			AtkObjectSignalDelegates.property_change handler = (AtkObjectHandle self, AtkPropertyValuesHandle arg1, IntPtr user_data) =>
			{
				

				var signalStruct = new AtkObjectSignalStructs.PropertyChangeSignal()
				{
					Self = self, Arg1 = arg1, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "property_change", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<AtkObjectSignalStructs.StateChangeSignal> Signal_StateChange(this AtkObjectHandle instance)
	{
		return Observable.Create((IObserver<AtkObjectSignalStructs.StateChangeSignal> obs) =>
		{
			AtkObjectSignalDelegates.state_change handler = (AtkObjectHandle self, string arg1, bool arg2, IntPtr user_data) =>
			{
				

				var signalStruct = new AtkObjectSignalStructs.StateChangeSignal()
				{
					Self = self, Arg1 = arg1, Arg2 = arg2, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "state_change", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<AtkObjectSignalStructs.VisibleDataChangedSignal> Signal_VisibleDataChanged(this AtkObjectHandle instance)
	{
		return Observable.Create((IObserver<AtkObjectSignalStructs.VisibleDataChangedSignal> obs) =>
		{
			AtkObjectSignalDelegates.visible_data_changed handler = (AtkObjectHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new AtkObjectSignalStructs.VisibleDataChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "visible_data_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class AtkObjectSignalStructs
{

public struct ActiveDescendantChangedSignal
{
	public AtkObjectHandle Self;
	public AtkObjectHandle Arg1;
	public IntPtr UserData;
}

public struct ChildrenChangedSignal
{
	public AtkObjectHandle Self;
	public uint Arg1;
	public AtkObjectHandle Arg2;
	public IntPtr UserData;
}

public struct FocusEventSignal
{
	public AtkObjectHandle Self;
	public bool Arg1;
	public IntPtr UserData;
}

public struct PropertyChangeSignal
{
	public AtkObjectHandle Self;
	public AtkPropertyValuesHandle Arg1;
	public IntPtr UserData;
}

public struct StateChangeSignal
{
	public AtkObjectHandle Self;
	public string Arg1;
	public bool Arg2;
	public IntPtr UserData;
}

public struct VisibleDataChangedSignal
{
	public AtkObjectHandle Self;
	public IntPtr UserData;
}
}

public static class AtkObjectSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void active_descendant_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<AtkObjectHandle>))] AtkObjectHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<AtkObjectHandle>))] AtkObjectHandle arg1, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void children_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<AtkObjectHandle>))] AtkObjectHandle self, uint arg1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<AtkObjectHandle>))] AtkObjectHandle arg2, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void focus_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<AtkObjectHandle>))] AtkObjectHandle self, bool arg1, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void property_change([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<AtkObjectHandle>))] AtkObjectHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<AtkPropertyValuesHandle>))] AtkPropertyValuesHandle arg1, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void state_change([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<AtkObjectHandle>))] AtkObjectHandle self, string arg1, bool arg2, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void visible_data_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<AtkObjectHandle>))] AtkObjectHandle self, IntPtr user_data);

}


public static class AtkObjectHandleExtensions
{
	public static bool AddRelationship(this AtkObjectHandle @object, AtkRelationType relationship, AtkObjectHandle target)
	{
		return AtkObjectExterns.atk_object_add_relationship(@object, relationship, target);
	}

	public static uint ConnectPropertyChangeHandler(this AtkObjectHandle accessible, AtkPropertyChangeHandler handler)
	{
		return AtkObjectExterns.atk_object_connect_property_change_handler(accessible, handler);
	}

	public static string GetAccessibleId(this AtkObjectHandle accessible)
	{
		return AtkObjectExterns.atk_object_get_accessible_id(accessible);
	}

	public static AtkAttributeSetHandle GetAttributes(this AtkObjectHandle accessible)
	{
		return AtkObjectExterns.atk_object_get_attributes(accessible);
	}

	public static string GetDescription(this AtkObjectHandle accessible)
	{
		return AtkObjectExterns.atk_object_get_description(accessible);
	}

	public static int GetIndexInParent(this AtkObjectHandle accessible)
	{
		return AtkObjectExterns.atk_object_get_index_in_parent(accessible);
	}

	public static AtkLayer GetLayer(this AtkObjectHandle accessible)
	{
		return AtkObjectExterns.atk_object_get_layer(accessible);
	}

	public static int GetMdiZorder(this AtkObjectHandle accessible)
	{
		return AtkObjectExterns.atk_object_get_mdi_zorder(accessible);
	}

	public static int GetNAccessibleChildren(this AtkObjectHandle accessible)
	{
		return AtkObjectExterns.atk_object_get_n_accessible_children(accessible);
	}

	public static string GetName(this AtkObjectHandle accessible)
	{
		return AtkObjectExterns.atk_object_get_name(accessible);
	}

	public static string GetObjectLocale(this AtkObjectHandle accessible)
	{
		return AtkObjectExterns.atk_object_get_object_locale(accessible);
	}

	public static AtkObjectHandle GetParent(this AtkObjectHandle accessible)
	{
		return AtkObjectExterns.atk_object_get_parent(accessible);
	}

	public static AtkRole GetRole(this AtkObjectHandle accessible)
	{
		return AtkObjectExterns.atk_object_get_role(accessible);
	}

	public static T Initialize<T>(this T accessible, IntPtr data) where T : AtkObjectHandle
	{
		AtkObjectExterns.atk_object_initialize(accessible, data);
		return accessible;
	}

	public static T NotifyStateChange<T>(this T accessible, AtkState state, bool value) where T : AtkObjectHandle
	{
		AtkObjectExterns.atk_object_notify_state_change(accessible, state, value);
		return accessible;
	}

	public static AtkObjectHandle PeekParent(this AtkObjectHandle accessible)
	{
		return AtkObjectExterns.atk_object_peek_parent(accessible);
	}

	public static AtkObjectHandle RefAccessibleChild(this AtkObjectHandle accessible, int i)
	{
		return AtkObjectExterns.atk_object_ref_accessible_child(accessible, i);
	}

	public static AtkRelationSetHandle RefRelationSet(this AtkObjectHandle accessible)
	{
		return AtkObjectExterns.atk_object_ref_relation_set(accessible);
	}

	public static AtkStateSetHandle RefStateSet(this AtkObjectHandle accessible)
	{
		return AtkObjectExterns.atk_object_ref_state_set(accessible);
	}

	public static T RemovePropertyChangeHandler<T>(this T accessible, uint handler_id) where T : AtkObjectHandle
	{
		AtkObjectExterns.atk_object_remove_property_change_handler(accessible, handler_id);
		return accessible;
	}

	public static bool RemoveRelationship(this AtkObjectHandle @object, AtkRelationType relationship, AtkObjectHandle target)
	{
		return AtkObjectExterns.atk_object_remove_relationship(@object, relationship, target);
	}

	public static T SetAccessibleId<T>(this T accessible, string name) where T : AtkObjectHandle
	{
		AtkObjectExterns.atk_object_set_accessible_id(accessible, name);
		return accessible;
	}

	public static T SetDescription<T>(this T accessible, string description) where T : AtkObjectHandle
	{
		AtkObjectExterns.atk_object_set_description(accessible, description);
		return accessible;
	}

	public static T SetName<T>(this T accessible, string name) where T : AtkObjectHandle
	{
		AtkObjectExterns.atk_object_set_name(accessible, name);
		return accessible;
	}

	public static T SetParent<T>(this T accessible, AtkObjectHandle parent) where T : AtkObjectHandle
	{
		AtkObjectExterns.atk_object_set_parent(accessible, parent);
		return accessible;
	}

	public static T SetRole<T>(this T accessible, AtkRole role) where T : AtkObjectHandle
	{
		AtkObjectExterns.atk_object_set_role(accessible, role);
		return accessible;
	}

	public static T AtkFocusTrackerNotify<T>(this T @object) where T : AtkObjectHandle
	{
		AtkObjectExterns.atk_focus_tracker_notify(@object);
		return @object;
	}

}

internal class AtkObjectExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern bool atk_object_add_relationship(AtkObjectHandle @object, AtkRelationType relationship, AtkObjectHandle target);

	[DllImport(Libraries.Atk)]
	internal static extern uint atk_object_connect_property_change_handler(AtkObjectHandle accessible, AtkPropertyChangeHandler handler);

	[DllImport(Libraries.Atk)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_object_get_accessible_id(AtkObjectHandle accessible);

	[DllImport(Libraries.Atk)]
	internal static extern AtkAttributeSetHandle atk_object_get_attributes(AtkObjectHandle accessible);

	[DllImport(Libraries.Atk)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_object_get_description(AtkObjectHandle accessible);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_object_get_index_in_parent(AtkObjectHandle accessible);

	[DllImport(Libraries.Atk)]
	internal static extern AtkLayer atk_object_get_layer(AtkObjectHandle accessible);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_object_get_mdi_zorder(AtkObjectHandle accessible);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_object_get_n_accessible_children(AtkObjectHandle accessible);

	[DllImport(Libraries.Atk)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_object_get_name(AtkObjectHandle accessible);

	[DllImport(Libraries.Atk)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_object_get_object_locale(AtkObjectHandle accessible);

	[DllImport(Libraries.Atk)]
	internal static extern AtkObjectHandle atk_object_get_parent(AtkObjectHandle accessible);

	[DllImport(Libraries.Atk)]
	internal static extern AtkRole atk_object_get_role(AtkObjectHandle accessible);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_object_initialize(AtkObjectHandle accessible, IntPtr data);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_object_notify_state_change(AtkObjectHandle accessible, AtkState state, bool value);

	[DllImport(Libraries.Atk)]
	internal static extern AtkObjectHandle atk_object_peek_parent(AtkObjectHandle accessible);

	[DllImport(Libraries.Atk)]
	internal static extern AtkObjectHandle atk_object_ref_accessible_child(AtkObjectHandle accessible, int i);

	[DllImport(Libraries.Atk)]
	internal static extern AtkRelationSetHandle atk_object_ref_relation_set(AtkObjectHandle accessible);

	[DllImport(Libraries.Atk)]
	internal static extern AtkStateSetHandle atk_object_ref_state_set(AtkObjectHandle accessible);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_object_remove_property_change_handler(AtkObjectHandle accessible, uint handler_id);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_object_remove_relationship(AtkObjectHandle @object, AtkRelationType relationship, AtkObjectHandle target);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_object_set_accessible_id(AtkObjectHandle accessible, string name);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_object_set_description(AtkObjectHandle accessible, string description);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_object_set_name(AtkObjectHandle accessible, string name);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_object_set_parent(AtkObjectHandle accessible, AtkObjectHandle parent);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_object_set_role(AtkObjectHandle accessible, AtkRole role);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_focus_tracker_notify(AtkObjectHandle @object);

}
