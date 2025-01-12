namespace MentorLake.Gtk3.Gdk3;

public class GdkKeymapHandle : GObjectHandle
{
	public static GdkKeymapHandle GetDefault()
	{
		return GdkKeymapExterns.gdk_keymap_get_default();
	}

	public static GdkKeymapHandle GetForDisplay(GdkDisplayHandle display)
	{
		return GdkKeymapExterns.gdk_keymap_get_for_display(display);
	}

}

public static class GdkKeymapSignalExtensions
{

	public static IObservable<GdkKeymapSignalStructs.DirectionChangedSignal> Signal_DirectionChanged(this GdkKeymapHandle instance)
	{
		return Observable.Create((IObserver<GdkKeymapSignalStructs.DirectionChangedSignal> obs) =>
		{
			GdkKeymapSignalDelegates.direction_changed handler = (GdkKeymapHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkKeymapSignalStructs.DirectionChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "direction_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkKeymapSignalStructs.KeysChangedSignal> Signal_KeysChanged(this GdkKeymapHandle instance)
	{
		return Observable.Create((IObserver<GdkKeymapSignalStructs.KeysChangedSignal> obs) =>
		{
			GdkKeymapSignalDelegates.keys_changed handler = (GdkKeymapHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkKeymapSignalStructs.KeysChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "keys_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkKeymapSignalStructs.StateChangedSignal> Signal_StateChanged(this GdkKeymapHandle instance)
	{
		return Observable.Create((IObserver<GdkKeymapSignalStructs.StateChangedSignal> obs) =>
		{
			GdkKeymapSignalDelegates.state_changed handler = (GdkKeymapHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkKeymapSignalStructs.StateChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "state_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GdkKeymapSignalStructs
{

public struct DirectionChangedSignal
{
	public GdkKeymapHandle Self;
	public IntPtr UserData;
}

public struct KeysChangedSignal
{
	public GdkKeymapHandle Self;
	public IntPtr UserData;
}

public struct StateChangedSignal
{
	public GdkKeymapHandle Self;
	public IntPtr UserData;
}
}

public static class GdkKeymapSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void direction_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkKeymapHandle>))] GdkKeymapHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void keys_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkKeymapHandle>))] GdkKeymapHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void state_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkKeymapHandle>))] GdkKeymapHandle self, IntPtr user_data);

}


public static class GdkKeymapHandleExtensions
{
	public static GdkKeymapHandle AddVirtualModifiers(this GdkKeymapHandle keymap, ref GdkModifierType state)
	{
		GdkKeymapExterns.gdk_keymap_add_virtual_modifiers(keymap, ref state);
		return keymap;
	}

	public static bool GetCapsLockState(this GdkKeymapHandle keymap)
	{
		return GdkKeymapExterns.gdk_keymap_get_caps_lock_state(keymap);
	}

	public static PangoDirection GetDirection(this GdkKeymapHandle keymap)
	{
		return GdkKeymapExterns.gdk_keymap_get_direction(keymap);
	}

	public static bool GetEntriesForKeycode(this GdkKeymapHandle keymap, uint hardware_keycode, out GdkKeymapKey[] keys, out uint[] keyvals, out int n_entries)
	{
		return GdkKeymapExterns.gdk_keymap_get_entries_for_keycode(keymap, hardware_keycode, out keys, out keyvals, out n_entries);
	}

	public static bool GetEntriesForKeyval(this GdkKeymapHandle keymap, uint keyval, out GdkKeymapKey[] keys, out int n_keys)
	{
		return GdkKeymapExterns.gdk_keymap_get_entries_for_keyval(keymap, keyval, out keys, out n_keys);
	}

	public static GdkModifierType GetModifierMask(this GdkKeymapHandle keymap, GdkModifierIntent intent)
	{
		return GdkKeymapExterns.gdk_keymap_get_modifier_mask(keymap, intent);
	}

	public static uint GetModifierState(this GdkKeymapHandle keymap)
	{
		return GdkKeymapExterns.gdk_keymap_get_modifier_state(keymap);
	}

	public static bool GetNumLockState(this GdkKeymapHandle keymap)
	{
		return GdkKeymapExterns.gdk_keymap_get_num_lock_state(keymap);
	}

	public static bool GetScrollLockState(this GdkKeymapHandle keymap)
	{
		return GdkKeymapExterns.gdk_keymap_get_scroll_lock_state(keymap);
	}

	public static bool HaveBidiLayouts(this GdkKeymapHandle keymap)
	{
		return GdkKeymapExterns.gdk_keymap_have_bidi_layouts(keymap);
	}

	public static uint LookupKey(this GdkKeymapHandle keymap, GdkKeymapKeyHandle key)
	{
		return GdkKeymapExterns.gdk_keymap_lookup_key(keymap, key);
	}

	public static bool MapVirtualModifiers(this GdkKeymapHandle keymap, ref GdkModifierType state)
	{
		return GdkKeymapExterns.gdk_keymap_map_virtual_modifiers(keymap, ref state);
	}

	public static bool TranslateKeyboardState(this GdkKeymapHandle keymap, uint hardware_keycode, GdkModifierType state, int group, out uint keyval, out int effective_group, out int level, out GdkModifierType consumed_modifiers)
	{
		return GdkKeymapExterns.gdk_keymap_translate_keyboard_state(keymap, hardware_keycode, state, group, out keyval, out effective_group, out level, out consumed_modifiers);
	}

}

internal class GdkKeymapExterns
{
	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_keymap_add_virtual_modifiers(GdkKeymapHandle keymap, ref GdkModifierType state);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_keymap_get_caps_lock_state(GdkKeymapHandle keymap);

	[DllImport(Libraries.Gdk3)]
	internal static extern PangoDirection gdk_keymap_get_direction(GdkKeymapHandle keymap);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_keymap_get_entries_for_keycode(GdkKeymapHandle keymap, uint hardware_keycode, out GdkKeymapKey[] keys, out uint[] keyvals, out int n_entries);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_keymap_get_entries_for_keyval(GdkKeymapHandle keymap, uint keyval, out GdkKeymapKey[] keys, out int n_keys);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkModifierType gdk_keymap_get_modifier_mask(GdkKeymapHandle keymap, GdkModifierIntent intent);

	[DllImport(Libraries.Gdk3)]
	internal static extern uint gdk_keymap_get_modifier_state(GdkKeymapHandle keymap);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_keymap_get_num_lock_state(GdkKeymapHandle keymap);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_keymap_get_scroll_lock_state(GdkKeymapHandle keymap);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_keymap_have_bidi_layouts(GdkKeymapHandle keymap);

	[DllImport(Libraries.Gdk3)]
	internal static extern uint gdk_keymap_lookup_key(GdkKeymapHandle keymap, GdkKeymapKeyHandle key);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_keymap_map_virtual_modifiers(GdkKeymapHandle keymap, ref GdkModifierType state);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_keymap_translate_keyboard_state(GdkKeymapHandle keymap, uint hardware_keycode, GdkModifierType state, int group, out uint keyval, out int effective_group, out int level, out GdkModifierType consumed_modifiers);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkKeymapHandle gdk_keymap_get_default();

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkKeymapHandle gdk_keymap_get_for_display(GdkDisplayHandle display);

}
