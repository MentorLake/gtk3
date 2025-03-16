namespace MentorLake.Vulkan;

public class VkSubpassBeginInfoHandle : BaseSafeHandle
{
}


public static class VkSubpassBeginInfoExtensions
{

	public static VkSubpassBeginInfo Dereference(this VkSubpassBeginInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubpassBeginInfo>(x.DangerousGetHandle());
}
internal class VkSubpassBeginInfoExterns
{
}

public struct VkSubpassBeginInfo
{
}
