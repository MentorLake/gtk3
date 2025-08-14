namespace MentorLake.Vulkan;


public class VkImageAlignmentControlCreateInfoMESAHandle : BaseSafeHandle
{
}


public static class VkImageAlignmentControlCreateInfoMESAExtensions
{

	public static VkImageAlignmentControlCreateInfoMESA Dereference(this VkImageAlignmentControlCreateInfoMESAHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageAlignmentControlCreateInfoMESA>(x.DangerousGetHandle());
}
internal class VkImageAlignmentControlCreateInfoMESAExterns
{
}


public struct VkImageAlignmentControlCreateInfoMESA
{
}
