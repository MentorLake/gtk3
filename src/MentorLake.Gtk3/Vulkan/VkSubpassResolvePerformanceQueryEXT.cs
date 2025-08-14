namespace MentorLake.Vulkan;


public class VkSubpassResolvePerformanceQueryEXTHandle : BaseSafeHandle
{
}


public static class VkSubpassResolvePerformanceQueryEXTExtensions
{

	public static VkSubpassResolvePerformanceQueryEXT Dereference(this VkSubpassResolvePerformanceQueryEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubpassResolvePerformanceQueryEXT>(x.DangerousGetHandle());
}
internal class VkSubpassResolvePerformanceQueryEXTExterns
{
}


public struct VkSubpassResolvePerformanceQueryEXT
{
}
