namespace MentorLake.Atk;

/// <summary>
/// <para>
/// Container for AtkPlug objects from other processes
/// </para>
/// <para>
/// Together with #AtkPlug, #AtkSocket provides the ability to embed
/// accessibles from one process into another in a fashion that is
/// transparent to assistive technologies. #AtkSocket works as the
/// container of #AtkPlug, embedding it using the method
/// atk_socket_embed(). Any accessible contained in the #AtkPlug will
/// appear to the assistive technologies as being inside the
/// application that created the #AtkSocket.
/// </para>
/// <para>
/// The communication between a #AtkSocket and a #AtkPlug is done by
/// the IPC layer of the accessibility framework, normally implemented
/// by the D-Bus based implementation of AT-SPI (at-spi2). If that is
/// the case, at-spi-atk2 is the responsible to implement the abstract
/// methods atk_plug_get_id() and atk_socket_embed(), so an ATK
/// implementor shouldn&apos;t reimplement them. The process that contains
/// the #AtkPlug is responsible to send the ID returned by
/// atk_plug_id() to the process that contains the #AtkSocket, so it
/// could call the method atk_socket_embed() in order to embed it.
/// </para>
/// <para>
/// For the same reasons, an implementor doesn&apos;t need to implement
/// atk_object_get_n_accessible_children() and
/// atk_object_ref_accessible_child(). All the logic related to those
/// functions will be implemented by the IPC layer.
/// </para>
/// <para>
/// See [class@AtkPlug]
/// </para>
/// </summary>

public class AtkSocketHandle : AtkObjectHandle, AtkComponentHandle
{
/// <summary>
/// <para>
/// Creates a new #AtkSocket.
/// </para>
/// </summary>

/// <return>
/// the newly created #AtkSocket instance
/// </return>

	public static MentorLake.Atk.AtkSocketHandle New()
	{
		return AtkSocketHandleExterns.atk_socket_new();
	}

}
public static class AtkSocketHandleSignalExtensions
{
/// <summary>
/// <para>
/// The &apos;bounds-changed&quot; signal is emitted when the position or
/// size of the component changes.
/// </para>
/// </summary>

	public static IObservable<AtkSocketHandleSignalStructs.BoundsChangedSignal> Signal_BoundsChanged(this AtkSocketHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkSocketHandleSignalStructs.BoundsChangedSignal> obs) =>
		{
			AtkSocketHandleSignalDelegates.bounds_changed handler = ( MentorLake.Atk.AtkComponentHandle self,  MentorLake.Atk.AtkRectangleHandle arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkSocketHandleSignalStructs.BoundsChangedSignal()
				{
					Self = self, Arg1 = arg1, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "bounds-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class AtkSocketHandleSignalStructs
{

public class BoundsChangedSignal
{

	public MentorLake.Atk.AtkComponentHandle Self;
/// <summary>
/// <para>
/// The AtkRectangle giving the new position and size.
/// </para>
/// </summary>

	public MentorLake.Atk.AtkRectangleHandle Arg1;

	public IntPtr UserData;
}
}

public static class AtkSocketHandleSignalDelegates
{

/// <summary>
/// <para>
/// The &apos;bounds-changed&quot; signal is emitted when the position or
/// size of the component changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// The AtkRectangle giving the new position and size.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void bounds_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRectangleHandle>))] MentorLake.Atk.AtkRectangleHandle arg1, IntPtr user_data);

}


public static class AtkSocketHandleExtensions
{
/// <summary>
/// <para>
/// Embeds the children of an #AtkPlug as the children of the
/// #AtkSocket. The plug may be in the same process or in a different
/// process.
/// </para>
/// <para>
/// The class item used by this function should be filled in by the IPC
/// layer (usually at-spi2-atk). The implementor of the AtkSocket
/// should call this function and pass the id for the plug as returned
/// by atk_plug_get_id().  It is the responsibility of the application
/// to pass the plug id on to the process implementing the #AtkSocket
/// as needed.
/// </para>
/// </summary>

/// <param name="obj">
/// an #AtkSocket
/// </param>
/// <param name="plug_id">
/// the ID of an #AtkPlug
/// </param>

	public static T Embed<T>(this T obj, string plug_id) where T : AtkSocketHandle
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkSocketHandle)");
		AtkSocketHandleExterns.atk_socket_embed(obj, plug_id);
		return obj;
	}

/// <summary>
/// <para>
/// Determines whether or not the socket has an embedded plug.
/// </para>
/// </summary>

/// <param name="obj">
/// an #AtkSocket
/// </param>
/// <return>
/// TRUE if a plug is embedded in the socket
/// </return>

	public static bool IsOccupied(this MentorLake.Atk.AtkSocketHandle obj)
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkSocketHandle)");
		return AtkSocketHandleExterns.atk_socket_is_occupied(obj);
	}

}

internal class AtkSocketHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Atk.AtkSocketHandle>))]
	internal static extern MentorLake.Atk.AtkSocketHandle atk_socket_new();

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_socket_embed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkSocketHandle>))] MentorLake.Atk.AtkSocketHandle obj, string plug_id);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_socket_is_occupied([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkSocketHandle>))] MentorLake.Atk.AtkSocketHandle obj);

}
