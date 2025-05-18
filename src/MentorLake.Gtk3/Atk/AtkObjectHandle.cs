namespace MentorLake.Atk;

public class AtkObjectHandle : GObjectHandle
{
}
public static class AtkObjectHandleSignalExtensions
{

	public static IObservable<AtkObjectHandleSignalStructs.ActiveDescendantChangedSignal> Signal_ActiveDescendantChanged(this AtkObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkObjectHandleSignalStructs.ActiveDescendantChangedSignal> obs) =>
		{
			AtkObjectHandleSignalDelegates.active_descendant_changed handler = ( MentorLake.Atk.AtkObjectHandle self,  MentorLake.Atk.AtkObjectHandle arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkObjectHandleSignalStructs.ActiveDescendantChangedSignal()
				{
					Self = self, Arg1 = arg1, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "active-descendant-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<AtkObjectHandleSignalStructs.AnnouncementSignal> Signal_Announcement(this AtkObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkObjectHandleSignalStructs.AnnouncementSignal> obs) =>
		{
			AtkObjectHandleSignalDelegates.announcement handler = ( MentorLake.Atk.AtkObjectHandle self,  string arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkObjectHandleSignalStructs.AnnouncementSignal()
				{
					Self = self, Arg1 = arg1, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "announcement", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<AtkObjectHandleSignalStructs.AttributeChangedSignal> Signal_AttributeChanged(this AtkObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkObjectHandleSignalStructs.AttributeChangedSignal> obs) =>
		{
			AtkObjectHandleSignalDelegates.attribute_changed handler = ( MentorLake.Atk.AtkObjectHandle self,  string arg1,  string arg2,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkObjectHandleSignalStructs.AttributeChangedSignal()
				{
					Self = self, Arg1 = arg1, Arg2 = arg2, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "attribute-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<AtkObjectHandleSignalStructs.ChildrenChangedSignal> Signal_ChildrenChanged(this AtkObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkObjectHandleSignalStructs.ChildrenChangedSignal> obs) =>
		{
			AtkObjectHandleSignalDelegates.children_changed handler = ( MentorLake.Atk.AtkObjectHandle self,  uint arg1,  MentorLake.Atk.AtkObjectHandle arg2,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkObjectHandleSignalStructs.ChildrenChangedSignal()
				{
					Self = self, Arg1 = arg1, Arg2 = arg2, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "children-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<AtkObjectHandleSignalStructs.FocusEventSignal> Signal_FocusEvent(this AtkObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkObjectHandleSignalStructs.FocusEventSignal> obs) =>
		{
			AtkObjectHandleSignalDelegates.focus_event handler = ( MentorLake.Atk.AtkObjectHandle self,  bool arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkObjectHandleSignalStructs.FocusEventSignal()
				{
					Self = self, Arg1 = arg1, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "focus-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<AtkObjectHandleSignalStructs.NotificationSignal> Signal_Notification(this AtkObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkObjectHandleSignalStructs.NotificationSignal> obs) =>
		{
			AtkObjectHandleSignalDelegates.notification handler = ( MentorLake.Atk.AtkObjectHandle self,  string arg1,  int arg2,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkObjectHandleSignalStructs.NotificationSignal()
				{
					Self = self, Arg1 = arg1, Arg2 = arg2, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "notification", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<AtkObjectHandleSignalStructs.PropertyChangeSignal> Signal_PropertyChange(this AtkObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkObjectHandleSignalStructs.PropertyChangeSignal> obs) =>
		{
			AtkObjectHandleSignalDelegates.property_change handler = ( MentorLake.Atk.AtkObjectHandle self,  MentorLake.Atk.AtkPropertyValuesHandle arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkObjectHandleSignalStructs.PropertyChangeSignal()
				{
					Self = self, Arg1 = arg1, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "property-change", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<AtkObjectHandleSignalStructs.StateChangeSignal> Signal_StateChange(this AtkObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkObjectHandleSignalStructs.StateChangeSignal> obs) =>
		{
			AtkObjectHandleSignalDelegates.state_change handler = ( MentorLake.Atk.AtkObjectHandle self,  string arg1,  bool arg2,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkObjectHandleSignalStructs.StateChangeSignal()
				{
					Self = self, Arg1 = arg1, Arg2 = arg2, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "state-change", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<AtkObjectHandleSignalStructs.VisibleDataChangedSignal> Signal_VisibleDataChanged(this AtkObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkObjectHandleSignalStructs.VisibleDataChangedSignal> obs) =>
		{
			AtkObjectHandleSignalDelegates.visible_data_changed handler = ( MentorLake.Atk.AtkObjectHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkObjectHandleSignalStructs.VisibleDataChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "visible-data-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class AtkObjectHandleSignalStructs
{

public class ActiveDescendantChangedSignal
{
	public MentorLake.Atk.AtkObjectHandle Self;
	public MentorLake.Atk.AtkObjectHandle Arg1;
	public IntPtr UserData;
}

public class AnnouncementSignal
{
	public MentorLake.Atk.AtkObjectHandle Self;
	public string Arg1;
	public IntPtr UserData;
}

public class AttributeChangedSignal
{
	public MentorLake.Atk.AtkObjectHandle Self;
	public string Arg1;
	public string Arg2;
	public IntPtr UserData;
}

public class ChildrenChangedSignal
{
	public MentorLake.Atk.AtkObjectHandle Self;
	public uint Arg1;
	public MentorLake.Atk.AtkObjectHandle Arg2;
	public IntPtr UserData;
}

public class FocusEventSignal
{
	public MentorLake.Atk.AtkObjectHandle Self;
	public bool Arg1;
	public IntPtr UserData;
}

public class NotificationSignal
{
	public MentorLake.Atk.AtkObjectHandle Self;
	public string Arg1;
	public int Arg2;
	public IntPtr UserData;
}

public class PropertyChangeSignal
{
	public MentorLake.Atk.AtkObjectHandle Self;
	public MentorLake.Atk.AtkPropertyValuesHandle Arg1;
	public IntPtr UserData;
}

public class StateChangeSignal
{
	public MentorLake.Atk.AtkObjectHandle Self;
	public string Arg1;
	public bool Arg2;
	public IntPtr UserData;
}

public class VisibleDataChangedSignal
{
	public MentorLake.Atk.AtkObjectHandle Self;
	public IntPtr UserData;
}
}

public static class AtkObjectHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void active_descendant_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle arg1, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void announcement([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle self, string arg1, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void attribute_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle self, string arg1, string arg2, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void children_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle self, uint arg1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle arg2, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void focus_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle self, bool arg1, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void notification([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle self, string arg1, int arg2, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void property_change([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkPropertyValuesHandle>))] MentorLake.Atk.AtkPropertyValuesHandle arg1, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void state_change([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle self, string arg1, bool arg2, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void visible_data_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle self, IntPtr user_data);

}


public static class AtkObjectHandleExtensions
{
	public static bool AddRelationship(this MentorLake.Atk.AtkObjectHandle @object, MentorLake.Atk.AtkRelationType relationship, MentorLake.Atk.AtkObjectHandle target)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_add_relationship(@object, relationship, target);
	}

	public static uint ConnectPropertyChangeHandler(this MentorLake.Atk.AtkObjectHandle accessible, MentorLake.Atk.AtkPropertyChangeHandler handler)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_connect_property_change_handler(accessible, handler);
	}

	public static string GetAccessibleId(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_accessible_id(accessible);
	}

	public static MentorLake.Atk.AtkAttributeSetHandle GetAttributes(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_attributes(accessible);
	}

	public static string GetDescription(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_description(accessible);
	}

	public static string GetHelpText(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_help_text(accessible);
	}

	public static int GetIndexInParent(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_index_in_parent(accessible);
	}

	public static MentorLake.Atk.AtkLayer GetLayer(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_layer(accessible);
	}

	public static int GetMdiZorder(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_mdi_zorder(accessible);
	}

	public static int GetNAccessibleChildren(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_n_accessible_children(accessible);
	}

	public static string GetName(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_name(accessible);
	}

	public static string GetObjectLocale(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_object_locale(accessible);
	}

	public static MentorLake.Atk.AtkObjectHandle GetParent(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_parent(accessible);
	}

	public static MentorLake.Atk.AtkRole GetRole(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_role(accessible);
	}

	public static T Initialize<T>(this T accessible, IntPtr data) where T : AtkObjectHandle
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		AtkObjectHandleExterns.atk_object_initialize(accessible, data);
		return accessible;
	}

	public static T NotifyStateChange<T>(this T accessible, MentorLake.Atk.AtkState state, bool value) where T : AtkObjectHandle
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		AtkObjectHandleExterns.atk_object_notify_state_change(accessible, state, value);
		return accessible;
	}

	public static MentorLake.Atk.AtkObjectHandle PeekParent(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_peek_parent(accessible);
	}

	public static MentorLake.Atk.AtkObjectHandle RefAccessibleChild(this MentorLake.Atk.AtkObjectHandle accessible, int i)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_ref_accessible_child(accessible, i);
	}

	public static MentorLake.Atk.AtkRelationSetHandle RefRelationSet(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_ref_relation_set(accessible);
	}

	public static MentorLake.Atk.AtkStateSetHandle RefStateSet(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_ref_state_set(accessible);
	}

	public static T RemovePropertyChangeHandler<T>(this T accessible, uint handler_id) where T : AtkObjectHandle
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		AtkObjectHandleExterns.atk_object_remove_property_change_handler(accessible, handler_id);
		return accessible;
	}

	public static bool RemoveRelationship(this MentorLake.Atk.AtkObjectHandle @object, MentorLake.Atk.AtkRelationType relationship, MentorLake.Atk.AtkObjectHandle target)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_remove_relationship(@object, relationship, target);
	}

	public static T SetAccessibleId<T>(this T accessible, string id) where T : AtkObjectHandle
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		AtkObjectHandleExterns.atk_object_set_accessible_id(accessible, id);
		return accessible;
	}

	public static T SetDescription<T>(this T accessible, string description) where T : AtkObjectHandle
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		AtkObjectHandleExterns.atk_object_set_description(accessible, description);
		return accessible;
	}

	public static T SetHelpText<T>(this T accessible, string help_text) where T : AtkObjectHandle
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		AtkObjectHandleExterns.atk_object_set_help_text(accessible, help_text);
		return accessible;
	}

	public static T SetName<T>(this T accessible, string name) where T : AtkObjectHandle
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		AtkObjectHandleExterns.atk_object_set_name(accessible, name);
		return accessible;
	}

	public static T SetParent<T>(this T accessible, MentorLake.Atk.AtkObjectHandle parent) where T : AtkObjectHandle
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		AtkObjectHandleExterns.atk_object_set_parent(accessible, parent);
		return accessible;
	}

	public static T SetRole<T>(this T accessible, MentorLake.Atk.AtkRole role) where T : AtkObjectHandle
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		AtkObjectHandleExterns.atk_object_set_role(accessible, role);
		return accessible;
	}

}

internal class AtkObjectHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_object_add_relationship([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle @object, MentorLake.Atk.AtkRelationType relationship, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle target);

	[DllImport(AtkLibrary.Name)]
	internal static extern uint atk_object_connect_property_change_handler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible, MentorLake.Atk.AtkPropertyChangeHandler handler);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_object_get_accessible_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkAttributeSetHandle>))]
	internal static extern MentorLake.Atk.AtkAttributeSetHandle atk_object_get_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_object_get_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_object_get_help_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_object_get_index_in_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkLayer atk_object_get_layer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_object_get_mdi_zorder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_object_get_n_accessible_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_object_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_object_get_object_locale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))]
	internal static extern MentorLake.Atk.AtkObjectHandle atk_object_get_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkRole atk_object_get_role([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_object_initialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible, IntPtr data);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_object_notify_state_change([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible, MentorLake.Atk.AtkState state, bool value);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))]
	internal static extern MentorLake.Atk.AtkObjectHandle atk_object_peek_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))]
	internal static extern MentorLake.Atk.AtkObjectHandle atk_object_ref_accessible_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible, int i);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationSetHandle>))]
	internal static extern MentorLake.Atk.AtkRelationSetHandle atk_object_ref_relation_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))]
	internal static extern MentorLake.Atk.AtkStateSetHandle atk_object_ref_state_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_object_remove_property_change_handler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible, uint handler_id);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_object_remove_relationship([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle @object, MentorLake.Atk.AtkRelationType relationship, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle target);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_object_set_accessible_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible, string id);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_object_set_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible, string description);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_object_set_help_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible, string help_text);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_object_set_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible, string name);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_object_set_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle parent);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_object_set_role([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible, MentorLake.Atk.AtkRole role);

}
