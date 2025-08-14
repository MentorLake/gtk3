namespace MentorLake.Vulkan;


public class VkBaseInStructureHandle : BaseSafeHandle
{
}


public static class VkBaseInStructureExtensions
{

	public static VkBaseInStructure Dereference(this VkBaseInStructureHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBaseInStructure>(x.DangerousGetHandle());
}
internal class VkBaseInStructureExterns
{
}


public struct VkBaseInStructure
{
}
