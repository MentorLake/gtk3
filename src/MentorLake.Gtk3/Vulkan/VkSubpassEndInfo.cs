namespace MentorLake.Vulkan;


public class VkSubpassEndInfoHandle : BaseSafeHandle
{
}


public static class VkSubpassEndInfoExtensions
{

	public static VkSubpassEndInfo Dereference(this VkSubpassEndInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubpassEndInfo>(x.DangerousGetHandle());
}
internal class VkSubpassEndInfoExterns
{
}


public struct VkSubpassEndInfo
{
}
