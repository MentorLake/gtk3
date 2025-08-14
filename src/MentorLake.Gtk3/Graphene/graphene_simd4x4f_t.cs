namespace MentorLake.Graphene;


public class graphene_simd4x4f_tHandle : BaseSafeHandle
{
}


public static class graphene_simd4x4f_tExtensions
{

	public static graphene_simd4x4f_t Dereference(this graphene_simd4x4f_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_simd4x4f_t>(x.DangerousGetHandle());
}
internal class graphene_simd4x4f_tExterns
{
}


public struct graphene_simd4x4f_t
{
}
