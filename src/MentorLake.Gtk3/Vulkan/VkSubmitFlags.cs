namespace MentorLake.Vulkan;


public class VkSubmitFlagsHandle : BaseSafeHandle
{
}


public static class VkSubmitFlagsExtensions
{

	public static VkSubmitFlags Dereference(this VkSubmitFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubmitFlags>(x.DangerousGetHandle());
}
internal class VkSubmitFlagsExterns
{
}


public struct VkSubmitFlags
{
}
