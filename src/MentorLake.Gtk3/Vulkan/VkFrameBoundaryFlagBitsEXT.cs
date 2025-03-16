namespace MentorLake.Vulkan;

public class VkFrameBoundaryFlagBitsEXTHandle : BaseSafeHandle
{
}


public static class VkFrameBoundaryFlagBitsEXTExtensions
{

	public static VkFrameBoundaryFlagBitsEXT Dereference(this VkFrameBoundaryFlagBitsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFrameBoundaryFlagBitsEXT>(x.DangerousGetHandle());
}
internal class VkFrameBoundaryFlagBitsEXTExterns
{
}

public struct VkFrameBoundaryFlagBitsEXT
{
}
