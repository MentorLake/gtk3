namespace MentorLake.Atk;

public class AtkRelationSetHandle : GObjectHandle
{
	public static MentorLake.Atk.AtkRelationSetHandle New()
	{
		return AtkRelationSetHandleExterns.atk_relation_set_new();
	}

}

public static class AtkRelationSetHandleExtensions
{
	public static T Add<T>(this T set, MentorLake.Atk.AtkRelationHandle relation) where T : AtkRelationSetHandle
	{
		AtkRelationSetHandleExterns.atk_relation_set_add(set, relation);
		return set;
	}

	public static T AddRelationByType<T>(this T set, MentorLake.Atk.AtkRelationType relationship, MentorLake.Atk.AtkObjectHandle target) where T : AtkRelationSetHandle
	{
		AtkRelationSetHandleExterns.atk_relation_set_add_relation_by_type(set, relationship, target);
		return set;
	}

	public static bool Contains(this MentorLake.Atk.AtkRelationSetHandle set, MentorLake.Atk.AtkRelationType relationship)
	{
		return AtkRelationSetHandleExterns.atk_relation_set_contains(set, relationship);
	}

	public static bool ContainsTarget(this MentorLake.Atk.AtkRelationSetHandle set, MentorLake.Atk.AtkRelationType relationship, MentorLake.Atk.AtkObjectHandle target)
	{
		return AtkRelationSetHandleExterns.atk_relation_set_contains_target(set, relationship, target);
	}

	public static int GetNRelations(this MentorLake.Atk.AtkRelationSetHandle set)
	{
		return AtkRelationSetHandleExterns.atk_relation_set_get_n_relations(set);
	}

	public static MentorLake.Atk.AtkRelationHandle GetRelation(this MentorLake.Atk.AtkRelationSetHandle set, int i)
	{
		return AtkRelationSetHandleExterns.atk_relation_set_get_relation(set, i);
	}

	public static MentorLake.Atk.AtkRelationHandle GetRelationByType(this MentorLake.Atk.AtkRelationSetHandle set, MentorLake.Atk.AtkRelationType relationship)
	{
		return AtkRelationSetHandleExterns.atk_relation_set_get_relation_by_type(set, relationship);
	}

	public static T Remove<T>(this T set, MentorLake.Atk.AtkRelationHandle relation) where T : AtkRelationSetHandle
	{
		AtkRelationSetHandleExterns.atk_relation_set_remove(set, relation);
		return set;
	}

}

internal class AtkRelationSetHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkRelationSetHandle atk_relation_set_new();

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_relation_set_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationSetHandle>))] MentorLake.Atk.AtkRelationSetHandle set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationHandle>))] MentorLake.Atk.AtkRelationHandle relation);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_relation_set_add_relation_by_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationSetHandle>))] MentorLake.Atk.AtkRelationSetHandle set, MentorLake.Atk.AtkRelationType relationship, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle target);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_relation_set_contains([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationSetHandle>))] MentorLake.Atk.AtkRelationSetHandle set, MentorLake.Atk.AtkRelationType relationship);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_relation_set_contains_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationSetHandle>))] MentorLake.Atk.AtkRelationSetHandle set, MentorLake.Atk.AtkRelationType relationship, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle target);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_relation_set_get_n_relations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationSetHandle>))] MentorLake.Atk.AtkRelationSetHandle set);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkRelationHandle atk_relation_set_get_relation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationSetHandle>))] MentorLake.Atk.AtkRelationSetHandle set, int i);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkRelationHandle atk_relation_set_get_relation_by_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationSetHandle>))] MentorLake.Atk.AtkRelationSetHandle set, MentorLake.Atk.AtkRelationType relationship);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_relation_set_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationSetHandle>))] MentorLake.Atk.AtkRelationSetHandle set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationHandle>))] MentorLake.Atk.AtkRelationHandle relation);

}
