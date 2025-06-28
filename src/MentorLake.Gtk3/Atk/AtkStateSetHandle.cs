namespace MentorLake.Atk;

public class AtkStateSetHandle : GObjectHandle
{
	public static MentorLake.Atk.AtkStateSetHandle New()
	{
		return AtkStateSetHandleExterns.atk_state_set_new();
	}

}

public static class AtkStateSetHandleExtensions
{
	public static bool AddState(this MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateType type)
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkStateSetHandle)");
		return AtkStateSetHandleExterns.atk_state_set_add_state(set, type);
	}

	public static T AddStates<T>(this T set, MentorLake.Atk.AtkStateType[] types, int n_types) where T : AtkStateSetHandle
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkStateSetHandle)");
		AtkStateSetHandleExterns.atk_state_set_add_states(set, types, n_types);
		return set;
	}

	public static MentorLake.Atk.AtkStateSetHandle AndSets(this MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateSetHandle compare_set)
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkStateSetHandle)");
		return AtkStateSetHandleExterns.atk_state_set_and_sets(set, compare_set);
	}

	public static T ClearStates<T>(this T set) where T : AtkStateSetHandle
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkStateSetHandle)");
		AtkStateSetHandleExterns.atk_state_set_clear_states(set);
		return set;
	}

	public static bool ContainsState(this MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateType type)
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkStateSetHandle)");
		return AtkStateSetHandleExterns.atk_state_set_contains_state(set, type);
	}

	public static bool ContainsStates(this MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateType[] types, int n_types)
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkStateSetHandle)");
		return AtkStateSetHandleExterns.atk_state_set_contains_states(set, types, n_types);
	}

	public static bool IsEmpty(this MentorLake.Atk.AtkStateSetHandle set)
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkStateSetHandle)");
		return AtkStateSetHandleExterns.atk_state_set_is_empty(set);
	}

	public static MentorLake.Atk.AtkStateSetHandle OrSets(this MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateSetHandle compare_set)
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkStateSetHandle)");
		return AtkStateSetHandleExterns.atk_state_set_or_sets(set, compare_set);
	}

	public static bool RemoveState(this MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateType type)
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkStateSetHandle)");
		return AtkStateSetHandleExterns.atk_state_set_remove_state(set, type);
	}

	public static MentorLake.Atk.AtkStateSetHandle XorSets(this MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateSetHandle compare_set)
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkStateSetHandle)");
		return AtkStateSetHandleExterns.atk_state_set_xor_sets(set, compare_set);
	}

}

internal class AtkStateSetHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))]
	internal static extern MentorLake.Atk.AtkStateSetHandle atk_state_set_new();

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_state_set_add_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateType type);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_state_set_add_states([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateType[] types, int n_types);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))]
	internal static extern MentorLake.Atk.AtkStateSetHandle atk_state_set_and_sets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle compare_set);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_state_set_clear_states([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle set);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_state_set_contains_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateType type);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_state_set_contains_states([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateType[] types, int n_types);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_state_set_is_empty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle set);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))]
	internal static extern MentorLake.Atk.AtkStateSetHandle atk_state_set_or_sets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle compare_set);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_state_set_remove_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateType type);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))]
	internal static extern MentorLake.Atk.AtkStateSetHandle atk_state_set_xor_sets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle compare_set);

}
