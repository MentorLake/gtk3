namespace MentorLake.Graphene;

public class graphene_size_tHandle : BaseSafeHandle
{
	public static MentorLake.Graphene.graphene_size_tHandle Alloc()
	{
		return graphene_size_tExterns.graphene_size_alloc();
	}

}


public static class graphene_size_tExtensions
{
	public static bool Equal(this MentorLake.Graphene.graphene_size_tHandle a, MentorLake.Graphene.graphene_size_tHandle b)
	{
		if (a.IsInvalid || a.IsClosed) throw new Exception("Invalid or closed handle (graphene_size_t)");
		return graphene_size_tExterns.graphene_size_equal(a, b);
	}

	public static void Free(this MentorLake.Graphene.graphene_size_tHandle s)
	{
		if (s.IsInvalid || s.IsClosed) throw new Exception("Invalid or closed handle (graphene_size_t)");
		graphene_size_tExterns.graphene_size_free(s);
	}

	public static MentorLake.Graphene.graphene_size_tHandle Init(this MentorLake.Graphene.graphene_size_tHandle s, float width, float height)
	{
		if (s.IsInvalid || s.IsClosed) throw new Exception("Invalid or closed handle (graphene_size_t)");
		return graphene_size_tExterns.graphene_size_init(s, width, height);
	}

	public static MentorLake.Graphene.graphene_size_tHandle InitFromSize(this MentorLake.Graphene.graphene_size_tHandle s, MentorLake.Graphene.graphene_size_tHandle src)
	{
		if (s.IsInvalid || s.IsClosed) throw new Exception("Invalid or closed handle (graphene_size_t)");
		return graphene_size_tExterns.graphene_size_init_from_size(s, src);
	}

	public static void Interpolate(this MentorLake.Graphene.graphene_size_tHandle a, MentorLake.Graphene.graphene_size_tHandle b, double factor, out MentorLake.Graphene.graphene_size_t res)
	{
		if (a.IsInvalid || a.IsClosed) throw new Exception("Invalid or closed handle (graphene_size_t)");
		graphene_size_tExterns.graphene_size_interpolate(a, b, factor, out res);
	}

	public static void Scale(this MentorLake.Graphene.graphene_size_tHandle s, float factor, out MentorLake.Graphene.graphene_size_t res)
	{
		if (s.IsInvalid || s.IsClosed) throw new Exception("Invalid or closed handle (graphene_size_t)");
		graphene_size_tExterns.graphene_size_scale(s, factor, out res);
	}


	public static graphene_size_t Dereference(this graphene_size_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_size_t>(x.DangerousGetHandle());
}
internal class graphene_size_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_size_tHandle graphene_size_alloc();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_size_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))] MentorLake.Graphene.graphene_size_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))] MentorLake.Graphene.graphene_size_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_size_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))] MentorLake.Graphene.graphene_size_tHandle s);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_size_tHandle graphene_size_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))] MentorLake.Graphene.graphene_size_tHandle s, float width, float height);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_size_tHandle graphene_size_init_from_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))] MentorLake.Graphene.graphene_size_tHandle s, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))] MentorLake.Graphene.graphene_size_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_size_interpolate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))] MentorLake.Graphene.graphene_size_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))] MentorLake.Graphene.graphene_size_tHandle b, double factor, out MentorLake.Graphene.graphene_size_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_size_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))] MentorLake.Graphene.graphene_size_tHandle s, float factor, out MentorLake.Graphene.graphene_size_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_size_tHandle graphene_size_zero();

}

public struct graphene_size_t
{
	public float width;
	public float height;
	public static MentorLake.Graphene.graphene_size_tHandle Zero()
	{
		return graphene_size_tExterns.graphene_size_zero();
	}

}
