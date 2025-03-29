namespace MentorLake.Atk;

public class AtkRelationHandle : GObjectHandle
{
	public static MentorLake.Atk.AtkRelationHandle New(MentorLake.Atk.AtkObjectHandle[] targets, int n_targets, MentorLake.Atk.AtkRelationType relationship)
	{
		return AtkRelationHandleExterns.atk_relation_new(targets, n_targets, relationship);
	}

}

public static class AtkRelationHandleExtensions
{
	public static T AddTarget<T>(this T relation, MentorLake.Atk.AtkObjectHandle target) where T : AtkRelationHandle
	{
		if (relation.IsInvalid || relation.IsClosed) throw new Exception("Invalid or closed handle (AtkRelationHandle)");
		AtkRelationHandleExterns.atk_relation_add_target(relation, target);
		return relation;
	}

	public static MentorLake.Atk.AtkRelationType GetRelationType(this MentorLake.Atk.AtkRelationHandle relation)
	{
		if (relation.IsInvalid || relation.IsClosed) throw new Exception("Invalid or closed handle (AtkRelationHandle)");
		return AtkRelationHandleExterns.atk_relation_get_relation_type(relation);
	}

	public static MentorLake.GLib.GPtrArrayHandle GetTarget(this MentorLake.Atk.AtkRelationHandle relation)
	{
		if (relation.IsInvalid || relation.IsClosed) throw new Exception("Invalid or closed handle (AtkRelationHandle)");
		return AtkRelationHandleExterns.atk_relation_get_target(relation);
	}

	public static bool RemoveTarget(this MentorLake.Atk.AtkRelationHandle relation, MentorLake.Atk.AtkObjectHandle target)
	{
		if (relation.IsInvalid || relation.IsClosed) throw new Exception("Invalid or closed handle (AtkRelationHandle)");
		return AtkRelationHandleExterns.atk_relation_remove_target(relation, target);
	}

}

internal class AtkRelationHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkRelationHandle atk_relation_new([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle[] targets, int n_targets, MentorLake.Atk.AtkRelationType relationship);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_relation_add_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationHandle>))] MentorLake.Atk.AtkRelationHandle relation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle target);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkRelationType atk_relation_get_relation_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationHandle>))] MentorLake.Atk.AtkRelationHandle relation);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle atk_relation_get_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationHandle>))] MentorLake.Atk.AtkRelationHandle relation);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_relation_remove_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationHandle>))] MentorLake.Atk.AtkRelationHandle relation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle target);

}
