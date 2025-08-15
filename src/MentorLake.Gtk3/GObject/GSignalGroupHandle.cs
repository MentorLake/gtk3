namespace MentorLake.GObject;

/// <summary>
/// <para>
/// `GSignalGroup` manages a collection of signals on a `GObject`.
/// </para>
/// <para>
/// `GSignalGroup` simplifies the process of connecting  many signals to a `GObject`
/// as a group. As such there is no API to disconnect a signal from the group.
/// </para>
/// <para>
/// In particular, this allows you to:
/// </para>
/// <para>
///  - Change the target instance, which automatically causes disconnection
///    of the signals from the old instance and connecting to the new instance.
///  - Block and unblock signals as a group
///  - Ensuring that blocked state transfers across target instances.
/// </para>
/// <para>
/// One place you might want to use such a structure is with `GtkTextView` and
/// `GtkTextBuffer`. Often times, you&apos;ll need to connect to many signals on
/// `GtkTextBuffer` from a `GtkTextView` subclass. This allows you to create a
/// signal group during instance construction, simply bind the
/// `GtkTextView:buffer` property to `GSignalGroup:target` and connect
/// all the signals you need. When the `GtkTextView:buffer` property changes
/// all of the signals will be transitioned correctly.
/// </para>
/// </summary>

public class GSignalGroupHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #GSignalGroup for target instances of @target_type.
/// </para>
/// </summary>

/// <param name="target_type">
/// the #GType of the target instance.
/// </param>
/// <return>
/// a new #GSignalGroup
/// </return>

	public static MentorLake.GObject.GSignalGroupHandle New(MentorLake.GObject.GType target_type)
	{
		return GSignalGroupHandleExterns.g_signal_group_new(target_type);
	}

}
public static class GSignalGroupHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when #GSignalGroup:target is set to a new value
/// other than %NULL. It is similar to #GObject::notify on `target` except it
/// will not emit when #GSignalGroup:target is %NULL and also allows for
/// receiving the #GObject without a data-race.
/// </para>
/// </summary>

	public static IObservable<GSignalGroupHandleSignalStructs.BindSignal> Signal_Bind(this GSignalGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GSignalGroupHandleSignalStructs.BindSignal> obs) =>
		{
			GSignalGroupHandleSignalDelegates.bind handler = ( MentorLake.GObject.GSignalGroupHandle self,  MentorLake.GObject.GObjectHandle instance,  IntPtr user_data) =>
			{
				

				var signalStruct = new GSignalGroupHandleSignalStructs.BindSignal()
				{
					Self = self, Instance = instance, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "bind", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when the target instance of @self is set to a
/// new #GObject.
/// </para>
/// <para>
/// This signal will only be emitted if the previous target of @self is
/// non-%NULL.
/// </para>
/// </summary>

	public static IObservable<GSignalGroupHandleSignalStructs.UnbindSignal> Signal_Unbind(this GSignalGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GSignalGroupHandleSignalStructs.UnbindSignal> obs) =>
		{
			GSignalGroupHandleSignalDelegates.unbind handler = ( MentorLake.GObject.GSignalGroupHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GSignalGroupHandleSignalStructs.UnbindSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "unbind", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GSignalGroupHandleSignalStructs
{

public class BindSignal
{

	public MentorLake.GObject.GSignalGroupHandle Self;
/// <summary>
/// <para>
/// a #GObject containing the new value for #GSignalGroup:target
/// </para>
/// </summary>

	public MentorLake.GObject.GObjectHandle Instance;

	public IntPtr UserData;
}

public class UnbindSignal
{

	public MentorLake.GObject.GSignalGroupHandle Self;

	public IntPtr UserData;
}
}

public static class GSignalGroupHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when #GSignalGroup:target is set to a new value
/// other than %NULL. It is similar to #GObject::notify on `target` except it
/// will not emit when #GSignalGroup:target is %NULL and also allows for
/// receiving the #GObject without a data-race.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="instance">
/// a #GObject containing the new value for #GSignalGroup:target
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void bind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle instance, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when the target instance of @self is set to a
/// new #GObject.
/// </para>
/// <para>
/// This signal will only be emitted if the previous target of @self is
/// non-%NULL.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unbind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self, IntPtr user_data);

}


public static class GSignalGroupHandleExtensions
{
/// <summary>
/// <para>
/// Blocks all signal handlers managed by @self so they will not
/// be called during any signal emissions. Must be unblocked exactly
/// the same number of times it has been blocked to become active again.
/// </para>
/// <para>
/// This blocked state will be kept across changes of the target instance.
/// </para>
/// </summary>

/// <param name="self">
/// the #GSignalGroup
/// </param>

	public static T Block<T>(this T self) where T : GSignalGroupHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSignalGroupHandle)");
		GSignalGroupHandleExterns.g_signal_group_block(self);
		return self;
	}

/// <summary>
/// <para>
/// Connects @c_handler to the signal @detailed_signal
/// on the target instance of @self.
/// </para>
/// <para>
/// You cannot connect a signal handler after #GSignalGroup:target has been set.
/// </para>
/// </summary>

/// <param name="self">
/// a #GSignalGroup
/// </param>
/// <param name="detailed_signal">
/// a string of the form &quot;signal-name::detail&quot;
/// </param>
/// <param name="c_handler">
/// the #GCallback to connect
/// </param>
/// <param name="data">
/// the data to pass to @c_handler calls
/// </param>

	public static T Connect<T>(this T self, string detailed_signal, MentorLake.GObject.GCallback c_handler, IntPtr data) where T : GSignalGroupHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSignalGroupHandle)");
		GSignalGroupHandleExterns.g_signal_group_connect(self, detailed_signal, c_handler, data);
		return self;
	}

/// <summary>
/// <para>
/// Connects @c_handler to the signal @detailed_signal
/// on the target instance of @self.
/// </para>
/// <para>
/// The @c_handler will be called after the default handler of the signal.
/// </para>
/// <para>
/// You cannot connect a signal handler after #GSignalGroup:target has been set.
/// </para>
/// </summary>

/// <param name="self">
/// a #GSignalGroup
/// </param>
/// <param name="detailed_signal">
/// a string of the form &quot;signal-name::detail&quot;
/// </param>
/// <param name="c_handler">
/// the #GCallback to connect
/// </param>
/// <param name="data">
/// the data to pass to @c_handler calls
/// </param>

	public static T ConnectAfter<T>(this T self, string detailed_signal, MentorLake.GObject.GCallback c_handler, IntPtr data) where T : GSignalGroupHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSignalGroupHandle)");
		GSignalGroupHandleExterns.g_signal_group_connect_after(self, detailed_signal, c_handler, data);
		return self;
	}

/// <summary>
/// <para>
/// Connects @closure to the signal @detailed_signal on #GSignalGroup:target.
/// </para>
/// <para>
/// You cannot connect a signal handler after #GSignalGroup:target has been set.
/// </para>
/// </summary>

/// <param name="self">
/// a #GSignalGroup
/// </param>
/// <param name="detailed_signal">
/// a string of the form `signal-name` with optional `::signal-detail`
/// </param>
/// <param name="closure">
/// the closure to connect.
/// </param>
/// <param name="after">
/// whether the handler should be called before or after the
///  default handler of the signal.
/// </param>

	public static T ConnectClosure<T>(this T self, string detailed_signal, MentorLake.GObject.GClosureHandle closure, bool after) where T : GSignalGroupHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSignalGroupHandle)");
		GSignalGroupHandleExterns.g_signal_group_connect_closure(self, detailed_signal, closure, after);
		return self;
	}

/// <summary>
/// <para>
/// Connects @c_handler to the signal @detailed_signal
/// on the target instance of @self.
/// </para>
/// <para>
/// You cannot connect a signal handler after #GSignalGroup:target has been set.
/// </para>
/// </summary>

/// <param name="self">
/// a #GSignalGroup
/// </param>
/// <param name="detailed_signal">
/// a string of the form &quot;signal-name::detail&quot;
/// </param>
/// <param name="c_handler">
/// the #GCallback to connect
/// </param>
/// <param name="data">
/// the data to pass to @c_handler calls
/// </param>
/// <param name="notify">
/// function to be called when disposing of @self
/// </param>
/// <param name="flags">
/// the flags used to create the signal connection
/// </param>

	public static T ConnectData<T>(this T self, string detailed_signal, MentorLake.GObject.GCallback c_handler, IntPtr data, MentorLake.GObject.GClosureNotify notify, MentorLake.GObject.GConnectFlags flags) where T : GSignalGroupHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSignalGroupHandle)");
		GSignalGroupHandleExterns.g_signal_group_connect_data(self, detailed_signal, c_handler, data, notify, flags);
		return self;
	}

/// <summary>
/// <para>
/// Connects @c_handler to the signal @detailed_signal on #GSignalGroup:target.
/// </para>
/// <para>
/// Ensures that the @object stays alive during the call to @c_handler
/// by temporarily adding a reference count. When the @object is destroyed
/// the signal handler will automatically be removed.
/// </para>
/// <para>
/// You cannot connect a signal handler after #GSignalGroup:target has been set.
/// </para>
/// </summary>

/// <param name="self">
/// a #GSignalGroup
/// </param>
/// <param name="detailed_signal">
/// a string of the form `signal-name` with optional `::signal-detail`
/// </param>
/// <param name="c_handler">
/// the #GCallback to connect
/// </param>
/// <param name="@object">
/// the #GObject to pass as data to @c_handler calls
/// </param>
/// <param name="flags">
/// #GConnectFlags for the signal connection
/// </param>

	public static T ConnectObject<T>(this T self, string detailed_signal, MentorLake.GObject.GCallback c_handler, IntPtr @object, MentorLake.GObject.GConnectFlags flags) where T : GSignalGroupHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSignalGroupHandle)");
		GSignalGroupHandleExterns.g_signal_group_connect_object(self, detailed_signal, c_handler, @object, flags);
		return self;
	}

/// <summary>
/// <para>
/// Connects @c_handler to the signal @detailed_signal
/// on the target instance of @self.
/// </para>
/// <para>
/// The instance on which the signal is emitted and @data
/// will be swapped when calling @c_handler.
/// </para>
/// <para>
/// You cannot connect a signal handler after #GSignalGroup:target has been set.
/// </para>
/// </summary>

/// <param name="self">
/// a #GSignalGroup
/// </param>
/// <param name="detailed_signal">
/// a string of the form &quot;signal-name::detail&quot;
/// </param>
/// <param name="c_handler">
/// the #GCallback to connect
/// </param>
/// <param name="data">
/// the data to pass to @c_handler calls
/// </param>

	public static T ConnectSwapped<T>(this T self, string detailed_signal, MentorLake.GObject.GCallback c_handler, IntPtr data) where T : GSignalGroupHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSignalGroupHandle)");
		GSignalGroupHandleExterns.g_signal_group_connect_swapped(self, detailed_signal, c_handler, data);
		return self;
	}

/// <summary>
/// <para>
/// Gets the target instance used when connecting signals.
/// </para>
/// </summary>

/// <param name="self">
/// the #GSignalGroup
/// </param>
/// <return>
/// The target instance
/// </return>

	public static MentorLake.GObject.GObjectHandle DupTarget(this MentorLake.GObject.GSignalGroupHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSignalGroupHandle)");
		return GSignalGroupHandleExterns.g_signal_group_dup_target(self);
	}

/// <summary>
/// <para>
/// Sets the target instance used when connecting signals. Any signal
/// that has been registered with g_signal_group_connect_object() or
/// similar functions will be connected to this object.
/// </para>
/// <para>
/// If the target instance was previously set, signals will be
/// disconnected from that object prior to connecting to @target.
/// </para>
/// </summary>

/// <param name="self">
/// the #GSignalGroup.
/// </param>
/// <param name="target">
/// The target instance used
///     when connecting signals.
/// </param>

	public static T SetTarget<T>(this T self, MentorLake.GObject.GObjectHandle target) where T : GSignalGroupHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSignalGroupHandle)");
		GSignalGroupHandleExterns.g_signal_group_set_target(self, target);
		return self;
	}

/// <summary>
/// <para>
/// Unblocks all signal handlers managed by @self so they will be
/// called again during any signal emissions unless it is blocked
/// again. Must be unblocked exactly the same number of times it
/// has been blocked to become active again.
/// </para>
/// </summary>

/// <param name="self">
/// the #GSignalGroup
/// </param>

	public static T Unblock<T>(this T self) where T : GSignalGroupHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSignalGroupHandle)");
		GSignalGroupHandleExterns.g_signal_group_unblock(self);
		return self;
	}

}

internal class GSignalGroupHandleExterns
{
	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))]
	internal static extern MentorLake.GObject.GSignalGroupHandle g_signal_group_new(MentorLake.GObject.GType target_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_group_block([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_group_connect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self, string detailed_signal, MentorLake.GObject.GCallback c_handler, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_group_connect_after([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self, string detailed_signal, MentorLake.GObject.GCallback c_handler, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_group_connect_closure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self, string detailed_signal, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, bool after);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_group_connect_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self, string detailed_signal, MentorLake.GObject.GCallback c_handler, IntPtr data, MentorLake.GObject.GClosureNotify notify, MentorLake.GObject.GConnectFlags flags);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_group_connect_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self, string detailed_signal, MentorLake.GObject.GCallback c_handler, IntPtr @object, MentorLake.GObject.GConnectFlags flags);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_group_connect_swapped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self, string detailed_signal, MentorLake.GObject.GCallback c_handler, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_signal_group_dup_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_group_set_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle target);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_signal_group_unblock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalGroupHandle>))] MentorLake.GObject.GSignalGroupHandle self);

}
