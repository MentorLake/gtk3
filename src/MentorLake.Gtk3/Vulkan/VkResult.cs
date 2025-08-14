namespace MentorLake.Vulkan;


public class VkResultHandle : BaseSafeHandle
{
}


public static class VkResultExtensions
{

	public static VkResult Dereference(this VkResultHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkResult>(x.DangerousGetHandle());
}
internal class VkResultExterns
{
}


public struct VkResult
{
}
