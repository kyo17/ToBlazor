using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace ToBlazor.Services
{
    public static class JsService
    {
        public static async Task showMessage(this IJSRuntime js, string title, string message, typesSwal swal)
        {
             await js.InvokeVoidAsync("Swal.fire", title, message, swal.ToString());
        }

        public async static Task<bool> deleteSwal(this IJSRuntime js, string title, string message,
            typesSwal swal)
        {
            return await js.InvokeAsync<bool>("deleteJs", title, message, swal.ToString());
        }
        public enum typesSwal
        {
            error, success, warning, question, info
        }
    }
}
