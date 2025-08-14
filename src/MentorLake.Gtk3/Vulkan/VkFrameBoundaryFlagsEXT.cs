namespace MentorLake.Vulkan;


public class VkFrameBoundaryFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkFrameBoundaryFlagsEXTExtensions
{

	public static VkFrameBoundaryFlagsEXT Dereference(this VkFrameBoundaryFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFrameBoundaryFlagsEXT>(x.DangerousGetHandle());
}
internal class VkFrameBoundaryFlagsEXTExterns
{
}


public struct VkFrameBoundaryFlagsEXT
{
}
