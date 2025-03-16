namespace MentorLake.Vulkan;

public class VkIndexTypeHandle : BaseSafeHandle
{
}


public static class VkIndexTypeExtensions
{

	public static VkIndexType Dereference(this VkIndexTypeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkIndexType>(x.DangerousGetHandle());
}
internal class VkIndexTypeExterns
{
}

public struct VkIndexType
{
}
