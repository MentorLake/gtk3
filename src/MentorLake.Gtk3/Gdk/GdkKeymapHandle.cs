namespace MentorLake.Gdk;

public class GdkKeymapHandle : GObjectHandle
{
	public static MentorLake.Gdk.GdkKeymapHandle GetDefault()
	{
		return GdkKeymapHandleExterns.gdk_keymap_get_default();
	}

	public static MentorLake.Gdk.GdkKeymapHandle GetForDisplay(MentorLake.Gdk.GdkDisplayHandle display)
	{
		return GdkKeymapHandleExterns.gdk_keymap_get_for_display(display);
	}

}
public static class GdkKeymapHandleSignalExtensions
{

	public static IObservable<GdkKeymapHandleSignalStructs.DirectionChangedSignal> Signal_DirectionChanged(this GdkKeymapHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkKeymapHandleSignalStructs.DirectionChangedSignal> obs) =>
		{
			GdkKeymapHandleSignalDelegates.direction_changed handler = ( MentorLake.Gdk.GdkKeymapHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkKeymapHandleSignalStructs.DirectionChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "direction-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GdkKeymapHandleSignalStructs.KeysChangedSignal> Signal_KeysChanged(this GdkKeymapHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkKeymapHandleSignalStructs.KeysChangedSignal> obs) =>
		{
			GdkKeymapHandleSignalDelegates.keys_changed handler = ( MentorLake.Gdk.GdkKeymapHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkKeymapHandleSignalStructs.KeysChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "keys-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GdkKeymapHandleSignalStructs.StateChangedSignal> Signal_StateChanged(this GdkKeymapHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkKeymapHandleSignalStructs.StateChangedSignal> obs) =>
		{
			GdkKeymapHandleSignalDelegates.state_changed handler = ( MentorLake.Gdk.GdkKeymapHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkKeymapHandleSignalStructs.StateChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "state-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GdkKeymapHandleSignalStructs
{

public struct DirectionChangedSignal
{
	public MentorLake.Gdk.GdkKeymapHandle Self;
	public IntPtr UserData;
}

public struct KeysChangedSignal
{
	public MentorLake.Gdk.GdkKeymapHandle Self;
	public IntPtr UserData;
}

public struct StateChangedSignal
{
	public MentorLake.Gdk.GdkKeymapHandle Self;
	public IntPtr UserData;
}
}

public static class GdkKeymapHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void direction_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void keys_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void state_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle self, IntPtr user_data);

}


public static class GdkKeymapHandleExtensions
{
	public static T AddVirtualModifiers<T>(this T keymap, ref MentorLake.Gdk.GdkModifierType state) where T : GdkKeymapHandle
	{
		if (keymap.IsInvalid || keymap.IsClosed) throw new Exception("Invalid or closed handle (GdkKeymapHandle)");
		GdkKeymapHandleExterns.gdk_keymap_add_virtual_modifiers(keymap, ref state);
		return keymap;
	}

	public static bool GetCapsLockState(this MentorLake.Gdk.GdkKeymapHandle keymap)
	{
		if (keymap.IsInvalid || keymap.IsClosed) throw new Exception("Invalid or closed handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_get_caps_lock_state(keymap);
	}

	public static MentorLake.Pango.PangoDirection GetDirection(this MentorLake.Gdk.GdkKeymapHandle keymap)
	{
		if (keymap.IsInvalid || keymap.IsClosed) throw new Exception("Invalid or closed handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_get_direction(keymap);
	}

	public static bool GetEntriesForKeycode(this MentorLake.Gdk.GdkKeymapHandle keymap, uint hardware_keycode, out MentorLake.Gdk.GdkKeymapKey[] keys, out uint[] keyvals, out int n_entries)
	{
		if (keymap.IsInvalid || keymap.IsClosed) throw new Exception("Invalid or closed handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_get_entries_for_keycode(keymap, hardware_keycode, out keys, out keyvals, out n_entries);
	}

	public static bool GetEntriesForKeyval(this MentorLake.Gdk.GdkKeymapHandle keymap, uint keyval, out MentorLake.Gdk.GdkKeymapKey[] keys, out int n_keys)
	{
		if (keymap.IsInvalid || keymap.IsClosed) throw new Exception("Invalid or closed handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_get_entries_for_keyval(keymap, keyval, out keys, out n_keys);
	}

	public static MentorLake.Gdk.GdkModifierType GetModifierMask(this MentorLake.Gdk.GdkKeymapHandle keymap, MentorLake.Gdk.GdkModifierIntent intent)
	{
		if (keymap.IsInvalid || keymap.IsClosed) throw new Exception("Invalid or closed handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_get_modifier_mask(keymap, intent);
	}

	public static uint GetModifierState(this MentorLake.Gdk.GdkKeymapHandle keymap)
	{
		if (keymap.IsInvalid || keymap.IsClosed) throw new Exception("Invalid or closed handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_get_modifier_state(keymap);
	}

	public static bool GetNumLockState(this MentorLake.Gdk.GdkKeymapHandle keymap)
	{
		if (keymap.IsInvalid || keymap.IsClosed) throw new Exception("Invalid or closed handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_get_num_lock_state(keymap);
	}

	public static bool GetScrollLockState(this MentorLake.Gdk.GdkKeymapHandle keymap)
	{
		if (keymap.IsInvalid || keymap.IsClosed) throw new Exception("Invalid or closed handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_get_scroll_lock_state(keymap);
	}

	public static bool HaveBidiLayouts(this MentorLake.Gdk.GdkKeymapHandle keymap)
	{
		if (keymap.IsInvalid || keymap.IsClosed) throw new Exception("Invalid or closed handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_have_bidi_layouts(keymap);
	}

	public static uint LookupKey(this MentorLake.Gdk.GdkKeymapHandle keymap, MentorLake.Gdk.GdkKeymapKeyHandle key)
	{
		if (keymap.IsInvalid || keymap.IsClosed) throw new Exception("Invalid or closed handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_lookup_key(keymap, key);
	}

	public static bool MapVirtualModifiers(this MentorLake.Gdk.GdkKeymapHandle keymap, ref MentorLake.Gdk.GdkModifierType state)
	{
		if (keymap.IsInvalid || keymap.IsClosed) throw new Exception("Invalid or closed handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_map_virtual_modifiers(keymap, ref state);
	}

	public static bool TranslateKeyboardState(this MentorLake.Gdk.GdkKeymapHandle keymap, uint hardware_keycode, MentorLake.Gdk.GdkModifierType state, int group, out uint keyval, out int effective_group, out int level, out MentorLake.Gdk.GdkModifierType consumed_modifiers)
	{
		if (keymap.IsInvalid || keymap.IsClosed) throw new Exception("Invalid or closed handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_translate_keyboard_state(keymap, hardware_keycode, state, group, out keyval, out effective_group, out level, out consumed_modifiers);
	}

}

internal class GdkKeymapHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_keymap_add_virtual_modifiers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap, ref MentorLake.Gdk.GdkModifierType state);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_keymap_get_caps_lock_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoDirection gdk_keymap_get_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_keymap_get_entries_for_keycode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap, uint hardware_keycode, out MentorLake.Gdk.GdkKeymapKey[] keys, out uint[] keyvals, out int n_entries);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_keymap_get_entries_for_keyval([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap, uint keyval, out MentorLake.Gdk.GdkKeymapKey[] keys, out int n_keys);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkModifierType gdk_keymap_get_modifier_mask([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap, MentorLake.Gdk.GdkModifierIntent intent);

	[DllImport(GdkLibrary.Name)]
	internal static extern uint gdk_keymap_get_modifier_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_keymap_get_num_lock_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_keymap_get_scroll_lock_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_keymap_have_bidi_layouts([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap);

	[DllImport(GdkLibrary.Name)]
	internal static extern uint gdk_keymap_lookup_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapKeyHandle>))] MentorLake.Gdk.GdkKeymapKeyHandle key);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_keymap_map_virtual_modifiers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap, ref MentorLake.Gdk.GdkModifierType state);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_keymap_translate_keyboard_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap, uint hardware_keycode, MentorLake.Gdk.GdkModifierType state, int group, out uint keyval, out int effective_group, out int level, out MentorLake.Gdk.GdkModifierType consumed_modifiers);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkKeymapHandle gdk_keymap_get_default();

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkKeymapHandle gdk_keymap_get_for_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

}
