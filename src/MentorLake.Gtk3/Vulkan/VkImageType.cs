namespace MentorLake.Vulkan;

public class VkImageTypeHandle : BaseSafeHandle
{
}


public static class VkImageTypeExtensions
{

	public static VkImageType Dereference(this VkImageTypeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageType>(x.DangerousGetHandle());
}
internal class VkImageTypeExterns
{
}

public struct VkImageType
{
}
