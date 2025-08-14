namespace MentorLake.Vulkan;


public class VkSurfacePresentModeCompatibilityEXTHandle : BaseSafeHandle
{
}


public static class VkSurfacePresentModeCompatibilityEXTExtensions
{

	public static VkSurfacePresentModeCompatibilityEXT Dereference(this VkSurfacePresentModeCompatibilityEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSurfacePresentModeCompatibilityEXT>(x.DangerousGetHandle());
}
internal class VkSurfacePresentModeCompatibilityEXTExterns
{
}


public struct VkSurfacePresentModeCompatibilityEXT
{
}
