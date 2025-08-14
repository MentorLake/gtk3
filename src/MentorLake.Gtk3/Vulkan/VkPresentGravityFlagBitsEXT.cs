namespace MentorLake.Vulkan;


public class VkPresentGravityFlagBitsEXTHandle : BaseSafeHandle
{
}


public static class VkPresentGravityFlagBitsEXTExtensions
{

	public static VkPresentGravityFlagBitsEXT Dereference(this VkPresentGravityFlagBitsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPresentGravityFlagBitsEXT>(x.DangerousGetHandle());
}
internal class VkPresentGravityFlagBitsEXTExterns
{
}


public struct VkPresentGravityFlagBitsEXT
{
}
