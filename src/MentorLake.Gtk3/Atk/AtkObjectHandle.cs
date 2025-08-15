namespace MentorLake.Atk;

/// <summary>
/// <para>
/// The base object class for the Accessibility Toolkit API.
/// </para>
/// <para>
/// This class is the primary class for accessibility support via the
/// Accessibility ToolKit (ATK).  Objects which are instances of
/// #AtkObject (or instances of AtkObject-derived types) are queried
/// for properties which relate basic (and generic) properties of a UI
/// component such as name and description.  Instances of #AtkObject
/// may also be queried as to whether they implement other ATK
/// interfaces (e.g. #AtkAction, #AtkComponent, etc.), as appropriate
/// to the role which a given UI component plays in a user interface.
/// </para>
/// <para>
/// All UI components in an application which provide useful
/// information or services to the user must provide corresponding
/// #AtkObject instances on request (in GTK+, for instance, usually on
/// a call to #gtk_widget_get_accessible ()), either via ATK support
/// built into the toolkit for the widget class or ancestor class, or
/// in the case of custom widgets, if the inherited #AtkObject
/// implementation is insufficient, via instances of a new #AtkObject
/// subclass.
/// </para>
/// <para>
/// See [class@AtkObjectFactory], [class@AtkRegistry].  (GTK+ users see also
/// #GtkAccessible).
/// </para>
/// </summary>

public class AtkObjectHandle : GObjectHandle
{
}
public static class AtkObjectHandleSignalExtensions
{
/// <summary>
/// <para>
/// The &quot;active-descendant-changed&quot; signal is emitted by an object
/// which has the state ATK_STATE_MANAGES_DESCENDANTS when the focus
/// object in the object changes. For instance, a table will emit the
/// signal when the cell in the table which has focus changes.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The &quot;announcement&quot; signal can be emitted to pass an announcement on to
/// be read by a screen reader.
/// </para>
/// <para>
/// Depcrecated (2.50): Use AtkObject::notification instead.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The &quot;attribute-changed&quot; signal should be emitted when one of an object&apos;s
/// attributes changes.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The signal &quot;children-changed&quot; is emitted when a child is added or
/// removed from an object. It supports two details: &quot;add&quot; and
/// &quot;remove&quot;
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The signal &quot;focus-event&quot; is emitted when an object gained or lost
/// focus.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The &quot;notification&quot; signal can be emitted to pass an announcement on to
/// be read by a screen reader.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The signal &quot;property-change&quot; is emitted when an object&apos;s property
/// value changes. @arg1 contains an #AtkPropertyValues with the name
/// and the new value of the property whose value has changed. Note
/// that, as with GObject notify, getting this signal does not
/// guarantee that the value of the property has actually changed; it
/// may also be emitted when the setter of the property is called to
/// reinstate the previous value.
/// </para>
/// <para>
/// Toolkit implementor note: ATK implementors should use
/// g_object_notify() to emit property-changed
/// notifications. #AtkObject::property-changed is needed by the
/// implementation of atk_add_global_event_listener() because GObject
/// notify doesn&apos;t support emission hooks.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The &quot;state-change&quot; signal is emitted when an object&apos;s state
/// changes.  The detail value identifies the state type which has
/// changed.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The &quot;visible-data-changed&quot; signal is emitted when the visual
/// appearance of the object changed.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// the newly focused object.
/// </para>
/// </summary>

	public MentorLake.Atk.AtkObjectHandle Arg1;

	public IntPtr UserData;
}

public class AnnouncementSignal
{

	public MentorLake.Atk.AtkObjectHandle Self;
/// <summary>
/// <para>
/// the text to be announced.
/// </para>
/// </summary>

	public string Arg1;

	public IntPtr UserData;
}

public class AttributeChangedSignal
{

	public MentorLake.Atk.AtkObjectHandle Self;
/// <summary>
/// <para>
/// the name of the attribute being modified, or %NULL if not
///          available.
/// </para>
/// </summary>

	public string Arg1;
/// <summary>
/// <para>
/// the attribute&apos;s new value, or %null if not available.
/// </para>
/// </summary>

	public string Arg2;

	public IntPtr UserData;
}

public class ChildrenChangedSignal
{

	public MentorLake.Atk.AtkObjectHandle Self;
/// <summary>
/// <para>
/// The index of the added or removed child. The value can be
/// -1. This is used if the value is not known by the implementor
/// when the child is added/removed or irrelevant.
/// </para>
/// </summary>

	public uint Arg1;
/// <summary>
/// <para>
/// A gpointer to the child AtkObject which was added or
/// removed. If the child was removed, it is possible that it is not
/// available for the implementor. In that case this pointer can be
/// NULL.
/// </para>
/// </summary>

	public MentorLake.Atk.AtkObjectHandle Arg2;

	public IntPtr UserData;
}

public class FocusEventSignal
{

	public MentorLake.Atk.AtkObjectHandle Self;
/// <summary>
/// <para>
/// a boolean value which indicates whether the object gained
/// or lost focus.
/// </para>
/// </summary>

	public bool Arg1;

	public IntPtr UserData;
}

public class NotificationSignal
{

	public MentorLake.Atk.AtkObjectHandle Self;
/// <summary>
/// <para>
/// the text to be announced.
/// </para>
/// </summary>

	public string Arg1;
/// <summary>
/// <para>
/// an #AtkLive specifying the politeness of the notification.
/// Should be either ATK_LIVE_POLITE or ATK_LIVE_ASSERTIVE.
/// </para>
/// </summary>

	public int Arg2;

	public IntPtr UserData;
}

public class PropertyChangeSignal
{

	public MentorLake.Atk.AtkObjectHandle Self;
/// <summary>
/// <para>
/// an #AtkPropertyValues containing the new
/// value of the property which changed.
/// </para>
/// </summary>

	public MentorLake.Atk.AtkPropertyValuesHandle Arg1;

	public IntPtr UserData;
}

public class StateChangeSignal
{

	public MentorLake.Atk.AtkObjectHandle Self;
/// <summary>
/// <para>
/// The name of the state which has changed
/// </para>
/// </summary>

	public string Arg1;
/// <summary>
/// <para>
/// A boolean which indicates whether the state has been set or unset.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// The &quot;active-descendant-changed&quot; signal is emitted by an object
/// which has the state ATK_STATE_MANAGES_DESCENDANTS when the focus
/// object in the object changes. For instance, a table will emit the
/// signal when the cell in the table which has focus changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// the newly focused object.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void active_descendant_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle arg1, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;announcement&quot; signal can be emitted to pass an announcement on to
/// be read by a screen reader.
/// </para>
/// <para>
/// Depcrecated (2.50): Use AtkObject::notification instead.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// the text to be announced.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void announcement([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle self, string arg1, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;attribute-changed&quot; signal should be emitted when one of an object&apos;s
/// attributes changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// the name of the attribute being modified, or %NULL if not
///          available.
/// </param>
/// <param name="arg2">
/// the attribute&apos;s new value, or %null if not available.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void attribute_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle self, string arg1, string arg2, IntPtr user_data);


/// <summary>
/// <para>
/// The signal &quot;children-changed&quot; is emitted when a child is added or
/// removed from an object. It supports two details: &quot;add&quot; and
/// &quot;remove&quot;
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// The index of the added or removed child. The value can be
/// -1. This is used if the value is not known by the implementor
/// when the child is added/removed or irrelevant.
/// </param>
/// <param name="arg2">
/// A gpointer to the child AtkObject which was added or
/// removed. If the child was removed, it is possible that it is not
/// available for the implementor. In that case this pointer can be
/// NULL.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void children_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle self, uint arg1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle arg2, IntPtr user_data);


/// <summary>
/// <para>
/// The signal &quot;focus-event&quot; is emitted when an object gained or lost
/// focus.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// a boolean value which indicates whether the object gained
/// or lost focus.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void focus_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle self, bool arg1, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;notification&quot; signal can be emitted to pass an announcement on to
/// be read by a screen reader.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// the text to be announced.
/// </param>
/// <param name="arg2">
/// an #AtkLive specifying the politeness of the notification.
/// Should be either ATK_LIVE_POLITE or ATK_LIVE_ASSERTIVE.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void notification([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle self, string arg1, int arg2, IntPtr user_data);


/// <summary>
/// <para>
/// The signal &quot;property-change&quot; is emitted when an object&apos;s property
/// value changes. @arg1 contains an #AtkPropertyValues with the name
/// and the new value of the property whose value has changed. Note
/// that, as with GObject notify, getting this signal does not
/// guarantee that the value of the property has actually changed; it
/// may also be emitted when the setter of the property is called to
/// reinstate the previous value.
/// </para>
/// <para>
/// Toolkit implementor note: ATK implementors should use
/// g_object_notify() to emit property-changed
/// notifications. #AtkObject::property-changed is needed by the
/// implementation of atk_add_global_event_listener() because GObject
/// notify doesn&apos;t support emission hooks.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// an #AtkPropertyValues containing the new
/// value of the property which changed.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void property_change([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkPropertyValuesHandle>))] MentorLake.Atk.AtkPropertyValuesHandle arg1, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;state-change&quot; signal is emitted when an object&apos;s state
/// changes.  The detail value identifies the state type which has
/// changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// The name of the state which has changed
/// </param>
/// <param name="arg2">
/// A boolean which indicates whether the state has been set or unset.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void state_change([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle self, string arg1, bool arg2, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;visible-data-changed&quot; signal is emitted when the visual
/// appearance of the object changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void visible_data_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle self, IntPtr user_data);

}


public static class AtkObjectHandleExtensions
{
/// <summary>
/// <para>
/// Adds a relationship of the specified type with the specified target.
/// </para>
/// </summary>

/// <param name="@object">
/// The #AtkObject to which an AtkRelation is to be added.
/// </param>
/// <param name="relationship">
/// The #AtkRelationType of the relation
/// </param>
/// <param name="target">
/// The #AtkObject which is to be the target of the relation.
/// </param>
/// <return>
/// TRUE if the relationship is added.
/// </return>

	public static bool AddRelationship(this MentorLake.Atk.AtkObjectHandle @object, MentorLake.Atk.AtkRelationType relationship, MentorLake.Atk.AtkObjectHandle target)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_add_relationship(@object, relationship, target);
	}

/// <summary>
/// <para>
/// Calls @handler on property changes.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <param name="handler">
/// a function to be called when a property changes its value
/// </param>
/// <return>
/// a #guint which is the handler id used in
///   atk_object_remove_property_change_handler()
/// </return>

	public static uint ConnectPropertyChangeHandler(this MentorLake.Atk.AtkObjectHandle accessible, MentorLake.Atk.AtkPropertyChangeHandler handler)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_connect_property_change_handler(accessible, handler);
	}

/// <summary>
/// <para>
/// Gets the accessible id of the accessible.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <return>
/// a character string representing the accessible id of the object, or
/// NULL if no such string was set.
/// </return>

	public static string GetAccessibleId(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_accessible_id(accessible);
	}

/// <summary>
/// <para>
/// Get a list of properties applied to this object as a whole, as an #AtkAttributeSet consisting of
/// name-value pairs. As such these attributes may be considered weakly-typed properties or annotations,
/// as distinct from strongly-typed object data available via other get/set methods.
/// Not all objects have explicit &quot;name-value pair&quot; #AtkAttributeSet properties.
/// </para>
/// </summary>

/// <param name="accessible">
/// An #AtkObject.
/// </param>
/// <return>
/// an #AtkAttributeSet consisting of all
/// explicit properties/annotations applied to the object, or an empty
/// set if the object has no name-value pair attributes assigned to
/// it. This #atkattributeset should be freed by a call to
/// atk_attribute_set_free().
/// </return>

	public static MentorLake.Atk.AtkAttributeSetHandle GetAttributes(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_attributes(accessible);
	}

/// <summary>
/// <para>
/// Gets the accessible description of the accessible.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <return>
/// a character string representing the accessible description
/// of the accessible.
/// </return>

	public static string GetDescription(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_description(accessible);
	}

/// <summary>
/// <para>
/// Gets the help text associated with the accessible.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <return>
/// a character string representing the help text or the object, or
/// NULL if no such string was set.
/// </return>

	public static string GetHelpText(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_help_text(accessible);
	}

/// <summary>
/// <para>
/// Gets the 0-based index of this accessible in its parent; returns -1 if the
/// accessible does not have an accessible parent.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <return>
/// an integer which is the index of the accessible in its parent
/// </return>

	public static int GetIndexInParent(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_index_in_parent(accessible);
	}

/// <summary>
/// <para>
/// Gets the layer of the accessible.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <return>
/// an #AtkLayer which is the layer of the accessible
/// </return>

	public static MentorLake.Atk.AtkLayer GetLayer(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_layer(accessible);
	}

/// <summary>
/// <para>
/// Gets the zorder of the accessible. The value G_MININT will be returned
/// if the layer of the accessible is not ATK_LAYER_MDI.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <return>
/// a gint which is the zorder of the accessible, i.e. the depth at
/// which the component is shown in relation to other components in the same
/// container.
/// </return>

	public static int GetMdiZorder(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_mdi_zorder(accessible);
	}

/// <summary>
/// <para>
/// Gets the number of accessible children of the accessible.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <return>
/// an integer representing the number of accessible children
/// of the accessible.
/// </return>

	public static int GetNAccessibleChildren(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_n_accessible_children(accessible);
	}

/// <summary>
/// <para>
/// Gets the accessible name of the accessible.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <return>
/// a character string representing the accessible name of the object.
/// </return>

	public static string GetName(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_name(accessible);
	}

/// <summary>
/// <para>
/// Gets a UTF-8 string indicating the POSIX-style LC_MESSAGES locale
/// of @accessible.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <return>
/// a UTF-8 string indicating the POSIX-style LC_MESSAGES
///          locale of @accessible.
/// </return>

	public static string GetObjectLocale(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_object_locale(accessible);
	}

/// <summary>
/// <para>
/// Gets the accessible parent of the accessible. By default this is
/// the one assigned with atk_object_set_parent(), but it is assumed
/// that ATK implementors have ways to get the parent of the object
/// without the need of assigning it manually with
/// atk_object_set_parent(), and will return it with this method.
/// </para>
/// <para>
/// If you are only interested on the parent assigned with
/// atk_object_set_parent(), use atk_object_peek_parent().
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <return>
/// an #AtkObject representing the accessible
/// parent of the accessible
/// </return>

	public static MentorLake.Atk.AtkObjectHandle GetParent(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_parent(accessible);
	}

/// <summary>
/// <para>
/// Gets the role of the accessible.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <return>
/// an #AtkRole which is the role of the accessible
/// </return>

	public static MentorLake.Atk.AtkRole GetRole(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_get_role(accessible);
	}

/// <summary>
/// <para>
/// This function is called when implementing subclasses of #AtkObject.
/// It does initialization required for the new object. It is intended
/// that this function should called only in the ..._new() functions used
/// to create an instance of a subclass of #AtkObject
/// </para>
/// </summary>

/// <param name="accessible">
/// a #AtkObject
/// </param>
/// <param name="data">
/// a #gpointer which identifies the object for which the AtkObject was created.
/// </param>

	public static T Initialize<T>(this T accessible, IntPtr data) where T : AtkObjectHandle
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		AtkObjectHandleExterns.atk_object_initialize(accessible, data);
		return accessible;
	}

/// <summary>
/// <para>
/// Emits a state-change signal for the specified state.
/// </para>
/// <para>
/// Note that as a general rule when the state of an existing object changes,
/// emitting a notification is expected.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <param name="state">
/// an #AtkState whose state is changed
/// </param>
/// <param name="value">
/// a gboolean which indicates whether the state is being set on or off
/// </param>

	public static T NotifyStateChange<T>(this T accessible, MentorLake.Atk.AtkState state, bool value) where T : AtkObjectHandle
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		AtkObjectHandleExterns.atk_object_notify_state_change(accessible, state, value);
		return accessible;
	}

/// <summary>
/// <para>
/// Gets the accessible parent of the accessible, if it has been
/// manually assigned with atk_object_set_parent. Otherwise, this
/// function returns %NULL.
/// </para>
/// <para>
/// This method is intended as an utility for ATK implementors, and not
/// to be exposed to accessible tools. See atk_object_get_parent() for
/// further reference.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <return>
/// an #AtkObject representing the accessible
/// parent of the accessible if assigned
/// </return>

	public static MentorLake.Atk.AtkObjectHandle PeekParent(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_peek_parent(accessible);
	}

/// <summary>
/// <para>
/// Gets a reference to the specified accessible child of the object.
/// The accessible children are 0-based so the first accessible child is
/// at index 0, the second at index 1 and so on.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <param name="i">
/// a gint representing the position of the child, starting from 0
/// </param>
/// <return>
/// an #AtkObject representing the specified
/// accessible child of the accessible.
/// </return>

	public static MentorLake.Atk.AtkObjectHandle RefAccessibleChild(this MentorLake.Atk.AtkObjectHandle accessible, int i)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_ref_accessible_child(accessible, i);
	}

/// <summary>
/// <para>
/// Gets the #AtkRelationSet associated with the object.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <return>
/// an #AtkRelationSet representing the relation set
/// of the object.
/// </return>

	public static MentorLake.Atk.AtkRelationSetHandle RefRelationSet(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_ref_relation_set(accessible);
	}

/// <summary>
/// <para>
/// Gets a reference to the state set of the accessible; the caller must
/// unreference it when it is no longer needed.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <return>
/// a reference to an #AtkStateSet which is the state
/// set of the accessible
/// </return>

	public static MentorLake.Atk.AtkStateSetHandle RefStateSet(this MentorLake.Atk.AtkObjectHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_ref_state_set(accessible);
	}

/// <summary>
/// <para>
/// Removes a property change handler.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <param name="handler_id">
/// a guint which identifies the handler to be removed.
/// </param>

	public static T RemovePropertyChangeHandler<T>(this T accessible, uint handler_id) where T : AtkObjectHandle
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		AtkObjectHandleExterns.atk_object_remove_property_change_handler(accessible, handler_id);
		return accessible;
	}

/// <summary>
/// <para>
/// Removes a relationship of the specified type with the specified target.
/// </para>
/// </summary>

/// <param name="@object">
/// The #AtkObject from which an AtkRelation is to be removed.
/// </param>
/// <param name="relationship">
/// The #AtkRelationType of the relation
/// </param>
/// <param name="target">
/// The #AtkObject which is the target of the relation to be removed.
/// </param>
/// <return>
/// TRUE if the relationship is removed.
/// </return>

	public static bool RemoveRelationship(this MentorLake.Atk.AtkObjectHandle @object, MentorLake.Atk.AtkRelationType relationship, MentorLake.Atk.AtkObjectHandle target)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		return AtkObjectHandleExterns.atk_object_remove_relationship(@object, relationship, target);
	}

/// <summary>
/// <para>
/// Sets the accessible ID of the accessible.  This is not meant to be presented
/// to the user, but to be an ID which is stable over application development.
/// Typically, this is the gtkbuilder ID. Such an ID will be available for
/// instance to identify a given well-known accessible object for tailored screen
/// reading, or for automatic regression testing.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <param name="id">
/// a character string to be set as the accessible id
/// </param>

	public static T SetAccessibleId<T>(this T accessible, string id) where T : AtkObjectHandle
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		AtkObjectHandleExterns.atk_object_set_accessible_id(accessible, id);
		return accessible;
	}

/// <summary>
/// <para>
/// Sets the accessible description of the accessible. You can&apos;t set
/// the description to NULL. This is reserved for the initial value. In
/// this aspect NULL is similar to ATK_ROLE_UNKNOWN. If you want to set
/// the name to a empty value you can use &quot;&quot;.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <param name="description">
/// a character string to be set as the accessible description
/// </param>

	public static T SetDescription<T>(this T accessible, string description) where T : AtkObjectHandle
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		AtkObjectHandleExterns.atk_object_set_description(accessible, description);
		return accessible;
	}

/// <summary>
/// <para>
/// Sets the help text associated with the accessible. This can be used to
/// expose context-sensitive information to help a user understand how to
/// interact with the object. You can&apos;t set the help text to NULL.
/// This is reserved for the initial value. If you want to set the name to
/// an empty value, you can use &quot;&quot;.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <param name="help_text">
/// a character string to be set as the accessible&apos;s help text
/// </param>

	public static T SetHelpText<T>(this T accessible, string help_text) where T : AtkObjectHandle
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		AtkObjectHandleExterns.atk_object_set_help_text(accessible, help_text);
		return accessible;
	}

/// <summary>
/// <para>
/// Sets the accessible name of the accessible. You can&apos;t set the name
/// to NULL. This is reserved for the initial value. In this aspect
/// NULL is similar to ATK_ROLE_UNKNOWN. If you want to set the name to
/// a empty value you can use &quot;&quot;.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <param name="name">
/// a character string to be set as the accessible name
/// </param>

	public static T SetName<T>(this T accessible, string name) where T : AtkObjectHandle
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		AtkObjectHandleExterns.atk_object_set_name(accessible, name);
		return accessible;
	}

/// <summary>
/// <para>
/// Sets the accessible parent of the accessible. @parent can be NULL.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <param name="parent">
/// an #AtkObject to be set as the accessible parent
/// </param>

	public static T SetParent<T>(this T accessible, MentorLake.Atk.AtkObjectHandle parent) where T : AtkObjectHandle
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (AtkObjectHandle)");
		AtkObjectHandleExterns.atk_object_set_parent(accessible, parent);
		return accessible;
	}

/// <summary>
/// <para>
/// Sets the role of the accessible.
/// </para>
/// </summary>

/// <param name="accessible">
/// an #AtkObject
/// </param>
/// <param name="role">
/// an #AtkRole to be set as the role
/// </param>

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))]
	internal static extern MentorLake.Atk.AtkObjectHandle atk_object_ref_accessible_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible, int i);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Atk.AtkRelationSetHandle>))]
	internal static extern MentorLake.Atk.AtkRelationSetHandle atk_object_ref_relation_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle accessible);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))]
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
