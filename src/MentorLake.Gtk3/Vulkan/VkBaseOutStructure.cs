namespace MentorLake.Vulkan;

public class VkBaseOutStructureHandle : BaseSafeHandle
{
}


public static class VkBaseOutStructureExtensions
{

	public static VkBaseOutStructure Dereference(this VkBaseOutStructureHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBaseOutStructure>(x.DangerousGetHandle());
}
internal class VkBaseOutStructureExterns
{
}

public struct VkBaseOutStructure
{
}
