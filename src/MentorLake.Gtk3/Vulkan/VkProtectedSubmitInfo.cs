namespace MentorLake.Vulkan;


public class VkProtectedSubmitInfoHandle : BaseSafeHandle
{
}


public static class VkProtectedSubmitInfoExtensions
{

	public static VkProtectedSubmitInfo Dereference(this VkProtectedSubmitInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkProtectedSubmitInfo>(x.DangerousGetHandle());
}
internal class VkProtectedSubmitInfoExterns
{
}


public struct VkProtectedSubmitInfo
{
}
