namespace MentorLake.Vulkan;


public class VkChromaLocationKHRHandle : BaseSafeHandle
{
}


public static class VkChromaLocationKHRExtensions
{

	public static VkChromaLocationKHR Dereference(this VkChromaLocationKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkChromaLocationKHR>(x.DangerousGetHandle());
}
internal class VkChromaLocationKHRExterns
{
}


public struct VkChromaLocationKHR
{
}
