namespace MentorLake.Vulkan;

public class VkFrameBoundaryEXTHandle : BaseSafeHandle
{
}


public static class VkFrameBoundaryEXTExtensions
{

	public static VkFrameBoundaryEXT Dereference(this VkFrameBoundaryEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFrameBoundaryEXT>(x.DangerousGetHandle());
}
internal class VkFrameBoundaryEXTExterns
{
}

public struct VkFrameBoundaryEXT
{
}
