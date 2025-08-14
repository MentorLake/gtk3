namespace MentorLake.Vulkan;


public class VkHeadlessSurfaceCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkHeadlessSurfaceCreateInfoEXTExtensions
{

	public static VkHeadlessSurfaceCreateInfoEXT Dereference(this VkHeadlessSurfaceCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkHeadlessSurfaceCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkHeadlessSurfaceCreateInfoEXTExterns
{
}


public struct VkHeadlessSurfaceCreateInfoEXT
{
}
