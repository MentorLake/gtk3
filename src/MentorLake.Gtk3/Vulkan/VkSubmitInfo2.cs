namespace MentorLake.Vulkan;


public class VkSubmitInfo2Handle : BaseSafeHandle
{
}


public static class VkSubmitInfo2Extensions
{

	public static VkSubmitInfo2 Dereference(this VkSubmitInfo2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubmitInfo2>(x.DangerousGetHandle());
}
internal class VkSubmitInfo2Externs
{
}


public struct VkSubmitInfo2
{
}
