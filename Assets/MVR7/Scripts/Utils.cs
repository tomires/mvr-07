using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

public static class Utils 
{
    //https://gist.github.com/mattyellen/d63f1f557d08f7254345bff77bfdc8b3
    public static TaskAwaiter GetAwaiter(this AsyncOperation asyncOp)
    {
        TaskCompletionSource<object> tcs = new TaskCompletionSource<object>();
        asyncOp.completed += obj => { tcs.SetResult(null); };
        return ((Task)tcs.Task).GetAwaiter();
    }
}
