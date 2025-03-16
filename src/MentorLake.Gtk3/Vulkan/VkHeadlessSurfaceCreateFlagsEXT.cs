namespace MentorLake.Vulkan;

public class VkHeadlessSurfaceCreateFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkHeadlessSurfaceCreateFlagsEXTExtensions
{

	public static VkHeadlessSurfaceCreateFlagsEXT Dereference(this VkHeadlessSurfaceCreateFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkHeadlessSurfaceCreateFlagsEXT>(x.DangerousGetHandle());
}
internal class VkHeadlessSurfaceCreateFlagsEXTExterns
{
}

public struct VkHeadlessSurfaceCreateFlagsEXT
{
}
