namespace MentorLake.Vulkan;


public class VkSurfacePresentModeEXTHandle : BaseSafeHandle
{
}


public static class VkSurfacePresentModeEXTExtensions
{

	public static VkSurfacePresentModeEXT Dereference(this VkSurfacePresentModeEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSurfacePresentModeEXT>(x.DangerousGetHandle());
}
internal class VkSurfacePresentModeEXTExterns
{
}


public struct VkSurfacePresentModeEXT
{
}
