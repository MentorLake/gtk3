namespace MentorLake.Vulkan;


public class VkComponentSwizzleHandle : BaseSafeHandle
{
}


public static class VkComponentSwizzleExtensions
{

	public static VkComponentSwizzle Dereference(this VkComponentSwizzleHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkComponentSwizzle>(x.DangerousGetHandle());
}
internal class VkComponentSwizzleExterns
{
}


public struct VkComponentSwizzle
{
}
