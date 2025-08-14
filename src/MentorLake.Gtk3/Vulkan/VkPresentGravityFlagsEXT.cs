namespace MentorLake.Vulkan;


public class VkPresentGravityFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkPresentGravityFlagsEXTExtensions
{

	public static VkPresentGravityFlagsEXT Dereference(this VkPresentGravityFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPresentGravityFlagsEXT>(x.DangerousGetHandle());
}
internal class VkPresentGravityFlagsEXTExterns
{
}


public struct VkPresentGravityFlagsEXT
{
}
